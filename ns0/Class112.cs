// Decompiled with JetBrains decompiler
// Type: ns0.Class112
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using NusHelper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
  internal static class Class112
  {
    public static bool bool_0;
    private static volatile bool bool_1;

    private static bool smethod_0()
    {
      try
      {
        string str = System.IO.File.ReadAllText(Path.Combine(GClass88.CachePath, "lasttitles"));
        int num1 = 0;
        string[] separator = new string[1]{ Environment.NewLine };
        int num2 = 1;
        foreach (string id in str.Split(separator, (StringSplitOptions) num2))
        {
          if (!string.IsNullOrEmpty(id))
          {
            ++num1;
            TitleId titleId = new TitleId(id);
          }
        }
        if (num1 < 25)
          return false;
        return new DirectoryInfo(Path.Combine(Environment.GetEnvironmentVariable("LocalAppData"), "Hikari06")).EnumerateFiles("user.config", SearchOption.AllDirectories).Count<FileInfo>() > 1;
      }
      catch
      {
        return false;
      }
    }

    [STAThread]
    private static void Main(string[] args)
    {
      try
      {
        Class7.smethod_2();
        ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
      }
      catch
      {
      }
      if (string.IsNullOrEmpty(Settings.Default.AppId))
      {
        Settings.Default.AppId = Guid.NewGuid().ToString();
        Settings.Default.Save();
      }
      GClass88.smethod_13(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\USB_HELPER\\");
      Class108.smethod_1();
      AppDomain.CurrentDomain.UnhandledException += (UnhandledExceptionEventHandler) ((sender, e) =>
      {
        Class108.smethod_1();
        Exception exceptionObject = e.ExceptionObject as Exception;
        string str1 = "NONE";
        try
        {
          str1 = new ComputerInfo().OSFullName;
        }
        catch
        {
        }
        try
        {
          if (exceptionObject != null)
          {
            string str2 = "NONE";
            if (GClass28.gclass30_0 != null)
              str2 = GClass28.gclass30_0.TitleId.IdRaw + "v" + GClass28.gclass30_0.Version ?? "0";
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            string str3 = Class102.string_0 ?? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            GClass6.smethod_19(string.Format("{0}/postBug.php", (object) Class67.String_4), new NameValueCollection()
            {
              {
                "bug_target_site",
                exceptionObject.ToString()
              },
              {
                "bug_message",
                exceptionObject.Message
              },
              {
                "bug_stacktrace",
                exceptionObject.StackTrace
              },
              {
                "app_version",
                str3 ?? ""
              },
              {
                "os_revision",
                str1
              },
              {
                "data_path",
                Settings.Default.Path
              },
              {
                "extraction_path",
                Settings.Default.ExtractFolder ?? ""
              },
              {
                "last_unpacking_title",
                str2
              }
            });
            if (exceptionObject.Message.Contains("Nullable object must have a value."))
            {
              if (Class112.bool_1)
                return;
              Class112.bool_1 = true;
              System.Windows.Forms.Application.Restart();
              return;
            }
          }
        }
        catch
        {
        }
        if (exceptionObject is UnauthorizedAccessException)
        {
          int num1 = (int) new frmException().ShowDialog();
        }
        else if (exceptionObject is FileNotFoundException && exceptionObject.Message.Contains("Telerik"))
        {
          int num2 = (int) new frmDownloadDotNet().ShowDialog();
        }
        else
        {
          int num3 = (int) new frmUnhandledException(exceptionObject).ShowDialog();
        }
        GClass9.smethod_0();
        System.Windows.Forms.Application.Exit();
      });
      if (args.Length == 1)
        Class102.string_0 = args[0];
      if (!ApplicationDeployment.IsNetworkDeployed && Class102.string_0 == null)
      {
        int num = (int) RadMessageBox.Show("You cannot execute this application directly. Please use the default shortcut on your desktop or execute Updater.exe");
        System.Windows.Forms.Application.Exit();
      }
      else
      {
        foreach (string resourcePath in ((IEnumerable<string>) Assembly.GetExecutingAssembly().GetManifestResourceNames()).Where<string>((Func<string, bool>) (string_0 => Path.GetExtension(string_0) == ".tssp")))
          ThemeResolutionService.LoadPackageResource(resourcePath);
        System.Windows.Forms.Application.EnableVisualStyles();
        if (Settings.Default.ThemeName == "VisualStudio2012Dark")
          Settings.Default.ThemeName = "DarkBlue";
        if (Settings.Default.ThemeName == "VisualStudio2012Light")
          Settings.Default.ThemeName = "Light";
        Settings.Default.Save();
        ThemeResolutionService.ApplicationThemeName = Settings.Default.ThemeName;
        if (Settings.Default.LaunchCount == 0 && !Class112.smethod_0())
        {
          int num = (int) new frmSupportOver().ShowDialog();
          System.Windows.Forms.Application.Exit();
          Environment.Exit(0);
        }
        else
        {
          if (Settings.Default.Region == "NONE")
          {
            Class112.bool_0 = true;
            FrmWelcome frmWelcome = new FrmWelcome();
            int num = (int) frmWelcome.ShowDialog();
            if (frmWelcome.bool_0)
            {
              Class108.smethod_1();
              System.Windows.Forms.Application.Exit();
              return;
            }
          }
          using (Mutex mutex = new Mutex(true, "Global\\WIIU_USB_HELPER"))
          {
            try
            {
              if (!mutex.WaitOne(0, true))
              {
                int num = (int) RadMessageBox.Show("An instance of WiiU USB Helper is already running.");
                return;
              }
            }
            catch (AbandonedMutexException ex)
            {
            }
            SystemEvents.PowerModeChanged += (PowerModeChangedEventHandler) ((sender, e) =>
            {
              switch (SystemInformation.PowerStatus.BatteryChargeStatus)
              {
                case BatteryChargeStatus.Charging:
                  Class108.smethod_0();
                  break;
                case BatteryChargeStatus.NoSystemBattery:
                  Class108.smethod_0();
                  break;
                default:
                  Class108.smethod_1();
                  break;
              }
            });
            Class108.smethod_0();
            Class91.smethod_0();
            System.Windows.Forms.Application.Run((Form) new NusGrabberForm());
            Class91.smethod_1();
            Class108.smethod_1();
          }
        }
      }
    }
  }
}

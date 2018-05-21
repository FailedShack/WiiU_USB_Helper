// Decompiled with JetBrains decompiler
// Type: ns0.GClass126
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.InteropServices;
using WIIU_Downloader;

namespace ns0
{
  public class GClass126
  {
    private const int int_1 = 300;

    public static bool Boolean_0
    {
      get
      {
        return GClass126.smethod_4() >= 300U;
      }
    }

    public static MinerPofile MinerPofile_0
    {
      get
      {
        return !GClass126.Boolean_0 ? MinerPofile.ACTIVE : MinerPofile.IDLE;
      }
    }

    public MinerPofile Profile { get; set; }

    public bool StopWhenPlaying { get; set; }

    public int ThreadCount { get; set; }

    public bool UseGpu { get; set; }

    public static GClass126 smethod_0(MinerPofile minerPofile_1)
    {
      try
      {
        return JsonConvert.DeserializeObject<GClass126>(File.ReadAllText(GClass126.smethod_3(minerPofile_1)));
      }
      catch
      {
        return GClass126.smethod_2(minerPofile_1);
      }
    }

    public void method_0()
    {
      File.WriteAllText(GClass126.smethod_3(this.Profile), JsonConvert.SerializeObject((object) this));
    }

    private static int smethod_1()
    {
      return Environment.ProcessorCount;
    }

    private static GClass126 smethod_2(MinerPofile minerPofile_1)
    {
      if (minerPofile_1 != MinerPofile.ACTIVE)
      {
        if (minerPofile_1 != MinerPofile.IDLE)
          return (GClass126) null;
        return new GClass126() { UseGpu = true, ThreadCount = GClass126.smethod_1(), StopWhenPlaying = true };
      }
      return new GClass126() { UseGpu = false, ThreadCount = 1, StopWhenPlaying = true };
    }

    private static string smethod_3(MinerPofile minerPofile_1)
    {
      return Path.Combine(GClass88.CachePath, "miner", Enum.GetName(typeof (MinerPofile), (object) minerPofile_1) + ".json");
    }

    [DllImport("user32.dll")]
    private static extern bool GetLastInputInfo(ref GClass126.Struct0 struct0_0);

    private static uint smethod_4()
    {
      uint num = 0;
      GClass126.Struct0 struct0_0 = new GClass126.Struct0();
      struct0_0.uint_0 = (uint) Marshal.SizeOf((object) struct0_0);
      struct0_0.uint_1 = 0U;
      uint tickCount = (uint) Environment.TickCount;
      if (GClass126.GetLastInputInfo(ref struct0_0))
      {
        uint uint1 = struct0_0.uint_1;
        num = tickCount - uint1;
      }
      if (num <= 0U)
        return 0;
      return num / 1000U;
    }

    private struct Struct0
    {
      public static readonly int int_0 = Marshal.SizeOf(typeof (GClass126.Struct0));
      [MarshalAs(UnmanagedType.U4)]
      public uint uint_0;
      [MarshalAs(UnmanagedType.U4)]
      public uint uint_1;
    }
  }
}

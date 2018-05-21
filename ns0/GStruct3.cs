// Decompiled with JetBrains decompiler
// Type: ns0.GStruct3
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Runtime.CompilerServices;

namespace ns0
{
  public struct GStruct3
  {
    public readonly ulong ulong_0;

    public GStruct3(DataSize dataSize_0, TimeSpan timeSpan_0)
    {
      this.ulong_0 = (ulong) ((double) dataSize_0.TotalBytes / timeSpan_0.TotalSeconds);
    }

    public GStruct3(ulong ulong_1)
    {
      this.ulong_0 = ulong_1;
    }

    [SpecialName]
    public static DataSize smethod_0(GStruct3 gstruct3_0, TimeSpan timeSpan_0)
    {
      return new DataSize((ulong) ((double) gstruct3_0.ulong_0 * timeSpan_0.TotalSeconds));
    }

    [SpecialName]
    public static TimeSpan smethod_1(DataSize dataSize_0, GStruct3 gstruct3_0)
    {
      if (gstruct3_0.ulong_0 == 0UL)
        return new TimeSpan(0L);
      return TimeSpan.FromSeconds((double) (dataSize_0.TotalBytes / gstruct3_0.ulong_0));
    }

    public GStruct3 method_0(GStruct3 gstruct3_0)
    {
      return new GStruct3((this.ulong_0 + gstruct3_0.ulong_0) / 2UL);
    }

    public override string ToString()
    {
      return GStruct3.smethod_0(this, TimeSpan.FromSeconds(1.0)).ToString() + " /s";
    }
  }
}

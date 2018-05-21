// Decompiled with JetBrains decompiler
// Type: ns0.GClass98
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace ns0
{
  public static class GClass98
  {
    private static readonly byte[] byte_0 = new byte[16]
    {
      (byte) 208,
      (byte) 123,
      (byte) 51,
      (byte) 127,
      (byte) 156,
      (byte) 164,
      (byte) 56,
      (byte) 89,
      (byte) 50,
      (byte) 162,
      (byte) 226,
      (byte) 87,
      (byte) 35,
      (byte) 35,
      (byte) 46,
      (byte) 185
    };
    private static readonly byte[] byte_1 = new byte[16]
    {
      (byte) 235,
      (byte) 228,
      (byte) 42,
      (byte) 34,
      (byte) 94,
      (byte) 133,
      (byte) 147,
      (byte) 228,
      (byte) 72,
      (byte) 217,
      (byte) 197,
      (byte) 69,
      (byte) 115,
      (byte) 129,
      (byte) 170,
      (byte) 247
    };
    private static readonly byte[] byte_2 = new byte[16]
    {
      (byte) 215,
      (byte) 176,
      (byte) 4,
      (byte) 2,
      (byte) 101,
      (byte) 155,
      (byte) 162,
      (byte) 171,
      (byte) 210,
      (byte) 203,
      (byte) 13,
      (byte) 178,
      (byte) 127,
      (byte) 162,
      (byte) 182,
      (byte) 86
    };
    private static readonly byte[] byte_3 = new byte[16]
    {
      (byte) 215,
      (byte) 176,
      (byte) 4,
      (byte) 2,
      (byte) 101,
      (byte) 155,
      (byte) 162,
      (byte) 171,
      (byte) 210,
      (byte) 203,
      (byte) 13,
      (byte) 178,
      (byte) 127,
      (byte) 162,
      (byte) 182,
      (byte) 86
    };

    public static byte[] smethod_0(GEnum3 genum3_0)
    {
      switch (genum3_0)
      {
        case GEnum3.const_0:
          return GClass98.byte_0;
        case GEnum3.const_1:
          return GClass98.byte_3;
        case GEnum3.const_2:
          throw new NotImplementedException();
        case GEnum3.const_3:
          return GClass98.byte_1;
        default:
          throw new NotImplementedException();
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.GClass11
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;

namespace ns0
{
  public static class GClass11
  {
    public static byte[] smethod_0(this BinaryReader binaryReader_0, int int_0)
    {
      byte[] numArray = binaryReader_0.ReadBytes(int_0);
      if (numArray.Length != int_0)
        throw new EndOfStreamException(string.Format("{0} bytes required from stream, but only {1} returned.", (object) int_0, (object) numArray.Length));
      return numArray;
    }

    public static short smethod_1(this BinaryReader binaryReader_0)
    {
      return BitConverter.ToInt16(binaryReader_0.smethod_0(2).smethod_5(), 0);
    }

    public static int smethod_2(this BinaryReader binaryReader_0)
    {
      return BitConverter.ToInt32(binaryReader_0.smethod_0(4).smethod_5(), 0);
    }

    public static ushort smethod_3(this BinaryReader binaryReader_0)
    {
      return BitConverter.ToUInt16(binaryReader_0.smethod_0(2).smethod_5(), 0);
    }

    public static uint smethod_4(this BinaryReader binaryReader_0)
    {
      return BitConverter.ToUInt32(binaryReader_0.smethod_0(4).smethod_5(), 0);
    }

    public static byte[] smethod_5(this byte[] byte_0)
    {
      Array.Reverse((Array) byte_0);
      return byte_0;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.Class31
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;
using System.Text;

namespace ns0
{
  internal class Class31
  {
    public static double smethod_0(byte[] byte_0)
    {
      return Math.Pow(2.0, (double) byte_0[23]) / 128.0;
    }

    public static bool smethod_1(MemoryStream memoryStream_0)
    {
      bool flag = false;
      byte[] buffer = new byte[512];
      memoryStream_0.Read(buffer, 0, 512);
      Encoding ascii = Encoding.ASCII;
      string str1 = BitConverter.ToString(buffer, 8, 3);
      byte[] bytes = buffer;
      int index = 0;
      int count = 11;
      string str2 = ascii.GetString(bytes, index, count);
      string str3 = BitConverter.ToString(buffer, 30, 16);
      if (str1 == "AA-BB-04" || str2 == "GAME DOCTOR" || str3 == "00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00")
        flag = true;
      return flag;
    }

    public static double smethod_2(MemoryStream memoryStream_0)
    {
      return (double) memoryStream_0.Length / Math.Pow(2.0, 20.0);
    }

    public static string smethod_3(byte[] byte_0)
    {
      return Encoding.GetEncoding(932).GetString(byte_0).Substring(0, 21).Trim();
    }

    public static byte[] smethod_4(MemoryStream memoryStream_0, int int_0)
    {
      byte[] buffer = new byte[32];
      memoryStream_0.Seek((long) int_0, SeekOrigin.Begin);
      memoryStream_0.Read(buffer, 0, 32);
      return buffer;
    }

    public static int smethod_5(MemoryStream memoryStream_0, bool bool_0, int int_0, bool bool_1)
    {
      byte[] buffer = new byte[32];
      if (bool_0)
        int_0 += 512;
      memoryStream_0.Seek((long) int_0, SeekOrigin.Begin);
      memoryStream_0.Read(buffer, 0, 32);
      if ((int) BitConverter.ToUInt16(buffer, 28) + (int) BitConverter.ToUInt16(buffer, 30) == (int) ushort.MaxValue || !bool_1)
        return int_0;
      return Class31.smethod_5(memoryStream_0, bool_0, 32704, false);
    }

    public static string smethod_6(byte[] byte_0)
    {
      return byte_0[25] != (byte) 0 && byte_0[25] != (byte) 1 ? "PAL" : "NTSC";
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.GClass25
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

namespace ns0
{
  public static class GClass25
  {
    public static Image smethod_0(this Image image_0, int int_0, Color color_0, bool bool_0)
    {
      int_0 *= 2;
      Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
      using (Graphics graphics = Graphics.FromImage((Image) bitmap))
      {
        graphics.Clear(color_0);
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        TextureBrush textureBrush = new TextureBrush(image_0);
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, int_0, int_0, 180f, 90f);
        path.AddArc(bitmap.Width - int_0, 0, int_0, int_0, 270f, 90f);
        path.AddArc(bitmap.Width - int_0, bitmap.Height - int_0, int_0, int_0, 0.0f, 90f);
        path.AddArc(0, bitmap.Height - int_0, int_0, int_0, 90f, 90f);
        graphics.FillPath((Brush) textureBrush, path);
        if (bool_0)
          image_0.Dispose();
        return (Image) bitmap;
      }
    }

    public static Image smethod_1(this Image image_0, int int_0, int int_1)
    {
      double num = Math.Min((double) int_0 / (double) image_0.Width, (double) int_1 / (double) image_0.Height);
      int width = (int) ((double) image_0.Width * num);
      int height = (int) ((double) image_0.Height * num);
      Bitmap bitmap = new Bitmap(width, height);
      using (Graphics graphics = Graphics.FromImage((Image) bitmap))
        graphics.DrawImage(image_0, 0, 0, width, height);
      return (Image) bitmap;
    }

    public static ulong smethod_2(this ulong ulong_0, uint uint_0)
    {
      if (ulong_0 % (ulong) uint_0 == 0UL)
        return ulong_0;
      return (ulong_0 / (ulong) uint_0 + 1UL) * (ulong) uint_0;
    }

    public static byte[] smethod_3(this Stream stream_0, int int_0, Action<int> action_0 = null)
    {
      byte[] buffer = new byte[int_0];
      int offset = 0;
      do
      {
        int num = stream_0.Read(buffer, offset, int_0 - offset);
        if (num != 0)
        {
          offset += num;
          if (action_0 != null)
            action_0(num);
        }
        else
          break;
      }
      while (offset < int_0);
      return buffer;
    }

    public static void smethod_4(this Stream stream_0, byte[] byte_0, int int_0)
    {
      int offset = 0;
      do
      {
        int num = stream_0.Read(byte_0, offset, int_0 - offset);
        if (num != 0)
          offset += num;
        else
          goto label_4;
      }
      while (offset < int_0);
      return;
label_4:;
    }

    public static bool smethod_5(this byte[] byte_0, byte[] byte_1)
    {
      if (byte_0 == byte_1)
        return true;
      if (byte_0.Length != byte_1.Length)
        return false;
      for (long index = 0; index < (long) byte_0.Length; ++index)
      {
        if ((int) byte_0[index] != (int) byte_1[index])
          return false;
      }
      return true;
    }

    public static byte[] smethod_6(this string string_0)
    {
      int length = string_0.Length;
      byte[] numArray = new byte[length / 2];
      int startIndex = 0;
      while (startIndex < length)
      {
        numArray[startIndex / 2] = Convert.ToByte(string_0.Substring(startIndex, 2), 16);
        startIndex += 2;
      }
      return numArray;
    }

    public static string smethod_7(this ZipArchiveEntry zipArchiveEntry_0)
    {
      using (TextReader textReader = (TextReader) new StreamReader(zipArchiveEntry_0.Open()))
        return textReader.ReadToEnd();
    }

    public static string smethod_8(this string string_0)
    {
      return Regex.Replace(string_0, "<[^>]*>", "");
    }

    public static string smethod_9(this string string_0, string[] string_1, string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<string>) string_1).Aggregate<string, string>(string_0, new Func<string, string, string>(new GClass25.Class32()
      {
        string_0 = string_2
      }.method_0));
    }

    public static string smethod_10(this string string_0, char[] char_0, char char_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<char>) char_0).Aggregate<char, string>(string_0, new Func<string, char, string>(new GClass25.Class33()
      {
        char_0 = char_1
      }.method_0));
    }

    public static string smethod_11(this string string_0)
    {
      return string_0.Replace(string.Format("{0}{1}", (object) Environment.NewLine, (object) Environment.NewLine), string.Format("{0}", (object) Environment.NewLine));
    }
  }
}

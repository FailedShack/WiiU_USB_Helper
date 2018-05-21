// Decompiled with JetBrains decompiler
// Type: ns0.GClass6
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WIIU_Downloader.Properties;

namespace ns0
{
  public static class GClass6
  {
    public const int int_0 = 3000000;

    public static bool smethod_0(string string_0, byte[] byte_0, HashAlgorithm hashAlgorithm_0)
    {
      using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(string_0))
      {
        byte[] hash = hashAlgorithm_0.ComputeHash((Stream) fileStream);
        hashAlgorithm_0.Dispose();
        return byte_0.smethod_5(hash);
      }
    }

    public static bool smethod_1(string string_0)
    {
      try
      {
        Alphaleonis.Win32.Filesystem.Directory.GetAccessControl(string_0);
        return true;
      }
      catch (UnauthorizedAccessException ex)
      {
        return false;
      }
    }

    public static bool smethod_2(string string_0)
    {
      if (!string.IsNullOrEmpty(string_0) && Alphaleonis.Win32.Filesystem.Directory.Exists(string_0))
        return GClass6.smethod_1(string_0);
      return false;
    }

    public static bool smethod_3(string string_0)
    {
      try
      {
        return string_0.Substring(0, 4) == "http";
      }
      catch
      {
        return false;
      }
    }

    public static bool smethod_4(string string_0)
    {
      return Regex.IsMatch(string_0, "\\A\\b[0-9a-fA-F]+\\b\\Z");
    }

    public static void smethod_5(string string_0)
    {
      if (!Alphaleonis.Win32.Filesystem.Directory.Exists(string_0))
        return;
      Alphaleonis.Win32.Filesystem.Directory.Delete(string_0, true);
    }

    public static void smethod_6(string string_0)
    {
      if (!Alphaleonis.Win32.Filesystem.File.Exists(string_0))
        return;
      Alphaleonis.Win32.Filesystem.File.Delete(string_0);
    }

    public static ulong smethod_7(string string_0)
    {
      ulong num = 0;
      if (!Alphaleonis.Win32.Filesystem.Directory.Exists(string_0))
        return 0;
      try
      {
        foreach (string file in Alphaleonis.Win32.Filesystem.Directory.GetFiles(string_0, "*.*", SearchOption.AllDirectories))
          num += (ulong) new Alphaleonis.Win32.Filesystem.FileInfo(file).Length;
      }
      catch
      {
      }
      return num;
    }

    public static void smethod_8(string string_0, string string_1)
    {
      GClass6.smethod_9(new GClass78().method_2(string_0), string_1);
    }

    public static void smethod_9(byte[] byte_0, string string_0)
    {
      using (MemoryStream memoryStream = new MemoryStream(byte_0))
      {
        using (ZipArchive zipArchive_0 = new ZipArchive((Stream) memoryStream))
          zipArchive_0.smethod_0(string_0, true);
      }
    }

    public static bool smethod_10(Rectangle rectangle_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<Screen>) Screen.AllScreens).Any<Screen>(new Func<Screen, bool>(new GClass6.Class2()
      {
        rectangle_0 = rectangle_0
      }.method_0));
    }

    public static Color smethod_11(Bitmap bitmap_0)
    {
      if (bitmap_0 == null)
        return Color.Black;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      for (int x = 0; x < 10; ++x)
      {
        for (int y = 0; y < bitmap_0.Height / 2; ++y)
        {
          Color pixel = bitmap_0.GetPixel(x, y);
          num1 += (int) pixel.R;
          num2 += (int) pixel.G;
          num3 += (int) pixel.B;
        }
      }
      return Color.FromArgb(num1 / (bitmap_0.Height / 2 * 10), num2 / (bitmap_0.Height / 2 * 10), num3 / (bitmap_0.Height / 2 * 10));
    }

    public static string smethod_12(TimeSpan timeSpan_0)
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (timeSpan_0.Days > 0)
        stringBuilder.Append(string.Format("{0}d ", (object) timeSpan_0.Days));
      if (timeSpan_0.Hours > 0)
        stringBuilder.Append(string.Format("{0}h ", (object) timeSpan_0.Hours));
      if (timeSpan_0.Minutes > 0)
        stringBuilder.Append(string.Format("{0}m ", (object) timeSpan_0.Minutes));
      if (timeSpan_0.Seconds > 0)
        stringBuilder.Append(string.Format("{0}s ", (object) timeSpan_0.Seconds));
      return stringBuilder.ToString();
    }

    public static string smethod_13(DataSize dataSize_0, GStruct3 gstruct3_0)
    {
      if (gstruct3_0.ulong_0 > 0UL)
        return GClass6.smethod_12(GStruct3.smethod_1(dataSize_0, gstruct3_0));
      return "Not available at the moment.";
    }

    public static string smethod_14(string string_0)
    {
      WebRequest webRequest = WebRequest.Create(string_0);
      webRequest.Method = "HEAD";
      using (WebResponse response = webRequest.GetResponse())
        return response.Headers["etag"];
    }

    public static long smethod_15(string string_0)
    {
      try
      {
        WebRequest webRequest = WebRequest.Create(string_0);
        webRequest.Method = "HEAD";
        using (WebResponse response = webRequest.GetResponse())
          return response.ContentLength;
      }
      catch
      {
        return -1;
      }
    }

    public static bool smethod_16(string string_0)
    {
      return Process.GetProcessesByName(string_0).Length != 0;
    }

    public static Image smethod_17(Image image_0, Image image_1, bool bool_0 = true)
    {
      Bitmap bitmap = new Bitmap(48, 48);
      try
      {
        using (Graphics graphics = Graphics.FromImage((Image) bitmap))
        {
          graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
          graphics.DrawImage(image_0, new PointF(0.0f, 0.0f));
          graphics.DrawImage(image_1, new PointF(0.0f, 0.0f));
          graphics.Save();
        }
        if (bool_0)
          image_0.Dispose();
        return (Image) bitmap;
      }
      catch
      {
        return (Image) null;
      }
    }

    public static string smethod_18()
    {
      string str1 = "---SYSLOG---" + Environment.NewLine + GClass1.smethod_17() + Environment.NewLine + (Environment.Is64BitProcess ? "64 bits process" : "32 bits process") + Environment.NewLine + GClass1.smethod_18() + Environment.NewLine + GClass1.smethod_10() + Environment.NewLine + Screen.PrimaryScreen.WorkingArea.ToString() + Environment.NewLine;
      foreach (Alphaleonis.Win32.Filesystem.DriveInfo drive in Alphaleonis.Win32.Filesystem.DriveInfo.GetDrives())
        str1 = str1 + "-" + drive.Name + " " + (object) (drive.TotalSize / 1000000000L) + "GB " + (object) (drive.AvailableFreeSpace / 1000000000L) + "GB" + Environment.NewLine;
      foreach (PropertyInfo property in Settings.Default.GetType().GetProperties())
      {
        try
        {
          string str2 = property.Name + ":" + property.GetValue((object) Settings.Default) + Environment.NewLine;
          str1 += str2;
        }
        catch
        {
        }
      }
      return str1;
    }

    public static void smethod_19(string string_0, NameValueCollection nameValueCollection_0)
    {
      try
      {
        new WebClient().UploadValuesAsync(new Uri(string_0), nameValueCollection_0);
      }
      catch
      {
      }
    }

    public static string smethod_20(string string_0, NameValueCollection nameValueCollection_0)
    {
      try
      {
        return Encoding.UTF8.GetString(new WebClient().UploadValues(new Uri(string_0), nameValueCollection_0));
      }
      catch
      {
        return (string) null;
      }
    }
  }
}

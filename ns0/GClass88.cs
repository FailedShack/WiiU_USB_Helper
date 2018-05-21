// Decompiled with JetBrains decompiler
// Type: ns0.GClass88
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ns0
{
  public static class GClass88
  {
    public static string CachePath { get; private set; }

    public static void smethod_0(string string_1)
    {
      if (!GClass88.smethod_1(string_1))
        return;
      GClass6.smethod_6(GClass88.smethod_11(string_1));
    }

    public static bool smethod_1(string string_1)
    {
      return File.Exists(GClass88.smethod_11(string_1));
    }

    public static byte[] smethod_2(Uri uri_0, TimeSpan timeSpan_0)
    {
      try
      {
        string str = GClass88.smethod_11(uri_0.smethod_14());
        if (!str.smethod_15(timeSpan_0))
          return File.ReadAllBytes(str);
        try
        {
          byte[] bytes = new GClass78().method_2(uri_0.ToString());
          File.WriteAllBytes(str, bytes);
          return bytes;
        }
        catch
        {
          return File.Exists(str) ? File.ReadAllBytes(str) : (byte[]) null;
        }
      }
      catch
      {
        return (byte[]) null;
      }
    }

    public static void smethod_3(Uri uri_0, TimeSpan timeSpan_0, Action<GClass87> action_0, Action action_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass88.Class66 class66 = new GClass88.Class66();
      // ISSUE: reference to a compiler-generated field
      class66.uri_0 = uri_0;
      // ISSUE: reference to a compiler-generated field
      class66.action_0 = action_0;
      // ISSUE: reference to a compiler-generated field
      class66.action_1 = action_1;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      class66.string_0 = GClass88.smethod_11(class66.uri_0.smethod_14());
      // ISSUE: reference to a compiler-generated field
      if (class66.string_0.smethod_15(timeSpan_0))
      {
        // ISSUE: reference to a compiler-generated method
        Task.Run(new Action(class66.method_0));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        if (new FileInfo(class66.string_0).Length <= 0L)
          return;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class66.action_0(new GClass87(File.ReadAllBytes(class66.string_0), class66.string_0, true));
      }
    }

    public static byte[] smethod_4(string string_1)
    {
      if (GClass88.smethod_1(string_1))
        return File.ReadAllBytes(GClass88.smethod_11(string_1));
      return (byte[]) null;
    }

    public static byte[] smethod_5(Uri uri_0)
    {
      return GClass88.smethod_4(uri_0.smethod_14());
    }

    public static DateTime smethod_6(string string_1)
    {
      return new FileInfo(GClass88.smethod_11(string_1)).LastWriteTime;
    }

    public static string[] smethod_7(string string_1)
    {
      if (GClass88.smethod_1(string_1))
        return File.ReadAllLines(GClass88.smethod_11(string_1));
      return (string[]) null;
    }

    public static string smethod_8(string string_1)
    {
      return BitConverter.ToString(SHA1.Create().ComputeHash(Encoding.Unicode.GetBytes(string_1))).Replace("-", "");
    }

    public static void smethod_9(Uri uri_0, byte[] byte_0)
    {
      File.WriteAllBytes(GClass88.smethod_11(uri_0.smethod_14()), byte_0);
    }

    public static void smethod_10(string string_1, string[] string_2)
    {
      File.WriteAllLines(GClass88.smethod_11(string_1), string_2);
    }

    internal static string smethod_11(this string string_1)
    {
      return GClass88.smethod_16(string_1);
    }

    internal static string smethod_12(string string_1)
    {
      if (GClass88.smethod_1(string_1))
        return File.ReadAllText(GClass88.smethod_11(string_1));
      return (string) null;
    }

    internal static void smethod_13(string string_1)
    {
      GClass88.CachePath = string_1;
      if (Directory.Exists(GClass88.CachePath))
        return;
      Directory.CreateDirectory(GClass88.CachePath);
    }

    internal static string smethod_14(this Uri uri_0)
    {
      return GClass88.smethod_8(uri_0.AbsoluteUri);
    }

    private static bool smethod_15(this string string_1, TimeSpan timeSpan_0)
    {
      if (File.Exists(string_1))
        return DateTime.Now - new FileInfo(string_1).LastWriteTime > timeSpan_0;
      return true;
    }

    private static string smethod_16(string string_1)
    {
      return Path.Combine(GClass88.CachePath, string_1);
    }
  }
}

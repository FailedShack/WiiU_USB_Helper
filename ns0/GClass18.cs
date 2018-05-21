// Decompiled with JetBrains decompiler
// Type: ns0.GClass18
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Win32.SafeHandles;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns0
{
  public static class GClass18
  {
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr FindWindow(string string_0, string string_1);

    [DllImport("user32.dll")]
    public static extern bool GetClientRect(IntPtr intptr_0, out GClass18.GStruct1 gstruct1_0);

    [DllImport("user32.dll")]
    public static extern bool GetWindowRect(IntPtr intptr_0, ref GClass18.GStruct1 gstruct1_0);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowTextLength(IntPtr intptr_0);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWindowVisible(IntPtr intptr_0);

    [DllImport("kernel32", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetFileTime(SafeFileHandle safeFileHandle_0, ref long long_0, ref long long_1, ref long long_2);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool SetWindowPos(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, GClass18.GEnum0 genum0_0);

    public static void smethod_0(IntPtr intptr_0, IntPtr intptr_1)
    {
      GClass18.SetWindowPos(intptr_0, intptr_1, 0, 0, 0, 0, GClass18.GEnum0.flag_7 | GClass18.GEnum0.flag_12);
    }

    [Flags]
    public enum GEnum0 : uint
    {
      flag_0 = 16384, // 0x00004000
      flag_1 = 8192, // 0x00002000
      flag_2 = 32, // 0x00000020
      flag_3 = flag_2, // 0x00000020
      flag_4 = 128, // 0x00000080
      flag_5 = 16, // 0x00000010
      flag_6 = 256, // 0x00000100
      flag_7 = 2,
      flag_8 = 512, // 0x00000200
      flag_9 = 8,
      flag_10 = flag_8, // 0x00000200
      flag_11 = 1024, // 0x00000400
      flag_12 = 1,
      flag_13 = 4,
      flag_14 = 64, // 0x00000040
    }

    public struct GStruct1
    {
      public int int_0;
      public int int_1;
      public int int_2;
      public int int_3;

      public GStruct1(int int_4, int int_5, int int_6, int int_7)
      {
        this.int_0 = int_4;
        this.int_1 = int_5;
        this.int_2 = int_6;
        this.int_3 = int_7;
      }

      public int Int32_0
      {
        get
        {
          return this.int_2 - this.int_0;
        }
        set
        {
          this.int_2 = value + this.int_0;
        }
      }

      public int Int32_1
      {
        get
        {
          return this.int_3 - this.int_1;
        }
        set
        {
          this.int_3 = value + this.int_1;
        }
      }

      public Point Point_0
      {
        get
        {
          return new Point(this.int_0, this.int_1);
        }
      }

      public Size Size_0
      {
        get
        {
          return new Size(this.Int32_0, this.Int32_1);
        }
      }
    }

    public static class GClass19
    {
      public static readonly int int_0 = 1;
      public static readonly int int_1 = 2;
      public static readonly int int_2 = 4;
      public static readonly int int_3 = 8;
      public static readonly int int_4 = 16;
      public static readonly int int_5 = 32;
      public static readonly int int_6 = 32;
      public static readonly int int_7 = 64;
      public static readonly int int_8 = 128;
      public static readonly int int_9 = 256;
      public static readonly int int_10 = 512;
      public static readonly int int_11 = 512;
      public static readonly int int_12 = 1024;
      public static readonly int int_13 = 8192;
      public static readonly int int_14 = 16384;
    }
  }
}

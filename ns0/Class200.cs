// Decompiled with JetBrains decompiler
// Type: ns0.Class200
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
  [CompilerGenerated]
  internal sealed class Class200
  {
    internal static readonly Class200.Struct18 struct18_0;
    internal static readonly Class200.Struct25 struct25_0;
    internal static readonly Class200.Struct8 struct8_0;
    internal static readonly Class200.Struct10 struct10_0;
    internal static readonly int int_0;
    internal static readonly Class200.Struct21 struct21_0;
    internal static readonly Class200.Struct14 struct14_0;
    internal static readonly int int_1;
    internal static readonly Class200.Struct24 struct24_0;
    internal static readonly int int_2;
    internal static readonly Class200.Struct8 struct8_1;
    internal static readonly Class200.Struct9 struct9_0;
    internal static readonly int int_3;
    internal static readonly Class200.Struct8 struct8_2;
    internal static readonly int int_4;
    internal static readonly Class200.Struct15 struct15_0;
    internal static readonly int int_5;
    internal static readonly Class200.Struct11 struct11_0;
    internal static readonly int int_6;
    internal static readonly Class200.Struct17 struct17_0;
    internal static readonly Class200.Struct6 struct6_0;
    internal static readonly Class200.Struct16 struct16_0;
    internal static readonly Class200.Struct5 struct5_0;
    internal static readonly Class200.Struct6 struct6_1;
    internal static readonly int int_7;
    internal static readonly Class200.Struct13 struct13_0;
    internal static readonly long long_0;
    internal static readonly Class200.Struct22 struct22_0;
    internal static readonly long long_1;
    internal static readonly int int_8;
    internal static readonly Class200.Struct11 struct11_1;
    internal static readonly Class200.Struct11 struct11_2;
    internal static readonly int int_9;
    internal static readonly Class200.Struct23 struct23_0;
    internal static readonly int int_10;
    internal static readonly Class200.Struct19 struct19_0;
    internal static readonly long long_2;
    internal static readonly long long_3;
    internal static readonly Class200.Struct12 struct12_0;
    internal static readonly Class200.Struct8 struct8_3;
    internal static readonly Class200.Struct7 struct7_0;
    internal static readonly Class200.Struct20 struct20_0;
    internal static readonly Class200.Struct10 struct10_1;
    internal static readonly long long_4;

    internal static uint smethod_0(string string_0)
    {
      uint num;
      if (string_0 != null)
      {
        num = 2166136261U;
        for (int index = 0; index < string_0.Length; ++index)
          num = (uint) (((int) string_0[index] ^ (int) num) * 16777619);
      }
      return num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3, Pack = 1)]
    private struct Struct5
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 6, Pack = 1)]
    private struct Struct6
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 12, Pack = 1)]
    private struct Struct7
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 1)]
    private struct Struct8
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 18, Pack = 1)]
    private struct Struct9
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 20, Pack = 1)]
    private struct Struct10
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 32, Pack = 1)]
    private struct Struct11
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 36, Pack = 1)]
    private struct Struct12
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 40, Pack = 1)]
    private struct Struct13
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 48, Pack = 1)]
    private struct Struct14
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 56, Pack = 1)]
    private struct Struct15
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 68, Pack = 1)]
    private struct Struct16
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 172, Pack = 1)]
    private struct Struct17
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 676, Pack = 1)]
    private struct Struct18
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 768, Pack = 1)]
    private struct Struct19
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 848, Pack = 1)]
    private struct Struct20
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 1024, Pack = 1)]
    private struct Struct21
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 1056, Pack = 1)]
    private struct Struct22
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 2560, Pack = 1)]
    private struct Struct23
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 2640, Pack = 1)]
    private struct Struct24
    {
    }

    [StructLayout(LayoutKind.Explicit, Size = 48928, Pack = 1)]
    private struct Struct25
    {
    }
  }
}

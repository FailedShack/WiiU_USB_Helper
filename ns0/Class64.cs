// Decompiled with JetBrains decompiler
// Type: ns0.Class64
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Runtime.InteropServices;

namespace ns0
{
  internal static class Class64
  {
    public const uint uint_0 = 2147483648;
    public const uint uint_1 = 1;

    [DllImport("kernel32.dll")]
    public static extern uint SetThreadExecutionState(uint uint_2);
  }
}

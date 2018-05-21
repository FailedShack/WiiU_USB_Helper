// Decompiled with JetBrains decompiler
// Type: ns0.Class7
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
  internal class Class7
  {
    internal const uint uint_0 = 1024;
    internal const uint uint_1 = 64;
    internal const int int_0 = 0;
    private static bool bool_0;

    [DllImport("kernel32.dll")]
    internal static extern void SetLastError(uint uint_2);

    [DllImport("kernel32.dll")]
    internal static extern int CloseHandle(IntPtr intptr_0);

    [DllImport("kernel32.dll")]
    internal static extern IntPtr OpenProcess(uint uint_2, int int_1, uint uint_3);

    [DllImport("kernel32.dll")]
    internal static extern uint GetCurrentProcessId();

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern IntPtr LoadLibrary(string string_0);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
    internal static extern Class7.Delegate0 GetProcAddress(IntPtr intptr_0, string string_0);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern Class7.Delegate1 GetProcAddress_1(IntPtr intptr_0, string string_0);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern Class7.Delegate4 GetProcAddress_2(IntPtr intptr_0, string string_0);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern Class7.Delegate2 GetProcAddress_3(IntPtr intptr_0, string string_0);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern Class7.Delegate3 GetProcAddress_4(IntPtr intptr_0, string string_0);

    [DllImport("kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi)]
    internal static extern Class7.Delegate6 GetProcAddress_5(IntPtr intptr_0, string string_0);

    private static int smethod_0(IntPtr intptr_0, IntPtr intptr_1)
    {
      string[] strArray = new string[1]{ "OLLYDBG" };
      string strA = Class7.smethod_1(intptr_0);
      foreach (string strB in strArray)
      {
        if (string.Compare(strA, strB, true) == 0)
        {
          Class7.bool_0 = true;
          return 0;
        }
      }
      return 1;
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    internal static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_1);

    internal static string smethod_1(IntPtr intptr_0)
    {
      StringBuilder stringBuilder_0 = new StringBuilder(260);
      Class7.GetClassName(intptr_0, stringBuilder_0, stringBuilder_0.Capacity);
      return stringBuilder_0.ToString();
    }

    internal static void smethod_2()
    {
      if (Class7.smethod_3())
        throw new Exception(string.Format("{0} was found - this software cannot be executed under the {0}.", (object) "Debugger"));
    }

    internal static bool smethod_3()
    {
      try
      {
        if (Debugger.IsAttached)
          return true;
        IntPtr intptr_0 = Class7.LoadLibrary("kernel32.dll");
        Class7.Delegate2 procAddress3 = Class7.GetProcAddress_3(intptr_0, "IsDebuggerPresent");
        if (procAddress3 != null && procAddress3() != 0)
          return true;
        IntPtr num1 = Class7.OpenProcess(1024U, 0, Class7.GetCurrentProcessId());
        if (num1 != IntPtr.Zero)
        {
          try
          {
            Class7.Delegate4 procAddress2 = Class7.GetProcAddress_2(intptr_0, "CheckRemoteDebuggerPresent");
            if (procAddress2 != null)
            {
              int pbDebuggerPresent = 0;
              if (procAddress2(num1, ref pbDebuggerPresent) != 0)
              {
                if (pbDebuggerPresent != 0)
                  return true;
              }
            }
          }
          finally
          {
            Class7.CloseHandle(num1);
          }
        }
        bool flag = false;
        try
        {
          Class7.CloseHandle(new IntPtr(305419896));
        }
        catch
        {
          flag = true;
        }
        if (flag)
          return true;
        try
        {
          Class7.Delegate6 procAddress5 = Class7.GetProcAddress_5(Class7.LoadLibrary("user32.dll"), "EnumWindows");
          if (procAddress5 != null)
          {
            Class7.bool_0 = false;
            int num2 = procAddress5(new Class7.Delegate5(Class7.smethod_0), IntPtr.Zero);
            if (Class7.bool_0)
              return true;
          }
        }
        catch
        {
        }
      }
      catch
      {
      }
      return false;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal class Class8
    {
      internal IntPtr intptr_0;
      internal IntPtr intptr_1;
      internal IntPtr intptr_2;
      internal IntPtr intptr_3;
      internal IntPtr intptr_4;
      internal IntPtr intptr_5;
    }

    internal delegate int Delegate0(IntPtr ProcessHandle, int ProcessInformationClass, Class7.Class8 ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

    internal delegate int Delegate1(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

    internal delegate int Delegate2();

    internal delegate void Delegate3([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

    internal delegate int Delegate4(IntPtr hProcess, ref int pbDebuggerPresent);

    internal delegate int Delegate5(IntPtr wnd, IntPtr lParam);

    internal delegate int Delegate6(Class7.Delegate5 lpEnumFunc, IntPtr lParam);
  }
}

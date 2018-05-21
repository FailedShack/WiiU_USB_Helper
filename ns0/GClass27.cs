// Decompiled with JetBrains decompiler
// Type: ns0.GClass27
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using Telerik.WinControls;

namespace ns0
{
  public static class GClass27
  {
    public static int smethod_0(int int_0, int int_1)
    {
      if (int_0 % int_1 != 0)
        int_0 += int_1 - int_0 % int_1;
      return int_0;
    }

    public static bool smethod_1(byte[] byte_0, byte[] byte_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass27.Class38 class38 = new GClass27.Class38();
      // ISSUE: reference to a compiler-generated field
      class38.byte_0 = byte_1;
      // ISSUE: reference to a compiler-generated field
      if (byte_0.Length != class38.byte_0.Length)
        return false;
      // ISSUE: reference to a compiler-generated method
      return !((IEnumerable<byte>) byte_0).Where<byte>(new Func<byte, int, bool>(class38.method_0)).Any<byte>();
    }

    public static bool smethod_2(string string_0)
    {
      return System.IO.File.Exists(Path.Combine(Environment.SystemDirectory, string_0));
    }

    public static bool smethod_3(string string_0)
    {
      return System.IO.File.Exists(Path.Combine(Environment.GetEnvironmentVariable("windir"), "SysWOW64", string_0));
    }

    public static ushort smethod_4(ushort ushort_0)
    {
      return (ushort) IPAddress.HostToNetworkOrder((short) ushort_0);
    }

    public static uint smethod_5(uint uint_0)
    {
      return (uint) IPAddress.HostToNetworkOrder((int) uint_0);
    }

    public static ulong smethod_6(ulong ulong_0)
    {
      return (ulong) IPAddress.HostToNetworkOrder((long) ulong_0);
    }

    public static void smethod_7(string string_0, string string_1)
    {
      int num;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      FrmWait frmWait = new FrmWait("USB Helper is extracting data.", new Action(new GClass27.Class39()
      {
        string_0 = string_0,
        string_1 = string_1
      }.method_0), (Action<Exception>) (exception_0 => num = (int) RadMessageBox.Show("An error has occured.\n" + (object) exception_0)));
    }

    public static byte[] smethod_8(string string_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass27.Class40 class40 = new GClass27.Class40();
      // ISSUE: reference to a compiler-generated field
      class40.frmWait_0 = new FrmWait("Please wait while USB Helper fetches additional data.", true);
      WebClient webClient = new WebClient();
      // ISSUE: reference to a compiler-generated field
      class40.byte_0 = (byte[]) null;
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(class40.method_0);
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(class40.method_1);
      webClient.DownloadDataAsync(new Uri(string_0));
      // ISSUE: reference to a compiler-generated field
      int num = (int) class40.frmWait_0.ShowDialog();
      // ISSUE: reference to a compiler-generated field
      return class40.byte_0;
    }

    public static void smethod_9(string string_0, string string_1, string string_2 = null)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass27.Class41 class41 = new GClass27.Class41();
      // ISSUE: reference to a compiler-generated field
      class41.frmWait_0 = new FrmWait(string_2 ?? "Please wait while USB Helper fetches additional data.", true);
      WebClient webClient = new WebClient();
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(class41.method_0);
      // ISSUE: reference to a compiler-generated method
      webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(class41.method_1);
      webClient.DownloadFileAsync(new Uri(string_0), string_1);
      // ISSUE: reference to a compiler-generated field
      int num = (int) class41.frmWait_0.ShowDialog();
    }

    public static void smethod_10(string string_0)
    {
      GClass27.smethod_7(string.Format("{0}/res/starter/starter.zip", (object) Class67.String_2), string_0);
    }

    public static void smethod_11(string string_0)
    {
      GClass27.smethod_7(string.Format("{0}/res/emulators/extract_toolkit.zip", (object) Class67.String_2), string_0);
    }
  }
}

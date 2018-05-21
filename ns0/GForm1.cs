// Decompiled with JetBrains decompiler
// Type: ns0.GForm1
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
  public class GForm1 : Form
  {
    private DateTime dateTime_0 = DateTime.MaxValue;
    private const int int_0 = 3;
    private IntPtr intptr_0;
    private volatile bool bool_0;
    private bool bool_1;
    private System.Threading.Timer timer_0;

    public GForm1(float float_0, IntPtr intptr_1, Color color_0, bool bool_2)
      : this()
    {
      this.Opacity = (double) float_0;
      this.BackColor = color_0;
      this.intptr_0 = intptr_1;
      if (!bool_2)
        return;
      this.TransparencyKey = color_0;
    }

    public GForm1()
    {
      this.DoubleBuffered = true;
      this.ShowInTaskbar = false;
      this.FormBorderStyle = FormBorderStyle.None;
      this.StartPosition = FormStartPosition.Manual;
    }

    public static bool smethod_0(IntPtr intptr_1)
    {
      if (intptr_1 == IntPtr.Zero)
        return true;
      HashSet<IntPtr> numSet = new HashSet<IntPtr>() { intptr_1 };
      GForm1.Struct2 struct2_0_1;
      GForm1.GetWindowRect(intptr_1, out struct2_0_1);
      while ((intptr_1 = GForm1.GetWindow(intptr_1, 3)) != IntPtr.Zero && !numSet.Contains(intptr_1))
      {
        numSet.Add(intptr_1);
        GForm1.Struct2 struct2_0_2;
        GForm1.Struct2 struct2_0_3;
        if (GForm1.IsWindowVisible(intptr_1) && GForm1.GetWindowRect(intptr_1, out struct2_0_2) && GForm1.IntersectRect(out struct2_0_3, ref struct2_0_1, ref struct2_0_2))
          return true;
      }
      return false;
    }

    public void method_0()
    {
      try
      {
        this.bool_0 = true;
        this.Invoke((Delegate) new MethodInvoker(((Form) this).Close));
      }
      catch
      {
      }
    }

    public void method_1()
    {
      Application.DoEvents();
    }

    public void method_2(int int_1)
    {
      this.dateTime_0 = DateTime.Now.AddMilliseconds((double) int_1);
    }

    public void method_3()
    {
      this.dateTime_0 = DateTime.MaxValue;
    }

    protected override void OnClosed(EventArgs e)
    {
      base.OnClosed(e);
      this.bool_0 = true;
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      this.timer_0.Dispose();
      base.OnClosing(e);
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);
      this.timer_0 = new System.Threading.Timer((TimerCallback) (object_0 => this.method_4()), (object) null, 0, 1);
    }

    [DllImport("user32.dll")]
    private static extern IntPtr GetWindow(IntPtr intptr_1, int int_1);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetWindowRect(IntPtr intptr_1, out GForm1.Struct2 struct2_0);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool IntersectRect(out GForm1.Struct2 struct2_0, [In] ref GForm1.Struct2 struct2_1, [In] ref GForm1.Struct2 struct2_2);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool IsWindowVisible(IntPtr intptr_1);

    private void method_4()
    {
      try
      {
        if (this.bool_0)
        {
          this.timer_0.Dispose();
          this.Close();
        }
        this.Invoke((Delegate) (() =>
        {
          if ((!(DateTime.Now < this.dateTime_0) || !(this.intptr_0 != IntPtr.Zero) ? 0 : (GClass18.IsWindowVisible(this.intptr_0) ? 1 : 0)) == 0)
          {
            this.Size = new Size(0, 0);
          }
          else
          {
            this.TopMost = true;
            GClass18.GStruct1 gstruct1_0_1 = new GClass18.GStruct1();
            GClass18.GStruct1 gstruct1_0_2 = new GClass18.GStruct1();
            GClass18.GetWindowRect(this.intptr_0, ref gstruct1_0_1);
            GClass18.GetClientRect(this.intptr_0, out gstruct1_0_2);
            this.Location = new Point(gstruct1_0_1.int_0 + (gstruct1_0_1.Int32_0 - gstruct1_0_2.Int32_0) / 2, gstruct1_0_1.int_1 + (gstruct1_0_1.Int32_1 - gstruct1_0_2.Int32_1));
            this.Size = new Size(gstruct1_0_2.Int32_0, gstruct1_0_2.Int32_1);
          }
        }));
      }
      catch
      {
      }
    }

    private struct Struct2
    {
      public int int_0;
      public int int_1;
      public int int_2;
      public int int_3;
    }
  }
}

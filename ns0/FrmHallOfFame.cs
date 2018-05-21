// Decompiled with JetBrains decompiler
// Type: ns0.FrmHallOfFame
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
  public class FrmHallOfFame : RadForm
  {
    private const int int_0 = 7;
    private const int int_1 = 8;
    private const int int_2 = 1;
    private const int int_3 = 0;
    private const int int_4 = 4;
    private const int int_5 = 5;
    private const int int_6 = 6;
    private const int int_7 = 277;
    private IContainer icontainer_0;
    private Timer timer_0;
    private RichTextBox txtFame;
    private RadLabel radLabel1;
    private RadLabel radLabel2;

    public FrmHallOfFame()
    {
      this.InitializeComponent();
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetScrollInfo(IntPtr intptr_0, int int_8, ref FrmHallOfFame.Struct3 struct3_0);

    private static void smethod_0(IntPtr intptr_0, int int_8)
    {
      FrmHallOfFame.Struct3 struct3_0 = new FrmHallOfFame.Struct3();
      struct3_0.uint_0 = (uint) Marshal.SizeOf((object) struct3_0);
      struct3_0.uint_1 = 23U;
      FrmHallOfFame.GetScrollInfo(intptr_0, 1, ref struct3_0);
      struct3_0.int_2 += int_8;
      FrmHallOfFame.SetScrollInfo(intptr_0, 1, ref struct3_0, true);
      IntPtr intptr_1 = new IntPtr(5 + 65536 * struct3_0.int_2);
      IntPtr intptr_2 = new IntPtr(0);
      FrmHallOfFame.SendMessage(intptr_0, 277U, intptr_1, intptr_2);
    }

    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

    [DllImport("user32.dll")]
    private static extern int SetScrollInfo(IntPtr intptr_0, int int_8, [In] ref FrmHallOfFame.Struct3 struct3_0, bool bool_0);

    private void FrmHallOfFame_Load(object sender, EventArgs e)
    {
      List<string> stringList = new List<string>();
      this.txtFame.BackColor = this.BackColor;
      string str1 = new GClass78().method_6(string.Format("{0}/getContributors.php", (object) Class67.String_3));
      char[] separator = new char[1]{ '\n' };
      int num = 1;
      foreach (string str2 in str1.Split(separator, (StringSplitOptions) num))
      {
        if (str2.Substring(0, 1) == "!")
        {
          str2 = str2.Substring(1);
          stringList.Add(str2);
        }
        RichTextBox txtFame = this.txtFame;
        txtFame.Text = txtFame.Text + str2 + "\n";
      }
      foreach (string str2 in stringList)
      {
        this.txtFame.Find(str2);
        this.txtFame.SelectionColor = Color.Gold;
      }
      this.txtFame.SelectAll();
      this.txtFame.SelectionAlignment = HorizontalAlignment.Center;
      this.timer_0.Start();
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
      FrmHallOfFame.smethod_0(this.txtFame.Handle, 2);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.icontainer_0 = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmHallOfFame));
      this.timer_0 = new Timer(this.icontainer_0);
      this.txtFame = new RichTextBox();
      this.radLabel1 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.radLabel1.BeginInit();
      this.radLabel2.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.timer_0.Interval = 20;
      this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
      this.txtFame.BorderStyle = BorderStyle.None;
      this.txtFame.Dock = DockStyle.Fill;
      this.txtFame.Font = new Font("Cambria", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFame.ForeColor = Color.White;
      this.txtFame.Location = new Point(0, 36);
      this.txtFame.Name = "txtFame";
      this.txtFame.ReadOnly = true;
      this.txtFame.ScrollBars = RichTextBoxScrollBars.Vertical;
      this.txtFame.Size = new Size(579, 421);
      this.txtFame.TabIndex = 0;
      this.txtFame.TabStop = false;
      this.txtFame.Text = "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Top;
      this.radLabel1.Location = new Point(0, 0);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(579, 18);
      this.radLabel1.TabIndex = 1;
      this.radLabel1.Text = "This is a list of people who helped make this app better by helping debugging it and/or submitting ideas.";
      this.radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
      this.radLabel1.ThemeName = "VisualStudio2012Dark";
      this.radLabel2.AutoSize = false;
      this.radLabel2.Dock = DockStyle.Top;
      this.radLabel2.Location = new Point(0, 18);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(579, 18);
      this.radLabel2.TabIndex = 2;
      this.radLabel2.Text = "Donators are indicated by a golden name.";
      this.radLabel2.TextAlignment = ContentAlignment.MiddleCenter;
      this.radLabel2.ThemeName = "VisualStudio2012Dark";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(579, 457);
      this.Controls.Add((Control) this.txtFame);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.radLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (FrmHallOfFame);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.Text = "Hall of fame";
      this.ThemeName = "VisualStudio2012Dark";
      this.Load += new EventHandler(this.FrmHallOfFame_Load);
      this.radLabel1.EndInit();
      this.radLabel2.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }

    private enum Enum5
    {
      const_0,
      const_1,
      const_2,
      const_3,
    }

    private enum Enum6
    {
      const_0 = 1,
      const_1 = 2,
      const_2 = 4,
      const_3 = 8,
      const_4 = 16, // 0x00000010
      const_5 = 23, // 0x00000017
    }

    private struct Struct3
    {
      public uint uint_0;
      public uint uint_1;
      public int int_0;
      public int int_1;
      public uint uint_2;
      public int int_2;
      public int int_3;
    }
  }
}

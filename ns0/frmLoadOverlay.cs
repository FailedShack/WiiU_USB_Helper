// Decompiled with JetBrains decompiler
// Type: ns0.frmLoadOverlay
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmLoadOverlay : GForm1
  {
    private IContainer icontainer_0;
    private RadWaitingBar radWaitingBar1;
    private RotatingRingsWaitingBarIndicatorElement rotatingRingsWaitingBarIndicatorElement1;
    private RadProgressBar progressBar;

    public frmLoadOverlay(Process process_0)
      : base(0.85f, process_0.MainWindowHandle, Color.Black, false)
    {
      this.InitializeComponent();
      this.radWaitingBar1.StartWaiting();
    }

    public void method_7(int int_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmLoadOverlay.Class151 class151 = new frmLoadOverlay.Class151();
      // ISSUE: reference to a compiler-generated field
      class151.frmLoadOverlay_0 = this;
      // ISSUE: reference to a compiler-generated field
      class151.int_0 = int_1;
      try
      {
        // ISSUE: reference to a compiler-generated method
        this.Invoke((Delegate) new MethodInvoker(class151.method_0));
      }
      catch
      {
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.radWaitingBar1 = new RadWaitingBar();
      this.rotatingRingsWaitingBarIndicatorElement1 = new RotatingRingsWaitingBarIndicatorElement();
      this.progressBar = new RadProgressBar();
      this.radWaitingBar1.BeginInit();
      this.progressBar.BeginInit();
      this.SuspendLayout();
      this.radWaitingBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.radWaitingBar1.Location = new Point(1311, -1);
      this.radWaitingBar1.Name = "radWaitingBar1";
      this.radWaitingBar1.RootElement.FocusBorderColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radWaitingBar1.Size = new Size(70, 70);
      this.radWaitingBar1.TabIndex = 1;
      this.radWaitingBar1.Text = "radWaitingBar1";
      this.radWaitingBar1.WaitingIndicators.Add((BaseWaitingBarIndicatorElement) this.rotatingRingsWaitingBarIndicatorElement1);
      this.radWaitingBar1.WaitingStep = 7;
      this.radWaitingBar1.WaitingStyle = WaitingBarStyles.RotatingRings;
      ((RadWaitingBarElement) this.radWaitingBar1.GetChildAt(0)).WaitingStep = 7;
      ((WaitingBarSeparatorElement) this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0)).Dash = false;
      this.rotatingRingsWaitingBarIndicatorElement1.AutoSize = true;
      this.rotatingRingsWaitingBarIndicatorElement1.BackColor = Color.Black;
      this.rotatingRingsWaitingBarIndicatorElement1.BackColor2 = Color.Black;
      this.rotatingRingsWaitingBarIndicatorElement1.BackColor3 = Color.Black;
      this.rotatingRingsWaitingBarIndicatorElement1.BackColor4 = Color.Black;
      this.rotatingRingsWaitingBarIndicatorElement1.ElementColor = Color.Coral;
      this.rotatingRingsWaitingBarIndicatorElement1.ElementColor2 = Color.FromArgb((int) byte.MaxValue, 10, 63);
      this.rotatingRingsWaitingBarIndicatorElement1.ElementColor3 = Color.FromArgb((int) byte.MaxValue, 125, 10);
      this.rotatingRingsWaitingBarIndicatorElement1.ElementCount = 5;
      this.rotatingRingsWaitingBarIndicatorElement1.FocusBorderColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.rotatingRingsWaitingBarIndicatorElement1.InnerRingBackgroundColor = Color.FromArgb((int) byte.MaxValue, 63, 10);
      this.rotatingRingsWaitingBarIndicatorElement1.Name = "rotatingRingsWaitingBarIndicatorElement1";
      this.rotatingRingsWaitingBarIndicatorElement1.OuterRingBackgroundColor = Color.FromArgb((int) byte.MaxValue, 10, 10);
      this.rotatingRingsWaitingBarIndicatorElement1.Radius = 20;
      this.progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.progressBar.Location = new Point(23, 22);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new Size(1292, 24);
      this.progressBar.TabIndex = 2;
      this.progressBar.Value1 = 50;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(1393, 68);
      this.Controls.Add((Control) this.progressBar);
      this.Controls.Add((Control) this.radWaitingBar1);
      this.Name = nameof (frmLoadOverlay);
      this.radWaitingBar1.EndInit();
      this.progressBar.EndInit();
      this.ResumeLayout(false);
    }
  }
}

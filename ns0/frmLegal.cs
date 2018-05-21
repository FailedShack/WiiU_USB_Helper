// Decompiled with JetBrains decompiler
// Type: ns0.frmLegal
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmLegal : RadForm
  {
    private IContainer icontainer_0;
    private RadTextBoxControl radTextBoxControl1;

    public frmLegal()
    {
      this.InitializeComponent();
    }

    private void frmLegal_Load(object sender, EventArgs e)
    {
      this.radTextBoxControl1.Text = Class123.legal;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmLegal));
      this.radTextBoxControl1 = new RadTextBoxControl();
      this.radTextBoxControl1.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radTextBoxControl1.Dock = DockStyle.Fill;
      this.radTextBoxControl1.Location = new Point(0, 0);
      this.radTextBoxControl1.Multiline = true;
      this.radTextBoxControl1.Name = "radTextBoxControl1";
      this.radTextBoxControl1.Size = new Size(986, 711);
      this.radTextBoxControl1.TabIndex = 0;
      this.radTextBoxControl1.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(986, 711);
      this.Controls.Add((Control) this.radTextBoxControl1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmLegal);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Legal Notice";
      this.Load += new EventHandler(this.frmLegal_Load);
      this.radTextBoxControl1.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

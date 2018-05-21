// Decompiled with JetBrains decompiler
// Type: ns0.frmRawOrEmu
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
  public class frmRawOrEmu : RadForm
  {
    public bool bool_0 = true;
    private IContainer icontainer_0;
    private RadButton radButton1;
    private RadButton radButton2;

    public frmRawOrEmu()
    {
      this.InitializeComponent();
    }

    private void frmRawOrEmu_Load(object sender, EventArgs e)
    {
    }

    private void radButton2_Click(object sender, EventArgs e)
    {
      this.bool_0 = false;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.bool_0 = true;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmRawOrEmu));
      this.radButton1 = new RadButton();
      this.radButton2 = new RadButton();
      this.radButton1.BeginInit();
      this.radButton2.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radButton1.Location = new Point(25, 22);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(262, 24);
      this.radButton1.TabIndex = 0;
      this.radButton1.Text = "Delete the RAW content (for physical systems)";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.radButton2.Location = new Point(25, 52);
      this.radButton2.Name = "radButton2";
      this.radButton2.Size = new Size(262, 24);
      this.radButton2.TabIndex = 1;
      this.radButton2.Text = "Delete the emulation content (for emulators)\r\n";
      this.radButton2.Click += new EventHandler(this.radButton2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(312, 99);
      this.Controls.Add((Control) this.radButton2);
      this.Controls.Add((Control) this.radButton1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmRawOrEmu);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "What to delete";
      this.Load += new EventHandler(this.frmRawOrEmu_Load);
      this.radButton1.EndInit();
      this.radButton2.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

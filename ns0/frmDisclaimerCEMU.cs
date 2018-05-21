// Decompiled with JetBrains decompiler
// Type: ns0.frmDisclaimerCEMU
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
  public class frmDisclaimerCEMU : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel label1;
    private RadButton cmdClearDl;

    public frmDisclaimerCEMU(GClass95 gclass95_0)
    {
      this.InitializeComponent();
      this.Text = gclass95_0.Name;
      this.label1.Text = string.Format("This feature is powered by {0}.\n{1}.\nYou need to have a powerful pc to be able to play games.\nPlease note that the emulator is still in development so you might encounter issues.", (object) gclass95_0.Name, (object) gclass95_0.Url);
    }

    private void cmdClearDl_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmDisclaimerCEMU_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new RadLabel();
      this.cmdClearDl = new RadButton();
      this.label1.BeginInit();
      this.cmdClearDl.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = false;
      this.label1.Dock = DockStyle.Top;
      this.label1.Location = new Point(10, 10);
      this.label1.Name = "label1";
      this.label1.Size = new Size(424, 62);
      this.label1.TabIndex = 1;
      this.label1.Text = "This feature is powered by Cemu.\r\nhttp://cemu.info/\r\nYou need to have a powerful pc to be able to play games.\r\nPlease note that the emulator is still in development so you might encounter issues.\r\n";
      this.label1.TextAlignment = ContentAlignment.TopCenter;
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.cmdClearDl.Dock = DockStyle.Bottom;
      this.cmdClearDl.Location = new Point(10, 79);
      this.cmdClearDl.Name = "cmdClearDl";
      this.cmdClearDl.Size = new Size(424, 20);
      this.cmdClearDl.TabIndex = 27;
      this.cmdClearDl.Text = "Got it";
      this.cmdClearDl.ThemeName = "VisualStudio2012Dark";
      this.cmdClearDl.Click += new EventHandler(this.cmdClearDl_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(444, 109);
      this.Controls.Add((Control) this.cmdClearDl);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmDisclaimerCEMU);
      this.Padding = new Padding(10);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cemu";
      this.Load += new EventHandler(this.frmDisclaimerCEMU_Load);
      this.label1.EndInit();
      this.cmdClearDl.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.frmVideo
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using AxWMPLib;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
  public class frmVideo : Form
  {
    private IContainer icontainer_0;
    private AxWindowsMediaPlayer axWindowsMediaPlayer1;

    public frmVideo(string string_0)
    {
      this.InitializeComponent();
      this.axWindowsMediaPlayer1.URL = string_0;
      this.axWindowsMediaPlayer1.Ctlcontrols.play();
    }

    private void frmVideo_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.axWindowsMediaPlayer1.Dispose();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmVideo));
      this.axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
      this.axWindowsMediaPlayer1.BeginInit();
      this.SuspendLayout();
      this.axWindowsMediaPlayer1.Dock = DockStyle.Fill;
      this.axWindowsMediaPlayer1.Enabled = true;
      this.axWindowsMediaPlayer1.Location = new Point(0, 0);
      this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
      this.axWindowsMediaPlayer1.OcxState = (AxHost.State) componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState");
      this.axWindowsMediaPlayer1.Size = new Size(1099, 597);
      this.axWindowsMediaPlayer1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1099, 597);
      this.Controls.Add((Control) this.axWindowsMediaPlayer1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmVideo);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Video Player";
      this.FormClosing += new FormClosingEventHandler(this.frmVideo_FormClosing);
      this.axWindowsMediaPlayer1.EndInit();
      this.ResumeLayout(false);
    }
  }
}

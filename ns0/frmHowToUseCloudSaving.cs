// Decompiled with JetBrains decompiler
// Type: ns0.frmHowToUseCloudSaving
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
  public class frmHowToUseCloudSaving : Form
  {
    private IContainer icontainer_0;

    public frmHowToUseCloudSaving()
    {
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmHowToUseCloudSaving));
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackgroundImage = (Image) Class123.imgHowToUseCloudSaving;
      this.ClientSize = new Size(1276, 720);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmHowToUseCloudSaving);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "How to use";
      this.ResumeLayout(false);
    }
  }
}

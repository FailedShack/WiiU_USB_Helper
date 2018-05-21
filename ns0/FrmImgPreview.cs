// Decompiled with JetBrains decompiler
// Type: ns0.FrmImgPreview
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
  public class FrmImgPreview : RadForm
  {
    private IContainer icontainer_0;
    private PictureBox pbPreview;

    public FrmImgPreview(Image image_0)
    {
      this.InitializeComponent();
      this.pbPreview.Image = image_0;
    }

    public FrmImgPreview(string string_0)
    {
      this.InitializeComponent();
      this.pbPreview.ImageLocation = string_0;
    }

    private void FrmImgPreview_Load(object sender, EventArgs e)
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
      this.pbPreview = new PictureBox();
      ((ISupportInitialize) this.pbPreview).BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.pbPreview.Dock = DockStyle.Fill;
      this.pbPreview.Location = new Point(0, 0);
      this.pbPreview.MaximumSize = new Size(1920, 1080);
      this.pbPreview.Name = "pbPreview";
      this.pbPreview.Size = new Size(1272, 690);
      this.pbPreview.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pbPreview.TabIndex = 0;
      this.pbPreview.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.ClientSize = new Size(1272, 690);
      this.Controls.Add((Control) this.pbPreview);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.MaximumSize = new Size(1920, 1080);
      this.Name = nameof (FrmImgPreview);
      this.RootElement.ApplyShapeToControl = true;
      this.RootElement.MaxSize = new Size(1920, 1080);
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Screenshot";
      this.ThemeName = "Desert";
      this.Load += new EventHandler(this.FrmImgPreview_Load);
      ((ISupportInitialize) this.pbPreview).EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

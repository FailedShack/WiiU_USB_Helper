// Decompiled with JetBrains decompiler
// Type: ns0.frmSupportOver
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmSupportOver : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel label1;
    private PictureBox pictureBox1;
    private RadButton cmdClose;
    private RadLabel radLabel1;
    private RadLabel lblCloudCredentials;

    public frmSupportOver()
    {
      this.InitializeComponent();
      Class97.smethod_11((RadForm) this, 10);
      try
      {
        if (!string.IsNullOrEmpty(Settings.Default.CloudUserName))
          this.lblCloudCredentials.Text = string.Format("As a reminder, here are your Wii U USB Helper Cloud credentials :\nUsername:  {0}\nPassword:   {1}", (object) Settings.Default.CloudUserName, (object) Settings.Default.CloudPassWord);
      }
      catch
      {
      }
      Task.Run((Action) (() =>
      {
        Thread.Sleep(300000);
        Environment.Exit(0);
      }));
    }

    private void cmdClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmSupportOver_Load(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSupportOver));
      this.label1 = new RadLabel();
      this.pictureBox1 = new PictureBox();
      this.cmdClose = new RadButton();
      this.radLabel1 = new RadLabel();
      this.lblCloudCredentials = new RadLabel();
      this.label1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.cmdClose.BeginInit();
      this.radLabel1.BeginInit();
      this.lblCloudCredentials.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.label1.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(149, 86);
      this.label1.Name = "label1";
      this.label1.Size = new Size(293, 24);
      this.label1.TabIndex = 37;
      this.label1.Text = "Thank you for using Wii U USB Helper !";
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.pictureBox1.Image = (Image) Class123.logo_horiz;
      this.pictureBox1.Location = new Point(37, 14);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(385, 66);
      this.pictureBox1.TabIndex = 43;
      this.pictureBox1.TabStop = false;
      this.cmdClose.Location = new Point(197, 352);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new Size(163, 26);
      this.cmdClose.TabIndex = 42;
      this.cmdClose.Text = "Exit";
      this.cmdClose.ThemeName = "VisualStudio2012Dark";
      this.cmdClose.Click += new EventHandler(this.cmdClose_Click);
      this.radLabel1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.ImageAlignment = ContentAlignment.MiddleRight;
      this.radLabel1.Location = new Point(48, 122);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(460, 146);
      this.radLabel1.TabIndex = 38;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
      this.radLabel1.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.radLabel1.ThemeName = "VisualStudio2012Dark";
      this.lblCloudCredentials.Location = new Point(48, 274);
      this.lblCloudCredentials.Name = "lblCloudCredentials";
      this.lblCloudCredentials.Size = new Size(2, 2);
      this.lblCloudCredentials.TabIndex = 44;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(556, 390);
      this.Controls.Add((Control) this.lblCloudCredentials);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.cmdClose);
      this.Controls.Add((Control) this.radLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmSupportOver);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Thank you!";
      this.Load += new EventHandler(this.frmSupportOver_Load);
      this.label1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.cmdClose.EndInit();
      this.radLabel1.EndInit();
      this.lblCloudCredentials.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

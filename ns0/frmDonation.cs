// Decompiled with JetBrains decompiler
// Type: ns0.frmDonation
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmDonation : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel label1;
    private RadLabel radLabel1;
    private RadButton cmdDonatorKey;
    private RadButton cmdLater;
    private RadLabel radLabel2;
    private RadTextBox radTextBox1;
    private RadLabel radLabel3;
    private RadButton radButton1;
    private PictureBox pictureBox1;
    private RadLabel lblNewVersion;
    private Timer timer_0;

    public frmDonation()
    {
      this.InitializeComponent();
      Class97.smethod_11((RadForm) this, 10);
    }

    private void method_0(object sender, EventArgs e)
    {
      try
      {
        Process.Start(string.Format("{0}/donation.php", (object) Class67.String_3));
      }
      catch
      {
      }
    }

    private void cmdDonatorKey_Click(object sender, EventArgs e)
    {
      string string_0 = Clipboard.GetText().Trim();
      GClass89.smethod_1(string_0, Class123.keysPub);
      if (GClass89.Boolean_0)
      {
        int num = (int) RadMessageBox.Show("Thank you so much for donating!");
        Settings.Default.DonationKey = string_0;
        Settings.Default.Save();
        this.Close();
      }
      else
      {
        int num1 = (int) RadMessageBox.Show("The key stored in the clipboard is not valid. Please try again.");
      }
    }

    private void cmdLater_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmDonation_Load(object sender1, EventArgs e1)
    {
      this.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Hidden;
      Timer timer = new Timer();
      timer.Interval = 1500;
      timer.Tick += (EventHandler) ((sender2, e2) => this.cmdLater.Enabled = true);
      timer.Start();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      if (new frmMining().ShowDialog() != DialogResult.OK)
        return;
      this.Close();
    }

    private void radLabel2_Click(object sender, EventArgs e)
    {
      this.Size = new Size(529, 471);
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
      this.lblNewVersion.Visible = !this.lblNewVersion.Visible;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDonation));
      this.label1 = new RadLabel();
      this.radLabel1 = new RadLabel();
      this.cmdDonatorKey = new RadButton();
      this.cmdLater = new RadButton();
      this.radLabel2 = new RadLabel();
      this.radTextBox1 = new RadTextBox();
      this.radLabel3 = new RadLabel();
      this.radButton1 = new RadButton();
      this.pictureBox1 = new PictureBox();
      this.lblNewVersion = new RadLabel();
      this.timer_0 = new Timer(this.icontainer_0);
      this.label1.BeginInit();
      this.radLabel1.BeginInit();
      this.cmdDonatorKey.BeginInit();
      this.cmdLater.BeginInit();
      this.radLabel2.BeginInit();
      this.radTextBox1.BeginInit();
      this.radLabel3.BeginInit();
      this.radButton1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.lblNewVersion.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.label1.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(129, 61);
      this.label1.Name = "label1";
      this.label1.Size = new Size(293, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "Thank you for using Wii U USB Helper !";
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.radLabel1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.ImageAlignment = ContentAlignment.MiddleRight;
      this.radLabel1.Location = new Point(41, 105);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(468, 146);
      this.radLabel1.TabIndex = 2;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
      this.radLabel1.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.radLabel1.ThemeName = "VisualStudio2012Dark";
      this.cmdDonatorKey.Location = new Point(109, 260);
      this.cmdDonatorKey.Name = "cmdDonatorKey";
      this.cmdDonatorKey.Size = new Size(163, 26);
      this.cmdDonatorKey.TabIndex = 28;
      this.cmdDonatorKey.Text = "I have a Donation Key!";
      this.cmdDonatorKey.ThemeName = "VisualStudio2012Dark";
      this.cmdDonatorKey.Click += new EventHandler(this.cmdDonatorKey_Click);
      this.cmdLater.Enabled = false;
      this.cmdLater.Location = new Point(278, 260);
      this.cmdLater.Name = "cmdLater";
      this.cmdLater.Size = new Size(163, 26);
      this.cmdLater.TabIndex = 29;
      this.cmdLater.Text = "Maybe later!";
      this.cmdLater.ThemeName = "VisualStudio2012Dark";
      this.cmdLater.Click += new EventHandler(this.cmdLater_Click);
      this.radLabel2.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel2.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel2.Location = new Point(137, 483);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(367, 18);
      this.radLabel2.TabIndex = 30;
      this.radLabel2.Text = "Click here if nothing happens when you click on \"I want to donate!\"";
      this.radLabel2.Click += new EventHandler(this.radLabel2_Click);
      this.radTextBox1.Location = new Point(102, 482);
      this.radTextBox1.Name = "radTextBox1";
      this.radTextBox1.ReadOnly = true;
      this.radTextBox1.Size = new Size(497, 20);
      this.radTextBox1.TabIndex = 31;
      this.radTextBox1.Text = "http://registration.wiiuusbhelper.com/donation.php";
      this.radLabel3.Location = new Point(71, 490);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(478, 18);
      this.radLabel3.TabIndex = 32;
      this.radLabel3.Text = "Thank you so much for your support! Paste this url in your browser and follow the instructions!";
      this.radButton1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radButton1.ForeColor = Color.Green;
      this.radButton1.Location = new Point(148, 292);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(254, 26);
      this.radButton1.TabIndex = 28;
      this.radButton1.Text = "I don't have any money, how can I help?";
      this.radButton1.ThemeName = "VisualStudio2012Dark";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.pictureBox1.Image = (Image) Class123.logo_horiz;
      this.pictureBox1.Location = new Point(10, 5);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(385, 66);
      this.pictureBox1.TabIndex = 35;
      this.pictureBox1.TabStop = false;
      this.lblNewVersion.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.lblNewVersion.Location = new Point(159, 319);
      this.lblNewVersion.Name = "lblNewVersion";
      this.lblNewVersion.Size = new Size(232, 18);
      this.lblNewVersion.TabIndex = 36;
      this.lblNewVersion.Text = "--New version with improved compatibility!--";
      this.timer_0.Enabled = true;
      this.timer_0.Interval = 600;
      this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(550, 348);
      this.Controls.Add((Control) this.lblNewVersion);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.radTextBox1);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.cmdLater);
      this.Controls.Add((Control) this.cmdDonatorKey);
      this.Controls.Add((Control) this.radLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmDonation);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Donation";
      this.Load += new EventHandler(this.frmDonation_Load);
      this.label1.EndInit();
      this.radLabel1.EndInit();
      this.cmdDonatorKey.EndInit();
      this.cmdLater.EndInit();
      this.radLabel2.EndInit();
      this.radTextBox1.EndInit();
      this.radLabel3.EndInit();
      this.radButton1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.lblNewVersion.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

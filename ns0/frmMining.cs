// Decompiled with JetBrains decompiler
// Type: ns0.frmMining
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmMining : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadLabel label1;
    private PictureBox pictureBox1;
    private RadButton cmdYes;
    private RadButton cmdNo;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private RadCheckBox radPause;

    public frmMining()
    {
      this.InitializeComponent();
      Class97.smethod_11((RadForm) this, 10);
      this.radPause.Checked = Settings.Default.PauseMiner;
    }

    private void cmdYes_Click(object sender, EventArgs e)
    {
      if (!Class108.Boolean_0)
      {
        int num = (int) RadMessageBox.Show("Thank you so much for your support!\nThe app will prepare the program first, it may take a few minutes.\nYou can check if the miner is running in the Contribute tab.\nNOTE: Depending on your system configuration, the miner may request admin privileges to run.");
        Settings.Default.Mine = true;
        Class108.smethod_0();
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void frmMining_Load(object sender, EventArgs e)
    {
      this.cmdYes.ButtonElement.BorderElement.ForeColor = Color.Green;
      this.cmdNo.ButtonElement.BorderElement.ForeColor = Color.Red;
    }

    private void cmdNo_Click(object sender, EventArgs e)
    {
      Settings.Default.Mine = false;
      Settings.Default.Save();
      Class108.smethod_1();
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void radPause_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      Settings.Default.PauseMiner = this.radPause.Checked;
      Settings.Default.Save();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMining));
      this.radLabel1 = new RadLabel();
      this.label1 = new RadLabel();
      this.pictureBox1 = new PictureBox();
      this.cmdYes = new RadButton();
      this.cmdNo = new RadButton();
      this.pictureBox2 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.radPause = new RadCheckBox();
      this.radLabel1.BeginInit();
      this.label1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.cmdYes.BeginInit();
      this.cmdNo.BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.radPause.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.AutoSize = false;
      this.radLabel1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.Location = new Point(106, 32);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(502, 433);
      this.radLabel1.TabIndex = 5;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radLabel1.TextAlignment = ContentAlignment.MiddleLeft;
      this.radLabel1.ThemeName = "VisualStudio2012Dark";
      this.label1.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(106, 2);
      this.label1.Name = "label1";
      this.label1.Size = new Size(286, 24);
      this.label1.TabIndex = 4;
      this.label1.Text = "Thank you for wanting to support me!";
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.pictureBox1.Image = (Image) Class123.logo;
      this.pictureBox1.Location = new Point(6, 32);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(94, 91);
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      this.cmdYes.Location = new Point(128, 471);
      this.cmdYes.Name = "cmdYes";
      this.cmdYes.Size = new Size(180, 24);
      this.cmdYes.TabIndex = 6;
      this.cmdYes.Text = "Sure!";
      this.cmdYes.Click += new EventHandler(this.cmdYes_Click);
      this.cmdNo.Location = new Point(314, 471);
      this.cmdNo.Name = "cmdNo";
      this.cmdNo.Size = new Size(180, 24);
      this.cmdNo.TabIndex = 7;
      this.cmdNo.Text = "Maybe some other time";
      this.cmdNo.Click += new EventHandler(this.cmdNo_Click);
      this.pictureBox2.Image = (Image) Class123.stopMiner;
      this.pictureBox2.Location = new Point(405, 501);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(212, 69);
      this.pictureBox2.TabIndex = 8;
      this.pictureBox2.TabStop = false;
      this.pictureBox3.Image = (Image) Class123.startMiner;
      this.pictureBox3.Location = new Point(26, 501);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(202, 78);
      this.pictureBox3.TabIndex = 9;
      this.pictureBox3.TabStop = false;
      this.radPause.Location = new Point(5, 561);
      this.radPause.Name = "radPause";
      this.radPause.Size = new Size(303, 18);
      this.radPause.TabIndex = 10;
      this.radPause.Text = "Pause the miner when using the \"Play this game\" feature";
      this.radPause.ToggleStateChanged += new StateChangedEventHandler(this.radPause_ToggleStateChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(636, 579);
      this.Controls.Add((Control) this.radPause);
      this.Controls.Add((Control) this.pictureBox3);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.cmdNo);
      this.Controls.Add((Control) this.radLabel1);
      this.Controls.Add((Control) this.cmdYes);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmMining);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "I want to help!";
      this.Load += new EventHandler(this.frmMining_Load);
      this.radLabel1.EndInit();
      this.label1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.cmdYes.EndInit();
      this.cmdNo.EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.radPause.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

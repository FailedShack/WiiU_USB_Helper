// Decompiled with JetBrains decompiler
// Type: ns0.FrmWelcome
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
  public class FrmWelcome : RadForm
  {
    public bool bool_0;
    private IContainer icontainer_0;
    private RadLabel label1;
    private RadButton cmdUSA;
    private RadButton cmdEUR;
    private RadButton cmdJPN;
    private RadLabel label2;
    private CheckBox cmdDisclaimer;
    private RadTextBox radTextBox1;
    private RadButton radButton1;
    private RadButton radButton2;
    private RadButton cmdKOR;

    public FrmWelcome()
    {
      this.InitializeComponent();
      Class97.smethod_11((RadForm) this, 10);
    }

    private void cmdEUR_Click(object sender, EventArgs e)
    {
      Settings.Default.Region = "EUR";
      this.method_0();
    }

    private void cmdJPN_Click(object sender, EventArgs e)
    {
      Settings.Default.Region = "JPN";
      this.method_0();
    }

    private void cmdKOR_Click(object sender, EventArgs e)
    {
      Settings.Default.Region = "KOR";
      this.method_0();
    }

    private void cmdUSA_Click(object sender, EventArgs e)
    {
      Settings.Default.Region = "USA";
      this.method_0();
    }

    private void FrmWelcome_Load(object sender, EventArgs e)
    {
      this.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Hidden;
      if (!(Settings.Default.Region != "NONE"))
        return;
      this.method_0();
    }

    private void method_0()
    {
      if (this.cmdDisclaimer.Checked)
      {
        int num = (int) RadMessageBox.Show("This software is brought to you, free of charge, by Hikari06 (aka Kazegaya). If you have paid any amount of money (except donations of course) to obtain it you have been SCAMMED. Please demand a refund immediately and report the seller. The only offical places to download this software are the post on gbatemp.net as well as the official site wiiuusbhelper.com.");
        Settings.Default.Save();
        this.Close();
      }
      else
      {
        int num1 = (int) RadMessageBox.Show("You must agree to the disclaimer before using the app.");
      }
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new frmLegal().ShowDialog();
    }

    private void radButton2_Click(object sender, EventArgs e)
    {
      this.bool_0 = true;
      Application.Exit();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FrmWelcome));
      this.label1 = new RadLabel();
      this.cmdUSA = new RadButton();
      this.cmdEUR = new RadButton();
      this.cmdJPN = new RadButton();
      this.label2 = new RadLabel();
      this.cmdDisclaimer = new CheckBox();
      this.radTextBox1 = new RadTextBox();
      this.radButton1 = new RadButton();
      this.radButton2 = new RadButton();
      this.cmdKOR = new RadButton();
      this.label1.BeginInit();
      this.cmdUSA.BeginInit();
      this.cmdEUR.BeginInit();
      this.cmdJPN.BeginInit();
      this.label2.BeginInit();
      this.radTextBox1.BeginInit();
      this.radButton1.BeginInit();
      this.radButton2.BeginInit();
      this.cmdKOR.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.label1.Location = new Point(114, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(290, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Welcome ! First, please select the region of your console.";
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.cmdUSA.Image = (Image) Class123.usaFlag;
      this.cmdUSA.ImageAlignment = ContentAlignment.MiddleCenter;
      this.cmdUSA.Location = new Point(29, 68);
      this.cmdUSA.Name = "cmdUSA";
      this.cmdUSA.Size = new Size(110, 24);
      this.cmdUSA.TabIndex = 1;
      this.cmdUSA.Text = "USA";
      this.cmdUSA.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdUSA.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdUSA.ThemeName = "VisualStudio2012Dark";
      this.cmdUSA.Click += new EventHandler(this.cmdUSA_Click);
      this.cmdEUR.Image = (Image) Class123.eurFlag;
      this.cmdEUR.ImageAlignment = ContentAlignment.MiddleCenter;
      this.cmdEUR.Location = new Point(148, 68);
      this.cmdEUR.Name = "cmdEUR";
      this.cmdEUR.Size = new Size(110, 24);
      this.cmdEUR.TabIndex = 2;
      this.cmdEUR.Text = "EUR";
      this.cmdEUR.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdEUR.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdEUR.ThemeName = "VisualStudio2012Dark";
      this.cmdEUR.Click += new EventHandler(this.cmdEUR_Click);
      this.cmdJPN.Image = (Image) Class123.jpnFlag;
      this.cmdJPN.ImageAlignment = ContentAlignment.MiddleCenter;
      this.cmdJPN.Location = new Point(267, 68);
      this.cmdJPN.Name = "cmdJPN";
      this.cmdJPN.Size = new Size(110, 24);
      this.cmdJPN.TabIndex = 3;
      this.cmdJPN.Text = "JPN";
      this.cmdJPN.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdJPN.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdJPN.ThemeName = "VisualStudio2012Dark";
      this.cmdJPN.Click += new EventHandler(this.cmdJPN_Click);
      this.label2.ForeColor = Color.Red;
      this.label2.Location = new Point(98, 34);
      this.label2.Name = "label2";
      this.label2.Size = new Size(322, 18);
      this.label2.TabIndex = 4;
      this.label2.Text = "Make sure you pick the right region, otherwise it may not work.";
      this.label2.ThemeName = "VisualStudio2012Dark";
      this.cmdDisclaimer.AutoSize = true;
      this.cmdDisclaimer.ForeColor = Color.Red;
      this.cmdDisclaimer.Location = new Point(29, 190);
      this.cmdDisclaimer.Name = "cmdDisclaimer";
      this.cmdDisclaimer.Size = new Size(223, 17);
      this.cmdDisclaimer.TabIndex = 15;
      this.cmdDisclaimer.Text = "I agree to these terms and to the EULA";
      this.cmdDisclaimer.UseVisualStyleBackColor = true;
      this.radTextBox1.AutoSize = false;
      this.radTextBox1.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radTextBox1.Location = new Point(29, 104);
      this.radTextBox1.MinimumSize = new Size(0, 24);
      this.radTextBox1.Multiline = true;
      this.radTextBox1.Name = "radTextBox1";
      this.radTextBox1.ReadOnly = true;
      this.radTextBox1.RootElement.MinSize = new Size(0, 24);
      this.radTextBox1.Size = new Size(477, 76);
      this.radTextBox1.TabIndex = 16;
      this.radTextBox1.Text = componentResourceManager.GetString("radTextBox1.Text");
      this.radTextBox1.ThemeName = "VisualStudio2012Dark";
      this.radButton1.Location = new Point(430, 186);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(76, 20);
      this.radButton1.TabIndex = 17;
      this.radButton1.Text = "EULA";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.radButton2.Location = new Point(437, 10);
      this.radButton2.Name = "radButton2";
      this.radButton2.Size = new Size(31, 20);
      this.radButton2.TabIndex = 18;
      this.radButton2.Text = "X";
      this.radButton2.Click += new EventHandler(this.radButton2_Click);
      this.cmdKOR.Image = (Image) Class123.korFlag;
      this.cmdKOR.ImageAlignment = ContentAlignment.MiddleCenter;
      this.cmdKOR.Location = new Point(386, 68);
      this.cmdKOR.Name = "cmdKOR";
      this.cmdKOR.Size = new Size(110, 24);
      this.cmdKOR.TabIndex = 4;
      this.cmdKOR.Text = "KOR";
      this.cmdKOR.TextAlignment = ContentAlignment.MiddleLeft;
      this.cmdKOR.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.cmdKOR.ThemeName = "VisualStudio2012Dark";
      this.cmdKOR.Click += new EventHandler(this.cmdKOR_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(518, 210);
      this.Controls.Add((Control) this.cmdKOR);
      this.Controls.Add((Control) this.radButton2);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.radTextBox1);
      this.Controls.Add((Control) this.cmdDisclaimer);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.cmdJPN);
      this.Controls.Add((Control) this.cmdEUR);
      this.Controls.Add((Control) this.cmdUSA);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (FrmWelcome);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Welcome!";
      this.ThemeName = "VisualStudio2012Dark";
      this.Load += new EventHandler(this.FrmWelcome_Load);
      this.label1.EndInit();
      this.cmdUSA.EndInit();
      this.cmdEUR.EndInit();
      this.cmdJPN.EndInit();
      this.label2.EndInit();
      this.radTextBox1.EndInit();
      this.radButton1.EndInit();
      this.radButton2.EndInit();
      this.cmdKOR.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

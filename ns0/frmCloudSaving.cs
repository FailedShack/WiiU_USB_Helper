// Decompiled with JetBrains decompiler
// Type: ns0.frmCloudSaving
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
  public class frmCloudSaving : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadLabel radLabel2;
    private RadTextBox txtUsername;
    private RadGroupBox radGroupBox1;
    private RadButton radButton1;
    private RadToggleSwitch radEnable;
    private RadLabel radLabel3;
    private PictureBox pictureBox1;
    private RadLabel radLogged;
    private RadLabel radLabel4;
    private RadLabel radLabel5;
    private RadLabel radLabel6;
    private RadTextBoxControl txtPassword;
    private RadButton cmdManageSaves;
    private RadLabel lblShowPassword;

    public frmCloudSaving()
    {
      this.InitializeComponent();
      this.txtUsername.Text = Settings.Default.CloudUserName;
      this.txtPassword.Text = Settings.Default.CloudPassWord;
      this.radEnable.Value = Settings.Default.EnableCloudSaving;
      this.method_0();
    }

    private void method_0()
    {
      bool flag = false;
      if (!string.IsNullOrEmpty(this.txtUsername.Text) && !string.IsNullOrEmpty(this.txtPassword.Text))
        flag = Encoding.UTF8.GetString(new WebClient().UploadValues("https://cloud.wiiuusbhelper.com/saves/login.php", new NameValueCollection()
        {
          {
            "username",
            this.txtUsername.Text
          },
          {
            "password",
            this.txtPassword.Text
          }
        })) == "OK";
      if (flag)
      {
        Settings.Default.CloudUserName = this.txtUsername.Text;
        Settings.Default.CloudPassWord = this.txtPassword.Text;
        this.radLogged.ForeColor = Color.Green;
        this.radLogged.Text = "Logged in";
      }
      else
      {
        this.radLogged.ForeColor = Color.Red;
        this.radLogged.Text = "Not logged in";
        Settings.Default.EnableCloudSaving = false;
      }
      Settings.Default.Save();
      this.cmdManageSaves.Enabled = flag;
      this.radEnable.Enabled = flag;
    }

    private void cmdManageSaves_Click(object sender, EventArgs e)
    {
      new frmManageCloudSaves().Show();
    }

    private void frmCloudSaving_Load(object sender, EventArgs e)
    {
    }

    private void lblShowPassword_MouseEnter(object sender, EventArgs e)
    {
      this.lblShowPassword.ForeColor = Color.Green;
      this.txtPassword.PasswordChar = char.MinValue;
      this.txtPassword.Invalidate();
    }

    private void lblShowPassword_MouseLeave(object sender, EventArgs e)
    {
      this.lblShowPassword.ForeColor = this.radLabel6.ForeColor;
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Invalidate();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.method_0();
      if (!this.radEnable.Enabled)
      {
        int num1 = (int) RadMessageBox.Show("Please check your username/password!");
      }
      else
      {
        this.radEnable.Value = true;
        int num2 = (int) new frmHowToUseCloudSaving().ShowDialog();
      }
    }

    private void radEnable_ValueChanged(object sender, EventArgs e)
    {
      Settings.Default.EnableCloudSaving = this.radEnable.Value;
      Settings.Default.Save();
    }

    private void method_1(object sender, KeyEventArgs e)
    {
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Space && e.KeyCode != Keys.OemQuestion && (e.KeyCode != Keys.OemPipe && e.KeyCode != Keys.ControlKey))
        return;
      e.SuppressKeyPress = true;
      e.Handled = true;
    }

    private void txtPassword_TextChanging(object sender, TextChangingEventArgs e)
    {
      if (!e.NewValue.Contains("\\") && !e.NewValue.Contains("/") && (!e.NewValue.Contains(",") && !e.NewValue.Contains("*")))
        return;
      e.Cancel = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCloudSaving));
      this.radLabel1 = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.txtUsername = new RadTextBox();
      this.radGroupBox1 = new RadGroupBox();
      this.lblShowPassword = new RadLabel();
      this.txtPassword = new RadTextBoxControl();
      this.radButton1 = new RadButton();
      this.radLogged = new RadLabel();
      this.radEnable = new RadToggleSwitch();
      this.radLabel3 = new RadLabel();
      this.pictureBox1 = new PictureBox();
      this.radLabel4 = new RadLabel();
      this.radLabel5 = new RadLabel();
      this.radLabel6 = new RadLabel();
      this.cmdManageSaves = new RadButton();
      this.radLabel1.BeginInit();
      this.radLabel2.BeginInit();
      this.txtUsername.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.lblShowPassword.BeginInit();
      this.txtPassword.BeginInit();
      this.radButton1.BeginInit();
      this.radLogged.BeginInit();
      this.radEnable.BeginInit();
      this.radLabel3.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.radLabel4.BeginInit();
      this.radLabel5.BeginInit();
      this.radLabel6.BeginInit();
      this.cmdManageSaves.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.Location = new Point(24, 32);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(62, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Username :";
      this.radLabel2.Location = new Point(24, 56);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(59, 18);
      this.radLabel2.TabIndex = 1;
      this.radLabel2.Text = "Password :";
      this.txtUsername.Location = new Point(93, 29);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new Size(218, 20);
      this.txtUsername.TabIndex = 1;
      this.txtUsername.TextChanging += new TextChangingEventHandler(this.txtPassword_TextChanging);
      this.txtUsername.KeyDown += new KeyEventHandler(this.txtPassword_KeyDown);
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.lblShowPassword);
      this.radGroupBox1.Controls.Add((Control) this.txtPassword);
      this.radGroupBox1.Controls.Add((Control) this.radButton1);
      this.radGroupBox1.Controls.Add((Control) this.radLabel1);
      this.radGroupBox1.Controls.Add((Control) this.radLogged);
      this.radGroupBox1.Controls.Add((Control) this.radLabel2);
      this.radGroupBox1.Controls.Add((Control) this.txtUsername);
      this.radGroupBox1.HeaderText = "Log in";
      this.radGroupBox1.Location = new Point(54, 132);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(335, 163);
      this.radGroupBox1.TabIndex = 4;
      this.radGroupBox1.Text = "Log in";
      this.lblShowPassword.Location = new Point(227, 80);
      this.lblShowPassword.Name = "lblShowPassword";
      this.lblShowPassword.Size = new Size(84, 18);
      this.lblShowPassword.TabIndex = 9;
      this.lblShowPassword.Text = "Show Password";
      this.lblShowPassword.MouseEnter += new EventHandler(this.lblShowPassword_MouseEnter);
      this.lblShowPassword.MouseLeave += new EventHandler(this.lblShowPassword_MouseLeave);
      this.txtPassword.Location = new Point(93, 54);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new Size(218, 20);
      this.txtPassword.TabIndex = 2;
      this.txtPassword.TextChanging += new TextChangingEventHandler(this.txtPassword_TextChanging);
      this.txtPassword.KeyDown += new KeyEventHandler(this.txtPassword_KeyDown);
      this.radButton1.Image = (Image) Class123.icnMovieMini;
      this.radButton1.Location = new Point(105, 104);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(133, 24);
      this.radButton1.TabIndex = 3;
      this.radButton1.Text = "Log in/Register";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.radLogged.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLogged.Location = new Point(24, 134);
      this.radLogged.Name = "radLogged";
      this.radLogged.Size = new Size(79, 24);
      this.radLogged.TabIndex = 8;
      this.radLogged.Text = "radLabel4";
      this.radEnable.Enabled = false;
      this.radEnable.Location = new Point(138, 304);
      this.radEnable.Name = "radEnable";
      this.radEnable.Size = new Size(99, 20);
      this.radEnable.TabIndex = 5;
      this.radEnable.Value = false;
      this.radEnable.ValueChanged += new EventHandler(this.radEnable_ValueChanged);
      this.radLabel3.Location = new Point(21, 304);
      this.radLabel3.Name = "radLabel3";
      this.radLabel3.Size = new Size(111, 18);
      this.radLabel3.TabIndex = 6;
      this.radLabel3.Text = "Enable cloud saving :";
      this.pictureBox1.Image = (Image) Class123.logo_horiz;
      this.pictureBox1.Location = new Point(21, 6);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(401, 83);
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      this.radLabel4.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.radLabel4.Location = new Point(21, 74);
      this.radLabel4.Name = "radLabel4";
      this.radLabel4.Size = new Size(146, 18);
      this.radLabel4.TabIndex = 9;
      this.radLabel4.Text = "This feature is experimental.";
      this.radLabel5.Location = new Point(21, 88);
      this.radLabel5.Name = "radLabel5";
      this.radLabel5.Size = new Size(385, 18);
      this.radLabel5.TabIndex = 10;
      this.radLabel5.Text = "If you enable it, all your Cemu and Citra saves will be uploaded to the cloud.";
      this.radLabel6.Location = new Point(21, 108);
      this.radLabel6.Name = "radLabel6";
      this.radLabel6.Size = new Size(344, 18);
      this.radLabel6.TabIndex = 11;
      this.radLabel6.Text = "This way you can easily share your saves across multiple computers.";
      this.cmdManageSaves.Enabled = false;
      this.cmdManageSaves.Image = (Image) Class123.icnCaseMini;
      this.cmdManageSaves.Location = new Point(243, 301);
      this.cmdManageSaves.Name = "cmdManageSaves";
      this.cmdManageSaves.Size = new Size(163, 24);
      this.cmdManageSaves.TabIndex = 12;
      this.cmdManageSaves.Text = "Manage my cloud saves...";
      this.cmdManageSaves.Click += new EventHandler(this.cmdManageSaves_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(442, 334);
      this.Controls.Add((Control) this.cmdManageSaves);
      this.Controls.Add((Control) this.radLabel6);
      this.Controls.Add((Control) this.radLabel5);
      this.Controls.Add((Control) this.radLabel4);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.radLabel3);
      this.Controls.Add((Control) this.radEnable);
      this.Controls.Add((Control) this.radGroupBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmCloudSaving);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Cloud Saving";
      this.Load += new EventHandler(this.frmCloudSaving_Load);
      this.radLabel1.EndInit();
      this.radLabel2.EndInit();
      this.txtUsername.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      this.lblShowPassword.EndInit();
      this.txtPassword.EndInit();
      this.radButton1.EndInit();
      this.radLogged.EndInit();
      this.radEnable.EndInit();
      this.radLabel3.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.radLabel4.EndInit();
      this.radLabel5.EndInit();
      this.radLabel6.EndInit();
      this.cmdManageSaves.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

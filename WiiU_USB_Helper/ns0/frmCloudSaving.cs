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
	// Token: 0x02000173 RID: 371
	public partial class frmCloudSaving : RadForm
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003C25C File Offset: 0x0003A45C
		public frmCloudSaving()
		{
			this.InitializeComponent();
			this.txtUsername.Text = Settings.Default.CloudUserName;
			this.txtPassword.Text = Settings.Default.CloudPassWord;
			this.radEnable.Value = Settings.Default.EnableCloudSaving;
			this.method_0();
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003C2BC File Offset: 0x0003A4BC
		private void method_0()
		{
			bool flag = false;
			if (!string.IsNullOrEmpty(this.txtUsername.Text) && !string.IsNullOrEmpty(this.txtPassword.Text))
			{
				flag = (Encoding.UTF8.GetString(new WebClient().UploadValues("https://cloud.wiiuusbhelper.com/saves/login.php", new NameValueCollection
				{
					{
						"username",
						this.txtUsername.Text
					},
					{
						"password",
						this.txtPassword.Text
					}
				})) == "OK");
			}
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

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001797A File Offset: 0x00015B7A
		private void cmdManageSaves_Click(object sender, EventArgs e)
		{
			new frmManageCloudSaves().Show();
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmCloudSaving_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00017986 File Offset: 0x00015B86
		private void lblShowPassword_MouseEnter(object sender, EventArgs e)
		{
			this.lblShowPassword.ForeColor = Color.Green;
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.Invalidate();
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000179AF File Offset: 0x00015BAF
		private void lblShowPassword_MouseLeave(object sender, EventArgs e)
		{
			this.lblShowPassword.ForeColor = this.radLabel6.ForeColor;
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Invalidate();
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000179DF File Offset: 0x00015BDF
		private void radButton1_Click(object sender, EventArgs e)
		{
			this.method_0();
			if (!this.radEnable.Enabled)
			{
				RadMessageBox.Show("Please check your username/password!");
				return;
			}
			this.radEnable.Value = true;
			new frmHowToUseCloudSaving().ShowDialog();
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00017A17 File Offset: 0x00015C17
		private void radEnable_ValueChanged(object sender, EventArgs e)
		{
			Settings.Default.EnableCloudSaving = this.radEnable.Value;
			Settings.Default.Save();
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000142A3 File Offset: 0x000124A3
		private void method_1(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00017A38 File Offset: 0x00015C38
		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space || e.KeyCode == Keys.OemQuestion || e.KeyCode == Keys.OemPipe || e.KeyCode == Keys.ControlKey)
			{
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0003C3E0 File Offset: 0x0003A5E0
		private void txtPassword_TextChanging(object sender, TextChangingEventArgs e)
		{
			if (e.NewValue.Contains("\\") || e.NewValue.Contains("/") || e.NewValue.Contains(",") || e.NewValue.Contains("*"))
			{
				e.Cancel = true;
			}
		}
	}
}

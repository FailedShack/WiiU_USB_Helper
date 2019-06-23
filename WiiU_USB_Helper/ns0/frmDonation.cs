using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x02000191 RID: 401
	public partial class frmDonation : RadForm
	{
		// Token: 0x06000B57 RID: 2903 RVA: 0x00017F89 File Offset: 0x00016189
		public frmDonation()
		{
			this.InitializeComponent();
			Class95.smethod_11(this, 10);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000428E0 File Offset: 0x00040AE0
		private void method_0(object sender, EventArgs e)
		{
			try
			{
				Process.Start(string.Format("{0}/donation.php", Class65.String_3));
			}
			catch
			{
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00042918 File Offset: 0x00040B18
		private void cmdDonatorKey_Click(object sender, EventArgs e)
		{
			string text = Clipboard.GetText().Trim();
			GClass89.smethod_1(text, Class121.keysPub);
			if (GClass89.Boolean_0)
			{
				RadMessageBox.Show("Thank you so much for donating!");
				Settings.Default.DonationKey = text;
				Settings.Default.Save();
				base.Close();
				return;
			}
			RadMessageBox.Show("The key stored in the clipboard is not valid. Please try again.");
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001564E File Offset: 0x0001384E
		private void cmdLater_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00017F9F File Offset: 0x0001619F
		private void frmDonation_Load(object sender, EventArgs e)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Hidden;
			Timer timer = new Timer();
			timer.Interval = 1500;
			timer.Tick += this.method_1;
			timer.Start();
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00017FDE File Offset: 0x000161DE
		private void radButton1_Click(object sender, EventArgs e)
		{
			if (new frmMining().ShowDialog() == DialogResult.OK)
			{
				base.Close();
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00017FF3 File Offset: 0x000161F3
		private void radLabel2_Click(object sender, EventArgs e)
		{
			base.Size = new Size(529, 471);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001800A File Offset: 0x0001620A
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.lblNewVersion.Visible = !this.lblNewVersion.Visible;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00018044 File Offset: 0x00016244
		[CompilerGenerated]
		private void method_1(object sender, EventArgs e)
		{
			this.cmdLater.Enabled = true;
		}
	}
}

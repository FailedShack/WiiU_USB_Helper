using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001FB RID: 507
	public partial class FrmWelcome : RadForm
	{
		// Token: 0x06000E10 RID: 3600 RVA: 0x00019864 File Offset: 0x00017A64
		public FrmWelcome()
		{
			this.InitializeComponent();
			Class95.smethod_11(this, 10);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0001987A File Offset: 0x00017A7A
		private void cmdEUR_Click(object sender, EventArgs e)
		{
			Settings.Default.Region = "EUR";
			this.method_0();
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00019891 File Offset: 0x00017A91
		private void cmdJPN_Click(object sender, EventArgs e)
		{
			Settings.Default.Region = "JPN";
			this.method_0();
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000198A8 File Offset: 0x00017AA8
		private void cmdKOR_Click(object sender, EventArgs e)
		{
			Settings.Default.Region = "KOR";
			this.method_0();
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000198BF File Offset: 0x00017ABF
		private void cmdUSA_Click(object sender, EventArgs e)
		{
			Settings.Default.Region = "USA";
			this.method_0();
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000198D6 File Offset: 0x00017AD6
		private void FrmWelcome_Load(object sender, EventArgs e)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Hidden;
			if (Settings.Default.Region != "NONE")
			{
				this.method_0();
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0001990A File Offset: 0x00017B0A
		private void method_0()
		{
			if (this.cmdDisclaimer.Checked)
			{
				RadMessageBox.Show("This software is brought to you, free of charge, by Hikari06 (aka Kazegaya). If you have paid any amount of money (except donations of course) to obtain it you have been SCAMMED. Please demand a refund immediately and report the seller. The only offical places to download this software are the post on gbatemp.net as well as the official site wiiuusbhelper.com.");
				Settings.Default.Save();
				base.Close();
				return;
			}
			RadMessageBox.Show("You must agree to the disclaimer before using the app.");
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00018F60 File Offset: 0x00017160
		private void radButton1_Click(object sender, EventArgs e)
		{
			new frmLegal().ShowDialog();
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00019940 File Offset: 0x00017B40
		private void radButton2_Click(object sender, EventArgs e)
		{
			this.bool_0 = true;
			Application.Exit();
		}

		// Token: 0x04000A2E RID: 2606
		public bool bool_0;
	}
}

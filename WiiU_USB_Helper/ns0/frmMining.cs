using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001A3 RID: 419
	public partial class frmMining : RadForm
	{
		// Token: 0x06000BB2 RID: 2994 RVA: 0x000183BE File Offset: 0x000165BE
		public frmMining()
		{
			this.InitializeComponent();
			Class95.smethod_11(this, 10);
			this.radPause.Checked = Settings.Default.PauseMiner;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000183E9 File Offset: 0x000165E9
		private void cmdYes_Click(object sender, EventArgs e)
		{
			if (!Class106.Boolean_0)
			{
				RadMessageBox.Show("Thank you so much for your support!\nThe app will prepare the program first, it may take a few minutes.\nYou can check if the miner is running in the Contribute tab.\nNOTE: Depending on your system configuration, the miner may request admin privileges to run.");
				Settings.Default.Mine = true;
				Class106.smethod_0();
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0001841A File Offset: 0x0001661A
		private void frmMining_Load(object sender, EventArgs e)
		{
			this.cmdYes.ButtonElement.BorderElement.ForeColor = Color.Green;
			this.cmdNo.ButtonElement.BorderElement.ForeColor = Color.Red;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00018450 File Offset: 0x00016650
		private void cmdNo_Click(object sender, EventArgs e)
		{
			Settings.Default.Mine = false;
			Settings.Default.Save();
			Class106.smethod_1();
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00018479 File Offset: 0x00016679
		private void radPause_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.PauseMiner = this.radPause.Checked;
			Settings.Default.Save();
		}
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001B2 RID: 434
	public partial class frmSupportOver : RadForm
	{
		// Token: 0x06000BFF RID: 3071 RVA: 0x0004ADC0 File Offset: 0x00048FC0
		public frmSupportOver()
		{
			this.InitializeComponent();
			Class95.smethod_11(this, 10);
			try
			{
				if (!string.IsNullOrEmpty(Settings.Default.CloudUserName))
				{
					this.lblCloudCredentials.Text = string.Format("As a reminder, here are your Wii U USB Helper Cloud credentials :\nUsername:  {0}\nPassword:   {1}", Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
				}
			}
			catch
			{
			}
			Task.Run(new Action(frmSupportOver.<>c.<>c_0.method_0));
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0001564E File Offset: 0x0001384E
		private void cmdClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmSupportOver_Load(object sender, EventArgs e)
		{
		}
	}
}

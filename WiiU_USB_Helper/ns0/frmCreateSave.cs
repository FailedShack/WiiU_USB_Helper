using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200018F RID: 399
	public partial class frmCreateSave : RadForm
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x00017F02 File Offset: 0x00016102
		public frmCreateSave()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmCreateSave_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00017ED4 File Offset: 0x000160D4
		private void radButton1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00042314 File Offset: 0x00040514
		private void cmdbackup_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtDescription.Text.Trim()))
			{
				RadMessageBox.Show("Please enter a valid description");
				return;
			}
			this.string_0 = this.txtDescription.Text.Trim();
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x040006A7 RID: 1703
		public string string_0;
	}
}

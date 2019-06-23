using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001A6 RID: 422
	public partial class frmRawOrEmu : RadForm
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x000184D8 File Offset: 0x000166D8
		public frmRawOrEmu()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmRawOrEmu_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000184ED File Offset: 0x000166ED
		private void radButton2_Click(object sender, EventArgs e)
		{
			this.bool_0 = false;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00018503 File Offset: 0x00016703
		private void radButton1_Click(object sender, EventArgs e)
		{
			this.bool_0 = true;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x04000721 RID: 1825
		public bool bool_0 = true;
	}
}

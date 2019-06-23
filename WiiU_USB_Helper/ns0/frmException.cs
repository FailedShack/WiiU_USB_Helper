using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000186 RID: 390
	public partial class frmException : RadForm
	{
		// Token: 0x06000B20 RID: 2848 RVA: 0x00017D69 File Offset: 0x00015F69
		public frmException()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmException_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001564E File Offset: 0x0001384E
		private void radButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}

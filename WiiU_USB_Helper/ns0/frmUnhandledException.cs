using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001AE RID: 430
	public partial class frmUnhandledException : RadForm
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x000186C0 File Offset: 0x000168C0
		public frmUnhandledException(Exception exception_0)
		{
			this.InitializeComponent();
			this.lblException.Text = exception_0.ToString();
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0001564E File Offset: 0x0001384E
		private void cmdLater_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000186DF File Offset: 0x000168DF
		private void radButton1_Click(object sender, EventArgs e)
		{
			new frmSupport(this.lblException.Text).ShowDialog();
		}
	}
}

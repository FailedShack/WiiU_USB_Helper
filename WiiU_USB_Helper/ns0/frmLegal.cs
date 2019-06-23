using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200019D RID: 413
	public partial class frmLegal : RadForm
	{
		// Token: 0x06000B9A RID: 2970 RVA: 0x00018293 File Offset: 0x00016493
		public frmLegal()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000182A1 File Offset: 0x000164A1
		private void frmLegal_Load(object sender, EventArgs e)
		{
			this.radTextBoxControl1.Text = Class121.legal;
		}
	}
}

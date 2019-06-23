using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000176 RID: 374
	public partial class frmDownloadDotNet : Form
	{
		// Token: 0x06000ADE RID: 2782 RVA: 0x00017AE7 File Offset: 0x00015CE7
		public frmDownloadDotNet()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00017AF5 File Offset: 0x00015CF5
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=55170");
		}
	}
}

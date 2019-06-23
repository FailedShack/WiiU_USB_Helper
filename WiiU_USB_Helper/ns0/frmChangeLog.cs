using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200013F RID: 319
	public partial class frmChangeLog : RadForm
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x0001589B File Offset: 0x00013A9B
		public frmChangeLog()
		{
			this.InitializeComponent();
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000361E0 File Offset: 0x000343E0
		private void frmChangeLog_Load(object sender, EventArgs e)
		{
			try
			{
				GClass78 gclass = new GClass78();
				this.txtLog.Text = gclass.method_6(string.Format("{0}/res/txt/changelog.txt", Class65.String_2)).Replace("\n", "\r\n");
			}
			catch
			{
			}
		}
	}
}

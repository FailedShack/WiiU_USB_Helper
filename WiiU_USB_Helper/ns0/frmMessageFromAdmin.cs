using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001A2 RID: 418
	public partial class frmMessageFromAdmin : RadForm
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x0001834E File Offset: 0x0001654E
		public frmMessageFromAdmin(string string_0)
		{
			this.InitializeComponent();
			this.txtMessage.Text = string_0;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0001564E File Offset: 0x0001384E
		private void closeButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00018368 File Offset: 0x00016568
		private void frmMessageFromAdmin_Load(object sender, EventArgs e)
		{
			Timer timer = new Timer();
			timer.Interval = 5000;
			timer.Tick += this.method_0;
			timer.Start();
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000183B0 File Offset: 0x000165B0
		[CompilerGenerated]
		private void method_0(object sender, EventArgs e)
		{
			this.closeButton.Enabled = true;
		}
	}
}

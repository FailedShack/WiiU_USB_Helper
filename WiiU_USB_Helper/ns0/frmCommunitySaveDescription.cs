using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001B6 RID: 438
	public partial class frmCommunitySaveDescription : RadForm
	{
		// Token: 0x06000C18 RID: 3096 RVA: 0x000188B4 File Offset: 0x00016AB4
		public frmCommunitySaveDescription()
		{
			this.InitializeComponent();
			this.txtDescription.MaxLength = 125;
			this.method_0();
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000188D5 File Offset: 0x00016AD5
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000188DD File Offset: 0x00016ADD
		public string Description { get; set; }

		// Token: 0x06000C1B RID: 3099 RVA: 0x000188E6 File Offset: 0x00016AE6
		private void cmdSubmit_Click(object sender, EventArgs e)
		{
			this.Description = this.txtDescription.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00018906 File Offset: 0x00016B06
		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0004B498 File Offset: 0x00049698
		private void method_0()
		{
			this.lblLength.Text = string.Format("{0} character(s) ({1} minimum, {2} maximum)", this.txtDescription.Text.Length, 40, 125);
			this.cmdSubmit.Enabled = (this.txtDescription.Text.Length >= 40 && this.txtDescription.Text.Length <= 125);
		}

		// Token: 0x04000799 RID: 1945
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400079A RID: 1946
		private const int int_0 = 125;

		// Token: 0x0400079B RID: 1947
		private const int int_1 = 40;
	}
}

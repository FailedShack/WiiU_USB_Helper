using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000190 RID: 400
	public partial class frmDisclaimerCEMU : RadForm
	{
		// Token: 0x06000B52 RID: 2898 RVA: 0x00017F2F File Offset: 0x0001612F
		public frmDisclaimerCEMU(GClass95 gclass95_0)
		{
			this.InitializeComponent();
			this.Text = gclass95_0.Name;
			this.label1.Text = string.Format("This feature is powered by {0}.\n{1}.\nYou need to have a powerful pc to be able to play games.\nPlease note that the emulator is still in development so you might encounter issues.", gclass95_0.Name, gclass95_0.Url);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001564E File Offset: 0x0001384E
		private void cmdClearDl_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmDisclaimerCEMU_Load(object sender, EventArgs e)
		{
		}
	}
}

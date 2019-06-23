using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;

namespace ns0
{
	// Token: 0x020001B1 RID: 433
	public partial class frmVideo : Form
	{
		// Token: 0x06000BFB RID: 3067 RVA: 0x00018764 File Offset: 0x00016964
		public frmVideo(string string_0)
		{
			this.InitializeComponent();
			this.axWindowsMediaPlayer1.URL = string_0;
			this.axWindowsMediaPlayer1.Ctlcontrols.play();
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0001878E File Offset: 0x0001698E
		private void frmVideo_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.axWindowsMediaPlayer1.Dispose();
		}
	}
}

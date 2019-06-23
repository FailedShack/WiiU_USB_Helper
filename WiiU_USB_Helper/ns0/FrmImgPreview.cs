using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001D1 RID: 465
	public partial class FrmImgPreview : RadForm
	{
		// Token: 0x06000CA1 RID: 3233 RVA: 0x00018CB2 File Offset: 0x00016EB2
		public FrmImgPreview(Image image_0)
		{
			this.InitializeComponent();
			this.pbPreview.Image = image_0;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00018CCC File Offset: 0x00016ECC
		public FrmImgPreview(string string_0)
		{
			this.InitializeComponent();
			this.pbPreview.ImageLocation = string_0;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000142A3 File Offset: 0x000124A3
		private void FrmImgPreview_Load(object sender, EventArgs e)
		{
		}
	}
}

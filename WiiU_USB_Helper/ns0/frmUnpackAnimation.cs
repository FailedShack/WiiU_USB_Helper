using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001AF RID: 431
	public partial class frmUnpackAnimation : Form
	{
		// Token: 0x06000BF0 RID: 3056 RVA: 0x0004A6C8 File Offset: 0x000488C8
		public frmUnpackAnimation(GClass30 gclass30_0)
		{
			this.InitializeComponent();
			base.Region = Class95.smethod_6(this, 40);
			GClass32 gclass = null;
			if (gclass30_0 is GClass32)
			{
				gclass = (gclass30_0 as GClass32);
				this.lblTile.Text = gclass.Name;
			}
			if (gclass30_0 is GClass31)
			{
				gclass = GClass28.dictionary_0[new TitleId(gclass30_0.TitleId.FullGame)];
				this.lblTile.Text = gclass.Name + " DLC";
			}
			if (gclass30_0 is GClass33)
			{
				gclass = GClass28.dictionary_0[new TitleId(gclass30_0.TitleId.FullGame)];
				this.lblTile.Text = gclass.Name + " UPDATE";
			}
			this.pictureBox1.Image = gclass.gclass86_0.Image;
			gclass.method_28(new Action<GClass74, GClass32>(this.method_2));
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0004A7C8 File Offset: 0x000489C8
		public void method_0()
		{
			try
			{
				this.bool_0 = true;
				base.BeginInvoke(new Action(base.Close));
			}
			catch
			{
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0004A804 File Offset: 0x00048A04
		public void method_1(GStruct0 gstruct0_0)
		{
			frmUnpackAnimation.Class152 @class = new frmUnpackAnimation.Class152();
			@class.gstruct0_0 = gstruct0_0;
			@class.frmUnpackAnimation_0 = this;
			try
			{
				base.Invoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00018716 File Offset: 0x00016916
		private void frmUnpackAnimation_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.bool_0)
			{
				RadMessageBox.Show("You cannot close this window while the title is extracting. Please wait for the end of the process");
				e.Cancel = true;
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000142A3 File Offset: 0x000124A3
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0004A850 File Offset: 0x00048A50
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.pictureBox1.Left += this.int_0;
			if (this.pictureBox1.Left <= -640 || this.pictureBox1.Left >= 0)
			{
				this.int_0 *= -1;
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00018751 File Offset: 0x00016951
		[CompilerGenerated]
		private void method_2(GClass74 gclass74_0, GClass32 gclass32_0)
		{
			this.pictureBox1.ImageLocation = gclass74_0.BannerUrl;
		}

		// Token: 0x0400077B RID: 1915
		private bool bool_0;

		// Token: 0x0400077C RID: 1916
		private int int_0 = -1;

		// Token: 0x020001B0 RID: 432
		[CompilerGenerated]
		private sealed class Class152
		{
			// Token: 0x06000BFA RID: 3066 RVA: 0x0004ABEC File Offset: 0x00048DEC
			internal void method_0()
			{
				if (this.gstruct0_0.int_1 > 100)
				{
					this.gstruct0_0.int_1 = 100;
				}
				this.frmUnpackAnimation_0.radProgressBar1.Value1 = this.gstruct0_0.int_1;
				this.frmUnpackAnimation_0.lblFiles.Text = string.Format("{0}/{1}", this.gstruct0_0.int_0, this.gstruct0_0.int_2);
			}

			// Token: 0x04000783 RID: 1923
			public GStruct0 gstruct0_0;

			// Token: 0x04000784 RID: 1924
			public frmUnpackAnimation frmUnpackAnimation_0;
		}
	}
}

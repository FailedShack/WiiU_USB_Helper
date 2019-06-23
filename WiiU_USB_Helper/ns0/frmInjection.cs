using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000195 RID: 405
	public partial class frmInjection : RadForm
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x000436AC File Offset: 0x000418AC
		public frmInjection(GClass32 gclass32_1)
		{
			frmInjection.Class145 @class = new frmInjection.Class145();
			@class.gclass32_0 = gclass32_1;
			base..ctor();
			@class.frmInjection_0 = this;
			this.InitializeComponent();
			if (!@class.gclass32_0.Boolean_0)
			{
				throw new ArgumentException("Only injectable titles can be provided!");
			}
			this.gclass32_0 = @class.gclass32_0;
			new FrmWait("The injection tool is starting...", new Action(@class.method_0), null);
			this.string_1 = string.Format("<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required {0}.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>", this.gclass91_0.String_1);
			this.grpDrop.Text = string.Format("Drop the following {0} : {1}({2}) {3}", new object[]
			{
				this.gclass91_0.String_1,
				this.gclass32_0.Name,
				this.gclass32_0.ProductId,
				this.gclass32_0.Region
			});
			this.lblDrop.Text = string.Format("Drop the following {0} : {1}({2}) {3}", new object[]
			{
				this.gclass91_0.String_1,
				this.gclass32_0.Name,
				this.gclass32_0.ProductId,
				this.gclass32_0.Region
			});
			if (this.gclass32_0.Platform != Platform.Gamecube)
			{
				this.chkRatio.Enabled = false;
			}
			if (this.gclass32_0.Platform == Platform.Gamecube)
			{
				this.lblIntro.Text = "<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>This way you can enjoy Gamecube games with your Wii U Gamepad!</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required ISO.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>";
			}
			else
			{
				this.lblIntro.Text = this.string_1;
			}
			this.method_3();
			if (this.gclass32_0.Platform == Platform.Gamecube)
			{
				base.Size = new Size(609, 465);
				return;
			}
			base.Size = new Size(609, 362);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000180C1 File Offset: 0x000162C1
		private void method_0(object sender, StateChangingEventArgs e)
		{
			if (e.NewValue == ToggleState.Off && RadMessageBox.Show("If you disable this you will NOT be able to play this game with your GamePad. Continue?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0004386C File Offset: 0x00041A6C
		private void cmdBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Multiselect = false,
				CheckFileExists = true
			};
			openFileDialog.Filter = this.gclass91_0.String_2;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_4(openFileDialog.FileName);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000438B4 File Offset: 0x00041AB4
		private void cmdPrepareSd_Click(object sender, EventArgs e)
		{
			FrmSelectDrive frmSelectDrive = new FrmSelectDrive(new DataSize(5000000UL));
			if (frmSelectDrive.ShowDialog() == DialogResult.OK)
			{
				GClass94.smethod_9(frmSelectDrive.driveInfo_0);
				GClass94.smethod_10(frmSelectDrive.driveInfo_0);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000438F4 File Offset: 0x00041AF4
		private void frmInjection_Load(object sender, EventArgs e)
		{
			this.pictureBox1.ImageLocation = this.gclass32_0.IconUrl;
			if (!GClass91.Boolean_0)
			{
				if (RadMessageBox.Show("Java is not installed but is required to use this feature. Would you like to install it now?", "Java", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					RadMessageBox.Show("The process cannot continue without Java.");
					base.Close();
					return;
				}
				Process.Start("https://www.java.com/en/");
				RadMessageBox.Show("Please restart the app once you have installed Java.");
				base.Close();
			}
			GClass94 gclass;
			if ((gclass = (this.gclass91_0 as GClass94)) != null && gclass.PatchGame != null && gclass.method_14())
			{
				base.Close();
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00043988 File Offset: 0x00041B88
		private void grpDrop_DragDrop(object sender, DragEventArgs e)
		{
			string string_ = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
			this.method_4(string_);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000180E5 File Offset: 0x000162E5
		private void grpDrop_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00018100 File Offset: 0x00016300
		private void method_1()
		{
			new frmInjectionAnimation(this.gclass91_0).ShowDialog();
			base.Close();
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00018119 File Offset: 0x00016319
		private void method_2()
		{
			RadMessageBox.Show("Your java version is too old. Please go to https://www.java.com/en/ , install it, resart the app and try again.");
			base.Close();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001812C File Offset: 0x0001632C
		private void radButton1_Click(object sender, EventArgs e)
		{
			Process.Start(string.Format("{0}/vote/gamecube.php", Class65.String_3));
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00018143 File Offset: 0x00016343
		private void radLabel2_Click(object sender, EventArgs e)
		{
			RadMessageBox.Show("This feature is made possible by the following tools:\n-nfs2iso2nfs by FIX94\n-Nintendont by FIX94\n-wit by Wiimm\n-NusPacker by timogus");
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000439B4 File Offset: 0x00041BB4
		private void method_3()
		{
			this.lblCount.Text = string.Format("{0} {1}(s) provided out of {2}", this.gclass91_0.vmethod_1(), this.gclass91_0.String_1, this.gclass91_0.RomCount);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00018150 File Offset: 0x00016350
		private void method_4(string string_2)
		{
			if (this.gclass91_0.vmethod_0(string_2))
			{
				this.method_1();
			}
			this.method_3();
		}

		// Token: 0x040006C7 RID: 1735
		private const string string_0 = "<html><p><strong><span style=\"font-size: 10pt\">Welcome to the USB Helper Injection Tool!</span></strong></p><p></p><p>You have selected a title which is normally not available on the eShop.</p><p>USB Helper allows you to build a game that will be launchable from the home menu.</p><p>This way you can enjoy Gamecube games with your Wii U Gamepad!</p><p>USB Helper will take care of almost everything for you!</p><p><span style=\"color: #ff8000\">The only thing you have to do is to provide the required ISO.</span></p><p>Just drop it in the box below and have fun!<br /><span style=\"color: #000000\"> <p></p><p></p></span></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p><p></p></html>";

		// Token: 0x040006C8 RID: 1736
		private string string_1;

		// Token: 0x040006C9 RID: 1737
		private GClass91 gclass91_0;

		// Token: 0x040006CA RID: 1738
		private GClass32 gclass32_0;

		// Token: 0x02000196 RID: 406
		internal sealed class Class144
		{
			// Token: 0x040006D9 RID: 1753
			[JsonProperty("force43")]
			public bool bool_0;
		}

		// Token: 0x02000197 RID: 407
		[CompilerGenerated]
		private sealed class Class145
		{
			// Token: 0x06000B7E RID: 2942 RVA: 0x0001818B File Offset: 0x0001638B
			internal void method_0()
			{
				this.frmInjection_0.gclass91_0 = this.gclass32_0.method_21();
			}

			// Token: 0x040006DA RID: 1754
			public frmInjection frmInjection_0;

			// Token: 0x040006DB RID: 1755
			public GClass32 gclass32_0;
		}
	}
}

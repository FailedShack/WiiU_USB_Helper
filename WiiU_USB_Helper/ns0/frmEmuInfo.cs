using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Alphaleonis.Win32.Filesystem;
using NusHelper.Emulators;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200017F RID: 383
	public partial class frmEmuInfo : RadForm
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x00017BEB File Offset: 0x00015DEB
		public frmEmuInfo(GClass32 gclass32_1)
		{
			this.gclass32_0 = gclass32_1;
			this.InitializeComponent();
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00017C00 File Offset: 0x00015E00
		private static string smethod_0(bool bool_1)
		{
			if (!bool_1)
			{
				return "Not installed";
			}
			return "Installed";
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00017C10 File Offset: 0x00015E10
		private void chkExceptionDLC_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			if (this.chkExceptionDLC.Checked)
			{
				GClass3.smethod_0(this.gclass32_0.Dlc);
				return;
			}
			GClass3.smethod_1(this.gclass32_0.Dlc);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0003EC44 File Offset: 0x0003CE44
		private void chkExceptionUpdate_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (this.bool_0)
			{
				return;
			}
			if (this.chkExceptionUpdate.Checked)
			{
				GClass3.smethod_0(this.gclass32_0.Updates[0]);
				return;
			}
			GClass3.smethod_1(this.gclass32_0.Updates[0]);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00017C49 File Offset: 0x00015E49
		private void cmdDeleteDlc_Click(object sender, EventArgs e)
		{
			this.gclass95_0.DeleteDlc();
			this.method_0();
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00017C5C File Offset: 0x00015E5C
		private void cmdDeleteGame_Click(object sender, EventArgs e)
		{
			this.gclass95_0.vmethod_1();
			this.method_0();
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00017C6F File Offset: 0x00015E6F
		private void cmdDeleteUpdate_Click(object sender, EventArgs e)
		{
			this.gclass95_0.DeleteUpdate();
			this.method_0();
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00017C82 File Offset: 0x00015E82
		private void cmdVerifyDlc_Click(object sender, EventArgs e)
		{
			this.method_1(this.gclass32_0.Dlc, (Cemu)this.gclass32_0.method_14(false));
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00017CA6 File Offset: 0x00015EA6
		private void cmdVerifyGame_Click(object sender, EventArgs e)
		{
			this.method_1(this.gclass32_0, (Cemu)this.gclass32_0.method_14(false));
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0003EC94 File Offset: 0x0003CE94
		private void cmdVerifyUpdate_Click(object sender, EventArgs e)
		{
			frmEmuInfo.Class136 @class = new frmEmuInfo.Class136();
			Cemu cemu = (Cemu)this.gclass32_0.method_14(false);
			@class.ulong_0 = cemu.GetUpdateVersion();
			this.method_1(this.gclass32_0.Updates.Find(new Predicate<GClass33>(@class.method_0)), cemu);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmEmuInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00017CC5 File Offset: 0x00015EC5
		private void frmEmuInfo_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0003ECE8 File Offset: 0x0003CEE8
		private void method_0()
		{
			this.gclass95_0 = this.gclass32_0.method_14(false);
			if (this.gclass95_0 == null)
			{
				RadMessageBox.Show("This title does not support emulation, so there is nothing to show here!");
				base.Close();
				return;
			}
			this.lblEmuName.Text = this.gclass95_0.Name;
			this.lblEmuPath.Text = this.gclass95_0.String_4;
			this.lblEmuStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.Boolean_0);
			this.lblGameStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.Boolean_2);
			this.lblUpdateStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.UpdateIsInstalled());
			this.lblDLCStatus.Text = frmEmuInfo.smethod_0(this.gclass95_0.DlcIsInstalled());
			this.bool_0 = true;
			if (this.gclass32_0.Boolean_2)
			{
				this.chkExceptionDLC.Checked = GClass3.smethod_3(this.gclass32_0.Dlc);
			}
			else
			{
				this.chkExceptionDLC.Enabled = false;
			}
			if (this.gclass32_0.Boolean_3)
			{
				this.chkExceptionUpdate.Checked = GClass3.smethod_3(this.gclass32_0.Updates[0]);
			}
			else
			{
				this.chkExceptionUpdate.Enabled = false;
			}
			this.bool_0 = false;
			this.lblUpdateVersion.Text = string.Format("v{0}", this.gclass95_0.GetUpdateVersion());
			bool flag = this.gclass32_0.method_14(false) is Cemu;
			this.cmdVerifyGame.Visible = (flag && this.gclass95_0.Boolean_2);
			this.cmdVerifyUpdate.Visible = (flag && this.gclass95_0.UpdateIsInstalled());
			this.cmdVerifyDlc.Visible = (flag && this.gclass95_0.DlcIsInstalled());
			this.cmdDeleteGame.Enabled = this.gclass95_0.Boolean_2;
			this.cmdDeleteUpdate.Enabled = this.gclass95_0.UpdateIsInstalled();
			this.cmdDeleteDlc.Enabled = this.gclass95_0.DlcIsInstalled();
			this.pictGame.Image = this.gclass32_0.gclass86_2.Image;
			foreach (object obj in this.radGroupBox1.Controls)
			{
				if (obj is RadGroupBox)
				{
					foreach (object obj2 in ((RadGroupBox)obj).Controls)
					{
						if (obj2 is RadLabel)
						{
							RadLabel radLabel = (RadLabel)obj2;
							string text = radLabel.Text;
							if (!(text == "Installed"))
							{
								if (text == "Not installed")
								{
									radLabel.ForeColor = Color.Red;
								}
							}
							else
							{
								radLabel.ForeColor = Color.Green;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0003F018 File Offset: 0x0003D218
		private void method_1(GClass30 gclass30_0, Cemu cemu_0)
		{
			frmEmuInfo.Class137 @class = new frmEmuInfo.Class137();
			@class.gclass30_0 = gclass30_0;
			@class.cemu_0 = cemu_0;
			@class.bool_0 = false;
			new FrmWait("USB Helper is verifying your data...", new Action(@class.method_0), new Action<Exception>(frmEmuInfo.<>c.<>c_0.method_0));
			if (@class.bool_0)
			{
				RadMessageBox.Show("USB Helper has detected that this title wasn't installed properly. Please delete it and try again.");
				return;
			}
			RadMessageBox.Show("No errors were found.");
		}

		// Token: 0x04000652 RID: 1618
		private readonly GClass32 gclass32_0;

		// Token: 0x04000653 RID: 1619
		private bool bool_0;

		// Token: 0x04000654 RID: 1620
		private GClass95 gclass95_0;

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		private sealed class Class136
		{
			// Token: 0x06000B0C RID: 2828 RVA: 0x00017CEC File Offset: 0x00015EEC
			internal bool method_0(GClass33 gclass33_0)
			{
				return ulong.Parse(gclass33_0.Version) == this.ulong_0;
			}

			// Token: 0x04000673 RID: 1651
			public ulong ulong_0;
		}

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		private sealed class Class137
		{
			// Token: 0x06000B0E RID: 2830 RVA: 0x000403E8 File Offset: 0x0003E5E8
			internal void method_0()
			{
				frmEmuInfo.Class138 @class = new frmEmuInfo.Class138();
				GClass13 gclass = this.gclass30_0.method_15();
				@class.string_0 = ((this.gclass30_0 is GClass32) ? this.cemu_0.CurrentGamePath : ((this.gclass30_0 is GClass33) ? this.cemu_0.UpdatePath : this.cemu_0.DlcPath));
				this.bool_0 = gclass.Files.Any(new Func<GClass12, bool>(@class.method_0));
			}

			// Token: 0x04000674 RID: 1652
			public GClass30 gclass30_0;

			// Token: 0x04000675 RID: 1653
			public Cemu cemu_0;

			// Token: 0x04000676 RID: 1654
			public bool bool_0;
		}

		// Token: 0x02000182 RID: 386
		[CompilerGenerated]
		private sealed class Class138
		{
			// Token: 0x06000B10 RID: 2832 RVA: 0x0004046C File Offset: 0x0003E66C
			internal bool method_0(GClass12 gclass12_0)
			{
				return !gclass12_0.bool_0 && !gclass12_0.bool_1 && (!File.Exists(Path.Combine(new string[]
				{
					this.string_0,
					gclass12_0.string_0
				})) || (ulong)gclass12_0.uint_2 != (ulong)new FileInfo(Path.Combine(new string[]
				{
					this.string_0,
					gclass12_0.string_0
				})).Length);
			}

			// Token: 0x04000677 RID: 1655
			public string string_0;
		}
	}
}

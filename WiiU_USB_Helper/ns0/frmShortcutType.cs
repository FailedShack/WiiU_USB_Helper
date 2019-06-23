using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NusHelper.Emulators;
using SharpSteam;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001AB RID: 427
	public partial class frmShortcutType : RadForm
	{
		// Token: 0x06000BCC RID: 3020 RVA: 0x00046F8C File Offset: 0x0004518C
		public frmShortcutType(GClass30 gclass30_1)
		{
			this.InitializeComponent();
			this.gclass30_0 = gclass30_1;
			try
			{
				this.cmdSteam.Enabled = Directory.Exists(SteamManager.GetSteamFolder());
			}
			catch
			{
				this.cmdSteam.Enabled = false;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000185B1 File Offset: 0x000167B1
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000185B9 File Offset: 0x000167B9
		public GEnum9 ShortcutType { get; private set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000185C2 File Offset: 0x000167C2
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000185CA File Offset: 0x000167CA
		public bool SteamLinkFix { get; private set; }

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000185D3 File Offset: 0x000167D3
		private void cmdShortcut_Click(object sender, EventArgs e)
		{
			this.ShortcutType = GEnum9.const_1;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000185E3 File Offset: 0x000167E3
		private void cmdSteam_Click(object sender, EventArgs e)
		{
			this.ShortcutType = GEnum9.const_0;
			base.DialogResult = DialogResult.OK;
			this.SteamLinkFix = this.chkSteamLink.Checked;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00046FE4 File Offset: 0x000451E4
		private void frmShortcutType_Load(object sender, EventArgs e)
		{
			this.radSteamLink.Visible = this.gclass30_0.method_14(false).GetControllerProfiles().Any(new Func<GClass95.GStruct6, bool>(frmShortcutType.<>c.<>c_0.method_0));
			this.chkSteamLink.Visible = (this.gclass30_0.method_14(false) is Cemu);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00047050 File Offset: 0x00045250
		private void lblCloseSteam_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("Steam");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00047080 File Offset: 0x00045280
		private void radSteamLink_Click(object sender, EventArgs e)
		{
			GClass95.GStruct6 config = this.gclass30_0.method_14(false).GetControllerProfiles().First(new Func<GClass95.GStruct6, bool>(frmShortcutType.<>c.<>c_0.method_1));
			this.gclass30_0.method_14(false).ApplyControllerProfile(config);
			RadMessageBox.Show("Done!");
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000470E0 File Offset: 0x000452E0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = GClass6.smethod_16("Steam");
			this.cmdSteam.Enabled = !flag;
			this.lblCloseSteam.Visible = flag;
		}

		// Token: 0x0400072E RID: 1838
		[CompilerGenerated]
		private GEnum9 genum9_0;

		// Token: 0x0400072F RID: 1839
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000730 RID: 1840
		private GClass30 gclass30_0;
	}
}

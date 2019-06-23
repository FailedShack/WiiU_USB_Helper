using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WIIU_Downloader.Forms;

namespace ns0
{
	// Token: 0x020001CF RID: 463
	public partial class FrmWhatToCopy : RadForm
	{
		// Token: 0x06000C90 RID: 3216 RVA: 0x00050568 File Offset: 0x0004E768
		public FrmWhatToCopy(GClass32 gclass32_1, WhatToAction whatToAction_1)
		{
			this.InitializeComponent();
			this.bool_0 = (whatToAction_1 == WhatToAction.Copy || whatToAction_1 == WhatToAction.Unpack);
			this.whatToAction_0 = whatToAction_1;
			this.title.Text = gclass32_1.Name;
			this.gclass32_0 = gclass32_1;
			this.Text = string.Format("What to {0}", whatToAction_1);
			this.label1.Text = string.Format("Select what you would like to {0}", Enum.GetName(typeof(WhatToAction), whatToAction_1).ToLower());
			if (this.bool_0)
			{
				this.chkCopyGame.Enabled = (gclass32_1.GEnum2_0 == GEnum2.const_2);
				Control control = this.chkCopyUpdate;
				bool enabled;
				if (gclass32_1.Boolean_3)
				{
					enabled = gclass32_1.Updates.Any(new Func<GClass33, bool>(FrmWhatToCopy.<>c.<>c_0.method_0));
				}
				else
				{
					enabled = false;
				}
				control.Enabled = enabled;
				this.chkCopyDlc.Enabled = (gclass32_1.Dlc != null && gclass32_1.Dlc.GEnum2_0 == GEnum2.const_2);
			}
			else
			{
				this.chkCopyGame.Enabled = (gclass32_1.GEnum2_0 > GEnum2.const_0);
				Control control2 = this.chkCopyUpdate;
				bool enabled2;
				if (gclass32_1.Boolean_3)
				{
					enabled2 = gclass32_1.Updates.Any(new Func<GClass33, bool>(FrmWhatToCopy.<>c.<>c_0.method_1));
				}
				else
				{
					enabled2 = false;
				}
				control2.Enabled = enabled2;
				this.chkCopyDlc.Enabled = (gclass32_1.Dlc != null && gclass32_1.Dlc.GEnum2_0 > GEnum2.const_0);
			}
			base.Opacity = 0.0;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00018C33 File Offset: 0x00016E33
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00018C3B File Offset: 0x00016E3B
		public bool CopyDlc { get; set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00018C44 File Offset: 0x00016E44
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00018C4C File Offset: 0x00016E4C
		public bool CopyGame { get; set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00018C55 File Offset: 0x00016E55
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00018C5D File Offset: 0x00016E5D
		public bool CopyUpdate { get; set; }

		// Token: 0x06000C97 RID: 3223 RVA: 0x00018C66 File Offset: 0x00016E66
		private void chkCopyUpdate_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (!this.chkCopyUpdate.Checked)
			{
				return;
			}
			this.method_0();
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00050700 File Offset: 0x0004E900
		private void method_0()
		{
			FrmSelectVersion frmSelectVersion = new FrmSelectVersion(this.gclass32_0.Updates, this.bool_0);
			if (frmSelectVersion.ShowDialog() == DialogResult.OK)
			{
				this.list_0 = frmSelectVersion.list_0;
				return;
			}
			this.chkCopyUpdate.Checked = false;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00050748 File Offset: 0x0004E948
		private void FrmWhatToCopy_Load(object sender, EventArgs e)
		{
			if (this.chkCopyGame.Enabled)
			{
				this.int_0++;
			}
			if (this.chkCopyDlc.Enabled)
			{
				this.int_0++;
			}
			if (this.chkCopyUpdate.Enabled)
			{
				this.int_0++;
			}
			if (!this.bool_0)
			{
				base.Opacity = 100.0;
				return;
			}
			if (this.int_0 == 0)
			{
				base.DialogResult = DialogResult.Cancel;
				base.Close();
			}
			if (this.int_0 != 1)
			{
				base.Opacity = 100.0;
				return;
			}
			base.DialogResult = DialogResult.OK;
			this.CopyGame = this.chkCopyGame.Enabled;
			if (this.chkCopyUpdate.Enabled)
			{
				this.method_0();
				this.CopyUpdate = (this.list_0 != null);
			}
			this.CopyDlc = this.chkCopyDlc.Enabled;
			base.Close();
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00050840 File Offset: 0x0004EA40
		private void radButton1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			this.CopyGame = this.chkCopyGame.Checked;
			this.CopyUpdate = this.chkCopyUpdate.Checked;
			this.CopyDlc = this.chkCopyDlc.Checked;
			base.Close();
		}

		// Token: 0x04000848 RID: 2120
		private WhatToAction whatToAction_0;

		// Token: 0x04000849 RID: 2121
		private readonly GClass32 gclass32_0;

		// Token: 0x0400084A RID: 2122
		private readonly bool bool_0;

		// Token: 0x0400084B RID: 2123
		private int int_0;

		// Token: 0x0400084C RID: 2124
		public List<GClass33> list_0;

		// Token: 0x0400084D RID: 2125
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400084E RID: 2126
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400084F RID: 2127
		[CompilerGenerated]
		private bool bool_3;
	}
}

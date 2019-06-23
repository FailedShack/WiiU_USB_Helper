using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001C7 RID: 455
	internal partial class FrmSelectVersion : RadForm
	{
		// Token: 0x06000C68 RID: 3176 RVA: 0x0004F19C File Offset: 0x0004D39C
		public FrmSelectVersion(IEnumerable<GClass33> ienumerable_0, bool bool_0)
		{
			this.InitializeComponent();
			foreach (GClass33 gclass in ienumerable_0)
			{
				this._lstVersions.Items.Add(new ListViewDataItem(string.Format("v{0} ({1})", gclass.Version, gclass.Size))
				{
					Tag = gclass,
					ForeColor = gclass.Color_0,
					Enabled = (!bool_0 || gclass.GEnum2_0 == GEnum2.const_2)
				});
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0004F244 File Offset: 0x0004D444
		private void _cmdCheckAll_Click(object sender, EventArgs e)
		{
			foreach (ListViewDataItem listViewDataItem in this._lstVersions.Items.Where(new Func<ListViewDataItem, bool>(FrmSelectVersion.<>c.<>c_0.method_0)))
			{
				listViewDataItem.CheckState = ToggleState.On;
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0004F2BC File Offset: 0x0004D4BC
		private void _cmdImport_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			this.list_0 = this._lstVersions.Items.Where(new Func<ListViewDataItem, bool>(FrmSelectVersion.<>c.<>c_0.method_1)).Select(new Func<ListViewDataItem, GClass33>(FrmSelectVersion.<>c.<>c_0.method_2)).ToList<GClass33>();
			base.Close();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000142A3 File Offset: 0x000124A3
		private void FrmSelectVersion_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000821 RID: 2081
		public List<GClass33> list_0;
	}
}

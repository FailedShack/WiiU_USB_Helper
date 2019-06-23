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
	// Token: 0x020001C3 RID: 451
	public partial class FrmNewTitles : RadForm
	{
		// Token: 0x06000C4E RID: 3150 RVA: 0x0004E468 File Offset: 0x0004C668
		public FrmNewTitles(IEnumerable<GClass30> ienumerable_0, string string_0 = "New titles have been added! Please choose the ones you wish to download.")
		{
			this.InitializeComponent();
			this.lblUpText.Text = string_0;
			this.lstTitles.EnableGrouping = true;
			this.lstTitles.EnableCustomGrouping = true;
			this.lstTitles.Groups.Add(this.listViewDataItemGroup_2);
			this.lstTitles.Groups.Add(this.listViewDataItemGroup_0);
			this.lstTitles.Groups.Add(this.listViewDataItemGroup_1);
			this.lstTitles.ShowGroups = true;
			this.lstTitles.BeginUpdate();
			foreach (GClass30 gclass in ienumerable_0)
			{
				ListViewDataItem listViewDataItem = new ListViewDataItem(gclass)
				{
					Tag = gclass
				};
				switch (gclass.System)
				{
				case GEnum3.const_0:
					listViewDataItem.Group = this.listViewDataItemGroup_0;
					break;
				case GEnum3.const_1:
					listViewDataItem.Group = this.listViewDataItemGroup_2;
					break;
				case GEnum3.const_2:
					throw new NotImplementedException();
				case GEnum3.const_3:
					listViewDataItem.Group = this.listViewDataItemGroup_1;
					break;
				}
				this.lstTitles.Items.Add(listViewDataItem);
			}
			this.lstTitles.EndUpdate();
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0004E5DC File Offset: 0x0004C7DC
		private void cmdCheckAll_Click(object sender, EventArgs e)
		{
			foreach (ListViewDataItem listViewDataItem in this.lstTitles.Items)
			{
				listViewDataItem.CheckState = ToggleState.On;
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0004E630 File Offset: 0x0004C830
		private void cmdImport_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			this.list_0 = this.lstTitles.Items.Where(new Func<ListViewDataItem, bool>(FrmNewTitles.<>c.<>c_0.method_0)).Select(new Func<ListViewDataItem, GClass30>(FrmNewTitles.<>c.<>c_0.method_1)).ToList<GClass30>();
			base.Close();
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000142A3 File Offset: 0x000124A3
		private void FrmNewTitles_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000142A3 File Offset: 0x000124A3
		private void radGroupBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000803 RID: 2051
		public List<GClass30> list_0;

		// Token: 0x04000804 RID: 2052
		private readonly ListViewDataItemGroup listViewDataItemGroup_0 = new ListViewDataItemGroup("3DS");

		// Token: 0x04000805 RID: 2053
		private readonly ListViewDataItemGroup listViewDataItemGroup_1 = new ListViewDataItemGroup("Wii");

		// Token: 0x04000806 RID: 2054
		private readonly ListViewDataItemGroup listViewDataItemGroup_2 = new ListViewDataItemGroup("WiiU");
	}
}

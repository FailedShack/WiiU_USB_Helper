using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Nus_Helper_Shared_Core.NusHelper.Saves;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200018E RID: 398
	public partial class frmChoseSave : RadForm
	{
		// Token: 0x06000B45 RID: 2885 RVA: 0x00041EC4 File Offset: 0x000400C4
		public frmChoseSave(GClass32 gclass32_0)
		{
			this.InitializeComponent();
			foreach (SaveDescription saveDescription in gclass32_0.method_24())
			{
				ListViewDataItem listViewDataItem = new ListViewDataItem
				{
					Tag = saveDescription
				};
				this.lstSaves.Items.Add(listViewDataItem);
				listViewDataItem[0] = frmChoseSave.smethod_0(double.Parse(saveDescription.Timestamp)).ToShortDateString();
				listViewDataItem[1] = saveDescription.Description;
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00041F68 File Offset: 0x00040168
		public static DateTime smethod_0(double double_0)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			result = result.AddSeconds(double_0).ToLocalTime();
			return result;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000142A3 File Offset: 0x000124A3
		private void frmChoseSave_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00041F9C File Offset: 0x0004019C
		private void cmdbackup_Click(object sender, EventArgs e)
		{
			if (this.lstSaves.CheckedItems.Count != 0 && this.lstSaves.CheckedItems.Count <= 1)
			{
				this.saveDescription_0 = (this.lstSaves.CheckedItems[0].Tag as SaveDescription);
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			RadMessageBox.Show("Please select one save.");
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00017ED4 File Offset: 0x000160D4
		private void radButton1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x040006A2 RID: 1698
		public SaveDescription saveDescription_0;
	}
}

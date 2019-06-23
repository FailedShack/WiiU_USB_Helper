using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x02000174 RID: 372
	public partial class frmCommunitySaves : RadForm
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003CEB4 File Offset: 0x0003B0B4
		public frmCommunitySaves(GClass32 gclass32_1)
		{
			this.InitializeComponent();
			this.gclass32_0 = gclass32_1;
			if (gclass32_1.method_14(false) != null && gclass32_1.method_14(false).FileSaveLocation != null)
			{
				this.method_0();
				return;
			}
			RadMessageBox.Show("This title does not support community saves.");
			base.Close();
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0003CF04 File Offset: 0x0003B104
		private void cmdImport_Click(object sender, EventArgs e)
		{
			if (this.lstSaves.SelectedItem == null)
			{
				return;
			}
			if (RadMessageBox.Show("You are about to import a save. If you already have any local save data, it will be OVERWRITTEN. If you are using Cloud Saving, your cloud save will also be OVERWRITTEN. Continue?", "Continue?", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				GClass95 gclass = this.gclass32_0.method_14(false);
				GClass6.smethod_5(gclass.FileSaveLocation);
				GClass27.smethod_7(string.Format("{0}/communitysaves/cdn/{1}", Class65.String_1, (this.lstSaves.SelectedItem.Tag as frmCommunitySaves.Class129).Md5), gclass.FileSaveLocation);
				if (Settings.Default.EnableCloudSaving)
				{
					gclass.method_2(gclass.vmethod_0(), Settings.Default.CloudUserName, Settings.Default.CloudPassWord);
				}
				RadMessageBox.Show("Save imported!");
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003CFB8 File Offset: 0x0003B1B8
		private void cmdUploadSave_Click(object sender, EventArgs e)
		{
			string text = this.gclass32_0.method_14(false).vmethod_0();
			if (text == null)
			{
				RadMessageBox.Show("An error occured while trying to compile your save. Do you have a local save to share?");
				return;
			}
			frmCommunitySaveDescription frmCommunitySaveDescription = new frmCommunitySaveDescription();
			if (frmCommunitySaveDescription.ShowDialog() != DialogResult.OK)
			{
				RadMessageBox.Show("The process was cancelled.");
				return;
			}
			string text2 = Class65.smethod_14(text, string.Format("{0}/communitysaves/upload.php", Class65.String_1));
			if (text2.Length != 32)
			{
				RadMessageBox.Show("An error occured while uploading your save.");
				return;
			}
			if (GClass6.smethod_20(string.Format("{0}/communitysaves/add.php", Class65.String_1), new NameValueCollection
			{
				{
					"titleid",
					this.gclass32_0.TitleId.IdRaw
				},
				{
					"md5",
					text2
				},
				{
					"description",
					frmCommunitySaveDescription.Description
				}
			}) == "Ok")
			{
				RadMessageBox.Show("Thank you for your contribution!");
				this.method_0();
				return;
			}
			RadMessageBox.Show("Your save could not be added. Perhaps a similar save already exists?");
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0003D0A8 File Offset: 0x0003B2A8
		private void method_0()
		{
			this.lstSaves.BeginUpdate();
			this.lstSaves.Items.Clear();
			foreach (frmCommunitySaves.Class129 @class in JsonConvert.DeserializeObject<List<frmCommunitySaves.Class129>>(GClass6.smethod_20(string.Format("{0}/communitysaves/list.php", Class65.String_1), new NameValueCollection
			{
				{
					"titleid",
					this.gclass32_0.TitleId.IdRaw
				}
			})))
			{
				ListViewDataItem listViewDataItem = new ListViewDataItem
				{
					Tag = @class
				};
				this.lstSaves.Items.Add(listViewDataItem);
				listViewDataItem[0] = @class.Description;
				listViewDataItem[1] = @class.Date;
			}
			this.lstSaves.EndUpdate();
			this.lblNoSaves.Visible = (this.lstSaves.Items.Count == 0);
		}

		// Token: 0x0400061D RID: 1565
		private GClass32 gclass32_0;

		// Token: 0x02000175 RID: 373
		private class Class129
		{
			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00017AB4 File Offset: 0x00015CB4
			// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00017ABC File Offset: 0x00015CBC
			[JsonProperty("date")]
			public string Date { get; set; }

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00017AC5 File Offset: 0x00015CC5
			// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00017ACD File Offset: 0x00015CCD
			[JsonProperty("description")]
			public string Description { get; set; }

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00017AD6 File Offset: 0x00015CD6
			// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00017ADE File Offset: 0x00015CDE
			[JsonProperty("md5")]
			public string Md5 { get; set; }

			// Token: 0x04000624 RID: 1572
			[CompilerGenerated]
			private string string_0;

			// Token: 0x04000625 RID: 1573
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000626 RID: 1574
			[CompilerGenerated]
			private string string_2;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001A0 RID: 416
	public partial class frmManageCloudSaves : RadForm
	{
		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001831B File Offset: 0x0001651B
		public frmManageCloudSaves()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00041F68 File Offset: 0x00040168
		public static DateTime smethod_0(double double_0)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			result = result.AddSeconds(double_0).ToLocalTime();
			return result;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00045700 File Offset: 0x00043900
		private void cmdDelete_Click(object sender, EventArgs e)
		{
			if (this.gclass32_0 != null && RadMessageBox.Show("Are you sure you want to delete this file? It cannot be recovered.", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				GClass6.smethod_20(string.Format("{0}/saves/delete_save.php", Class65.String_1), new NameValueCollection
				{
					{
						"username",
						Settings.Default.CloudUserName
					},
					{
						"password",
						Settings.Default.CloudPassWord
					},
					{
						"titleid",
						this.gclass32_0.TitleId.IdRaw
					}
				});
				this.method_0();
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00045790 File Offset: 0x00043990
		private void lstSaves_SelectedItemChanged(object sender, EventArgs e)
		{
			try
			{
				this.gclass32_0 = (this.lstSaves.SelectedItem.Tag as GClass32);
			}
			catch
			{
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000457D0 File Offset: 0x000439D0
		private void method_0()
		{
			this.gclass32_0 = null;
			List<Class150> list = JsonConvert.DeserializeObject<List<Class150>>(GClass6.smethod_20(string.Format("{0}/saves/list_saves.php", Class65.String_1), new NameValueCollection
			{
				{
					"username",
					Settings.Default.CloudUserName
				},
				{
					"password",
					Settings.Default.CloudPassWord
				}
			}));
			this.lstSaves.BeginUpdate();
			this.lstSaves.Items.Clear();
			foreach (Class150 @class in list)
			{
				ListViewDataItem listViewDataItem = new ListViewDataItem();
				this.lstSaves.Items.Add(listViewDataItem);
				listViewDataItem[0] = GClass28.dictionary_0[new TitleId(@class.string_1)].Name;
				listViewDataItem[1] = frmManageCloudSaves.smethod_0((double)@class.long_0).ToLongDateString() + " " + frmManageCloudSaves.smethod_0((double)@class.long_0).ToLongTimeString();
				listViewDataItem[2] = new DataSize(@class.ulong_0);
				listViewDataItem.Tag = GClass28.dictionary_0[new TitleId(@class.string_1)];
			}
			this.lstSaves.EndUpdate();
		}

		// Token: 0x04000700 RID: 1792
		private GClass32 gclass32_0;
	}
}

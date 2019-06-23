using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001A8 RID: 424
	public partial class frmSelectTheme : RadForm
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x00018584 File Offset: 0x00016784
		public frmSelectTheme()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00046C7C File Offset: 0x00044E7C
		private void frmSelectTheme_Load(object sender, EventArgs e)
		{
			foreach (object obj in ThemeResolutionService.GetAvailableThemes())
			{
				Theme theme = obj as Theme;
				string text = theme.Name;
				bool bool_ = false;
				if (text[0] == '!')
				{
					text = text.Substring(1);
					bool_ = true;
				}
				ListViewDataItem item = new ListViewDataItem(text)
				{
					Tag = new frmSelectTheme.Struct1
					{
						bool_0 = bool_,
						theme_0 = theme
					}
				};
				this.lstThemes.Items.Add(item);
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00046D30 File Offset: 0x00044F30
		private void lstThemes_ItemMouseClick(object sender, ListViewItemEventArgs e)
		{
			frmSelectTheme.Struct1 @struct = (frmSelectTheme.Struct1)e.Item.Tag;
			Settings.Default.ThemeName = @struct.theme_0.Name;
			Settings.Default.Save();
			RadMessageBox.Show("Please restart the app for the changes to take effect.");
		}

		// Token: 0x020001A9 RID: 425
		internal struct Struct1
		{
			// Token: 0x04000729 RID: 1833
			public bool bool_0;

			// Token: 0x0400072A RID: 1834
			public Theme theme_0;
		}
	}
}

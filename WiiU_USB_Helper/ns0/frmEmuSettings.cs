using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000184 RID: 388
	public partial class frmEmuSettings : RadForm
	{
		// Token: 0x06000B14 RID: 2836 RVA: 0x00017D0D File Offset: 0x00015F0D
		public frmEmuSettings()
		{
			this.InitializeComponent();
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00017D1B File Offset: 0x00015F1B
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00017D23 File Offset: 0x00015F23
		public bool PathWasChanged { get; private set; }

		// Token: 0x06000B17 RID: 2839 RVA: 0x000404E4 File Offset: 0x0003E6E4
		private void cmdLaunchEmu_Click(object sender, EventArgs e)
		{
			if (this.lstEmus.SelectedItem != null)
			{
				GClass95 gclass = (GClass95)Activator.CreateInstance((Type)this.lstEmus.SelectedItem.Tag, new object[]
				{
					GClass28.dictionary_0.ElementAt(0).Value,
					false
				});
				if (gclass.Boolean_0)
				{
					new Process
					{
						StartInfo = new ProcessStartInfo
						{
							FileName = gclass.GetExecutable(),
							WorkingDirectory = gclass.String_4
						}
					}.Start();
					return;
				}
				RadMessageBox.Show("The emulator is not installed yet. You must use the \"Play this game\" button at least once");
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00040588 File Offset: 0x0003E788
		private void frmEmuSettings_Load(object sender, EventArgs e)
		{
			foreach (Type type in Assembly.GetAssembly(typeof(GClass95)).GetTypes().Where(new Func<Type, bool>(frmEmuSettings.<>c.<>c_0.method_0)))
			{
				this.lstEmus.Items.Add(new ListViewDataItem(type.Name)
				{
					Tag = type
				});
			}
			this.lstEmus.SelectedIndex = 0;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00040630 File Offset: 0x0003E830
		private void lstEmus_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.lstEmus.SelectedItem != null)
			{
				this.settingsGrid.SelectedObject = ((GClass95)Activator.CreateInstance((Type)this.lstEmus.SelectedItem.Tag, new object[]
				{
					GClass28.dictionary_0.ElementAt(0).Value,
					false
				})).EmuConfiguration_0;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000406A0 File Offset: 0x0003E8A0
		private void settingsGrid_EditorRequired(object sender, PropertyGridEditorRequiredEventArgs e)
		{
			if (e.Item.Name.ToLower().Contains("path"))
			{
				PropertyGridBrowseEditor propertyGridBrowseEditor = new PropertyGridBrowseEditor();
				(propertyGridBrowseEditor.EditorElement as RadBrowseEditorElement).DialogType = BrowseEditorDialogType.FolderBrowseDialog;
				e.Editor = propertyGridBrowseEditor;
				this.PathWasChanged = true;
			}
		}

		// Token: 0x0400067A RID: 1658
		[CompilerGenerated]
		private bool bool_0;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001BD RID: 445
	public partial class FrmImport : RadForm
	{
		// Token: 0x06000C3B RID: 3131 RVA: 0x00018A14 File Offset: 0x00016C14
		public FrmImport(string string_1)
		{
			this.InitializeComponent();
			this.string_0 = string_1;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0004D3A4 File Offset: 0x0004B5A4
		private void cmdCheckAll_Click(object sender, EventArgs e)
		{
			foreach (ListViewDataItem listViewDataItem in this.lstTitles.Items.Where(new Func<ListViewDataItem, bool>(FrmImport.<>c.<>c_0.method_0)))
			{
				listViewDataItem.CheckState = ToggleState.On;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0004D41C File Offset: 0x0004B61C
		private void cmdImport_Click(object sender, EventArgs e)
		{
			using (IEnumerator<ListViewDataItem> enumerator = this.lstTitles.Items.Where(new Func<ListViewDataItem, bool>(FrmImport.<>c.<>c_0.method_1)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FrmImport.Class153 @class = new FrmImport.Class153();
					@class.frmImport_0 = this;
					@class.listViewDataItem_0 = enumerator.Current;
					new FrmWait("USB Helper is importing your title...", new Action(@class.method_0), new Action<Exception>(FrmImport.<>c.<>c_0.method_2));
				}
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0004D4E4 File Offset: 0x0004B6E4
		private void FrmImport_Load(object sender, EventArgs e)
		{
			FrmImport.Class154 @class = new FrmImport.Class154();
			@class.frmImport_0 = this;
			this.lstTitles.SortDescriptors.Add(new SortDescriptor("Value", ListSortDirection.Ascending));
			@class.string_0 = new string[0];
			@class.string_1 = new string[0];
			new FrmWait("USB Helper is looking for importable titles...", new Action(@class.method_0), new Action<Exception>(FrmImport.<>c.<>c_0.method_3));
			foreach (string path in @class.string_0)
			{
				string value = "Ready to import";
				GClass100 gclass = GClass100.smethod_0(path, GEnum3.const_1);
				TitleId titleId = new TitleId(gclass.TitleId.ToString("x16"));
				if (GClass28.dictionary_0.ContainsKey(titleId.FullGame))
				{
					GClass30 gclass2 = null;
					switch (titleId.IdType)
					{
					case GEnum1.const_0:
						gclass2 = GClass28.dictionary_0[titleId.FullGame];
						if (gclass2.System == GEnum3.const_0)
						{
							gclass2 = GClass28.dictionary_0[titleId.FullGame].Updates.Last<GClass33>();
						}
						else if (gclass2.System == GEnum3.const_1)
						{
							FrmImport.Class155 class2 = new FrmImport.Class155();
							class2.ushort_0 = gclass.TitleVersion;
							try
							{
								gclass2 = GClass28.dictionary_0[titleId.FullGame].Updates.Find(new Predicate<GClass33>(class2.method_0));
								break;
							}
							catch
							{
								gclass2 = null;
								break;
							}
							goto IL_1DF;
						}
						break;
					case GEnum1.const_1:
						goto IL_1DF;
					case GEnum1.const_2:
						gclass2 = GClass28.dictionary_0[titleId.FullGame].Dlc;
						break;
					case GEnum1.const_3:
						gclass2 = GClass28.dictionary_0[titleId.FullGame];
						break;
					case GEnum1.const_4:
						gclass2 = GClass28.dictionary_0[titleId.FullGame];
						break;
					}
					IL_2CB:
					if (gclass2 != null)
					{
						ListViewDataItem listViewDataItem = new ListViewDataItem
						{
							Tag = new Struct4
							{
								gclass100_0 = gclass,
								gclass30_0 = gclass2,
								string_0 = Path.GetDirectoryName(path)
							}
						};
						if (gclass2.GEnum2_0 != GEnum2.const_0)
						{
							value = "Cannot be imported, already in the library";
							listViewDataItem.Enabled = false;
						}
						this.lstTitles.Items.Add(listViewDataItem);
						listViewDataItem[0] = gclass2.ToString();
						listViewDataItem[1] = value;
						goto IL_2C2;
					}
					goto IL_2C2;
					IL_1DF:
					gclass2 = GClass28.dictionary_0[titleId.FullGame];
					goto IL_2CB;
				}
				value = "Cannot be imported, not in the database";
				ListViewDataItem listViewDataItem2 = new ListViewDataItem();
				this.lstTitles.Items.Add(listViewDataItem2);
				listViewDataItem2.Enabled = false;
				listViewDataItem2[0] = string.Format("UNKNOWN ({0})", titleId.IdRaw);
				listViewDataItem2[1] = value;
				IL_2C2:;
			}
			foreach (string text in @class.string_1)
			{
				try
				{
					if (!(new DirectoryInfo(Path.GetDirectoryName(text)).Name != "meta"))
					{
						TitleId titleId2 = new TitleId(XDocument.Load(text).Descendants("title_id").ElementAt(0).Value);
						if (titleId2.IdType == GEnum1.const_1 && GClass28.dictionary_0.ContainsKey(titleId2))
						{
							GClass32 gclass3 = GClass28.dictionary_0[titleId2];
							GClass95 gclass4 = gclass3.method_14(false);
							if (gclass4 != null && !gclass3.Boolean_1)
							{
								ListViewDataItem listViewDataItem3 = new ListViewDataItem();
								this.lstTitles.Items.Add(listViewDataItem3);
								listViewDataItem3[0] = gclass3.Name + " (EMU)";
								listViewDataItem3[1] = "Importable";
								listViewDataItem3.Tag = new Struct4
								{
									gclass30_0 = gclass3,
									gclass95_0 = gclass4,
									string_0 = new DirectoryInfo(Path.GetDirectoryName(text)).Parent.FullName
								};
							}
						}
					}
				}
				catch
				{
				}
			}
			if (this.lstTitles.Items.Count != 0)
			{
				return;
			}
			RadMessageBox.Show("No games were found. Please specify another path.");
			base.DialogResult = DialogResult.Abort;
			base.Close();
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0004D960 File Offset: 0x0004BB60
		private void method_0(string string_1, string string_2)
		{
			try
			{
				FileSystem.MoveFile(string_1, Path.Combine(string_2, new FileInfo(string_1).Name), UIOption.AllDialogs);
			}
			catch
			{
			}
		}

		// Token: 0x040007E7 RID: 2023
		public List<GClass32> list_0 = new List<GClass32>();

		// Token: 0x040007E8 RID: 2024
		private readonly string string_0;

		// Token: 0x020001BF RID: 447
		[CompilerGenerated]
		private sealed class Class153
		{
			// Token: 0x06000C49 RID: 3145 RVA: 0x0004E1E8 File Offset: 0x0004C3E8
			internal void method_0()
			{
				Struct4 @struct = (Struct4)this.listViewDataItem_0.Tag;
				if (!this.frmImport_0.list_0.Contains(GClass28.dictionary_0[@struct.gclass30_0.TitleId.FullGame]))
				{
					this.frmImport_0.list_0.Add(GClass28.dictionary_0[@struct.gclass30_0.TitleId.FullGame]);
				}
				if (@struct.gclass100_0 != null)
				{
					Directory.CreateDirectory(@struct.gclass30_0.OutputPath);
					foreach (GClass101 gclass in @struct.gclass100_0.GClass101_0)
					{
						this.frmImport_0.method_0(Path.Combine(@struct.string_0, gclass.String_0 + ".app"), @struct.gclass30_0.OutputPath);
						this.frmImport_0.method_0(Path.Combine(@struct.string_0, gclass.String_0 + ".h3"), @struct.gclass30_0.OutputPath);
					}
					this.frmImport_0.method_0(Path.Combine(@struct.string_0, "title.tik"), @struct.gclass30_0.OutputPath);
					this.frmImport_0.method_0(Path.Combine(@struct.string_0, "title.tmd"), @struct.gclass30_0.OutputPath);
					this.frmImport_0.method_0(Path.Combine(@struct.string_0, "title.cert"), @struct.gclass30_0.OutputPath);
				}
				else if (@struct.gclass95_0 != null)
				{
					GClass6.smethod_5(@struct.gclass95_0.CurrentGamePath);
					Directory.CreateDirectory(@struct.gclass95_0.CurrentGamePath);
					foreach (DirectoryInfo directoryInfo in new DirectoryInfo(@struct.string_0).EnumerateDirectories())
					{
						directoryInfo.MoveTo(Path.Combine(@struct.gclass95_0.CurrentGamePath, directoryInfo.Name));
					}
				}
				@struct.gclass30_0.method_6();
			}

			// Token: 0x040007F9 RID: 2041
			public ListViewDataItem listViewDataItem_0;

			// Token: 0x040007FA RID: 2042
			public FrmImport frmImport_0;
		}

		// Token: 0x020001C0 RID: 448
		[CompilerGenerated]
		private sealed class Class154
		{
			// Token: 0x06000C4B RID: 3147 RVA: 0x0004E40C File Offset: 0x0004C60C
			internal void method_0()
			{
				try
				{
					this.string_0 = Directory.GetFiles(this.frmImport_0.string_0, "title.tmd", System.IO.SearchOption.AllDirectories);
					this.string_1 = Directory.GetFiles(this.frmImport_0.string_0, "meta.xml", System.IO.SearchOption.AllDirectories);
				}
				catch
				{
				}
			}

			// Token: 0x040007FB RID: 2043
			public string[] string_0;

			// Token: 0x040007FC RID: 2044
			public FrmImport frmImport_0;

			// Token: 0x040007FD RID: 2045
			public string[] string_1;
		}

		// Token: 0x020001C1 RID: 449
		[CompilerGenerated]
		private sealed class Class155
		{
			// Token: 0x06000C4D RID: 3149 RVA: 0x00018A72 File Offset: 0x00016C72
			internal bool method_0(GClass33 gclass33_0)
			{
				return gclass33_0.Version == this.ushort_0.ToString();
			}

			// Token: 0x040007FE RID: 2046
			public ushort ushort_0;
		}
	}
}

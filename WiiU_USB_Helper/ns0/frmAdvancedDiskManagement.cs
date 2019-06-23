using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x0200016A RID: 362
	public partial class frmAdvancedDiskManagement : RadForm
	{
		// Token: 0x06000A9F RID: 2719 RVA: 0x0003AD04 File Offset: 0x00038F04
		public frmAdvancedDiskManagement()
		{
			frmAdvancedDiskManagement.Class122 @class = new frmAdvancedDiskManagement.Class122();
			@class.frmAdvancedDiskManagement_0 = this;
			this.InitializeComponent();
			@class.int_0 = 0;
			@class.frmWait_0 = new FrmWait("Analyzing your disk... This might take a while.", true);
			Task.Run(new Action(@class.method_0));
			@class.frmWait_0.ShowDialog();
			this.method_2();
			this.method_3();
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00017821 File Offset: 0x00015A21
		public List<GClass32> DeletedTitles { get; } = new List<GClass32>();

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003AD8C File Offset: 0x00038F8C
		private void method_0(Class128 class128_0, RadListView radListView_0)
		{
			ListViewDataItem listViewDataItem = new ListViewDataItem
			{
				Tag = class128_0
			};
			radListView_0.Items.Add(listViewDataItem);
			listViewDataItem[0] = class128_0.ToString();
			listViewDataItem[1] = new DataSize(class128_0.Size);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00017829 File Offset: 0x00015A29
		private void cmdDelete_Click(object sender, EventArgs e)
		{
			ListViewDataItem selectedItem = this.lstTitles.SelectedItem;
			this.method_1(((selectedItem != null) ? selectedItem.Tag : null) as Class128);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001784D File Offset: 0x00015A4D
		private void cmdDeleteEmu_Click(object sender, EventArgs e)
		{
			ListViewDataItem selectedItem = this.lstEmuTitles.SelectedItem;
			this.method_1(((selectedItem != null) ? selectedItem.Tag : null) as Class128);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003ADD8 File Offset: 0x00038FD8
		private void method_1(Class128 class128_0)
		{
			frmAdvancedDiskManagement.Class126 @class = new frmAdvancedDiskManagement.Class126();
			@class.class128_0 = class128_0;
			if (@class.class128_0 == null)
			{
				return;
			}
			@class.class128_0.method_0();
			if (this.list_2.Contains(@class.class128_0))
			{
				this.list_2.Remove(@class.class128_0);
				this.lstTitles.Items.Remove(this.lstTitles.Items.First(new Func<ListViewDataItem, bool>(@class.method_0)));
			}
			if (this.list_1.Contains(@class.class128_0))
			{
				this.list_1.Remove(@class.class128_0);
				this.lstEmuTitles.Items.Remove(this.lstEmuTitles.Items.First(new Func<ListViewDataItem, bool>(@class.method_1)));
			}
			if (!this.DeletedTitles.Contains(@class.class128_0.CorrespondingTitle.GClass32_0))
			{
				this.DeletedTitles.Add(@class.class128_0.CorrespondingTitle.GClass32_0);
			}
			this.method_3();
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0003AEE8 File Offset: 0x000390E8
		private void method_2()
		{
			foreach (Class128 class128_ in this.list_2.OrderByDescending(new Func<Class128, ulong>(frmAdvancedDiskManagement.<>c.<>c_0.method_0)))
			{
				this.method_0(class128_, this.lstTitles);
			}
			foreach (Class128 class128_2 in this.list_1.OrderByDescending(new Func<Class128, ulong>(frmAdvancedDiskManagement.<>c.<>c_0.method_1)))
			{
				this.method_0(class128_2, this.lstEmuTitles);
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00017871 File Offset: 0x00015A71
		private void lstEmuTitles_ItemRemoving(object sender, ListViewItemCancelEventArgs e)
		{
			this.method_1(e.Item.Tag as Class128);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00017871 File Offset: 0x00015A71
		private void lstTitles_ItemRemoving(object sender, ListViewItemCancelEventArgs e)
		{
			this.method_1(e.Item.Tag as Class128);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003AFC8 File Offset: 0x000391C8
		private void radButton1_Click(object sender, EventArgs e)
		{
			if (RadMessageBox.Show("This will delete all the RAW data for titles which are ready for emulation. Continue?", "Are you sure?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}
			Class128[] array = this.list_1.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				frmAdvancedDiskManagement.Class127 @class = new frmAdvancedDiskManagement.Class127();
				@class.class128_0 = array[i];
				if (@class.class128_0.CorrespondingTitle.Boolean_1)
				{
					try
					{
						this.method_1(this.list_2.First(new Func<Class128, bool>(@class.method_0)));
					}
					catch
					{
					}
				}
			}
			this.lstTitles.Invalidate();
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003B064 File Offset: 0x00039264
		private void method_3()
		{
			ulong num = 0UL;
			foreach (Class128 @class in this.list_1)
			{
				num += @class.Size;
			}
			this.lblTotalEmu.Text = new DataSize(num).ToString();
			num = 0UL;
			foreach (Class128 class2 in this.list_2)
			{
				num += class2.Size;
			}
			this.lblTotalRaw.Text = new DataSize(num).ToString();
		}

		// Token: 0x040005EB RID: 1515
		[CompilerGenerated]
		private readonly List<GClass32> list_0;

		// Token: 0x040005EC RID: 1516
		private List<Class128> list_1 = new List<Class128>();

		// Token: 0x040005ED RID: 1517
		private List<Class128> list_2 = new List<Class128>();

		// Token: 0x0200016B RID: 363
		[CompilerGenerated]
		private sealed class Class122
		{
			// Token: 0x06000AAD RID: 2733 RVA: 0x0003BE6C File Offset: 0x0003A06C
			internal void method_0()
			{
				using (Dictionary<TitleId, GClass32>.ValueCollection.Enumerator enumerator = GClass28.dictionary_0.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						frmAdvancedDiskManagement.Class123 @class = new frmAdvancedDiskManagement.Class123();
						@class.gclass32_0 = enumerator.Current;
						ulong num = GClass6.smethod_7(@class.gclass32_0.OutputPath);
						if (num > 0UL)
						{
							this.frmAdvancedDiskManagement_0.list_2.Add(new Class128(string.Format("{0} {1}", @class.gclass32_0.Name, @class.gclass32_0.Region), num, @class.gclass32_0, new Action(@class.method_0)));
						}
						if (@class.gclass32_0.Boolean_2)
						{
							num = GClass6.smethod_7(@class.gclass32_0.Dlc.OutputPath);
							if (num > 0UL)
							{
								this.frmAdvancedDiskManagement_0.list_2.Add(new Class128(string.Format("{0} {1} DLC", @class.gclass32_0.Name, @class.gclass32_0.Region), num, @class.gclass32_0.Dlc, new Action(@class.method_1)));
							}
						}
						using (List<GClass33>.Enumerator enumerator2 = @class.gclass32_0.Updates.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								frmAdvancedDiskManagement.Class124 class2 = new frmAdvancedDiskManagement.Class124();
								class2.gclass33_0 = enumerator2.Current;
								num = GClass6.smethod_7(class2.gclass33_0.OutputPath);
								if (num > 0UL)
								{
									this.frmAdvancedDiskManagement_0.list_2.Add(new Class128(string.Format("{0} {1} UPDATE {2}", @class.gclass32_0.Name, @class.gclass32_0.Region, class2.gclass33_0.Version), num, class2.gclass33_0, new Action(class2.method_0)));
								}
							}
						}
						GClass95 gclass = @class.gclass32_0.method_14(false);
						if (gclass != null)
						{
							ulong totalBytes = gclass.vmethod_2().TotalBytes;
							if (totalBytes > 0UL)
							{
								this.frmAdvancedDiskManagement_0.list_1.Add(new Class128(string.Format("{0} {1}", @class.gclass32_0.Name, @class.gclass32_0.Region), totalBytes, @class.gclass32_0, new Action(gclass.vmethod_1)));
							}
							totalBytes = gclass.GetDlcSize().TotalBytes;
							if (totalBytes > 0UL)
							{
								this.frmAdvancedDiskManagement_0.list_1.Add(new Class128(string.Format("{0} {1} DLC", @class.gclass32_0.Name, @class.gclass32_0.Region), totalBytes, @class.gclass32_0.Dlc, new Action(gclass.DeleteDlc)));
							}
							totalBytes = gclass.GetUpdateSize().TotalBytes;
							if (totalBytes > 0UL)
							{
								frmAdvancedDiskManagement.Class125 class3 = new frmAdvancedDiskManagement.Class125();
								class3.ulong_0 = gclass.GetUpdateVersion();
								if (class3.ulong_0 > 0UL)
								{
									try
									{
										this.frmAdvancedDiskManagement_0.list_1.Add(new Class128(string.Format("{0} {1} UPDATE {2}", @class.gclass32_0.Name, @class.gclass32_0.Region, class3.ulong_0), totalBytes, @class.gclass32_0.Updates.First(new Func<GClass33, bool>(class3.method_0)), new Action(gclass.DeleteUpdate)));
									}
									catch
									{
									}
								}
							}
						}
						FrmWait frmWait = this.frmWait_0;
						int num2 = this.int_0 + 1;
						this.int_0 = num2;
						frmWait.method_2((int)((double)num2 / (double)GClass28.dictionary_0.Count * 100.0));
					}
				}
				this.frmWait_0.method_0();
			}

			// Token: 0x040005FE RID: 1534
			public FrmWait frmWait_0;

			// Token: 0x040005FF RID: 1535
			public int int_0;

			// Token: 0x04000600 RID: 1536
			public frmAdvancedDiskManagement frmAdvancedDiskManagement_0;
		}

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		private sealed class Class123
		{
			// Token: 0x06000AAF RID: 2735 RVA: 0x000178A8 File Offset: 0x00015AA8
			internal void method_0()
			{
				this.gclass32_0.method_11();
			}

			// Token: 0x06000AB0 RID: 2736 RVA: 0x000178B6 File Offset: 0x00015AB6
			internal void method_1()
			{
				this.gclass32_0.Dlc.method_11();
			}

			// Token: 0x04000601 RID: 1537
			public GClass32 gclass32_0;
		}

		// Token: 0x0200016D RID: 365
		[CompilerGenerated]
		private sealed class Class124
		{
			// Token: 0x06000AB2 RID: 2738 RVA: 0x000178C9 File Offset: 0x00015AC9
			internal void method_0()
			{
				this.gclass33_0.method_11();
			}

			// Token: 0x04000602 RID: 1538
			public GClass33 gclass33_0;
		}

		// Token: 0x0200016E RID: 366
		[CompilerGenerated]
		private sealed class Class125
		{
			// Token: 0x06000AB4 RID: 2740 RVA: 0x000178D7 File Offset: 0x00015AD7
			internal bool method_0(GClass33 gclass33_0)
			{
				return gclass33_0.Version == this.ulong_0.ToString();
			}

			// Token: 0x04000603 RID: 1539
			public ulong ulong_0;
		}

		// Token: 0x0200016F RID: 367
		[CompilerGenerated]
		private sealed class Class126
		{
			// Token: 0x06000AB6 RID: 2742 RVA: 0x000178EF File Offset: 0x00015AEF
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Tag == this.class128_0;
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x000178EF File Offset: 0x00015AEF
			internal bool method_1(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Tag == this.class128_0;
			}

			// Token: 0x04000604 RID: 1540
			public Class128 class128_0;
		}

		// Token: 0x02000171 RID: 369
		[CompilerGenerated]
		private sealed class Class127
		{
			// Token: 0x06000ABD RID: 2749 RVA: 0x00017913 File Offset: 0x00015B13
			internal bool method_0(Class128 class128_1)
			{
				return class128_1.CorrespondingTitle == this.class128_0.CorrespondingTitle;
			}

			// Token: 0x04000608 RID: 1544
			public Class128 class128_0;
		}
	}
}

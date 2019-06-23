using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using HelperChat;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Helpers;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Microsoft.VisualBasic.Devices;
using Microsoft.WindowsAPICodePack.Taskbar;
using Newtonsoft.Json;
using NusHelper;
using NusHelper.Emulators;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI.Gauges;
using WIIU_Downloader.Forms;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x020001D2 RID: 466
	public partial class NusGrabberForm : RadForm
	{
		// Token: 0x06000CA6 RID: 3238 RVA: 0x00050EA0 File Offset: 0x0004F0A0
		public NusGrabberForm()
		{
			if (Settings.Default.Region == "NONE")
			{
				RadMessageBox.Show("You must specify a region.");
				Application.Restart();
			}
			Class95.smethod_14(this);
			this.InitializeComponent();
			this.toolGameInfo.Select();
			GClass28.Event_0 += this.method_67;
			base.WindowState = FormWindowState.Normal;
			base.StartPosition = FormStartPosition.WindowsDefaultBounds;
			if (Settings.Default.WindowPosition != Rectangle.Empty && GClass6.smethod_10(Settings.Default.WindowPosition))
			{
				base.StartPosition = FormStartPosition.Manual;
				base.DesktopBounds = Settings.Default.WindowPosition;
				base.WindowState = Settings.Default.WindowState;
			}
			else
			{
				base.StartPosition = FormStartPosition.WindowsDefaultLocation;
				base.Size = Settings.Default.WindowPosition.Size;
			}
			this.dockMain.FloatingWindowCreated += NusGrabberForm.<>c.<>c_0.method_0;
			this.dockInfo.FloatingWindowCreated += NusGrabberForm.<>c.<>c_0.method_1;
			this.pbPreview1.MouseDoubleClick += new MouseEventHandler(Class95.smethod_10);
			this.pbPreview2.MouseDoubleClick += new MouseEventHandler(Class95.smethod_10);
			this.pbPreview3.MouseDoubleClick += new MouseEventHandler(Class95.smethod_10);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000510DC File Offset: 0x0004F2DC
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			FormWindowState windowState = base.WindowState;
			if (windowState != FormWindowState.Normal)
			{
				if (windowState != FormWindowState.Maximized)
				{
					Settings.Default.WindowState = FormWindowState.Normal;
					goto IL_34;
				}
			}
			Settings.Default.WindowState = base.WindowState;
			IL_34:
			base.Visible = false;
			base.WindowState = FormWindowState.Normal;
			Settings.Default.WindowPosition = base.DesktopBounds;
			Settings.Default.Save();
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00051148 File Offset: 0x0004F348
		protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, Keys keyData)
		{
			if (keyData == (Keys.LButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolLibrary.Select();
				return true;
			}
			if (keyData == (Keys.RButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolFilters.Select();
				return true;
			}
			if (keyData == (Keys.LButton | Keys.RButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolAdvancedSearch.Select();
				return true;
			}
			if (keyData == (Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolAdvancedSettings.Select();
				return true;
			}
			if (keyData == (Keys.LButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolEmuSettings.Select();
				return true;
			}
			if (keyData == (Keys.RButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolContribute.Select();
				return true;
			}
			if (keyData == (Keys.LButton | Keys.RButton | Keys.MButton | Keys.ShiftKey | Keys.Space | Keys.Control))
			{
				this.toolHelp.Select();
				return true;
			}
			if (keyData == (Keys)131150)
			{
				GClass28.bool_1 = !GClass28.bool_1;
				RadMessageBox.Show("AES status : " + (GClass28.bool_1 ? "enabled" : "disabled"));
				return true;
			}
			if (keyData == (Keys)131138)
			{
				GClass28.bool_0 = !GClass28.bool_0;
				RadMessageBox.Show("Large buffer : " + (GClass28.bool_0 ? "enabled" : "disabled"));
				return true;
			}
			if (keyData == (Keys)131142)
			{
				this.FTSearchBox.Focus();
				return true;
			}
			if (keyData == (Keys)131148)
			{
				this.lstGames.Focus();
				try
				{
					ListViewDataItem listViewDataItem = this.lstGames.Items.First(new Func<ListViewDataItem, bool>(NusGrabberForm.<>c.<>c_0.method_2));
					this.lstGames.ListViewElement.EnsureItemVisible(listViewDataItem);
					this.lstGames.SelectedItem = listViewDataItem;
				}
				catch
				{
				}
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00018D1D File Offset: 0x00016F1D
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00018D25 File Offset: 0x00016F25
		private bool CurrentlyDownloading { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00018D2E File Offset: 0x00016F2E
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00018D36 File Offset: 0x00016F36
		private FrmWait frmWait { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00018D3F File Offset: 0x00016F3F
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00018D47 File Offset: 0x00016F47
		private int IndexGameCurrentlyDownloaded { get; set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00018D50 File Offset: 0x00016F50
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00018D58 File Offset: 0x00016F58
		private List<Platform> Platforms { get; set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00018D61 File Offset: 0x00016F61
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00018D69 File Offset: 0x00016F69
		private WebProxy Proxy { get; set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00018D72 File Offset: 0x00016F72
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00018D7A File Offset: 0x00016F7A
		private GClass32 PreviouslySelectedGame { get; set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00018D83 File Offset: 0x00016F83
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00018D8B File Offset: 0x00016F8B
		private GClass32 SelectedGame { get; set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00018D94 File Offset: 0x00016F94
		private List<GClass30> TitlesToCopy { get; } = new List<GClass30>();

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00018D9C File Offset: 0x00016F9C
		private List<GClass30> TitlesToDownload { get; } = new List<GClass30>();

		// Token: 0x06000CBA RID: 3258 RVA: 0x000512F4 File Offset: 0x0004F4F4
		private void method_0(GClass32 gclass32_2)
		{
			this.method_6(gclass32_2);
			try
			{
				if (gclass32_2.Boolean_3 && !this.dlQueue.smethod_0(gclass32_2.Updates.Last<GClass33>()) && gclass32_2.Updates.Last<GClass33>().GEnum2_0 != GEnum2.const_2 && RadMessageBox.Show(string.Format("{0} has an update that you do not have downloaded yet. Would you like to add it to the queue?", gclass32_2), "Add update?", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.method_6(gclass32_2.Updates.Last<GClass33>());
				}
				if (gclass32_2.Boolean_2 && !this.dlQueue.smethod_0(gclass32_2.Dlc))
				{
					if (gclass32_2.Dlc.GEnum2_0 != GEnum2.const_2)
					{
						if (RadMessageBox.Show(string.Format("{0} has a DLC that you do not have downloaded yet. Would you like to add it to the queue?", gclass32_2), "Add DLC?", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							this.method_6(gclass32_2.Dlc);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000513CC File Offset: 0x0004F5CC
		private ListViewDataItem method_1(GClass32 gclass32_2, RadListView radListView_0)
		{
			ListViewDataItem listViewDataItem = new ListViewDataItem(gclass32_2)
			{
				Tag = gclass32_2,
				Group = this.method_11(gclass32_2),
				ForeColor = Class95.smethod_0(gclass32_2)
			};
			radListView_0.Items.Add(listViewDataItem);
			listViewDataItem[0] = gclass32_2.Name;
			listViewDataItem[1] = gclass32_2.Region;
			listViewDataItem[2] = gclass32_2.Size;
			listViewDataItem[3] = gclass32_2.Int32_0 + "%";
			listViewDataItem[4] = (gclass32_2.Boolean_3 ? ((gclass32_2.Updates.Last<GClass33>().GEnum2_0 == GEnum2.const_2) ? "Ready" : "Yes") : "No");
			listViewDataItem[5] = (gclass32_2.Boolean_2 ? ((gclass32_2.Dlc.GEnum2_0 == GEnum2.const_2) ? "Ready" : "Yes") : "No");
			listViewDataItem[6] = gclass32_2.String_0;
			return listViewDataItem;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000514C8 File Offset: 0x0004F6C8
		private void method_2(GClass30 gclass30_0)
		{
			if (this.TitlesToCopy.Contains(gclass30_0))
			{
				return;
			}
			this.TitlesToCopy.Add(gclass30_0);
			ListViewDataItem item = new ListViewDataItem(gclass30_0)
			{
				Tag = gclass30_0
			};
			this.lstCopy.Items.Add(item);
			this.method_16();
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00051518 File Offset: 0x0004F718
		private void method_3()
		{
			this.DownloadButton.ButtonElement.BorderElement.ForeColor = System.Drawing.Color.Green;
			this.DownloadButton.ButtonElement.BorderElement.Width = 2f;
			if (this.timer_0 == null)
			{
				this.timer_0 = new System.Windows.Forms.Timer
				{
					Interval = 200
				};
				this.timer_0.Tick += this.timer_0_Tick;
				this.timer_0.Start();
			}
			this.timer_0.Start();
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000515A4 File Offset: 0x0004F7A4
		private void method_4()
		{
			NusGrabberForm.Class161 @class = new NusGrabberForm.Class161();
			@class.nusGrabberForm_0 = this;
			this.float_0 = 0f;
			@class.int_0 = 1;
			if (this.timer_1 == null)
			{
				this.timer_1 = new System.Windows.Forms.Timer
				{
					Interval = 33
				};
				this.timer_1.Tick += @class.method_0;
				this.timer_1.Start();
			}
			this.timer_1.Start();
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00051618 File Offset: 0x0004F818
		private void method_5(ListViewDataItem listViewDataItem_0)
		{
			NusGrabberForm.Class162 @class = new NusGrabberForm.Class162();
			@class.listViewDataItem_0 = listViewDataItem_0;
			@class.nusGrabberForm_0 = this;
			try
			{
				Task.Run(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00051660 File Offset: 0x0004F860
		private void method_6(GClass30 gclass30_0)
		{
			if (gclass30_0.DiscOnly)
			{
				RadMessageBox.Show("This title has only been released on disc and cannot therefore be downloaded from the eShop servers. You can however download its updates or dlc if applicable.");
				return;
			}
			if (!this.TitlesToDownload.Contains(gclass30_0))
			{
				if (gclass30_0.Platform == Platform.Nintendo_DS && Settings.Default.ShowHaxchiWarning)
				{
					if (RadMessageBox.Show("You are trying to add a DS VC game to your download list. DO NOT USE ANY TITLE DOWNLOADED FROM THIS APP TO INSTALL CBHC (Coldboot Hacxhi) OR YOU WILL BRICK ", "Caution!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
					{
						return;
					}
					Settings.Default.ShowHaxchiWarning = false;
					Settings.Default.Save();
				}
				this.TitlesToDownload.Add(gclass30_0);
				ListViewDataItem listViewDataItem = new ListViewDataItem
				{
					Tag = gclass30_0
				};
				this.method_5(listViewDataItem);
				this.dlQueue.Items.Add(listViewDataItem);
				this.method_3();
				this.method_17();
				if (this.CurrentlyDownloading)
				{
					this.gclass80_0.method_3();
				}
				this.method_18();
			}
			GClass32 selectedGame = this.SelectedGame;
			if (selectedGame != null && !selectedGame.method_29(gclass30_0))
			{
				return;
			}
			if (gclass30_0 is GClass32)
			{
				this.cmdAddGame.Enabled = false;
				return;
			}
			if (gclass30_0 is GClass31)
			{
				this.cmdAddDlc.Enabled = false;
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0005176C File Offset: 0x0004F96C
		private void method_7(GClass30 gclass30_0)
		{
			NusGrabberForm.Class164 @class = new NusGrabberForm.Class164();
			@class.gclass30_0 = gclass30_0;
			this.TitlesToDownload.Remove(@class.gclass30_0);
			this.dlQueue.Items.Remove(this.dlQueue.Items.First(new Func<ListViewDataItem, bool>(@class.method_0)));
			this.method_17();
			this.method_18();
			if (this.CurrentlyDownloading)
			{
				this.gclass80_0.method_3();
			}
			this.method_9();
			if (this.SelectedGame != null && !this.SelectedGame.method_29(@class.gclass30_0))
			{
				return;
			}
			if (@class.gclass30_0 is GClass33)
			{
				this.cmdAddUpdate.Enabled = true;
				return;
			}
			if (@class.gclass30_0 is GClass31)
			{
				this.cmdAddDlc.Enabled = true;
				return;
			}
			this.cmdAddGame.Enabled = true;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00051848 File Offset: 0x0004FA48
		private void method_8(int int_3, GClass133 gclass133_0)
		{
			if (int_3 == 0)
			{
				gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Hidden;
			}
			else
			{
				gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Visible;
			}
			if (int_3 == this.dlQueue.Items.Count - 1)
			{
				gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Hidden;
				return;
			}
			gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Visible;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000518A0 File Offset: 0x0004FAA0
		private void method_9()
		{
			GClass133[] array = this.list_4.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				NusGrabberForm.Class165 @class = new NusGrabberForm.Class165();
				@class.gclass133_0 = array[i];
				try
				{
					int num = this.dlQueue.Items.IndexOf(this.dlQueue.Items.First(new Func<ListViewDataItem, bool>(@class.method_0)));
					if (!this.CurrentlyDownloading)
					{
						this.method_8(num, @class.gclass133_0);
					}
					else if (num <= this.IndexGameCurrentlyDownloaded)
					{
						@class.gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Hidden;
						@class.gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Hidden;
					}
					else if (num == this.IndexGameCurrentlyDownloaded + 1)
					{
						@class.gclass133_0.lightVisualElement_1.Visibility = ElementVisibility.Hidden;
						if (num == this.dlQueue.Items.Count - 1)
						{
							@class.gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Hidden;
						}
						else
						{
							@class.gclass133_0.lightVisualElement_0.Visibility = ElementVisibility.Visible;
						}
					}
					else
					{
						this.method_8(num, @class.gclass133_0);
					}
				}
				catch
				{
					this.list_4.Remove(@class.gclass133_0);
				}
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000519DC File Offset: 0x0004FBDC
		private void method_10(GClass30 gclass30_0, int int_3)
		{
			NusGrabberForm.Class166 @class = new NusGrabberForm.Class166();
			@class.gclass30_0 = gclass30_0;
			try
			{
				int num = this.dlQueue.Items.IndexOf(this.dlQueue.Items.First(new Func<ListViewDataItem, bool>(@class.method_0)));
				object tag = this.dlQueue.Items[num + int_3].Tag;
				this.dlQueue.BeginEdit();
				ListViewDataItem listViewDataItem = new ListViewDataItem
				{
					Tag = this.dlQueue.Items[num].Tag
				};
				this.dlQueue.Items[num + int_3] = listViewDataItem;
				ListViewDataItem listViewDataItem2 = new ListViewDataItem
				{
					Tag = tag
				};
				this.dlQueue.Items[num] = listViewDataItem2;
				this.dlQueue.EndEdit();
				this.dlQueue.SelectedIndex = num + int_3;
				this.method_5(listViewDataItem);
				this.method_5(listViewDataItem2);
				GClass30 value = this.TitlesToDownload[num + int_3];
				this.TitlesToDownload[num + int_3] = this.TitlesToDownload[num];
				this.TitlesToDownload[num] = value;
				this.method_9();
			}
			catch
			{
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00051B28 File Offset: 0x0004FD28
		private void dlQueue_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
		{
			if (this.dlQueue.ViewType == ListViewType.DetailsView)
			{
				NusGrabberForm.Class167 @class = new NusGrabberForm.Class167();
				@class.nusGrabberForm_0 = this;
				@class.gclass133_0 = new GClass133();
				e.VisualItem = @class.gclass133_0;
				@class.gclass133_0.gclass30_0 = (GClass30)e.DataItem.Tag;
				@class.gclass133_0.lightVisualElement_1.Click += @class.method_0;
				@class.gclass133_0.lightVisualElement_0.Click += @class.method_1;
				this.list_4.Add(@class.gclass133_0);
			}
			this.method_9();
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00051BD4 File Offset: 0x0004FDD4
		private ListViewDataItemGroup method_11(GClass32 gclass32_2)
		{
			if (gclass32_2.Boolean_1)
			{
				return this.listViewDataItemGroup_4;
			}
			if (gclass32_2.Boolean_5)
			{
				return this.listViewDataItemGroup_2;
			}
			switch (gclass32_2.GEnum2_0)
			{
			case GEnum2.const_0:
				return this.listViewDataItemGroup_3;
			case GEnum2.const_1:
				return this.listViewDataItemGroup_1;
			case GEnum2.const_2:
				return this.listViewDataItemGroup_0;
			default:
				return this.listViewDataItemGroup_3;
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00051C34 File Offset: 0x0004FE34
		private void chkCopyToSD_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (e.ToggleState != ToggleState.On)
			{
				this.driveInfo_0 = null;
				return;
			}
			DriveInfo driveInfo = GClass32.smethod_4(new DataSize(0UL));
			if (driveInfo == null)
			{
				this.chkCopyToSD.Checked = false;
				return;
			}
			this.driveInfo_0 = driveInfo;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00018DA4 File Offset: 0x00016FA4
		private void chkDelay_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			this.radDate.Enabled = this.chkDelay.Checked;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00018DBC File Offset: 0x00016FBC
		private void chkEUR_CheckStateChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_49();
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00018DCC File Offset: 0x00016FCC
		private void chkHibernate_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (this.chkHibernate.Checked)
			{
				this.chkSleep.Checked = false;
				this.chkSleep.Checked = false;
				this.genum10_0 = GEnum10.const_3;
				return;
			}
			this.genum10_0 = GEnum10.const_0;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00018DBC File Offset: 0x00016FBC
		private void chkJAP_CheckStateChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_49();
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00018DBC File Offset: 0x00016FBC
		private void chkKOR_CheckStateChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_49();
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00051C78 File Offset: 0x0004FE78
		private void chkPack_ToggleStateChanging(object sender, StateChangingEventArgs e)
		{
			if (!this.chkPack.Checked && !GClass6.smethod_2(Settings.Default.ExtractFolder))
			{
				if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
				{
					Class95.smethod_12(false);
				}
				if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
				{
					e.Cancel = true;
				}
				return;
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00051CD4 File Offset: 0x0004FED4
		private void chkPreventShortcut_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (this.chkPreventShortcut.Checked && !File.Exists("NOSHORTCUT"))
			{
				File.WriteAllText("NOSHORTCUT", "");
			}
			if (!this.chkPreventShortcut.Checked)
			{
				GClass6.smethod_6("NOSHORTCUT");
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00018E02 File Offset: 0x00017002
		private void chkShowLegit_CheckedChanged(object sender, EventArgs e)
		{
			this.method_49();
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00018E02 File Offset: 0x00017002
		private void chkShowPreviews_CheckedChanged(object sender, EventArgs e)
		{
			this.method_49();
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00018E02 File Offset: 0x00017002
		private void chkShowRednand_CheckedChanged(object sender, EventArgs e)
		{
			this.method_49();
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00018E0A File Offset: 0x0001700A
		private void chkShutdown_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (this.chkShutdown.Checked)
			{
				this.chkSleep.Checked = false;
				this.chkHibernate.Checked = false;
				this.genum10_0 = GEnum10.const_2;
				return;
			}
			this.genum10_0 = GEnum10.const_0;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00018E40 File Offset: 0x00017040
		private void chkSleep_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			if (this.chkSleep.Checked)
			{
				this.chkShutdown.Checked = false;
				this.chkHibernate.Checked = false;
				this.genum10_0 = GEnum10.const_1;
				return;
			}
			this.genum10_0 = GEnum10.const_0;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00051D20 File Offset: 0x0004FF20
		private void chkUnpack_ToggleStateChanging(object sender, StateChangingEventArgs e)
		{
			if (!this.chkUnpack.Checked && !GClass6.smethod_2(Settings.Default.ExtractFolder))
			{
				if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
				{
					Class95.smethod_12(false);
				}
				if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
				{
					e.Cancel = true;
				}
				return;
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00018DBC File Offset: 0x00016FBC
		private void chkUSA_CheckStateChanged(object sender, EventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_49();
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00051D7C File Offset: 0x0004FF7C
		private void chkCompactView_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.CompactView = this.chkCompactView.Checked;
			Settings.Default.Save();
			if (this.chkCompactView.Checked)
			{
				this.lstGames.ViewType = ListViewType.DetailsView;
				this.lstGames.FullRowSelect = true;
			}
			else
			{
				this.lstGames.ViewType = ListViewType.IconsView;
				this.lstGames.ItemSize = new Size(170, 64);
			}
			this.lstGames.ItemSpacing = 1;
			this.lstGames.MultiSelect = true;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00051E0C File Offset: 0x0005000C
		private void method_12()
		{
			try
			{
				this.gclass130_0.Exit();
				this.gclass130_0.Dispose();
			}
			catch
			{
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00051E44 File Offset: 0x00050044
		private void cmdAbortAll_Click(object sender, EventArgs e)
		{
			if (this.CurrentlyDownloading)
			{
				if (RadMessageBox.Show("Are you sure you want to abort? The download will pick up where it stopped next time you start it.", "Abort", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.gclass80_0.method_0();
					Thread.Sleep(1000);
					this.method_60(this, "--Download aborted--");
					return;
				}
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00018E76 File Offset: 0x00017076
		private void cmdAbortDelay_Click(object sender, EventArgs e)
		{
			this.method_59();
			this.method_18();
			this.method_54(true);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00051E90 File Offset: 0x00050090
		private void cmdAddAllDLCS_Click(object sender, EventArgs e)
		{
			if (RadMessageBox.Show("Caution this will add all available DLCs to the queue for the games which are currently displayed in the list. This might take a lot of space and time. Continue ?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}
			foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
			{
				GClass32 gclass = listViewDataItem.Tag as GClass32;
				if (gclass.Boolean_2 && gclass.Dlc.GEnum2_0 != GEnum2.const_2 && listViewDataItem.Visible)
				{
					this.method_6(gclass.Dlc);
				}
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00051F28 File Offset: 0x00050128
		private void cmdAddAllUpdates_Click(object sender, EventArgs e)
		{
			if (RadMessageBox.Show("Caution this will add all available updates to the queue for the games which are currently displayed in the list. This might take a lot of space and time. Continue ?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}
			bool flag = RadMessageBox.Show("Should USB Helper also add older versions of updates?", "Add older versions?", MessageBoxButtons.YesNo) == DialogResult.Yes;
			foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
			{
				GClass32 gclass = listViewDataItem.Tag as GClass32;
				if (gclass.Boolean_3 && listViewDataItem.Visible)
				{
					if (flag)
					{
						using (IEnumerator<GClass33> enumerator2 = gclass.Updates.Where(new Func<GClass33, bool>(NusGrabberForm.<>c.<>c_0.method_3)).GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								GClass33 gclass30_ = enumerator2.Current;
								this.method_6(gclass30_);
							}
							continue;
						}
					}
					if (gclass.Updates.Last<GClass33>().GEnum2_0 != GEnum2.const_2)
					{
						this.method_6(gclass.Updates.Last<GClass33>());
					}
				}
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00018E8B File Offset: 0x0001708B
		private void cmdAddDlc_Click(object sender, EventArgs e)
		{
			this.method_6(this.SelectedGame.Dlc);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00052054 File Offset: 0x00050254
		private void cmdAddGame_Click(object sender, EventArgs e)
		{
			if (this.SelectedGame == null)
			{
				return;
			}
			Image image = this.lstGames.Items.First(new Func<ListViewDataItem, bool>(this.method_68)).Image;
			if (image != null)
			{
				Point position = Cursor.Position;
				Point point_ = this.dlQueue.FindForm().PointToClient(this.dlQueue.Parent.PointToScreen(this.dlQueue.Location));
				new frmOverlay(base.Handle, image, position, point_).ShowDialog();
				try
				{
					this.soundPlayer_0.Play();
				}
				catch
				{
				}
			}
			this.method_0(this.SelectedGame);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00052104 File Offset: 0x00050304
		private void cmdAddUpdate_Click(object sender, EventArgs e)
		{
			FrmSelectVersion frmSelectVersion = new FrmSelectVersion(this.SelectedGame.Updates, false);
			if (frmSelectVersion.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			foreach (GClass33 gclass30_ in frmSelectVersion.list_0)
			{
				this.method_6(gclass30_);
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00018E9E File Offset: 0x0001709E
		private void method_13(object sender, EventArgs e)
		{
			new frmBug().Show();
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00052174 File Offset: 0x00050374
		private void cmdChangeRegion_Click(object sender, EventArgs e)
		{
			Settings.Default.Region = "NONE";
			this.bool_1 = true;
			Settings.Default.Boolean_0 = false;
			Settings.Default.Boolean_2 = false;
			Settings.Default.Boolean_1 = false;
			Settings.Default.Save();
			Application.Restart();
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00018EAA File Offset: 0x000170AA
		private void cmdChangeTheme_Click(object sender, EventArgs e)
		{
			new frmSelectTheme().ShowDialog();
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00018EB7 File Offset: 0x000170B7
		private void cmdChangeTicket_Click(object sender, EventArgs e)
		{
			Settings.Default.TicketsPath = "";
			Settings.Default.TicketsPath3DS = "";
			Settings.Default.Save();
			Application.Restart();
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000521C8 File Offset: 0x000503C8
		private void radButton1_Click(object sender, EventArgs e)
		{
			foreach (ListViewDataItem listViewDataItem in this.lstCopy.Items.ToArray<ListViewDataItem>())
			{
				this.method_50(listViewDataItem.Tag as GClass30);
			}
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00018EE6 File Offset: 0x000170E6
		private void cmdClearCriterias_Click(object sender, EventArgs e)
		{
			this.chkGameGenres.UncheckAllItems();
			this.list_0 = null;
			this.method_21();
			this.method_49();
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0005220C File Offset: 0x0005040C
		private void cmdClearDl_Click(object sender, EventArgs e)
		{
			foreach (ListViewDataItem listViewDataItem in this.dlQueue.Items.ToArray<ListViewDataItem>())
			{
				this.method_7(listViewDataItem.Tag as GClass30);
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00018F06 File Offset: 0x00017106
		private void cmdClearProxy_Click(object sender, EventArgs e)
		{
			this.method_61();
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00018F0E File Offset: 0x0001710E
		private void cmdCopy_Click(object sender, EventArgs e)
		{
			this.method_55(this.SelectedGame);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00052250 File Offset: 0x00050450
		private void cmdCopyAll_Click(object sender, EventArgs e)
		{
			if (RadMessageBox.Show("This will add all downloaded content (games,updates and dlc) to the copy queue. Continue?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}
			foreach (GClass32 gclass in this.lstGames.Items.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_4)))
			{
				if (gclass.GEnum2_0 == GEnum2.const_2)
				{
					this.method_2(gclass);
				}
				if (gclass.Boolean_3)
				{
					foreach (GClass33 gclass30_ in gclass.Updates.Where(new Func<GClass33, bool>(NusGrabberForm.<>c.<>c_0.method_5)))
					{
						this.method_2(gclass30_);
					}
				}
				if (gclass.Boolean_2 && gclass.Dlc.GEnum2_0 == GEnum2.const_2)
				{
					this.method_2(gclass.Dlc);
				}
			}
			this.toolCopy.Select();
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00018F1C File Offset: 0x0001711C
		private void cmdDelete_Click(object sender, EventArgs e)
		{
			this.method_28(this.SelectedGame);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00018F2A File Offset: 0x0001712A
		private void cmdDonate_Click(object sender, EventArgs e)
		{
			new frmDonation().ShowDialog();
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00052380 File Offset: 0x00050580
		private void cmdAddAllGames_Click(object sender, EventArgs e)
		{
			if (RadMessageBox.Show("Caution this will add to the queue all the games which are currently displayed in the list. This might take a lot of space and time. Continue ?", "Continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}
			foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
			{
				GClass32 gclass = listViewDataItem.Tag as GClass32;
				if (gclass.GEnum2_0 != GEnum2.const_2 && listViewDataItem.Visible)
				{
					this.method_6(gclass);
				}
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00018F37 File Offset: 0x00017137
		private void cmdGoBack_Click(object sender, EventArgs e)
		{
			this.webBrowser.GoBack();
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00018F45 File Offset: 0x00017145
		private void cmdGoNext_Click(object sender, EventArgs e)
		{
			this.webBrowser.GoForward();
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00018F53 File Offset: 0x00017153
		private void cmdHallOfFame_Click(object sender, EventArgs e)
		{
			new FrmHallOfFame().ShowDialog();
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00052404 File Offset: 0x00050604
		private void cmdImportGames_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				Description = "Please select the root folder to scan."
			};
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			FrmImport frmImport = new FrmImport(folderBrowserDialog.SelectedPath);
			if (frmImport.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			Class95.smethod_15(this, "The games have been imported sucessfuly!");
			this.method_63(true, true, frmImport.list_0);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0005245C File Offset: 0x0005065C
		private void cmdInitiateCopy_Click(object sender, EventArgs e)
		{
			if (this.lstCopy.Items.Count == 0)
			{
				return;
			}
			DriveInfo driveInfo = GClass32.smethod_4((DataSize)this.lblTotalCopy.Tag);
			if (driveInfo == null)
			{
				return;
			}
			Class95.smethod_4(this.TitlesToCopy, driveInfo, false, true, this);
			this.method_63(false, true, this.TitlesToCopy.Where(new Func<GClass30, bool>(NusGrabberForm.<>c.<>c_0.method_6)).Select(new Func<GClass30, GClass32>(NusGrabberForm.<>c.<>c_0.method_7)).ToList<GClass32>());
			this.radButton1_Click(null, null);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00018F60 File Offset: 0x00017160
		private void cmdLegal_Click(object sender, EventArgs e)
		{
			new frmLegal().ShowDialog();
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00018F6D File Offset: 0x0001716D
		private void cmdManageRemoteSd_Click(object sender, EventArgs e)
		{
			if (this.gclass82_0 == null)
			{
				Class95.smethod_16(this);
				return;
			}
			Class95.smethod_9(string.Format("ftp://{0}/sd/Install/", this.gclass82_0.IPAddress_0));
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00018F98 File Offset: 0x00017198
		private void cmdPlay_Click(object sender, EventArgs e)
		{
			this.method_42(this.SelectedGame);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00052508 File Offset: 0x00050708
		private void cmdPrepareSd_Click(object sender, EventArgs e)
		{
			FrmSelectDrive frmSelectDrive = new FrmSelectDrive(new DataSize(0UL));
			if (frmSelectDrive.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			DriveInfo driveInfo = frmSelectDrive.driveInfo_0;
			if (driveInfo.DriveFormat != "FAT32")
			{
				RadMessageBox.Show("This drive needs to be formatted to FAT32 before being used on a WiiU. Please try again once you have formatted it");
				return;
			}
			GClass27.smethod_10(driveInfo.Name);
			RadMessageBox.Show("SD card prepared!" + Environment.NewLine + "To launch the homebrew channel, open the web browser on your Wii U, go to http://loadiine.ovh and press \"Submit\"");
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00018FA6 File Offset: 0x000171A6
		private void cmdRefresh_Click(object sender, EventArgs e)
		{
			this.method_51();
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00052578 File Offset: 0x00050778
		private void cmdRestoreSave_Click(object sender, EventArgs e)
		{
			NusGrabberForm.Class168 @class = new NusGrabberForm.Class168();
			if (this.gclass82_0 == null)
			{
				Class95.smethod_16(this);
				return;
			}
			frmChoseSave frmChoseSave = new frmChoseSave(this.SelectedGame);
			if (frmChoseSave.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper uploads your save.", false);
			Task.Run<DialogResult>(new Func<DialogResult>(@class.method_0));
			try
			{
				this.SelectedGame.method_26(this.gclass82_0, frmChoseSave.saveDescription_0.Timestamp);
			}
			catch (Exception ex)
			{
				@class.frmWait_0.method_0();
				Class95.smethod_15(this, ex.Message);
				return;
			}
			@class.frmWait_0.method_0();
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00052628 File Offset: 0x00050828
		private void cmdSearchWithCriterias_Click(object sender, EventArgs e)
		{
			if (this.chkGameGenres.CheckedItems.Count == 0)
			{
				return;
			}
			this.list_0 = new List<string>();
			new FrmWait("USB Helper is looking for your games...", new Action(this.method_69), new Action<Exception>(NusGrabberForm.<>c.<>c_0.method_8));
			this.method_21();
			this.method_49();
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00018FAE File Offset: 0x000171AE
		private void method_14(object sender, EventArgs e)
		{
			new frmChangeLog().Show();
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00052698 File Offset: 0x00050898
		private void cmdSendWiiu_Click(object sender, EventArgs e)
		{
			NusGrabberForm.Class169 @class = new NusGrabberForm.Class169();
			@class.nusGrabberForm_0 = this;
			if (this.lstCopy.Items.Count == 0)
			{
				return;
			}
			if (this.gclass82_0 == null)
			{
				Class95.smethod_16(this);
				return;
			}
			Class58.bool_0 = true;
			@class.string_0 = "";
			string str = "--COPY REPORT--" + Environment.NewLine;
			bool flag = RadMessageBox.Show("Should the titles be installed automatically once the transfer is complete?", "Install", MessageBoxButtons.YesNo) == DialogResult.Yes;
			bool? nullable_ = null;
			if (this.gclass82_0.TransferVersion > 10)
			{
				nullable_ = new bool?(RadMessageBox.Show("Should the titles be removed automatically from the SD once the installation is complete?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes);
			}
			int num = 0;
			using (List<GClass30>.Enumerator enumerator = this.TitlesToCopy.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					NusGrabberForm.Class170 class2 = new NusGrabberForm.Class170();
					class2.class169_0 = @class;
					class2.gclass30_0 = enumerator.Current;
					NusGrabberForm.Class171 class3 = new NusGrabberForm.Class171();
					class3.class170_0 = class2;
					if (class3.class170_0.gclass30_0.System != GEnum3.const_1)
					{
						return;
					}
					class3.frmFtpProgress_0 = new FrmFtpProgress(class3.class170_0.gclass30_0);
					class3.class170_0.gclass30_0.Event_1 += class3.method_0;
					class3.class170_0.gclass30_0.Event_0 += class3.method_1;
					class3.frmFtpProgress_0.Event_0 += class3.class170_0.method_0;
					Thread.Sleep(1000);
					class3.class170_0.gclass30_0.method_18(false, this.gclass82_0, flag, nullable_);
					class3.frmFtpProgress_0.ShowDialog();
					if (++num < this.TitlesToCopy.Count && flag)
					{
						this.gclass82_0 = null;
						string text = "USB Helper is waiting for the installation to complete...";
						Action action_;
						if ((action_ = class3.class170_0.class169_0.action_0) == null)
						{
							action_ = (class3.class170_0.class169_0.action_0 = new Action(class3.class170_0.class169_0.method_0));
						}
						new FrmWait(text, action_, new Action<Exception>(NusGrabberForm.<>c.<>c_0.method_9));
					}
					if (class3.class170_0.class169_0.string_0 == "OK" && class3.class170_0.gclass30_0 is GClass32)
					{
						(class3.class170_0.gclass30_0 as GClass32).Boolean_5 = true;
					}
					str += string.Format("-{0} : {1} {2}", class3.class170_0.gclass30_0, class3.class170_0.class169_0.string_0, Environment.NewLine);
				}
			}
			Class95.smethod_15(this, str);
			this.gclass82_0 = null;
			this.method_63(false, true, null);
			this.radButton1_Click(null, null);
			Class58.bool_0 = false;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000529A4 File Offset: 0x00050BA4
		private void cmdSetProxy_Click(object sender, EventArgs e)
		{
			try
			{
				Uri address = new Uri(this.txtProxyUrl.Text);
				NetworkCredential credentials = new NetworkCredential(this.txtProxyUsr.Text, this.txtProxyPassword.Text);
				WebProxy proxy = new WebProxy
				{
					Address = address,
					Credentials = credentials,
					UseDefaultCredentials = true
				};
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.google.com");
				httpWebRequest.Proxy = proxy;
				httpWebRequest.Timeout = 5000;
				httpWebRequest.Method = "GET";
				using (httpWebRequest.GetResponse())
				{
					this.Proxy = proxy;
				}
				this.lblproxyStatus.Text = "Set";
				this.lblproxyStatus.ForeColor = System.Drawing.Color.Green;
			}
			catch (Exception ex)
			{
				this.method_61();
				RadMessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00018FBA File Offset: 0x000171BA
		private void cmdShortcut_Click(object sender, EventArgs e)
		{
			GClass128.smethod_0(this.SelectedGame);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00018FC7 File Offset: 0x000171C7
		private void cmdSugegstIdea_Click(object sender, EventArgs e)
		{
			new frmFeedback().ShowDialog();
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00018FD4 File Offset: 0x000171D4
		private void method_15()
		{
			Task.Run(new Action(this.method_70));
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00052A90 File Offset: 0x00050C90
		private void method_16()
		{
			DataSize dataSize = new DataSize(0UL);
			dataSize = this.lstCopy.Items.Aggregate(dataSize, new Func<DataSize, ListViewDataItem, DataSize>(NusGrabberForm.<>c.<>c_0.method_10));
			this.lblTotalCopy.Text = dataSize.ToString();
			this.lblTotalCopy.Tag = dataSize;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00052B00 File Offset: 0x00050D00
		private void method_17()
		{
			DataSize dataSize = new DataSize(0UL);
			dataSize = this.dlQueue.Items.Aggregate(dataSize, new Func<DataSize, ListViewDataItem, DataSize>(NusGrabberForm.<>c.<>c_0.method_11));
			this.lblTotalDl.Text = dataSize.ToString();
			RadLabel radLabel = this.lblTotalDl;
			radLabel.Text += string.Format(" (Download time : {0})", GClass6.smethod_13(dataSize, new GStruct3(Settings.Default.MeasuredSpeed)));
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00052B94 File Offset: 0x00050D94
		private void method_18()
		{
			this.DownloadButton.Enabled = (this.dlQueue.Items.Count > 0 && !this.CurrentlyDownloading);
			if (!this.DownloadButton.Enabled)
			{
				System.Windows.Forms.Timer timer = this.timer_0;
				if (timer == null)
				{
					return;
				}
				timer.Stop();
				return;
			}
			else
			{
				System.Windows.Forms.Timer timer2 = this.timer_0;
				if (timer2 == null)
				{
					return;
				}
				timer2.Start();
				return;
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00018FE8 File Offset: 0x000171E8
		private void dlQueue_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
		{
			if (this.CurrentlyDownloading && this.dlQueue.SelectedIndex <= this.IndexGameCurrentlyDownloaded)
			{
				RadMessageBox.Show("You cannot remove this game while downloading. Please abort first.");
				return;
			}
			this.method_7(e.Item.Tag as GClass30);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00019027 File Offset: 0x00017227
		private void DownloadButton_Click(object sender, EventArgs e)
		{
			this.method_44();
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00052BFC File Offset: 0x00050DFC
		private void method_19(object object_0, GClass81 gclass81_0)
		{
			NusGrabberForm.Class172 @class = new NusGrabberForm.Class172();
			@class.gclass81_0 = gclass81_0;
			@class.nusGrabberForm_0 = this;
			try
			{
				base.Invoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00052C48 File Offset: 0x00050E48
		private byte[] method_20(string string_4)
		{
			string path = Path.Combine(NusGrabberForm.string_2, GClass88.smethod_8(string_4));
			if (GClass6.smethod_3(string_4))
			{
				this.bool_5 = string_4.Contains("wiiu.titlekeys");
				this.bool_4 = string_4.Contains("3ds.titlekeys");
				this.bool_6 = string_4.Contains("wii.titlekeys");
				GClass78 gclass = new GClass78();
				try
				{
					byte[] array;
					if (!this.bool_5 && !this.bool_4 && !this.bool_6)
					{
						array = gclass.method_2(string_4);
					}
					else
					{
						array = gclass.method_4(string_4 + "json", 2);
					}
					Directory.CreateDirectory(NusGrabberForm.string_2);
					File.WriteAllBytes(path, array);
					return array;
				}
				catch
				{
					if (File.Exists(path))
					{
						Class95.smethod_15(this, string.Format("There was an error while trying to fetch the title keys from {0}. Wii U USB Helper will now try to use a backup version. Please note that some features might now work as expected.", string_4));
						return File.ReadAllBytes(path);
					}
					Class95.smethod_15(this, string.Format("There was an error while trying to fetch the title keys from {0} (the site is probably down). No backup was found. Unfortunately the app cannot work without it.", string_4));
					return null;
				}
			}
			if (!File.Exists(string_4))
			{
				return null;
			}
			byte[] result;
			try
			{
				result = File.ReadAllBytes(string_4);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00052D64 File Offset: 0x00050F64
		private void method_21()
		{
			this.bool_0 = false;
			this.lstGames.FilterDescriptors.Clear();
			this.lstGames.FilterPredicate = new Predicate<ListViewDataItem>(this.method_57);
			this.lstGames.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, this.FTSearchBox.Text));
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0001902F File Offset: 0x0001722F
		private void timer_2_Tick(object sender, EventArgs e)
		{
			this.method_49();
			this.timer_2.Stop();
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00019042 File Offset: 0x00017242
		private void FTSearchBox_TextChanged(object sender, EventArgs e)
		{
			this.lstGames.smethod_1(true);
			this.timer_2.Stop();
			this.timer_2.Start();
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00052DC8 File Offset: 0x00050FC8
		private void method_22(GClass74 gclass74_0, GClass32 gclass32_2)
		{
			NusGrabberForm.Class173 @class = new NusGrabberForm.Class173();
			@class.nusGrabberForm_0 = this;
			@class.gclass74_0 = gclass74_0;
			@class.gclass32_0 = gclass32_2;
			try
			{
				if (!base.IsDisposed)
				{
					base.Invoke(new Action(@class.method_0));
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00052E24 File Offset: 0x00051024
		private NusGrabberForm.Class159 method_23()
		{
			NusGrabberForm.Class174 @class = new NusGrabberForm.Class174();
			@class.nusGrabberForm_0 = this;
			if (Settings.Default.TicketsPath.Contains("wiiu.titlekeys.com"))
			{
				Settings.Default.TicketsPath = "http://wiiu.titlekeys.gq/";
			}
			if (Settings.Default.TicketsPath3DS.Contains("3ds.titlekeys.com"))
			{
				Settings.Default.TicketsPath3DS = "http://3ds.titlekeys.gq/";
			}
			@class.byte_0 = null;
			@class.byte_1 = null;
			@class.byte_2 = null;
			new FrmWait("USB Helper is fetching the title keys.", new Action(@class.method_0), new Action<Exception>(NusGrabberForm.<>c.<>c_0.method_26));
			while (@class.byte_0 == null && @class.byte_1 == null && @class.byte_2 == null)
			{
				FrmAskTicket frmAskTicket = new FrmAskTicket();
				if (frmAskTicket.ShowDialog() != DialogResult.OK)
				{
					break;
				}
				Settings.Default.TicketsPath = frmAskTicket.FileLocationWiiU;
				Settings.Default.TicketsPath3DS = frmAskTicket.FileLocation3DS;
				Settings.Default.TicketsPathWii = frmAskTicket.FileLocationWii;
				string text = "USB Helper is fetching the title keys.";
				Action action_;
				if ((action_ = @class.action_0) == null)
				{
					action_ = (@class.action_0 = new Action(@class.method_1));
				}
				new FrmWait(text, action_, new Action<Exception>(NusGrabberForm.<>c.<>c_0.method_27));
			}
			return new NusGrabberForm.Class159
			{
				WiiU = @class.byte_0,
				Byte_0 = @class.byte_1,
				Wii = @class.byte_2
			};
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00019066 File Offset: 0x00017266
		private void method_24()
		{
			this.lblStorageLocation.Text = string.Format("<html>The content is stored in <span style=\"color: #ff8000\">{0}</span>. <strong>DATA</strong> contains Wii U and Emulation data, <strong>DATA_3DS</strong> contains 3DS data.<br> <span>Manually extracted games will go in : <span style=\"color: #ff8000\">{1}</span><br></html>", Settings.Default.Path, Settings.Default.ExtractFolder);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00052FB0 File Offset: 0x000511B0
		private void method_25(byte[] byte_0, byte[] byte_1, byte[] byte_2)
		{
			NusGrabberForm.Class175 @class = new NusGrabberForm.Class175();
			@class.nusGrabberForm_0 = this;
			this.timer_6.Stop();
			GClass89.Event_0 += @class.method_0;
			GClass89.smethod_0(Settings.Default.LaunchCount, Settings.Default.DonationKey, Class121.keysPub);
			Settings @default = Settings.Default;
			int launchCount = @default.LaunchCount;
			@default.LaunchCount = launchCount + 1;
			Settings.Default.Save();
			this.frmWait = new FrmWait("Now loading...", true);
			Task.Run<DialogResult>(new Func<DialogResult>(@class.method_1));
			try
			{
				this.frmWait.method_2(10);
				string text = ApplicationDeployment.IsNetworkDeployed ? "CLICKONCE" : "UPDATER";
				string string_ = ApplicationDeployment.IsNetworkDeployed ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : Class100.string_0;
				string string_2 = "NONE";
				try
				{
					string_2 = new ComputerInfo().OSFullName;
				}
				catch
				{
				}
				GClass26.smethod_0(Settings.Default.Path, NusGrabberForm.string_2, Settings.Default.TicketsPath, Settings.Default.TicketsPath3DS, "wiiuusbhelper.com", "https://registration.wiiuusbhelper.com", this.bool_5 || this.bool_4 || this.bool_6, byte_0, byte_1, byte_2, new GStruct2(text, string_2, string_), null);
				this.frmWait.method_2(60);
			}
			catch (Exception ex)
			{
				RadMessageBox.Show(ex.ToString());
				Application.Exit();
				return;
			}
			this.cmdRefresh.Enabled = (this.bool_5 || this.bool_4 || this.bool_6);
			this.dlQueue.Items.Clear();
			try
			{
				this.lstGames.BeginUpdate();
				this.lstGames.FilterDescriptors.Clear();
				this.lstGames.FilterPredicate = null;
				this.lstGames.Items.Clear();
				this.lstGames.EndUpdate();
			}
			catch
			{
			}
			Settings.Default.Save();
			this.lstGames.EnableCustomGrouping = true;
			this.lstGames.ShowGroups = true;
			this.lstGames.EnableFiltering = true;
			this.lstGames.EnableSorting = true;
			this.lstGames.EnableColumnSort = true;
			this.lstGames.BeginUpdate();
			@class.frmWait_0 = new FrmWait("USB HELPER is retrieving the latest metadata", true);
			Task.Run<DialogResult>(new Func<DialogResult>(@class.method_2));
			int num = 0;
			int num2 = -1;
			int count = GClass28.dictionary_0.Values.Count;
			foreach (GClass32 gclass32_ in GClass28.dictionary_0.Values.OrderByDescending(new Func<GClass32, bool>(NusGrabberForm.<>c.<>c_0.method_28)).ThenBy(new Func<GClass32, string>(NusGrabberForm.<>c.<>c_0.method_29)))
			{
				this.method_1(gclass32_, this.lstGames);
				int num3 = (int)((double)num++ / (double)count * 100.0);
				if (num3 > num2)
				{
					num2 = num3;
					@class.frmWait_0.method_2(num3);
				}
			}
			@class.frmWait_0.method_0();
			this.lstGames.EndUpdate();
			this.method_52();
			Class95.smethod_3();
			new Thread(new ThreadStart(this.method_43))
			{
				IsBackground = true
			}.Start();
			Thread.Sleep(75);
			this.frmWait.method_2(100);
			this.chkSuperSpeed.Checked = Settings.Default.EnableSuperSpeed;
			this.chkShowPreviews.Checked = Settings.Default.ShowEvents;
			this.chkShowLegit.Checked = Settings.Default.ShowLegit;
			this.chkDisableSpeedGraph.Checked = !Settings.Default.ShowSpeedGraph;
			this.chkShowRednand.Checked = Settings.Default.ShowCFW;
			this.chkForceGameMode.Checked = Settings.Default.ForceGameMode;
			this.chkPreventShortcut.Checked = File.Exists("NOSHORTCUT");
			this.chkNotifyChat.Checked = Settings.Default.ChatNotifications;
			this.radioGameRoom.IsChecked = Settings.Default.GameSpecificRoom;
			this.radioLobby.IsChecked = !Settings.Default.GameSpecificRoom;
			this.frmWait.method_0();
			this.smethod_0(false, Class121.logo_horiz);
			this.method_26();
			this.method_27();
			this.method_24();
			string region = Settings.Default.Region;
			if (!(region == "EUR"))
			{
				if (!(region == "JPN"))
				{
					if (region == "USA")
					{
						Settings.Default.Boolean_2 = true;
					}
				}
				else
				{
					Settings.Default.Boolean_1 = true;
				}
			}
			else
			{
				Settings.Default.Boolean_0 = true;
			}
			this.bool_0 = true;
			this.chkEUR.Checked = Settings.Default.Boolean_0;
			this.chkJAP.Checked = Settings.Default.Boolean_1;
			this.chkUSA.Checked = Settings.Default.Boolean_2;
			this.chkKOR.Checked = Settings.Default.Boolean_3;
			this.method_49();
			foreach (ListViewDataItemGroup listViewDataItemGroup in this.lstGames.Groups)
			{
				try
				{
					ListViewDataItem listViewDataItem = listViewDataItemGroup.Items.First(new Func<ListViewDataItem, bool>(NusGrabberForm.<>c.<>c_0.method_30));
					this.lstGames.ListViewElement.EnsureItemVisible(listViewDataItem);
					this.lstGames.SelectedItem = listViewDataItem;
					break;
				}
				catch
				{
				}
			}
			this.chkCompactView.Checked = Settings.Default.CompactView;
			Task.Run(new Action(NusGrabberForm.<>c.<>c_0.method_31));
			this.method_15();
			if (Settings.Default.Show552Warning)
			{
				Settings.Default.Show552Warning = false;
				Settings.Default.Save();
				if (RadMessageBox.Show("Thank you for using Wii U USB Helper! A new Wii U update (5.5.2) has been released. It is strongly advised NOT TO update. Would you like to see how to prevent your console from updating?", "New update!", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
				Process.Start("https://github.com/FlimFlam69/WiiUTutorial/wiki/1:-Blocking-Updates-From-Nintendo");
			}
			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = 4000;
			timer.Tick += @class.method_3;
			timer.Start();
			GClass83 gclass = new GClass83();
			gclass.Event_0 += @class.method_4;
			gclass.method_0(true);
			if (Settings.Default.ForceGameMode)
			{
				this.method_47();
			}
			GClass128.smethod_1();
			this.timer_6.Start();
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000536A0 File Offset: 0x000518A0
		private void method_26()
		{
			if (!GClass28.NewTitles.Any<GClass32>())
			{
				return;
			}
			FrmNewTitles frmNewTitles = new FrmNewTitles(GClass28.NewTitles, "New titles have been added! Please choose the ones you wish to download.");
			if (frmNewTitles.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			foreach (GClass30 gclass in frmNewTitles.list_0)
			{
				this.method_0(gclass as GClass32);
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00053720 File Offset: 0x00051920
		private void method_27()
		{
			if (!GClass28.NewUpdates.Any<GClass33>())
			{
				return;
			}
			FrmNewTitles frmNewTitles = new FrmNewTitles(GClass28.NewUpdates, "New titles have been added! Please choose the ones you wish to download.");
			if (frmNewTitles.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			foreach (GClass30 gclass30_ in frmNewTitles.list_0)
			{
				this.method_6(gclass30_);
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0005379C File Offset: 0x0005199C
		private void method_28(GClass32 gclass32_2)
		{
			if (gclass32_2.Boolean_1)
			{
				frmRawOrEmu frmRawOrEmu = new frmRawOrEmu();
				if (frmRawOrEmu.ShowDialog() == DialogResult.OK)
				{
					if (frmRawOrEmu.bool_0)
					{
						this.method_56(gclass32_2);
					}
					else
					{
						new frmEmuInfo(gclass32_2).ShowDialog();
					}
				}
			}
			else
			{
				this.method_56(gclass32_2);
			}
			this.method_63(false, true, this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_32)).ToList<GClass32>());
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00053824 File Offset: 0x00051A24
		private void method_29(List<GClass30> list_5)
		{
			this.IndexGameCurrentlyDownloaded = -1;
			try
			{
				this.chartValues_0.Clear();
			}
			catch
			{
			}
			GClass80 gclass = new GClass80(this.Proxy, true, true);
			this.gclass80_0 = gclass;
			this.gclass80_0.method_4((ulong)this.radMaxSpeed.Value * 1000UL);
			this.CurrentlyDownloading = true;
			gclass.Event_6 += this.method_46;
			gclass.Event_3 += this.method_60;
			gclass.Event_4 += this.method_71;
			gclass.Event_5 += this.method_19;
			this.gclass80_0.Event_0 += this.method_72;
			this.toolDownload.Image = Class121.dlTabGif;
			gclass.method_1(list_5, 100, 10000);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00053914 File Offset: 0x00051B14
		private void method_30()
		{
			GClass95 gclass = this.SelectedGame.method_14(true);
			if (gclass == null)
			{
				RadMessageBox.Show("Unfortunately emulation is not yet implemented for this title.");
				return;
			}
			try
			{
				this.SelectedGame.method_13(gclass);
			}
			catch (Exception ex)
			{
				RadMessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0005396C File Offset: 0x00051B6C
		private void method_31(object sender, EventArgs e)
		{
			this.smethod_0(true, Class121.logo_horiz);
			Class95.smethod_2();
			NusGrabberForm.Class159 @class = this.method_23();
			bool flag = true;
			while (@class.WiiU == null && @class.Byte_0 == null && @class.Wii == null && flag)
			{
				if (RadMessageBox.Show("The application could not retrieve the ticket archive from the specified location. Would you like to specify another one?", "Tickets", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					@class = this.method_23();
				}
				else
				{
					RadMessageBox.Show("This application cannot work without a ticket archive.");
					flag = false;
				}
			}
			if (flag)
			{
				this.method_25(@class.WiiU, @class.Byte_0, @class.Wii);
				return;
			}
			base.Close();
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00019091 File Offset: 0x00017291
		private void lstCopy_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
		{
			this.method_50(e.Item.Tag as GClass30);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00053A04 File Offset: 0x00051C04
		private void lstGames_ItemMouseUp(object sender, ListViewItemMouseEventArgs e)
		{
			if (e.OriginalEventArgs.Button != MouseButtons.Right)
			{
				return;
			}
			GClass32 gclass = e.Item.Tag as GClass32;
			if (gclass == null)
			{
				return;
			}
			if (this.lstGames.SelectedItems.Count < 2)
			{
				this.lstGames.SelectedItem = e.Item;
			}
			if (this.lstGames.SelectedItems.Count == 0)
			{
				return;
			}
			IEnumerable<GClass32> source = this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_33));
			if (source.All(new Func<GClass32, bool>(NusGrabberForm.<>c.<>c_0.method_34)))
			{
				this.radContextMenu_0.Items[7].Text = "Unpack (Loadiine)";
			}
			else if (source.All(new Func<GClass32, bool>(NusGrabberForm.<>c.<>c_0.method_35)))
			{
				this.radContextMenu_0.Items[7].Text = "Pack to CIA (3DS)";
			}
			else
			{
				this.radContextMenu_0.Items[7].Text = "Unpack Wii U titles and pack 3DS titles";
			}
			this.radContextMenu_0.Items[1].Enabled = (gclass.Boolean_3 && this.lstGames.SelectedItems.Count == 1);
			this.radContextMenu_0.Items[2].Enabled = (gclass.Boolean_2 && this.lstGames.SelectedItems.Count == 1);
			this.radContextMenu_0.Items[11].Enabled = !source.Any(new Func<GClass32, bool>(NusGrabberForm.<>c.<>c_0.method_36));
			this.radContextMenu_0.Show(e.OriginalEventArgs.X + base.Location.X + this.lstGames.Location.X, e.OriginalEventArgs.Y + base.Location.Y + this.lstGames.Location.Y + 150);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000190A9 File Offset: 0x000172A9
		private void lstGames_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.lstGames.SelectedItems.Clear();
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00053C58 File Offset: 0x00051E58
		private void lstGames_SelectedItemChanged(object sender, EventArgs e)
		{
			ListViewDataItem selectedItem = this.lstGames.SelectedItem;
			GClass32 gclass = ((selectedItem != null) ? selectedItem.Tag : null) as GClass32;
			if (gclass == null)
			{
				return;
			}
			this.SelectedGame = gclass;
			this.method_65();
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00053C94 File Offset: 0x00051E94
		private void lstGames_SizeChanged(object sender, EventArgs e)
		{
			this.lstGames.Columns[0].Width = (float)(this.lstGames.Width - 20) - (this.lstGames.Columns.Sum(new Func<ListViewDetailColumn, float>(NusGrabberForm.<>c.<>c_0.method_37)) - this.lstGames.Columns[0].Width);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00018DBC File Offset: 0x00016FBC
		private void method_32(object sender, ListViewItemEventArgs e)
		{
			if (!this.bool_0)
			{
				this.method_49();
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000190C5 File Offset: 0x000172C5
		private void method_33(GClass32 gclass32_2, bool bool_9, bool bool_10 = true)
		{
			gclass32_2.Boolean_5 = bool_9;
			if (bool_10)
			{
				this.method_63(false, true, null);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00053D10 File Offset: 0x00051F10
		private void NusGrabberForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.bool_2)
			{
				this.method_12();
			}
			try
			{
				Settings.Default.ShowCFW = this.chkShowRednand.Checked;
				Settings.Default.ShowLegit = this.chkShowLegit.Checked;
				Settings.Default.ShowEvents = this.chkShowPreviews.Checked;
				if (!this.bool_1)
				{
					Settings.Default.Boolean_0 = this.chkEUR.Checked;
					Settings.Default.Boolean_1 = this.chkJAP.Checked;
					Settings.Default.Boolean_2 = this.chkUSA.Checked;
					Settings.Default.Boolean_3 = this.chkKOR.Checked;
				}
				Settings.Default.Platforms = string.Join<int>(",", this.Platforms.Select(new Func<Platform, int>(NusGrabberForm.<>c.<>c_0.method_38)).ToArray<int>());
				Settings.Default.Save();
				this.method_53();
				GClass30.smethod_1();
			}
			catch
			{
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00053E34 File Offset: 0x00052034
		private void method_34(GClass82 gclass82_1)
		{
			try
			{
				NusGrabberForm.Class178 @class = new NusGrabberForm.Class178();
				@class.nusGrabberForm_0 = this;
				if (Class58.bool_0)
				{
					return;
				}
				@class.list_0 = GClass83.smethod_0(gclass82_1);
				base.Invoke(new MethodInvoker(@class.method_0));
				if (@class.list_0.Count == 0)
				{
					return;
				}
				@class.list_1 = new List<GClass33>();
				foreach (GClass32 gclass in @class.list_0.Where(new Func<GClass32, bool>(NusGrabberForm.<>c.<>c_0.method_39)))
				{
					if (GClass83.smethod_1(gclass82_1, gclass) < int.Parse(gclass.Updates.Last<GClass33>().Version))
					{
						@class.list_1.Add(gclass.Updates.Last<GClass33>());
					}
				}
				base.Invoke(new MethodInvoker(@class.method_1));
			}
			catch
			{
			}
			this.dateTime_0 = DateTime.Now;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00053F5C File Offset: 0x0005215C
		private void method_35()
		{
			this.cartesianChart_0 = new LiveCharts.WinForms.CartesianChart
			{
				Dock = DockStyle.Fill
			};
			Charting.For<GClass125>(Mappers.Xy<GClass125>().X(new Func<GClass125, double>(NusGrabberForm.<>c.<>c_0.method_42)).Y(new Func<GClass125, double>(NusGrabberForm.<>c.<>c_0.method_43)), SeriesOrientation.All);
			this.chartValues_0 = new ChartValues<GClass125>();
			this.cartesianChart_0.Series = new SeriesCollection
			{
				new LineSeries
				{
					Values = this.chartValues_0,
					PointGeometrySize = 1.0,
					StrokeThickness = 1.0,
					Title = "Download Speed (MB/s)",
					Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(75, 200, 113, 55))
					{
						Opacity = 50.0
					},
					Stroke = System.Windows.Media.Brushes.Orange
				}
			};
			NoisyCollection<Axis> axisX = this.cartesianChart_0.AxisX;
			Axis axis = new Axis();
			axis.DisableAnimations = true;
			axis.LabelFormatter = new Func<double, string>(NusGrabberForm.<>c.<>c_0.method_44);
			axis.Separator = new Separator
			{
				Step = (double)TimeSpan.FromSeconds(5.0).Ticks
			};
			axisX.Add(axis);
			this.cartesianChart_0.AxisY.Add(new Axis
			{
				DisableAnimations = true,
				MinValue = 0.0
			});
			this.method_36(DateTime.Now);
			this.radLiveSpeed.Controls.Add(this.cartesianChart_0);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00054114 File Offset: 0x00052314
		private void method_36(DateTime dateTime_2)
		{
			this.cartesianChart_0.AxisX[0].MaxValue = (double)dateTime_2.Ticks;
			this.cartesianChart_0.AxisX[0].MinValue = (double)(dateTime_2.Ticks - TimeSpan.FromSeconds(15.0).Ticks);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00054174 File Offset: 0x00052374
		private void method_37()
		{
			this.radContextMenu_0.Items[0].Click += this.method_73;
			this.radContextMenu_0.Items[1].Click += this.method_74;
			this.radContextMenu_0.Items[2].Click += this.method_75;
			this.radContextMenu_0.Items[3].Click += this.method_76;
			this.radContextMenu_0.Items[4].Click += this.method_77;
			this.radContextMenu_0.Items[5].Click += this.method_78;
			this.radContextMenu_0.Items[6].Click += this.method_79;
			this.radContextMenu_0.Items[7].Click += this.method_80;
			this.radContextMenu_0.Items[8].Click += this.method_81;
			this.radContextMenu_0.Items[9].Click += this.method_82;
			this.radContextMenu_0.Items[10].Click += this.method_83;
			this.radContextMenu_0.Items[11].Click += this.method_84;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0005431C File Offset: 0x0005251C
		private void method_38()
		{
			this.Platforms = new List<Platform>();
			if (string.IsNullOrEmpty(Settings.Default.Platforms))
			{
				this.Platforms.AddRange(Enum.GetValues(typeof(Platform)).Cast<Platform>());
			}
			else
			{
				try
				{
					this.Platforms.AddRange(Settings.Default.Platforms.Split(new char[]
					{
						','
					}).Select(new Func<string, Platform>(NusGrabberForm.<>c.<>c_0.method_58)));
				}
				catch
				{
					Settings.Default.Platforms = null;
				}
			}
			this.int_2 = this.Platforms.Count;
			this.treePlatforms.AutoCheckChildNodes = true;
			this.treePlatforms.TriStateMode = true;
			this.treePlatforms.Nodes.Add("Wii U");
			this.treePlatforms.Nodes["Wii U"].Nodes.Add("Native Titles");
			this.treePlatforms.Nodes["Wii U"].Nodes.Add("Virtual Console");
			this.treePlatforms.Nodes["Wii U"].Nodes.Add("Custom Titles");
			this.treePlatforms.Nodes.Add("3DS");
			this.treePlatforms.Nodes["3DS"].Nodes.Add("Native Titles");
			this.treePlatforms.Nodes["3DS"].Nodes.Add("Virtual Console");
			this.treePlatforms.Nodes.Add("Wii");
			this.treePlatforms.Nodes["Wii"].Nodes.Add("Native Titles");
			this.treePlatforms.Nodes["Wii"].Nodes.Add("Virtual Console");
			foreach (string text in Enum.GetNames(typeof(Platform)))
			{
				NusGrabberForm.Class179 @class = new NusGrabberForm.Class179();
				@class.nusGrabberForm_0 = this;
				Platform platform = (Platform)Enum.Parse(typeof(Platform), text);
				@class.radTreeNode_0 = new RadTreeNode(" " + text.Replace('_', ' '))
				{
					Image = GClass23.smethod_0(platform),
					Tag = platform,
					CheckType = CheckType.CheckBox,
					CheckState = (this.Platforms.Contains(platform) ? ToggleState.On : ToggleState.Off)
				};
				@class.radTreeNode_0.PropertyChanged += @class.method_0;
				if (GClass23.platform_3.Contains((Platform)@class.radTreeNode_0.Tag))
				{
					if (GClass23.platform_2.Contains((Platform)@class.radTreeNode_0.Tag))
					{
						this.treePlatforms.Nodes["Wii U"].Nodes["Custom Titles"].Nodes.Add(@class.radTreeNode_0);
					}
					else if (GClass23.platform_4.Contains((Platform)@class.radTreeNode_0.Tag))
					{
						this.treePlatforms.Nodes["Wii U"].Nodes["Virtual Console"].Nodes.Add(@class.radTreeNode_0);
					}
					else
					{
						this.treePlatforms.Nodes["Wii U"].Nodes["Native Titles"].Nodes.Add(@class.radTreeNode_0);
					}
				}
				else if (GClass23.platform_0.Contains((Platform)@class.radTreeNode_0.Tag))
				{
					if (GClass23.platform_1.Contains((Platform)@class.radTreeNode_0.Tag))
					{
						this.treePlatforms.Nodes["3DS"].Nodes["Virtual Console"].Nodes.Add(@class.radTreeNode_0);
					}
					else
					{
						this.treePlatforms.Nodes["3DS"].Nodes["Native Titles"].Nodes.Add(@class.radTreeNode_0);
					}
				}
				else if (GClass23.platform_5.Contains((Platform)@class.radTreeNode_0.Tag))
				{
					if (GClass23.platform_6.Contains((Platform)@class.radTreeNode_0.Tag))
					{
						this.treePlatforms.Nodes["Wii"].Nodes["Virtual Console"].Nodes.Add(@class.radTreeNode_0);
					}
					else
					{
						this.treePlatforms.Nodes["Wii"].Nodes["Native Titles"].Nodes.Add(@class.radTreeNode_0);
					}
				}
			}
			this.treePlatforms.ExpandAll();
			this.treePlatforms.Nodes["3DS"].Nodes["Native Titles"].Image = GClass23.smethod_0(Platform.Nintendo_3DS);
			this.treePlatforms.Nodes["3DS"].Image = Class121.logo3ds;
			this.treePlatforms.Nodes["3DS"].Text = "";
			this.treePlatforms.Nodes["3DS"].Nodes["Native Titles"].Collapse();
			this.treePlatforms.Nodes["Wii U"].Nodes["Native Titles"].Collapse();
			this.treePlatforms.Nodes["Wii U"].Nodes["Native Titles"].Image = GClass23.smethod_0(Platform.Wii_U_Disc);
			this.treePlatforms.Nodes["Wii U"].Image = Class121.logoWiiU;
			this.treePlatforms.Nodes["Wii U"].Text = "";
			this.treePlatforms.Nodes["Wii"].Text = "";
			this.treePlatforms.Nodes["Wii"].Image = Class121.logoWii;
			this.treePlatforms.Nodes["Wii"].Nodes["Native Titles"].Collapse();
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x000549F0 File Offset: 0x00052BF0
		private void NusGrabberForm_Load(object sender, EventArgs e)
		{
			this.dateTime_1 = DateTime.Now;
			Class89.Event_0 += this.method_85;
			if (Settings.Default.ShowSpeedGraph)
			{
				this.method_35();
			}
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(Class121.genres);
				foreach (object obj in xmlDocument.GetElementsByTagName("genre"))
				{
					XmlNode xmlNode = (XmlNode)obj;
					this.chkGameGenres.Items.Add(new ListViewDataItem
					{
						Text = xmlNode.FirstChild.InnerText,
						Tag = uint.Parse(xmlNode.Attributes["id"].InnerText)
					});
				}
			}
			catch
			{
			}
			this.radDate.Value = DateTime.Now;
			this.radDate.MinDate = DateTime.Now;
			this.radDate.Format = DateTimePickerFormat.Custom;
			this.radDate.CustomFormat = "MM/dd/yyyy HH:mm";
			this.Text = this.Text + " - Current region : " + Settings.Default.Region;
			this.method_38();
			RadMessageBox.ShowInTaskbar = true;
			if (ApplicationDeployment.IsNetworkDeployed)
			{
				Version currentVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
				this.Text = this.Text + " Ver:" + currentVersion;
			}
			else if (Class100.string_0 != null)
			{
				this.Text = this.Text + " Ver:" + Class100.string_0;
			}
			if (!GClass6.smethod_2(Settings.Default.Path) && !Class95.smethod_13(true))
			{
				base.Close();
				return;
			}
			this.txtDesc.BackColor = this.BackColor;
			this.toolGameDesc.Select();
			this.method_37();
			Font font = new Font(this.Font, FontStyle.Bold);
			this.listViewDataItemGroup_4.Font = font;
			this.listViewDataItemGroup_2.Font = font;
			this.listViewDataItemGroup_0.Font = font;
			this.listViewDataItemGroup_1.Font = font;
			this.listViewDataItemGroup_3.Font = font;
			this.lstGames.Groups.Add(this.listViewDataItemGroup_4);
			this.lstGames.Groups.Add(this.listViewDataItemGroup_2);
			this.lstGames.Groups.Add(this.listViewDataItemGroup_0);
			this.lstGames.Groups.Add(this.listViewDataItemGroup_1);
			this.lstGames.Groups.Add(this.listViewDataItemGroup_3);
			this.method_31(this, null);
			new GClass127().method_0();
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00054CA4 File Offset: 0x00052EA4
		private void method_39(object object_0, GClass84 gclass84_0)
		{
			NusGrabberForm.Class181 @class = new NusGrabberForm.Class181();
			@class.nusGrabberForm_0 = this;
			@class.gclass84_0 = gclass84_0;
			try
			{
				base.Invoke(new Action(@class.method_0));
				(object_0 as GClass86).Event_2 -= this.method_39;
			}
			catch
			{
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00054D04 File Offset: 0x00052F04
		private void method_40(object object_0, object object_1)
		{
			try
			{
				base.Invoke(new Action(this.method_86));
				(object_0 as GClass86).Event_0 -= new EventHandler(this.method_40);
			}
			catch
			{
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00054D50 File Offset: 0x00052F50
		private void method_41(object object_0, GClass84 gclass84_0)
		{
			NusGrabberForm.Class182 @class = new NusGrabberForm.Class182();
			@class.nusGrabberForm_0 = this;
			@class.gclass84_0 = gclass84_0;
			try
			{
				base.Invoke(new Action(@class.method_0));
				(object_0 as GClass86).Event_2 -= this.method_41;
			}
			catch
			{
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00054DB0 File Offset: 0x00052FB0
		private void pbCover_DoubleClick(object sender, EventArgs e)
		{
			if (this.SelectedGame == null)
			{
				return;
			}
			DialogResult dialogResult = RadMessageBox.Show("Would you like to specify a custom cover for this game? Choose cancel to download the default cover.", "Custom cover", MessageBoxButtons.YesNoCancel);
			Image image;
			if (dialogResult != DialogResult.Cancel)
			{
				if (dialogResult != DialogResult.Yes)
				{
					return;
				}
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					CheckFileExists = true,
					Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
				};
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				image = Image.FromStream(new MemoryStream(File.ReadAllBytes(openFileDialog.FileName)));
				this.pbCover.Image = image;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					image.Save(memoryStream, ImageFormat.Png);
					GClass88.smethod_9(new Uri(this.SelectedGame.String_7), memoryStream.ToArray());
					return;
				}
			}
			byte[] array = GClass85.smethod_0(this.SelectedGame.String_7, TimeSpan.Zero);
			if (array == null)
			{
				return;
			}
			image = Image.FromStream(new MemoryStream(array));
			this.pbCover.Image = image;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00054EAC File Offset: 0x000530AC
		private void method_42(GClass32 gclass32_2)
		{
			if (!gclass32_2.Boolean_1)
			{
				if (gclass32_2.GEnum2_0 == GEnum2.const_2)
				{
					this.method_30();
					this.method_63(false, true, new GClass32[]
					{
						gclass32_2
					}.ToList<GClass32>());
					return;
				}
				GClass95 gclass = gclass32_2.method_14(true);
				if (gclass == null)
				{
					RadMessageBox.Show("This title does not support emulation for the moment.");
					return;
				}
				if (!this.CurrentlyDownloading && gclass32_2.System == GEnum3.const_1 && gclass32_2.Size.TotalBytes < 150000000UL)
				{
					RadMessageBox.Show("USB Helper will now download and prepare your game.");
					gclass.Play();
					this.method_63(false, true, new GClass32[]
					{
						gclass32_2
					}.ToList<GClass32>());
					return;
				}
				RadMessageBox.Show("You do not have downloaded this game. Wii U USB Helper will now add it to the queue. Please try again when the download is complete.");
				this.method_0(gclass32_2);
				this.chkPrepareEmulation.Checked = true;
				if (!this.CurrentlyDownloading)
				{
					this.method_44();
					return;
				}
			}
			else
			{
				this.method_30();
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00054F88 File Offset: 0x00053188
		private void method_43()
		{
			NusGrabberForm.Class183 @class = new NusGrabberForm.Class183();
			@class.nusGrabberForm_0 = this;
			this.bool_7 = false;
			@class.int_0 = 0;
			ListViewDataItem[] array = this.lstGames.Items.ToArray<ListViewDataItem>();
			for (int i = 0; i < array.Length; i++)
			{
				NusGrabberForm.Class184 class2 = new NusGrabberForm.Class184();
				class2.class183_0 = @class;
				class2.listViewDataItem_0 = array[i];
				try
				{
					NusGrabberForm.Class185 class3 = new NusGrabberForm.Class185();
					class3.class184_0 = class2;
					class3.gclass32_0 = (class3.class184_0.listViewDataItem_0.Tag as GClass32);
					if (class3.gclass32_0 == null)
					{
						break;
					}
					if (class3.gclass32_0.Platform == Platform.Nintendo_DSiWare)
					{
						class3.gclass32_0.gclass86_2.Image = Class121.dsiwareicon;
						Class95.smethod_1(class3.gclass32_0, 8, this.lstGames.ListViewElement.BackColor);
						base.Invoke(new Action(class3.method_0));
					}
					else
					{
						while (class3.class184_0.class183_0.int_0 > 10)
						{
							Thread.Sleep(1);
						}
						int num = class3.class184_0.class183_0.int_0;
						class3.class184_0.class183_0.int_0 = num + 1;
						Task.Run(new Action(class3.method_1));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x000550EC File Offset: 0x000532EC
		private void method_44()
		{
			this.method_54(false);
			this.CurrentlyDownloading = true;
			this.lstLog.Items.Clear();
			this.method_18();
			this.dockMain.ActiveWindow = this.toolDownload;
			if (this.chkDelay.Checked && this.radDate.Value.CompareTo(DateTime.Now) > 0)
			{
				this.DownloadButton.Enabled = false;
				this.timer_4.Start();
				return;
			}
			this.method_58();
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00055174 File Offset: 0x00053374
		private void method_45(IEnumerable<GClass32> ienumerable_0, bool bool_9)
		{
			foreach (GClass32 gclass in ienumerable_0)
			{
				gclass.method_22();
				if (this.SelectedGame == gclass && gclass.Boolean_1)
				{
					this.cmdShortcut.Enabled = true;
				}
				if (gclass.Boolean_1 && bool_9)
				{
					gclass.method_11();
				}
			}
			this.method_63(false, true, ienumerable_0.ToList<GClass32>());
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000551F8 File Offset: 0x000533F8
		private void method_46(object sender, GEventArgs0 e)
		{
			NusGrabberForm.Class186 @class = new NusGrabberForm.Class186();
			@class.nusGrabberForm_0 = this;
			@class.geventArgs0_0 = e;
			try
			{
				base.BeginInvoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00055244 File Offset: 0x00053444
		private void method_47()
		{
			Class65.smethod_4();
			Cemu cemu = new Cemu(null, false);
			if (!cemu.Boolean_0 && !cemu.EmuConfiguration_0.AutoUpdate)
			{
				RadMessageBox.Show(string.Format("CEMU is not installed. Please install it in {0} or enable automatic updates", cemu.String_4));
				return;
			}
			Citra citra = new Citra(null, false);
			if (!citra.Boolean_0 && !citra.EmuConfiguration_0.AutoUpdate)
			{
				RadMessageBox.Show(string.Format("Citra is not installed. Please install it in {0} or enable automatic updates", citra.String_4));
				return;
			}
			if (this.gclass130_0 == null)
			{
				Thread thread = new Thread(new ThreadStart(this.method_87));
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				return;
			}
			this.gclass130_0.method_1();
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000190DA File Offset: 0x000172DA
		private void radButton2_Click(object sender, EventArgs e)
		{
			this.method_47();
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000190E2 File Offset: 0x000172E2
		private void method_48(object sender, EventArgs e)
		{
			if (GClass9.smethod_0())
			{
				return;
			}
			new frmSupport().ShowDialog();
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000552F0 File Offset: 0x000534F0
		private void cmdBackupSave_Click(object sender, EventArgs e)
		{
			NusGrabberForm.Class187 @class = new NusGrabberForm.Class187();
			if (this.gclass82_0 == null)
			{
				Class95.smethod_16(this);
				return;
			}
			frmCreateSave frmCreateSave = new frmCreateSave();
			if (frmCreateSave.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			@class.frmWait_0 = new FrmWait("Please wait while USB Helper downloads your save.", false);
			try
			{
				Task.Run<DialogResult>(new Func<DialogResult>(@class.method_0));
				this.SelectedGame.method_25(this.gclass82_0, frmCreateSave.string_0);
			}
			catch (GException0)
			{
				@class.frmWait_0.method_0();
				Class95.smethod_15(this, "No save was found for this game on your Wii U.");
				return;
			}
			catch (Exception ex)
			{
				@class.frmWait_0.method_0();
				Class95.smethod_15(this, ex.Message);
				return;
			}
			@class.frmWait_0.method_0();
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000190F7 File Offset: 0x000172F7
		private void radMaxSpeed_ValueChanged(object sender, EventArgs e)
		{
			GClass80 gclass = this.gclass80_0;
			if (gclass == null)
			{
				return;
			}
			gclass.method_4((ulong)this.radMaxSpeed.Value * 1000UL);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000553BC File Offset: 0x000535BC
		private void method_49()
		{
			this.lstGames.Visible = false;
			this.lstGames.smethod_1(true);
			this.method_21();
			this.listViewDataItemGroup_0.Text = string.Format("Downloaded ({0})", this.listViewDataItemGroup_0.Items.Count);
			this.listViewDataItemGroup_4.Text = string.Format("Ready for emulation ({0})", this.listViewDataItemGroup_4.Items.Count);
			this.listViewDataItemGroup_2.Text = string.Format("Installed on your WiiU/3DS ({0})", this.listViewDataItemGroup_2.Items.Count);
			this.listViewDataItemGroup_1.Text = string.Format("Partially downloaded ({0})", this.listViewDataItemGroup_1.Items.Count);
			this.listViewDataItemGroup_3.Text = string.Format("Not downloaded ({0})", this.listViewDataItemGroup_3.Items.Count);
			this.lblNbGms.Text = string.Format("{0} game(s) available (Missing Games? Check your filters and these checkboxes ->)", this.lstGames.Items.Count);
			this.lstGames.Visible = true;
			this.lstGames.smethod_1(false);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000554FC File Offset: 0x000536FC
		private void method_50(GClass30 gclass30_0)
		{
			NusGrabberForm.Class188 @class = new NusGrabberForm.Class188();
			@class.gclass30_0 = gclass30_0;
			this.TitlesToCopy.Remove(@class.gclass30_0);
			this.lstCopy.Items.Remove(this.lstCopy.Items.First(new Func<ListViewDataItem, bool>(@class.method_0)));
			this.method_16();
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0005555C File Offset: 0x0005375C
		private void method_51()
		{
			this.bool_7 = true;
			Thread.Sleep(1800);
			try
			{
				NusGrabberForm.Class189 @class = new NusGrabberForm.Class189();
				@class.byte_0 = null;
				@class.byte_1 = null;
				byte[] byte_ = null;
				new FrmWait("USB Helper is fetching the title keys...", new Action(@class.method_0), new Action<Exception>(NusGrabberForm.<>c.<>c_0.method_59));
				this.method_25(@class.byte_0, @class.byte_1, byte_);
			}
			catch
			{
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000555F0 File Offset: 0x000537F0
		private void method_52()
		{
			string[] array = GClass88.smethod_7("dl");
			if (array == null)
			{
				return;
			}
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				TitleId titleId = new TitleId(array2[i]);
				if (GClass28.dictionary_0.ContainsKey(new TitleId(titleId.FullGame)))
				{
					GClass32 gclass = GClass28.dictionary_0[new TitleId(titleId.FullGame)];
					switch (titleId.IdType)
					{
					case GEnum1.const_1:
						if (gclass.GEnum2_0 != GEnum2.const_2)
						{
							this.method_6(gclass);
						}
						break;
					case GEnum1.const_2:
						if (gclass.Boolean_2 && gclass.Dlc.GEnum2_0 != GEnum2.const_2)
						{
							this.method_6(gclass.Dlc);
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00019120 File Offset: 0x00017320
		private void method_53()
		{
			GClass88.smethod_10("dl", this.dlQueue.Items.Select(new Func<ListViewDataItem, string>(NusGrabberForm.<>c.<>c_0.method_60)).ToArray<string>());
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x000556BC File Offset: 0x000538BC
		private void method_54(bool bool_9)
		{
			this.cmdAddAllGames.Enabled = bool_9;
			this.cmdAddAllDLCS.Enabled = bool_9;
			this.cmdSetExtractFolder.Enabled = bool_9;
			this.cmdAddAllUpdates.Enabled = bool_9;
			this.cmdRefresh.Enabled = (this.bool_5 || this.bool_4 || this.bool_6);
			this.cmdClearDl.Enabled = bool_9;
			this.cmdChangeFolder.Enabled = bool_9;
			this.cmdChangeRegion.Enabled = bool_9;
			this.cmdChangeTicket.Enabled = bool_9;
			this.cmdImportGames.Enabled = bool_9;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0005575C File Offset: 0x0005395C
		private void method_55(GClass32 gclass32_2)
		{
			GClass29 gclass = gclass32_2.method_31();
			if (gclass == null)
			{
				return;
			}
			if (gclass.bool_1)
			{
				this.method_2(gclass32_2);
			}
			if (gclass.bool_2)
			{
				foreach (GClass33 gclass30_ in gclass.list_0)
				{
					this.method_2(gclass30_);
				}
			}
			if (gclass.bool_0)
			{
				this.method_2(gclass32_2.Dlc);
			}
			this.dockMain.ActiveWindow = this.toolCopy;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000557F8 File Offset: 0x000539F8
		private void method_56(GClass32 gclass32_2)
		{
			FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(gclass32_2, WhatToAction.Delete);
			if (frmWhatToCopy.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			if (frmWhatToCopy.CopyDlc)
			{
				gclass32_2.Dlc.method_11();
			}
			if (frmWhatToCopy.CopyGame)
			{
				gclass32_2.method_11();
			}
			if (frmWhatToCopy.CopyUpdate)
			{
				foreach (GClass33 gclass in frmWhatToCopy.list_0)
				{
					gclass.method_11();
				}
			}
			this.method_63(true, true, new List<GClass32>(new GClass32[]
			{
				gclass32_2
			}));
			this.method_65();
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000558A4 File Offset: 0x00053AA4
		private bool method_57(ListViewDataItem listViewDataItem_0)
		{
			NusGrabberForm.Class190 @class = new NusGrabberForm.Class190();
			GClass32 gclass = listViewDataItem_0.Tag as GClass32;
			if (gclass == null)
			{
				return true;
			}
			@class.string_0 = gclass.Name.Trim().ToLower().Split(new char[]
			{
				' '
			});
			return (!gclass.CfwOnly || this.chkShowRednand.Checked) && (gclass.CfwOnly || this.chkShowLegit.Checked) && (!gclass.Name.Contains("Event Preview") || this.chkShowPreviews.Checked) && (this.chkEUR.Checked || !(gclass.Region == "EUR")) && (this.chkUSA.Checked || !(gclass.Region == "USA")) && (this.chkKOR.Checked || !(gclass.Region == "KOR")) && (this.chkJAP.Checked || !(gclass.Region == "JPN")) && this.Platforms.Contains(gclass.Platform) && (this.list_0 == null || this.list_0.Contains(gclass.EshopId)) && this.FTSearchBox.Text.Trim().ToLower().Split(new char[]
			{
				' '
			}).All(new Func<string, bool>(@class.method_0));
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00055A2C File Offset: 0x00053C2C
		private void method_58()
		{
			try
			{
				TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
			}
			catch
			{
			}
			this.method_29(this.TitlesToDownload);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00019160 File Offset: 0x00017360
		private void method_59()
		{
			this.CurrentlyDownloading = false;
			this.lblTimeLeft.Text = "-";
			this.timer_4.Enabled = false;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00055A68 File Offset: 0x00053C68
		private void method_60(object object_0, string string_4)
		{
			NusGrabberForm.Class192 @class = new NusGrabberForm.Class192();
			@class.nusGrabberForm_0 = this;
			@class.string_0 = string_4;
			try
			{
				base.Invoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00055AB4 File Offset: 0x00053CB4
		private void timer_4_Tick(object sender, EventArgs e)
		{
			this.radDate.Value.CompareTo(DateTime.Now);
			if (this.radDate.Value.CompareTo(DateTime.Now) > 0)
			{
				this.lblTimeLeft.Text = string.Format("{0} left", (this.radDate.Value - DateTime.Now).ToString("hh\\:mm\\:ss"));
				return;
			}
			this.method_59();
			this.method_58();
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00055B3C File Offset: 0x00053D3C
		private void timer_3_Tick(object sender, EventArgs e)
		{
			try
			{
				GClass30.smethod_1();
			}
			catch
			{
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00019185 File Offset: 0x00017385
		private void method_61()
		{
			this.lblproxyStatus.Text = "Not set";
			this.lblproxyStatus.ForeColor = System.Drawing.Color.Red;
			this.Proxy = null;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00055B64 File Offset: 0x00053D64
		private void method_62()
		{
			if (Class106.bool_0)
			{
				this.lblDonatorStatus.ForeColor = System.Drawing.Color.Orange;
				this.lblDonatorEmail.Text = "-";
				this.lblDonatorDate.Text = "-";
				this.lblDonatorStatus.Text = "The miner is updating...";
				return;
			}
			if (GClass89.Boolean_0)
			{
				this.lblDonatorStatus.ForeColor = System.Drawing.Color.Green;
				this.lblDonatorStatus.Text = "Thank you for your donation!";
				this.lblDonatorEmail.Text = GClass89.GClass8_0.Email;
				this.lblDonatorDate.Text = GClass89.GClass8_0.DonationDate;
				return;
			}
			this.lblDonatorStatus.ForeColor = System.Drawing.Color.Red;
			this.lblDonatorStatus.Text = "You are not a donor yet.";
			this.lblDonatorEmail.Text = "-";
			this.lblDonatorDate.Text = "-";
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00055C4C File Offset: 0x00053E4C
		private void method_63(bool bool_9 = false, bool bool_10 = true, List<GClass32> list_5 = null)
		{
			this.lstGames.BeginUpdate();
			foreach (ListViewDataItem listViewDataItem in this.lstGames.Items)
			{
				GClass32 gclass = listViewDataItem.Tag as GClass32;
				if (list_5 == null || list_5.Contains(gclass))
				{
					if (bool_10)
					{
						gclass.method_6();
						if (gclass.Boolean_3)
						{
							foreach (GClass33 gclass2 in gclass.Updates)
							{
								gclass2.method_6();
							}
						}
						if (gclass.Boolean_2)
						{
							gclass.Dlc.method_6();
						}
						listViewDataItem.Group = this.method_11(gclass);
						listViewDataItem[3] = gclass.Int32_0 + "%";
						listViewDataItem[4] = (gclass.Boolean_3 ? ((gclass.Updates.Last<GClass33>().GEnum2_0 == GEnum2.const_2) ? "Ready" : "Yes") : "No");
						listViewDataItem[5] = (gclass.Boolean_2 ? ((gclass.Dlc.GEnum2_0 == GEnum2.const_2) ? "Ready" : "Yes") : "No");
						if (bool_9)
						{
							Class95.smethod_1(gclass, 8, this.lstGames.ListViewElement.BackColor);
							listViewDataItem.Image = gclass.gclass86_2.Image;
						}
					}
					listViewDataItem.ForeColor = Class95.smethod_0(gclass);
				}
			}
			this.method_49();
			this.method_15();
			this.lstGames.EndUpdate();
			this.method_65();
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00055E28 File Offset: 0x00054028
		private void method_64(string string_4)
		{
			if (string_4 == null)
			{
				return;
			}
			Class89.smethod_3(string_4, this.string_3);
			this.lstChat.Items.Clear();
			this.lstChat.Items.Add(string.Format("--NOW JOINING: {0}--", string_4));
			this.lstChat.Items.Add("--Remember to stay polite!--");
			this.lstChat.Items.Add("--This feature is experimental!--");
			this.lblChannelClientCount.Text = "Loading...";
			this.string_3 = string_4;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00055EB4 File Offset: 0x000540B4
		private void method_65()
		{
			if (this.SelectedGame == null)
			{
				return;
			}
			if (Settings.Default.GameSpecificRoom)
			{
				this.method_64(this.SelectedGame.Name);
			}
			this.lblModsOnlyCemu.Visible = !(this.SelectedGame.method_14(false) is Cemu);
			this.modPreview.Items.Clear();
			this.txtModDescription.Text = "";
			this.lstMods.Items.Clear();
			this.txtModSearch.Text = "";
			try
			{
				this.gclass15_0 = new GClass15(this.SelectedGame);
				IEnumerable<GClass14> source = this.gclass15_0.method_1();
				this.lstMods.BeginUpdate();
				foreach (GClass14 gclass in source.OrderByDescending(new Func<GClass14, long>(NusGrabberForm.<>c.<>c_0.method_61)))
				{
					ListViewDataItem listViewDataItem = new ListViewDataItem(gclass.Name)
					{
						Tag = gclass
					};
					listViewDataItem.CheckState = (this.gclass15_0.method_3(gclass.Name) ? ToggleState.On : ToggleState.Off);
					this.lstMods.Items.Add(listViewDataItem);
				}
				this.lstMods.EndUpdate();
				if (this.lstMods.Items.Count > 0)
				{
					this.lstMods.SelectedIndex = 0;
				}
			}
			catch
			{
			}
			this.PreviouslySelectedGame = this.SelectedGame;
			this.txtDesc.smethod_1(true);
			this.panelGameCover.smethod_1(true);
			this.bitmap_0 = null;
			this.pbPreview1.Image = null;
			this.pbPreview2.Image = null;
			this.pbPreview3.Image = null;
			this.cmdShortcut.Enabled = this.SelectedGame.Boolean_1;
			this.lblGameSize.Text = this.SelectedGame.Size.ToString();
			this.lblStatusGameRaw.ForeColor = this.SelectedGame.Color_0;
			this.lblStatusGameRaw.LabelElement.ToolTipText = this.SelectedGame.String_3;
			this.lblStatusGameEmu.ForeColor = this.SelectedGame.Color_1;
			this.lblStatusGameEmu.LabelElement.ToolTipText = this.SelectedGame.String_4;
			this.lblTitleId.Text = this.SelectedGame.TitleId.ToSplitString();
			this.cmdRestoreSave.Enabled = (this.SelectedGame.System == GEnum3.const_1);
			this.cmdBackupSave.Enabled = (this.SelectedGame.System == GEnum3.const_1);
			this.cmdImportCemu.Enabled = (this.SelectedGame.System == GEnum3.const_1);
			this.cmdCommunitySaves.Enabled = (this.SelectedGame.method_14(false) != null && this.SelectedGame.method_14(false).FileSaveLocation != null);
			try
			{
				this.webBrowser.Url = new Uri(string.Format("https://www.yandex.com/search/?text={0}", HttpUtility.UrlEncode(this.SelectedGame.Name + " Wii U".Replace("&", "and"))), UriKind.Absolute);
			}
			catch
			{
			}
			this.cmdAddGame.Text = ((this.SelectedGame.GEnum2_0 != GEnum2.const_2 || this.SelectedGame.Boolean_0) ? "&Add" : "&Verify");
			if (this.SelectedGame.Boolean_3)
			{
				this.lblUpdateSize.Text = this.SelectedGame.Updates.Last<GClass33>().Size.ToString();
				this.lblStatusUpdateEmu.LabelElement.ToolTipText = this.SelectedGame.Updates.Last<GClass33>().String_4;
				this.lblStatusUpdateEmu.ForeColor = this.SelectedGame.Updates.Last<GClass33>().Color_1;
				this.lblStatusUpdateRaw.ForeColor = this.SelectedGame.Updates.Last<GClass33>().Color_0;
				this.lblStatusUpdateRaw.LabelElement.ToolTipText = this.SelectedGame.Updates.Last<GClass33>().String_3;
				Control control = this.lblEmuUpdateVersion;
				string str = "v.";
				GClass95 gclass2 = this.SelectedGame.method_14(false);
				control.Text = str + ((gclass2 != null) ? gclass2.GetUpdateVersion().ToString() : null);
				this.cmdAddUpdate.Enabled = true;
				this.cmdAddUpdate.Text = "Add &update";
			}
			else
			{
				this.lblStatusUpdateRaw.ForeColor = System.Drawing.Color.Gray;
				this.lblStatusUpdateEmu.ForeColor = System.Drawing.Color.Gray;
				this.lblEmuUpdateVersion.Text = "-";
				this.lblUpdateSize.Text = "-";
				this.cmdAddUpdate.Text = "No update available";
				this.lblStatusUpdateRaw.LabelElement.ToolTipText = "No update available";
				this.lblStatusUpdateEmu.LabelElement.ToolTipText = "No update available";
				this.cmdAddUpdate.Enabled = false;
			}
			if (this.SelectedGame.Boolean_2)
			{
				this.lblDLCSize.Text = this.SelectedGame.Dlc.Size.ToString();
				this.lblStatusDLCRaw.ForeColor = this.SelectedGame.Dlc.Color_0;
				this.lblStatusDLCRaw.LabelElement.ToolTipText = this.SelectedGame.Dlc.String_3;
				this.lblStatusDLCEmu.ForeColor = this.SelectedGame.Color_1;
				this.lblStatusDLCEmu.LabelElement.ToolTipText = this.SelectedGame.String_4;
				this.cmdAddDlc.Enabled = !this.dlQueue.smethod_0(this.SelectedGame.Dlc);
				this.cmdAddDlc.Text = "Add &DLC";
			}
			else
			{
				this.lblStatusDLCRaw.ForeColor = System.Drawing.Color.Gray;
				this.lblStatusDLCRaw.LabelElement.ToolTipText = "No DLC available";
				this.lblStatusDLCEmu.ForeColor = System.Drawing.Color.Gray;
				this.lblStatusDLCEmu.LabelElement.ToolTipText = "No DLC available";
				this.lblDLCSize.Text = "-";
				this.cmdAddDlc.Text = "No DLC available";
				this.cmdAddDlc.Enabled = false;
			}
			this.cmdPlay.Enabled = true;
			this.cmdAddGame.Enabled = (!this.dlQueue.smethod_0(this.SelectedGame) && !this.SelectedGame.DiscOnly);
			this.lblTitle.Text = this.SelectedGame.Name;
			if (this.SelectedGame.CfwOnly)
			{
				this.lblTitle.Text = this.lblTitle.Text + " (CFW ONLY)";
			}
			if (this.SelectedGame.DiscOnly)
			{
				this.lblTitle.Text = this.lblTitle.Text + " (ONLY UPDATES AND DLC) ";
			}
			this.cmdCopy.Enabled = (this.SelectedGame.GEnum2_0 == GEnum2.const_2 || this.SelectedGame.Boolean_3 || (this.SelectedGame.Boolean_2 && this.SelectedGame.Dlc.GEnum2_0 == GEnum2.const_2));
			this.cmdDelete.Enabled = (this.SelectedGame.GEnum2_0 != GEnum2.const_0 || this.SelectedGame.Boolean_1 || this.SelectedGame.Boolean_3 || (this.SelectedGame.Boolean_2 && this.SelectedGame.Dlc.GEnum2_0 > GEnum2.const_0));
			this.txtDesc.Text = "";
			this.pbBanner.Image = Class121.banner;
			switch (this.SelectedGame.System)
			{
			case GEnum3.const_0:
				this.pictureLogo.Image = Class121.logo3ds;
				goto IL_830;
			case GEnum3.const_1:
				this.pictureLogo.Image = Class121.logoWiiU;
				goto IL_830;
			case GEnum3.const_3:
				this.pictureLogo.Image = Class121.logoWii;
				goto IL_830;
			}
			this.pictureLogo.Image = null;
			IL_830:
			this.SelectedGame.method_28(new Action<GClass74, GClass32>(this.method_22));
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00056730 File Offset: 0x00054930
		private void method_66(ulong ulong_2)
		{
			NusGrabberForm.Class193 @class = new NusGrabberForm.Class193();
			@class.nusGrabberForm_0 = this;
			@class.ulong_0 = ulong_2;
			base.Invoke(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000191AE File Offset: 0x000173AE
		private void chkSuperSpeed_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			GClass28.bool_2 = this.chkSuperSpeed.Checked;
			Settings.Default.EnableSuperSpeed = this.chkSuperSpeed.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00056764 File Offset: 0x00054964
		private void pbCover_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			if (this.bitmap_0 == null)
			{
				graphics.Clear(this.BackColor);
				return;
			}
			this.panelGameCover.smethod_1(false);
			float num = (float)(this.pbCover.Width / 2);
			float num2 = (float)(this.pbCover.Height / 2);
			float num3 = 1f + this.float_0 / 100f;
			graphics.ScaleTransform(num3, num3);
			graphics.DrawImage(this.bitmap_0, new PointF(num - (float)this.bitmap_0.Width * num3 / 2f, num2 - (float)this.bitmap_0.Height * num3 / 2f));
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00056810 File Offset: 0x00054A10
		private void lstMovies_ItemMouseDoubleClick(object sender, ListViewItemEventArgs e)
		{
			GClass56 gclass = e.Item.Tag as GClass56;
			try
			{
				new frmVideo(Class65.smethod_1(gclass.Files.File.First(new Func<GClass46, bool>(NusGrabberForm.<>c.<>c_0.method_62)).MovieUrl, 315360000)).ShowDialog();
			}
			catch
			{
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000191DF File Offset: 0x000173DF
		private void chkForceGameMode_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.ForceGameMode = this.chkForceGameMode.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00019200 File Offset: 0x00017400
		private void radButton4_Click(object sender, EventArgs e)
		{
			frmEmuSettings frmEmuSettings = new frmEmuSettings();
			frmEmuSettings.ShowDialog();
			if (frmEmuSettings.PathWasChanged)
			{
				this.method_63(false, true, null);
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0005688C File Offset: 0x00054A8C
		private void timer_5_Tick(object sender, EventArgs e)
		{
			if ((DateTime.Now - this.dateTime_1).TotalDays >= 3.0)
			{
				Class95.smethod_5("Restart the application", "USB HELPER has not been restarted in a while. It is recommended that you restart it regularly to get the latest content.", -1, true, null);
				this.dateTime_1 = DateTime.Now;
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x000568DC File Offset: 0x00054ADC
		private void radButton5_Click(object sender, EventArgs e)
		{
			frmAdvancedDiskManagement frmAdvancedDiskManagement = new frmAdvancedDiskManagement();
			frmAdvancedDiskManagement.ShowDialog();
			this.method_63(true, true, frmAdvancedDiskManagement.DeletedTitles);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0001921E File Offset: 0x0001741E
		private void radButton7_Click(object sender, EventArgs e)
		{
			new frmCloudSaving().ShowDialog();
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0001922B File Offset: 0x0001742B
		private void cmdImportCemu_Click(object sender, EventArgs e)
		{
			Class95.smethod_7(this.SelectedGame, this.gclass82_0, this);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00056904 File Offset: 0x00054B04
		private void txtChat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != Convert.ToChar(Keys.Return))
			{
				return;
			}
			if (this.string_3 != null)
			{
				Class89.smethod_6(Class89.smethod_2(), this.string_3, this.txtChat.Text.Trim());
			}
			this.txtChat.Text = "";
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00056960 File Offset: 0x00054B60
		private void lstMods_SelectedItemChanged(object sender, EventArgs e)
		{
			NusGrabberForm.Class194 @class = new NusGrabberForm.Class194();
			@class.nusGrabberForm_0 = this;
			if (this.lstMods.SelectedItem == null)
			{
				return;
			}
			@class.gclass14_0 = (this.lstMods.SelectedItem.Tag as GClass14);
			this.txtModDescription.Text = string.Concat(new string[]
			{
				@class.gclass14_0.Description,
				Environment.NewLine,
				Environment.NewLine,
				string.Format("Creator: {0}", @class.gclass14_0.Creator),
				Environment.NewLine,
				string.Format("Original link: {0}", @class.gclass14_0.OriginalLink)
			});
			this.modPreview.Items.Clear();
			this.modPreview.Items.Clear();
			this.ulong_1 += 1UL;
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00056A50 File Offset: 0x00054C50
		private void lstMods_ItemCheckedChanging(object sender, ListViewItemCancelEventArgs e)
		{
			GClass14 gclass = e.Item.Tag as GClass14;
			if (e.Item.CheckState == ToggleState.Off)
			{
				this.lstMods.BeginUpdate();
				List<string> list = this.gclass15_0.method_0(gclass.Name);
				if (!list.Contains(gclass.Name))
				{
					e.Cancel = true;
				}
				using (List<string>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						NusGrabberForm.Class197 @class = new NusGrabberForm.Class197();
						@class.string_0 = enumerator.Current;
						try
						{
							this.lstMods.Items.First(new Func<ListViewDataItem, bool>(@class.method_0)).CheckState = ToggleState.On;
						}
						catch
						{
						}
					}
				}
				this.lstMods.EndUpdate();
				return;
			}
			if (!this.gclass15_0.method_5(gclass.Name))
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0001923F File Offset: 0x0001743F
		private void txtModSearch_TextChanged(object sender, EventArgs e)
		{
			this.lstMods.FilterDescriptors.Clear();
			this.lstMods.FilterDescriptors.Add(new FilterDescriptor("Text", FilterOperator.Contains, this.txtModSearch.Text));
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00056B50 File Offset: 0x00054D50
		private void cmdModContribute_Click(object sender, EventArgs e)
		{
			Process.Start("https://cloud.wiiuusbhelper.com/mods/suggest/index.php?name=" + Convert.ToBase64String(Encoding.UTF8.GetBytes(this.SelectedGame.Name + string.Format(" ({0})", this.SelectedGame.Region))));
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00056BA4 File Offset: 0x00054DA4
		private void dockMain_ActiveWindowChanged(object sender, DockWindowEventArgs e)
		{
			if (this.dockWindow_0 == this.toolDownload && Settings.Default.ShowDownloadManagerTip && Settings.Default.LaunchCount <= 3 && this.CurrentlyDownloading)
			{
				Settings.Default.ShowDownloadManagerTip = false;
				Settings.Default.Save();
				new frmHelpOverlay(base.Handle, new Point?(new Point(base.Width - 40, 125)), "The Download Manager will be accessible from here!", 5).ShowDialog();
			}
			this.dockWindow_0 = e.DockWindow;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00019278 File Offset: 0x00017478
		private void timer_6_Tick(object sender, EventArgs e)
		{
			if (this.int_2 != this.Platforms.Count)
			{
				this.method_49();
			}
			this.int_2 = this.Platforms.Count;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000192A4 File Offset: 0x000174A4
		private void chkDisableSpeedGraph_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.ShowSpeedGraph = !this.chkDisableSpeedGraph.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000192C8 File Offset: 0x000174C8
		private void cmdCommunitySaves_Click(object sender, EventArgs e)
		{
			new frmCommunitySaves(this.SelectedGame).ShowDialog();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000192DB File Offset: 0x000174DB
		private void chkNotifyChat_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.ChatNotifications = this.chkNotifyChat.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000192FC File Offset: 0x000174FC
		private void lstChat_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
		{
			e.VisualItem.TextWrap = true;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0001930A File Offset: 0x0001750A
		private void dockInfo_ActiveWindowChanged(object sender, DockWindowEventArgs e)
		{
			if (this.dockInfo.ActiveWindow == this.toolChat)
			{
				this.toolChat.Text = "Chat Room";
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0001932F File Offset: 0x0001752F
		private void timer_7_Tick(object sender, EventArgs e)
		{
			if (this.string_3 != null)
			{
				Class89.smethod_5(this.string_3);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00056C30 File Offset: 0x00054E30
		private void cmdSetExtractFolder_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Class95.smethod_12(false);
				this.method_24();
				return;
			}
			if (e.Button == MouseButtons.Right && Directory.Exists(Settings.Default.ExtractFolder))
			{
				Class95.smethod_9(Settings.Default.ExtractFolder);
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00056C88 File Offset: 0x00054E88
		private void cmdChangeFolder_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Class95.smethod_13(false);
				this.method_51();
				return;
			}
			if (e.Button == MouseButtons.Right && Directory.Exists(Settings.Default.Path))
			{
				Class95.smethod_9(Settings.Default.Path);
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00019344 File Offset: 0x00017544
		private void radioLobby_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.GameSpecificRoom = (e.ToggleState != ToggleState.On);
			if (!Settings.Default.GameSpecificRoom)
			{
				this.method_64("MAIN LOBBY");
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00019373 File Offset: 0x00017573
		private void radioGameRoom_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			Settings.Default.GameSpecificRoom = (e.ToggleState == ToggleState.On);
			if (Settings.Default.GameSpecificRoom)
			{
				GClass32 selectedGame = this.SelectedGame;
				this.method_64((selectedGame != null) ? selectedGame.Name : null);
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00063E58 File Offset: 0x00062058
		[CompilerGenerated]
		private void method_67(object object_0, Exception exception_0)
		{
			NusGrabberForm.Class160 @class = new NusGrabberForm.Class160();
			@class.exception_0 = exception_0;
			base.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000193CB File Offset: 0x000175CB
		[CompilerGenerated]
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.DownloadButton.ButtonElement.BorderElement.Visibility = ((this.DownloadButton.ButtonElement.BorderElement.Visibility == ElementVisibility.Hidden) ? ElementVisibility.Visible : ElementVisibility.Hidden);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000193FE File Offset: 0x000175FE
		[CompilerGenerated]
		private bool method_68(ListViewDataItem listViewDataItem_0)
		{
			return listViewDataItem_0.Tag == this.SelectedGame;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00063E88 File Offset: 0x00062088
		[CompilerGenerated]
		private void method_69()
		{
			try
			{
				foreach (string arg in new string[]
				{
					"US",
					"GB",
					"JP"
				})
				{
					string str = string.Format("https://samurai.ctr.shop.nintendo.net/samurai/ws/{0}/titles?limit=1000&", arg);
					foreach (ListViewDataItem listViewDataItem in this.chkGameGenres.CheckedItems)
					{
						str += string.Format("genre[]={0}&", (uint)listViewDataItem.Tag);
					}
					foreach (GClass109 gclass in JsonConvert.DeserializeObject<GClass111>(Encoding.UTF8.GetString(new GClass78
					{
						bool_0 = true
					}.method_4(str, 24))).Contents.Content)
					{
						this.list_0.Add(gclass.Title.Id.ToString());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00063FFC File Offset: 0x000621FC
		[CompilerGenerated]
		private void method_70()
		{
			try
			{
				this.ulong_0 = 0UL;
				string path = Path.Combine(Settings.Default.Path, "DATA");
				string path2 = Path.Combine(Settings.Default.Path, "DATA_3DS");
				if (Directory.Exists(path))
				{
					this.ulong_0 += GClass6.smethod_7(path);
				}
				if (Directory.Exists(path2))
				{
					this.ulong_0 += GClass6.smethod_7(path2);
				}
				if (this.ulong_0 == 0UL)
				{
					this.ulong_0 += 1UL;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000640A0 File Offset: 0x000622A0
		[CompilerGenerated]
		private void method_71(object object_0, GClass79 gclass79_0)
		{
			NusGrabberForm.Class176 @class = new NusGrabberForm.Class176();
			@class.nusGrabberForm_0 = this;
			@class.gclass79_0 = gclass79_0;
			try
			{
				base.Invoke(new Action(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000640EC File Offset: 0x000622EC
		[CompilerGenerated]
		private void method_72(object object_0, bool bool_9)
		{
			NusGrabberForm.Class177 @class = new NusGrabberForm.Class177();
			@class.nusGrabberForm_0 = this;
			@class.bool_0 = bool_9;
			base.Invoke(new Action(@class.method_0));
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00064120 File Offset: 0x00062320
		[CompilerGenerated]
		private void method_73(object sender, EventArgs e)
		{
			foreach (GClass32 gclass32_ in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_45)))
			{
				this.method_0(gclass32_);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00064198 File Offset: 0x00062398
		[CompilerGenerated]
		private void method_74(object sender, EventArgs e)
		{
			FrmSelectVersion frmSelectVersion = new FrmSelectVersion((this.lstGames.SelectedItems[0].Tag as GClass32).Updates, false);
			if (frmSelectVersion.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			foreach (GClass33 gclass30_ in frmSelectVersion.list_0)
			{
				this.method_6(gclass30_);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0001940E File Offset: 0x0001760E
		[CompilerGenerated]
		private void method_75(object sender, EventArgs e)
		{
			this.method_6((this.lstGames.SelectedItems[0].Tag as GClass32).Dlc);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00064220 File Offset: 0x00062420
		[CompilerGenerated]
		private void method_76(object sender, EventArgs e)
		{
			foreach (GClass32 gclass32_ in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_46)))
			{
				this.method_55(gclass32_);
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00064298 File Offset: 0x00062498
		[CompilerGenerated]
		private void method_77(object sender, EventArgs e)
		{
			foreach (GClass32 gclass32_ in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_47)).ToArray<GClass32>())
			{
				this.method_28(gclass32_);
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000642F4 File Offset: 0x000624F4
		[CompilerGenerated]
		private void method_78(object sender, EventArgs e)
		{
			foreach (GClass32 gclass32_ in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_48)).ToArray<GClass32>())
			{
				this.method_33(gclass32_, true, false);
			}
			this.method_65();
			this.method_63(false, true, this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_49)).ToList<GClass32>());
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00064394 File Offset: 0x00062594
		[CompilerGenerated]
		private void method_79(object sender, EventArgs e)
		{
			foreach (GClass32 gclass32_ in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_50)).ToArray<GClass32>())
			{
				this.method_33(gclass32_, false, false);
			}
			this.method_65();
			this.method_63(false, true, this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_51)).ToList<GClass32>());
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00064434 File Offset: 0x00062634
		[CompilerGenerated]
		private void method_80(object sender, EventArgs e)
		{
			if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
			{
				Class95.smethod_12(false);
			}
			if (!GClass6.smethod_2(Settings.Default.ExtractFolder))
			{
				Class95.smethod_15(this, "Operation aborted.");
				return;
			}
			foreach (GClass32 gclass in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_52)))
			{
				if (gclass.System == GEnum3.const_1)
				{
					FrmWhatToCopy frmWhatToCopy = new FrmWhatToCopy(gclass, WhatToAction.Unpack);
					if (frmWhatToCopy.ShowDialog() != DialogResult.OK)
					{
						continue;
					}
					if (frmWhatToCopy.CopyDlc)
					{
						gclass.Dlc.method_16(Settings.Default.ExtractFolder, true, false, null, false);
					}
					if (frmWhatToCopy.CopyGame)
					{
						gclass.method_16(Settings.Default.ExtractFolder, true, false, null, false);
					}
					if (!frmWhatToCopy.CopyUpdate)
					{
						continue;
					}
					using (List<GClass33>.Enumerator enumerator2 = frmWhatToCopy.list_0.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							GClass33 gclass2 = enumerator2.Current;
							gclass2.method_16(Settings.Default.ExtractFolder, true, false, null, false);
						}
						continue;
					}
				}
				if (gclass.System == GEnum3.const_0)
				{
					FrmWhatToCopy frmWhatToCopy2 = new FrmWhatToCopy(gclass, WhatToAction.Unpack);
					if (frmWhatToCopy2.ShowDialog() == DialogResult.OK)
					{
						if (frmWhatToCopy2.CopyDlc)
						{
							gclass.Dlc.method_5(Settings.Default.ExtractFolder, gclass.Dlc.Name + " (DLC)");
						}
						if (frmWhatToCopy2.CopyGame)
						{
							gclass.method_5(Settings.Default.ExtractFolder, gclass.Name);
						}
						if (frmWhatToCopy2.CopyUpdate)
						{
							foreach (GClass33 gclass3 in frmWhatToCopy2.list_0)
							{
								gclass3.method_5(Settings.Default.ExtractFolder, string.Format("{0}  (UPDATE) (v{1})", gclass3.Name, gclass3.Version));
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00019436 File Offset: 0x00017636
		[CompilerGenerated]
		private void method_81(object sender, EventArgs e)
		{
			this.method_42(this.lstGames.SelectedItems[0].Tag as GClass32);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000646A4 File Offset: 0x000628A4
		[CompilerGenerated]
		private void method_82(object sender, EventArgs e)
		{
			this.method_45(this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_53)).Where(new Func<GClass32, bool>(NusGrabberForm.<>c.<>c_0.method_54)), false);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0006470C File Offset: 0x0006290C
		[CompilerGenerated]
		private void method_83(object sender, EventArgs e)
		{
			foreach (GClass32 gclass in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_55)))
			{
				new frmEmuInfo(gclass).ShowDialog();
			}
			this.method_63(false, true, this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_56)).ToList<GClass32>());
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000647C4 File Offset: 0x000629C4
		[CompilerGenerated]
		private void method_84(object sender, EventArgs e)
		{
			foreach (GClass32 gclass in this.lstGames.SelectedItems.Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_57)))
			{
				new frmDownloadSpecificFiles(gclass).ShowDialog();
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00064840 File Offset: 0x00062A40
		[CompilerGenerated]
		private void method_85(object object_0, HelperChat.Message message_0)
		{
			NusGrabberForm.Class180 @class = new NusGrabberForm.Class180();
			@class.nusGrabberForm_0 = this;
			@class.message_0 = message_0;
			try
			{
				base.Invoke(new MethodInvoker(@class.method_0));
			}
			catch
			{
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00019459 File Offset: 0x00017659
		[CompilerGenerated]
		private void method_86()
		{
			this.panelGameCover.smethod_1(false);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00019467 File Offset: 0x00017667
		[CompilerGenerated]
		private void method_87()
		{
			this.bool_2 = true;
			this.gclass130_0 = new GClass130(this);
			this.gclass130_0.Run();
		}

		// Token: 0x0400085C RID: 2140
		private const string string_0 = "Powered by Willzor's wiiuusbhelper.com (No Wii U found, please launch Wii U USB Helper Transfer Tool)";

		// Token: 0x0400085D RID: 2141
		private const string string_1 = "Powered by Willzor's wiiuusbhelper.com (Connected to your Wii U!)";

		// Token: 0x0400085E RID: 2142
		private const int int_0 = 4000;

		// Token: 0x0400085F RID: 2143
		private static readonly string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\USB_HELPER\\";

		// Token: 0x04000860 RID: 2144
		private readonly ListViewDataItemGroup listViewDataItemGroup_0 = new ListViewDataItemGroup("Downloaded")
		{
			Image = Class121.icnDownloadedMini
		};

		// Token: 0x04000861 RID: 2145
		private readonly ListViewDataItemGroup listViewDataItemGroup_1 = new ListViewDataItemGroup("Partially downloaded")
		{
			Image = Class121.icnPartialMini
		};

		// Token: 0x04000862 RID: 2146
		private readonly ListViewDataItemGroup listViewDataItemGroup_2 = new ListViewDataItemGroup("Installed on your WiiU")
		{
			Image = Class121.icnWiiuMini
		};

		// Token: 0x04000863 RID: 2147
		private readonly ListViewDataItemGroup listViewDataItemGroup_3 = new ListViewDataItemGroup("Not downloaded")
		{
			Image = Class121.icnNotDownloadedMini
		};

		// Token: 0x04000864 RID: 2148
		private readonly ListViewDataItemGroup listViewDataItemGroup_4 = new ListViewDataItemGroup("Ready for emulation")
		{
			Image = Class121.icnPlayMini
		};

		// Token: 0x04000865 RID: 2149
		private GEnum10 genum10_0;

		// Token: 0x04000866 RID: 2150
		private GClass80 gclass80_0;

		// Token: 0x04000867 RID: 2151
		private ulong ulong_0;

		// Token: 0x04000868 RID: 2152
		private bool bool_0;

		// Token: 0x04000869 RID: 2153
		private GClass15 gclass15_0;

		// Token: 0x0400086A RID: 2154
		private bool bool_1;

		// Token: 0x0400086B RID: 2155
		private bool bool_2;

		// Token: 0x0400086C RID: 2156
		private bool bool_3;

		// Token: 0x0400086D RID: 2157
		private bool bool_4;

		// Token: 0x0400086E RID: 2158
		private bool bool_5;

		// Token: 0x0400086F RID: 2159
		private bool bool_6;

		// Token: 0x04000870 RID: 2160
		private volatile bool bool_7;

		// Token: 0x04000871 RID: 2161
		private DriveInfo driveInfo_0;

		// Token: 0x04000872 RID: 2162
		private List<string> list_0;

		// Token: 0x04000873 RID: 2163
		private GClass130 gclass130_0;

		// Token: 0x04000874 RID: 2164
		private DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04000875 RID: 2165
		private GClass82 gclass82_0;

		// Token: 0x04000876 RID: 2166
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x04000877 RID: 2167
		private Bitmap bitmap_0;

		// Token: 0x04000878 RID: 2168
		[CompilerGenerated]
		private FrmWait frmWait_0;

		// Token: 0x04000879 RID: 2169
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400087A RID: 2170
		[CompilerGenerated]
		private List<Platform> list_1;

		// Token: 0x0400087B RID: 2171
		[CompilerGenerated]
		private WebProxy webProxy_0;

		// Token: 0x0400087C RID: 2172
		[CompilerGenerated]
		private GClass32 gclass32_0;

		// Token: 0x0400087D RID: 2173
		[CompilerGenerated]
		private GClass32 gclass32_1;

		// Token: 0x0400087E RID: 2174
		[CompilerGenerated]
		private readonly List<GClass30> list_2;

		// Token: 0x0400087F RID: 2175
		[CompilerGenerated]
		private readonly List<GClass30> list_3;

		// Token: 0x04000880 RID: 2176
		private System.Windows.Forms.Timer timer_0;

		// Token: 0x04000881 RID: 2177
		private System.Windows.Forms.Timer timer_1;

		// Token: 0x04000882 RID: 2178
		private float float_0;

		// Token: 0x04000883 RID: 2179
		private List<GClass133> list_4 = new List<GClass133>();

		// Token: 0x04000884 RID: 2180
		private SoundPlayer soundPlayer_0 = new SoundPlayer(Class121.sndAdd);

		// Token: 0x04000885 RID: 2181
		private DateTime dateTime_1;

		// Token: 0x04000886 RID: 2182
		private ChartValues<GClass125> chartValues_0;

		// Token: 0x04000887 RID: 2183
		private LiveCharts.WinForms.CartesianChart cartesianChart_0;

		// Token: 0x04000888 RID: 2184
		private string string_3;

		// Token: 0x04000889 RID: 2185
		private ulong ulong_1;

		// Token: 0x0400088A RID: 2186
		private DockWindow dockWindow_0;

		// Token: 0x0400088B RID: 2187
		private int int_2;

		// Token: 0x020001D3 RID: 467
		private class Class159
		{
			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00019487 File Offset: 0x00017687
			// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0001948F File Offset: 0x0001768F
			public byte[] WiiU { get; set; }

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00019498 File Offset: 0x00017698
			// (set) Token: 0x06000D78 RID: 3448 RVA: 0x000194A0 File Offset: 0x000176A0
			public byte[] Byte_0 { get; set; }

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000194A9 File Offset: 0x000176A9
			// (set) Token: 0x06000D7A RID: 3450 RVA: 0x000194B1 File Offset: 0x000176B1
			public byte[] Wii { get; set; }

			// Token: 0x040009A2 RID: 2466
			[CompilerGenerated]
			private byte[] byte_0;

			// Token: 0x040009A3 RID: 2467
			[CompilerGenerated]
			private byte[] byte_1;

			// Token: 0x040009A4 RID: 2468
			[CompilerGenerated]
			private byte[] byte_2;
		}

		// Token: 0x020001D4 RID: 468
		[CompilerGenerated]
		private sealed class Class160
		{
			// Token: 0x06000D7C RID: 3452 RVA: 0x000194BA File Offset: 0x000176BA
			internal void method_0()
			{
				RadMessageBox.Show(this.exception_0.Message);
			}

			// Token: 0x040009A5 RID: 2469
			public Exception exception_0;
		}

		// Token: 0x020001D6 RID: 470
		[CompilerGenerated]
		private sealed class Class161
		{
			// Token: 0x06000DBF RID: 3519 RVA: 0x000648CC File Offset: 0x00062ACC
			internal void method_0(object sender, EventArgs e)
			{
				this.nusGrabberForm_0.float_0 = this.nusGrabberForm_0.float_0 + (float)this.int_0 / 4f;
				if (this.nusGrabberForm_0.float_0 >= 3f || this.nusGrabberForm_0.float_0 <= -3f)
				{
					this.int_0 *= -1;
				}
				this.nusGrabberForm_0.pbCover.Refresh();
			}

			// Token: 0x040009E6 RID: 2534
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x040009E7 RID: 2535
			public int int_0;
		}

		// Token: 0x020001D7 RID: 471
		[CompilerGenerated]
		private sealed class Class162
		{
			// Token: 0x06000DC1 RID: 3521 RVA: 0x00064940 File Offset: 0x00062B40
			internal void method_0()
			{
				try
				{
					byte[] buffer = new GClass78().method_2((this.listViewDataItem_0.Tag as GClass30).GClass32_0.IconUrl);
					NusGrabberForm.Class163 @class = new NusGrabberForm.Class163();
					@class.class162_0 = this;
					@class.memoryStream_0 = new MemoryStream(buffer);
					try
					{
						this.nusGrabberForm_0.Invoke(new MethodInvoker(@class.method_0));
					}
					finally
					{
						if (@class.memoryStream_0 != null)
						{
							((IDisposable)@class.memoryStream_0).Dispose();
						}
					}
				}
				catch
				{
				}
			}

			// Token: 0x040009E8 RID: 2536
			public ListViewDataItem listViewDataItem_0;

			// Token: 0x040009E9 RID: 2537
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001D8 RID: 472
		[CompilerGenerated]
		private sealed class Class163
		{
			// Token: 0x06000DC3 RID: 3523 RVA: 0x00019658 File Offset: 0x00017858
			internal void method_0()
			{
				this.class162_0.listViewDataItem_0.Image = new Bitmap(Image.FromStream(this.memoryStream_0), 48, 48);
			}

			// Token: 0x040009EA RID: 2538
			public MemoryStream memoryStream_0;

			// Token: 0x040009EB RID: 2539
			public NusGrabberForm.Class162 class162_0;
		}

		// Token: 0x020001D9 RID: 473
		[CompilerGenerated]
		private sealed class Class164
		{
			// Token: 0x06000DC5 RID: 3525 RVA: 0x0001967E File Offset: 0x0001787E
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Tag == this.gclass30_0;
			}

			// Token: 0x040009EC RID: 2540
			public GClass30 gclass30_0;
		}

		// Token: 0x020001DA RID: 474
		[CompilerGenerated]
		private sealed class Class165
		{
			// Token: 0x06000DC7 RID: 3527 RVA: 0x0001968E File Offset: 0x0001788E
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Tag == this.gclass133_0.gclass30_0;
			}

			// Token: 0x040009ED RID: 2541
			public GClass133 gclass133_0;
		}

		// Token: 0x020001DB RID: 475
		[CompilerGenerated]
		private sealed class Class166
		{
			// Token: 0x06000DC9 RID: 3529 RVA: 0x000196A3 File Offset: 0x000178A3
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Tag == this.gclass30_0;
			}

			// Token: 0x040009EE RID: 2542
			public GClass30 gclass30_0;
		}

		// Token: 0x020001DC RID: 476
		[CompilerGenerated]
		private sealed class Class167
		{
			// Token: 0x06000DCB RID: 3531 RVA: 0x000196B3 File Offset: 0x000178B3
			internal void method_0(object sender, EventArgs e)
			{
				this.nusGrabberForm_0.method_10(this.gclass133_0.gclass30_0, -1);
			}

			// Token: 0x06000DCC RID: 3532 RVA: 0x000196CC File Offset: 0x000178CC
			internal void method_1(object sender, EventArgs e)
			{
				this.nusGrabberForm_0.method_10(this.gclass133_0.gclass30_0, 1);
			}

			// Token: 0x040009EF RID: 2543
			public GClass133 gclass133_0;

			// Token: 0x040009F0 RID: 2544
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001DD RID: 477
		[CompilerGenerated]
		private sealed class Class168
		{
			// Token: 0x06000DCE RID: 3534 RVA: 0x000196E5 File Offset: 0x000178E5
			internal DialogResult method_0()
			{
				return this.frmWait_0.ShowDialog();
			}

			// Token: 0x040009F1 RID: 2545
			public FrmWait frmWait_0;
		}

		// Token: 0x020001DE RID: 478
		[CompilerGenerated]
		private sealed class Class169
		{
			// Token: 0x06000DD0 RID: 3536 RVA: 0x000196F2 File Offset: 0x000178F2
			internal void method_0()
			{
				Thread.Sleep(5000);
				while (this.nusGrabberForm_0.gclass82_0 == null)
				{
					Thread.Sleep(100);
				}
				Thread.Sleep(5000);
			}

			// Token: 0x040009F2 RID: 2546
			public string string_0;

			// Token: 0x040009F3 RID: 2547
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x040009F4 RID: 2548
			public Action action_0;
		}

		// Token: 0x020001DF RID: 479
		[CompilerGenerated]
		private sealed class Class170
		{
			// Token: 0x06000DD2 RID: 3538 RVA: 0x0001971E File Offset: 0x0001791E
			internal void method_0(object sender, EventArgs e)
			{
				this.gclass30_0.method_7();
			}

			// Token: 0x040009F5 RID: 2549
			public GClass30 gclass30_0;

			// Token: 0x040009F6 RID: 2550
			public NusGrabberForm.Class169 class169_0;
		}

		// Token: 0x020001E0 RID: 480
		[CompilerGenerated]
		private sealed class Class171
		{
			// Token: 0x06000DD4 RID: 3540 RVA: 0x0001972B File Offset: 0x0001792B
			internal void method_0(object sender, GEventArgs0 e)
			{
				this.frmFtpProgress_0.method_2(e.GameProgress, e.Speed);
				this.frmFtpProgress_0.method_1(e.TotalEta);
			}

			// Token: 0x06000DD5 RID: 3541 RVA: 0x00019755 File Offset: 0x00017955
			internal void method_1(object object_0, GClass81 gclass81_0)
			{
				this.class170_0.class169_0.string_0 = gclass81_0.Message;
				this.class170_0.gclass30_0.method_8();
				this.frmFtpProgress_0.method_0();
			}

			// Token: 0x040009F7 RID: 2551
			public FrmFtpProgress frmFtpProgress_0;

			// Token: 0x040009F8 RID: 2552
			public NusGrabberForm.Class170 class170_0;
		}

		// Token: 0x020001E1 RID: 481
		[CompilerGenerated]
		private sealed class Class172
		{
			// Token: 0x06000DD7 RID: 3543 RVA: 0x000649DC File Offset: 0x00062BDC
			internal void method_0()
			{
				if (!this.gclass81_0.Error)
				{
					this.nusGrabberForm_0.lstLog.Items.Clear();
					this.nusGrabberForm_0.gaugeSpeed.Value = 0f;
					this.nusGrabberForm_0.lblSpeed.Text = "0,00 KB/s";
					this.nusGrabberForm_0.totalProgress.Value1 = 0;
					this.nusGrabberForm_0.pgFile.Value1 = 0;
					this.nusGrabberForm_0.lblFileEta.Text = "-";
					this.nusGrabberForm_0.NUSGrabberProgress.Value1 = 0;
					this.nusGrabberForm_0.lblEta.Text = "-";
					this.nusGrabberForm_0.lblTotalEta.Text = "-";
					this.nusGrabberForm_0.grpProgressCurrent.Text = "Current game";
					this.nusGrabberForm_0.radLiveSpeed.Text = "Live Speed";
					this.nusGrabberForm_0.lblFileCheckStatus.Visible = false;
					if (this.nusGrabberForm_0.driveInfo_0 != null)
					{
						Class95.smethod_4(this.nusGrabberForm_0.dlQueue.Items.Select(new Func<ListViewDataItem, GClass30>(NusGrabberForm.<>c.<>c_0.method_12)).Where(new Func<GClass30, bool>(NusGrabberForm.<>c.<>c_0.method_13)).ToList<GClass30>(), this.nusGrabberForm_0.driveInfo_0, false, false, this.nusGrabberForm_0);
					}
					if (this.nusGrabberForm_0.chkUnpack.Checked)
					{
						foreach (GClass30 gclass in this.nusGrabberForm_0.dlQueue.Items.Select(new Func<ListViewDataItem, GClass30>(NusGrabberForm.<>c.<>c_0.method_14)).Where(new Func<GClass30, bool>(NusGrabberForm.<>c.<>c_0.method_15)))
						{
							gclass.method_16(Settings.Default.ExtractFolder, true, false, null, false);
						}
					}
					if (this.nusGrabberForm_0.chkPack.Checked)
					{
						foreach (GClass30 gclass2 in this.nusGrabberForm_0.dlQueue.Items.Select(new Func<ListViewDataItem, GClass30>(NusGrabberForm.<>c.<>c_0.method_16)).Where(new Func<GClass30, bool>(NusGrabberForm.<>c.<>c_0.method_17)))
						{
							if (gclass2 is GClass33)
							{
								gclass2.method_5(Settings.Default.ExtractFolder, string.Format("{0}  (UPDATE) (v{1})", gclass2.Name, gclass2.Version));
							}
							else if (gclass2 is GClass31)
							{
								gclass2.method_5(Settings.Default.ExtractFolder, gclass2.Name + " (DLC)");
							}
							else
							{
								gclass2.method_5(Settings.Default.ExtractFolder, gclass2.Name);
							}
						}
					}
					if (this.nusGrabberForm_0.chkPrepareEmulation.Checked)
					{
						this.nusGrabberForm_0.method_45(this.nusGrabberForm_0.dlQueue.Items.Select(new Func<ListViewDataItem, GClass30>(NusGrabberForm.<>c.<>c_0.method_18)).Where(new Func<GClass30, bool>(NusGrabberForm.<>c.<>c_0.method_19)).Select(new Func<GClass30, GClass32>(NusGrabberForm.<>c.<>c_0.method_20)), true);
					}
					switch (this.nusGrabberForm_0.genum10_0)
					{
					case GEnum10.const_1:
						Application.SetSuspendState(PowerState.Suspend, true, true);
						break;
					case GEnum10.const_2:
						Process.Start("shutdown", "/s /t 0");
						break;
					case GEnum10.const_3:
						Application.SetSuspendState(PowerState.Hibernate, true, true);
						break;
					}
					Class95.smethod_5("Download completed!", " Your titles are ready!", 15, true, this.nusGrabberForm_0.dlQueue.Items[0].Image);
				}
				this.nusGrabberForm_0.method_63(true, true, this.nusGrabberForm_0.dlQueue.Items.Where(new Func<ListViewDataItem, bool>(NusGrabberForm.<>c.<>c_0.method_21)).Select(new Func<ListViewDataItem, GClass32>(NusGrabberForm.<>c.<>c_0.method_22)).ToList<GClass32>());
				foreach (GClass30 gclass30_ in this.nusGrabberForm_0.dlQueue.Items.ToArray<ListViewDataItem>().Select(new Func<ListViewDataItem, GClass30>(NusGrabberForm.<>c.<>c_0.method_23)).Where(new Func<GClass30, bool>(NusGrabberForm.<>c.<>c_0.method_24)))
				{
					this.nusGrabberForm_0.method_7(gclass30_);
				}
				this.nusGrabberForm_0.method_54(true);
				try
				{
					TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
				}
				catch
				{
				}
				this.nusGrabberForm_0.CurrentlyDownloading = false;
				this.nusGrabberForm_0.method_18();
				this.nusGrabberForm_0.method_65();
				this.nusGrabberForm_0.method_9();
				this.nusGrabberForm_0.toolDownload.Image = null;
			}

			// Token: 0x040009F9 RID: 2553
			public GClass81 gclass81_0;

			// Token: 0x040009FA RID: 2554
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001E2 RID: 482
		[CompilerGenerated]
		private sealed class Class173
		{
			// Token: 0x06000DD9 RID: 3545 RVA: 0x00064FA4 File Offset: 0x000631A4
			internal void method_0()
			{
				this.nusGrabberForm_0.txtDesc.smethod_1(false);
				if (this.gclass74_0 != null)
				{
					if (this.nusGrabberForm_0.SelectedGame == this.gclass32_0)
					{
						if (this.gclass74_0.RatingInfo != null)
						{
							this.nusGrabberForm_0.pbRating.ImageLocation = this.gclass74_0.RatingInfo.Rating.Icons.Icon[0].Url;
						}
						if (this.gclass74_0.StarRatingInfo != null)
						{
							this.nusGrabberForm_0.pgScore.Value1 = (int)(this.gclass74_0.StarRatingInfo.Score * 20.0);
						}
						else
						{
							this.nusGrabberForm_0.pgScore.Value1 = 0;
						}
						this.nusGrabberForm_0.lblNbPlayers.Text = ((this.gclass74_0.NumberOfPlayers != null) ? this.gclass74_0.NumberOfPlayers.smethod_8() : "-");
						this.nusGrabberForm_0.lstControllers.Items.Clear();
						this.nusGrabberForm_0.lstMovies.Items.Clear();
						this.nusGrabberForm_0.lstGenre.Items.Clear();
						this.nusGrabberForm_0.lstLanguages.Items.Clear();
						GClass61 playStyles = this.gclass74_0.PlayStyles;
						if (((playStyles != null) ? playStyles.PlayStyle[0].Controllers : null) != null)
						{
							foreach (GClass36 gclass in this.gclass74_0.PlayStyles.PlayStyle[0].Controllers.Controller)
							{
								this.nusGrabberForm_0.lstControllers.Items.Add(gclass.Name);
							}
						}
						if (this.gclass74_0.Genres != null)
						{
							foreach (GClass48 gclass2 in this.gclass74_0.Genres.Genre)
							{
								this.nusGrabberForm_0.lstGenre.Items.Add(gclass2.Name);
							}
						}
						if (this.gclass74_0.Movies != null)
						{
							foreach (GClass56 gclass3 in this.gclass74_0.Movies.Movie)
							{
								ListViewDataItem item = new ListViewDataItem(gclass3.Name)
								{
									Tag = gclass3
								};
								this.nusGrabberForm_0.lstMovies.Items.Add(item);
							}
						}
						if (this.gclass74_0.Languages != null)
						{
							this.nusGrabberForm_0.lstLanguages.Items.AddRange(this.gclass74_0.Languages.Language.Select(new Func<GClass54, ListViewDataItem>(NusGrabberForm.<>c.<>c_0.method_25)).ToArray<ListViewDataItem>());
						}
						if (this.gclass74_0.Description != null)
						{
							this.nusGrabberForm_0.txtDesc.Text = this.gclass74_0.Description.smethod_9(new string[]
							{
								"</br>",
								"<br/>",
								"<br>",
								"<br />",
								"<Br>",
								"\n",
								"<BR>}"
							}, " ").Replace("  ", Environment.NewLine).smethod_8();
						}
						else
						{
							this.nusGrabberForm_0.txtDesc.Text = "";
						}
						if (this.gclass74_0.Copyright != null && this.nusGrabberForm_0.SelectedGame.Platform == Platform.Wii_U_Custom)
						{
							RadTextBoxControl txtDesc = this.nusGrabberForm_0.txtDesc;
							txtDesc.Text += string.Format("{0}{1}Developed by : {2}", Environment.NewLine, Environment.NewLine, this.gclass74_0.Copyright.Text);
						}
						if (this.gclass32_0.Boolean_0)
						{
							RadTextBoxControl txtDesc2 = this.nusGrabberForm_0.txtDesc;
							txtDesc2.Text += string.Format("{0}{1}NOTE: This is an injection. You have to provide the iso to build the game.", Environment.NewLine, Environment.NewLine);
						}
						else
						{
							RadTextBoxControl txtDesc3 = this.nusGrabberForm_0.txtDesc;
							txtDesc3.Text += string.Format("{0}{1}Estimated download time: {2}", Environment.NewLine, Environment.NewLine, this.gclass32_0.method_0(new GStruct3(Settings.Default.MeasuredSpeed)));
						}
						this.nusGrabberForm_0.bitmap_0 = null;
						this.nusGrabberForm_0.SelectedGame.gclass86_1.Event_2 += this.nusGrabberForm_0.method_41;
						this.nusGrabberForm_0.SelectedGame.gclass86_1.Event_0 += new EventHandler(this.nusGrabberForm_0.method_40);
						if (this.nusGrabberForm_0.SelectedGame.Platform != Platform.Gamecube)
						{
							if (this.nusGrabberForm_0.SelectedGame.Platform != Platform.Wii_Custom)
							{
								this.nusGrabberForm_0.SelectedGame.gclass86_1.vmethod_0(this.gclass74_0.CustomCoverUrl ?? this.nusGrabberForm_0.SelectedGame.String_7, TimeSpan.FromDays(30.0));
								goto IL_5DE;
							}
						}
						this.nusGrabberForm_0.SelectedGame.gclass86_1.vmethod_0(string.Format("http://art.gametdb.com/wii/cover3D/{0}/{1}.png", (this.nusGrabberForm_0.SelectedGame.Region == "EUR") ? "EN" : ((this.nusGrabberForm_0.SelectedGame.Region == "JPN") ? "JA" : "US"), this.nusGrabberForm_0.SelectedGame.ProductId), TimeSpan.FromDays(30.0));
						IL_5DE:
						if (this.gclass74_0.BannerUrl != null)
						{
							this.nusGrabberForm_0.SelectedGame.gclass86_0.Event_2 += this.nusGrabberForm_0.method_39;
							this.nusGrabberForm_0.SelectedGame.gclass86_0.vmethod_0(this.gclass74_0.BannerUrl, TimeSpan.FromDays(30.0));
						}
						else
						{
							this.nusGrabberForm_0.pbBanner.Image = Class121.banner;
						}
						this.nusGrabberForm_0.toolWindow5.BackColor = GClass6.smethod_11((Bitmap)this.nusGrabberForm_0.pbBanner.Image);
						if (this.gclass74_0.Screenshots != null)
						{
							if (this.gclass74_0.Screenshots.Screenshot.Count >= 1)
							{
								this.nusGrabberForm_0.pbPreview1.ImageLocation = this.gclass74_0.Screenshots.Screenshot[0].ImageUrl[0].Value;
							}
							if (this.gclass74_0.Screenshots.Screenshot.Count >= 2)
							{
								this.nusGrabberForm_0.pbPreview2.ImageLocation = this.gclass74_0.Screenshots.Screenshot[1].ImageUrl[0].Value;
							}
							if (this.gclass74_0.Screenshots.Screenshot.Count >= 3)
							{
								this.nusGrabberForm_0.pbPreview3.ImageLocation = this.gclass74_0.Screenshots.Screenshot[2].ImageUrl[0].Value;
							}
						}
						return;
					}
				}
			}

			// Token: 0x040009FB RID: 2555
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x040009FC RID: 2556
			public GClass74 gclass74_0;

			// Token: 0x040009FD RID: 2557
			public GClass32 gclass32_0;
		}

		// Token: 0x020001E3 RID: 483
		[CompilerGenerated]
		private sealed class Class174
		{
			// Token: 0x06000DDB RID: 3547 RVA: 0x00065754 File Offset: 0x00063954
			internal void method_0()
			{
				this.byte_0 = this.nusGrabberForm_0.method_20(Settings.Default.TicketsPath);
				this.byte_1 = this.nusGrabberForm_0.method_20(Settings.Default.TicketsPath3DS);
				this.byte_2 = this.nusGrabberForm_0.method_20(Settings.Default.TicketsPathWii);
			}

			// Token: 0x06000DDC RID: 3548 RVA: 0x00065754 File Offset: 0x00063954
			internal void method_1()
			{
				this.byte_0 = this.nusGrabberForm_0.method_20(Settings.Default.TicketsPath);
				this.byte_1 = this.nusGrabberForm_0.method_20(Settings.Default.TicketsPath3DS);
				this.byte_2 = this.nusGrabberForm_0.method_20(Settings.Default.TicketsPathWii);
			}

			// Token: 0x040009FE RID: 2558
			public byte[] byte_0;

			// Token: 0x040009FF RID: 2559
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A00 RID: 2560
			public byte[] byte_1;

			// Token: 0x04000A01 RID: 2561
			public byte[] byte_2;

			// Token: 0x04000A02 RID: 2562
			public Action action_0;
		}

		// Token: 0x020001E4 RID: 484
		[CompilerGenerated]
		private sealed class Class175
		{
			// Token: 0x06000DDE RID: 3550 RVA: 0x00019788 File Offset: 0x00017988
			internal void method_0(object sender, EventArgs e)
			{
				this.nusGrabberForm_0.method_62();
			}

			// Token: 0x06000DDF RID: 3551 RVA: 0x00019795 File Offset: 0x00017995
			internal DialogResult method_1()
			{
				return this.nusGrabberForm_0.frmWait.ShowDialog();
			}

			// Token: 0x06000DE0 RID: 3552 RVA: 0x000197A7 File Offset: 0x000179A7
			internal DialogResult method_2()
			{
				return this.frmWait_0.ShowDialog();
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x000197B4 File Offset: 0x000179B4
			internal void method_3(object sender, EventArgs e)
			{
				this.nusGrabberForm_0.method_66(this.nusGrabberForm_0.ulong_0);
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x000657B4 File Offset: 0x000639B4
			internal void method_4(object object_0, GClass82 gclass82_0)
			{
				if ((DateTime.Now - this.nusGrabberForm_0.dateTime_0).TotalSeconds > 8.0)
				{
					this.nusGrabberForm_0.method_34(gclass82_0);
				}
				this.nusGrabberForm_0.dateTime_0 = DateTime.Now;
				this.nusGrabberForm_0.gclass82_0 = gclass82_0;
			}

			// Token: 0x04000A03 RID: 2563
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A04 RID: 2564
			public FrmWait frmWait_0;
		}

		// Token: 0x020001E5 RID: 485
		[CompilerGenerated]
		private sealed class Class176
		{
			// Token: 0x06000DE4 RID: 3556 RVA: 0x00065814 File Offset: 0x00063A14
			internal void method_0()
			{
				try
				{
					this.nusGrabberForm_0.IndexGameCurrentlyDownloaded = this.gclass79_0.Index;
					this.nusGrabberForm_0.method_9();
					if (this.nusGrabberForm_0.IndexGameCurrentlyDownloaded > 0)
					{
						this.nusGrabberForm_0.dlQueue.Items[this.nusGrabberForm_0.IndexGameCurrentlyDownloaded - 1].ForeColor = System.Drawing.Color.Green;
					}
					this.nusGrabberForm_0.dlQueue.Items[this.nusGrabberForm_0.IndexGameCurrentlyDownloaded].ForeColor = System.Drawing.Color.Orange;
					this.nusGrabberForm_0.grpProgressCurrent.Text = string.Format("Current game : {0}", this.gclass79_0.Title);
				}
				catch
				{
				}
			}

			// Token: 0x04000A05 RID: 2565
			public GClass79 gclass79_0;

			// Token: 0x04000A06 RID: 2566
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001E6 RID: 486
		[CompilerGenerated]
		private sealed class Class177
		{
			// Token: 0x06000DE6 RID: 3558 RVA: 0x000197CC File Offset: 0x000179CC
			internal void method_0()
			{
				this.nusGrabberForm_0.lblFileCheckStatus.Visible = this.bool_0;
			}

			// Token: 0x04000A07 RID: 2567
			public bool bool_0;

			// Token: 0x04000A08 RID: 2568
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001E7 RID: 487
		[CompilerGenerated]
		private sealed class Class178
		{
			// Token: 0x06000DE8 RID: 3560 RVA: 0x000658E0 File Offset: 0x00063AE0
			internal void method_0()
			{
				if (this.list_0.Count == 0)
				{
					this.nusGrabberForm_0.lblSynchronized.ForeColor = System.Drawing.Color.Red;
					this.nusGrabberForm_0.lblSynchronized.Text = "Sync Failed! (Is Mocha Running?)";
					return;
				}
				this.nusGrabberForm_0.lblSynchronized.ForeColor = System.Drawing.Color.Green;
				this.nusGrabberForm_0.lblSynchronized.Text = "Synced at " + DateTime.Now.ToShortTimeString();
			}

			// Token: 0x06000DE9 RID: 3561 RVA: 0x00065964 File Offset: 0x00063B64
			internal void method_1()
			{
				try
				{
					if (this.list_1.Count > 0)
					{
						IEnumerable<GClass33> enumerable = this.list_1.Where(new Func<GClass33, bool>(NusGrabberForm.<>c.<>c_0.method_40));
						if (enumerable.Any<GClass33>() && RadMessageBox.Show("USB Helper has determined that your Wii U lacks game updates that you have already downloaded. Would you like me to add them to the copy queue now?", "Add?", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							foreach (GClass33 gclass30_ in enumerable)
							{
								this.nusGrabberForm_0.method_2(gclass30_);
							}
							this.nusGrabberForm_0.dockMain.ActiveWindow = this.nusGrabberForm_0.toolCopy;
						}
						IEnumerable<GClass33> enumerable2 = this.list_1.Where(new Func<GClass33, bool>(NusGrabberForm.<>c.<>c_0.method_41));
						if (enumerable2.Any<GClass33>())
						{
							FrmNewTitles frmNewTitles = new FrmNewTitles(enumerable2, "USB Helper has detected that you have missed these updates on your Wii U and have not downloaded them yet:");
							frmNewTitles.ShowDialog();
							foreach (GClass30 gclass30_2 in frmNewTitles.list_0)
							{
								this.nusGrabberForm_0.method_6(gclass30_2);
							}
						}
					}
					foreach (GClass32 gclass32_ in this.list_0)
					{
						this.nusGrabberForm_0.method_33(gclass32_, true, false);
					}
					this.nusGrabberForm_0.method_65();
					this.nusGrabberForm_0.method_63(false, true, this.list_0);
				}
				catch
				{
				}
			}

			// Token: 0x04000A09 RID: 2569
			public List<GClass32> list_0;

			// Token: 0x04000A0A RID: 2570
			public List<GClass33> list_1;

			// Token: 0x04000A0B RID: 2571
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001E8 RID: 488
		[CompilerGenerated]
		private sealed class Class179
		{
			// Token: 0x06000DEB RID: 3563 RVA: 0x00065B60 File Offset: 0x00063D60
			internal void method_0(object sender, PropertyChangedEventArgs e)
			{
				if (e.PropertyName == "CheckState")
				{
					Platform item = (Platform)this.radTreeNode_0.Tag;
					if (this.radTreeNode_0.Checked)
					{
						if (!this.nusGrabberForm_0.Platforms.Contains(item))
						{
							this.nusGrabberForm_0.Platforms.Add(item);
							return;
						}
					}
					else if (this.nusGrabberForm_0.Platforms.Contains(item))
					{
						this.nusGrabberForm_0.Platforms.Remove(item);
					}
				}
			}

			// Token: 0x04000A0C RID: 2572
			public RadTreeNode radTreeNode_0;

			// Token: 0x04000A0D RID: 2573
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001E9 RID: 489
		[CompilerGenerated]
		private sealed class Class180
		{
			// Token: 0x06000DED RID: 3565 RVA: 0x00065BE8 File Offset: 0x00063DE8
			internal void method_0()
			{
				string destinationChannel = this.message_0.DestinationChannel;
				if (destinationChannel == "INFO_CLIENT_COUNT")
				{
					this.nusGrabberForm_0.lblChannelClientCount.Text = string.Format("{0} client(s) in this channel", this.message_0.Payload);
					return;
				}
				if (this.nusGrabberForm_0.toolChat.DockManager.ActiveWindow != this.nusGrabberForm_0.toolChat && (DateTime.Now - HelperChat.Message.UnixTimeStampToDateTime(double.Parse(this.message_0.TimeStamp))).TotalSeconds <= 7.0)
				{
					this.nusGrabberForm_0.toolChat.Text = "Chat Room (NEW!)";
					if (Settings.Default.ChatNotifications)
					{
						Class95.smethod_5(string.Format("New message ({0})!", this.message_0.DestinationChannel), this.message_0.Payload, 10, true, null);
					}
				}
				bool flag;
				if (flag = Class89.smethod_4(this.message_0.Sender))
				{
					this.message_0.Sender = "You";
				}
				ListViewDataItem item = new ListViewDataItem
				{
					Text = this.message_0.ToHtmlString(flag ? "#c87137" : "#c1c6dc"),
					Tag = this.message_0
				};
				bool flag2 = false;
				using (IEnumerator<ListViewDataItem> enumerator = this.nusGrabberForm_0.lstChat.Items.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						HelperChat.Message message;
						if ((message = (enumerator.Current.Tag as HelperChat.Message)) != null && message.TimeStamp == this.message_0.TimeStamp)
						{
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2)
				{
					this.nusGrabberForm_0.lstChat.Items.Add(item);
				}
			}

			// Token: 0x04000A0E RID: 2574
			public HelperChat.Message message_0;

			// Token: 0x04000A0F RID: 2575
			public NusGrabberForm nusGrabberForm_0;
		}

		// Token: 0x020001EA RID: 490
		[CompilerGenerated]
		private sealed class Class181
		{
			// Token: 0x06000DEF RID: 3567 RVA: 0x00065DBC File Offset: 0x00063FBC
			internal void method_0()
			{
				this.nusGrabberForm_0.pbBanner.Image = this.gclass84_0.image_0;
				this.nusGrabberForm_0.toolWindow5.BackColor = GClass6.smethod_11((Bitmap)this.nusGrabberForm_0.pbBanner.Image);
			}

			// Token: 0x04000A10 RID: 2576
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A11 RID: 2577
			public GClass84 gclass84_0;
		}

		// Token: 0x020001EB RID: 491
		[CompilerGenerated]
		private sealed class Class182
		{
			// Token: 0x06000DF1 RID: 3569 RVA: 0x00065E10 File Offset: 0x00064010
			internal void method_0()
			{
				this.nusGrabberForm_0.panelGameCover.smethod_1(false);
				this.nusGrabberForm_0.bitmap_0 = (Bitmap)this.gclass84_0.image_0;
				this.nusGrabberForm_0.bitmap_0.SetResolution(96f, 96f);
				this.nusGrabberForm_0.method_4();
			}

			// Token: 0x04000A12 RID: 2578
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A13 RID: 2579
			public GClass84 gclass84_0;
		}

		// Token: 0x020001EC RID: 492
		[CompilerGenerated]
		private sealed class Class183
		{
			// Token: 0x04000A14 RID: 2580
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A15 RID: 2581
			public int int_0;
		}

		// Token: 0x020001ED RID: 493
		[CompilerGenerated]
		private sealed class Class184
		{
			// Token: 0x04000A16 RID: 2582
			public ListViewDataItem listViewDataItem_0;

			// Token: 0x04000A17 RID: 2583
			public NusGrabberForm.Class183 class183_0;
		}

		// Token: 0x020001EE RID: 494
		[CompilerGenerated]
		private sealed class Class185
		{
			// Token: 0x06000DF5 RID: 3573 RVA: 0x000197E4 File Offset: 0x000179E4
			internal void method_0()
			{
				this.class184_0.listViewDataItem_0.Image = this.gclass32_0.gclass86_2.Image;
			}

			// Token: 0x06000DF6 RID: 3574 RVA: 0x00065E70 File Offset: 0x00064070
			internal void method_1()
			{
				try
				{
					if (this.class184_0.class183_0.nusGrabberForm_0.bool_7)
					{
						return;
					}
					string text = GClass88.smethod_8(this.gclass32_0.IconUrl);
					string text2 = Path.Combine(GClass88.CachePath, text);
					if (!GClass88.smethod_1(text))
					{
						using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(this.gclass32_0.IconUrl)))
						{
							if (this.gclass32_0.System == GEnum3.const_3)
							{
								using (Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream), 64, 48))
								{
									using (Bitmap bitmap2 = bitmap.Clone(new Rectangle(8, 0, 48, 48), bitmap.PixelFormat))
									{
										bitmap2.Save(text2, ImageFormat.Png);
									}
									goto IL_EB;
								}
							}
							using (Bitmap bitmap3 = new Bitmap(Image.FromStream(memoryStream), 48, 48))
							{
								bitmap3.Save(text2, ImageFormat.Png);
							}
							IL_EB:;
						}
					}
					using (MemoryStream memoryStream2 = new MemoryStream(File.ReadAllBytes(text2)))
					{
						this.gclass32_0.gclass86_2.Image = Image.FromStream(memoryStream2);
						Class95.smethod_1(this.gclass32_0, 8, this.class184_0.class183_0.nusGrabberForm_0.lstGames.ListViewElement.BackColor);
					}
					Control nusGrabberForm_ = this.class184_0.class183_0.nusGrabberForm_0;
					Action method;
					if ((method = this.action_0) == null)
					{
						method = (this.action_0 = new Action(this.method_2));
					}
					nusGrabberForm_.Invoke(method);
				}
				catch
				{
				}
				int int_ = this.class184_0.class183_0.int_0;
				this.class184_0.class183_0.int_0 = int_ - 1;
			}

			// Token: 0x06000DF7 RID: 3575 RVA: 0x000197E4 File Offset: 0x000179E4
			internal void method_2()
			{
				this.class184_0.listViewDataItem_0.Image = this.gclass32_0.gclass86_2.Image;
			}

			// Token: 0x04000A18 RID: 2584
			public GClass32 gclass32_0;

			// Token: 0x04000A19 RID: 2585
			public NusGrabberForm.Class184 class184_0;

			// Token: 0x04000A1A RID: 2586
			public Action action_0;
		}

		// Token: 0x020001EF RID: 495
		[CompilerGenerated]
		private sealed class Class186
		{
			// Token: 0x06000DF9 RID: 3577 RVA: 0x000660C8 File Offset: 0x000642C8
			internal void method_0()
			{
				try
				{
					this.nusGrabberForm_0.NUSGrabberProgress.Value1 = this.geventArgs0_0.GameProgress;
					this.nusGrabberForm_0.totalProgress.Value1 = this.geventArgs0_0.TotalProgress;
					TaskbarManager.Instance.SetProgressValue(this.geventArgs0_0.TotalProgress, 100);
					Class95.smethod_17(this.geventArgs0_0.GameEta, this.nusGrabberForm_0.lblEta);
					Class95.smethod_17(this.geventArgs0_0.TotalEta, this.nusGrabberForm_0.lblTotalEta);
					Class95.smethod_17(this.geventArgs0_0.FileEta, this.nusGrabberForm_0.lblFileEta);
					this.nusGrabberForm_0.pgFile.Value1 = this.geventArgs0_0.FileProgress;
					try
					{
						if (Settings.Default.ShowSpeedGraph)
						{
							DateTime now = DateTime.Now;
							if (this.nusGrabberForm_0.chartValues_0.Count == 0 || (DateTime.Now - this.nusGrabberForm_0.chartValues_0.Last<GClass125>().DateTime).TotalMilliseconds >= 1500.0)
							{
								this.nusGrabberForm_0.chartValues_0.Add(new GClass125
								{
									DateTime = now,
									Speed = (double)(this.geventArgs0_0.Speed.ulong_0 / 1000000f)
								});
								this.nusGrabberForm_0.method_36(now);
								if (this.nusGrabberForm_0.chartValues_0.Count > 100)
								{
									this.nusGrabberForm_0.chartValues_0.RemoveAt(0);
								}
								this.nusGrabberForm_0.radLiveSpeed.Text = string.Format("Live Speed : {0}", this.geventArgs0_0.Speed);
							}
						}
					}
					catch
					{
					}
					this.nusGrabberForm_0.gaugeSpeed.Value = this.geventArgs0_0.Speed.ulong_0 * 8UL / 1000000f;
					this.nusGrabberForm_0.lblSpeed.Text = this.geventArgs0_0.Speed.ToString();
				}
				catch
				{
				}
			}

			// Token: 0x04000A1B RID: 2587
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A1C RID: 2588
			public GEventArgs0 geventArgs0_0;
		}

		// Token: 0x020001F0 RID: 496
		[CompilerGenerated]
		private sealed class Class187
		{
			// Token: 0x06000DFB RID: 3579 RVA: 0x00019806 File Offset: 0x00017A06
			internal DialogResult method_0()
			{
				return this.frmWait_0.ShowDialog();
			}

			// Token: 0x04000A1D RID: 2589
			public FrmWait frmWait_0;
		}

		// Token: 0x020001F1 RID: 497
		[CompilerGenerated]
		private sealed class Class188
		{
			// Token: 0x06000DFD RID: 3581 RVA: 0x00019813 File Offset: 0x00017A13
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Tag == this.gclass30_0;
			}

			// Token: 0x04000A1E RID: 2590
			public GClass30 gclass30_0;
		}

		// Token: 0x020001F2 RID: 498
		[CompilerGenerated]
		private sealed class Class189
		{
			// Token: 0x06000DFF RID: 3583 RVA: 0x00066314 File Offset: 0x00064514
			internal void method_0()
			{
				if (Settings.Default.TicketsPath != "")
				{
					this.byte_0 = new GClass78().method_4(Settings.Default.TicketsPath + "/json", 2);
				}
				if (Settings.Default.TicketsPath3DS != "")
				{
					this.byte_1 = new GClass78().method_4(Settings.Default.TicketsPath3DS + "/json", 2);
				}
			}

			// Token: 0x04000A1F RID: 2591
			public byte[] byte_0;

			// Token: 0x04000A20 RID: 2592
			public byte[] byte_1;
		}

		// Token: 0x020001F3 RID: 499
		[CompilerGenerated]
		private sealed class Class190
		{
			// Token: 0x06000E01 RID: 3585 RVA: 0x00066398 File Offset: 0x00064598
			internal bool method_0(string string_1)
			{
				NusGrabberForm.Class191 @class = new NusGrabberForm.Class191();
				@class.string_0 = string_1;
				return this.string_0.Any(new Func<string, bool>(@class.method_0));
			}

			// Token: 0x04000A21 RID: 2593
			public string[] string_0;
		}

		// Token: 0x020001F4 RID: 500
		[CompilerGenerated]
		private sealed class Class191
		{
			// Token: 0x06000E03 RID: 3587 RVA: 0x00019823 File Offset: 0x00017A23
			internal bool method_0(string string_1)
			{
				return string_1.Contains(this.string_0);
			}

			// Token: 0x04000A22 RID: 2594
			public string string_0;
		}

		// Token: 0x020001F5 RID: 501
		[CompilerGenerated]
		private sealed class Class192
		{
			// Token: 0x06000E05 RID: 3589 RVA: 0x000663CC File Offset: 0x000645CC
			internal void method_0()
			{
				this.nusGrabberForm_0.lstLog.Items.Add(string.Format("{0}: {1}", this.nusGrabberForm_0.lstLog.Items.Count + 1, this.string_0));
			}

			// Token: 0x04000A23 RID: 2595
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A24 RID: 2596
			public string string_0;
		}

		// Token: 0x020001F6 RID: 502
		[CompilerGenerated]
		private sealed class Class193
		{
			// Token: 0x06000E07 RID: 3591 RVA: 0x0006641C File Offset: 0x0006461C
			internal void method_0()
			{
				if ((DateTime.Now - this.nusGrabberForm_0.dateTime_0).TotalMilliseconds > 4000.0)
				{
					this.nusGrabberForm_0.gclass82_0 = null;
				}
				this.nusGrabberForm_0.lblStatus.Text = string.Format("{0}  (Disk Usage: {1})", (this.nusGrabberForm_0.gclass82_0 == null) ? "Powered by Willzor's wiiuusbhelper.com (No Wii U found, please launch Wii U USB Helper Transfer Tool)" : "Powered by Willzor's wiiuusbhelper.com (Connected to your Wii U!)", (this.ulong_0 > 0UL) ? new DataSize(this.ulong_0).ToString() : "Computing...");
			}

			// Token: 0x04000A25 RID: 2597
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A26 RID: 2598
			public ulong ulong_0;
		}

		// Token: 0x020001F7 RID: 503
		[CompilerGenerated]
		private sealed class Class194
		{
			// Token: 0x06000E09 RID: 3593 RVA: 0x000664BC File Offset: 0x000646BC
			internal void method_0()
			{
				ulong ulong_ = this.nusGrabberForm_0.ulong_1;
				try
				{
					string[] pictures = this.gclass14_0.Pictures;
					for (int i = 0; i < pictures.Length; i++)
					{
						NusGrabberForm.Class195 @class = new NusGrabberForm.Class195();
						@class.class194_0 = this;
						@class.string_0 = pictures[i];
						NusGrabberForm.Class196 class2 = new NusGrabberForm.Class196();
						class2.class195_0 = @class;
						class2.image_0 = Image.FromStream(new MemoryStream(new WebClient().DownloadData(class2.class195_0.string_0))).smethod_1(200, 200);
						if (ulong_ != this.nusGrabberForm_0.ulong_1)
						{
							break;
						}
						this.nusGrabberForm_0.Invoke(new MethodInvoker(class2.method_0));
					}
				}
				catch
				{
				}
			}

			// Token: 0x04000A27 RID: 2599
			public NusGrabberForm nusGrabberForm_0;

			// Token: 0x04000A28 RID: 2600
			public GClass14 gclass14_0;
		}

		// Token: 0x020001F8 RID: 504
		[CompilerGenerated]
		private sealed class Class195
		{
			// Token: 0x06000E0B RID: 3595 RVA: 0x00019831 File Offset: 0x00017A31
			internal void method_0(object sender, MouseEventArgs e)
			{
				if (e.Button == MouseButtons.Right)
				{
					new FrmImgPreview(this.string_0).ShowDialog();
				}
			}

			// Token: 0x04000A29 RID: 2601
			public string string_0;

			// Token: 0x04000A2A RID: 2602
			public NusGrabberForm.Class194 class194_0;
		}

		// Token: 0x020001F9 RID: 505
		[CompilerGenerated]
		private sealed class Class196
		{
			// Token: 0x06000E0D RID: 3597 RVA: 0x00066590 File Offset: 0x00064790
			internal void method_0()
			{
				RadButtonElement radButtonElement = new RadButtonElement
				{
					Image = this.image_0
				};
				radButtonElement.MouseDown += this.class195_0.method_0;
				this.class195_0.class194_0.nusGrabberForm_0.modPreview.Items.Add(radButtonElement);
			}

			// Token: 0x04000A2B RID: 2603
			public Image image_0;

			// Token: 0x04000A2C RID: 2604
			public NusGrabberForm.Class195 class195_0;
		}

		// Token: 0x020001FA RID: 506
		[CompilerGenerated]
		private sealed class Class197
		{
			// Token: 0x06000E0F RID: 3599 RVA: 0x00019851 File Offset: 0x00017A51
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Text == this.string_0;
			}

			// Token: 0x04000A2D RID: 2605
			public string string_0;
		}
	}
}

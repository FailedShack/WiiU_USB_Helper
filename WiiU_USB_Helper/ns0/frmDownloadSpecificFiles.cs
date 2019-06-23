using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using NusHelper;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000177 RID: 375
	public partial class frmDownloadSpecificFiles : RadForm
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x0003DA6C File Offset: 0x0003BC6C
		public frmDownloadSpecificFiles(GClass32 gclass32_1)
		{
			frmDownloadSpecificFiles.Class130 @class = new frmDownloadSpecificFiles.Class130();
			@class.gclass32_0 = gclass32_1;
			base..ctor();
			@class.frmDownloadSpecificFiles_0 = this;
			this.InitializeComponent();
			this.gclass32_0 = @class.gclass32_0;
			if (this.gclass32_0.Boolean_0)
			{
				return;
			}
			if (@class.gclass32_0.System != GEnum3.const_1)
			{
				throw new Exception("This only works with WUP titles!");
			}
			this.lstNodesGame.TriStateMode = true;
			this.lstNodesDlc.TriStateMode = true;
			this.lstNodesUpdate.TriStateMode = true;
			this.lstNodesUpdate.Enabled = @class.gclass32_0.Boolean_3;
			this.lstNodesDlc.Enabled = @class.gclass32_0.Boolean_2;
			this.lstNodesGame.Enabled = !@class.gclass32_0.DiscOnly;
			new FrmWait("Please wait while USB Helper fetches data...", new Action(@class.method_0), new Action<Exception>(frmDownloadSpecificFiles.<>c.<>c_0.method_0));
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0003DB6C File Offset: 0x0003BD6C
		private void method_0(RadTreeView radTreeView_0, GClass30 gclass30_0, GClass13 gclass13_3, string string_0)
		{
			List<GClass12> list = new List<GClass12>();
			using (IEnumerator<RadTreeNode> enumerator = radTreeView_0.CheckedNodes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					frmDownloadSpecificFiles.Class131 @class = new frmDownloadSpecificFiles.Class131();
					@class.radTreeNode_0 = enumerator.Current;
					list.Add(gclass13_3.Files.Find(new Predicate<GClass12>(@class.method_0)));
				}
			}
			if (list.Count > 0)
			{
				gclass30_0.method_16(string_0, true, true, list, false);
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00017B21 File Offset: 0x00015D21
		private void frmDownloadSpecificFiles_Load(object sender, EventArgs e)
		{
			if (this.gclass32_0.Boolean_0)
			{
				RadMessageBox.Show("This feature is not compatible with this title.");
				base.Close();
				return;
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00017B42 File Offset: 0x00015D42
		private void lstNodesDlc_NodeMouseClick(object sender, RadTreeViewEventArgs e)
		{
			this.method_1(e.Node, this.gclass13_0, this.class7_0);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00017B5C File Offset: 0x00015D5C
		private void lstNodesGame_NodeMouseClick(object sender, RadTreeViewEventArgs e)
		{
			this.method_1(e.Node, this.gclass13_1, this.class7_1);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00017B76 File Offset: 0x00015D76
		private void lstNodesUpdate_NodeMouseClick(object sender, RadTreeViewEventArgs e)
		{
			this.method_1(e.Node, this.gclass13_2, this.class7_2);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0003DBF8 File Offset: 0x0003BDF8
		private void radButton1_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
			{
				IsFolderPicker = true,
				Title = "Please chose where to download your files."
			};
			if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
			{
				if (this.lstNodesGame.Enabled)
				{
					this.method_0(this.lstNodesGame, this.gclass32_0, this.gclass13_1, commonOpenFileDialog.FileName);
				}
				if (this.lstNodesUpdate.Enabled)
				{
					this.method_0(this.lstNodesUpdate, this.gclass32_0.Updates.Last<GClass33>(), this.gclass13_2, commonOpenFileDialog.FileName);
				}
				if (this.lstNodesDlc.Enabled)
				{
					this.method_0(this.lstNodesDlc, this.gclass32_0.Dlc, this.gclass13_0, commonOpenFileDialog.FileName);
				}
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0003DCBC File Offset: 0x0003BEBC
		private void method_1(RadTreeNode radTreeNode_0, GClass13 gclass13_3, Class7 class7_3)
		{
			frmDownloadSpecificFiles.Class132 @class = new frmDownloadSpecificFiles.Class132();
			@class.radTreeNode_0 = radTreeNode_0;
			@class.frmDownloadSpecificFiles_0 = this;
			@class.class7_0 = class7_3;
			this.lblFullPath.Text = @class.radTreeNode_0.FullPath;
			this.grpPreview.Controls.Clear();
			if (@class.radTreeNode_0.Nodes.Count == 0)
			{
				frmDownloadSpecificFiles.Class133 class2 = new frmDownloadSpecificFiles.Class133();
				class2.class132_0 = @class;
				class2.gclass12_0 = gclass13_3.Files.Find(new Predicate<GClass12>(class2.class132_0.method_0));
				this.lblSize.Text = new DataSize((ulong)class2.gclass12_0.uint_2).ToString();
				Task.Run(new Action(class2.method_0));
				return;
			}
			this.lblSize.Text = "";
		}

		// Token: 0x0400062D RID: 1581
		private readonly GClass32 gclass32_0;

		// Token: 0x0400062E RID: 1582
		private GClass13 gclass13_0;

		// Token: 0x0400062F RID: 1583
		private Class7 class7_0;

		// Token: 0x04000630 RID: 1584
		private GClass13 gclass13_1;

		// Token: 0x04000631 RID: 1585
		private Class7 class7_1;

		// Token: 0x04000632 RID: 1586
		private GClass13 gclass13_2;

		// Token: 0x04000633 RID: 1587
		private Class7 class7_2;

		// Token: 0x02000178 RID: 376
		[CompilerGenerated]
		private sealed class Class130
		{
			// Token: 0x06000AED RID: 2797 RVA: 0x0003E7FC File Offset: 0x0003C9FC
			internal void method_0()
			{
				if (!this.gclass32_0.DiscOnly)
				{
					this.frmDownloadSpecificFiles_0.gclass13_1 = this.gclass32_0.method_15();
					this.frmDownloadSpecificFiles_0.class7_1 = new Class7(this.gclass32_0);
					foreach (GClass12 gclass in this.frmDownloadSpecificFiles_0.gclass13_1.Files)
					{
						this.frmDownloadSpecificFiles_0.lstNodesGame.AddNodeByPath(gclass.string_0);
					}
				}
				if (this.gclass32_0.Boolean_3)
				{
					this.frmDownloadSpecificFiles_0.gclass13_2 = this.gclass32_0.Updates.Last<GClass33>().method_15();
					this.frmDownloadSpecificFiles_0.class7_2 = new Class7(this.gclass32_0.Updates.Last<GClass33>());
					foreach (GClass12 gclass2 in this.frmDownloadSpecificFiles_0.gclass13_2.Files)
					{
						this.frmDownloadSpecificFiles_0.lstNodesUpdate.AddNodeByPath(gclass2.string_0);
					}
				}
				if (this.gclass32_0.Boolean_2)
				{
					this.frmDownloadSpecificFiles_0.gclass13_0 = this.gclass32_0.Dlc.method_15();
					this.frmDownloadSpecificFiles_0.class7_0 = new Class7(this.gclass32_0.Dlc);
					foreach (GClass12 gclass3 in this.frmDownloadSpecificFiles_0.gclass13_0.Files)
					{
						this.frmDownloadSpecificFiles_0.lstNodesDlc.AddNodeByPath(gclass3.string_0);
					}
				}
			}

			// Token: 0x04000643 RID: 1603
			public GClass32 gclass32_0;

			// Token: 0x04000644 RID: 1604
			public frmDownloadSpecificFiles frmDownloadSpecificFiles_0;
		}

		// Token: 0x0200017A RID: 378
		[CompilerGenerated]
		private sealed class Class131
		{
			// Token: 0x06000AF2 RID: 2802 RVA: 0x00017BBB File Offset: 0x00015DBB
			internal bool method_0(GClass12 gclass12_0)
			{
				return gclass12_0.string_0 == this.radTreeNode_0.FullPath;
			}

			// Token: 0x04000647 RID: 1607
			public RadTreeNode radTreeNode_0;
		}

		// Token: 0x0200017B RID: 379
		[CompilerGenerated]
		private sealed class Class132
		{
			// Token: 0x06000AF4 RID: 2804 RVA: 0x00017BD3 File Offset: 0x00015DD3
			internal bool method_0(GClass12 gclass12_0)
			{
				return gclass12_0.string_0 == this.radTreeNode_0.FullPath;
			}

			// Token: 0x04000648 RID: 1608
			public RadTreeNode radTreeNode_0;

			// Token: 0x04000649 RID: 1609
			public frmDownloadSpecificFiles frmDownloadSpecificFiles_0;

			// Token: 0x0400064A RID: 1610
			public Class7 class7_0;
		}

		// Token: 0x0200017C RID: 380
		[CompilerGenerated]
		private sealed class Class133
		{
			// Token: 0x06000AF6 RID: 2806 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
			internal void method_0()
			{
				try
				{
					if (new string[]
					{
						".txt",
						".json",
						".ini",
						".xml"
					}.Contains(Path.GetExtension(this.gclass12_0.string_0)))
					{
						frmDownloadSpecificFiles.Class134 @class = new frmDownloadSpecificFiles.Class134();
						@class.class133_0 = this;
						this.class132_0.frmDownloadSpecificFiles_0.grpPreview.Text = "File preview";
						@class.radTextBoxControl_0 = new RadTextBoxControl();
						@class.radTextBoxControl_0.Dock = DockStyle.Fill;
						@class.radTextBoxControl_0.IsReadOnly = true;
						@class.radTextBoxControl_0.Multiline = true;
						@class.byte_0 = this.class132_0.class7_0.method_0(this.gclass12_0, 0UL);
						this.class132_0.frmDownloadSpecificFiles_0.Invoke(new MethodInvoker(@class.method_0));
					}
					else
					{
						frmDownloadSpecificFiles.Class135 class2 = new frmDownloadSpecificFiles.Class135();
						class2.class133_0 = this;
						this.class132_0.frmDownloadSpecificFiles_0.grpPreview.Text = "File preview (First 32768 bytes)";
						class2.byte_0 = this.class132_0.class7_0.method_0(this.gclass12_0, 32768UL);
						this.class132_0.frmDownloadSpecificFiles_0.Invoke(new MethodInvoker(class2.method_0));
					}
				}
				catch
				{
				}
			}

			// Token: 0x0400064B RID: 1611
			public GClass12 gclass12_0;

			// Token: 0x0400064C RID: 1612
			public frmDownloadSpecificFiles.Class132 class132_0;
		}

		// Token: 0x0200017D RID: 381
		[CompilerGenerated]
		private sealed class Class134
		{
			// Token: 0x06000AF8 RID: 2808 RVA: 0x0003EB5C File Offset: 0x0003CD5C
			internal void method_0()
			{
				try
				{
					this.radTextBoxControl_0.Text = Encoding.UTF8.GetString(this.byte_0);
					this.class133_0.class132_0.frmDownloadSpecificFiles_0.grpPreview.Controls.Add(this.radTextBoxControl_0);
				}
				catch
				{
				}
			}

			// Token: 0x0400064D RID: 1613
			public RadTextBoxControl radTextBoxControl_0;

			// Token: 0x0400064E RID: 1614
			public byte[] byte_0;

			// Token: 0x0400064F RID: 1615
			public frmDownloadSpecificFiles.Class133 class133_0;
		}

		// Token: 0x0200017E RID: 382
		[CompilerGenerated]
		private sealed class Class135
		{
			// Token: 0x06000AFA RID: 2810 RVA: 0x0003EBC0 File Offset: 0x0003CDC0
			internal void method_0()
			{
				try
				{
					HexBox hexBox = new HexBox
					{
						BackColor = Color.White,
						StringViewVisible = true,
						Dock = DockStyle.Fill,
						VScrollBarVisible = true,
						BytesPerLine = 16
					};
					hexBox.ByteProvider = new DynamicByteProvider(this.byte_0);
					this.class133_0.class132_0.frmDownloadSpecificFiles_0.grpPreview.Controls.Add(hexBox);
				}
				catch
				{
				}
			}

			// Token: 0x04000650 RID: 1616
			public byte[] byte_0;

			// Token: 0x04000651 RID: 1617
			public frmDownloadSpecificFiles.Class133 class133_0;
		}
	}
}

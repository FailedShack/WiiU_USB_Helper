using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x020001B7 RID: 439
	public partial class FrmAskTicket : RadForm
	{
		// Token: 0x06000C20 RID: 3104 RVA: 0x0001892D File Offset: 0x00016B2D
		public FrmAskTicket()
		{
			this.InitializeComponent();
			Class95.smethod_11(this, 10);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00018964 File Offset: 0x00016B64
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x0001896C File Offset: 0x00016B6C
		public string FileLocation3DS { get; set; } = "";

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00018975 File Offset: 0x00016B75
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0001897D File Offset: 0x00016B7D
		public string FileLocationWii { get; set; } = "";

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00018986 File Offset: 0x00016B86
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0001898E File Offset: 0x00016B8E
		public string FileLocationWiiU { get; set; } = "";

		// Token: 0x06000C27 RID: 3111 RVA: 0x0004B8A4 File Offset: 0x00049AA4
		private void cmdSavelink_Click(object sender, EventArgs e)
		{
			this.txtUrl.Text = this.txtUrl.Text.Trim();
			if (this.txtUrl.Text.Contains("wiiu.titlekeys.com"))
			{
				RadMessageBox.Show("This textbox is not meant to be used with this site. Please look below.");
				this.txtUrl.Text = "";
				return;
			}
			GClass78 gclass = new GClass78();
			try
			{
				gclass.method_2(this.txtUrl.Text);
				this.FileLocationWiiU = this.txtUrl.Text;
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			catch
			{
				RadMessageBox.Show("Sorry but the link you have provided seems invalid.");
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000142A3 File Offset: 0x000124A3
		private void FrmAskTicket_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0004B958 File Offset: 0x00049B58
		private void radButton1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				CheckFileExists = true,
				Multiselect = false,
				Filter = "RAR Archive (*.rar)|*.rar"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				base.DialogResult = DialogResult.OK;
				this.FileLocationWiiU = openFileDialog.FileName;
				base.Close();
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0004B9A8 File Offset: 0x00049BA8
		private void radButton2_Click(object sender, EventArgs e)
		{
			if (this.radTextBox1.Text.Contains("wiiu.titlekeys"))
			{
				this.FileLocationWiiU = "http://wiiu.titlekeys.gq/";
			}
			if (this.radTextBox2.Text.Contains("3ds.titlekeys"))
			{
				this.FileLocation3DS = "http://3ds.titlekeys.gq/";
			}
			if (this.radTextBox3.Text.Contains("wii.titlekeys"))
			{
				this.FileLocationWii = "http://wii.titlekeys.gq/";
			}
			if (!(this.FileLocation3DS != "") && !(this.FileLocationWiiU != "") && !(this.FileLocationWii != ""))
			{
				RadMessageBox.Show("The urls you have specified appear to be incorrect. Please check them.");
				return;
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0004BA6C File Offset: 0x00049C6C
		private void radGroupBox1_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (File.Exists(array[0]))
			{
				base.DialogResult = DialogResult.OK;
				this.FileLocationWiiU = array[0];
				base.Close();
				return;
			}
			RadMessageBox.Show("Sorry but the path you have provided seems invalid.");
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00018997 File Offset: 0x00016B97
		private void radGroupBox1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None);
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000142A3 File Offset: 0x000124A3
		private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000142A3 File Offset: 0x000124A3
		private void radPageViewPage1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000142A3 File Offset: 0x000124A3
		private void radTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040007A1 RID: 1953
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040007A2 RID: 1954
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040007A3 RID: 1955
		[CompilerGenerated]
		private string string_2;
	}
}

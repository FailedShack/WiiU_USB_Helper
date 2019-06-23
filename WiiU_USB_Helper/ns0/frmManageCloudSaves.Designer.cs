namespace ns0
{
	// Token: 0x020001A0 RID: 416
	public partial class frmManageCloudSaves : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001832F File Offset: 0x0001652F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00045938 File Offset: 0x00043B38
		private void InitializeComponent()
		{
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Game");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Date");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Size");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmManageCloudSaves));
			this.lstSaves = new global::Telerik.WinControls.UI.RadListView();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdDelete = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.lstSaves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDelete).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.lstSaves.AllowEdit = false;
			this.lstSaves.AllowRemove = false;
			listViewDetailColumn.HeaderText = "Game";
			listViewDetailColumn.Width = 400f;
			listViewDetailColumn2.HeaderText = "Date";
			listViewDetailColumn3.HeaderText = "Size";
			this.lstSaves.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn,
				listViewDetailColumn2,
				listViewDetailColumn3
			});
			this.lstSaves.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstSaves.ItemSpacing = -1;
			this.lstSaves.Location = new global::System.Drawing.Point(0, 0);
			this.lstSaves.Name = "lstSaves";
			this.lstSaves.Size = new global::System.Drawing.Size(808, 482);
			this.lstSaves.TabIndex = 0;
			this.lstSaves.Text = "radListView1";
			this.lstSaves.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.lstSaves.SelectedItemChanged += new global::System.EventHandler(this.lstSaves_SelectedItemChanged);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.cmdDelete);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox1.HeaderText = "Actions";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 482);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(808, 57);
			this.radGroupBox1.TabIndex = 0;
			this.radGroupBox1.Text = "Actions";
			this.cmdDelete.Location = new global::System.Drawing.Point(5, 28);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new global::System.Drawing.Size(177, 24);
			this.cmdDelete.TabIndex = 0;
			this.cmdDelete.Text = "Delete the save from the cloud";
			this.cmdDelete.Click += new global::System.EventHandler(this.cmdDelete_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(808, 539);
			base.Controls.Add(this.lstSaves);
			base.Controls.Add(this.radGroupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmManageCloudSaves";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage my saves";
			((global::System.ComponentModel.ISupportInitialize)this.lstSaves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdDelete).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000701 RID: 1793
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000702 RID: 1794
		private global::Telerik.WinControls.UI.RadListView lstSaves;

		// Token: 0x04000703 RID: 1795
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x04000704 RID: 1796
		private global::Telerik.WinControls.UI.RadButton cmdDelete;
	}
}

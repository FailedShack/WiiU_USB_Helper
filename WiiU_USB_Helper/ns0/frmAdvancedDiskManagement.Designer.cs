namespace ns0
{
	// Token: 0x0200016A RID: 362
	public partial class frmAdvancedDiskManagement : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x00017889 File Offset: 0x00015A89
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003B148 File Offset: 0x00039348
		private void InitializeComponent()
		{
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Title");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Size on disk");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Title");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Size on disk");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmAdvancedDiskManagement));
			this.lstTitles = new global::Telerik.WinControls.UI.RadListView();
			this.cmdDelete = new global::Telerik.WinControls.UI.RadButton();
			this.lstEmuTitles = new global::Telerik.WinControls.UI.RadListView();
			this.cmdDeleteEmu = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radSplitContainer1 = new global::Telerik.WinControls.UI.RadSplitContainer();
			this.splitPanel1 = new global::Telerik.WinControls.UI.SplitPanel();
			this.radGroupBox2 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.lblTotalRaw = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.splitPanel2 = new global::Telerik.WinControls.UI.SplitPanel();
			this.radGroupBox3 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblTotalEmu = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.lstTitles).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDelete).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstEmuTitles).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteEmu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer1).BeginInit();
			this.radSplitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel1).BeginInit();
			this.splitPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).BeginInit();
			this.radGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalRaw).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel2).BeginInit();
			this.splitPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).BeginInit();
			this.radGroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalEmu).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			listViewDetailColumn.HeaderText = "Title";
			listViewDetailColumn.Width = 400f;
			listViewDetailColumn2.HeaderText = "Size on disk";
			this.lstTitles.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn,
				listViewDetailColumn2
			});
			this.lstTitles.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstTitles.ItemSpacing = -1;
			this.lstTitles.Location = new global::System.Drawing.Point(2, 120);
			this.lstTitles.Name = "lstTitles";
			this.lstTitles.ShowGridLines = true;
			this.lstTitles.Size = new global::System.Drawing.Size(726, 614);
			this.lstTitles.TabIndex = 1;
			this.lstTitles.Text = "radListView1";
			this.lstTitles.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.lstTitles.ItemRemoving += new global::Telerik.WinControls.UI.ListViewItemCancelEventHandler(this.lstTitles_ItemRemoving);
			this.cmdDelete.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdDelete.Location = new global::System.Drawing.Point(2, 764);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new global::System.Drawing.Size(726, 24);
			this.cmdDelete.TabIndex = 2;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.Click += new global::System.EventHandler(this.cmdDelete_Click);
			this.lstEmuTitles.AllowEdit = false;
			listViewDetailColumn3.HeaderText = "Title";
			listViewDetailColumn3.Width = 400f;
			listViewDetailColumn4.HeaderText = "Size on disk";
			this.lstEmuTitles.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn3,
				listViewDetailColumn4
			});
			this.lstEmuTitles.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstEmuTitles.ItemSpacing = -1;
			this.lstEmuTitles.Location = new global::System.Drawing.Point(2, 120);
			this.lstEmuTitles.Name = "lstEmuTitles";
			this.lstEmuTitles.ShowGridLines = true;
			this.lstEmuTitles.Size = new global::System.Drawing.Size(726, 614);
			this.lstEmuTitles.TabIndex = 3;
			this.lstEmuTitles.Text = "radListView1";
			this.lstEmuTitles.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.lstEmuTitles.ItemRemoving += new global::Telerik.WinControls.UI.ListViewItemCancelEventHandler(this.lstEmuTitles_ItemRemoving);
			this.cmdDeleteEmu.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdDeleteEmu.Location = new global::System.Drawing.Point(2, 764);
			this.cmdDeleteEmu.Name = "cmdDeleteEmu";
			this.cmdDeleteEmu.Size = new global::System.Drawing.Size(726, 24);
			this.cmdDeleteEmu.TabIndex = 3;
			this.cmdDeleteEmu.Text = "Delete";
			this.cmdDeleteEmu.Click += new global::System.EventHandler(this.cmdDeleteEmu_Click);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.radSplitContainer1);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox1.HeaderText = "Manage Data";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Padding = new global::System.Windows.Forms.Padding(20);
			this.radGroupBox1.Size = new global::System.Drawing.Size(1504, 830);
			this.radGroupBox1.TabIndex = 5;
			this.radGroupBox1.Text = "Manage Data";
			this.radSplitContainer1.Controls.Add(this.splitPanel1);
			this.radSplitContainer1.Controls.Add(this.splitPanel2);
			this.radSplitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radSplitContainer1.Location = new global::System.Drawing.Point(20, 20);
			this.radSplitContainer1.Name = "radSplitContainer1";
			this.radSplitContainer1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.radSplitContainer1.Size = new global::System.Drawing.Size(1464, 790);
			this.radSplitContainer1.TabIndex = 7;
			this.radSplitContainer1.TabStop = false;
			this.radSplitContainer1.Text = "radSplitContainer1";
			this.splitPanel1.Controls.Add(this.radGroupBox2);
			this.splitPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.splitPanel1.Name = "splitPanel1";
			this.splitPanel1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.splitPanel1.Size = new global::System.Drawing.Size(730, 790);
			this.splitPanel1.TabIndex = 0;
			this.splitPanel1.TabStop = false;
			this.splitPanel1.Text = "splitPanel1";
			this.radGroupBox2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox2.Controls.Add(this.radButton1);
			this.radGroupBox2.Controls.Add(this.lstTitles);
			this.radGroupBox2.Controls.Add(this.lblTotalRaw);
			this.radGroupBox2.Controls.Add(this.cmdDelete);
			this.radGroupBox2.Controls.Add(this.radLabel1);
			this.radGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox2.HeaderText = "Raw content";
			this.radGroupBox2.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox2.Name = "radGroupBox2";
			this.radGroupBox2.Size = new global::System.Drawing.Size(730, 790);
			this.radGroupBox2.TabIndex = 6;
			this.radGroupBox2.Text = "Raw content";
			this.radButton1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radButton1.Location = new global::System.Drawing.Point(2, 710);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(726, 24);
			this.radButton1.TabIndex = 4;
			this.radButton1.Text = "Delete all useless data";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.lblTotalRaw.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblTotalRaw.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTotalRaw.Location = new global::System.Drawing.Point(2, 734);
			this.lblTotalRaw.Name = "lblTotalRaw";
			this.lblTotalRaw.Size = new global::System.Drawing.Size(17, 30);
			this.lblTotalRaw.TabIndex = 3;
			this.lblTotalRaw.Text = "-";
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel1.Location = new global::System.Drawing.Point(2, 18);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Padding = new global::System.Windows.Forms.Padding(20, 0, 0, 0);
			this.radLabel1.Size = new global::System.Drawing.Size(726, 102);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.splitPanel2.Controls.Add(this.radGroupBox3);
			this.splitPanel2.Location = new global::System.Drawing.Point(734, 0);
			this.splitPanel2.Name = "splitPanel2";
			this.splitPanel2.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.splitPanel2.Size = new global::System.Drawing.Size(730, 790);
			this.splitPanel2.TabIndex = 1;
			this.splitPanel2.TabStop = false;
			this.splitPanel2.Text = "splitPanel2";
			this.radGroupBox3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox3.Controls.Add(this.lstEmuTitles);
			this.radGroupBox3.Controls.Add(this.lblTotalEmu);
			this.radGroupBox3.Controls.Add(this.radLabel2);
			this.radGroupBox3.Controls.Add(this.cmdDeleteEmu);
			this.radGroupBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox3.HeaderText = "Emulation Content";
			this.radGroupBox3.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox3.Name = "radGroupBox3";
			this.radGroupBox3.Size = new global::System.Drawing.Size(730, 790);
			this.radGroupBox3.TabIndex = 6;
			this.radGroupBox3.Text = "Emulation Content";
			this.lblTotalEmu.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblTotalEmu.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTotalEmu.Location = new global::System.Drawing.Point(2, 734);
			this.lblTotalEmu.Name = "lblTotalEmu";
			this.lblTotalEmu.Size = new global::System.Drawing.Size(17, 30);
			this.lblTotalEmu.TabIndex = 4;
			this.lblTotalEmu.Text = "-";
			this.radLabel2.AutoSize = false;
			this.radLabel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel2.Location = new global::System.Drawing.Point(2, 18);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Padding = new global::System.Windows.Forms.Padding(20, 0, 0, 0);
			this.radLabel2.Size = new global::System.Drawing.Size(726, 102);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "<html><p>We call 'Emulation' content files that have been unpacked/decrypted/converted from the RAW files.</p><p>This is the format emulators can use to play games.</p><p></p></html>";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1504, 830);
			base.Controls.Add(this.radGroupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmAdvancedDiskManagement";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Advanced Disk Space Manager";
			((global::System.ComponentModel.ISupportInitialize)this.lstTitles).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDelete).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstEmuTitles).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteEmu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer1).EndInit();
			this.radSplitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel1).EndInit();
			this.splitPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).EndInit();
			this.radGroupBox2.ResumeLayout(false);
			this.radGroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalRaw).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel2).EndInit();
			this.splitPanel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).EndInit();
			this.radGroupBox3.ResumeLayout(false);
			this.radGroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblTotalEmu).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040005EE RID: 1518
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040005EF RID: 1519
		private global::Telerik.WinControls.UI.RadListView lstTitles;

		// Token: 0x040005F0 RID: 1520
		private global::Telerik.WinControls.UI.RadButton cmdDelete;

		// Token: 0x040005F1 RID: 1521
		private global::Telerik.WinControls.UI.RadListView lstEmuTitles;

		// Token: 0x040005F2 RID: 1522
		private global::Telerik.WinControls.UI.RadButton cmdDeleteEmu;

		// Token: 0x040005F3 RID: 1523
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x040005F4 RID: 1524
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox3;

		// Token: 0x040005F5 RID: 1525
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x040005F6 RID: 1526
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox2;

		// Token: 0x040005F7 RID: 1527
		private global::Telerik.WinControls.UI.RadLabel lblTotalRaw;

		// Token: 0x040005F8 RID: 1528
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040005F9 RID: 1529
		private global::Telerik.WinControls.UI.RadLabel lblTotalEmu;

		// Token: 0x040005FA RID: 1530
		private global::Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;

		// Token: 0x040005FB RID: 1531
		private global::Telerik.WinControls.UI.SplitPanel splitPanel1;

		// Token: 0x040005FC RID: 1532
		private global::Telerik.WinControls.UI.SplitPanel splitPanel2;

		// Token: 0x040005FD RID: 1533
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}

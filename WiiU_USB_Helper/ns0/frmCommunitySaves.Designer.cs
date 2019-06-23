namespace ns0
{
	// Token: 0x02000174 RID: 372
	public partial class frmCommunitySaves : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x00017A95 File Offset: 0x00015C95
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0003D1A4 File Offset: 0x0003B3A4
		private void InitializeComponent()
		{
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Description");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Date");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmCommunitySaves));
			this.lstSaves = new global::Telerik.WinControls.UI.RadListView();
			this.cmdUploadSave = new global::Telerik.WinControls.UI.RadButton();
			this.cmdImport = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblNoSaves = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.lstSaves).BeginInit();
			this.lstSaves.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdUploadSave).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImport).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblNoSaves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			listViewDetailColumn.HeaderText = "Description";
			listViewDetailColumn.Width = 600f;
			listViewDetailColumn2.HeaderText = "Date";
			this.lstSaves.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn,
				listViewDetailColumn2
			});
			this.lstSaves.Controls.Add(this.lblNoSaves);
			this.lstSaves.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstSaves.ItemSpacing = -1;
			this.lstSaves.Location = new global::System.Drawing.Point(0, 0);
			this.lstSaves.Name = "lstSaves";
			this.lstSaves.Size = new global::System.Drawing.Size(938, 404);
			this.lstSaves.TabIndex = 0;
			this.lstSaves.Text = "radListView1";
			this.lstSaves.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.cmdUploadSave.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdUploadSave.Image = global::ns0.Class121.icnWebMini;
			this.cmdUploadSave.Location = new global::System.Drawing.Point(482, 26);
			this.cmdUploadSave.Name = "cmdUploadSave";
			this.cmdUploadSave.Size = new global::System.Drawing.Size(203, 24);
			this.cmdUploadSave.TabIndex = 0;
			this.cmdUploadSave.Text = "Upload my own save";
			this.cmdUploadSave.Click += new global::System.EventHandler(this.cmdUploadSave_Click);
			this.cmdImport.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdImport.Image = global::ns0.Class121.icnDownloadedMini;
			this.cmdImport.Location = new global::System.Drawing.Point(253, 26);
			this.cmdImport.Name = "cmdImport";
			this.cmdImport.Size = new global::System.Drawing.Size(200, 24);
			this.cmdImport.TabIndex = 1;
			this.cmdImport.Text = "Import this save";
			this.cmdImport.Click += new global::System.EventHandler(this.cmdImport_Click);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.cmdImport);
			this.radGroupBox1.Controls.Add(this.cmdUploadSave);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox1.HeaderText = "Options";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 404);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(938, 63);
			this.radGroupBox1.TabIndex = 1;
			this.radGroupBox1.Text = "Options";
			this.lblNoSaves.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblNoSaves.AutoSize = false;
			this.lblNoSaves.Location = new global::System.Drawing.Point(0, 0);
			this.lblNoSaves.Name = "lblNoSaves";
			this.lblNoSaves.Size = new global::System.Drawing.Size(938, 404);
			this.lblNoSaves.TabIndex = 0;
			this.lblNoSaves.Text = "No saves are available at the moment, why not share your own?";
			this.lblNoSaves.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(938, 467);
			base.Controls.Add(this.lstSaves);
			base.Controls.Add(this.radGroupBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmCommunitySaves";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Community Saves";
			((global::System.ComponentModel.ISupportInitialize)this.lstSaves).EndInit();
			this.lstSaves.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.cmdUploadSave).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImport).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lblNoSaves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400061E RID: 1566
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400061F RID: 1567
		private global::Telerik.WinControls.UI.RadListView lstSaves;

		// Token: 0x04000620 RID: 1568
		private global::Telerik.WinControls.UI.RadButton cmdUploadSave;

		// Token: 0x04000621 RID: 1569
		private global::Telerik.WinControls.UI.RadButton cmdImport;

		// Token: 0x04000622 RID: 1570
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x04000623 RID: 1571
		private global::Telerik.WinControls.UI.RadLabel lblNoSaves;
	}
}

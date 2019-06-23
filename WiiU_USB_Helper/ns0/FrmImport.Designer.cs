namespace ns0
{
	// Token: 0x020001BD RID: 445
	public partial class FrmImport : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x00018A34 File Offset: 0x00016C34
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0004D99C File Offset: 0x0004BB9C
		private void InitializeComponent()
		{
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Title");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Status");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.FrmImport));
			this.lstTitles = new global::Telerik.WinControls.UI.RadCheckedListBox();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdImport = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radLabel6 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel5 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdCheckAll = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.lstTitles).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImport).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCheckAll).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.lstTitles.AllowRemove = false;
			listViewDetailColumn.HeaderText = "Title";
			listViewDetailColumn.Width = 500f;
			listViewDetailColumn2.HeaderText = "Status";
			listViewDetailColumn2.Width = 300f;
			this.lstTitles.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn,
				listViewDetailColumn2
			});
			this.lstTitles.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstTitles.ItemSpacing = -1;
			this.lstTitles.Location = new global::System.Drawing.Point(5, 95);
			this.lstTitles.Name = "lstTitles";
			this.lstTitles.Size = new global::System.Drawing.Size(836, 398);
			this.lstTitles.TabIndex = 1;
			this.lstTitles.Text = "\r\n";
			this.lstTitles.ThemeName = "VisualStudio2012Dark";
			this.lstTitles.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.radLabel1.Location = new global::System.Drawing.Point(188, 14);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(240, 18);
			this.radLabel1.TabIndex = 2;
			this.radLabel1.Text = "USB Helper has detected the following games. ";
			this.radLabel1.ThemeName = "VisualStudio2012Dark";
			this.radLabel2.Location = new global::System.Drawing.Point(255, 8);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(2, 2);
			this.radLabel2.TabIndex = 3;
			this.radLabel2.ThemeName = "VisualStudio2012Dark";
			this.cmdImport.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdImport.Location = new global::System.Drawing.Point(5, 519);
			this.cmdImport.Name = "cmdImport";
			this.cmdImport.Size = new global::System.Drawing.Size(836, 26);
			this.cmdImport.TabIndex = 5;
			this.cmdImport.Text = "Import";
			this.cmdImport.ThemeName = "VisualStudio2012Dark";
			this.cmdImport.Click += new global::System.EventHandler(this.cmdImport_Click);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.radLabel6);
			this.radGroupBox1.Controls.Add(this.radLabel5);
			this.radGroupBox1.Controls.Add(this.radLabel4);
			this.radGroupBox1.Controls.Add(this.radLabel3);
			this.radGroupBox1.Controls.Add(this.radLabel1);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox1.HeaderText = "Info";
			this.radGroupBox1.Location = new global::System.Drawing.Point(5, 5);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(836, 90);
			this.radGroupBox1.TabIndex = 6;
			this.radGroupBox1.Text = "Info";
			this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
			this.radLabel6.Location = new global::System.Drawing.Point(188, 31);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new global::System.Drawing.Size(323, 18);
			this.radLabel6.TabIndex = 4;
			this.radLabel6.Text = "This will only work with games which already appear in the app.";
			this.radLabel6.ThemeName = "VisualStudio2012Dark";
			this.radLabel5.Location = new global::System.Drawing.Point(189, 48);
			this.radLabel5.Name = "radLabel5";
			this.radLabel5.Size = new global::System.Drawing.Size(367, 18);
			this.radLabel5.TabIndex = 3;
			this.radLabel5.Text = "If you have tickets which are not available on that site, please post them.";
			this.radLabel5.ThemeName = "VisualStudio2012Dark";
			this.radLabel4.ForeColor = global::System.Drawing.Color.Red;
			this.radLabel4.Location = new global::System.Drawing.Point(188, 67);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(311, 18);
			this.radLabel4.TabIndex = 4;
			this.radLabel4.Text = "Caution, this will MOVE and RENAME the folders accordingly.";
			this.radLabel4.ThemeName = "VisualStudio2012Dark";
			this.radLabel3.Location = new global::System.Drawing.Point(424, 14);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(225, 18);
			this.radLabel3.TabIndex = 3;
			this.radLabel3.Text = " Please choose the ones you wish to import.";
			this.radLabel3.ThemeName = "VisualStudio2012Dark";
			this.cmdCheckAll.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdCheckAll.Location = new global::System.Drawing.Point(5, 493);
			this.cmdCheckAll.Name = "cmdCheckAll";
			this.cmdCheckAll.Size = new global::System.Drawing.Size(836, 26);
			this.cmdCheckAll.TabIndex = 6;
			this.cmdCheckAll.Text = "Select all";
			this.cmdCheckAll.ThemeName = "VisualStudio2012Dark";
			this.cmdCheckAll.Click += new global::System.EventHandler(this.cmdCheckAll_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(846, 550);
			base.Controls.Add(this.lstTitles);
			base.Controls.Add(this.cmdCheckAll);
			base.Controls.Add(this.cmdImport);
			base.Controls.Add(this.radGroupBox1);
			base.Controls.Add(this.radLabel2);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(479, 580);
			base.Name = "FrmImport";
			base.Padding = new global::System.Windows.Forms.Padding(5);
			base.RootElement.ApplyShapeToControl = true;
			base.RootElement.MaxSize = new global::System.Drawing.Size(0, 0);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Import games";
			base.ThemeName = "VisualStudio2012Dark";
			base.Load += new global::System.EventHandler(this.FrmImport_Load);
			((global::System.ComponentModel.ISupportInitialize)this.lstTitles).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImport).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCheckAll).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007E9 RID: 2025
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040007EA RID: 2026
		private global::Telerik.WinControls.UI.RadCheckedListBox lstTitles;

		// Token: 0x040007EB RID: 2027
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040007EC RID: 2028
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x040007ED RID: 2029
		private global::Telerik.WinControls.UI.RadButton cmdImport;

		// Token: 0x040007EE RID: 2030
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x040007EF RID: 2031
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x040007F0 RID: 2032
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x040007F1 RID: 2033
		private global::Telerik.WinControls.UI.RadButton cmdCheckAll;

		// Token: 0x040007F2 RID: 2034
		private global::Telerik.WinControls.UI.RadLabel radLabel6;

		// Token: 0x040007F3 RID: 2035
		private global::Telerik.WinControls.UI.RadLabel radLabel5;
	}
}

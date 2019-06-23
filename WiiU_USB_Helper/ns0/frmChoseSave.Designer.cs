namespace ns0
{
	// Token: 0x0200018E RID: 398
	public partial class frmChoseSave : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x00017EE3 File Offset: 0x000160E3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00042008 File Offset: 0x00040208
		private void InitializeComponent()
		{
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Date");
			global::Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new global::Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Description");
			this.lstSaves = new global::Telerik.WinControls.UI.RadCheckedListBox();
			this.cmdbackup = new global::Telerik.WinControls.UI.RadButton();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.lstSaves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdbackup).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			listViewDetailColumn.HeaderText = "Date";
			listViewDetailColumn2.HeaderText = "Description";
			listViewDetailColumn2.Width = 500f;
			this.lstSaves.Columns.AddRange(new global::Telerik.WinControls.UI.ListViewDetailColumn[]
			{
				listViewDetailColumn,
				listViewDetailColumn2
			});
			this.lstSaves.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstSaves.ItemSpacing = -1;
			this.lstSaves.Location = new global::System.Drawing.Point(0, 0);
			this.lstSaves.Name = "lstSaves";
			this.lstSaves.Size = new global::System.Drawing.Size(728, 362);
			this.lstSaves.TabIndex = 0;
			this.lstSaves.Text = "radCheckedListBox1";
			this.lstSaves.ViewType = global::Telerik.WinControls.UI.ListViewType.DetailsView;
			this.cmdbackup.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdbackup.Location = new global::System.Drawing.Point(0, 362);
			this.cmdbackup.Name = "cmdbackup";
			this.cmdbackup.Size = new global::System.Drawing.Size(728, 24);
			this.cmdbackup.TabIndex = 4;
			this.cmdbackup.Text = "Restore";
			this.cmdbackup.Click += new global::System.EventHandler(this.cmdbackup_Click);
			this.radButton1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radButton1.Location = new global::System.Drawing.Point(0, 386);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(728, 24);
			this.radButton1.TabIndex = 3;
			this.radButton1.Text = "Cancel";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(728, 410);
			base.Controls.Add(this.lstSaves);
			base.Controls.Add(this.cmdbackup);
			base.Controls.Add(this.radButton1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmChoseSave";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Chose a Save File";
			base.Load += new global::System.EventHandler(this.frmChoseSave_Load);
			((global::System.ComponentModel.ISupportInitialize)this.lstSaves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdbackup).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006A3 RID: 1699
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006A4 RID: 1700
		private global::Telerik.WinControls.UI.RadCheckedListBox lstSaves;

		// Token: 0x040006A5 RID: 1701
		private global::Telerik.WinControls.UI.RadButton cmdbackup;

		// Token: 0x040006A6 RID: 1702
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}

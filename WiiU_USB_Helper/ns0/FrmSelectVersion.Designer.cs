namespace ns0
{
	// Token: 0x020001C7 RID: 455
	internal partial class FrmSelectVersion : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C6C RID: 3180 RVA: 0x0004F334 File Offset: 0x0004D534
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.FrmSelectVersion));
			this._lstVersions = new global::Telerik.WinControls.UI.RadCheckedListBox();
			this._radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this._cmdImport = new global::Telerik.WinControls.UI.RadButton();
			this._radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this._radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this._cmdCheckAll = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this._lstVersions).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this._radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this._cmdImport).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this._radGroupBox1).BeginInit();
			this._radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this._radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this._cmdCheckAll).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this._lstVersions.AllowRemove = false;
			this._lstVersions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this._lstVersions.Location = new global::System.Drawing.Point(10, 46);
			this._lstVersions.Name = "_lstVersions";
			this._lstVersions.Size = new global::System.Drawing.Size(446, 337);
			this._lstVersions.TabIndex = 7;
			this._lstVersions.Text = "\r\n";
			this._lstVersions.ThemeName = "VisualStudio2012Dark";
			this._radLabel1.Location = new global::System.Drawing.Point(5, 14);
			this._radLabel1.Name = "_radLabel1";
			this._radLabel1.Size = new global::System.Drawing.Size(399, 18);
			this._radLabel1.TabIndex = 2;
			this._radLabel1.Text = "Please select the desired update versions. You usually only need the latest one.";
			this._radLabel1.ThemeName = "VisualStudio2012Dark";
			this._cmdImport.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this._cmdImport.Location = new global::System.Drawing.Point(10, 383);
			this._cmdImport.Name = "_cmdImport";
			this._cmdImport.Size = new global::System.Drawing.Size(446, 26);
			this._cmdImport.TabIndex = 9;
			this._cmdImport.Text = "Ok";
			this._cmdImport.ThemeName = "VisualStudio2012Dark";
			this._cmdImport.Click += new global::System.EventHandler(this._cmdImport_Click);
			this._radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this._radGroupBox1.Controls.Add(this._radLabel1);
			this._radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this._radGroupBox1.HeaderText = "Info";
			this._radGroupBox1.Location = new global::System.Drawing.Point(10, 10);
			this._radGroupBox1.Name = "_radGroupBox1";
			this._radGroupBox1.Size = new global::System.Drawing.Size(446, 36);
			this._radGroupBox1.TabIndex = 10;
			this._radGroupBox1.Text = "Info";
			this._radGroupBox1.ThemeName = "VisualStudio2012Dark";
			this._radLabel2.Location = new global::System.Drawing.Point(265, 18);
			this._radLabel2.Name = "_radLabel2";
			this._radLabel2.Size = new global::System.Drawing.Size(2, 2);
			this._radLabel2.TabIndex = 8;
			this._radLabel2.ThemeName = "VisualStudio2012Dark";
			this._cmdCheckAll.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this._cmdCheckAll.Location = new global::System.Drawing.Point(10, 409);
			this._cmdCheckAll.Name = "_cmdCheckAll";
			this._cmdCheckAll.Size = new global::System.Drawing.Size(446, 26);
			this._cmdCheckAll.TabIndex = 11;
			this._cmdCheckAll.Text = "Select all";
			this._cmdCheckAll.ThemeName = "VisualStudio2012Dark";
			this._cmdCheckAll.Click += new global::System.EventHandler(this._cmdCheckAll_Click);
			base.ClientSize = new global::System.Drawing.Size(466, 445);
			base.Controls.Add(this._lstVersions);
			base.Controls.Add(this._cmdImport);
			base.Controls.Add(this._radGroupBox1);
			base.Controls.Add(this._radLabel2);
			base.Controls.Add(this._cmdCheckAll);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FrmSelectVersion";
			base.Padding = new global::System.Windows.Forms.Padding(10);
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select versions";
			base.Load += new global::System.EventHandler(this.FrmSelectVersion_Load);
			((global::System.ComponentModel.ISupportInitialize)this._lstVersions).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this._radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this._cmdImport).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this._radGroupBox1).EndInit();
			this._radGroupBox1.ResumeLayout(false);
			this._radGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this._radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this._cmdCheckAll).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400081B RID: 2075
		private global::Telerik.WinControls.UI.RadButton _cmdCheckAll;

		// Token: 0x0400081C RID: 2076
		private global::Telerik.WinControls.UI.RadButton _cmdImport;

		// Token: 0x0400081D RID: 2077
		private global::Telerik.WinControls.UI.RadCheckedListBox _lstVersions;

		// Token: 0x0400081E RID: 2078
		private global::Telerik.WinControls.UI.RadGroupBox _radGroupBox1;

		// Token: 0x0400081F RID: 2079
		private global::Telerik.WinControls.UI.RadLabel _radLabel1;

		// Token: 0x04000820 RID: 2080
		private global::Telerik.WinControls.UI.RadLabel _radLabel2;
	}
}

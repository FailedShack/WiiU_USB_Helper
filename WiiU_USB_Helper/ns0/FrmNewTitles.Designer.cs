namespace ns0
{
	// Token: 0x020001C3 RID: 451
	public partial class FrmNewTitles : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C53 RID: 3155 RVA: 0x00018A8A File Offset: 0x00016C8A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.FrmNewTitles));
			this.cmdImport = new global::Telerik.WinControls.UI.RadButton();
			this.lblUpText = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdCheckAll = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.lstTitles = new global::Telerik.WinControls.UI.RadCheckedListBox();
			((global::System.ComponentModel.ISupportInitialize)this.cmdImport).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpText).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCheckAll).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstTitles).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.cmdImport.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdImport.Location = new global::System.Drawing.Point(10, 532);
			this.cmdImport.Name = "cmdImport";
			this.cmdImport.Size = new global::System.Drawing.Size(714, 26);
			this.cmdImport.TabIndex = 9;
			this.cmdImport.Text = "Add to the queue";
			this.cmdImport.ThemeName = "VisualStudio2012Dark";
			this.cmdImport.Click += new global::System.EventHandler(this.cmdImport_Click);
			this.lblUpText.AutoSize = false;
			this.lblUpText.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblUpText.Location = new global::System.Drawing.Point(2, 18);
			this.lblUpText.Name = "lblUpText";
			this.lblUpText.Size = new global::System.Drawing.Size(710, 19);
			this.lblUpText.TabIndex = 2;
			this.lblUpText.Text = "New titles have been added! Please choose the ones you wish to download.\r\n";
			this.lblUpText.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblUpText.ThemeName = "VisualStudio2012Dark";
			this.cmdCheckAll.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdCheckAll.Location = new global::System.Drawing.Point(10, 506);
			this.cmdCheckAll.Name = "cmdCheckAll";
			this.cmdCheckAll.Size = new global::System.Drawing.Size(714, 26);
			this.cmdCheckAll.TabIndex = 10;
			this.cmdCheckAll.Text = "Select all";
			this.cmdCheckAll.ThemeName = "VisualStudio2012Dark";
			this.cmdCheckAll.Click += new global::System.EventHandler(this.cmdCheckAll_Click);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.lblUpText);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox1.HeaderText = "Info";
			this.radGroupBox1.Location = new global::System.Drawing.Point(10, 10);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(714, 39);
			this.radGroupBox1.TabIndex = 11;
			this.radGroupBox1.Text = "Info";
			this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
			this.radGroupBox1.Click += new global::System.EventHandler(this.radGroupBox1_Click);
			this.radLabel2.Location = new global::System.Drawing.Point(260, 13);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(2, 2);
			this.radLabel2.TabIndex = 8;
			this.radLabel2.ThemeName = "VisualStudio2012Dark";
			this.lstTitles.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstTitles.Location = new global::System.Drawing.Point(10, 49);
			this.lstTitles.Name = "lstTitles";
			this.lstTitles.Size = new global::System.Drawing.Size(714, 457);
			this.lstTitles.TabIndex = 7;
			this.lstTitles.Text = "\r\n";
			this.lstTitles.ThemeName = "VisualStudio2012Dark";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(734, 568);
			base.Controls.Add(this.lstTitles);
			base.Controls.Add(this.cmdCheckAll);
			base.Controls.Add(this.cmdImport);
			base.Controls.Add(this.radGroupBox1);
			base.Controls.Add(this.radLabel2);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FrmNewTitles";
			base.Padding = new global::System.Windows.Forms.Padding(10);
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New titles available!";
			base.ThemeName = "VisualStudio2012Dark";
			base.Load += new global::System.EventHandler(this.FrmNewTitles_Load);
			((global::System.ComponentModel.ISupportInitialize)this.cmdImport).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpText).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdCheckAll).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstTitles).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000807 RID: 2055
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000808 RID: 2056
		private global::Telerik.WinControls.UI.RadButton cmdImport;

		// Token: 0x04000809 RID: 2057
		private global::Telerik.WinControls.UI.RadLabel lblUpText;

		// Token: 0x0400080A RID: 2058
		private global::Telerik.WinControls.UI.RadButton cmdCheckAll;

		// Token: 0x0400080B RID: 2059
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x0400080C RID: 2060
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x0400080D RID: 2061
		private global::Telerik.WinControls.UI.RadCheckedListBox lstTitles;
	}
}

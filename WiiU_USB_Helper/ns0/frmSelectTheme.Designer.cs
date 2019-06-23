namespace ns0
{
	// Token: 0x020001A8 RID: 424
	public partial class frmSelectTheme : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BCA RID: 3018 RVA: 0x00018592 File Offset: 0x00016792
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00046D78 File Offset: 0x00044F78
		private void InitializeComponent()
		{
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.lstThemes = new global::Telerik.WinControls.UI.RadListView();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstThemes).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.AutoSize = false;
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radLabel1.Location = new global::System.Drawing.Point(5, 5);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(328, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Please select a theme";
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lstThemes.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstThemes.Location = new global::System.Drawing.Point(5, 23);
			this.lstThemes.Name = "lstThemes";
			this.lstThemes.SelectLastAddedItem = false;
			this.lstThemes.Size = new global::System.Drawing.Size(328, 355);
			this.lstThemes.TabIndex = 1;
			this.lstThemes.Text = "radListView1";
			this.lstThemes.ItemMouseClick += new global::Telerik.WinControls.UI.ListViewItemEventHandler(this.lstThemes_ItemMouseClick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(338, 383);
			base.Controls.Add(this.lstThemes);
			base.Controls.Add(this.radLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmSelectTheme";
			base.Padding = new global::System.Windows.Forms.Padding(5);
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select a theme";
			base.Load += new global::System.EventHandler(this.frmSelectTheme_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstThemes).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000726 RID: 1830
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000727 RID: 1831
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000728 RID: 1832
		private global::Telerik.WinControls.UI.RadListView lstThemes;
	}
}

namespace ns0
{
	// Token: 0x020001D1 RID: 465
	public partial class FrmImgPreview : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00018CE6 File Offset: 0x00016EE6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00050CF8 File Offset: 0x0004EEF8
		private void InitializeComponent()
		{
			this.pbPreview = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.pbPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pbPreview.Location = new global::System.Drawing.Point(0, 0);
			this.pbPreview.MaximumSize = new global::System.Drawing.Size(1920, 1080);
			this.pbPreview.Name = "pbPreview";
			this.pbPreview.Size = new global::System.Drawing.Size(1272, 690);
			this.pbPreview.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbPreview.TabIndex = 0;
			this.pbPreview.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSize = true;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new global::System.Drawing.Size(1272, 690);
			base.Controls.Add(this.pbPreview);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new global::System.Drawing.Size(1920, 1080);
			base.Name = "FrmImgPreview";
			base.RootElement.ApplyShapeToControl = true;
			base.RootElement.MaxSize = new global::System.Drawing.Size(1920, 1080);
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Screenshot";
			base.ThemeName = "Desert";
			base.Load += new global::System.EventHandler(this.FrmImgPreview_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pbPreview).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400085A RID: 2138
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400085B RID: 2139
		private global::System.Windows.Forms.PictureBox pbPreview;
	}
}

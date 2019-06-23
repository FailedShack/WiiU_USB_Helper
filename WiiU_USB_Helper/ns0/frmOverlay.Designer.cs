namespace ns0
{
	// Token: 0x020001A4 RID: 420
	public partial class frmOverlay : global::ns0.GForm1
	{
		// Token: 0x06000BBA RID: 3002 RVA: 0x000184B9 File Offset: 0x000166B9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0004686C File Offset: 0x00044A6C
		private void InitializeComponent()
		{
			this.pBox = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pBox).BeginInit();
			base.SuspendLayout();
			this.pBox.Location = new global::System.Drawing.Point(92, 105);
			this.pBox.Name = "pBox";
			this.pBox.Size = new global::System.Drawing.Size(100, 50);
			this.pBox.TabIndex = 1;
			this.pBox.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 261);
			base.Controls.Add(this.pBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmOverlay";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmOverlay";
			((global::System.ComponentModel.ISupportInitialize)this.pBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000719 RID: 1817
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400071A RID: 1818
		private global::System.Windows.Forms.PictureBox pBox;
	}
}

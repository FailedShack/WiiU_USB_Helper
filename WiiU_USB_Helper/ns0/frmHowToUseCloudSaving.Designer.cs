namespace ns0
{
	// Token: 0x02000194 RID: 404
	public partial class frmHowToUseCloudSaving : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x000180A2 File Offset: 0x000162A2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00043604 File Offset: 0x00041804
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmHowToUseCloudSaving));
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackgroundImage = global::ns0.Class121.imgHowToUseCloudSaving;
			base.ClientSize = new global::System.Drawing.Size(1276, 720);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmHowToUseCloudSaving";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "How to use";
			base.ResumeLayout(false);
		}

		// Token: 0x040006C6 RID: 1734
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}

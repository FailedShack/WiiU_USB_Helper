namespace ns0
{
	// Token: 0x020001B1 RID: 433
	public partial class frmVideo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x0001879B File Offset: 0x0001699B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0004AC6C File Offset: 0x00048E6C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmVideo));
			this.axWindowsMediaPlayer1 = new global::AxWMPLib.AxWindowsMediaPlayer();
			((global::System.ComponentModel.ISupportInitialize)this.axWindowsMediaPlayer1).BeginInit();
			base.SuspendLayout();
			this.axWindowsMediaPlayer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new global::System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = (global::System.Windows.Forms.AxHost.State)componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState");
			this.axWindowsMediaPlayer1.Size = new global::System.Drawing.Size(1099, 597);
			this.axWindowsMediaPlayer1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1099, 597);
			base.Controls.Add(this.axWindowsMediaPlayer1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmVideo";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Video Player";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmVideo_FormClosing);
			((global::System.ComponentModel.ISupportInitialize)this.axWindowsMediaPlayer1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000785 RID: 1925
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000786 RID: 1926
		private global::AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
	}
}

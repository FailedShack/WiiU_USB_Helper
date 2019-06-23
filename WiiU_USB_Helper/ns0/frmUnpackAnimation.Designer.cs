namespace ns0
{
	// Token: 0x020001AF RID: 431
	public partial class frmUnpackAnimation : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BF6 RID: 3062 RVA: 0x00018732 File Offset: 0x00016932
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0004A8A4 File Offset: 0x00048AA4
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmUnpackAnimation));
			this.radProgressBar1 = new global::Telerik.WinControls.UI.RadProgressBar();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.lblFiles = new global::Telerik.WinControls.UI.RadLabel();
			this.lblTile = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.radProgressBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblFiles).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTile).BeginInit();
			base.SuspendLayout();
			this.radProgressBar1.Location = new global::System.Drawing.Point(15, 75);
			this.radProgressBar1.Name = "radProgressBar1";
			this.radProgressBar1.ShowProgressIndicators = true;
			this.radProgressBar1.Size = new global::System.Drawing.Size(610, 24);
			this.radProgressBar1.TabIndex = 0;
			this.radProgressBar1.Text = "0 %";
			this.pictureBox1.Location = new global::System.Drawing.Point(-1, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(805, 175);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 30;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.lblFiles.Location = new global::System.Drawing.Point(12, 157);
			this.lblFiles.Name = "lblFiles";
			this.lblFiles.Size = new global::System.Drawing.Size(9, 18);
			this.lblFiles.TabIndex = 3;
			this.lblFiles.Text = ".";
			this.lblTile.Location = new global::System.Drawing.Point(15, 0);
			this.lblTile.Name = "lblTile";
			this.lblTile.Size = new global::System.Drawing.Size(9, 18);
			this.lblTile.TabIndex = 4;
			this.lblTile.Text = ".";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(640, 174);
			base.Controls.Add(this.lblTile);
			base.Controls.Add(this.lblFiles);
			base.Controls.Add(this.radProgressBar1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmUnpackAnimation";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Now unpacking...";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmUnpackAnimation_FormClosing);
			((global::System.ComponentModel.ISupportInitialize)this.radProgressBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblFiles).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblTile).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400077D RID: 1917
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400077E RID: 1918
		private global::Telerik.WinControls.UI.RadProgressBar radProgressBar1;

		// Token: 0x0400077F RID: 1919
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000780 RID: 1920
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000781 RID: 1921
		private global::Telerik.WinControls.UI.RadLabel lblFiles;

		// Token: 0x04000782 RID: 1922
		private global::Telerik.WinControls.UI.RadLabel lblTile;
	}
}

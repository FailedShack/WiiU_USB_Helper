namespace ns0
{
	// Token: 0x02000140 RID: 320
	public partial class FrmFtpProgress : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00015904 File Offset: 0x00013B04
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00036590 File Offset: 0x00034790
		private void InitializeComponent()
		{
			this.radProgressBar1 = new global::Telerik.WinControls.UI.RadProgressBar();
			this.title = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.lblSpeed = new global::Telerik.WinControls.UI.RadLabel();
			this.lblEta = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pctIcon = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.radProgressBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.title).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblSpeed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblEta).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pctIcon).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radProgressBar1.Location = new global::System.Drawing.Point(22, 79);
			this.radProgressBar1.Name = "radProgressBar1";
			this.radProgressBar1.ShowProgressIndicators = true;
			this.radProgressBar1.Size = new global::System.Drawing.Size(398, 24);
			this.radProgressBar1.TabIndex = 0;
			this.radProgressBar1.Text = "0 %";
			this.title.AutoSize = false;
			this.title.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.title.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.title.Location = new global::System.Drawing.Point(0, 0);
			this.title.Name = "title";
			this.title.Size = new global::System.Drawing.Size(442, 73);
			this.title.TabIndex = 1;
			this.title.Text = "radLabel1";
			this.title.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
			this.title.UseMnemonic = false;
			this.radButton1.Location = new global::System.Drawing.Point(166, 190);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(110, 24);
			this.radButton1.TabIndex = 3;
			this.radButton1.Text = "Abort";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.lblSpeed.Location = new global::System.Drawing.Point(348, 104);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new global::System.Drawing.Size(27, 18);
			this.lblSpeed.TabIndex = 2;
			this.lblSpeed.Text = "0.00";
			this.lblEta.Location = new global::System.Drawing.Point(22, 104);
			this.lblEta.Name = "lblEta";
			this.lblEta.Size = new global::System.Drawing.Size(25, 18);
			this.lblEta.TabIndex = 3;
			this.lblEta.Text = "ETA";
			this.pictureBox1.Image = global::ns0.Class121.icnWiiU;
			this.pictureBox1.Location = new global::System.Drawing.Point(284, 133);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(128, 43);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pctIcon.Location = new global::System.Drawing.Point(31, 128);
			this.pctIcon.Name = "pctIcon";
			this.pctIcon.Size = new global::System.Drawing.Size(64, 64);
			this.pctIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctIcon.TabIndex = 5;
			this.pctIcon.TabStop = false;
			this.pictureBox2.Image = global::ns0.Class121.transferAnim;
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new global::System.Drawing.Point(98, 138);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(180, 40);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(442, 221);
			base.Controls.Add(this.lblSpeed);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.pctIcon);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.lblEta);
			base.Controls.Add(this.title);
			base.Controls.Add(this.radProgressBar1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FrmFtpProgress";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Now uploading...";
			base.Load += new global::System.EventHandler(this.FrmFtpProgress_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radProgressBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.title).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblSpeed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblEta).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pctIcon).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000518 RID: 1304
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000519 RID: 1305
		private global::Telerik.WinControls.UI.RadProgressBar radProgressBar1;

		// Token: 0x0400051A RID: 1306
		private global::Telerik.WinControls.UI.RadLabel title;

		// Token: 0x0400051B RID: 1307
		private global::Telerik.WinControls.UI.RadLabel lblSpeed;

		// Token: 0x0400051C RID: 1308
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x0400051D RID: 1309
		private global::Telerik.WinControls.UI.RadLabel lblEta;

		// Token: 0x0400051E RID: 1310
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400051F RID: 1311
		private global::System.Windows.Forms.PictureBox pctIcon;

		// Token: 0x04000520 RID: 1312
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}

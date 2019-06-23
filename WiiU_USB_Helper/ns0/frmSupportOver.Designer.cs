namespace ns0
{
	// Token: 0x020001B2 RID: 434
	public partial class frmSupportOver : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x000187BA File Offset: 0x000169BA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0004AE58 File Offset: 0x00049058
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmSupportOver));
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.cmdClose = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblCloudCredentials = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClose).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblCloudCredentials).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(149, 86);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(293, 24);
			this.label1.TabIndex = 37;
			this.label1.Text = "Thank you for using Wii U USB Helper !";
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.pictureBox1.Image = global::ns0.Class121.logo_horiz;
			this.pictureBox1.Location = new global::System.Drawing.Point(37, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(385, 66);
			this.pictureBox1.TabIndex = 43;
			this.pictureBox1.TabStop = false;
			this.cmdClose.Location = new global::System.Drawing.Point(197, 352);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new global::System.Drawing.Size(163, 26);
			this.cmdClose.TabIndex = 42;
			this.cmdClose.Text = "Exit";
			this.cmdClose.ThemeName = "VisualStudio2012Dark";
			this.cmdClose.Click += new global::System.EventHandler(this.cmdClose_Click);
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.ImageAlignment = global::System.Drawing.ContentAlignment.MiddleRight;
			this.radLabel1.Location = new global::System.Drawing.Point(48, 122);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(460, 146);
			this.radLabel1.TabIndex = 38;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabel1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.radLabel1.ThemeName = "VisualStudio2012Dark";
			this.lblCloudCredentials.Location = new global::System.Drawing.Point(48, 274);
			this.lblCloudCredentials.Name = "lblCloudCredentials";
			this.lblCloudCredentials.Size = new global::System.Drawing.Size(2, 2);
			this.lblCloudCredentials.TabIndex = 44;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(556, 390);
			base.Controls.Add(this.lblCloudCredentials);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.cmdClose);
			base.Controls.Add(this.radLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSupportOver";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thank you!";
			base.Load += new global::System.EventHandler(this.frmSupportOver_Load);
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClose).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblCloudCredentials).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000787 RID: 1927
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000788 RID: 1928
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000789 RID: 1929
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400078A RID: 1930
		private global::Telerik.WinControls.UI.RadButton cmdClose;

		// Token: 0x0400078B RID: 1931
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x0400078C RID: 1932
		private global::Telerik.WinControls.UI.RadLabel lblCloudCredentials;
	}
}

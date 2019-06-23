namespace ns0
{
	// Token: 0x02000195 RID: 405
	public partial class frmInjection : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0001816C File Offset: 0x0001636C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00043A04 File Offset: 0x00041C04
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmInjection));
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.chkRatio = new global::Telerik.WinControls.UI.RadCheckBox();
			this.grpDrop = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblDrop = new global::Telerik.WinControls.UI.RadLabel();
			this.lblCount = new global::System.Windows.Forms.Label();
			this.cmdBrowse = new global::Telerik.WinControls.UI.RadButton();
			this.cmdPrepareSd = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblIntro = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkRatio).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpDrop).BeginInit();
			this.grpDrop.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblDrop).BeginInit();
			this.lblDrop.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdBrowse).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdPrepareSd).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblIntro).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.radButton1);
			this.radGroupBox1.Controls.Add(this.radLabel2);
			this.radGroupBox1.Controls.Add(this.chkRatio);
			this.radGroupBox1.Controls.Add(this.grpDrop);
			this.radGroupBox1.Controls.Add(this.cmdPrepareSd);
			this.radGroupBox1.Controls.Add(this.radLabel3);
			this.radGroupBox1.Controls.Add(this.pictureBox2);
			this.radGroupBox1.Controls.Add(this.pictureBox1);
			this.radGroupBox1.Controls.Add(this.lblIntro);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox1.HeaderText = "Injection";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(601, 435);
			this.radGroupBox1.TabIndex = 0;
			this.radGroupBox1.Text = "Injection";
			this.radButton1.Location = new global::System.Drawing.Point(458, 12);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(138, 24);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "Vote for the next games!";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.radLabel2.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel2.Location = new global::System.Drawing.Point(5, 412);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(120, 18);
			this.radLabel2.TabIndex = 9;
			this.radLabel2.Text = "See the Special Thanks";
			this.radLabel2.Click += new global::System.EventHandler(this.radLabel2_Click);
			this.chkRatio.Location = new global::System.Drawing.Point(480, 396);
			this.chkRatio.Name = "chkRatio";
			this.chkRatio.Size = new global::System.Drawing.Size(91, 18);
			this.chkRatio.TabIndex = 8;
			this.chkRatio.Text = "Force 4:3 ratio";
			this.grpDrop.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.grpDrop.AllowDrop = true;
			this.grpDrop.Controls.Add(this.lblDrop);
			this.grpDrop.HeaderText = "Drop the ISO here !";
			this.grpDrop.Location = new global::System.Drawing.Point(27, 160);
			this.grpDrop.Name = "grpDrop";
			this.grpDrop.Size = new global::System.Drawing.Size(546, 169);
			this.grpDrop.TabIndex = 1;
			this.grpDrop.Text = "Drop the ISO here !";
			this.grpDrop.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.grpDrop_DragDrop);
			this.grpDrop.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.grpDrop_DragEnter);
			this.lblDrop.AutoSize = false;
			this.lblDrop.Controls.Add(this.lblCount);
			this.lblDrop.Controls.Add(this.cmdBrowse);
			this.lblDrop.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblDrop.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDrop.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.lblDrop.Location = new global::System.Drawing.Point(2, 18);
			this.lblDrop.Name = "lblDrop";
			this.lblDrop.Size = new global::System.Drawing.Size(542, 149);
			this.lblDrop.TabIndex = 0;
			this.lblDrop.Text = "Drop your ISO here!";
			this.lblDrop.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new global::System.Drawing.Point(386, 133);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new global::System.Drawing.Size(156, 13);
			this.lblCount.TabIndex = 1;
			this.lblCount.Text = "{x} disc(s) provded out of {x}";
			this.cmdBrowse.Location = new global::System.Drawing.Point(216, 122);
			this.cmdBrowse.Name = "cmdBrowse";
			this.cmdBrowse.Size = new global::System.Drawing.Size(110, 24);
			this.cmdBrowse.TabIndex = 0;
			this.cmdBrowse.Text = "Browse...";
			this.cmdBrowse.Click += new global::System.EventHandler(this.cmdBrowse_Click);
			this.cmdPrepareSd.Image = global::ns0.Class121.icnSd;
			this.cmdPrepareSd.Location = new global::System.Drawing.Point(206, 363);
			this.cmdPrepareSd.Name = "cmdPrepareSd";
			this.cmdPrepareSd.Padding = new global::System.Windows.Forms.Padding(8);
			this.cmdPrepareSd.Size = new global::System.Drawing.Size(203, 51);
			this.cmdPrepareSd.TabIndex = 7;
			this.cmdPrepareSd.Text = "Prepare my SD";
			this.cmdPrepareSd.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdPrepareSd.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdPrepareSd.ThemeName = "VisualStudio2012Dark";
			this.cmdPrepareSd.Click += new global::System.EventHandler(this.cmdPrepareSd_Click);
			this.radLabel3.Location = new global::System.Drawing.Point(116, 340);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(447, 17);
			this.radLabel3.TabIndex = 4;
			this.radLabel3.Text = "<html><strong><span style=\"color: #ff8000\">In order to be able to launch these games, you must prepare your SD at least once.</span></strong></html>";
			this.pictureBox2.Image = global::ns0.Class121.warning;
			this.pictureBox2.Location = new global::System.Drawing.Point(29, 333);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(64, 64);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Location = new global::System.Drawing.Point(27, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(90, 90);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.lblIntro.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblIntro.Location = new global::System.Drawing.Point(126, 21);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new global::System.Drawing.Size(465, 323);
			this.lblIntro.TabIndex = 1;
			this.lblIntro.Text = componentResourceManager.GetString("lblIntro.Text");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(601, 435);
			base.Controls.Add(this.radGroupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmInjection";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Injection";
			base.Load += new global::System.EventHandler(this.frmInjection_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkRatio).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.grpDrop).EndInit();
			this.grpDrop.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.lblDrop).EndInit();
			this.lblDrop.ResumeLayout(false);
			this.lblDrop.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdBrowse).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdPrepareSd).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblIntro).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006CB RID: 1739
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006CC RID: 1740
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x040006CD RID: 1741
		private global::Telerik.WinControls.UI.RadLabel lblIntro;

		// Token: 0x040006CE RID: 1742
		private global::Telerik.WinControls.UI.RadGroupBox grpDrop;

		// Token: 0x040006CF RID: 1743
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040006D0 RID: 1744
		private global::Telerik.WinControls.UI.RadLabel lblDrop;

		// Token: 0x040006D1 RID: 1745
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040006D2 RID: 1746
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x040006D3 RID: 1747
		private global::Telerik.WinControls.UI.RadButton cmdPrepareSd;

		// Token: 0x040006D4 RID: 1748
		private global::Telerik.WinControls.UI.RadButton cmdBrowse;

		// Token: 0x040006D5 RID: 1749
		private global::Telerik.WinControls.UI.RadCheckBox chkRatio;

		// Token: 0x040006D6 RID: 1750
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x040006D7 RID: 1751
		private global::System.Windows.Forms.Label lblCount;

		// Token: 0x040006D8 RID: 1752
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}

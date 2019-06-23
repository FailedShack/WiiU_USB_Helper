namespace ns0
{
	// Token: 0x02000191 RID: 401
	public partial class frmDonation : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B5F RID: 2911 RVA: 0x00018025 File Offset: 0x00016225
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00042974 File Offset: 0x00040B74
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmDonation));
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdDonatorKey = new global::Telerik.WinControls.UI.RadButton();
			this.cmdLater = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblNewVersion = new global::Telerik.WinControls.UI.RadLabel();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDonatorKey).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdLater).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblNewVersion).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(129, 61);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(293, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thank you for using Wii U USB Helper !";
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.ImageAlignment = global::System.Drawing.ContentAlignment.MiddleRight;
			this.radLabel1.Location = new global::System.Drawing.Point(41, 105);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(468, 146);
			this.radLabel1.TabIndex = 2;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radLabel1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.radLabel1.ThemeName = "VisualStudio2012Dark";
			this.cmdDonatorKey.Location = new global::System.Drawing.Point(109, 260);
			this.cmdDonatorKey.Name = "cmdDonatorKey";
			this.cmdDonatorKey.Size = new global::System.Drawing.Size(163, 26);
			this.cmdDonatorKey.TabIndex = 28;
			this.cmdDonatorKey.Text = "I have a Donation Key!";
			this.cmdDonatorKey.ThemeName = "VisualStudio2012Dark";
			this.cmdDonatorKey.Click += new global::System.EventHandler(this.cmdDonatorKey_Click);
			this.cmdLater.Enabled = false;
			this.cmdLater.Location = new global::System.Drawing.Point(278, 260);
			this.cmdLater.Name = "cmdLater";
			this.cmdLater.Size = new global::System.Drawing.Size(163, 26);
			this.cmdLater.TabIndex = 29;
			this.cmdLater.Text = "Maybe later!";
			this.cmdLater.ThemeName = "VisualStudio2012Dark";
			this.cmdLater.Click += new global::System.EventHandler(this.cmdLater_Click);
			this.radLabel2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel2.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel2.Location = new global::System.Drawing.Point(137, 483);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(367, 18);
			this.radLabel2.TabIndex = 30;
			this.radLabel2.Text = "Click here if nothing happens when you click on \"I want to donate!\"";
			this.radLabel2.Click += new global::System.EventHandler(this.radLabel2_Click);
			this.radTextBox1.Location = new global::System.Drawing.Point(102, 482);
			this.radTextBox1.Name = "radTextBox1";
			this.radTextBox1.ReadOnly = true;
			this.radTextBox1.Size = new global::System.Drawing.Size(497, 20);
			this.radTextBox1.TabIndex = 31;
			this.radTextBox1.Text = "http://registration.wiiuusbhelper.com/donation.php";
			this.radLabel3.Location = new global::System.Drawing.Point(71, 490);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(478, 18);
			this.radLabel3.TabIndex = 32;
			this.radLabel3.Text = "Thank you so much for your support! Paste this url in your browser and follow the instructions!";
			this.radButton1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radButton1.ForeColor = global::System.Drawing.Color.Green;
			this.radButton1.Location = new global::System.Drawing.Point(148, 292);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(254, 26);
			this.radButton1.TabIndex = 28;
			this.radButton1.Text = "I don't have any money, how can I help?";
			this.radButton1.ThemeName = "VisualStudio2012Dark";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.pictureBox1.Image = global::ns0.Class121.logo_horiz;
			this.pictureBox1.Location = new global::System.Drawing.Point(10, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(385, 66);
			this.pictureBox1.TabIndex = 35;
			this.pictureBox1.TabStop = false;
			this.lblNewVersion.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.lblNewVersion.Location = new global::System.Drawing.Point(159, 319);
			this.lblNewVersion.Name = "lblNewVersion";
			this.lblNewVersion.Size = new global::System.Drawing.Size(232, 18);
			this.lblNewVersion.TabIndex = 36;
			this.lblNewVersion.Text = "--New version with improved compatibility!--";
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 600;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(550, 348);
			base.Controls.Add(this.lblNewVersion);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.radLabel3);
			base.Controls.Add(this.radTextBox1);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.cmdLater);
			base.Controls.Add(this.cmdDonatorKey);
			base.Controls.Add(this.radLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmDonation";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Donation";
			base.Load += new global::System.EventHandler(this.frmDonation_Load);
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDonatorKey).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdLater).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblNewVersion).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040006B0 RID: 1712
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006B1 RID: 1713
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x040006B2 RID: 1714
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040006B3 RID: 1715
		private global::Telerik.WinControls.UI.RadButton cmdDonatorKey;

		// Token: 0x040006B4 RID: 1716
		private global::Telerik.WinControls.UI.RadButton cmdLater;

		// Token: 0x040006B5 RID: 1717
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x040006B6 RID: 1718
		private global::Telerik.WinControls.UI.RadTextBox radTextBox1;

		// Token: 0x040006B7 RID: 1719
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x040006B8 RID: 1720
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x040006B9 RID: 1721
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040006BA RID: 1722
		private global::Telerik.WinControls.UI.RadLabel lblNewVersion;

		// Token: 0x040006BB RID: 1723
		private global::System.Windows.Forms.Timer timer_0;
	}
}

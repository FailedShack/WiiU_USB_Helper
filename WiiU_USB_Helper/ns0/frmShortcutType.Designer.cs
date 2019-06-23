namespace ns0
{
	// Token: 0x020001AB RID: 427
	public partial class frmShortcutType : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BD7 RID: 3031 RVA: 0x00018604 File Offset: 0x00016804
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00047114 File Offset: 0x00045314
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmShortcutType));
			this.cmdShortcut = new global::Telerik.WinControls.UI.RadButton();
			this.cmdSteam = new global::Telerik.WinControls.UI.RadButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.lblCloseSteam = new global::Telerik.WinControls.UI.RadLabel();
			this.radSplitContainer1 = new global::Telerik.WinControls.UI.RadSplitContainer();
			this.splitPanel1 = new global::Telerik.WinControls.UI.SplitPanel();
			this.splitPanel2 = new global::Telerik.WinControls.UI.SplitPanel();
			this.radSteamLink = new global::Telerik.WinControls.UI.RadButton();
			this.chkSteamLink = new global::Telerik.WinControls.UI.RadCheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.cmdShortcut).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSteam).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblCloseSteam).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer1).BeginInit();
			this.radSplitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel1).BeginInit();
			this.splitPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel2).BeginInit();
			this.splitPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radSteamLink).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkSteamLink).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.cmdShortcut.Location = new global::System.Drawing.Point(100, 168);
			this.cmdShortcut.Name = "cmdShortcut";
			this.cmdShortcut.Size = new global::System.Drawing.Size(172, 24);
			this.cmdShortcut.TabIndex = 0;
			this.cmdShortcut.Text = "Create a desktop shortcut";
			this.cmdShortcut.Click += new global::System.EventHandler(this.cmdShortcut_Click);
			this.cmdSteam.Location = new global::System.Drawing.Point(85, 138);
			this.cmdSteam.Name = "cmdSteam";
			this.cmdSteam.Size = new global::System.Drawing.Size(172, 24);
			this.cmdSteam.TabIndex = 1;
			this.cmdSteam.Text = "Add game to Steam";
			this.cmdSteam.Click += new global::System.EventHandler(this.cmdSteam_Click);
			this.pictureBox1.Image = global::ns0.Class121.icnSteam;
			this.pictureBox1.Location = new global::System.Drawing.Point(123, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(96, 96);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox2.Image = global::ns0.Class121.icnDesktop;
			this.pictureBox2.Location = new global::System.Drawing.Point(138, 47);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(96, 96);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.radLabel1.AutoSize = false;
			this.radLabel1.Location = new global::System.Drawing.Point(59, 198);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(227, 21);
			this.radLabel1.TabIndex = 4;
			this.radLabel1.Text = "<html><ul><li>Launch the game from your dekstop</li></ul></html>";
			this.radLabel2.Location = new global::System.Drawing.Point(40, 168);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(263, 46);
			this.radLabel2.TabIndex = 5;
			this.radLabel2.Text = "<html><ul><li>Launch the game from Steam</li><li>Launch the game from the Big Picture Mode</li><li>Launch the game with the Steam Link</li></ul></html>";
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 150;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.lblCloseSteam.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblCloseSteam.ForeColor = global::System.Drawing.Color.Red;
			this.lblCloseSteam.Location = new global::System.Drawing.Point(41, 119);
			this.lblCloseSteam.Name = "lblCloseSteam";
			this.lblCloseSteam.Size = new global::System.Drawing.Size(260, 18);
			this.lblCloseSteam.TabIndex = 6;
			this.lblCloseSteam.Text = "Please close Steam to proceed (click to force close)";
			this.lblCloseSteam.Visible = false;
			this.lblCloseSteam.Click += new global::System.EventHandler(this.lblCloseSteam_Click);
			this.radSplitContainer1.Controls.Add(this.splitPanel1);
			this.radSplitContainer1.Controls.Add(this.splitPanel2);
			this.radSplitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radSplitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.radSplitContainer1.Name = "radSplitContainer1";
			this.radSplitContainer1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.radSplitContainer1.Size = new global::System.Drawing.Size(691, 266);
			this.radSplitContainer1.TabIndex = 8;
			this.radSplitContainer1.TabStop = false;
			this.radSplitContainer1.Text = "radSplitContainer1";
			this.splitPanel1.Controls.Add(this.pictureBox2);
			this.splitPanel1.Controls.Add(this.cmdShortcut);
			this.splitPanel1.Controls.Add(this.radLabel1);
			this.splitPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.splitPanel1.Name = "splitPanel1";
			this.splitPanel1.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.splitPanel1.Size = new global::System.Drawing.Size(344, 266);
			this.splitPanel1.TabIndex = 0;
			this.splitPanel1.TabStop = false;
			this.splitPanel1.Text = "splitPanel1";
			this.splitPanel2.Controls.Add(this.chkSteamLink);
			this.splitPanel2.Controls.Add(this.radSteamLink);
			this.splitPanel2.Controls.Add(this.pictureBox1);
			this.splitPanel2.Controls.Add(this.cmdSteam);
			this.splitPanel2.Controls.Add(this.lblCloseSteam);
			this.splitPanel2.Controls.Add(this.radLabel2);
			this.splitPanel2.Location = new global::System.Drawing.Point(348, 0);
			this.splitPanel2.Name = "splitPanel2";
			this.splitPanel2.RootElement.MinSize = new global::System.Drawing.Size(25, 25);
			this.splitPanel2.Size = new global::System.Drawing.Size(343, 266);
			this.splitPanel2.TabIndex = 1;
			this.splitPanel2.TabStop = false;
			this.splitPanel2.Text = "splitPanel2";
			this.radSteamLink.Location = new global::System.Drawing.Point(114, 239);
			this.radSteamLink.Name = "radSteamLink";
			this.radSteamLink.Size = new global::System.Drawing.Size(226, 24);
			this.radSteamLink.TabIndex = 7;
			this.radSteamLink.Text = "Download Steam Link Input Configuration";
			this.radSteamLink.Click += new global::System.EventHandler(this.radSteamLink_Click);
			this.chkSteamLink.Location = new global::System.Drawing.Point(19, 242);
			this.chkSteamLink.Name = "chkSteamLink";
			this.chkSteamLink.Size = new global::System.Drawing.Size(89, 18);
			this.chkSteamLink.TabIndex = 8;
			this.chkSteamLink.Text = "Steam Link fix";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(691, 266);
			base.Controls.Add(this.radSplitContainer1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmShortcutType";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Choose a shortcut";
			base.Load += new global::System.EventHandler(this.frmShortcutType_Load);
			((global::System.ComponentModel.ISupportInitialize)this.cmdShortcut).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdSteam).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblCloseSteam).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radSplitContainer1).EndInit();
			this.radSplitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel1).EndInit();
			this.splitPanel1.ResumeLayout(false);
			this.splitPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitPanel2).EndInit();
			this.splitPanel2.ResumeLayout(false);
			this.splitPanel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radSteamLink).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkSteamLink).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000731 RID: 1841
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000732 RID: 1842
		private global::Telerik.WinControls.UI.RadButton cmdShortcut;

		// Token: 0x04000733 RID: 1843
		private global::Telerik.WinControls.UI.RadButton cmdSteam;

		// Token: 0x04000734 RID: 1844
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000735 RID: 1845
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000736 RID: 1846
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000737 RID: 1847
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x04000738 RID: 1848
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000739 RID: 1849
		private global::Telerik.WinControls.UI.RadLabel lblCloseSteam;

		// Token: 0x0400073A RID: 1850
		private global::Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;

		// Token: 0x0400073B RID: 1851
		private global::Telerik.WinControls.UI.SplitPanel splitPanel1;

		// Token: 0x0400073C RID: 1852
		private global::Telerik.WinControls.UI.SplitPanel splitPanel2;

		// Token: 0x0400073D RID: 1853
		private global::Telerik.WinControls.UI.RadButton radSteamLink;

		// Token: 0x0400073E RID: 1854
		private global::Telerik.WinControls.UI.RadCheckBox chkSteamLink;
	}
}

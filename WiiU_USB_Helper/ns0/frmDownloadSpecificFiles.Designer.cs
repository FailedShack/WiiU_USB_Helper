namespace ns0
{
	// Token: 0x02000177 RID: 375
	public partial class frmDownloadSpecificFiles : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000AEA RID: 2794 RVA: 0x00017B90 File Offset: 0x00015D90
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003DD98 File Offset: 0x0003BF98
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmDownloadSpecificFiles));
			this.lstNodesGame = new global::Telerik.WinControls.UI.RadTreeView();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.lstNodesUpdate = new global::Telerik.WinControls.UI.RadTreeView();
			this.lstNodesDlc = new global::Telerik.WinControls.UI.RadTreeView();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radGroupBox2 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radGroupBox3 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radGroupBox4 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.grpPreview = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radGroupBox5 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblFullPath = new global::Telerik.WinControls.UI.RadLabel();
			this.lblSize = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.lstNodesGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstNodesUpdate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstNodesDlc).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).BeginInit();
			this.radGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).BeginInit();
			this.radGroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox4).BeginInit();
			this.radGroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.grpPreview).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox5).BeginInit();
			this.radGroupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblFullPath).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblSize).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.lstNodesGame.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstNodesGame.Location = new global::System.Drawing.Point(2, 18);
			this.lstNodesGame.Name = "lstNodesGame";
			this.lstNodesGame.Size = new global::System.Drawing.Size(334, 505);
			this.lstNodesGame.SpacingBetweenNodes = -1;
			this.lstNodesGame.TabIndex = 0;
			this.lstNodesGame.NodeMouseClick += new global::Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.lstNodesGame_NodeMouseClick);
			this.radButton1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radButton1.Location = new global::System.Drawing.Point(0, 525);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(1530, 24);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "Download Selected Files";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.lstNodesUpdate.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstNodesUpdate.Location = new global::System.Drawing.Point(2, 18);
			this.lstNodesUpdate.Name = "lstNodesUpdate";
			this.lstNodesUpdate.Size = new global::System.Drawing.Size(365, 505);
			this.lstNodesUpdate.SpacingBetweenNodes = -1;
			this.lstNodesUpdate.TabIndex = 1;
			this.lstNodesUpdate.NodeMouseClick += new global::Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.lstNodesUpdate_NodeMouseClick);
			this.lstNodesDlc.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstNodesDlc.Location = new global::System.Drawing.Point(2, 18);
			this.lstNodesDlc.Name = "lstNodesDlc";
			this.lstNodesDlc.Size = new global::System.Drawing.Size(384, 505);
			this.lstNodesDlc.SpacingBetweenNodes = -1;
			this.lstNodesDlc.TabIndex = 2;
			this.lstNodesDlc.NodeMouseClick += new global::Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.lstNodesDlc_NodeMouseClick);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.lstNodesGame);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radGroupBox1.HeaderText = "Game";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(338, 525);
			this.radGroupBox1.TabIndex = 3;
			this.radGroupBox1.Text = "Game";
			this.radGroupBox2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox2.Controls.Add(this.lstNodesUpdate);
			this.radGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radGroupBox2.HeaderText = "Update";
			this.radGroupBox2.Location = new global::System.Drawing.Point(338, 0);
			this.radGroupBox2.Name = "radGroupBox2";
			this.radGroupBox2.Size = new global::System.Drawing.Size(369, 525);
			this.radGroupBox2.TabIndex = 4;
			this.radGroupBox2.Text = "Update";
			this.radGroupBox3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox3.Controls.Add(this.lstNodesDlc);
			this.radGroupBox3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radGroupBox3.HeaderText = "Dlc";
			this.radGroupBox3.Location = new global::System.Drawing.Point(707, 0);
			this.radGroupBox3.Name = "radGroupBox3";
			this.radGroupBox3.Size = new global::System.Drawing.Size(388, 525);
			this.radGroupBox3.TabIndex = 5;
			this.radGroupBox3.Text = "Dlc";
			this.radGroupBox4.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox4.Controls.Add(this.grpPreview);
			this.radGroupBox4.Controls.Add(this.radGroupBox5);
			this.radGroupBox4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox4.HeaderText = "File Info";
			this.radGroupBox4.Location = new global::System.Drawing.Point(1095, 0);
			this.radGroupBox4.Name = "radGroupBox4";
			this.radGroupBox4.Size = new global::System.Drawing.Size(435, 525);
			this.radGroupBox4.TabIndex = 6;
			this.radGroupBox4.Text = "File Info";
			this.grpPreview.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.grpPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.grpPreview.HeaderText = "File preview";
			this.grpPreview.Location = new global::System.Drawing.Point(2, 118);
			this.grpPreview.Name = "grpPreview";
			this.grpPreview.Size = new global::System.Drawing.Size(431, 405);
			this.grpPreview.TabIndex = 7;
			this.grpPreview.Text = "File preview";
			this.radGroupBox5.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox5.Controls.Add(this.radLabel1);
			this.radGroupBox5.Controls.Add(this.radLabel2);
			this.radGroupBox5.Controls.Add(this.lblFullPath);
			this.radGroupBox5.Controls.Add(this.lblSize);
			this.radGroupBox5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.radGroupBox5.HeaderText = "Details";
			this.radGroupBox5.Location = new global::System.Drawing.Point(2, 18);
			this.radGroupBox5.Name = "radGroupBox5";
			this.radGroupBox5.Size = new global::System.Drawing.Size(431, 100);
			this.radGroupBox5.TabIndex = 7;
			this.radGroupBox5.Text = "Details";
			this.radLabel1.Location = new global::System.Drawing.Point(18, 36);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(55, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Full Path :";
			this.radLabel2.Location = new global::System.Drawing.Point(18, 60);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(32, 18);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "Size :";
			this.lblFullPath.Location = new global::System.Drawing.Point(80, 35);
			this.lblFullPath.Name = "lblFullPath";
			this.lblFullPath.Size = new global::System.Drawing.Size(11, 18);
			this.lblFullPath.TabIndex = 1;
			this.lblFullPath.Text = "-";
			this.lblSize.Location = new global::System.Drawing.Point(80, 59);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new global::System.Drawing.Size(11, 18);
			this.lblSize.TabIndex = 2;
			this.lblSize.Text = "-";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1530, 549);
			base.Controls.Add(this.radGroupBox4);
			base.Controls.Add(this.radGroupBox3);
			base.Controls.Add(this.radGroupBox2);
			base.Controls.Add(this.radGroupBox1);
			base.Controls.Add(this.radButton1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDownloadSpecificFiles";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Download Specific Files";
			base.Load += new global::System.EventHandler(this.frmDownloadSpecificFiles_Load);
			((global::System.ComponentModel.ISupportInitialize)this.lstNodesGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstNodesUpdate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lstNodesDlc).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).EndInit();
			this.radGroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).EndInit();
			this.radGroupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox4).EndInit();
			this.radGroupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.grpPreview).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox5).EndInit();
			this.radGroupBox5.ResumeLayout(false);
			this.radGroupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblFullPath).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblSize).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000634 RID: 1588
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000635 RID: 1589
		private global::Telerik.WinControls.UI.RadTreeView lstNodesGame;

		// Token: 0x04000636 RID: 1590
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x04000637 RID: 1591
		private global::Telerik.WinControls.UI.RadTreeView lstNodesUpdate;

		// Token: 0x04000638 RID: 1592
		private global::Telerik.WinControls.UI.RadTreeView lstNodesDlc;

		// Token: 0x04000639 RID: 1593
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x0400063A RID: 1594
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox2;

		// Token: 0x0400063B RID: 1595
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox3;

		// Token: 0x0400063C RID: 1596
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox4;

		// Token: 0x0400063D RID: 1597
		private global::Telerik.WinControls.UI.RadGroupBox grpPreview;

		// Token: 0x0400063E RID: 1598
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox5;

		// Token: 0x0400063F RID: 1599
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000640 RID: 1600
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x04000641 RID: 1601
		private global::Telerik.WinControls.UI.RadLabel lblFullPath;

		// Token: 0x04000642 RID: 1602
		private global::Telerik.WinControls.UI.RadLabel lblSize;
	}
}

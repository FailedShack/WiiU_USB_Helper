namespace ns0
{
	// Token: 0x0200017F RID: 383
	public partial class frmEmuInfo : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x00017CCD File Offset: 0x00015ECD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0003F098 File Offset: 0x0003D298
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmEmuInfo));
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.radGroupBox6 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblEmuPath = new global::Telerik.WinControls.UI.RadLabel();
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblEmuStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.label2 = new global::Telerik.WinControls.UI.RadLabel();
			this.lblEmuName = new global::Telerik.WinControls.UI.RadLabel();
			this.label3 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox3 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdVerifyGame = new global::Telerik.WinControls.UI.RadButton();
			this.pictGame = new global::System.Windows.Forms.PictureBox();
			this.lblGameStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel6 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox4 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdVerifyUpdate = new global::Telerik.WinControls.UI.RadButton();
			this.chkExceptionUpdate = new global::Telerik.WinControls.UI.RadCheckBox();
			this.lblUpdateVersion = new global::Telerik.WinControls.UI.RadLabel();
			this.lblUpdateStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel7 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox5 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.cmdVerifyDlc = new global::Telerik.WinControls.UI.RadButton();
			this.chkExceptionDLC = new global::Telerik.WinControls.UI.RadCheckBox();
			this.lblDLCStatus = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdDeleteGame = new global::Telerik.WinControls.UI.RadButton();
			this.cmdDeleteUpdate = new global::Telerik.WinControls.UI.RadButton();
			this.cmdDeleteDlc = new global::Telerik.WinControls.UI.RadButton();
			this.radGroupBox2 = new global::Telerik.WinControls.UI.RadGroupBox();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox6).BeginInit();
			this.radGroupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuPath).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuStatus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuName).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).BeginInit();
			this.radGroupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdVerifyGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblGameStatus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox4).BeginInit();
			this.radGroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdVerifyUpdate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkExceptionUpdate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpdateVersion).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpdateStatus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox5).BeginInit();
			this.radGroupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdVerifyDlc).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkExceptionDLC).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDLCStatus).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteUpdate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteDlc).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).BeginInit();
			this.radGroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.radGroupBox6);
			this.radGroupBox1.Controls.Add(this.radGroupBox3);
			this.radGroupBox1.Controls.Add(this.radGroupBox4);
			this.radGroupBox1.Controls.Add(this.radGroupBox5);
			this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox1.HeaderText = "Info";
			this.radGroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(1114, 154);
			this.radGroupBox1.TabIndex = 0;
			this.radGroupBox1.Text = "Info";
			this.radGroupBox6.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox6.Controls.Add(this.lblEmuPath);
			this.radGroupBox6.Controls.Add(this.label1);
			this.radGroupBox6.Controls.Add(this.lblEmuStatus);
			this.radGroupBox6.Controls.Add(this.label2);
			this.radGroupBox6.Controls.Add(this.lblEmuName);
			this.radGroupBox6.Controls.Add(this.label3);
			this.radGroupBox6.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radGroupBox6.HeaderText = "Emulator information";
			this.radGroupBox6.Location = new global::System.Drawing.Point(2, 18);
			this.radGroupBox6.Name = "radGroupBox6";
			this.radGroupBox6.Size = new global::System.Drawing.Size(430, 134);
			this.radGroupBox6.TabIndex = 2;
			this.radGroupBox6.Text = "Emulator information";
			this.lblEmuPath.Location = new global::System.Drawing.Point(21, 89);
			this.lblEmuPath.Name = "lblEmuPath";
			this.lblEmuPath.Size = new global::System.Drawing.Size(11, 18);
			this.lblEmuPath.TabIndex = 7;
			this.lblEmuPath.Text = "-";
			this.label1.Location = new global::System.Drawing.Point(21, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(57, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Emulator :";
			this.lblEmuStatus.Location = new global::System.Drawing.Point(120, 42);
			this.lblEmuStatus.Name = "lblEmuStatus";
			this.lblEmuStatus.Size = new global::System.Drawing.Size(11, 18);
			this.lblEmuStatus.TabIndex = 6;
			this.lblEmuStatus.Text = "-";
			this.label2.Location = new global::System.Drawing.Point(21, 43);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(89, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Emulator status :";
			this.lblEmuName.Location = new global::System.Drawing.Point(120, 18);
			this.lblEmuName.Name = "lblEmuName";
			this.lblEmuName.Size = new global::System.Drawing.Size(11, 18);
			this.lblEmuName.TabIndex = 5;
			this.lblEmuName.Text = "-";
			this.label3.Location = new global::System.Drawing.Point(21, 65);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(82, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Emulator path :";
			this.radGroupBox3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox3.Controls.Add(this.cmdVerifyGame);
			this.radGroupBox3.Controls.Add(this.pictGame);
			this.radGroupBox3.Controls.Add(this.lblGameStatus);
			this.radGroupBox3.Controls.Add(this.radLabel6);
			this.radGroupBox3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.radGroupBox3.HeaderText = "Game Info";
			this.radGroupBox3.Location = new global::System.Drawing.Point(432, 18);
			this.radGroupBox3.Name = "radGroupBox3";
			this.radGroupBox3.Size = new global::System.Drawing.Size(280, 134);
			this.radGroupBox3.TabIndex = 2;
			this.radGroupBox3.Text = "Game Info";
			this.cmdVerifyGame.Location = new global::System.Drawing.Point(85, 105);
			this.cmdVerifyGame.Name = "cmdVerifyGame";
			this.cmdVerifyGame.Size = new global::System.Drawing.Size(110, 24);
			this.cmdVerifyGame.TabIndex = 13;
			this.cmdVerifyGame.Text = "Verify";
			this.cmdVerifyGame.Visible = false;
			this.cmdVerifyGame.Click += new global::System.EventHandler(this.cmdVerifyGame_Click);
			this.pictGame.Location = new global::System.Drawing.Point(227, 16);
			this.pictGame.Name = "pictGame";
			this.pictGame.Size = new global::System.Drawing.Size(48, 48);
			this.pictGame.TabIndex = 8;
			this.pictGame.TabStop = false;
			this.lblGameStatus.Location = new global::System.Drawing.Point(83, 21);
			this.lblGameStatus.Name = "lblGameStatus";
			this.lblGameStatus.Size = new global::System.Drawing.Size(11, 18);
			this.lblGameStatus.TabIndex = 10;
			this.lblGameStatus.Text = "-";
			this.radLabel6.Location = new global::System.Drawing.Point(6, 22);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new global::System.Drawing.Size(46, 18);
			this.radLabel6.TabIndex = 4;
			this.radLabel6.Text = "Status : ";
			this.radGroupBox4.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox4.Controls.Add(this.cmdVerifyUpdate);
			this.radGroupBox4.Controls.Add(this.chkExceptionUpdate);
			this.radGroupBox4.Controls.Add(this.lblUpdateVersion);
			this.radGroupBox4.Controls.Add(this.lblUpdateStatus);
			this.radGroupBox4.Controls.Add(this.radLabel7);
			this.radGroupBox4.Controls.Add(this.radLabel4);
			this.radGroupBox4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.radGroupBox4.HeaderText = "Update Info";
			this.radGroupBox4.Location = new global::System.Drawing.Point(712, 18);
			this.radGroupBox4.Name = "radGroupBox4";
			this.radGroupBox4.Size = new global::System.Drawing.Size(200, 134);
			this.radGroupBox4.TabIndex = 3;
			this.radGroupBox4.Text = "Update Info";
			this.cmdVerifyUpdate.Location = new global::System.Drawing.Point(45, 105);
			this.cmdVerifyUpdate.Name = "cmdVerifyUpdate";
			this.cmdVerifyUpdate.Size = new global::System.Drawing.Size(110, 24);
			this.cmdVerifyUpdate.TabIndex = 11;
			this.cmdVerifyUpdate.Text = "Verify";
			this.cmdVerifyUpdate.Visible = false;
			this.cmdVerifyUpdate.Click += new global::System.EventHandler(this.cmdVerifyUpdate_Click);
			this.chkExceptionUpdate.Location = new global::System.Drawing.Point(7, 70);
			this.chkExceptionUpdate.Name = "chkExceptionUpdate";
			this.chkExceptionUpdate.Size = new global::System.Drawing.Size(94, 18);
			this.chkExceptionUpdate.TabIndex = 10;
			this.chkExceptionUpdate.Text = "Do not unpack";
			this.chkExceptionUpdate.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkExceptionUpdate_ToggleStateChanged);
			this.lblUpdateVersion.Location = new global::System.Drawing.Point(84, 46);
			this.lblUpdateVersion.Name = "lblUpdateVersion";
			this.lblUpdateVersion.Size = new global::System.Drawing.Size(11, 18);
			this.lblUpdateVersion.TabIndex = 9;
			this.lblUpdateVersion.Text = "-";
			this.lblUpdateStatus.Location = new global::System.Drawing.Point(83, 22);
			this.lblUpdateStatus.Name = "lblUpdateStatus";
			this.lblUpdateStatus.Size = new global::System.Drawing.Size(11, 18);
			this.lblUpdateStatus.TabIndex = 7;
			this.lblUpdateStatus.Text = "-";
			this.radLabel7.Location = new global::System.Drawing.Point(7, 46);
			this.radLabel7.Name = "radLabel7";
			this.radLabel7.Size = new global::System.Drawing.Size(49, 18);
			this.radLabel7.TabIndex = 4;
			this.radLabel7.Text = "Version :";
			this.radLabel4.Location = new global::System.Drawing.Point(6, 22);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(46, 18);
			this.radLabel4.TabIndex = 2;
			this.radLabel4.Text = "Status : ";
			this.radGroupBox5.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox5.Controls.Add(this.cmdVerifyDlc);
			this.radGroupBox5.Controls.Add(this.chkExceptionDLC);
			this.radGroupBox5.Controls.Add(this.lblDLCStatus);
			this.radGroupBox5.Controls.Add(this.radLabel1);
			this.radGroupBox5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.radGroupBox5.HeaderText = "DLC Info";
			this.radGroupBox5.Location = new global::System.Drawing.Point(912, 18);
			this.radGroupBox5.Name = "radGroupBox5";
			this.radGroupBox5.Size = new global::System.Drawing.Size(200, 134);
			this.radGroupBox5.TabIndex = 4;
			this.radGroupBox5.Text = "DLC Info";
			this.cmdVerifyDlc.Location = new global::System.Drawing.Point(45, 105);
			this.cmdVerifyDlc.Name = "cmdVerifyDlc";
			this.cmdVerifyDlc.Size = new global::System.Drawing.Size(110, 24);
			this.cmdVerifyDlc.TabIndex = 12;
			this.cmdVerifyDlc.Text = "Verify";
			this.cmdVerifyDlc.Visible = false;
			this.cmdVerifyDlc.Click += new global::System.EventHandler(this.cmdVerifyDlc_Click);
			this.chkExceptionDLC.Location = new global::System.Drawing.Point(5, 70);
			this.chkExceptionDLC.Name = "chkExceptionDLC";
			this.chkExceptionDLC.Size = new global::System.Drawing.Size(94, 18);
			this.chkExceptionDLC.TabIndex = 11;
			this.chkExceptionDLC.Text = "Do not unpack";
			this.chkExceptionDLC.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkExceptionDLC_ToggleStateChanged);
			this.lblDLCStatus.Location = new global::System.Drawing.Point(88, 22);
			this.lblDLCStatus.Name = "lblDLCStatus";
			this.lblDLCStatus.Size = new global::System.Drawing.Size(11, 18);
			this.lblDLCStatus.TabIndex = 6;
			this.lblDLCStatus.Text = "-";
			this.radLabel1.Location = new global::System.Drawing.Point(11, 22);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(46, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Status : ";
			this.cmdDeleteGame.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdDeleteGame.Location = new global::System.Drawing.Point(386, 24);
			this.cmdDeleteGame.Name = "cmdDeleteGame";
			this.cmdDeleteGame.Size = new global::System.Drawing.Size(110, 24);
			this.cmdDeleteGame.TabIndex = 3;
			this.cmdDeleteGame.Text = "Delete Game";
			this.cmdDeleteGame.Click += new global::System.EventHandler(this.cmdDeleteGame_Click);
			this.cmdDeleteUpdate.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdDeleteUpdate.Location = new global::System.Drawing.Point(502, 24);
			this.cmdDeleteUpdate.Name = "cmdDeleteUpdate";
			this.cmdDeleteUpdate.Size = new global::System.Drawing.Size(110, 24);
			this.cmdDeleteUpdate.TabIndex = 4;
			this.cmdDeleteUpdate.Text = "Delete Update";
			this.cmdDeleteUpdate.Click += new global::System.EventHandler(this.cmdDeleteUpdate_Click);
			this.cmdDeleteDlc.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.cmdDeleteDlc.Location = new global::System.Drawing.Point(618, 24);
			this.cmdDeleteDlc.Name = "cmdDeleteDlc";
			this.cmdDeleteDlc.Size = new global::System.Drawing.Size(110, 24);
			this.cmdDeleteDlc.TabIndex = 4;
			this.cmdDeleteDlc.Text = "Delete DLC";
			this.cmdDeleteDlc.Click += new global::System.EventHandler(this.cmdDeleteDlc_Click);
			this.radGroupBox2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox2.Controls.Add(this.cmdDeleteDlc);
			this.radGroupBox2.Controls.Add(this.cmdDeleteGame);
			this.radGroupBox2.Controls.Add(this.cmdDeleteUpdate);
			this.radGroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.radGroupBox2.HeaderText = "Delete";
			this.radGroupBox2.Location = new global::System.Drawing.Point(0, 154);
			this.radGroupBox2.Name = "radGroupBox2";
			this.radGroupBox2.Size = new global::System.Drawing.Size(1114, 56);
			this.radGroupBox2.TabIndex = 1;
			this.radGroupBox2.Text = "Delete";
			base.ClientSize = new global::System.Drawing.Size(1114, 210);
			base.Controls.Add(this.radGroupBox1);
			base.Controls.Add(this.radGroupBox2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmEmuInfo";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Emulator Status";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmEmuInfo_FormClosing);
			base.Load += new global::System.EventHandler(this.frmEmuInfo_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox6).EndInit();
			this.radGroupBox6.ResumeLayout(false);
			this.radGroupBox6.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuPath).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuStatus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblEmuName).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox3).EndInit();
			this.radGroupBox3.ResumeLayout(false);
			this.radGroupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdVerifyGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblGameStatus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox4).EndInit();
			this.radGroupBox4.ResumeLayout(false);
			this.radGroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdVerifyUpdate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkExceptionUpdate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpdateVersion).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblUpdateStatus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox5).EndInit();
			this.radGroupBox5.ResumeLayout(false);
			this.radGroupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.cmdVerifyDlc).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkExceptionDLC).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.lblDLCStatus).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteUpdate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdDeleteDlc).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox2).EndInit();
			this.radGroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000655 RID: 1621
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000656 RID: 1622
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x04000657 RID: 1623
		private global::Telerik.WinControls.UI.RadButton cmdDeleteGame;

		// Token: 0x04000658 RID: 1624
		private global::Telerik.WinControls.UI.RadLabel label3;

		// Token: 0x04000659 RID: 1625
		private global::Telerik.WinControls.UI.RadLabel label2;

		// Token: 0x0400065A RID: 1626
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x0400065B RID: 1627
		private global::Telerik.WinControls.UI.RadLabel lblEmuPath;

		// Token: 0x0400065C RID: 1628
		private global::Telerik.WinControls.UI.RadLabel lblEmuStatus;

		// Token: 0x0400065D RID: 1629
		private global::Telerik.WinControls.UI.RadLabel lblEmuName;

		// Token: 0x0400065E RID: 1630
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox5;

		// Token: 0x0400065F RID: 1631
		private global::Telerik.WinControls.UI.RadLabel lblDLCStatus;

		// Token: 0x04000660 RID: 1632
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000661 RID: 1633
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox4;

		// Token: 0x04000662 RID: 1634
		private global::Telerik.WinControls.UI.RadLabel lblUpdateVersion;

		// Token: 0x04000663 RID: 1635
		private global::Telerik.WinControls.UI.RadLabel lblUpdateStatus;

		// Token: 0x04000664 RID: 1636
		private global::Telerik.WinControls.UI.RadLabel radLabel7;

		// Token: 0x04000665 RID: 1637
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x04000666 RID: 1638
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox3;

		// Token: 0x04000667 RID: 1639
		private global::Telerik.WinControls.UI.RadLabel lblGameStatus;

		// Token: 0x04000668 RID: 1640
		private global::Telerik.WinControls.UI.RadLabel radLabel6;

		// Token: 0x04000669 RID: 1641
		private global::Telerik.WinControls.UI.RadButton cmdDeleteUpdate;

		// Token: 0x0400066A RID: 1642
		private global::Telerik.WinControls.UI.RadButton cmdDeleteDlc;

		// Token: 0x0400066B RID: 1643
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox2;

		// Token: 0x0400066C RID: 1644
		private global::System.Windows.Forms.PictureBox pictGame;

		// Token: 0x0400066D RID: 1645
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox6;

		// Token: 0x0400066E RID: 1646
		private global::Telerik.WinControls.UI.RadCheckBox chkExceptionUpdate;

		// Token: 0x0400066F RID: 1647
		private global::Telerik.WinControls.UI.RadCheckBox chkExceptionDLC;

		// Token: 0x04000670 RID: 1648
		private global::Telerik.WinControls.UI.RadButton cmdVerifyGame;

		// Token: 0x04000671 RID: 1649
		private global::Telerik.WinControls.UI.RadButton cmdVerifyUpdate;

		// Token: 0x04000672 RID: 1650
		private global::Telerik.WinControls.UI.RadButton cmdVerifyDlc;
	}
}

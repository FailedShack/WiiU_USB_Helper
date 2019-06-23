namespace ns0
{
	// Token: 0x02000173 RID: 371
	public partial class frmCloudSaving : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x00017A76 File Offset: 0x00015C76
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003C43C File Offset: 0x0003A63C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmCloudSaving));
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.txtUsername = new global::Telerik.WinControls.UI.RadTextBox();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblShowPassword = new global::Telerik.WinControls.UI.RadLabel();
			this.txtPassword = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.radLogged = new global::Telerik.WinControls.UI.RadLabel();
			this.radEnable = new global::Telerik.WinControls.UI.RadToggleSwitch();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel5 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel6 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdManageSaves = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUsername).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblShowPassword).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtPassword).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLogged).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radEnable).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdManageSaves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.Location = new global::System.Drawing.Point(24, 32);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(62, 18);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = "Username :";
			this.radLabel2.Location = new global::System.Drawing.Point(24, 56);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(59, 18);
			this.radLabel2.TabIndex = 1;
			this.radLabel2.Text = "Password :";
			this.txtUsername.Location = new global::System.Drawing.Point(93, 29);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(218, 20);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.TextChanging += new global::Telerik.WinControls.TextChangingEventHandler(this.txtPassword_TextChanging);
			this.txtUsername.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.lblShowPassword);
			this.radGroupBox1.Controls.Add(this.txtPassword);
			this.radGroupBox1.Controls.Add(this.radButton1);
			this.radGroupBox1.Controls.Add(this.radLabel1);
			this.radGroupBox1.Controls.Add(this.radLogged);
			this.radGroupBox1.Controls.Add(this.radLabel2);
			this.radGroupBox1.Controls.Add(this.txtUsername);
			this.radGroupBox1.HeaderText = "Log in";
			this.radGroupBox1.Location = new global::System.Drawing.Point(54, 132);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(335, 163);
			this.radGroupBox1.TabIndex = 4;
			this.radGroupBox1.Text = "Log in";
			this.lblShowPassword.Location = new global::System.Drawing.Point(227, 80);
			this.lblShowPassword.Name = "lblShowPassword";
			this.lblShowPassword.Size = new global::System.Drawing.Size(84, 18);
			this.lblShowPassword.TabIndex = 9;
			this.lblShowPassword.Text = "Show Password";
			this.lblShowPassword.MouseEnter += new global::System.EventHandler(this.lblShowPassword_MouseEnter);
			this.lblShowPassword.MouseLeave += new global::System.EventHandler(this.lblShowPassword_MouseLeave);
			this.txtPassword.Location = new global::System.Drawing.Point(93, 54);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(218, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.TextChanging += new global::Telerik.WinControls.TextChangingEventHandler(this.txtPassword_TextChanging);
			this.txtPassword.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.radButton1.Image = global::ns0.Class121.icnMovieMini;
			this.radButton1.Location = new global::System.Drawing.Point(105, 104);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(133, 24);
			this.radButton1.TabIndex = 3;
			this.radButton1.Text = "Log in/Register";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.radLogged.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLogged.Location = new global::System.Drawing.Point(24, 134);
			this.radLogged.Name = "radLogged";
			this.radLogged.Size = new global::System.Drawing.Size(79, 24);
			this.radLogged.TabIndex = 8;
			this.radLogged.Text = "radLabel4";
			this.radEnable.Enabled = false;
			this.radEnable.Location = new global::System.Drawing.Point(138, 304);
			this.radEnable.Name = "radEnable";
			this.radEnable.Size = new global::System.Drawing.Size(99, 20);
			this.radEnable.TabIndex = 5;
			this.radEnable.Value = false;
			this.radEnable.ValueChanged += new global::System.EventHandler(this.radEnable_ValueChanged);
			this.radLabel3.Location = new global::System.Drawing.Point(21, 304);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(111, 18);
			this.radLabel3.TabIndex = 6;
			this.radLabel3.Text = "Enable cloud saving :";
			this.pictureBox1.Image = global::ns0.Class121.logo_horiz;
			this.pictureBox1.Location = new global::System.Drawing.Point(21, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(401, 83);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.radLabel4.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel4.Location = new global::System.Drawing.Point(21, 74);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(146, 18);
			this.radLabel4.TabIndex = 9;
			this.radLabel4.Text = "This feature is experimental.";
			this.radLabel5.Location = new global::System.Drawing.Point(21, 88);
			this.radLabel5.Name = "radLabel5";
			this.radLabel5.Size = new global::System.Drawing.Size(385, 18);
			this.radLabel5.TabIndex = 10;
			this.radLabel5.Text = "If you enable it, all your Cemu and Citra saves will be uploaded to the cloud.";
			this.radLabel6.Location = new global::System.Drawing.Point(21, 108);
			this.radLabel6.Name = "radLabel6";
			this.radLabel6.Size = new global::System.Drawing.Size(344, 18);
			this.radLabel6.TabIndex = 11;
			this.radLabel6.Text = "This way you can easily share your saves across multiple computers.";
			this.cmdManageSaves.Enabled = false;
			this.cmdManageSaves.Image = global::ns0.Class121.icnCaseMini;
			this.cmdManageSaves.Location = new global::System.Drawing.Point(243, 301);
			this.cmdManageSaves.Name = "cmdManageSaves";
			this.cmdManageSaves.Size = new global::System.Drawing.Size(163, 24);
			this.cmdManageSaves.TabIndex = 12;
			this.cmdManageSaves.Text = "Manage my cloud saves...";
			this.cmdManageSaves.Click += new global::System.EventHandler(this.cmdManageSaves_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(442, 334);
			base.Controls.Add(this.cmdManageSaves);
			base.Controls.Add(this.radLabel6);
			base.Controls.Add(this.radLabel5);
			base.Controls.Add(this.radLabel4);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.radLabel3);
			base.Controls.Add(this.radEnable);
			base.Controls.Add(this.radGroupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmCloudSaving";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cloud Saving";
			base.Load += new global::System.EventHandler(this.frmCloudSaving_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUsername).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblShowPassword).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtPassword).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLogged).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radEnable).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdManageSaves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400060D RID: 1549
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400060E RID: 1550
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x0400060F RID: 1551
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x04000610 RID: 1552
		private global::Telerik.WinControls.UI.RadTextBox txtUsername;

		// Token: 0x04000611 RID: 1553
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x04000612 RID: 1554
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x04000613 RID: 1555
		private global::Telerik.WinControls.UI.RadToggleSwitch radEnable;

		// Token: 0x04000614 RID: 1556
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x04000615 RID: 1557
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000616 RID: 1558
		private global::Telerik.WinControls.UI.RadLabel radLogged;

		// Token: 0x04000617 RID: 1559
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x04000618 RID: 1560
		private global::Telerik.WinControls.UI.RadLabel radLabel5;

		// Token: 0x04000619 RID: 1561
		private global::Telerik.WinControls.UI.RadLabel radLabel6;

		// Token: 0x0400061A RID: 1562
		private global::Telerik.WinControls.UI.RadTextBoxControl txtPassword;

		// Token: 0x0400061B RID: 1563
		private global::Telerik.WinControls.UI.RadButton cmdManageSaves;

		// Token: 0x0400061C RID: 1564
		private global::Telerik.WinControls.UI.RadLabel lblShowPassword;
	}
}

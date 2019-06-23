namespace ns0
{
	// Token: 0x020001AE RID: 430
	public partial class frmUnhandledException : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x000186F7 File Offset: 0x000168F7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0004A050 File Offset: 0x00048250
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmUnhandledException));
			this.cmdLater = new global::Telerik.WinControls.UI.RadButton();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.radGroupBox1 = new global::Telerik.WinControls.UI.RadGroupBox();
			this.lblException = new global::Telerik.WinControls.UI.RadTextBoxControl();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.cmdLater).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblException).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.cmdLater.Location = new global::System.Drawing.Point(205, 550);
			this.cmdLater.Name = "cmdLater";
			this.cmdLater.Size = new global::System.Drawing.Size(163, 29);
			this.cmdLater.TabIndex = 35;
			this.cmdLater.Text = "Close the app";
			this.cmdLater.ThemeName = "VisualStudio2012Dark";
			this.cmdLater.Click += new global::System.EventHandler(this.cmdLater_Click);
			this.radLabel1.AutoSize = false;
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.Location = new global::System.Drawing.Point(118, 42);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(454, 185);
			this.radLabel1.TabIndex = 32;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.radLabel1.ThemeName = "VisualStudio2012Dark";
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(118, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(325, 24);
			this.label1.TabIndex = 31;
			this.label1.Text = "Wii U USB Helper has encountered an issue.";
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.pictureBox1.Image = global::ns0.Class121.logo;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(94, 91);
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			this.radLabel2.Location = new global::System.Drawing.Point(5, 21);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(60, 18);
			this.radLabel2.TabIndex = 36;
			this.radLabel2.Text = "Exception :";
			this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.lblException);
			this.radGroupBox1.Controls.Add(this.radLabel2);
			this.radGroupBox1.HeaderText = "Info";
			this.radGroupBox1.Location = new global::System.Drawing.Point(12, 279);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Size = new global::System.Drawing.Size(560, 265);
			this.radGroupBox1.TabIndex = 37;
			this.radGroupBox1.Text = "Info";
			this.lblException.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.lblException.Font = new global::System.Drawing.Font("Consolas", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblException.ForeColor = global::System.Drawing.Color.Lime;
			this.lblException.IsReadOnly = true;
			this.lblException.Location = new global::System.Drawing.Point(6, 46);
			this.lblException.Multiline = true;
			this.lblException.Name = "lblException";
			this.lblException.Size = new global::System.Drawing.Size(549, 214);
			this.lblException.TabIndex = 37;
			this.lblException.TabStop = false;
			this.radButton1.Location = new global::System.Drawing.Point(208, 244);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(163, 29);
			this.radButton1.TabIndex = 36;
			this.radButton1.Text = "Go the Help Center";
			this.radButton1.ThemeName = "VisualStudio2012Dark";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(579, 583);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.radGroupBox1);
			base.Controls.Add(this.cmdLater);
			base.Controls.Add(this.radLabel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmUnhandledException";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "An error has occured";
			((global::System.ComponentModel.ISupportInitialize)this.cmdLater).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.lblException).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000772 RID: 1906
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000773 RID: 1907
		private global::Telerik.WinControls.UI.RadButton cmdLater;

		// Token: 0x04000774 RID: 1908
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000775 RID: 1909
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000776 RID: 1910
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000777 RID: 1911
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x04000778 RID: 1912
		private global::Telerik.WinControls.UI.RadGroupBox radGroupBox1;

		// Token: 0x04000779 RID: 1913
		private global::Telerik.WinControls.UI.RadTextBoxControl lblException;

		// Token: 0x0400077A RID: 1914
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}

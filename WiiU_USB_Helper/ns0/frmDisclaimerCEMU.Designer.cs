namespace ns0
{
	// Token: 0x02000190 RID: 400
	public partial class frmDisclaimerCEMU : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00017F6A File Offset: 0x0001616A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000426BC File Offset: 0x000408BC
		private void InitializeComponent()
		{
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.cmdClearDl = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearDl).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = false;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new global::System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(424, 62);
			this.label1.TabIndex = 1;
			this.label1.Text = "This feature is powered by Cemu.\r\nhttp://cemu.info/\r\nYou need to have a powerful pc to be able to play games.\r\nPlease note that the emulator is still in development so you might encounter issues.\r\n";
			this.label1.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.cmdClearDl.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.cmdClearDl.Location = new global::System.Drawing.Point(10, 79);
			this.cmdClearDl.Name = "cmdClearDl";
			this.cmdClearDl.Size = new global::System.Drawing.Size(424, 20);
			this.cmdClearDl.TabIndex = 27;
			this.cmdClearDl.Text = "Got it";
			this.cmdClearDl.ThemeName = "VisualStudio2012Dark";
			this.cmdClearDl.Click += new global::System.EventHandler(this.cmdClearDl_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(444, 109);
			base.Controls.Add(this.cmdClearDl);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "frmDisclaimerCEMU";
			base.Padding = new global::System.Windows.Forms.Padding(10);
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cemu";
			base.Load += new global::System.EventHandler(this.frmDisclaimerCEMU_Load);
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdClearDl).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006AD RID: 1709
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006AE RID: 1710
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x040006AF RID: 1711
		private global::Telerik.WinControls.UI.RadButton cmdClearDl;
	}
}

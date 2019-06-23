namespace ns0
{
	// Token: 0x020001CF RID: 463
	public partial class FrmWhatToCopy : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C9B RID: 3227 RVA: 0x00018C7C File Offset: 0x00016E7C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00050890 File Offset: 0x0004EA90
		private void InitializeComponent()
		{
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.chkCopyGame = new global::Telerik.WinControls.UI.RadCheckBox();
			this.chkCopyUpdate = new global::Telerik.WinControls.UI.RadCheckBox();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.chkCopyDlc = new global::Telerik.WinControls.UI.RadCheckBox();
			this.title = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyUpdate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyDlc).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.title).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.label1.Location = new global::System.Drawing.Point(56, 47);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(185, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select what you would like to copy :";
			this.chkCopyGame.Location = new global::System.Drawing.Point(102, 75);
			this.chkCopyGame.Name = "chkCopyGame";
			this.chkCopyGame.Size = new global::System.Drawing.Size(49, 18);
			this.chkCopyGame.TabIndex = 1;
			this.chkCopyGame.Text = "Game";
			this.chkCopyUpdate.Location = new global::System.Drawing.Point(102, 99);
			this.chkCopyUpdate.Name = "chkCopyUpdate";
			this.chkCopyUpdate.Size = new global::System.Drawing.Size(57, 18);
			this.chkCopyUpdate.TabIndex = 2;
			this.chkCopyUpdate.Text = "Update";
			this.chkCopyUpdate.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkCopyUpdate_ToggleStateChanged);
			this.radButton1.Location = new global::System.Drawing.Point(90, 147);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(110, 24);
			this.radButton1.TabIndex = 3;
			this.radButton1.Text = "Ok";
			this.radButton1.ThemeName = "Desert";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.chkCopyDlc.Location = new global::System.Drawing.Point(102, 123);
			this.chkCopyDlc.Name = "chkCopyDlc";
			this.chkCopyDlc.Size = new global::System.Drawing.Size(40, 18);
			this.chkCopyDlc.TabIndex = 3;
			this.chkCopyDlc.Text = "DLC";
			this.title.AutoSize = false;
			this.title.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.title.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.title.Location = new global::System.Drawing.Point(0, 0);
			this.title.Name = "title";
			this.title.Size = new global::System.Drawing.Size(296, 45);
			this.title.TabIndex = 4;
			this.title.Text = "label2";
			this.title.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
			this.title.UseMnemonic = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(296, 172);
			base.Controls.Add(this.title);
			base.Controls.Add(this.chkCopyDlc);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.chkCopyUpdate);
			base.Controls.Add(this.chkCopyGame);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FrmWhatToCopy";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "What to copy?";
			base.ThemeName = "Desert";
			base.Load += new global::System.EventHandler(this.FrmWhatToCopy_Load);
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyUpdate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkCopyDlc).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.title).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000850 RID: 2128
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000851 RID: 2129
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000852 RID: 2130
		private global::Telerik.WinControls.UI.RadCheckBox chkCopyGame;

		// Token: 0x04000853 RID: 2131
		private global::Telerik.WinControls.UI.RadCheckBox chkCopyUpdate;

		// Token: 0x04000854 RID: 2132
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x04000855 RID: 2133
		private global::Telerik.WinControls.UI.RadCheckBox chkCopyDlc;

		// Token: 0x04000856 RID: 2134
		private global::Telerik.WinControls.UI.RadLabel title;
	}
}

namespace ns0
{
	// Token: 0x0200013F RID: 319
	public partial class frmChangeLog : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x000158A9 File Offset: 0x00013AA9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00036238 File Offset: 0x00034438
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmChangeLog));
			this.txtLog = new global::Telerik.WinControls.UI.RadTextBox();
			((global::System.ComponentModel.ISupportInitialize)this.txtLog).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.txtLog.AutoSize = false;
			this.txtLog.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Font = new global::System.Drawing.Font("Consolas", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtLog.Location = new global::System.Drawing.Point(0, 0);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.txtLog.Size = new global::System.Drawing.Size(736, 504);
			this.txtLog.TabIndex = 0;
			this.txtLog.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(736, 504);
			base.Controls.Add(this.txtLog);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmChangeLog";
			base.RootElement.ApplyShapeToControl = true;
			this.Text = "Changelog";
			base.ThemeName = "VisualStudio2012Dark";
			base.Load += new global::System.EventHandler(this.frmChangeLog_Load);
			((global::System.ComponentModel.ISupportInitialize)this.txtLog).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000514 RID: 1300
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000515 RID: 1301
		private global::Telerik.WinControls.UI.RadTextBox txtLog;
	}
}

namespace ns0
{
	// Token: 0x02000186 RID: 390
	public partial class frmException : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B23 RID: 2851 RVA: 0x00017D77 File Offset: 0x00015F77
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000409D0 File Offset: 0x0003EBD0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmException));
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Padding = new global::System.Windows.Forms.Padding(20);
			this.radLabel1.Size = new global::System.Drawing.Size(1143, 167);
			this.radLabel1.TabIndex = 0;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radButton1.Location = new global::System.Drawing.Point(502, 173);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(110, 24);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "Ok";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1130, 203);
			base.Controls.Add(this.radButton1);
			base.Controls.Add(this.radLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmException";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Error";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.frmException_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000681 RID: 1665
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000682 RID: 1666
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000683 RID: 1667
		private global::Telerik.WinControls.UI.RadButton radButton1;
	}
}

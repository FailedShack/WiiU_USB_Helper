namespace ns0
{
	// Token: 0x0200018D RID: 397
	public partial class frmBug : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x00017EB5 File Offset: 0x000160B5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00041D70 File Offset: 0x0003FF70
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmBug));
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new global::System.Drawing.Size(1081, 650);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.Url = new global::System.Uri("http://bug.wiiuusbhelper.com", global::System.UriKind.Absolute);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1081, 650);
			base.Controls.Add(this.webBrowser1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmBug";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Bug Tracker";
			base.Load += new global::System.EventHandler(this.frmBug_Load);
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006A0 RID: 1696
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006A1 RID: 1697
		private global::System.Windows.Forms.WebBrowser webBrowser1;
	}
}

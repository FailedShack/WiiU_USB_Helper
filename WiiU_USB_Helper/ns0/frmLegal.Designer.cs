namespace ns0
{
	// Token: 0x0200019D RID: 413
	public partial class frmLegal : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B9C RID: 2972 RVA: 0x000182B3 File Offset: 0x000164B3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000451DC File Offset: 0x000433DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmLegal));
			this.radTextBoxControl1 = new global::Telerik.WinControls.UI.RadTextBoxControl();
			((global::System.ComponentModel.ISupportInitialize)this.radTextBoxControl1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radTextBoxControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radTextBoxControl1.Location = new global::System.Drawing.Point(0, 0);
			this.radTextBoxControl1.Multiline = true;
			this.radTextBoxControl1.Name = "radTextBoxControl1";
			this.radTextBoxControl1.Size = new global::System.Drawing.Size(986, 711);
			this.radTextBoxControl1.TabIndex = 0;
			this.radTextBoxControl1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(986, 711);
			base.Controls.Add(this.radTextBoxControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmLegal";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Legal Notice";
			base.Load += new global::System.EventHandler(this.frmLegal_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radTextBoxControl1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006F8 RID: 1784
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006F9 RID: 1785
		private global::Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
	}
}

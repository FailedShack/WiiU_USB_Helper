namespace ns0
{
	// Token: 0x020001A6 RID: 422
	public partial class frmRawOrEmu : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00018519 File Offset: 0x00016719
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00046A78 File Offset: 0x00044C78
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmRawOrEmu));
			this.radButton1 = new global::Telerik.WinControls.UI.RadButton();
			this.radButton2 = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radButton1.Location = new global::System.Drawing.Point(25, 22);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new global::System.Drawing.Size(262, 24);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "Delete the RAW content (for physical systems)";
			this.radButton1.Click += new global::System.EventHandler(this.radButton1_Click);
			this.radButton2.Location = new global::System.Drawing.Point(25, 52);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new global::System.Drawing.Size(262, 24);
			this.radButton2.TabIndex = 1;
			this.radButton2.Text = "Delete the emulation content (for emulators)\r\n";
			this.radButton2.Click += new global::System.EventHandler(this.radButton2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(312, 99);
			base.Controls.Add(this.radButton2);
			base.Controls.Add(this.radButton1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmRawOrEmu";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "What to delete";
			base.Load += new global::System.EventHandler(this.frmRawOrEmu_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radButton2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000722 RID: 1826
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000723 RID: 1827
		private global::Telerik.WinControls.UI.RadButton radButton1;

		// Token: 0x04000724 RID: 1828
		private global::Telerik.WinControls.UI.RadButton radButton2;
	}
}

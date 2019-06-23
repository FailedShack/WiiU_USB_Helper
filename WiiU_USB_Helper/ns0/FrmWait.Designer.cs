namespace ns0
{
	// Token: 0x020001C9 RID: 457
	public partial class FrmWait : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00018BB3 File Offset: 0x00016DB3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00050170 File Offset: 0x0004E370
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.lblMessage = new global::Telerik.WinControls.UI.RadLabel();
			this.radProgressBar1 = new global::Telerik.WinControls.UI.RadProgressBar();
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.loadingCircle1 = new global::ns0.GControl0();
			((global::System.ComponentModel.ISupportInitialize)this.lblMessage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radProgressBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.lblMessage.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMessage.Location = new global::System.Drawing.Point(111, 111);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new global::System.Drawing.Size(62, 18);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "lblMessage";
			this.lblMessage.SizeChanged += new global::System.EventHandler(this.lblMessage_SizeChanged);
			this.radProgressBar1.Location = new global::System.Drawing.Point(3, 133);
			this.radProgressBar1.Name = "radProgressBar1";
			this.radProgressBar1.ShowProgressIndicators = true;
			this.radProgressBar1.Size = new global::System.Drawing.Size(282, 24);
			this.radProgressBar1.TabIndex = 2;
			this.radProgressBar1.Text = "0 %";
			this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
			this.loadingCircle1.Boolean_0 = false;
			this.loadingCircle1.BackColor = global::System.Drawing.Color.Transparent;
			this.loadingCircle1.Color_0 = global::System.Drawing.Color.DarkGray;
			this.loadingCircle1.Int32_0 = 5;
			this.loadingCircle1.Location = new global::System.Drawing.Point(-3, 0);
			this.loadingCircle1.Name = "loadingCircle1";
			this.loadingCircle1.Int32_1 = 12;
			this.loadingCircle1.Int32_2 = 11;
			this.loadingCircle1.Int32_3 = 200;
			this.loadingCircle1.Size = new global::System.Drawing.Size(293, 129);
			this.loadingCircle1.Int32_4 = 2;
			this.loadingCircle1.GEnum8_0 = global::ns0.GControl0.GEnum8.const_0;
			this.loadingCircle1.TabIndex = 3;
			this.loadingCircle1.Text = "loadingCircle1";
			this.loadingCircle1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.loadingCircle1_Paint);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(285, 129);
			base.Controls.Add(this.loadingCircle1);
			base.Controls.Add(this.radProgressBar1);
			base.Controls.Add(this.lblMessage);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FrmWait";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Please wait";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmWait_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmWait_Load);
			base.Shown += new global::System.EventHandler(this.FrmWait_Shown);
			base.SizeChanged += new global::System.EventHandler(this.FrmWait_SizeChanged);
			((global::System.ComponentModel.ISupportInitialize)this.lblMessage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radProgressBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000836 RID: 2102
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000837 RID: 2103
		private global::Telerik.WinControls.UI.RadLabel lblMessage;

		// Token: 0x04000838 RID: 2104
		private global::Telerik.WinControls.UI.RadProgressBar radProgressBar1;

		// Token: 0x04000839 RID: 2105
		private global::System.Windows.Forms.Timer timer_1;

		// Token: 0x0400083A RID: 2106
		private global::ns0.GControl0 loadingCircle1;
	}
}

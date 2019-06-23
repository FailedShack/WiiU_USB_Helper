namespace ns0
{
	// Token: 0x0200019E RID: 414
	public partial class frmLoadOverlay : global::ns0.GForm1
	{
		// Token: 0x06000BA0 RID: 2976 RVA: 0x000182FC File Offset: 0x000164FC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004538C File Offset: 0x0004358C
		private void InitializeComponent()
		{
			this.radWaitingBar1 = new global::Telerik.WinControls.UI.RadWaitingBar();
			this.rotatingRingsWaitingBarIndicatorElement1 = new global::Telerik.WinControls.UI.RotatingRingsWaitingBarIndicatorElement();
			this.progressBar = new global::Telerik.WinControls.UI.RadProgressBar();
			((global::System.ComponentModel.ISupportInitialize)this.radWaitingBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.progressBar).BeginInit();
			base.SuspendLayout();
			this.radWaitingBar1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.radWaitingBar1.Location = new global::System.Drawing.Point(1311, -1);
			this.radWaitingBar1.Name = "radWaitingBar1";
			this.radWaitingBar1.RootElement.FocusBorderColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radWaitingBar1.Size = new global::System.Drawing.Size(70, 70);
			this.radWaitingBar1.TabIndex = 1;
			this.radWaitingBar1.Text = "radWaitingBar1";
			this.radWaitingBar1.WaitingIndicators.Add(this.rotatingRingsWaitingBarIndicatorElement1);
			this.radWaitingBar1.WaitingStep = 7;
			this.radWaitingBar1.WaitingStyle = global::Telerik.WinControls.Enumerations.WaitingBarStyles.RotatingRings;
			((global::Telerik.WinControls.UI.RadWaitingBarElement)this.radWaitingBar1.GetChildAt(0)).WaitingStep = 7;
			((global::Telerik.WinControls.UI.WaitingBarSeparatorElement)this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0)).Dash = false;
			this.rotatingRingsWaitingBarIndicatorElement1.AutoSize = true;
			this.rotatingRingsWaitingBarIndicatorElement1.BackColor = global::System.Drawing.Color.Black;
			this.rotatingRingsWaitingBarIndicatorElement1.BackColor2 = global::System.Drawing.Color.Black;
			this.rotatingRingsWaitingBarIndicatorElement1.BackColor3 = global::System.Drawing.Color.Black;
			this.rotatingRingsWaitingBarIndicatorElement1.BackColor4 = global::System.Drawing.Color.Black;
			this.rotatingRingsWaitingBarIndicatorElement1.ElementColor = global::System.Drawing.Color.Coral;
			this.rotatingRingsWaitingBarIndicatorElement1.ElementColor2 = global::System.Drawing.Color.FromArgb(255, 10, 63);
			this.rotatingRingsWaitingBarIndicatorElement1.ElementColor3 = global::System.Drawing.Color.FromArgb(255, 125, 10);
			this.rotatingRingsWaitingBarIndicatorElement1.ElementCount = 5;
			this.rotatingRingsWaitingBarIndicatorElement1.FocusBorderColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.rotatingRingsWaitingBarIndicatorElement1.InnerRingBackgroundColor = global::System.Drawing.Color.FromArgb(255, 63, 10);
			this.rotatingRingsWaitingBarIndicatorElement1.Name = "rotatingRingsWaitingBarIndicatorElement1";
			this.rotatingRingsWaitingBarIndicatorElement1.OuterRingBackgroundColor = global::System.Drawing.Color.FromArgb(255, 10, 10);
			this.rotatingRingsWaitingBarIndicatorElement1.Radius = 20;
			this.progressBar.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.progressBar.Location = new global::System.Drawing.Point(23, 22);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new global::System.Drawing.Size(1292, 24);
			this.progressBar.TabIndex = 2;
			this.progressBar.Value1 = 50;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1393, 68);
			base.Controls.Add(this.progressBar);
			base.Controls.Add(this.radWaitingBar1);
			base.Name = "frmLoadOverlay";
			((global::System.ComponentModel.ISupportInitialize)this.radWaitingBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.progressBar).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006FA RID: 1786
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006FB RID: 1787
		private global::Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;

		// Token: 0x040006FC RID: 1788
		private global::Telerik.WinControls.UI.RotatingRingsWaitingBarIndicatorElement rotatingRingsWaitingBarIndicatorElement1;

		// Token: 0x040006FD RID: 1789
		private global::Telerik.WinControls.UI.RadProgressBar progressBar;
	}
}

namespace ns0
{
	// Token: 0x02000192 RID: 402
	public partial class frmHelpOverlay : global::ns0.GForm1
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x00018052 File Offset: 0x00016252
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00043320 File Offset: 0x00041520
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictArrow = new global::System.Windows.Forms.PictureBox();
			this.btnGotcha = new global::Telerik.WinControls.UI.RadButton();
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.pictArrow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnGotcha).BeginInit();
			base.SuspendLayout();
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 51.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(1357, 789);
			this.label1.TabIndex = 0;
			this.label1.Text = "_";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.pictArrow.Image = global::ns0.Class121.imgArrow;
			this.pictArrow.Location = new global::System.Drawing.Point(62, 49);
			this.pictArrow.Name = "pictArrow";
			this.pictArrow.Size = new global::System.Drawing.Size(200, 200);
			this.pictArrow.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictArrow.TabIndex = 1;
			this.pictArrow.TabStop = false;
			this.btnGotcha.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGotcha.Location = new global::System.Drawing.Point(1139, 728);
			this.btnGotcha.Name = "btnGotcha";
			this.btnGotcha.Size = new global::System.Drawing.Size(206, 49);
			this.btnGotcha.TabIndex = 2;
			this.btnGotcha.Text = "Gotcha!";
			this.btnGotcha.Click += new global::System.EventHandler(this.btnGotcha_Click);
			this.timer_1.Enabled = true;
			this.timer_1.Interval = 33;
			this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1357, 789);
			base.Controls.Add(this.btnGotcha);
			base.Controls.Add(this.pictArrow);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmHelpOverlay";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmHelpOverlay";
			((global::System.ComponentModel.ISupportInitialize)this.pictArrow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnGotcha).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040006BF RID: 1727
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006C0 RID: 1728
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040006C1 RID: 1729
		private global::System.Windows.Forms.PictureBox pictArrow;

		// Token: 0x040006C2 RID: 1730
		private global::Telerik.WinControls.UI.RadButton btnGotcha;

		// Token: 0x040006C3 RID: 1731
		private global::System.Windows.Forms.Timer timer_1;
	}
}

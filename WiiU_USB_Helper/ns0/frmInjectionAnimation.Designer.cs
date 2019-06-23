namespace ns0
{
	// Token: 0x02000198 RID: 408
	public partial class frmInjectionAnimation : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B89 RID: 2953 RVA: 0x00018203 File Offset: 0x00016403
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00044840 File Offset: 0x00042A40
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmInjectionAnimation));
			this.pctAarrow = new global::System.Windows.Forms.PictureBox();
			this.radLabel4 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel3 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.chkListenToMusic = new global::Telerik.WinControls.UI.RadCheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.pctAarrow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkListenToMusic).BeginInit();
			base.SuspendLayout();
			this.pctAarrow.BackColor = global::System.Drawing.Color.Transparent;
			this.pctAarrow.Image = global::ns0.Class121.icnArrow;
			this.pctAarrow.Location = new global::System.Drawing.Point(227, 35);
			this.pctAarrow.Name = "pctAarrow";
			this.pctAarrow.Size = new global::System.Drawing.Size(32, 32);
			this.pctAarrow.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctAarrow.TabIndex = 11;
			this.pctAarrow.TabStop = false;
			this.radLabel4.BackColor = global::System.Drawing.Color.Transparent;
			this.radLabel4.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel4.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel4.Location = new global::System.Drawing.Point(271, 144);
			this.radLabel4.Name = "radLabel4";
			this.radLabel4.Size = new global::System.Drawing.Size(184, 19);
			this.radLabel4.TabIndex = 10;
			this.radLabel4.Text = "Step 4 : Packing the game...";
			this.radLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.radLabel3.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel3.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel3.Location = new global::System.Drawing.Point(271, 110);
			this.radLabel3.Name = "radLabel3";
			this.radLabel3.Size = new global::System.Drawing.Size(191, 19);
			this.radLabel3.TabIndex = 9;
			this.radLabel3.Text = "Step 3 : Injecting the game...";
			this.radLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.radLabel2.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel2.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel2.Location = new global::System.Drawing.Point(271, 76);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(181, 19);
			this.radLabel2.TabIndex = 8;
			this.radLabel2.Text = "Step 2 : Shrinking the ISO...";
			this.radLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.radLabel1.Font = new global::System.Drawing.Font("Trebuchet MS", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.radLabel1.Location = new global::System.Drawing.Point(271, 42);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(206, 19);
			this.radLabel1.TabIndex = 7;
			this.radLabel1.Text = "Step 1 : Fetching the content...";
			this.timer_0.Interval = 33;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new global::System.Drawing.Point(36, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(160, 160);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
			this.chkListenToMusic.Location = new global::System.Drawing.Point(259, 174);
			this.chkListenToMusic.Name = "chkListenToMusic";
			this.chkListenToMusic.Size = new global::System.Drawing.Size(218, 18);
			this.chkListenToMusic.TabIndex = 13;
			this.chkListenToMusic.Text = "Why not listen to the OST of the game?";
			this.chkListenToMusic.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.chkListenToMusic_ToggleStateChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ns0.Class121.bg;
			base.ClientSize = new global::System.Drawing.Size(489, 204);
			base.Controls.Add(this.chkListenToMusic);
			base.Controls.Add(this.pctAarrow);
			base.Controls.Add(this.radLabel4);
			base.Controls.Add(this.radLabel3);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.radLabel1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmInjectionAnimation";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Injecting...";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmInjectionAnimation_FormClosing);
			base.Shown += new global::System.EventHandler(this.frmInjectionAnimation_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.pctAarrow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chkListenToMusic).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040006E5 RID: 1765
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040006E6 RID: 1766
		private global::System.Windows.Forms.PictureBox pctAarrow;

		// Token: 0x040006E7 RID: 1767
		private global::Telerik.WinControls.UI.RadLabel radLabel4;

		// Token: 0x040006E8 RID: 1768
		private global::Telerik.WinControls.UI.RadLabel radLabel3;

		// Token: 0x040006E9 RID: 1769
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x040006EA RID: 1770
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x040006EB RID: 1771
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040006EC RID: 1772
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040006ED RID: 1773
		private global::System.Windows.Forms.Timer timer_1;

		// Token: 0x040006EE RID: 1774
		private global::Telerik.WinControls.UI.RadCheckBox chkListenToMusic;
	}
}

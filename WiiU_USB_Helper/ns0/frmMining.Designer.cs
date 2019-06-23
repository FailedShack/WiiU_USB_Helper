namespace ns0
{
	// Token: 0x020001A3 RID: 419
	public partial class frmMining : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BB7 RID: 2999 RVA: 0x0001849A File Offset: 0x0001669A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00046124 File Offset: 0x00044324
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmMining));
			this.radLabel1 = new global::Telerik.WinControls.UI.RadLabel();
			this.label1 = new global::Telerik.WinControls.UI.RadLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.cmdYes = new global::Telerik.WinControls.UI.RadButton();
			this.cmdNo = new global::Telerik.WinControls.UI.RadButton();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.radPause = new global::Telerik.WinControls.UI.RadCheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdYes).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdNo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radPause).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radLabel1.AutoSize = false;
			this.radLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel1.Location = new global::System.Drawing.Point(106, 32);
			this.radLabel1.Name = "radLabel1";
			this.radLabel1.Size = new global::System.Drawing.Size(502, 433);
			this.radLabel1.TabIndex = 5;
			this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
			this.radLabel1.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.radLabel1.ThemeName = "VisualStudio2012Dark";
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(106, 2);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(286, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Thank you for wanting to support me!";
			this.label1.ThemeName = "VisualStudio2012Dark";
			this.pictureBox1.Image = global::ns0.Class121.logo;
			this.pictureBox1.Location = new global::System.Drawing.Point(6, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(94, 91);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.cmdYes.Location = new global::System.Drawing.Point(128, 471);
			this.cmdYes.Name = "cmdYes";
			this.cmdYes.Size = new global::System.Drawing.Size(180, 24);
			this.cmdYes.TabIndex = 6;
			this.cmdYes.Text = "Sure!";
			this.cmdYes.Click += new global::System.EventHandler(this.cmdYes_Click);
			this.cmdNo.Location = new global::System.Drawing.Point(314, 471);
			this.cmdNo.Name = "cmdNo";
			this.cmdNo.Size = new global::System.Drawing.Size(180, 24);
			this.cmdNo.TabIndex = 7;
			this.cmdNo.Text = "Maybe some other time";
			this.cmdNo.Click += new global::System.EventHandler(this.cmdNo_Click);
			this.pictureBox2.Image = global::ns0.Class121.stopMiner;
			this.pictureBox2.Location = new global::System.Drawing.Point(405, 501);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(212, 69);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			this.pictureBox3.Image = global::ns0.Class121.startMiner;
			this.pictureBox3.Location = new global::System.Drawing.Point(26, 501);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(202, 78);
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			this.radPause.Location = new global::System.Drawing.Point(5, 561);
			this.radPause.Name = "radPause";
			this.radPause.Size = new global::System.Drawing.Size(303, 18);
			this.radPause.TabIndex = 10;
			this.radPause.Text = "Pause the miner when using the \"Play this game\" feature";
			this.radPause.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.radPause_ToggleStateChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(636, 579);
			base.Controls.Add(this.radPause);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.cmdNo);
			base.Controls.Add(this.radLabel1);
			base.Controls.Add(this.cmdYes);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmMining";
			base.RootElement.ApplyShapeToControl = true;
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "I want to help!";
			base.Load += new global::System.EventHandler(this.frmMining_Load);
			((global::System.ComponentModel.ISupportInitialize)this.radLabel1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.label1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdYes).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.cmdNo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radPause).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000710 RID: 1808
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000711 RID: 1809
		private global::Telerik.WinControls.UI.RadLabel radLabel1;

		// Token: 0x04000712 RID: 1810
		private global::Telerik.WinControls.UI.RadLabel label1;

		// Token: 0x04000713 RID: 1811
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000714 RID: 1812
		private global::Telerik.WinControls.UI.RadButton cmdYes;

		// Token: 0x04000715 RID: 1813
		private global::Telerik.WinControls.UI.RadButton cmdNo;

		// Token: 0x04000716 RID: 1814
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000717 RID: 1815
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000718 RID: 1816
		private global::Telerik.WinControls.UI.RadCheckBox radPause;
	}
}

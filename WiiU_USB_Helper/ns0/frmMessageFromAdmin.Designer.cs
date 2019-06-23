namespace ns0
{
	// Token: 0x020001A2 RID: 418
	public partial class frmMessageFromAdmin : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x00018391 File Offset: 0x00016591
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00045CA8 File Offset: 0x00043EA8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmMessageFromAdmin));
			this.feedbackLabel = new global::Telerik.WinControls.UI.RadLabel();
			this.radLabel2 = new global::Telerik.WinControls.UI.RadLabel();
			this.feedbackPictureBox = new global::System.Windows.Forms.PictureBox();
			this.closeButton = new global::Telerik.WinControls.UI.RadButton();
			this.txtMessage = new global::Telerik.WinControls.UI.RadTextBox();
			this.remarksLabel = new global::Telerik.WinControls.UI.RadLabel();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackLabel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackPictureBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.closeButton).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtMessage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.remarksLabel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.feedbackLabel.Location = new global::System.Drawing.Point(100, 59);
			this.feedbackLabel.Name = "feedbackLabel";
			this.feedbackLabel.ShowItemToolTips = false;
			this.feedbackLabel.Size = new global::System.Drawing.Size(254, 18);
			this.feedbackLabel.TabIndex = 20;
			this.feedbackLabel.Text = "You have received a message from the developer.";
			this.radLabel2.Font = new global::System.Drawing.Font("Segoe UI", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radLabel2.Location = new global::System.Drawing.Point(100, 12);
			this.radLabel2.Name = "radLabel2";
			this.radLabel2.Size = new global::System.Drawing.Size(264, 41);
			this.radLabel2.TabIndex = 29;
			this.radLabel2.Text = "Important message";
			this.feedbackPictureBox.Image = global::ns0.Class121.logo;
			this.feedbackPictureBox.Location = new global::System.Drawing.Point(6, 12);
			this.feedbackPictureBox.Name = "feedbackPictureBox";
			this.feedbackPictureBox.Size = new global::System.Drawing.Size(88, 78);
			this.feedbackPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.feedbackPictureBox.TabIndex = 21;
			this.feedbackPictureBox.TabStop = false;
			this.closeButton.Enabled = false;
			this.closeButton.Location = new global::System.Drawing.Point(390, 250);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new global::System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 27;
			this.closeButton.Text = "&Close";
			this.closeButton.Click += new global::System.EventHandler(this.closeButton_Click);
			this.txtMessage.AutoSize = false;
			this.txtMessage.Location = new global::System.Drawing.Point(3, 96);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ReadOnly = true;
			this.txtMessage.Size = new global::System.Drawing.Size(468, 148);
			this.txtMessage.TabIndex = 25;
			this.remarksLabel.Location = new global::System.Drawing.Point(3, 215);
			this.remarksLabel.Name = "remarksLabel";
			this.remarksLabel.Size = new global::System.Drawing.Size(51, 18);
			this.remarksLabel.TabIndex = 23;
			this.remarksLabel.Text = "Remarks:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(477, 276);
			base.Controls.Add(this.feedbackLabel);
			base.Controls.Add(this.radLabel2);
			base.Controls.Add(this.feedbackPictureBox);
			base.Controls.Add(this.closeButton);
			base.Controls.Add(this.txtMessage);
			base.Controls.Add(this.remarksLabel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmMessageFromAdmin";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Important message";
			base.Load += new global::System.EventHandler(this.frmMessageFromAdmin_Load);
			((global::System.ComponentModel.ISupportInitialize)this.feedbackLabel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.radLabel2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackPictureBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.closeButton).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtMessage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.remarksLabel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000709 RID: 1801
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400070A RID: 1802
		private global::Telerik.WinControls.UI.RadLabel feedbackLabel;

		// Token: 0x0400070B RID: 1803
		private global::Telerik.WinControls.UI.RadLabel radLabel2;

		// Token: 0x0400070C RID: 1804
		private global::System.Windows.Forms.PictureBox feedbackPictureBox;

		// Token: 0x0400070D RID: 1805
		private global::Telerik.WinControls.UI.RadButton closeButton;

		// Token: 0x0400070E RID: 1806
		private global::Telerik.WinControls.UI.RadTextBox txtMessage;

		// Token: 0x0400070F RID: 1807
		private global::Telerik.WinControls.UI.RadLabel remarksLabel;
	}
}

namespace ns0
{
	// Token: 0x0200018A RID: 394
	internal partial class frmFeedback : global::Telerik.WinControls.UI.RadForm
	{
		// Token: 0x06000B3B RID: 2875 RVA: 0x00017E6A File Offset: 0x0001606A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000414C8 File Offset: 0x0003F6C8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmFeedback));
			this.suggestionTypeGroupBox = new global::Telerik.WinControls.UI.RadGroupBox();
			this.featureRequestRadioButton = new global::Telerik.WinControls.UI.RadRadioButton();
			this.commentRadioButton = new global::Telerik.WinControls.UI.RadRadioButton();
			this.suggestionRadioButton = new global::Telerik.WinControls.UI.RadRadioButton();
			this.feedbackLabel = new global::Telerik.WinControls.UI.RadLabel();
			this.feedbackPictureBox = new global::System.Windows.Forms.PictureBox();
			this.emailLabel = new global::Telerik.WinControls.UI.RadLabel();
			this.remarksLabel = new global::Telerik.WinControls.UI.RadLabel();
			this.txtEmail = new global::Telerik.WinControls.UI.RadTextBox();
			this.txtRemarks = new global::Telerik.WinControls.UI.RadTextBox();
			this.sendButton = new global::Telerik.WinControls.UI.RadButton();
			this.closeButton = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.suggestionTypeGroupBox).BeginInit();
			this.suggestionTypeGroupBox.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.featureRequestRadioButton).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.commentRadioButton).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.suggestionRadioButton).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackLabel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackPictureBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.emailLabel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.remarksLabel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtEmail).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtRemarks).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.sendButton).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.closeButton).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.suggestionTypeGroupBox.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
			this.suggestionTypeGroupBox.Controls.Add(this.featureRequestRadioButton);
			this.suggestionTypeGroupBox.Controls.Add(this.commentRadioButton);
			this.suggestionTypeGroupBox.Controls.Add(this.suggestionRadioButton);
			this.suggestionTypeGroupBox.HeaderText = "Suggestion Type:";
			this.suggestionTypeGroupBox.Location = new global::System.Drawing.Point(12, 87);
			this.suggestionTypeGroupBox.Name = "suggestionTypeGroupBox";
			this.suggestionTypeGroupBox.Size = new global::System.Drawing.Size(464, 42);
			this.suggestionTypeGroupBox.TabIndex = 0;
			this.suggestionTypeGroupBox.TabStop = false;
			this.suggestionTypeGroupBox.Text = "Suggestion Type:";
			this.featureRequestRadioButton.Location = new global::System.Drawing.Point(262, 17);
			this.featureRequestRadioButton.Name = "featureRequestRadioButton";
			this.featureRequestRadioButton.Size = new global::System.Drawing.Size(101, 18);
			this.featureRequestRadioButton.TabIndex = 3;
			this.featureRequestRadioButton.TabStop = false;
			this.featureRequestRadioButton.Text = "Feature Request";
			this.featureRequestRadioButton.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.featureRequestRadioButton_ToggleStateChanged);
			this.commentRadioButton.Location = new global::System.Drawing.Point(186, 17);
			this.commentRadioButton.Name = "commentRadioButton";
			this.commentRadioButton.Size = new global::System.Drawing.Size(70, 18);
			this.commentRadioButton.TabIndex = 2;
			this.commentRadioButton.TabStop = false;
			this.commentRadioButton.Text = "Comment";
			this.commentRadioButton.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.commentRadioButton_ToggleStateChanged);
			this.suggestionRadioButton.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.suggestionRadioButton.Location = new global::System.Drawing.Point(102, 17);
			this.suggestionRadioButton.Name = "suggestionRadioButton";
			this.suggestionRadioButton.Size = new global::System.Drawing.Size(76, 18);
			this.suggestionRadioButton.TabIndex = 0;
			this.suggestionRadioButton.Text = "Suggestion";
			this.suggestionRadioButton.ToggleState = global::Telerik.WinControls.Enumerations.ToggleState.On;
			this.suggestionRadioButton.ToggleStateChanged += new global::Telerik.WinControls.UI.StateChangedEventHandler(this.suggestionRadioButton_ToggleStateChanged);
			this.feedbackLabel.Location = new global::System.Drawing.Point(112, 12);
			this.feedbackLabel.Name = "feedbackLabel";
			this.feedbackLabel.ShowItemToolTips = false;
			this.feedbackLabel.Size = new global::System.Drawing.Size(364, 47);
			this.feedbackLabel.TabIndex = 1;
			this.feedbackLabel.Text = "Please fill in the form below to submit your feedback.\r\nSelecting the proper feedback type will help us better understand your\r\nopinion.";
			this.feedbackPictureBox.Image = global::ns0.Class121.logo;
			this.feedbackPictureBox.Location = new global::System.Drawing.Point(16, 3);
			this.feedbackPictureBox.Name = "feedbackPictureBox";
			this.feedbackPictureBox.Size = new global::System.Drawing.Size(88, 78);
			this.feedbackPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.feedbackPictureBox.TabIndex = 2;
			this.feedbackPictureBox.TabStop = false;
			this.emailLabel.Location = new global::System.Drawing.Point(12, 145);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new global::System.Drawing.Size(136, 18);
			this.emailLabel.TabIndex = 3;
			this.emailLabel.Text = "E-mail Address (Optional):";
			this.remarksLabel.Location = new global::System.Drawing.Point(12, 169);
			this.remarksLabel.Name = "remarksLabel";
			this.remarksLabel.Size = new global::System.Drawing.Size(51, 18);
			this.remarksLabel.TabIndex = 4;
			this.remarksLabel.Text = "Remarks:";
			this.txtEmail.Location = new global::System.Drawing.Point(154, 143);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new global::System.Drawing.Size(322, 20);
			this.txtEmail.TabIndex = 5;
			this.txtRemarks.AutoSize = false;
			this.txtRemarks.Location = new global::System.Drawing.Point(12, 193);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new global::System.Drawing.Size(468, 120);
			this.txtRemarks.TabIndex = 6;
			this.sendButton.Location = new global::System.Drawing.Point(405, 319);
			this.sendButton.Name = "sendButton";
			this.sendButton.Size = new global::System.Drawing.Size(75, 23);
			this.sendButton.TabIndex = 7;
			this.sendButton.Text = "    &Send";
			this.sendButton.Click += new global::System.EventHandler(this.sendButton_Click);
			this.closeButton.Location = new global::System.Drawing.Point(319, 319);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new global::System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 8;
			this.closeButton.Text = "&Close";
			this.closeButton.Click += new global::System.EventHandler(this.closeButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(481, 346);
			base.Controls.Add(this.feedbackPictureBox);
			base.Controls.Add(this.closeButton);
			base.Controls.Add(this.sendButton);
			base.Controls.Add(this.txtRemarks);
			base.Controls.Add(this.txtEmail);
			base.Controls.Add(this.remarksLabel);
			base.Controls.Add(this.emailLabel);
			base.Controls.Add(this.feedbackLabel);
			base.Controls.Add(this.suggestionTypeGroupBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmFeedback";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Feedback";
			base.Load += new global::System.EventHandler(this.frmFeedback_Load);
			((global::System.ComponentModel.ISupportInitialize)this.suggestionTypeGroupBox).EndInit();
			this.suggestionTypeGroupBox.ResumeLayout(false);
			this.suggestionTypeGroupBox.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.featureRequestRadioButton).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.commentRadioButton).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.suggestionRadioButton).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackLabel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.feedbackPictureBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.emailLabel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.remarksLabel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtEmail).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtRemarks).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.sendButton).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.closeButton).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400068F RID: 1679
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000690 RID: 1680
		private global::Telerik.WinControls.UI.RadGroupBox suggestionTypeGroupBox;

		// Token: 0x04000691 RID: 1681
		private global::Telerik.WinControls.UI.RadRadioButton featureRequestRadioButton;

		// Token: 0x04000692 RID: 1682
		private global::Telerik.WinControls.UI.RadRadioButton commentRadioButton;

		// Token: 0x04000693 RID: 1683
		private global::Telerik.WinControls.UI.RadRadioButton suggestionRadioButton;

		// Token: 0x04000694 RID: 1684
		private global::Telerik.WinControls.UI.RadLabel feedbackLabel;

		// Token: 0x04000695 RID: 1685
		private global::System.Windows.Forms.PictureBox feedbackPictureBox;

		// Token: 0x04000696 RID: 1686
		private global::Telerik.WinControls.UI.RadLabel emailLabel;

		// Token: 0x04000697 RID: 1687
		private global::Telerik.WinControls.UI.RadLabel remarksLabel;

		// Token: 0x04000698 RID: 1688
		private global::Telerik.WinControls.UI.RadTextBox txtEmail;

		// Token: 0x04000699 RID: 1689
		private global::Telerik.WinControls.UI.RadTextBox txtRemarks;

		// Token: 0x0400069A RID: 1690
		private global::Telerik.WinControls.UI.RadButton sendButton;

		// Token: 0x0400069B RID: 1691
		private global::Telerik.WinControls.UI.RadButton closeButton;
	}
}

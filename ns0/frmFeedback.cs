// Decompiled with JetBrains decompiler
// Type: ns0.frmFeedback
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace ns0
{
  internal class frmFeedback : RadForm
  {
    private IContainer icontainer_0;
    private RadGroupBox suggestionTypeGroupBox;
    private RadRadioButton featureRequestRadioButton;
    private RadRadioButton commentRadioButton;
    private RadRadioButton suggestionRadioButton;
    private RadLabel feedbackLabel;
    private PictureBox feedbackPictureBox;
    private RadLabel emailLabel;
    private RadLabel remarksLabel;
    private RadTextBox txtEmail;
    private RadTextBox txtRemarks;
    private RadButton sendButton;
    private RadButton closeButton;

    public frmFeedback()
    {
      this.InitializeComponent();
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void commentRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      this.featureRequestRadioButton.IsChecked = false;
      this.suggestionRadioButton.IsChecked = false;
    }

    private void featureRequestRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      this.commentRadioButton.IsChecked = false;
      this.suggestionRadioButton.IsChecked = false;
    }

    private void frmFeedback_Load(object sender, EventArgs e)
    {
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      frmFeedback.Class143 class143 = new frmFeedback.Class143();
      // ISSUE: reference to a compiler-generated field
      class143.frmFeedback_0 = this;
      this.txtRemarks.Text = this.txtRemarks.Text.Trim();
      if (this.txtRemarks.Text.Length < 50)
      {
        int num1 = (int) RadMessageBox.Show("Your request must be at least 50 characters long.");
      }
      else
      {
        GClass7 gclass7 = new GClass7("feedback@wiiuusbhelper.com", !this.commentRadioButton.IsChecked ? (!this.featureRequestRadioButton.IsChecked ? "New suggestion" : "New feature request") : "New comment", this.txtRemarks.Text, this.txtEmail.Text.Trim());
        // ISSUE: reference to a compiler-generated field
        class143.frmWait_0 = new FrmWait("Please wait while your feedback is sent...", false);
        // ISSUE: reference to a compiler-generated method
        gclass7.Event_0 += new EventHandler<string>(class143.method_0);
        gclass7.method_0();
        // ISSUE: reference to a compiler-generated field
        int num2 = (int) class143.frmWait_0.ShowDialog();
      }
    }

    private void suggestionRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs e)
    {
      this.featureRequestRadioButton.IsChecked = false;
      this.commentRadioButton.IsChecked = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFeedback));
      this.suggestionTypeGroupBox = new RadGroupBox();
      this.featureRequestRadioButton = new RadRadioButton();
      this.commentRadioButton = new RadRadioButton();
      this.suggestionRadioButton = new RadRadioButton();
      this.feedbackLabel = new RadLabel();
      this.feedbackPictureBox = new PictureBox();
      this.emailLabel = new RadLabel();
      this.remarksLabel = new RadLabel();
      this.txtEmail = new RadTextBox();
      this.txtRemarks = new RadTextBox();
      this.sendButton = new RadButton();
      this.closeButton = new RadButton();
      this.suggestionTypeGroupBox.BeginInit();
      this.suggestionTypeGroupBox.SuspendLayout();
      this.featureRequestRadioButton.BeginInit();
      this.commentRadioButton.BeginInit();
      this.suggestionRadioButton.BeginInit();
      this.feedbackLabel.BeginInit();
      ((ISupportInitialize) this.feedbackPictureBox).BeginInit();
      this.emailLabel.BeginInit();
      this.remarksLabel.BeginInit();
      this.txtEmail.BeginInit();
      this.txtRemarks.BeginInit();
      this.sendButton.BeginInit();
      this.closeButton.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.suggestionTypeGroupBox.AccessibleRole = AccessibleRole.Grouping;
      this.suggestionTypeGroupBox.Controls.Add((Control) this.featureRequestRadioButton);
      this.suggestionTypeGroupBox.Controls.Add((Control) this.commentRadioButton);
      this.suggestionTypeGroupBox.Controls.Add((Control) this.suggestionRadioButton);
      this.suggestionTypeGroupBox.HeaderText = "Suggestion Type:";
      this.suggestionTypeGroupBox.Location = new Point(12, 87);
      this.suggestionTypeGroupBox.Name = "suggestionTypeGroupBox";
      this.suggestionTypeGroupBox.Size = new Size(464, 42);
      this.suggestionTypeGroupBox.TabIndex = 0;
      this.suggestionTypeGroupBox.TabStop = false;
      this.suggestionTypeGroupBox.Text = "Suggestion Type:";
      this.featureRequestRadioButton.Location = new Point(262, 17);
      this.featureRequestRadioButton.Name = "featureRequestRadioButton";
      this.featureRequestRadioButton.Size = new Size(101, 18);
      this.featureRequestRadioButton.TabIndex = 3;
      this.featureRequestRadioButton.TabStop = false;
      this.featureRequestRadioButton.Text = "Feature Request";
      this.featureRequestRadioButton.ToggleStateChanged += new StateChangedEventHandler(this.featureRequestRadioButton_ToggleStateChanged);
      this.commentRadioButton.Location = new Point(186, 17);
      this.commentRadioButton.Name = "commentRadioButton";
      this.commentRadioButton.Size = new Size(70, 18);
      this.commentRadioButton.TabIndex = 2;
      this.commentRadioButton.TabStop = false;
      this.commentRadioButton.Text = "Comment";
      this.commentRadioButton.ToggleStateChanged += new StateChangedEventHandler(this.commentRadioButton_ToggleStateChanged);
      this.suggestionRadioButton.CheckState = CheckState.Checked;
      this.suggestionRadioButton.Location = new Point(102, 17);
      this.suggestionRadioButton.Name = "suggestionRadioButton";
      this.suggestionRadioButton.Size = new Size(76, 18);
      this.suggestionRadioButton.TabIndex = 0;
      this.suggestionRadioButton.Text = "Suggestion";
      this.suggestionRadioButton.ToggleState = ToggleState.On;
      this.suggestionRadioButton.ToggleStateChanged += new StateChangedEventHandler(this.suggestionRadioButton_ToggleStateChanged);
      this.feedbackLabel.Location = new Point(112, 12);
      this.feedbackLabel.Name = "feedbackLabel";
      this.feedbackLabel.ShowItemToolTips = false;
      this.feedbackLabel.Size = new Size(364, 47);
      this.feedbackLabel.TabIndex = 1;
      this.feedbackLabel.Text = "Please fill in the form below to submit your feedback.\r\nSelecting the proper feedback type will help us better understand your\r\nopinion.";
      this.feedbackPictureBox.Image = (Image) Class123.logo;
      this.feedbackPictureBox.Location = new Point(16, 3);
      this.feedbackPictureBox.Name = "feedbackPictureBox";
      this.feedbackPictureBox.Size = new Size(88, 78);
      this.feedbackPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
      this.feedbackPictureBox.TabIndex = 2;
      this.feedbackPictureBox.TabStop = false;
      this.emailLabel.Location = new Point(12, 145);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new Size(136, 18);
      this.emailLabel.TabIndex = 3;
      this.emailLabel.Text = "E-mail Address (Optional):";
      this.remarksLabel.Location = new Point(12, 169);
      this.remarksLabel.Name = "remarksLabel";
      this.remarksLabel.Size = new Size(51, 18);
      this.remarksLabel.TabIndex = 4;
      this.remarksLabel.Text = "Remarks:";
      this.txtEmail.Location = new Point(154, 143);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new Size(322, 20);
      this.txtEmail.TabIndex = 5;
      this.txtRemarks.AutoSize = false;
      this.txtRemarks.Location = new Point(12, 193);
      this.txtRemarks.Multiline = true;
      this.txtRemarks.Name = "txtRemarks";
      this.txtRemarks.Size = new Size(468, 120);
      this.txtRemarks.TabIndex = 6;
      this.sendButton.Location = new Point(405, 319);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new Size(75, 23);
      this.sendButton.TabIndex = 7;
      this.sendButton.Text = "    &Send";
      this.sendButton.Click += new EventHandler(this.sendButton_Click);
      this.closeButton.Location = new Point(319, 319);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new Size(75, 23);
      this.closeButton.TabIndex = 8;
      this.closeButton.Text = "&Close";
      this.closeButton.Click += new EventHandler(this.closeButton_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(481, 346);
      this.Controls.Add((Control) this.feedbackPictureBox);
      this.Controls.Add((Control) this.closeButton);
      this.Controls.Add((Control) this.sendButton);
      this.Controls.Add((Control) this.txtRemarks);
      this.Controls.Add((Control) this.txtEmail);
      this.Controls.Add((Control) this.remarksLabel);
      this.Controls.Add((Control) this.emailLabel);
      this.Controls.Add((Control) this.feedbackLabel);
      this.Controls.Add((Control) this.suggestionTypeGroupBox);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (frmFeedback);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Feedback";
      this.Load += new EventHandler(this.frmFeedback_Load);
      this.suggestionTypeGroupBox.EndInit();
      this.suggestionTypeGroupBox.ResumeLayout(false);
      this.suggestionTypeGroupBox.PerformLayout();
      this.featureRequestRadioButton.EndInit();
      this.commentRadioButton.EndInit();
      this.suggestionRadioButton.EndInit();
      this.feedbackLabel.EndInit();
      ((ISupportInitialize) this.feedbackPictureBox).EndInit();
      this.emailLabel.EndInit();
      this.remarksLabel.EndInit();
      this.txtEmail.EndInit();
      this.txtRemarks.EndInit();
      this.sendButton.EndInit();
      this.closeButton.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

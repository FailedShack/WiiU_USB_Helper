// Decompiled with JetBrains decompiler
// Type: ns0.frmMessageFromAdmin
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmMessageFromAdmin : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel feedbackLabel;
    private RadLabel radLabel2;
    private PictureBox feedbackPictureBox;
    private RadButton closeButton;
    private RadTextBox txtMessage;
    private RadLabel remarksLabel;

    public frmMessageFromAdmin(string string_0)
    {
      this.InitializeComponent();
      this.txtMessage.Text = string_0;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmMessageFromAdmin_Load(object sender1, EventArgs e1)
    {
      Timer timer = new Timer();
      timer.Interval = 5000;
      timer.Tick += (EventHandler) ((sender2, e2) => this.closeButton.Enabled = true);
      timer.Start();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMessageFromAdmin));
      this.feedbackLabel = new RadLabel();
      this.radLabel2 = new RadLabel();
      this.feedbackPictureBox = new PictureBox();
      this.closeButton = new RadButton();
      this.txtMessage = new RadTextBox();
      this.remarksLabel = new RadLabel();
      this.feedbackLabel.BeginInit();
      this.radLabel2.BeginInit();
      ((ISupportInitialize) this.feedbackPictureBox).BeginInit();
      this.closeButton.BeginInit();
      this.txtMessage.BeginInit();
      this.remarksLabel.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.feedbackLabel.Location = new Point(100, 59);
      this.feedbackLabel.Name = "feedbackLabel";
      this.feedbackLabel.ShowItemToolTips = false;
      this.feedbackLabel.Size = new Size(254, 18);
      this.feedbackLabel.TabIndex = 20;
      this.feedbackLabel.Text = "You have received a message from the developer.";
      this.radLabel2.Font = new Font("Segoe UI", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.radLabel2.Location = new Point(100, 12);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(264, 41);
      this.radLabel2.TabIndex = 29;
      this.radLabel2.Text = "Important message";
      this.feedbackPictureBox.Image = (Image) Class123.logo;
      this.feedbackPictureBox.Location = new Point(6, 12);
      this.feedbackPictureBox.Name = "feedbackPictureBox";
      this.feedbackPictureBox.Size = new Size(88, 78);
      this.feedbackPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
      this.feedbackPictureBox.TabIndex = 21;
      this.feedbackPictureBox.TabStop = false;
      this.closeButton.Enabled = false;
      this.closeButton.Location = new Point(390, 250);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new Size(75, 23);
      this.closeButton.TabIndex = 27;
      this.closeButton.Text = "&Close";
      this.closeButton.Click += new EventHandler(this.closeButton_Click);
      this.txtMessage.AutoSize = false;
      this.txtMessage.Location = new Point(3, 96);
      this.txtMessage.Multiline = true;
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.ReadOnly = true;
      this.txtMessage.Size = new Size(468, 148);
      this.txtMessage.TabIndex = 25;
      this.remarksLabel.Location = new Point(3, 215);
      this.remarksLabel.Name = "remarksLabel";
      this.remarksLabel.Size = new Size(51, 18);
      this.remarksLabel.TabIndex = 23;
      this.remarksLabel.Text = "Remarks:";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(477, 276);
      this.Controls.Add((Control) this.feedbackLabel);
      this.Controls.Add((Control) this.radLabel2);
      this.Controls.Add((Control) this.feedbackPictureBox);
      this.Controls.Add((Control) this.closeButton);
      this.Controls.Add((Control) this.txtMessage);
      this.Controls.Add((Control) this.remarksLabel);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmMessageFromAdmin);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Important message";
      this.Load += new EventHandler(this.frmMessageFromAdmin_Load);
      this.feedbackLabel.EndInit();
      this.radLabel2.EndInit();
      ((ISupportInitialize) this.feedbackPictureBox).EndInit();
      this.closeButton.EndInit();
      this.txtMessage.EndInit();
      this.remarksLabel.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

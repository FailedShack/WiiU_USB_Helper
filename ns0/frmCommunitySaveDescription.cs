// Decompiled with JetBrains decompiler
// Type: ns0.frmCommunitySaveDescription
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
  public class frmCommunitySaveDescription : RadForm
  {
    private const int int_0 = 125;
    private const int int_1 = 40;
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadTextBoxControl txtDescription;
    private RadLabel lblLength;
    private RadButton cmdSubmit;

    public frmCommunitySaveDescription()
    {
      this.InitializeComponent();
      this.txtDescription.MaxLength = 125;
      this.method_0();
    }

    public string Description { get; set; }

    private void cmdSubmit_Click(object sender, EventArgs e)
    {
      this.Description = this.txtDescription.Text;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void txtDescription_TextChanged(object sender, EventArgs e)
    {
      this.method_0();
    }

    private void method_0()
    {
      this.lblLength.Text = string.Format("{0} character(s) ({1} minimum, {2} maximum)", (object) this.txtDescription.Text.Length, (object) 40, (object) 125);
      this.cmdSubmit.Enabled = this.txtDescription.Text.Length >= 40 && this.txtDescription.Text.Length <= 125;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCommunitySaveDescription));
      this.radLabel1 = new RadLabel();
      this.txtDescription = new RadTextBoxControl();
      this.lblLength = new RadLabel();
      this.cmdSubmit = new RadButton();
      this.radLabel1.BeginInit();
      this.txtDescription.BeginInit();
      this.lblLength.BeginInit();
      this.lblLength.SuspendLayout();
      this.cmdSubmit.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Top;
      this.radLabel1.Location = new Point(0, 0);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Padding = new Padding(10);
      this.radLabel1.Size = new Size(672, 85);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radLabel1.TextAlignment = ContentAlignment.MiddleLeft;
      this.txtDescription.Dock = DockStyle.Fill;
      this.txtDescription.Location = new Point(0, 85);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new Size(672, 251);
      this.txtDescription.TabIndex = 1;
      this.txtDescription.TextChanged += new EventHandler(this.txtDescription_TextChanged);
      this.lblLength.AutoSize = false;
      this.lblLength.Controls.Add((Control) this.cmdSubmit);
      this.lblLength.Dock = DockStyle.Bottom;
      this.lblLength.Location = new Point(0, 336);
      this.lblLength.Name = "lblLength";
      this.lblLength.Size = new Size(672, 39);
      this.lblLength.TabIndex = 0;
      this.cmdSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.cmdSubmit.Enabled = false;
      this.cmdSubmit.Image = (Image) Class123.icnArrow;
      this.cmdSubmit.Location = new Point(543, 6);
      this.cmdSubmit.Name = "cmdSubmit";
      this.cmdSubmit.Size = new Size(126, 30);
      this.cmdSubmit.TabIndex = 0;
      this.cmdSubmit.Text = "Submit";
      this.cmdSubmit.Click += new EventHandler(this.cmdSubmit_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(672, 375);
      this.Controls.Add((Control) this.txtDescription);
      this.Controls.Add((Control) this.lblLength);
      this.Controls.Add((Control) this.radLabel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmCommunitySaveDescription);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Description";
      this.radLabel1.EndInit();
      this.txtDescription.EndInit();
      this.lblLength.EndInit();
      this.lblLength.ResumeLayout(false);
      this.cmdSubmit.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

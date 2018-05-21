// Decompiled with JetBrains decompiler
// Type: ns0.frmCreateSave
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
  public class frmCreateSave : RadForm
  {
    public string string_0;
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadTextBox txtDescription;
    private RadButton cmdbackup;
    private RadButton radButton1;

    public frmCreateSave()
    {
      this.InitializeComponent();
    }

    private void frmCreateSave_Load(object sender, EventArgs e)
    {
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void cmdbackup_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(this.txtDescription.Text.Trim()))
      {
        int num = (int) RadMessageBox.Show("Please enter a valid description");
      }
      else
      {
        this.string_0 = this.txtDescription.Text.Trim();
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.radLabel1 = new RadLabel();
      this.txtDescription = new RadTextBox();
      this.radButton1 = new RadButton();
      this.cmdbackup = new RadButton();
      this.radLabel1.BeginInit();
      this.txtDescription.BeginInit();
      this.radButton1.BeginInit();
      this.cmdbackup.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = DockStyle.Top;
      this.radLabel1.Location = new Point(5, 5);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(337, 18);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Please enter a short description of the content of your save.";
      this.radLabel1.TextAlignment = ContentAlignment.MiddleCenter;
      this.txtDescription.AutoSize = false;
      this.txtDescription.Dock = DockStyle.Fill;
      this.txtDescription.Location = new Point(5, 23);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new Size(337, 234);
      this.txtDescription.TabIndex = 1;
      this.radButton1.Dock = DockStyle.Bottom;
      this.radButton1.Location = new Point(5, 281);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(337, 24);
      this.radButton1.TabIndex = 1;
      this.radButton1.Text = "Cancel";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.cmdbackup.Dock = DockStyle.Bottom;
      this.cmdbackup.Location = new Point(5, 257);
      this.cmdbackup.Name = "cmdbackup";
      this.cmdbackup.Size = new Size(337, 24);
      this.cmdbackup.TabIndex = 2;
      this.cmdbackup.Text = "Backup";
      this.cmdbackup.Click += new EventHandler(this.cmdbackup_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(347, 310);
      this.Controls.Add((Control) this.txtDescription);
      this.Controls.Add((Control) this.cmdbackup);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.radLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmCreateSave);
      this.Padding = new Padding(5);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Backup save";
      this.Load += new EventHandler(this.frmCreateSave_Load);
      this.radLabel1.EndInit();
      this.txtDescription.EndInit();
      this.radButton1.EndInit();
      this.cmdbackup.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

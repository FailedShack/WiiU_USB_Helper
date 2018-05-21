// Decompiled with JetBrains decompiler
// Type: ns0.frmUnhandledException
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
  public class frmUnhandledException : RadForm
  {
    private IContainer icontainer_0;
    private RadButton cmdLater;
    private RadLabel radLabel1;
    private RadLabel label1;
    private PictureBox pictureBox1;
    private RadLabel radLabel2;
    private RadGroupBox radGroupBox1;
    private RadTextBoxControl lblException;
    private RadButton radButton1;

    public frmUnhandledException(Exception exception_0)
    {
      this.InitializeComponent();
      this.lblException.Text = exception_0.ToString();
    }

    private void cmdLater_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      int num = (int) new frmSupport(this.lblException.Text).ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmUnhandledException));
      this.cmdLater = new RadButton();
      this.radLabel1 = new RadLabel();
      this.label1 = new RadLabel();
      this.pictureBox1 = new PictureBox();
      this.radLabel2 = new RadLabel();
      this.radGroupBox1 = new RadGroupBox();
      this.lblException = new RadTextBoxControl();
      this.radButton1 = new RadButton();
      this.cmdLater.BeginInit();
      this.radLabel1.BeginInit();
      this.label1.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.radLabel2.BeginInit();
      this.radGroupBox1.BeginInit();
      this.radGroupBox1.SuspendLayout();
      this.lblException.BeginInit();
      this.radButton1.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.cmdLater.Location = new Point(205, 550);
      this.cmdLater.Name = "cmdLater";
      this.cmdLater.Size = new Size(163, 29);
      this.cmdLater.TabIndex = 35;
      this.cmdLater.Text = "Close the app";
      this.cmdLater.ThemeName = "VisualStudio2012Dark";
      this.cmdLater.Click += new EventHandler(this.cmdLater_Click);
      this.radLabel1.AutoSize = false;
      this.radLabel1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.radLabel1.Location = new Point(118, 42);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new Size(454, 185);
      this.radLabel1.TabIndex = 32;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radLabel1.TextAlignment = ContentAlignment.MiddleLeft;
      this.radLabel1.ThemeName = "VisualStudio2012Dark";
      this.label1.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(118, 12);
      this.label1.Name = "label1";
      this.label1.Size = new Size(325, 24);
      this.label1.TabIndex = 31;
      this.label1.Text = "Wii U USB Helper has encountered an issue.";
      this.label1.ThemeName = "VisualStudio2012Dark";
      this.pictureBox1.Image = (Image) Class123.logo;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(94, 91);
      this.pictureBox1.TabIndex = 30;
      this.pictureBox1.TabStop = false;
      this.radLabel2.Location = new Point(5, 21);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new Size(60, 18);
      this.radLabel2.TabIndex = 36;
      this.radLabel2.Text = "Exception :";
      this.radGroupBox1.AccessibleRole = AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add((Control) this.lblException);
      this.radGroupBox1.Controls.Add((Control) this.radLabel2);
      this.radGroupBox1.HeaderText = "Info";
      this.radGroupBox1.Location = new Point(12, 279);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new Size(560, 265);
      this.radGroupBox1.TabIndex = 37;
      this.radGroupBox1.Text = "Info";
      this.lblException.BackColor = Color.FromArgb(64, 64, 64);
      this.lblException.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblException.ForeColor = Color.Lime;
      this.lblException.IsReadOnly = true;
      this.lblException.Location = new Point(6, 46);
      this.lblException.Multiline = true;
      this.lblException.Name = "lblException";
      this.lblException.Size = new Size(549, 214);
      this.lblException.TabIndex = 37;
      this.lblException.TabStop = false;
      this.radButton1.Location = new Point(208, 244);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(163, 29);
      this.radButton1.TabIndex = 36;
      this.radButton1.Text = "Go the Help Center";
      this.radButton1.ThemeName = "VisualStudio2012Dark";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(579, 583);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.radGroupBox1);
      this.Controls.Add((Control) this.cmdLater);
      this.Controls.Add((Control) this.radLabel1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.pictureBox1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = nameof (frmUnhandledException);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "An error has occured";
      this.cmdLater.EndInit();
      this.radLabel1.EndInit();
      this.label1.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.radLabel2.EndInit();
      this.radGroupBox1.EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      this.lblException.EndInit();
      this.radButton1.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

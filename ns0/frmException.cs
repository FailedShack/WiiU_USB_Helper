// Decompiled with JetBrains decompiler
// Type: ns0.frmException
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
  public class frmException : RadForm
  {
    private IContainer icontainer_0;
    private RadLabel radLabel1;
    private RadButton radButton1;

    public frmException()
    {
      this.InitializeComponent();
    }

    private void frmException_Load(object sender, EventArgs e)
    {
    }

    private void radButton1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmException));
      this.radLabel1 = new RadLabel();
      this.radButton1 = new RadButton();
      this.radLabel1.BeginInit();
      this.radButton1.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.radLabel1.Dock = DockStyle.Fill;
      this.radLabel1.Location = new Point(0, 0);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Padding = new Padding(20);
      this.radLabel1.Size = new Size(1143, 167);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = componentResourceManager.GetString("radLabel1.Text");
      this.radButton1.Location = new Point(502, 173);
      this.radButton1.Name = "radButton1";
      this.radButton1.Size = new Size(110, 24);
      this.radButton1.TabIndex = 0;
      this.radButton1.Text = "Ok";
      this.radButton1.Click += new EventHandler(this.radButton1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1130, 203);
      this.Controls.Add((Control) this.radButton1);
      this.Controls.Add((Control) this.radLabel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmException);
      this.RootElement.ApplyShapeToControl = true;
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Error";
      this.TopMost = true;
      this.Load += new EventHandler(this.frmException_Load);
      this.radLabel1.EndInit();
      this.radButton1.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

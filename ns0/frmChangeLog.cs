// Decompiled with JetBrains decompiler
// Type: ns0.frmChangeLog
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
  public class frmChangeLog : RadForm
  {
    private IContainer icontainer_0;
    private RadTextBox txtLog;

    public frmChangeLog()
    {
      this.InitializeComponent();
    }

    private void frmChangeLog_Load(object sender, EventArgs e)
    {
      try
      {
        this.txtLog.Text = new GClass78().method_6(string.Format("{0}/res/txt/changelog.txt", (object) Class67.String_2)).Replace("\n", "\r\n");
      }
      catch
      {
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmChangeLog));
      this.txtLog = new RadTextBox();
      this.txtLog.BeginInit();
      this.BeginInit();
      this.SuspendLayout();
      this.txtLog.AutoSize = false;
      this.txtLog.Dock = DockStyle.Fill;
      this.txtLog.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtLog.Location = new Point(0, 0);
      this.txtLog.Multiline = true;
      this.txtLog.Name = "txtLog";
      this.txtLog.ReadOnly = true;
      this.txtLog.ScrollBars = ScrollBars.Vertical;
      this.txtLog.Size = new Size(736, 504);
      this.txtLog.TabIndex = 0;
      this.txtLog.TabStop = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(736, 504);
      this.Controls.Add((Control) this.txtLog);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmChangeLog);
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "Changelog";
      this.ThemeName = "VisualStudio2012Dark";
      this.Load += new EventHandler(this.frmChangeLog_Load);
      this.txtLog.EndInit();
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

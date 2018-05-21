// Decompiled with JetBrains decompiler
// Type: ns0.frmBug
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
  public class frmBug : RadForm
  {
    private IContainer icontainer_0;
    private WebBrowser webBrowser1;

    public frmBug()
    {
      this.InitializeComponent();
    }

    private void frmBug_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBug));
      this.webBrowser1 = new WebBrowser();
      this.BeginInit();
      this.SuspendLayout();
      this.webBrowser1.Dock = DockStyle.Fill;
      this.webBrowser1.Location = new Point(0, 0);
      this.webBrowser1.MinimumSize = new Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new Size(1081, 650);
      this.webBrowser1.TabIndex = 0;
      this.webBrowser1.Url = new Uri("http://bug.wiiuusbhelper.com", UriKind.Absolute);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1081, 650);
      this.Controls.Add((Control) this.webBrowser1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (frmBug);
      this.RootElement.ApplyShapeToControl = true;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Bug Tracker";
      this.Load += new EventHandler(this.frmBug_Load);
      this.EndInit();
      this.ResumeLayout(false);
    }
  }
}

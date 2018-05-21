// Decompiled with JetBrains decompiler
// Type: ns0.GForm0
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.ComponentModel;
using System.Windows.Forms;

namespace ns0
{
  public class GForm0 : Form
  {
    private IContainer icontainer_0;

    public GForm0()
    {
      this.method_0();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.icontainer_0 != null)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void method_0()
    {
      this.icontainer_0 = (IContainer) new Container();
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Text = "frmSaveConflict";
    }
  }
}

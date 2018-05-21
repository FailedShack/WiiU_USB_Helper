// Decompiled with JetBrains decompiler
// Type: ns0.GControl1
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ns0
{
  [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
  public class GControl1 : ToolStripControlHost
  {
    public GControl1()
      : base((Control) new GControl0())
    {
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [RefreshProperties(RefreshProperties.All)]
    public GControl0 GControl0_0
    {
      get
      {
        return this.Control as GControl0;
      }
    }

    public override Size GetPreferredSize(Size constrainingSize)
    {
      return this.GControl0_0.GetPreferredSize(constrainingSize);
    }

    protected override void OnSubscribeControlEvents(Control control)
    {
      base.OnSubscribeControlEvents(control);
    }

    protected override void OnUnsubscribeControlEvents(Control control)
    {
      base.OnUnsubscribeControlEvents(control);
    }
  }
}

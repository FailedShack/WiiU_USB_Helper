// Decompiled with JetBrains decompiler
// Type: ns0.GClass135
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using System;

namespace ns0
{
  public abstract class GClass135
  {
    public event EventHandler Event_0;

    public abstract Matrix vmethod_0();

    protected void method_0()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }
  }
}

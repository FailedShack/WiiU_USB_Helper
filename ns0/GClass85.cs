// Decompiled with JetBrains decompiler
// Type: ns0.GClass85
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;

namespace ns0
{
  public abstract class GClass85
  {
    public event EventHandler Event_0;

    public static byte[] smethod_0(string string_0, TimeSpan timeSpan_0)
    {
      if (Uri.IsWellFormedUriString(string_0, UriKind.Absolute))
        return GClass88.smethod_2(new Uri(string_0), timeSpan_0);
      return (byte[]) null;
    }

    public virtual void vmethod_0(string string_0, TimeSpan timeSpan_0)
    {
      if (!Uri.IsWellFormedUriString(string_0, UriKind.Absolute))
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler eventHandler0 = this.eventHandler_0;
        if (eventHandler0 == null)
          return;
        eventHandler0((object) this, (EventArgs) null);
      }
      else
        GClass88.smethod_3(new Uri(string_0), timeSpan_0, (Action<GClass87>) (gclass87_0 =>
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler<GClass87> eventHandler1 = this.eventHandler_1;
          if (eventHandler1 == null)
            return;
          eventHandler1((object) this, gclass87_0);
        }), (Action) (() =>
        {
          // ISSUE: reference to a compiler-generated field
          EventHandler eventHandler0 = this.eventHandler_0;
          if (eventHandler0 == null)
            return;
          eventHandler0((object) this, (EventArgs) null);
        }));
    }

    protected event EventHandler<GClass87> Event_1;
  }
}

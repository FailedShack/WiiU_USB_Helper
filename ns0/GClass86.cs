// Decompiled with JetBrains decompiler
// Type: ns0.GClass86
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ns0
{
  public sealed class GClass86 : GClass85
  {
    public Image Image { get; set; }

    public event EventHandler<GClass84> Event_2;

    public void method_2(string string_0, TimeSpan timeSpan_0)
    {
      this.Event_1 += new EventHandler<GClass87>(this.method_4);
      base.vmethod_0(string_0, timeSpan_0);
    }

    public override void vmethod_0(string string_0, TimeSpan timeSpan_0)
    {
      this.Event_1 += new EventHandler<GClass87>(this.method_3);
      base.vmethod_0(string_0, timeSpan_0);
    }

    private void method_3(object object_0, GClass87 gclass87_0)
    {
      this.Event_1 -= new EventHandler<GClass87>(this.method_3);
      try
      {
        this.Image = Image.FromStream((Stream) new MemoryStream(gclass87_0.byte_0));
      }
      catch (Exception ex)
      {
        GClass6.smethod_6(gclass87_0.string_0);
        return;
      }
      // ISSUE: reference to a compiler-generated field
      EventHandler<GClass84> eventHandler2 = this.eventHandler_2;
      if (eventHandler2 == null)
        return;
      eventHandler2((object) this, new GClass84(this.Image));
    }

    private void method_4(object object_0, GClass87 gclass87_0)
    {
      this.Event_1 -= new EventHandler<GClass87>(this.method_4);
      if (!gclass87_0.bool_0)
      {
        using (MemoryStream memoryStream1 = new MemoryStream(gclass87_0.byte_0))
        {
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            new Bitmap(Image.FromStream((Stream) memoryStream1), new Size(48, 48)).Save((Stream) memoryStream2, ImageFormat.Png);
            File.WriteAllBytes(gclass87_0.string_0, memoryStream2.ToArray());
            this.Image = Image.FromStream((Stream) memoryStream2);
          }
          catch (Exception ex)
          {
            GClass6.smethod_6(gclass87_0.string_0);
            return;
          }
        }
      }
      else
        this.Image = Image.FromStream((Stream) new MemoryStream(gclass87_0.byte_0));
      // ISSUE: reference to a compiler-generated field
      EventHandler<GClass84> eventHandler2 = this.eventHandler_2;
      if (eventHandler2 == null)
        return;
      eventHandler2((object) this, new GClass84(this.Image));
    }
  }
}

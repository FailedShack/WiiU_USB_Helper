// Decompiled with JetBrains decompiler
// Type: ns0.GClass143
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ns0
{
  public class GClass143
  {
    private List<GClass140> list_0 = new List<GClass140>();
    private Rectangle rectangle_0;

    public GClass141 Cursor { get; set; }

    public void method_0(GClass140 gclass140_0)
    {
      this.list_0.Add(gclass140_0);
    }

    public void method_1()
    {
      foreach (GClass140 gclass140 in this.list_0.ToArray())
      {
        if (this.rectangle_0.Intersects(gclass140.Rectangle))
          gclass140.method_2();
      }
    }

    public void method_2()
    {
      this.list_0.Clear();
    }

    public void method_3(GameTime gameTime_0, SpriteBatch spriteBatch_0)
    {
      foreach (GClass140 gclass140 in ((IEnumerable<GClass140>) this.list_0.ToArray()).Where<GClass140>((Func<GClass140, bool>) (gclass140_0 => !gclass140_0.Hide)))
        gclass140.vmethod_0(gameTime_0, spriteBatch_0);
      GClass141 cursor = this.Cursor;
      if (cursor == null)
        return;
      cursor.vmethod_0(gameTime_0, spriteBatch_0);
    }

    public void method_4(GClass140 gclass140_0)
    {
      if (!this.list_0.Contains(gclass140_0))
        return;
      this.list_0.Remove(gclass140_0);
    }

    public void method_5(Rectangle rectangle_1)
    {
      this.rectangle_0 = rectangle_1;
      GClass141 cursor = this.Cursor;
      if (cursor == null)
        return;
      cursor.method_3(new Vector2((float) this.rectangle_0.X, (float) rectangle_1.Y), true, 2.5f);
    }

    public void method_6(GameTime gameTime_0)
    {
      foreach (GClass140 gclass140 in this.list_0.ToArray())
        gclass140.vmethod_1(gameTime_0);
      GClass141 cursor = this.Cursor;
      if (cursor == null)
        return;
      cursor.vmethod_1(gameTime_0);
    }
  }
}

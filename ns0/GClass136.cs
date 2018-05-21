// Decompiled with JetBrains decompiler
// Type: ns0.GClass136
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using System;

namespace ns0
{
  public class GClass136 : GClass135
  {
    private GClass134 gclass134_0;
    private Vector2 vector2_0;

    public GClass136(Vector2 vector2_1, double double_0, double double_1, double double_2)
    {
      this.gclass134_0 = new GClass134(double_0, double_1, double_2);
      this.gclass134_0.Event_0 += (EventHandler) ((sender, e) => this.method_0());
      this.vector2_0 = vector2_1;
    }

    public override Matrix vmethod_0()
    {
      return Matrix.CreateTranslation(-this.vector2_0.X, -this.vector2_0.Y, 0.0f) * Matrix.CreateScale((float) this.gclass134_0.method_1()) * Matrix.CreateTranslation(this.vector2_0.X, this.vector2_0.Y, 0.0f);
    }
  }
}

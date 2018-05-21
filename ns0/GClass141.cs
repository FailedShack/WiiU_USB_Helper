// Decompiled with JetBrains decompiler
// Type: ns0.GClass141
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ns0
{
  public class GClass141 : GClass140
  {
    public GClass141(Texture2D texture2D_1, Rectangle rectangle_1)
      : base(texture2D_1, rectangle_1)
    {
    }

    public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
    {
      if (this.Texture == null)
        return;
      if (this.bool_0)
        spriteBatch_0.Draw(this.Texture, new Rectangle((int) ((double) this.Rectangle.X + 0.5 * (double) this.Rectangle.Width - 0.5 * ((double) this.Rectangle.Width * this.Scale)), (int) ((double) this.Rectangle.Y + 0.5 * (double) this.Rectangle.Height - 0.5 * ((double) this.Rectangle.Height * this.Scale)), (int) ((double) this.Rectangle.Width * this.Scale), (int) ((double) this.Rectangle.Height * this.Scale)), this.color_0 * (float) this.Opacity);
      else
        spriteBatch_0.Draw(this.Texture, new Rectangle(this.Rectangle.X, this.Rectangle.Y, (int) ((double) this.Rectangle.Width * this.Scale), (int) ((double) this.Rectangle.Height * this.Scale)), this.color_0 * (float) this.Opacity);
    }
  }
}

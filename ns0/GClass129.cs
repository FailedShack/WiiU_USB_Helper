// Decompiled with JetBrains decompiler
// Type: ns0.GClass129
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ns0
{
  public static class GClass129
  {
    public static void smethod_0(this SpriteBatch spriteBatch_0, Rectangle rectangle_0, Texture2D texture2D_0, int int_0, Color color_0)
    {
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location, new Point(int_0)), new Rectangle?(new Rectangle(0, 0, int_0, int_0)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(int_0, 0), new Point(rectangle_0.Width - int_0 * 2, int_0)), new Rectangle?(new Rectangle(int_0, 0, texture2D_0.Width - int_0 * 2, int_0)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(rectangle_0.Width - int_0, 0), new Point(int_0)), new Rectangle?(new Rectangle(texture2D_0.Width - int_0, 0, int_0, int_0)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(0, int_0), new Point(int_0, rectangle_0.Height - int_0 * 2)), new Rectangle?(new Rectangle(0, int_0, int_0, texture2D_0.Height - int_0 * 2)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(int_0), rectangle_0.Size - new Point(int_0 * 2)), new Rectangle?(new Rectangle(int_0, int_0, texture2D_0.Width - int_0 * 2, texture2D_0.Height - int_0 * 2)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(rectangle_0.Width - int_0, int_0), new Point(int_0, rectangle_0.Height - int_0 * 2)), new Rectangle?(new Rectangle(texture2D_0.Width - int_0, int_0, int_0, texture2D_0.Height - int_0 * 2)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(0, rectangle_0.Height - int_0), new Point(int_0)), new Rectangle?(new Rectangle(0, texture2D_0.Height - int_0, int_0, int_0)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + new Point(int_0, rectangle_0.Height - int_0), new Point(rectangle_0.Width - int_0 * 2, int_0)), new Rectangle?(new Rectangle(int_0, texture2D_0.Height - int_0, texture2D_0.Width - int_0 * 2, int_0)), color_0);
      spriteBatch_0.Draw(texture2D_0, new Rectangle(rectangle_0.Location + rectangle_0.Size - new Point(int_0), new Point(int_0)), new Rectangle?(new Rectangle(texture2D_0.Width - int_0, texture2D_0.Height - int_0, int_0, int_0)), color_0);
    }
  }
}

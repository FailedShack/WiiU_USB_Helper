// Decompiled with JetBrains decompiler
// Type: ns0.Class121
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;

namespace ns0
{
  internal class Class121 : GClass138
  {
    private GClass138 gclass138_0;
    private GClass142 gclass142_0;
    private bool bool_2;
    private Video video_0;
    private double double_0;
    private Texture2D texture2D_0;

    public Class121(Game game_0, GClass138 gclass138_1)
      : base(game_0)
    {
      this.gclass138_0 = gclass138_1;
      this.gclass138_0.method_3();
    }

    public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
    {
      this.gclass143_0.method_3(gameTime_0, spriteBatch_0);
    }

    public override void vmethod_1()
    {
      this.video_0 = this.contentManager_0.Load<Video>("splash");
      this.gclass142_0 = new GClass142(this.video_0);
      this.gclass142_0.Event_1 += (EventHandler) ((sender, e) =>
      {
        this.method_7();
        this.method_6(this.gclass138_0);
      });
      this.gclass143_0.method_0((GClass140) this.gclass142_0);
      base.vmethod_1();
    }

    public override void vmethod_2()
    {
      this.gclass142_0.Dispose();
      Texture2D texture2D0 = this.texture2D_0;
      if (texture2D0 != null)
      {
        // ISSUE: explicit non-virtual call
        __nonvirtual (texture2D0.Dispose());
      }
      base.vmethod_2();
    }

    public override void vmethod_3(GameTime gameTime_0)
    {
      this.gclass143_0.method_6(gameTime_0);
    }
  }
}

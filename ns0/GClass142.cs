// Decompiled with JetBrains decompiler
// Type: ns0.GClass142
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;

namespace ns0
{
  public class GClass142 : GClass140
  {
    public Video video_0;
    private VideoPlayer videoPlayer_0;
    private bool bool_4;

    public GClass142(Video video_1)
      : base((Texture2D) null, new Rectangle(0, 0, 1920, 1080))
    {
      this.video_0 = video_1;
      this.videoPlayer_0 = new VideoPlayer();
      this.videoPlayer_0.Play(this.video_0);
    }

    public event EventHandler Event_1;

    public bool IsLooping { get; set; }

    public override void Dispose()
    {
      base.Dispose();
      this.videoPlayer_0.Dispose();
    }

    public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
    {
      if (this.videoPlayer_0.State != MediaState.Playing)
        return;
      this.Texture = this.videoPlayer_0.GetTexture();
      if (this.Texture == null)
        return;
      this.bool_4 = true;
      spriteBatch_0.Draw(this.Texture, this.Rectangle, Color.White);
    }

    public override void vmethod_1(GameTime gameTime_0)
    {
      base.vmethod_1(gameTime_0);
      if (this.videoPlayer_0.State != MediaState.Playing && this.IsLooping)
        this.videoPlayer_0.Play(this.video_0);
      if (this.videoPlayer_0.State != MediaState.Stopped || !this.bool_4)
        return;
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler1 = this.eventHandler_1;
      if (eventHandler1 == null)
        return;
      eventHandler1((object) this, (EventArgs) null);
    }
  }
}

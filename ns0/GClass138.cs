// Decompiled with JetBrains decompiler
// Type: ns0.GClass138
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ns0
{
  public abstract class GClass138
  {
    public GClass143 gclass143_0 = new GClass143();
    public static GraphicsDevice graphicsDevice_0;
    public static GraphicsDeviceManager graphicsDeviceManager_0;
    public ContentManager contentManager_0;
    public GClass139 gclass139_0;

    public GClass138(Game game_0)
    {
      this.contentManager_0 = new ContentManager((IServiceProvider) game_0.Services);
      this.contentManager_0.RootDirectory = "Content";
    }

    public event EventHandler Event_0;

    public event EventHandler Event_1;

    public event EventHandler Event_2;

    public event EventHandler<GClass138> Event_3;

    public bool ContentLoaded { get; private set; }

    public bool Hide { get; set; }

    public void method_0()
    {
      this._animator = (GClass135) null;
    }

    public abstract void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0);

    public Matrix? method_1()
    {
      if (this._animator != null)
        return new Matrix?(this._animator.vmethod_0());
      return new Matrix?();
    }

    public void method_2(GClass135 gclass135_1)
    {
      this._animator = gclass135_1;
    }

    public virtual void vmethod_1()
    {
      this.ContentLoaded = true;
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler1 = this.eventHandler_1;
      if (eventHandler1 == null)
        return;
      eventHandler1((object) this, (EventArgs) null);
    }

    public void method_3()
    {
      Task.Run((Action) (() => this.vmethod_1()));
    }

    public virtual void vmethod_2()
    {
      this.contentManager_0.Unload();
    }

    public abstract void vmethod_3(GameTime gameTime_0);

    protected Texture2D method_4(string string_0)
    {
      using (MemoryStream memoryStream = new MemoryStream(GClass88.smethod_2(new Uri(string_0), TimeSpan.FromDays(999.0))))
      {
        try
        {
          return Texture2D.FromStream(GClass138.graphicsDevice_0, (Stream) memoryStream);
        }
        catch
        {
          return (Texture2D) null;
        }
      }
    }

    protected void method_5()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }

    protected void method_6(GClass138 gclass138_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<GClass138> eventHandler3 = this.eventHandler_3;
      if (eventHandler3 == null)
        return;
      eventHandler3((object) this, gclass138_0);
    }

    protected void method_7()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler2 = this.eventHandler_2;
      if (eventHandler2 != null)
        eventHandler2((object) this, (EventArgs) null);
      this.vmethod_2();
    }

    private GClass135 _animator { get; set; }
  }
}

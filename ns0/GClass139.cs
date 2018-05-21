// Decompiled with JetBrains decompiler
// Type: ns0.GClass139
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ns0
{
  public class GClass139
  {
    private List<GClass138> list_0 = new List<GClass138>();
    private KeyboardState keyboardState_0;

    public GClass139(GraphicsDevice graphicsDevice_1, GraphicsDeviceManager graphicsDeviceManager_1)
    {
      this.Device = graphicsDevice_1;
      this.Graphics = graphicsDeviceManager_1;
      GClass138.graphicsDevice_0 = graphicsDevice_1;
      GClass138.graphicsDeviceManager_0 = graphicsDeviceManager_1;
    }

    public event EventHandler Event_0;

    public GClass138 GClass138_0
    {
      get
      {
        if (this.list_0.Count <= 0)
          return (GClass138) null;
        return this.list_0.Last<GClass138>();
      }
    }

    public GraphicsDevice Device { get; private set; }

    public GraphicsDeviceManager Graphics { get; private set; }

    public bool Pause { get; set; }

    public void method_0(GClass138 gclass138_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass139.Class122 class122 = new GClass139.Class122();
      // ISSUE: reference to a compiler-generated field
      class122.gclass139_0 = this;
      // ISSUE: reference to a compiler-generated field
      class122.gclass138_0 = gclass138_0;
      // ISSUE: reference to a compiler-generated field
      if (!this.list_0.Contains(class122.gclass138_0))
      {
        // ISSUE: reference to a compiler-generated field
        class122.gclass138_0.gclass139_0 = this;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class122.gclass138_0.Event_0 += new EventHandler(class122.method_0);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class122.gclass138_0.Event_2 += new EventHandler(class122.method_1);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class122.gclass138_0.Event_3 += new EventHandler<GClass138>(class122.method_2);
        // ISSUE: reference to a compiler-generated field
        this.list_0.Add(class122.gclass138_0);
      }
      else
      {
        GClass138 gclass138 = this.list_0.Last<GClass138>();
        // ISSUE: reference to a compiler-generated field
        this.list_0[this.list_0.IndexOf(class122.gclass138_0)] = gclass138;
        // ISSUE: reference to a compiler-generated field
        this.list_0[this.list_0.Count - 1] = class122.gclass138_0;
      }
    }

    public void method_1(GameTime gameTime_0, SpriteBatch spriteBatch_0)
    {
      this.Device.Clear(Color.Black);
      if (this.GClass138_0 == null || !this.GClass138_0.ContentLoaded || (this.GClass138_0.Hide || this.Pause))
        return;
      spriteBatch_0.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, this.GClass138_0.method_1());
      this.GClass138_0.vmethod_0(gameTime_0, spriteBatch_0);
      spriteBatch_0.End();
    }

    public bool method_2(Keys keys_0)
    {
      KeyboardState state = Keyboard.GetState();
      if (this.keyboardState_0.IsKeyUp(keys_0))
        return state.IsKeyDown(keys_0);
      return false;
    }

    public void method_3(GClass138 gclass138_0)
    {
      if (!this.list_0.Contains(gclass138_0))
        return;
      this.list_0.Remove(gclass138_0);
    }

    public void method_4()
    {
      foreach (GClass138 gclass138 in this.list_0)
        gclass138.vmethod_2();
      this.list_0.Clear();
    }

    public void method_5(GameTime gameTime_0)
    {
      if (this.GClass138_0 == null || !this.GClass138_0.ContentLoaded || (this.GClass138_0.Hide || this.Pause))
        return;
      this.GClass138_0.vmethod_3(gameTime_0);
      this.keyboardState_0 = Keyboard.GetState();
    }
  }
}

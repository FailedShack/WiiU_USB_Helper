// Decompiled with JetBrains decompiler
// Type: ns0.GClass130
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
  public class GClass130 : Game
  {
    private const int int_0 = -20;
    private const int int_1 = 3;
    private const int int_2 = 2;
    private const int int_3 = 1;
    private const int int_4 = 262144;
    private const int int_5 = 128;
    private Form form_0;
    private bool bool_0;
    private GraphicsDeviceManager graphicsDeviceManager_0;
    private Class120 class120_0;
    private SpriteBatch spriteBatch_0;
    private RenderTarget2D renderTarget2D_0;
    private GClass139 gclass139_0;

    public GClass130(Form form_1)
    {
      this.form_0 = form_1;
      this.graphicsDeviceManager_0 = new GraphicsDeviceManager((Game) this)
      {
        PreferredBackBufferWidth = 1920,
        PreferredBackBufferHeight = 1080,
        IsFullScreen = true,
        GraphicsProfile = GraphicsProfile.HiDef,
        HardwareModeSwitch = false
      };
      this.bool_0 = true;
      this.graphicsDeviceManager_0.ApplyChanges();
      this.gclass139_0 = new GClass139(this.GraphicsDevice, this.graphicsDeviceManager_0);
      this.gclass139_0.Event_0 += (EventHandler) ((sender, e) => this.bool_0 = true);
      this.Content.RootDirectory = "Content";
    }

    public void method_0()
    {
      IntPtr handle = this.Window.Handle;
      if (!handle.Equals((object) IntPtr.Zero))
        GClass130.ShowWindow(handle, 0);
      this.form_0.Invoke((Delegate) (() => this.form_0.BringToFront()));
      this.gclass139_0.Pause = true;
    }

    public void method_1()
    {
      this.gclass139_0.Pause = false;
      this.class120_0.method_9();
    }

    protected override void Draw(GameTime gameTime)
    {
      if (this.bool_0)
      {
        GClass130.ShowWindow(this.Window.Handle, 3);
        GClass130.SetForegroundWindow(this.Window.Handle);
        this.bool_0 = false;
      }
      if (!this.graphicsDeviceManager_0.IsFullScreen)
        this.graphicsDeviceManager_0.ToggleFullScreen();
      this.GraphicsDevice.SetRenderTarget(this.renderTarget2D_0);
      this.gclass139_0.method_1(gameTime, this.spriteBatch_0);
      this.GraphicsDevice.SetRenderTarget((RenderTarget2D) null);
      this.spriteBatch_0.Begin(SpriteSortMode.Deferred, (BlendState) null, (SamplerState) null, (DepthStencilState) null, (RasterizerState) null, (Effect) null, new Matrix?());
      this.spriteBatch_0.Draw((Texture2D) this.renderTarget2D_0, new Rectangle(0, 0, this.GraphicsDevice.Viewport.Width, this.GraphicsDevice.Viewport.Height), Color.White);
      this.spriteBatch_0.End();
      base.Draw(gameTime);
    }

    protected override void Initialize()
    {
      MediaPlayer.IsRepeating = true;
      this.renderTarget2D_0 = new RenderTarget2D(this.GraphicsDevice, 1920, 1080);
      this.spriteBatch_0 = new SpriteBatch(this.GraphicsDevice);
      base.Initialize();
    }

    protected override void LoadContent()
    {
      this.class120_0 = new Class120((Game) this);
      Class121 class121 = new Class121((Game) this, (GClass138) this.class120_0);
      class121.vmethod_1();
      this.gclass139_0.method_0((GClass138) class121);
    }

    protected override void UnloadContent()
    {
    }

    protected override void Update(GameTime gameTime)
    {
      this.gclass139_0.method_5(gameTime);
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
      {
        GClass136 gclass136 = new GClass136(this.GraphicsDevice.Viewport.Bounds.Center.ToVector2(), 1.0, 0.0, 350.0);
        gclass136.Event_0 += (EventHandler) ((sender, e) => this.method_0());
        GClass138 gclass1380 = this.gclass139_0.GClass138_0;
        if (gclass1380 != null)
          gclass1380.method_2((GClass135) gclass136);
      }
      base.Update(gameTime);
    }

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int GetWindowLong(IntPtr intptr_0, int int_6);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool SetForegroundWindow(IntPtr intptr_0);

    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr intptr_0, int int_6, int int_7);

    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr intptr_0, int int_6);
  }
}

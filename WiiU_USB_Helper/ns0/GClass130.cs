using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ns0
{
	// Token: 0x0200014F RID: 335
	public class GClass130 : Game
	{
		// Token: 0x06000904 RID: 2308 RVA: 0x000383DC File Offset: 0x000365DC
		public GClass130(Form form_1)
		{
			this.form_0 = form_1;
			this.graphicsDeviceManager_0 = new GraphicsDeviceManager(this)
			{
				PreferredBackBufferWidth = 1920,
				PreferredBackBufferHeight = 1080,
				IsFullScreen = true,
				GraphicsProfile = GraphicsProfile.HiDef,
				HardwareModeSwitch = false
			};
			this.bool_0 = true;
			this.graphicsDeviceManager_0.ApplyChanges();
			this.gclass139_0 = new GClass139(base.GraphicsDevice, this.graphicsDeviceManager_0);
			this.gclass139_0.Event_0 += this.method_2;
			base.Content.RootDirectory = "Content";
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00038480 File Offset: 0x00036680
		public void method_0()
		{
			IntPtr handle = base.Window.Handle;
			if (!handle.Equals(IntPtr.Zero))
			{
				GClass130.ShowWindow(handle, 0);
			}
			this.form_0.Invoke(new MethodInvoker(this.method_3));
			this.gclass139_0.Pause = true;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00015CFD File Offset: 0x00013EFD
		public void method_1()
		{
			this.gclass139_0.Pause = false;
			this.class118_0.method_9();
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000384D8 File Offset: 0x000366D8
		protected override void Draw(GameTime gameTime)
		{
			if (this.bool_0)
			{
				GClass130.ShowWindow(base.Window.Handle, 3);
				GClass130.SetForegroundWindow(base.Window.Handle);
				this.bool_0 = false;
			}
			if (!this.graphicsDeviceManager_0.IsFullScreen)
			{
				this.graphicsDeviceManager_0.ToggleFullScreen();
			}
			base.GraphicsDevice.SetRenderTarget(this.renderTarget2D_0);
			this.gclass139_0.method_1(gameTime, this.spriteBatch_0);
			base.GraphicsDevice.SetRenderTarget(null);
			this.spriteBatch_0.Begin(SpriteSortMode.Deferred, null, null, null, null, null, null);
			this.spriteBatch_0.Draw(this.renderTarget2D_0, new Rectangle(0, 0, base.GraphicsDevice.Viewport.Width, base.GraphicsDevice.Viewport.Height), Color.White);
			this.spriteBatch_0.End();
			base.Draw(gameTime);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00015D16 File Offset: 0x00013F16
		protected override void Initialize()
		{
			MediaPlayer.IsRepeating = true;
			this.renderTarget2D_0 = new RenderTarget2D(base.GraphicsDevice, 1920, 1080);
			this.spriteBatch_0 = new SpriteBatch(base.GraphicsDevice);
			base.Initialize();
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000385D0 File Offset: 0x000367D0
		protected override void LoadContent()
		{
			this.class118_0 = new Class118(this);
			Class119 @class = new Class119(this, this.class118_0);
			@class.vmethod_1();
			this.gclass139_0.method_0(@class);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000142A3 File Offset: 0x000124A3
		protected override void UnloadContent()
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00038608 File Offset: 0x00036808
		protected override void Update(GameTime gameTime)
		{
			this.gclass139_0.method_5(gameTime);
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
			{
				GClass136 gclass = new GClass136(base.GraphicsDevice.Viewport.Bounds.Center.ToVector2(), 1.0, 0.0, 350.0);
				gclass.Event_0 += this.method_4;
				GClass138 gclass138_ = this.gclass139_0.GClass138_0;
				if (gclass138_ != null)
				{
					gclass138_.method_2(gclass);
				}
			}
			base.Update(gameTime);
		}

		// Token: 0x0600090C RID: 2316
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowLong(IntPtr intptr_0, int int_6);

		// Token: 0x0600090D RID: 2317
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool SetForegroundWindow(IntPtr intptr_0);

		// Token: 0x0600090E RID: 2318
		[DllImport("user32.dll")]
		private static extern int SetWindowLong(IntPtr intptr_0, int int_6, int int_7);

		// Token: 0x0600090F RID: 2319
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr intptr_0, int int_6);

		// Token: 0x06000910 RID: 2320 RVA: 0x00015D50 File Offset: 0x00013F50
		[CompilerGenerated]
		private void method_2(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00015D59 File Offset: 0x00013F59
		[CompilerGenerated]
		private void method_3()
		{
			this.form_0.BringToFront();
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00015D66 File Offset: 0x00013F66
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x04000561 RID: 1377
		private const int int_0 = -20;

		// Token: 0x04000562 RID: 1378
		private const int int_1 = 3;

		// Token: 0x04000563 RID: 1379
		private const int int_2 = 2;

		// Token: 0x04000564 RID: 1380
		private const int int_3 = 1;

		// Token: 0x04000565 RID: 1381
		private const int int_4 = 262144;

		// Token: 0x04000566 RID: 1382
		private const int int_5 = 128;

		// Token: 0x04000567 RID: 1383
		private Form form_0;

		// Token: 0x04000568 RID: 1384
		private bool bool_0;

		// Token: 0x04000569 RID: 1385
		private GraphicsDeviceManager graphicsDeviceManager_0;

		// Token: 0x0400056A RID: 1386
		private Class118 class118_0;

		// Token: 0x0400056B RID: 1387
		private SpriteBatch spriteBatch_0;

		// Token: 0x0400056C RID: 1388
		private RenderTarget2D renderTarget2D_0;

		// Token: 0x0400056D RID: 1389
		private GClass139 gclass139_0;
	}
}

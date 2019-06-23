using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ns0
{
	// Token: 0x0200015F RID: 351
	public class GClass139
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x000162C7 File Offset: 0x000144C7
		public GClass139(GraphicsDevice graphicsDevice_1, GraphicsDeviceManager graphicsDeviceManager_1)
		{
			this.Device = graphicsDevice_1;
			this.Graphics = graphicsDeviceManager_1;
			GClass138.graphicsDevice_0 = graphicsDevice_1;
			GClass138.graphicsDeviceManager_0 = graphicsDeviceManager_1;
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000987 RID: 2439 RVA: 0x0003A3BC File Offset: 0x000385BC
		// (remove) Token: 0x06000988 RID: 2440 RVA: 0x0003A3F4 File Offset: 0x000385F4
		public event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000162F4 File Offset: 0x000144F4
		public GClass138 GClass138_0
		{
			get
			{
				if (this.list_0.Count <= 0)
				{
					return null;
				}
				return this.list_0.Last<GClass138>();
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00016311 File Offset: 0x00014511
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00016319 File Offset: 0x00014519
		public GraphicsDevice Device { get; private set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00016322 File Offset: 0x00014522
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0001632A File Offset: 0x0001452A
		public GraphicsDeviceManager Graphics { get; private set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00016333 File Offset: 0x00014533
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0001633B File Offset: 0x0001453B
		public bool Pause { get; set; }

		// Token: 0x06000990 RID: 2448 RVA: 0x0003A42C File Offset: 0x0003862C
		public void method_0(GClass138 gclass138_0)
		{
			GClass139.Class120 @class = new GClass139.Class120();
			@class.gclass139_0 = this;
			@class.gclass138_0 = gclass138_0;
			if (!this.list_0.Contains(@class.gclass138_0))
			{
				@class.gclass138_0.gclass139_0 = this;
				@class.gclass138_0.Event_0 += @class.method_0;
				@class.gclass138_0.Event_2 += @class.method_1;
				@class.gclass138_0.Event_3 += @class.method_2;
				this.list_0.Add(@class.gclass138_0);
				return;
			}
			GClass138 value = this.list_0.Last<GClass138>();
			int index = this.list_0.IndexOf(@class.gclass138_0);
			this.list_0[index] = value;
			this.list_0[this.list_0.Count - 1] = @class.gclass138_0;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0003A50C File Offset: 0x0003870C
		public void method_1(GameTime gameTime_0, SpriteBatch spriteBatch_0)
		{
			this.Device.Clear(Color.Black);
			if (this.GClass138_0 != null && this.GClass138_0.ContentLoaded && !this.GClass138_0.Hide && !this.Pause)
			{
				spriteBatch_0.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, this.GClass138_0.method_1());
				this.GClass138_0.vmethod_0(gameTime_0, spriteBatch_0);
				spriteBatch_0.End();
				return;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0003A584 File Offset: 0x00038784
		public bool method_2(Keys keys_0)
		{
			KeyboardState state = Keyboard.GetState();
			return this.keyboardState_0.IsKeyUp(keys_0) && state.IsKeyDown(keys_0);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00016344 File Offset: 0x00014544
		public void method_3(GClass138 gclass138_0)
		{
			if (this.list_0.Contains(gclass138_0))
			{
				this.list_0.Remove(gclass138_0);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0003A5B0 File Offset: 0x000387B0
		public void method_4()
		{
			foreach (GClass138 gclass in this.list_0)
			{
				gclass.vmethod_2();
			}
			this.list_0.Clear();
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0003A60C File Offset: 0x0003880C
		public void method_5(GameTime gameTime_0)
		{
			if (this.GClass138_0 != null && this.GClass138_0.ContentLoaded && !this.GClass138_0.Hide && !this.Pause)
			{
				this.GClass138_0.vmethod_3(gameTime_0);
				this.keyboardState_0 = Keyboard.GetState();
				return;
			}
		}

		// Token: 0x040005BE RID: 1470
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040005BF RID: 1471
		[CompilerGenerated]
		private GraphicsDevice graphicsDevice_0;

		// Token: 0x040005C0 RID: 1472
		[CompilerGenerated]
		private GraphicsDeviceManager graphicsDeviceManager_0;

		// Token: 0x040005C1 RID: 1473
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040005C2 RID: 1474
		private KeyboardState keyboardState_0;

		// Token: 0x040005C3 RID: 1475
		private List<GClass138> list_0 = new List<GClass138>();

		// Token: 0x02000160 RID: 352
		[CompilerGenerated]
		private sealed class Class120
		{
			// Token: 0x06000997 RID: 2455 RVA: 0x00016361 File Offset: 0x00014561
			internal void method_0(object sender, EventArgs e)
			{
				EventHandler eventHandler_ = this.gclass139_0.eventHandler_0;
				if (eventHandler_ == null)
				{
					return;
				}
				eventHandler_(this.gclass139_0, null);
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x0001637F File Offset: 0x0001457F
			internal void method_1(object sender, EventArgs e)
			{
				this.gclass139_0.method_3(this.gclass138_0);
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x00016392 File Offset: 0x00014592
			internal void method_2(object object_0, GClass138 gclass138_1)
			{
				this.gclass139_0.method_0(gclass138_1);
			}

			// Token: 0x040005C4 RID: 1476
			public GClass139 gclass139_0;

			// Token: 0x040005C5 RID: 1477
			public GClass138 gclass138_0;
		}
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ns0
{
	// Token: 0x0200015E RID: 350
	public abstract class GClass138
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x000161C7 File Offset: 0x000143C7
		public GClass138(Game game_0)
		{
			this.contentManager_0 = new ContentManager(game_0.Services);
			this.contentManager_0.RootDirectory = "Content";
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x0600096B RID: 2411 RVA: 0x0003A164 File Offset: 0x00038364
		// (remove) Token: 0x0600096C RID: 2412 RVA: 0x0003A19C File Offset: 0x0003839C
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

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600096D RID: 2413 RVA: 0x0003A1D4 File Offset: 0x000383D4
		// (remove) Token: 0x0600096E RID: 2414 RVA: 0x0003A20C File Offset: 0x0003840C
		public event EventHandler Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600096F RID: 2415 RVA: 0x0003A244 File Offset: 0x00038444
		// (remove) Token: 0x06000970 RID: 2416 RVA: 0x0003A27C File Offset: 0x0003847C
		public event EventHandler Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000971 RID: 2417 RVA: 0x0003A2B4 File Offset: 0x000384B4
		// (remove) Token: 0x06000972 RID: 2418 RVA: 0x0003A2EC File Offset: 0x000384EC
		public event EventHandler<GClass138> Event_3
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass138> eventHandler = this.eventHandler_3;
				EventHandler<GClass138> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass138> value2 = (EventHandler<GClass138>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass138>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass138> eventHandler = this.eventHandler_3;
				EventHandler<GClass138> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass138> value2 = (EventHandler<GClass138>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass138>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000161FB File Offset: 0x000143FB
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00016203 File Offset: 0x00014403
		public bool ContentLoaded { get; private set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0001620C File Offset: 0x0001440C
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00016214 File Offset: 0x00014414
		public bool Hide { get; set; }

		// Token: 0x06000977 RID: 2423 RVA: 0x0001621D File Offset: 0x0001441D
		public void method_0()
		{
			this._animator = null;
		}

		// Token: 0x06000978 RID: 2424
		public abstract void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0);

		// Token: 0x06000979 RID: 2425 RVA: 0x0003A324 File Offset: 0x00038524
		public Matrix? method_1()
		{
			if (this._animator != null)
			{
				return new Matrix?(this._animator.vmethod_0());
			}
			return null;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00016226 File Offset: 0x00014426
		public void method_2(GClass135 gclass135_1)
		{
			this._animator = gclass135_1;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001622F File Offset: 0x0001442F
		public virtual void vmethod_1()
		{
			this.ContentLoaded = true;
			EventHandler eventHandler = this.eventHandler_1;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0001624A File Offset: 0x0001444A
		public void method_3()
		{
			Task.Run(new Action(this.method_8));
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0001625E File Offset: 0x0001445E
		public virtual void vmethod_2()
		{
			this.contentManager_0.Unload();
		}

		// Token: 0x0600097E RID: 2430
		public abstract void vmethod_3(GameTime gameTime_0);

		// Token: 0x0600097F RID: 2431 RVA: 0x0003A354 File Offset: 0x00038554
		protected Texture2D method_4(string string_0)
		{
			Texture2D result;
			using (MemoryStream memoryStream = new MemoryStream(GClass88.smethod_2(new Uri(string_0), TimeSpan.FromDays(999.0))))
			{
				try
				{
					result = Texture2D.FromStream(GClass138.graphicsDevice_0, memoryStream);
				}
				catch
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0001626B File Offset: 0x0001446B
		protected void method_5()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001627F File Offset: 0x0001447F
		protected void method_6(GClass138 gclass138_0)
		{
			EventHandler<GClass138> eventHandler = this.eventHandler_3;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, gclass138_0);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00016293 File Offset: 0x00014493
		protected void method_7()
		{
			EventHandler eventHandler = this.eventHandler_2;
			if (eventHandler != null)
			{
				eventHandler(this, null);
			}
			this.vmethod_2();
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000162AE File Offset: 0x000144AE
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x000162B6 File Offset: 0x000144B6
		private GClass135 _animator { get; set; }

		// Token: 0x06000985 RID: 2437 RVA: 0x000162BF File Offset: 0x000144BF
		[CompilerGenerated]
		private void method_8()
		{
			this.vmethod_1();
		}

		// Token: 0x040005B2 RID: 1458
		public static GraphicsDevice graphicsDevice_0;

		// Token: 0x040005B3 RID: 1459
		public static GraphicsDeviceManager graphicsDeviceManager_0;

		// Token: 0x040005B4 RID: 1460
		public ContentManager contentManager_0;

		// Token: 0x040005B5 RID: 1461
		public GClass143 gclass143_0 = new GClass143();

		// Token: 0x040005B6 RID: 1462
		public GClass139 gclass139_0;

		// Token: 0x040005B7 RID: 1463
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040005B8 RID: 1464
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x040005B9 RID: 1465
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x040005BA RID: 1466
		[CompilerGenerated]
		private EventHandler<GClass138> eventHandler_3;

		// Token: 0x040005BB RID: 1467
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040005BC RID: 1468
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040005BD RID: 1469
		[CompilerGenerated]
		private GClass135 gclass135_0;
	}
}

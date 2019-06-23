using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ns0
{
	// Token: 0x02000163 RID: 355
	public abstract class GClass140 : IDisposable
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x0003A72C File Offset: 0x0003892C
		public GClass140(Texture2D texture2D_1, Rectangle rectangle_1)
		{
			this.Texture = texture2D_1;
			this.Rectangle = rectangle_1;
			this.vector2_0 = this.Vector2_0;
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060009A4 RID: 2468 RVA: 0x0003A794 File Offset: 0x00038994
		// (remove) Token: 0x060009A5 RID: 2469 RVA: 0x0003A7CC File Offset: 0x000389CC
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0001644D File Offset: 0x0001464D
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00016455 File Offset: 0x00014655
		public bool Hide { get; set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0001645E File Offset: 0x0001465E
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00016466 File Offset: 0x00014666
		public double Opacity { get; set; } = 1.0;

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0001646F File Offset: 0x0001466F
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x0001648E File Offset: 0x0001468E
		public Vector2 Vector2_0
		{
			get
			{
				return new Vector2((float)this.Rectangle.X, (float)this.Rectangle.Y);
			}
			set
			{
				this.Rectangle = new Rectangle((int)value.X, (int)value.Y, this.Rectangle.Width, this.Rectangle.Height);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000164BF File Offset: 0x000146BF
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x000164C7 File Offset: 0x000146C7
		public Rectangle Rectangle { get; protected set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x000164D0 File Offset: 0x000146D0
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x000164D8 File Offset: 0x000146D8
		public double Scale { get; set; } = 1.0;

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000164E1 File Offset: 0x000146E1
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x000164E9 File Offset: 0x000146E9
		public object Tag { get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000164F2 File Offset: 0x000146F2
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x000164FA File Offset: 0x000146FA
		public Texture2D Texture { get; set; }

		// Token: 0x060009B4 RID: 2484 RVA: 0x0003A804 File Offset: 0x00038A04
		public void method_0()
		{
			GClass137[] array = this.list_0.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].method_0();
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00016503 File Offset: 0x00014703
		public void method_1(GClass137 gclass137_0)
		{
			gclass137_0.Target = this;
			this.list_0.Add(gclass137_0);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00016518 File Offset: 0x00014718
		public virtual void Dispose()
		{
			Texture2D texture = this.Texture;
			if (texture == null)
			{
				return;
			}
			texture.Dispose();
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0001652A File Offset: 0x0001472A
		public void method_2()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0003A834 File Offset: 0x00038A34
		public void method_3(Vector2 vector2_3, bool bool_3, float float_2 = 0f)
		{
			if (bool_3 && vector2_3 != this.Vector2_0)
			{
				this.vector2_0 = vector2_3;
				this.bool_2 = bool_3;
				this.float_1 = float_2;
				this.vector2_1 = Vector2.Normalize(this.vector2_0 - this.Vector2_0);
				this.float_0 = Vector2.Distance(this.Vector2_0, this.vector2_0);
				this.vector2_2 = this.Vector2_0;
				return;
			}
			this.Vector2_0 = vector2_3;
		}

		// Token: 0x060009B9 RID: 2489
		public abstract void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0);

		// Token: 0x060009BA RID: 2490 RVA: 0x0001653E File Offset: 0x0001473E
		public void method_4()
		{
			this.list_0.Clear();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0003A8B0 File Offset: 0x00038AB0
		public void method_5()
		{
			GClass137[] array = this.list_0.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].method_2();
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0003A8E0 File Offset: 0x00038AE0
		public virtual void vmethod_1(GameTime gameTime_0)
		{
			GClass137[] array = this.list_0.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].method_1();
			}
			if (this.bool_2)
			{
				this.Vector2_0 += this.vector2_1 * 2f * (float)gameTime_0.ElapsedGameTime.TotalMilliseconds;
				if (Vector2.Distance(this.vector2_2, this.Vector2_0) >= this.float_0)
				{
					this.Vector2_0 = this.vector2_0;
					this.bool_2 = false;
				}
			}
		}

		// Token: 0x040005CE RID: 1486
		public Color color_0 = Color.White;

		// Token: 0x040005CF RID: 1487
		public Vector2 vector2_0;

		// Token: 0x040005D0 RID: 1488
		public bool bool_0 = true;

		// Token: 0x040005D1 RID: 1489
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x040005D2 RID: 1490
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040005D3 RID: 1491
		[CompilerGenerated]
		private double double_0;

		// Token: 0x040005D4 RID: 1492
		[CompilerGenerated]
		private Rectangle rectangle_0;

		// Token: 0x040005D5 RID: 1493
		[CompilerGenerated]
		private double double_1;

		// Token: 0x040005D6 RID: 1494
		[CompilerGenerated]
		private object object_0;

		// Token: 0x040005D7 RID: 1495
		[CompilerGenerated]
		private Texture2D texture2D_0;

		// Token: 0x040005D8 RID: 1496
		private List<GClass137> list_0 = new List<GClass137>();

		// Token: 0x040005D9 RID: 1497
		private Vector2 vector2_1;

		// Token: 0x040005DA RID: 1498
		private float float_0;

		// Token: 0x040005DB RID: 1499
		private bool bool_2;

		// Token: 0x040005DC RID: 1500
		private float float_1;

		// Token: 0x040005DD RID: 1501
		private Vector2 vector2_2;
	}
}

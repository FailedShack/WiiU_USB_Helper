using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace ns0
{
	// Token: 0x02000167 RID: 359
	public class GClass142 : GClass140
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x000165FF File Offset: 0x000147FF
		public GClass142(Video video_1) : base(null, new Rectangle(0, 0, 1920, 1080))
		{
			this.video_0 = video_1;
			this.videoPlayer_0 = new VideoPlayer();
			this.videoPlayer_0.Play(this.video_0);
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060009CD RID: 2509 RVA: 0x0003ABDC File Offset: 0x00038DDC
		// (remove) Token: 0x060009CE RID: 2510 RVA: 0x0003AC14 File Offset: 0x00038E14
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0001663C File Offset: 0x0001483C
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00016644 File Offset: 0x00014844
		public bool IsLooping { get; set; }

		// Token: 0x060009D1 RID: 2513 RVA: 0x0001664D File Offset: 0x0001484D
		public override void Dispose()
		{
			base.Dispose();
			this.videoPlayer_0.Dispose();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0003AC4C File Offset: 0x00038E4C
		public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
		{
			if (this.videoPlayer_0.State == MediaState.Playing)
			{
				base.Texture = this.videoPlayer_0.GetTexture();
				if (base.Texture != null)
				{
					this.bool_4 = true;
					spriteBatch_0.Draw(base.Texture, base.Rectangle, Color.White);
				}
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0003ACA0 File Offset: 0x00038EA0
		public override void vmethod_1(GameTime gameTime_0)
		{
			base.vmethod_1(gameTime_0);
			if (this.videoPlayer_0.State != MediaState.Playing && this.IsLooping)
			{
				this.videoPlayer_0.Play(this.video_0);
			}
			if (this.videoPlayer_0.State == MediaState.Stopped && this.bool_4)
			{
				EventHandler eventHandler = this.eventHandler_1;
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(this, null);
			}
		}

		// Token: 0x040005E3 RID: 1507
		public Video video_0;

		// Token: 0x040005E4 RID: 1508
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x040005E5 RID: 1509
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040005E6 RID: 1510
		private VideoPlayer videoPlayer_0;

		// Token: 0x040005E7 RID: 1511
		private bool bool_4;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x020000BC RID: 188
	public abstract class GClass85
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060004C6 RID: 1222 RVA: 0x0002A1E0 File Offset: 0x000283E0
		// (remove) Token: 0x060004C7 RID: 1223 RVA: 0x0002A218 File Offset: 0x00028418
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

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001325D File Offset: 0x0001145D
		public static byte[] smethod_0(string string_0, TimeSpan timeSpan_0)
		{
			if (Uri.IsWellFormedUriString(string_0, UriKind.Absolute))
			{
				return GClass88.smethod_2(new Uri(string_0), timeSpan_0);
			}
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002A250 File Offset: 0x00028450
		public virtual void vmethod_0(string string_0, TimeSpan timeSpan_0)
		{
			if (Uri.IsWellFormedUriString(string_0, UriKind.Absolute))
			{
				GClass88.smethod_3(new Uri(string_0), timeSpan_0, new Action<GClass87>(this.method_0), new Action(this.method_1));
				return;
			}
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060004CA RID: 1226 RVA: 0x0002A2A0 File Offset: 0x000284A0
		// (remove) Token: 0x060004CB RID: 1227 RVA: 0x0002A2D8 File Offset: 0x000284D8
		protected event EventHandler<GClass87> Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass87> eventHandler = this.eventHandler_1;
				EventHandler<GClass87> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass87> value2 = (EventHandler<GClass87>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass87>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass87> eventHandler = this.eventHandler_1;
				EventHandler<GClass87> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass87> value2 = (EventHandler<GClass87>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass87>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00013276 File Offset: 0x00011476
		[CompilerGenerated]
		private void method_0(GClass87 gclass87_0)
		{
			EventHandler<GClass87> eventHandler = this.eventHandler_1;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, gclass87_0);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0001328A File Offset: 0x0001148A
		[CompilerGenerated]
		private void method_1()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x04000305 RID: 773
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04000306 RID: 774
		[CompilerGenerated]
		private EventHandler<GClass87> eventHandler_1;
	}
}

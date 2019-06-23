using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

namespace ns0
{
	// Token: 0x0200015C RID: 348
	public abstract class GClass135
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000960 RID: 2400 RVA: 0x0003A0F4 File Offset: 0x000382F4
		// (remove) Token: 0x06000961 RID: 2401 RVA: 0x0003A12C File Offset: 0x0003832C
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

		// Token: 0x06000962 RID: 2402
		public abstract Matrix vmethod_0();

		// Token: 0x06000963 RID: 2403 RVA: 0x00016115 File Offset: 0x00014315
		protected void method_0()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x040005AE RID: 1454
		[CompilerGenerated]
		private EventHandler eventHandler_0;
	}
}

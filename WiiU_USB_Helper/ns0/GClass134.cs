using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000156 RID: 342
	public class GClass134
	{
		// Token: 0x06000931 RID: 2353 RVA: 0x00015F0D File Offset: 0x0001410D
		public GClass134(double double_4, double double_5, double double_6)
		{
			this.double_2 = double_4;
			this.double_1 = double_5;
			this.double_0 = double_6;
			this.double_3 = (double_5 - double_4) / double_6;
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000932 RID: 2354 RVA: 0x00038C00 File Offset: 0x00036E00
		// (remove) Token: 0x06000933 RID: 2355 RVA: 0x00038C38 File Offset: 0x00036E38
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00015F35 File Offset: 0x00014135
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00015F3D File Offset: 0x0001413D
		public bool IsLooping { get; set; }

		// Token: 0x06000936 RID: 2358 RVA: 0x00015F46 File Offset: 0x00014146
		public void method_0()
		{
			this.bool_1 = true;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00038C70 File Offset: 0x00036E70
		public double method_1()
		{
			if (this.nullable_0 == null)
			{
				this.nullable_0 = new DateTime?(DateTime.Now);
			}
			double num = (DateTime.Now - this.nullable_0.Value).TotalMilliseconds;
			if (num >= this.double_0)
			{
				if (!this.IsLooping)
				{
					if (!this.bool_1)
					{
						this.method_4();
					}
					this.bool_1 = true;
					return this.double_1;
				}
				double num2 = this.double_2;
				this.double_2 = this.double_1;
				this.double_1 = num2;
				this.double_3 *= -1.0;
				this.nullable_0 = new DateTime?(DateTime.Now);
				num = 0.0;
			}
			return this.double_3 * num + this.double_2;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00038D40 File Offset: 0x00036F40
		public bool method_2()
		{
			return this.bool_1 || (this.nullable_0 != null && !this.IsLooping && (this.bool_1 = ((DateTime.Now - this.nullable_0.Value).TotalMilliseconds >= this.double_0)));
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00015F4F File Offset: 0x0001414F
		public void method_3()
		{
			this.bool_1 = false;
			this.nullable_0 = new DateTime?(DateTime.Now);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00015F68 File Offset: 0x00014168
		private void method_4()
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x0400057B RID: 1403
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x0400057C RID: 1404
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400057D RID: 1405
		private double double_0;

		// Token: 0x0400057E RID: 1406
		private double double_1;

		// Token: 0x0400057F RID: 1407
		private bool bool_1;

		// Token: 0x04000580 RID: 1408
		private double double_2;

		// Token: 0x04000581 RID: 1409
		private DateTime? nullable_0;

		// Token: 0x04000582 RID: 1410
		private double double_3;
	}
}

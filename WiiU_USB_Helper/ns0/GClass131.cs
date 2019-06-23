using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000150 RID: 336
	public static class GClass131
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000913 RID: 2323 RVA: 0x000386C4 File Offset: 0x000368C4
		// (remove) Token: 0x06000914 RID: 2324 RVA: 0x000386F8 File Offset: 0x000368F8
		public static event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = GClass131.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref GClass131.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = GClass131.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref GClass131.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00015D6E File Offset: 0x00013F6E
		public static void smethod_0(Action<GClass132> action_0)
		{
			GClass131.Class113 @class = new GClass131.Class113();
			@class.action_0 = action_0;
			@class.eventHandler_0 = null;
			@class.eventHandler_0 = new EventHandler(@class.method_0);
			GClass131.Event_0 += @class.eventHandler_0;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0003872C File Offset: 0x0003692C
		public static List<GClass132> smethod_1()
		{
			List<GClass132> result = new List<GClass132>();
			try
			{
				new ManagementObjectSearcher(new WqlObjectQuery("SELECT * FROM Win32_DiskDrive")).Get();
				return result;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00038770 File Offset: 0x00036970
		public static void smethod_2()
		{
			try
			{
				if (!GClass131.bool_0)
				{
					GClass131.bool_0 = true;
					ManagementEventWatcher managementEventWatcher = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 OR EventType = 3"));
					managementEventWatcher.EventArrived += GClass131.<>c.<>c_0.method_0;
					managementEventWatcher.Start();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400056E RID: 1390
		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		// Token: 0x0400056F RID: 1391
		private static int int_0;

		// Token: 0x04000570 RID: 1392
		private static bool bool_0;

		// Token: 0x02000151 RID: 337
		[CompilerGenerated]
		private sealed class Class113
		{
			// Token: 0x06000919 RID: 2329 RVA: 0x00015D9F File Offset: 0x00013F9F
			internal void method_0(object sender, EventArgs e)
			{
				if (GClass131.smethod_1().Count > 0)
				{
					GClass131.Event_0 -= this.eventHandler_0;
					Action<GClass132> action = this.action_0;
					if (action == null)
					{
						return;
					}
					action(GClass131.smethod_1().Last<GClass132>());
				}
			}

			// Token: 0x04000571 RID: 1393
			public EventHandler eventHandler_0;

			// Token: 0x04000572 RID: 1394
			public Action<GClass132> action_0;
		}
	}
}

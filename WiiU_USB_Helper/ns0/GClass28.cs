using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using NusHelper;
using NusHelper.Server;

namespace ns0
{
	// Token: 0x0200005A RID: 90
	public static class GClass28
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600020C RID: 524 RVA: 0x000236EC File Offset: 0x000218EC
		// (remove) Token: 0x0600020D RID: 525 RVA: 0x00023720 File Offset: 0x00021920
		public static event EventHandler<Exception> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Exception> eventHandler = GClass28.eventHandler_0;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = (EventHandler<Exception>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref GClass28.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Exception> eventHandler = GClass28.eventHandler_0;
				EventHandler<Exception> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Exception> value2 = (EventHandler<Exception>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Exception>>(ref GClass28.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00011BE1 File Offset: 0x0000FDE1
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		public static List<GClass32> NewTitles { get; internal set; } = new List<GClass32>();

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00011BF7 File Offset: 0x0000FDF7
		public static List<GClass33> NewUpdates { get; internal set; } = new List<GClass33>();

		// Token: 0x06000212 RID: 530 RVA: 0x00011BFF File Offset: 0x0000FDFF
		internal static void smethod_0(Exception exception_0)
		{
			EventHandler<Exception> eventHandler = GClass28.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(null, exception_0);
		}

		// Token: 0x04000146 RID: 326
		public const string string_0 = "This software is brought to you, free of charge, by Hikari06 (aka Kazegaya). If you have paid any amount of money (except donations of course) to obtain it you have been SCAMMED. Please demand a refund immediately and report the seller. The only offical places to download this software are the post on gbatemp.net as well as the official site wiiuusbhelper.com.";

		// Token: 0x04000147 RID: 327
		public const string string_1 = "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/";

		// Token: 0x04000148 RID: 328
		public const string string_2 = "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/";

		// Token: 0x04000149 RID: 329
		public const string string_3 = "http://cdn.wiiuusbhelper.com/wiiu/download/";

		// Token: 0x0400014A RID: 330
		public static readonly Dictionary<TitleId, GClass32> dictionary_0 = new Dictionary<TitleId, GClass32>();

		// Token: 0x0400014B RID: 331
		public static List<GClass32> list_0 = new List<GClass32>();

		// Token: 0x0400014C RID: 332
		public static List<TitleId> list_1 = new List<TitleId>();

		// Token: 0x0400014D RID: 333
		public static List<string> list_2;

		// Token: 0x0400014E RID: 334
		public static bool bool_0 = false;

		// Token: 0x0400014F RID: 335
		public static bool bool_1 = true;

		// Token: 0x04000150 RID: 336
		public static string string_4;

		// Token: 0x04000151 RID: 337
		public static List<GClass32> list_3 = new List<GClass32>();

		// Token: 0x04000152 RID: 338
		public static GClass32 gclass32_0;

		// Token: 0x04000153 RID: 339
		public static bool bool_2 = false;

		// Token: 0x04000154 RID: 340
		public static IPAddress ipaddress_0 = IPAddress.Parse("95.183.50.10");

		// Token: 0x04000155 RID: 341
		[CompilerGenerated]
		private static EventHandler<Exception> eventHandler_0;

		// Token: 0x04000156 RID: 342
		[CompilerGenerated]
		private static List<GClass32> list_4;

		// Token: 0x04000157 RID: 343
		[CompilerGenerated]
		private static List<GClass33> list_5;

		// Token: 0x04000158 RID: 344
		internal static readonly Dictionary<TitleId, GClass80.GStruct4> dictionary_1 = new Dictionary<TitleId, GClass80.GStruct4>();

		// Token: 0x04000159 RID: 345
		internal static readonly Dictionary<TitleId, DbRow> dictionary_2 = new Dictionary<TitleId, DbRow>();

		// Token: 0x0400015A RID: 346
		internal static readonly Dictionary<TitleId, List<GClass80.GStruct5>> dictionary_3 = new Dictionary<TitleId, List<GClass80.GStruct5>>();

		// Token: 0x0400015B RID: 347
		internal static readonly List<GClass31> list_6 = new List<GClass31>();

		// Token: 0x0400015C RID: 348
		internal static GClass30 gclass30_0;

		// Token: 0x0400015D RID: 349
		internal static string[] string_5;
	}
}

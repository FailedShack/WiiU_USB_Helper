using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HelperChat;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x02000121 RID: 289
	internal static class Class89
	{
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000809 RID: 2057 RVA: 0x00033C14 File Offset: 0x00031E14
		// (remove) Token: 0x0600080A RID: 2058 RVA: 0x00033C48 File Offset: 0x00031E48
		public static event EventHandler<Message> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<Message> eventHandler = Class89.eventHandler_0;
				EventHandler<Message> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Message> value2 = (EventHandler<Message>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Message>>(ref Class89.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<Message> eventHandler = Class89.eventHandler_0;
				EventHandler<Message> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Message> value2 = (EventHandler<Message>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Message>>(ref Class89.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00015376 File Offset: 0x00013576
		public static void smethod_0()
		{
			Class89.smethod_7(null, null);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0001537F File Offset: 0x0001357F
		public static void smethod_1()
		{
			Class89.smethod_6("APP", "NONE", "!FRWL");
			Client client = Class89.client_0;
			if (client == null)
			{
				return;
			}
			client.DestroyClient();
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000153A4 File Offset: 0x000135A4
		public static string smethod_2()
		{
			if (!(Settings.Default.CloudUserName != ""))
			{
				return "Anon-" + Settings.Default.AppId.Substring(0, 4);
			}
			return Settings.Default.CloudUserName;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000153E2 File Offset: 0x000135E2
		public static void smethod_3(string string_0, string string_1)
		{
			if (string_1 != null)
			{
				Class89.smethod_6("APP", string_1, "!GBYE");
			}
			if (string_0 != null)
			{
				Class89.smethod_6("APP", string_0, "!HELO");
				Class89.smethod_5(string_0);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00015410 File Offset: 0x00013610
		public static bool smethod_4(string string_0)
		{
			return Class89.smethod_2() == string_0;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001541D File Offset: 0x0001361D
		public static void smethod_5(string string_0)
		{
			Class89.smethod_6("APP", string_0, "!CONT");
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00033C7C File Offset: 0x00031E7C
		public static void smethod_6(string string_0, string string_1, string string_2)
		{
			Class89.Class90 @class = new Class89.Class90();
			@class.string_0 = string_1;
			@class.string_1 = string_0;
			@class.string_2 = string_2;
			try
			{
				if (!string.IsNullOrEmpty(@class.string_1) && !string.IsNullOrEmpty(@class.string_0) && !string.IsNullOrEmpty(@class.string_2))
				{
					Class89.smethod_7(new Action<Client>(@class.method_0), new Action(Class89.<>c.<>c_0.method_0));
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00033D14 File Offset: 0x00031F14
		private static void smethod_7(Action<Client> action_0, Action action_1)
		{
			Class89.Class91 @class = new Class89.Class91();
			@class.action_0 = action_0;
			@class.action_1 = action_1;
			if (Class89.client_0 == null || Class89.client_0.Destroyed)
			{
				Task.Run(new Action(@class.method_0));
				return;
			}
			Class89.bool_0 = true;
			Action<Client> action_2 = @class.action_0;
			if (action_2 == null)
			{
				return;
			}
			action_2(Class89.client_0);
		}

		// Token: 0x040004AF RID: 1199
		[CompilerGenerated]
		private static EventHandler<Message> eventHandler_0;

		// Token: 0x040004B0 RID: 1200
		private static volatile bool bool_0 = false;

		// Token: 0x040004B1 RID: 1201
		private static Client client_0;

		// Token: 0x040004B2 RID: 1202
		private static object object_0 = new object();

		// Token: 0x02000122 RID: 290
		[CompilerGenerated]
		private sealed class Class90
		{
			// Token: 0x06000814 RID: 2068 RVA: 0x0001542F File Offset: 0x0001362F
			internal void method_0(Client client_0)
			{
				Class89.client_0.SendMessage(new Message(this.string_0, this.string_1, this.string_2));
			}

			// Token: 0x040004B3 RID: 1203
			public string string_0;

			// Token: 0x040004B4 RID: 1204
			public string string_1;

			// Token: 0x040004B5 RID: 1205
			public string string_2;
		}

		// Token: 0x02000124 RID: 292
		[CompilerGenerated]
		private sealed class Class91
		{
			// Token: 0x0600081A RID: 2074 RVA: 0x00033D78 File Offset: 0x00031F78
			internal void method_0()
			{
				object object_ = Class89.object_0;
				lock (object_)
				{
					Action<Client> action;
					if (Class89.client_0 != null && Class89.bool_0 && !Class89.client_0.Destroyed)
					{
						action = this.action_0;
						if (action == null)
						{
							return;
						}
					}
					else
					{
						try
						{
							TcpClient tcpClient = new TcpClient();
							tcpClient.Connect("chat.wiiuusbhelper.com", 9090);
							Class89.client_0 = new Client(tcpClient, false, null, null);
							Class89.client_0.MessageReceived += Class89.<>c.<>c_0.method_1;
							Class89.client_0.Connect();
							Class89.client_0.StartAsyncListen();
							Action<Client> action2 = this.action_0;
							if (action2 != null)
							{
								action2(Class89.client_0);
							}
							Class89.bool_0 = true;
							return;
						}
						catch (Exception)
						{
							Action action3 = this.action_1;
							if (action3 != null)
							{
								action3();
							}
							Class89.bool_0 = false;
							return;
						}
					}
					action(Class89.client_0);
				}
			}

			// Token: 0x040004B9 RID: 1209
			public Action<Client> action_0;

			// Token: 0x040004BA RID: 1210
			public Action action_1;
		}
	}
}

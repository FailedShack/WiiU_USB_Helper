using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using NusHelper;

namespace ns0
{
	// Token: 0x020000B7 RID: 183
	public sealed class GClass83
	{
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600049F RID: 1183 RVA: 0x00029C60 File Offset: 0x00027E60
		// (remove) Token: 0x060004A0 RID: 1184 RVA: 0x00029C98 File Offset: 0x00027E98
		public event EventHandler<GClass82> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass82> eventHandler = this.eventHandler_0;
				EventHandler<GClass82> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass82> value2 = (EventHandler<GClass82>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass82>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass82> eventHandler = this.eventHandler_0;
				EventHandler<GClass82> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass82> value2 = (EventHandler<GClass82>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass82>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00029CD0 File Offset: 0x00027ED0
		public static List<GClass32> smethod_0(GClass82 gclass82_0)
		{
			List<GClass32> list = new List<GClass32>();
			try
			{
				foreach (string text in new Class58(gclass82_0.IPAddress_0.ToString(), "", "").method_4("/storage_usb/usr/title/00050000"))
				{
					if (text.Length == 8)
					{
						TitleId key = new TitleId("00050000" + text);
						if (GClass28.dictionary_0.ContainsKey(key))
						{
							list.Add(GClass28.dictionary_0[key]);
						}
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00029D8C File Offset: 0x00027F8C
		public static int smethod_1(GClass82 gclass82_0, GClass30 gclass30_0)
		{
			int result;
			try
			{
				byte[] bytes = new Class58(gclass82_0.IPAddress_0.ToString(), "", "").method_7(string.Format("/storage_usb/usr/title/0005000e/{0}/meta/meta.xml", gclass30_0.TitleId.High.ToLower()));
				XmlDocument xmlDocument = new XmlDocument();
				string xml = Encoding.UTF8.GetString(bytes).Trim(new char[]
				{
					'﻿'
				});
				xmlDocument.LoadXml(xml);
				result = int.Parse(xmlDocument.SelectSingleNode("/menu[@type=\"complex\"]/title_version[@type=\"unsignedInt\"]/text()").Value);
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00013089 File Offset: 0x00011289
		public void method_0(bool bool_1)
		{
			GClass83.Class63 @class = new GClass83.Class63();
			@class.gclass83_0 = this;
			@class.bool_0 = bool_1;
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000130AF File Offset: 0x000112AF
		public void method_1()
		{
			this.bool_0 = false;
			this.udpClient_0.Close();
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000130C5 File Offset: 0x000112C5
		private void method_2(IPAddress ipaddress_0, int int_0)
		{
			EventHandler<GClass82> eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new GClass82
			{
				IPAddress_0 = ipaddress_0,
				TransferVersion = int_0
			});
		}

		// Token: 0x040002F7 RID: 759
		[CompilerGenerated]
		private EventHandler<GClass82> eventHandler_0;

		// Token: 0x040002F8 RID: 760
		private const string string_0 = "HELLO FROM WIIU!";

		// Token: 0x040002F9 RID: 761
		private readonly UdpClient udpClient_0 = new UdpClient(14521);

		// Token: 0x040002FA RID: 762
		private volatile bool bool_0 = true;

		// Token: 0x020000B8 RID: 184
		[CompilerGenerated]
		private sealed class Class63
		{
			// Token: 0x060004A7 RID: 1191 RVA: 0x00029E30 File Offset: 0x00028030
			internal void method_0()
			{
				IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 14521);
				while (this.gclass83_0.bool_0)
				{
					byte[] bytes;
					try
					{
						bytes = this.gclass83_0.udpClient_0.Receive(ref ipendPoint);
					}
					catch (Exception)
					{
						break;
					}
					string @string = Encoding.ASCII.GetString(bytes);
					if (@string.Contains("HELLO FROM WIIU!"))
					{
						int int_ = 0;
						if (@string.Length > 16)
						{
							string[] array = @string.Substring(16).Split(new char[]
							{
								';'
							});
							try
							{
								int_ = int.Parse(array[0]);
								goto IL_BC;
							}
							catch
							{
								goto IL_BC;
							}
							goto IL_8C;
						}
						goto IL_BC;
						IL_9E:
						if (!this.bool_0)
						{
							this.gclass83_0.bool_0 = false;
							continue;
						}
						continue;
						IL_BC:
						if (!this.gclass83_0.bool_0)
						{
							goto IL_9E;
						}
						IL_8C:
						this.gclass83_0.method_2(ipendPoint.Address, int_);
						goto IL_9E;
					}
				}
			}

			// Token: 0x040002FB RID: 763
			public GClass83 gclass83_0;

			// Token: 0x040002FC RID: 764
			public bool bool_0;
		}
	}
}

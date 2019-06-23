using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ns0
{
	// Token: 0x0200000E RID: 14
	public class GClass7
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00010A0A File Offset: 0x0000EC0A
		public GClass7(string string_4, string string_5, string string_6, string string_7 = "")
		{
			this.string_3 = string_5;
			this.string_1 = string_6;
			this.string_2 = string_7;
			this.string_0 = string_4;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000045 RID: 69 RVA: 0x0001B1E0 File Offset: 0x000193E0
		// (remove) Token: 0x06000046 RID: 70 RVA: 0x0001B218 File Offset: 0x00019418
		public event EventHandler<string> Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler<string> eventHandler = this.eventHandler_0;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<string> eventHandler = this.eventHandler_0;
				EventHandler<string> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<string>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00010A2F File Offset: 0x0000EC2F
		public void method_0()
		{
			Task.Run(new Action(this.method_1));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0001B250 File Offset: 0x00019450
		[CompilerGenerated]
		private void method_1()
		{
			try
			{
				string @string = Encoding.UTF8.GetString(new WebClient().UploadValues(string.Format("{0}/sendEmail.php", Class65.String_4), new NameValueCollection
				{
					{
						"from",
						this.string_0
					},
					{
						"subject",
						this.string_3
					},
					{
						"message",
						this.string_1
					},
					{
						"reply-to",
						this.string_2
					}
				}));
				this.eventHandler_0(this, @string);
			}
			catch (Exception ex)
			{
				EventHandler<string> eventHandler = this.eventHandler_0;
				if (eventHandler != null)
				{
					eventHandler(this, ex.ToString());
				}
			}
		}

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		private EventHandler<string> eventHandler_0;

		// Token: 0x0400000E RID: 14
		private string string_0;

		// Token: 0x0400000F RID: 15
		private string string_1;

		// Token: 0x04000010 RID: 16
		private string string_2;

		// Token: 0x04000011 RID: 17
		private string string_3;
	}
}

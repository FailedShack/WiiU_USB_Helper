using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x020000BA RID: 186
	public sealed class GClass86 : GClass85
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00013205 File Offset: 0x00011405
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x0001320D File Offset: 0x0001140D
		public Image Image { get; set; }

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060004BE RID: 1214 RVA: 0x0002A01C File Offset: 0x0002821C
		// (remove) Token: 0x060004BF RID: 1215 RVA: 0x0002A054 File Offset: 0x00028254
		public event EventHandler<GClass84> Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler<GClass84> eventHandler = this.eventHandler_2;
				EventHandler<GClass84> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass84> value2 = (EventHandler<GClass84>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass84>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<GClass84> eventHandler = this.eventHandler_2;
				EventHandler<GClass84> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<GClass84> value2 = (EventHandler<GClass84>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<GClass84>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00013216 File Offset: 0x00011416
		public void method_2(string string_0, TimeSpan timeSpan_0)
		{
			base.Event_1 += this.method_4;
			base.vmethod_0(string_0, timeSpan_0);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00013232 File Offset: 0x00011432
		public override void vmethod_0(string string_0, TimeSpan timeSpan_0)
		{
			base.Event_1 += this.method_3;
			base.vmethod_0(string_0, timeSpan_0);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0002A08C File Offset: 0x0002828C
		private void method_3(object object_0, GClass87 gclass87_0)
		{
			base.Event_1 -= this.method_3;
			try
			{
				this.Image = Image.FromStream(new MemoryStream(gclass87_0.byte_0));
			}
			catch (Exception)
			{
				GClass6.smethod_6(gclass87_0.string_0);
				return;
			}
			EventHandler<GClass84> eventHandler = this.eventHandler_2;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new GClass84(this.Image));
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0002A100 File Offset: 0x00028300
		private void method_4(object object_0, GClass87 gclass87_0)
		{
			base.Event_1 -= this.method_4;
			if (!gclass87_0.bool_0)
			{
				using (MemoryStream memoryStream = new MemoryStream(gclass87_0.byte_0))
				{
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						new Bitmap(Image.FromStream(memoryStream), new Size(48, 48)).Save(memoryStream2, ImageFormat.Png);
						File.WriteAllBytes(gclass87_0.string_0, memoryStream2.ToArray());
						this.Image = Image.FromStream(memoryStream2);
						goto IL_98;
					}
					catch (Exception)
					{
						GClass6.smethod_6(gclass87_0.string_0);
						return;
					}
				}
			}
			this.Image = Image.FromStream(new MemoryStream(gclass87_0.byte_0));
			IL_98:
			EventHandler<GClass84> eventHandler = this.eventHandler_2;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, new GClass84(this.Image));
		}

		// Token: 0x04000302 RID: 770
		[CompilerGenerated]
		private Image image_0;

		// Token: 0x04000303 RID: 771
		[CompilerGenerated]
		private EventHandler<GClass84> eventHandler_2;
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000140 RID: 320
	public partial class FrmFtpProgress : RadForm
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x000363D4 File Offset: 0x000345D4
		public FrmFtpProgress(GClass30 gclass30_0)
		{
			this.InitializeComponent();
			GClass32 gclass32_ = gclass30_0.GClass32_0;
			this.pctIcon.ImageLocation = gclass32_.IconUrl;
			this.title.Text = gclass30_0.Name;
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddEllipse(new Rectangle(0, 0, this.pctIcon.Width - 1, this.pctIcon.Height - 1));
				this.pctIcon.Region = new Region(graphicsPath);
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060008A7 RID: 2215 RVA: 0x00036470 File Offset: 0x00034670
		// (remove) Token: 0x060008A8 RID: 2216 RVA: 0x000364A8 File Offset: 0x000346A8
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

		// Token: 0x060008A9 RID: 2217 RVA: 0x000364E0 File Offset: 0x000346E0
		public void method_0()
		{
			try
			{
				this.bool_0 = true;
				base.BeginInvoke(new Action(base.Close));
			}
			catch
			{
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00036520 File Offset: 0x00034720
		public void method_1(TimeSpan timeSpan_0)
		{
			FrmFtpProgress.Class108 @class = new FrmFtpProgress.Class108();
			@class.frmFtpProgress_0 = this;
			@class.timeSpan_0 = timeSpan_0;
			base.BeginInvoke(new Action(@class.method_0));
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00036554 File Offset: 0x00034754
		public void method_2(int int_0, GStruct3 gstruct3_0)
		{
			FrmFtpProgress.Class109 @class = new FrmFtpProgress.Class109();
			@class.int_0 = int_0;
			@class.frmFtpProgress_0 = this;
			@class.gstruct3_0 = gstruct3_0;
			base.BeginInvoke(new Action(@class.method_0));
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000158C8 File Offset: 0x00013AC8
		private void FrmFtpProgress_Load(object sender, EventArgs e)
		{
			base.FormElement.TitleBar.CloseButton.Visibility = ElementVisibility.Collapsed;
			if (this.bool_0)
			{
				base.Close();
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000158F0 File Offset: 0x00013AF0
		private void radButton1_Click(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.eventHandler_0;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x04000516 RID: 1302
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04000517 RID: 1303
		private volatile bool bool_0;

		// Token: 0x02000141 RID: 321
		[CompilerGenerated]
		private sealed class Class108
		{
			// Token: 0x060008B1 RID: 2225 RVA: 0x00036B3C File Offset: 0x00034D3C
			internal void method_0()
			{
				this.frmFtpProgress_0.lblEta.Text = ((this.timeSpan_0.TotalSeconds > 0.0) ? string.Format("ETA : {0}h {1}m {2}s", this.timeSpan_0.Hours, this.timeSpan_0.Minutes, this.timeSpan_0.Seconds) : "ETA : Acquiring data...");
			}

			// Token: 0x04000521 RID: 1313
			public FrmFtpProgress frmFtpProgress_0;

			// Token: 0x04000522 RID: 1314
			public TimeSpan timeSpan_0;
		}

		// Token: 0x02000142 RID: 322
		[CompilerGenerated]
		private sealed class Class109
		{
			// Token: 0x060008B3 RID: 2227 RVA: 0x00036BB0 File Offset: 0x00034DB0
			internal void method_0()
			{
				if (this.int_0 > 100)
				{
					this.int_0 = 100;
				}
				this.frmFtpProgress_0.radProgressBar1.Value1 = this.int_0;
				this.frmFtpProgress_0.lblSpeed.Text = this.gstruct3_0.ToString();
			}

			// Token: 0x04000523 RID: 1315
			public int int_0;

			// Token: 0x04000524 RID: 1316
			public FrmFtpProgress frmFtpProgress_0;

			// Token: 0x04000525 RID: 1317
			public GStruct3 gstruct3_0;
		}
	}
}

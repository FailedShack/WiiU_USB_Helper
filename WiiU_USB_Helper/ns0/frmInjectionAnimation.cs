using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using WMPLib;

namespace ns0
{
	// Token: 0x02000198 RID: 408
	public partial class frmInjectionAnimation : Form
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0004444C File Offset: 0x0004264C
		public frmInjectionAnimation(GClass91 gclass91_1)
		{
			this.InitializeComponent();
			base.Region = Class95.smethod_6(this, 40);
			this.gclass91_0 = gclass91_1;
			try
			{
				this.int_3 = this.pctAarrow.Left;
				this.timer_1.Interval = 25;
				this.timer_1.Start();
				this.bitmap_0 = (Bitmap)Image.FromStream(new MemoryStream(new GClass78().method_2(string.Format("http://art.gametdb.com/wii/disc/{0}/{1}.png", (this.gclass91_0.ToInject.Region == "USA") ? "US" : "EN", this.gclass91_0.ToInject.ProductId))));
				this.bitmap_0.SetResolution(96f, 96f);
				this.timer_0.Interval = 30;
				this.timer_0.Start();
			}
			catch
			{
			}
			try
			{
				this.windowsMediaPlayer_0 = new WindowsMediaPlayerClass();
				this.windowsMediaPlayer_0.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(this, (UIntPtr)ldftn(method_3));
			}
			catch
			{
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00044590 File Offset: 0x00042790
		private void chkListenToMusic_ToggleStateChanged(object sender, StateChangedEventArgs e)
		{
			try
			{
				if (e.ToggleState == ToggleState.On)
				{
					this.method_2();
				}
				else
				{
					this.windowsMediaPlayer_0.controls.stop();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000445D4 File Offset: 0x000427D4
		private void frmInjectionAnimation_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.windowsMediaPlayer_0.controls.stop();
				this.windowsMediaPlayer_0.close();
			}
			catch
			{
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00044614 File Offset: 0x00042814
		private void frmInjectionAnimation_Shown(object sender, EventArgs e)
		{
			frmInjectionAnimation.Class146 @class = new frmInjectionAnimation.Class146();
			@class.frmInjectionAnimation_0 = this;
			this.gclass91_0.Event_0 += @class.method_0;
			this.gclass91_0.Event_1 += @class.method_2;
			@class.list_0 = new List<RadLabel>();
			foreach (object obj in base.Controls)
			{
				if (obj is RadLabel)
				{
					@class.list_0.Add(obj as RadLabel);
				}
			}
			@class.list_0.Reverse();
			string[] string_ = this.gclass91_0.String_3;
			for (int i = 0; i < 4; i++)
			{
				@class.list_0[i].Text = string.Format("Step {0}: {1}...", i + 1, string_[i]);
			}
			this.gclass91_0.Event_2 += @class.method_3;
			this.gclass91_0.vmethod_2();
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000181A3 File Offset: 0x000163A3
		private string method_0()
		{
			return new GClass78().method_6(string.Format("{0}/music", this.gclass91_0.ToInject.String_6));
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00044738 File Offset: 0x00042938
		private string method_1(string string_0)
		{
			HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
			htmlDocument.LoadHtml(new GClass78().method_6("https://downloads.khinsider.com" + string_0));
			return htmlDocument.DocumentNode.Descendants("audio").First<HtmlNode>().Attributes["src"].Value;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000181C9 File Offset: 0x000163C9
		private void method_2()
		{
			Task.Run(new Action(this.method_4));
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00044790 File Offset: 0x00042990
		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			if (this.bitmap_0 == null)
			{
				return;
			}
			Graphics graphics = e.Graphics;
			graphics.TranslateTransform(80f, 80f);
			graphics.RotateTransform((float)this.int_1);
			graphics.DrawImage(this.bitmap_0, new Point(-80, -80));
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000181DD File Offset: 0x000163DD
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_1 = (this.int_1 + this.int_2) % 360;
			this.pictureBox1.Refresh();
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000447E0 File Offset: 0x000429E0
		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (this.pctAarrow.Left - 1 < this.int_3 || this.pctAarrow.Left + 1 > this.int_3 + 8)
			{
				this.int_4 *= -1;
			}
			this.pctAarrow.Left += this.int_4;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00018222 File Offset: 0x00016422
		[CompilerGenerated]
		private void method_3(int int_5)
		{
			if (this.windowsMediaPlayer_0.playState == WMPPlayState.wmppsMediaEnded)
			{
				this.method_2();
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00044ED0 File Offset: 0x000430D0
		[CompilerGenerated]
		private void method_4()
		{
			try
			{
				this.windowsMediaPlayer_0.controls.stop();
				if (this.list_0 == null)
				{
					HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
					this.list_0 = new List<string>();
					htmlDocument.LoadHtml(new GClass78().method_6(this.method_0()));
					this.list_0.AddRange(htmlDocument.DocumentNode.Descendants("a").Where(new Func<HtmlNode, bool>(frmInjectionAnimation.<>c.<>c_0.method_0)).Select(new Func<HtmlNode, string>(frmInjectionAnimation.<>c.<>c_0.method_1)).ToArray<string>());
				}
				this.windowsMediaPlayer_0.settings.volume = 50;
				this.windowsMediaPlayer_0.URL = this.method_1(this.list_0[new Random().Next(this.list_0.Count)]);
				this.windowsMediaPlayer_0.controls.play();
			}
			catch
			{
			}
		}

		// Token: 0x040006DC RID: 1756
		private const int int_0 = 8;

		// Token: 0x040006DD RID: 1757
		private int int_1 = 2;

		// Token: 0x040006DE RID: 1758
		private int int_2 = 20;

		// Token: 0x040006DF RID: 1759
		private Bitmap bitmap_0;

		// Token: 0x040006E0 RID: 1760
		private GClass91 gclass91_0;

		// Token: 0x040006E1 RID: 1761
		private WindowsMediaPlayer windowsMediaPlayer_0;

		// Token: 0x040006E2 RID: 1762
		private List<string> list_0;

		// Token: 0x040006E3 RID: 1763
		private int int_3;

		// Token: 0x040006E4 RID: 1764
		private int int_4 = -1;

		// Token: 0x02000199 RID: 409
		[CompilerGenerated]
		private sealed class Class146
		{
			// Token: 0x06000B8E RID: 2958 RVA: 0x00018238 File Offset: 0x00016438
			internal void method_0(object sender, EventArgs e)
			{
				this.frmInjectionAnimation_0.Invoke(new MethodInvoker(this.method_1));
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x00044FF0 File Offset: 0x000431F0
			internal void method_1()
			{
				try
				{
					this.frmInjectionAnimation_0.Close();
				}
				catch
				{
				}
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x00045020 File Offset: 0x00043220
			internal void method_2(object object_0, Exception exception_0)
			{
				frmInjectionAnimation.Class147 @class = new frmInjectionAnimation.Class147();
				@class.class146_0 = this;
				@class.exception_0 = exception_0;
				this.frmInjectionAnimation_0.Invoke(new MethodInvoker(@class.method_0));
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x0004505C File Offset: 0x0004325C
			internal void method_3(object object_0, int int_0)
			{
				frmInjectionAnimation.Class148 @class = new frmInjectionAnimation.Class148();
				@class.class146_0 = this;
				@class.int_0 = int_0;
				this.frmInjectionAnimation_0.Invoke(new MethodInvoker(@class.method_0));
			}

			// Token: 0x040006EF RID: 1775
			public frmInjectionAnimation frmInjectionAnimation_0;

			// Token: 0x040006F0 RID: 1776
			public List<RadLabel> list_0;
		}

		// Token: 0x0200019A RID: 410
		[CompilerGenerated]
		private sealed class Class147
		{
			// Token: 0x06000B93 RID: 2963 RVA: 0x00045098 File Offset: 0x00043298
			internal void method_0()
			{
				try
				{
					RadMessageBox.Show("An error has occured.\n" + this.exception_0);
					this.class146_0.frmInjectionAnimation_0.Close();
				}
				catch
				{
				}
			}

			// Token: 0x040006F1 RID: 1777
			public Exception exception_0;

			// Token: 0x040006F2 RID: 1778
			public frmInjectionAnimation.Class146 class146_0;
		}

		// Token: 0x0200019B RID: 411
		[CompilerGenerated]
		private sealed class Class148
		{
			// Token: 0x06000B95 RID: 2965 RVA: 0x000450E0 File Offset: 0x000432E0
			internal void method_0()
			{
				switch (this.int_0)
				{
				case 0:
					this.class146_0.frmInjectionAnimation_0.int_2 = 5;
					break;
				case 1:
					this.class146_0.frmInjectionAnimation_0.int_2 = 20;
					break;
				case 2:
					this.class146_0.frmInjectionAnimation_0.int_2 = 35;
					break;
				case 3:
					this.class146_0.frmInjectionAnimation_0.int_2 = 10;
					break;
				}
				this.class146_0.frmInjectionAnimation_0.pctAarrow.Location = new Point(this.class146_0.frmInjectionAnimation_0.pctAarrow.Left, this.class146_0.list_0[this.int_0].Top + this.class146_0.list_0[this.int_0].Height / 2 - this.class146_0.frmInjectionAnimation_0.pctAarrow.Height / 2);
			}

			// Token: 0x040006F3 RID: 1779
			public int int_0;

			// Token: 0x040006F4 RID: 1780
			public frmInjectionAnimation.Class146 class146_0;
		}
	}
}

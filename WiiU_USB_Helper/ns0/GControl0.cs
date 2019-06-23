using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200014B RID: 331
	public class GControl0 : Control
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x00037DB8 File Offset: 0x00035FB8
		public GControl0()
		{
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.color_1 = this.color_0;
			this.method_4();
			this.method_9();
			this.method_6();
			this.timer_0 = new Timer();
			this.timer_0.Tick += this.timer_0_Tick;
			this.method_1();
			base.Resize += this.GControl0_Resize;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00015AB7 File Offset: 0x00013CB7
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00015ABF File Offset: 0x00013CBF
		[Category("LoadingCircle")]
		[Description("Gets or sets the number of spoke.")]
		public bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				this.method_1();
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00015ACE File Offset: 0x00013CCE
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00015AD6 File Offset: 0x00013CD6
		[Category("LoadingCircle")]
		[TypeConverter("System.Drawing.ColorConverter")]
		[Description("Sets the color of spoke.")]
		public Color Color_0
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
				this.method_4();
				base.Invalidate();
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00015AEB File Offset: 0x00013CEB
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00015B02 File Offset: 0x00013D02
		[Category("LoadingCircle")]
		[Description("Gets or sets the radius of inner circle.")]
		public int Int32_0
		{
			get
			{
				if (this.int_16 == 0)
				{
					this.int_16 = 8;
				}
				return this.int_16;
			}
			set
			{
				this.int_16 = value;
				base.Invalidate();
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00015B11 File Offset: 0x00013D11
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00015B29 File Offset: 0x00013D29
		[Category("LoadingCircle")]
		[Description("Gets or sets the number of spoke.")]
		public int Int32_1
		{
			get
			{
				if (this.int_17 == 0)
				{
					this.int_17 = 10;
				}
				return this.int_17;
			}
			set
			{
				if (this.int_17 != value && this.int_17 > 0)
				{
					this.int_17 = value;
					this.method_4();
					this.method_9();
					base.Invalidate();
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00015B56 File Offset: 0x00013D56
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00015B6E File Offset: 0x00013D6E
		[Description("Gets or sets the radius of outer circle.")]
		[Category("LoadingCircle")]
		public int Int32_2
		{
			get
			{
				if (this.int_18 == 0)
				{
					this.int_18 = 10;
				}
				return this.int_18;
			}
			set
			{
				this.int_18 = value;
				base.Invalidate();
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00015B7D File Offset: 0x00013D7D
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00015B8A File Offset: 0x00013D8A
		[Category("LoadingCircle")]
		[Description("Gets or sets the rotation speed. Higher the slower.")]
		public int Int32_3
		{
			get
			{
				return this.timer_0.Interval;
			}
			set
			{
				if (value > 0)
				{
					this.timer_0.Interval = value;
				}
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00015B9C File Offset: 0x00013D9C
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00015BB4 File Offset: 0x00013DB4
		[Description("Gets or sets the thickness of a spoke.")]
		[Category("LoadingCircle")]
		public int Int32_4
		{
			get
			{
				if (this.int_20 <= 0)
				{
					this.int_20 = 4;
				}
				return this.int_20;
			}
			set
			{
				this.int_20 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00015BC3 File Offset: 0x00013DC3
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00037E58 File Offset: 0x00036058
		[DefaultValue(typeof(GControl0.GEnum8), "Custom")]
		[Category("LoadingCircle")]
		[Description("Quickly sets the style to one of these presets, or a custom style if desired")]
		public GControl0.GEnum8 GEnum8_0
		{
			get
			{
				return this.genum8_0;
			}
			set
			{
				this.genum8_0 = value;
				switch (this.genum8_0)
				{
				case GControl0.GEnum8.const_0:
					this.method_0(12, 2, 5, 11);
					return;
				case GControl0.GEnum8.const_1:
					this.method_0(9, 4, 6, 7);
					return;
				case GControl0.GEnum8.const_2:
					this.method_0(24, 4, 8, 9);
					return;
				case GControl0.GEnum8.const_3:
					this.method_0(10, 4, 8, 10);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00015BCB File Offset: 0x00013DCB
		public override Size GetPreferredSize(Size proposedSize)
		{
			proposedSize.Width = (this.int_18 + this.int_20) * 2;
			return proposedSize;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00015BE4 File Offset: 0x00013DE4
		public void method_0(int int_21, int int_22, int int_23, int int_24)
		{
			this.Int32_1 = int_21;
			this.Int32_4 = int_22;
			this.Int32_0 = int_23;
			this.Int32_2 = int_24;
			base.Invalidate();
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00037EBC File Offset: 0x000360BC
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.int_17 > 0)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				int num = this.int_19;
				for (int i = 0; i < this.int_17; i++)
				{
					num %= this.int_17;
					this.method_3(e.Graphics, this.method_8(this.pointF_0, this.int_16, this.double_2[num]), this.method_8(this.pointF_0, this.int_18, this.double_2[num]), this.color_2[i], this.int_20);
					num++;
				}
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00015C09 File Offset: 0x00013E09
		private void method_1()
		{
			if (this.bool_0)
			{
				this.timer_0.Start();
			}
			else
			{
				this.timer_0.Stop();
				this.int_19 = 0;
			}
			this.method_4();
			base.Invalidate();
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00037F60 File Offset: 0x00036160
		private void timer_0_Tick(object sender, EventArgs e)
		{
			int num = this.int_19 + 1;
			this.int_19 = num;
			this.int_19 = num % this.int_17;
			base.Invalidate();
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00037F94 File Offset: 0x00036194
		private Color method_2(Color color_3, int int_21)
		{
			int r = (int)color_3.R;
			int g = (int)color_3.G;
			int b = (int)color_3.B;
			return Color.FromArgb(int_21, Math.Min(r, 255), Math.Min(g, 255), Math.Min(b, 255));
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00037FE0 File Offset: 0x000361E0
		private void method_3(Graphics graphics_0, PointF pointF_1, PointF pointF_2, Color color_3, int int_21)
		{
			using (Pen pen = new Pen(new SolidBrush(color_3), (float)int_21))
			{
				pen.StartCap = LineCap.Round;
				pen.EndCap = LineCap.Round;
				graphics_0.DrawLine(pen, pointF_1, pointF_2);
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00015C3E File Offset: 0x00013E3E
		private void method_4()
		{
			this.color_2 = this.method_5(this.color_1, this.Boolean_0, this.int_17);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00038030 File Offset: 0x00036230
		private Color[] method_5(Color color_3, bool bool_1, int int_21)
		{
			Color[] array = new Color[this.Int32_1];
			byte b = (byte)(255 / this.Int32_1);
			byte b2 = 0;
			for (int i = 0; i < this.Int32_1; i++)
			{
				if (bool_1)
				{
					if (i != 0 && i >= this.Int32_1 - int_21)
					{
						b2 += b;
						if (b2 > 255)
						{
							b2 = byte.MaxValue;
						}
						array[i] = this.method_2(color_3, (int)b2);
					}
					else
					{
						array[i] = color_3;
					}
				}
				else
				{
					array[i] = color_3;
				}
			}
			return array;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00015C5E File Offset: 0x00013E5E
		private void method_6()
		{
			this.pointF_0 = this.method_7(this);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00015C6D File Offset: 0x00013E6D
		private PointF method_7(Control control_0)
		{
			return new PointF((float)(control_0.Width / 2), (float)(control_0.Height / 2 - 1));
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000380B4 File Offset: 0x000362B4
		private PointF method_8(PointF pointF_1, int int_21, double double_3)
		{
			double num = 3.1415926535897931 * double_3 / 180.0;
			return new PointF(pointF_1.X + (float)int_21 * (float)Math.Cos(num), pointF_1.Y + (float)int_21 * (float)Math.Sin(num));
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00015C88 File Offset: 0x00013E88
		private void method_9()
		{
			this.double_2 = this.method_10(this.Int32_1);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00038100 File Offset: 0x00036300
		private double[] method_10(int int_21)
		{
			double[] array = new double[int_21];
			double num = 360.0 / (double)int_21;
			for (int i = 0; i < int_21; i++)
			{
				array[i] = ((i == 0) ? num : (array[i - 1] + num));
			}
			return array;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00015C9C File Offset: 0x00013E9C
		private void GControl0_Resize(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00015CA4 File Offset: 0x00013EA4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0400053C RID: 1340
		private const int int_0 = 8;

		// Token: 0x0400053D RID: 1341
		private const int int_1 = 10;

		// Token: 0x0400053E RID: 1342
		private const int int_2 = 10;

		// Token: 0x0400053F RID: 1343
		private const int int_3 = 4;

		// Token: 0x04000540 RID: 1344
		private const int int_4 = 6;

		// Token: 0x04000541 RID: 1345
		private const int int_5 = 9;

		// Token: 0x04000542 RID: 1346
		private const int int_6 = 7;

		// Token: 0x04000543 RID: 1347
		private const int int_7 = 4;

		// Token: 0x04000544 RID: 1348
		private const int int_8 = 8;

		// Token: 0x04000545 RID: 1349
		private const int int_9 = 24;

		// Token: 0x04000546 RID: 1350
		private const int int_10 = 9;

		// Token: 0x04000547 RID: 1351
		private const int int_11 = 4;

		// Token: 0x04000548 RID: 1352
		private const int int_12 = 5;

		// Token: 0x04000549 RID: 1353
		private const int int_13 = 12;

		// Token: 0x0400054A RID: 1354
		private const int int_14 = 11;

		// Token: 0x0400054B RID: 1355
		private const int int_15 = 2;

		// Token: 0x0400054C RID: 1356
		private const double double_0 = 360.0;

		// Token: 0x0400054D RID: 1357
		private const double double_1 = 180.0;

		// Token: 0x0400054E RID: 1358
		private readonly Color color_0 = Color.DarkGray;

		// Token: 0x0400054F RID: 1359
		private readonly Timer timer_0;

		// Token: 0x04000550 RID: 1360
		private double[] double_2;

		// Token: 0x04000551 RID: 1361
		private PointF pointF_0;

		// Token: 0x04000552 RID: 1362
		private Color color_1;

		// Token: 0x04000553 RID: 1363
		private Color[] color_2;

		// Token: 0x04000554 RID: 1364
		private int int_16;

		// Token: 0x04000555 RID: 1365
		private bool bool_0;

		// Token: 0x04000556 RID: 1366
		private int int_17;

		// Token: 0x04000557 RID: 1367
		private int int_18;

		// Token: 0x04000558 RID: 1368
		private int int_19;

		// Token: 0x04000559 RID: 1369
		private int int_20;

		// Token: 0x0400055A RID: 1370
		private GControl0.GEnum8 genum8_0;

		// Token: 0x0400055B RID: 1371
		private IContainer icontainer_0;

		// Token: 0x0200014C RID: 332
		public enum GEnum8
		{
			// Token: 0x0400055D RID: 1373
			const_0,
			// Token: 0x0400055E RID: 1374
			const_1,
			// Token: 0x0400055F RID: 1375
			const_2,
			// Token: 0x04000560 RID: 1376
			const_3
		}
	}
}

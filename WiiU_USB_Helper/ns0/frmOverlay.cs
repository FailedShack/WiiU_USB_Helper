using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x020001A4 RID: 420
	public partial class frmOverlay : GForm1
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x00046734 File Offset: 0x00044934
		public frmOverlay(IntPtr intptr_1, Image image_0, System.Drawing.Point point_0, System.Drawing.Point point_1) : base(100f, intptr_1, Color.Magenta, true)
		{
			frmOverlay.Class151 @class = new frmOverlay.Class151();
			@class.frmOverlay_0 = this;
			this.InitializeComponent();
			this.pBox.Image = image_0;
			this.pBox.SizeMode = PictureBoxSizeMode.AutoSize;
			point_0.X += this.pBox.Width / 2;
			point_0.Y += this.pBox.Height / 2;
			this.pBox.Location = point_0;
			@class.timer_0 = new Timer
			{
				Interval = 16
			};
			@class.vector_1 = new Vector((double)point_0.X, (double)point_0.Y);
			Vector vector = new Vector((double)point_1.X, (double)point_1.Y);
			@class.float_0 = 0.01f;
			@class.double_0 = (@class.vector_1 - vector).Length;
			@class.vector_0 = vector - @class.vector_1;
			@class.vector_0.Normalize();
			@class.timer_0.Tick += @class.method_0;
			@class.timer_0.Start();
		}

		// Token: 0x020001A5 RID: 421
		[CompilerGenerated]
		private sealed class Class151
		{
			// Token: 0x06000BBD RID: 3005 RVA: 0x00046964 File Offset: 0x00044B64
			internal void method_0(object sender, EventArgs e)
			{
				this.float_0 += 0.01f;
				Vector vector = this.vector_0 * 800.0 * (double)this.float_0;
				this.frmOverlay_0.pBox.Location = new System.Drawing.Point(this.frmOverlay_0.pBox.Location.X + (int)vector.X, this.frmOverlay_0.pBox.Location.Y + (int)vector.Y);
				if ((this.vector_1 - new Vector((double)this.frmOverlay_0.pBox.Location.X, (double)this.frmOverlay_0.pBox.Location.Y)).Length >= this.double_0)
				{
					this.timer_0.Stop();
					try
					{
						this.frmOverlay_0.Close();
					}
					catch
					{
					}
				}
			}

			// Token: 0x0400071B RID: 1819
			public float float_0;

			// Token: 0x0400071C RID: 1820
			public Vector vector_0;

			// Token: 0x0400071D RID: 1821
			public Vector vector_1;

			// Token: 0x0400071E RID: 1822
			public double double_0;

			// Token: 0x0400071F RID: 1823
			public Timer timer_0;

			// Token: 0x04000720 RID: 1824
			public frmOverlay frmOverlay_0;
		}
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000192 RID: 402
	public partial class frmHelpOverlay : GForm1
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x000431B8 File Offset: 0x000413B8
		public frmHelpOverlay(IntPtr intptr_1, Point? nullable_0, string string_0, int int_3) : base(0.85f, intptr_1, Color.Black, false)
		{
			this.InitializeComponent();
			this.label1.Text = string_0;
			if (nullable_0 == null)
			{
				this.pictArrow.Visible = false;
			}
			else
			{
				this.pictArrow.Location = new Point(nullable_0.Value.X - this.pictArrow.Width, nullable_0.Value.Y - this.pictArrow.Height / 2);
			}
			if (int_3 > 0)
			{
				frmHelpOverlay.Class143 @class = new frmHelpOverlay.Class143();
				@class.frmHelpOverlay_0 = this;
				@class.timer_0 = new Timer
				{
					Interval = int_3 * 1000
				};
				@class.timer_0.Tick += @class.method_0;
				@class.timer_0.Start();
			}
			this.point_0 = this.pictArrow.Location;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001564E File Offset: 0x0001384E
		private void btnGotcha_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000432B0 File Offset: 0x000414B0
		private void timer_1_Tick(object sender, EventArgs e)
		{
			this.pictArrow.Left += this.int_2 * 7;
			if (this.point_0.X - this.pictArrow.Left > 50 | this.point_0.X - this.pictArrow.Left < 0)
			{
				this.int_2 *= -1;
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001564E File Offset: 0x0001384E
		private void method_7(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040006BC RID: 1724
		private const int int_1 = 50;

		// Token: 0x040006BD RID: 1725
		private int int_2 = -1;

		// Token: 0x040006BE RID: 1726
		private Point point_0;

		// Token: 0x02000193 RID: 403
		[CompilerGenerated]
		private sealed class Class143
		{
			// Token: 0x06000B69 RID: 2921 RVA: 0x00018071 File Offset: 0x00016271
			internal void method_0(object sender, EventArgs e)
			{
				this.timer_0.Stop();
				this.timer_0.Dispose();
				this.frmHelpOverlay_0.Close();
			}

			// Token: 0x040006C4 RID: 1732
			public Timer timer_0;

			// Token: 0x040006C5 RID: 1733
			public frmHelpOverlay frmHelpOverlay_0;
		}
	}
}

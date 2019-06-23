using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace ns0
{
	// Token: 0x02000162 RID: 354
	public class GClass136 : GClass135
	{
		// Token: 0x060009A0 RID: 2464 RVA: 0x00016410 File Offset: 0x00014610
		public GClass136(Vector2 vector2_1, double double_0, double double_1, double double_2)
		{
			this.gclass134_0 = new GClass134(double_0, double_1, double_2);
			this.gclass134_0.Event_0 += this.method_1;
			this.vector2_0 = vector2_1;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0003A6C0 File Offset: 0x000388C0
		public override Matrix vmethod_0()
		{
			return Matrix.CreateTranslation(-this.vector2_0.X, -this.vector2_0.Y, 0f) * Matrix.CreateScale((float)this.gclass134_0.method_1()) * Matrix.CreateTranslation(this.vector2_0.X, this.vector2_0.Y, 0f);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00016445 File Offset: 0x00014645
		[CompilerGenerated]
		private void method_1(object sender, EventArgs e)
		{
			base.method_0();
		}

		// Token: 0x040005CC RID: 1484
		private GClass134 gclass134_0;

		// Token: 0x040005CD RID: 1485
		private Vector2 vector2_0;
	}
}

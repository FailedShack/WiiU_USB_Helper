using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ns0
{
	// Token: 0x02000164 RID: 356
	public class GClass143
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0001655E File Offset: 0x0001475E
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x00016566 File Offset: 0x00014766
		public GClass141 Cursor { get; set; }

		// Token: 0x060009C0 RID: 2496 RVA: 0x0001656F File Offset: 0x0001476F
		public void method_0(GClass140 gclass140_0)
		{
			this.list_0.Add(gclass140_0);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0003A978 File Offset: 0x00038B78
		public void method_1()
		{
			foreach (GClass140 gclass in this.list_0.ToArray())
			{
				if (this.rectangle_0.Intersects(gclass.Rectangle))
				{
					gclass.method_2();
				}
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0001657D File Offset: 0x0001477D
		public void method_2()
		{
			this.list_0.Clear();
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0003A9BC File Offset: 0x00038BBC
		public void method_3(GameTime gameTime_0, SpriteBatch spriteBatch_0)
		{
			foreach (GClass140 gclass in this.list_0.ToArray().Where(new Func<GClass140, bool>(GClass143.<>c.<>c_0.method_0)))
			{
				gclass.vmethod_0(gameTime_0, spriteBatch_0);
			}
			GClass141 cursor = this.Cursor;
			if (cursor == null)
			{
				return;
			}
			cursor.vmethod_0(gameTime_0, spriteBatch_0);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0001658A File Offset: 0x0001478A
		public void method_4(GClass140 gclass140_0)
		{
			if (this.list_0.Contains(gclass140_0))
			{
				this.list_0.Remove(gclass140_0);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000165A7 File Offset: 0x000147A7
		public void method_5(Rectangle rectangle_1)
		{
			this.rectangle_0 = rectangle_1;
			GClass141 cursor = this.Cursor;
			if (cursor == null)
			{
				return;
			}
			cursor.method_3(new Vector2((float)this.rectangle_0.X, (float)rectangle_1.Y), true, 2.5f);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0003AA44 File Offset: 0x00038C44
		public void method_6(GameTime gameTime_0)
		{
			GClass140[] array = this.list_0.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].vmethod_1(gameTime_0);
			}
			GClass141 cursor = this.Cursor;
			if (cursor == null)
			{
				return;
			}
			cursor.vmethod_1(gameTime_0);
		}

		// Token: 0x040005DE RID: 1502
		[CompilerGenerated]
		private GClass141 gclass141_0;

		// Token: 0x040005DF RID: 1503
		private Rectangle rectangle_0;

		// Token: 0x040005E0 RID: 1504
		private List<GClass140> list_0 = new List<GClass140>();
	}
}

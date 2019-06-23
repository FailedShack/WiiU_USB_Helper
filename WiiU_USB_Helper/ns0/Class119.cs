using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace ns0
{
	// Token: 0x02000161 RID: 353
	internal class Class119 : GClass138
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x000163A0 File Offset: 0x000145A0
		public Class119(Game game_0, GClass138 gclass138_1) : base(game_0)
		{
			this.gclass138_0 = gclass138_1;
			this.gclass138_0.method_3();
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000163BB File Offset: 0x000145BB
		public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
		{
			this.gclass143_0.method_3(gameTime_0, spriteBatch_0);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0003A65C File Offset: 0x0003885C
		public override void vmethod_1()
		{
			this.video_0 = this.contentManager_0.Load<Video>("splash");
			this.gclass142_0 = new GClass142(this.video_0);
			this.gclass142_0.Event_1 += this.method_9;
			this.gclass143_0.method_0(this.gclass142_0);
			base.vmethod_1();
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000163CA File Offset: 0x000145CA
		public override void vmethod_2()
		{
			this.gclass142_0.Dispose();
			Texture2D texture2D = this.texture2D_0;
			if (texture2D != null)
			{
				texture2D.Dispose();
			}
			base.vmethod_2();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000163EE File Offset: 0x000145EE
		public override void vmethod_3(GameTime gameTime_0)
		{
			this.gclass143_0.method_6(gameTime_0);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000163FC File Offset: 0x000145FC
		[CompilerGenerated]
		private void method_9(object sender, EventArgs e)
		{
			base.method_7();
			base.method_6(this.gclass138_0);
		}

		// Token: 0x040005C6 RID: 1478
		private GClass138 gclass138_0;

		// Token: 0x040005C7 RID: 1479
		private GClass142 gclass142_0;

		// Token: 0x040005C8 RID: 1480
		private bool bool_2;

		// Token: 0x040005C9 RID: 1481
		private Video video_0;

		// Token: 0x040005CA RID: 1482
		private double double_0;

		// Token: 0x040005CB RID: 1483
		private Texture2D texture2D_0;
	}
}

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ns0
{
	// Token: 0x02000166 RID: 358
	public class GClass141 : GClass140
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x000165F5 File Offset: 0x000147F5
		public GClass141(Texture2D texture2D_1, Rectangle rectangle_1) : base(texture2D_1, rectangle_1)
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0003AA88 File Offset: 0x00038C88
		public override void vmethod_0(GameTime gameTime_0, SpriteBatch spriteBatch_0)
		{
			if (base.Texture != null)
			{
				if (this.bool_0)
				{
					spriteBatch_0.Draw(base.Texture, new Rectangle((int)((double)base.Rectangle.X + 0.5 * (double)base.Rectangle.Width - 0.5 * ((double)base.Rectangle.Width * base.Scale)), (int)((double)base.Rectangle.Y + 0.5 * (double)base.Rectangle.Height - 0.5 * ((double)base.Rectangle.Height * base.Scale)), (int)((double)base.Rectangle.Width * base.Scale), (int)((double)base.Rectangle.Height * base.Scale)), this.color_0 * (float)base.Opacity);
					return;
				}
				spriteBatch_0.Draw(base.Texture, new Rectangle(base.Rectangle.X, base.Rectangle.Y, (int)((double)base.Rectangle.Width * base.Scale), (int)((double)base.Rectangle.Height * base.Scale)), this.color_0 * (float)base.Opacity);
			}
		}
	}
}

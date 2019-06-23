using System;
using System.Drawing;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000155 RID: 341
	public class GClass133 : SimpleListViewVisualItem
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00015F01 File Offset: 0x00014101
		protected override Type ThemeEffectiveType
		{
			get
			{
				return typeof(SimpleListViewVisualItem);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00038A34 File Offset: 0x00036C34
		protected override void CreateChildElements()
		{
			base.CreateChildElements();
			this.lightVisualElement_2 = new LightVisualElement
			{
				MinSize = new Size(120, 0),
				ShouldHandleMouseInput = false,
				TextAlignment = ContentAlignment.MiddleLeft,
				NotifyParentOnMouseInput = true,
				AutoSize = true
			};
			this.lightVisualElement_1 = new LightVisualElement
			{
				Image = Class121.arrowUP,
				AutoSize = false
			};
			this.lightVisualElement_0 = new LightVisualElement
			{
				Image = Class121.arrowDown,
				AutoSize = false
			};
			this.lightVisualElement_0.Size = new Size(30, 20);
			this.lightVisualElement_1.Size = new Size(30, 20);
			this.Children.Add(this.lightVisualElement_2);
			this.Children.Add(this.lightVisualElement_0);
			this.Children.Add(this.lightVisualElement_1);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00038B18 File Offset: 0x00036D18
		protected override void SynchronizeProperties()
		{
			base.SynchronizeProperties();
			this.Text = "";
			this.lightVisualElement_0.Location = new Point(base.Parent.Bounds.Width - 40, 0);
			this.lightVisualElement_1.Location = new Point(base.Parent.Bounds.Width - 65, 0);
			this.gclass30_0 = (GClass30)base.Data.Tag;
			if (this.gclass30_0 is GClass32)
			{
				this.lightVisualElement_2.Text = (this.gclass30_0 as GClass32).method_30();
			}
			else
			{
				this.lightVisualElement_2.Text = this.gclass30_0.ToString();
			}
			this.Image = base.Data.Image;
			this.lightVisualElement_2.Location = new Point(50, 0);
		}

		// Token: 0x04000577 RID: 1399
		public GClass30 gclass30_0;

		// Token: 0x04000578 RID: 1400
		public LightVisualElement lightVisualElement_0;

		// Token: 0x04000579 RID: 1401
		public LightVisualElement lightVisualElement_1;

		// Token: 0x0400057A RID: 1402
		private LightVisualElement lightVisualElement_2;
	}
}

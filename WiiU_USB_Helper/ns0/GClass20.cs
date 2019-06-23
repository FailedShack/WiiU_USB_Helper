using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Telerik.WinControls.UI;

namespace ns0
{
	// Token: 0x02000040 RID: 64
	public static class GClass20
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00020B58 File Offset: 0x0001ED58
		public static bool smethod_0(this RadListView radListView_0, GClass30 gclass30_0)
		{
			GClass20.Class27 @class = new GClass20.Class27();
			@class.gclass30_0 = gclass30_0;
			return radListView_0.Items.Any(new Func<ListViewDataItem, bool>(@class.method_0));
		}

		// Token: 0x02000041 RID: 65
		[CompilerGenerated]
		private sealed class Class27
		{
			// Token: 0x06000181 RID: 385 RVA: 0x000116D8 File Offset: 0x0000F8D8
			internal bool method_0(ListViewDataItem listViewDataItem_0)
			{
				return listViewDataItem_0.Value == this.gclass30_0;
			}

			// Token: 0x040000D1 RID: 209
			public GClass30 gclass30_0;
		}
	}
}

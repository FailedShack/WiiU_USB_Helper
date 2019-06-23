using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000AA RID: 170
	public sealed class GClass79
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x00012E96 File Offset: 0x00011096
		internal GClass79(GClass30 gclass30_1, int int_1)
		{
			this.Title = gclass30_1;
			this.Index = int_1;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00012EAC File Offset: 0x000110AC
		public GClass30 Title { get; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00012EB4 File Offset: 0x000110B4
		public int Index { get; }

		// Token: 0x040002AC RID: 684
		[CompilerGenerated]
		private readonly GClass30 gclass30_0;

		// Token: 0x040002AD RID: 685
		[CompilerGenerated]
		private readonly int int_0;
	}
}

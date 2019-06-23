using System;
using System.Collections.Generic;
using System.Linq;

namespace ns0
{
	// Token: 0x020000FD RID: 253
	public struct GStruct7
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x00014983 File Offset: 0x00012B83
		public GStruct7(GClass101 gclass101_1, List<int> list_1, bool bool_2, bool bool_3)
		{
			this.gclass101_0 = gclass101_1;
			this.list_0 = list_1;
			this.bool_1 = bool_2;
			this.bool_0 = bool_3;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000149A2 File Offset: 0x00012BA2
		public bool Boolean_0
		{
			get
			{
				return !this.bool_0 && !this.bool_1 && !this.list_0.Any<int>();
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000149C4 File Offset: 0x00012BC4
		public override string ToString()
		{
			return string.Format("File {0:x8} has {1} bad blocks", this.gclass101_0.ContentId, this.list_0.Count);
		}

		// Token: 0x040003E3 RID: 995
		public readonly List<int> list_0;

		// Token: 0x040003E4 RID: 996
		public readonly bool bool_0;

		// Token: 0x040003E5 RID: 997
		public readonly bool bool_1;

		// Token: 0x040003E6 RID: 998
		private readonly GClass101 gclass101_0;
	}
}

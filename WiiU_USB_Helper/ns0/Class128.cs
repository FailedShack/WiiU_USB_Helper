using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x02000172 RID: 370
	internal class Class128
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x00017928 File Offset: 0x00015B28
		public Class128(string string_1, ulong ulong_1, GClass30 gclass30_1, Action action_1)
		{
			this.Name = string_1;
			this.Size = ulong_1;
			this.action_0 = action_1;
			this.CorrespondingTitle = gclass30_1;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0001794D File Offset: 0x00015B4D
		public GClass30 CorrespondingTitle { get; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00017955 File Offset: 0x00015B55
		public string Name { get; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0001795D File Offset: 0x00015B5D
		public ulong Size { get; }

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00017965 File Offset: 0x00015B65
		public void method_0()
		{
			this.action_0();
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00017972 File Offset: 0x00015B72
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x04000609 RID: 1545
		[CompilerGenerated]
		private readonly GClass30 gclass30_0;

		// Token: 0x0400060A RID: 1546
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x0400060B RID: 1547
		[CompilerGenerated]
		private readonly ulong ulong_0;

		// Token: 0x0400060C RID: 1548
		private Action action_0;
	}
}

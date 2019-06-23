using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000B2 RID: 178
	public class GEventArgs0 : EventArgs
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00029C10 File Offset: 0x00027E10
		internal GEventArgs0(int int_3, int int_4, int int_5, TimeSpan timeSpan_3, TimeSpan timeSpan_4, TimeSpan timeSpan_5, GStruct3 gstruct3_1, GClass30 gclass30_1)
		{
			this.GameProgress = int_3;
			this.TotalProgress = int_4;
			this.GameEta = timeSpan_3;
			this.TotalEta = timeSpan_4;
			this.Speed = gstruct3_1;
			this.FileEta = timeSpan_5;
			this.FileProgress = int_5;
			this.Title = gclass30_1;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00012FD1 File Offset: 0x000111D1
		public TimeSpan FileEta { get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00012FD9 File Offset: 0x000111D9
		public int FileProgress { get; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00012FE1 File Offset: 0x000111E1
		public TimeSpan GameEta { get; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00012FE9 File Offset: 0x000111E9
		public int GameProgress { get; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00012FF1 File Offset: 0x000111F1
		public GStruct3 Speed { get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00012FF9 File Offset: 0x000111F9
		public GClass30 Title { get; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00013001 File Offset: 0x00011201
		public TimeSpan TotalEta { get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00013009 File Offset: 0x00011209
		public int TotalProgress { get; }

		// Token: 0x040002E0 RID: 736
		[CompilerGenerated]
		private readonly TimeSpan timeSpan_0;

		// Token: 0x040002E1 RID: 737
		[CompilerGenerated]
		private readonly int int_0;

		// Token: 0x040002E2 RID: 738
		[CompilerGenerated]
		private readonly TimeSpan timeSpan_1;

		// Token: 0x040002E3 RID: 739
		[CompilerGenerated]
		private readonly int int_1;

		// Token: 0x040002E4 RID: 740
		[CompilerGenerated]
		private readonly GStruct3 gstruct3_0;

		// Token: 0x040002E5 RID: 741
		[CompilerGenerated]
		private readonly GClass30 gclass30_0;

		// Token: 0x040002E6 RID: 742
		[CompilerGenerated]
		private readonly TimeSpan timeSpan_2;

		// Token: 0x040002E7 RID: 743
		[CompilerGenerated]
		private readonly int int_2;
	}
}

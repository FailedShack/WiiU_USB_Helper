using System;
using NusHelper;

namespace ns0
{
	// Token: 0x020000A6 RID: 166
	public struct GStruct3
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00012D50 File Offset: 0x00010F50
		public GStruct3(DataSize dataSize_0, TimeSpan timeSpan_0)
		{
			this.ulong_0 = (ulong)(dataSize_0.TotalBytes / timeSpan_0.TotalSeconds);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00012D6A File Offset: 0x00010F6A
		public GStruct3(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00012D73 File Offset: 0x00010F73
		public static DataSize smethod_0(GStruct3 gstruct3_0, TimeSpan timeSpan_0)
		{
			return new DataSize((ulong)(gstruct3_0.ulong_0 * timeSpan_0.TotalSeconds));
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00012D8B File Offset: 0x00010F8B
		public static TimeSpan smethod_1(DataSize dataSize_0, GStruct3 gstruct3_0)
		{
			if (gstruct3_0.ulong_0 == 0UL)
			{
				return new TimeSpan(0L);
			}
			return TimeSpan.FromSeconds(dataSize_0.TotalBytes / gstruct3_0.ulong_0);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00012DB2 File Offset: 0x00010FB2
		public GStruct3 method_0(GStruct3 gstruct3_0)
		{
			return new GStruct3((this.ulong_0 + gstruct3_0.ulong_0) / 2UL);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00012DC9 File Offset: 0x00010FC9
		public override string ToString()
		{
			return GStruct3.smethod_0(this, TimeSpan.FromSeconds(1.0)) + " /s";
		}

		// Token: 0x0400029A RID: 666
		public readonly ulong ulong_0;
	}
}

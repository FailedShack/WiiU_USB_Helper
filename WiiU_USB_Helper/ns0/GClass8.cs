using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200000F RID: 15
	public sealed class GClass8
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00010A43 File Offset: 0x0000EC43
		public GClass8(string string_3, string string_4, string string_5)
		{
			this.Email = string_3;
			this.Key = string_4;
			this.DonationDate = string_5;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00010A60 File Offset: 0x0000EC60
		public string DonationDate { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00010A68 File Offset: 0x0000EC68
		public string Email { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00010A70 File Offset: 0x0000EC70
		public string Key { get; }

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x04000013 RID: 19
		[CompilerGenerated]
		private readonly string string_1;

		// Token: 0x04000014 RID: 20
		[CompilerGenerated]
		private readonly string string_2;
	}
}

using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000097 RID: 151
	public class GClass72
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00012926 File Offset: 0x00010B26
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0001292E File Offset: 0x00010B2E
		[JsonProperty("everyone")]
		public int Everyone { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00012937 File Offset: 0x00010B37
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0001293F File Offset: 0x00010B3F
		[JsonProperty("gamers")]
		public int Gamers { get; set; }

		// Token: 0x0400023D RID: 573
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400023E RID: 574
		[CompilerGenerated]
		private int int_1;
	}
}

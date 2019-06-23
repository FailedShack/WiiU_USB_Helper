using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns0
{
	// Token: 0x02000114 RID: 276
	public class GClass110
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00014F43 File Offset: 0x00013143
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00014F4B File Offset: 0x0001314B
		[JsonProperty("content")]
		public List<GClass109> Content { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00014F54 File Offset: 0x00013154
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00014F5C File Offset: 0x0001315C
		[JsonProperty("length")]
		public int Length { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00014F65 File Offset: 0x00013165
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x00014F6D File Offset: 0x0001316D
		[JsonProperty("offset")]
		public int Offset { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00014F76 File Offset: 0x00013176
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00014F7E File Offset: 0x0001317E
		[JsonProperty("total")]
		public int Total { get; set; }

		// Token: 0x04000477 RID: 1143
		[CompilerGenerated]
		private List<GClass109> list_0;

		// Token: 0x04000478 RID: 1144
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000479 RID: 1145
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400047A RID: 1146
		[CompilerGenerated]
		private int int_2;
	}
}

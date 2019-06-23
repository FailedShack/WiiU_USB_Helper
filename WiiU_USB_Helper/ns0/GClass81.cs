using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x020000B5 RID: 181
	public class GClass81
	{
		// Token: 0x06000495 RID: 1173 RVA: 0x00013011 File Offset: 0x00011211
		public GClass81(string string_1, bool bool_1, GEnum5 genum5_1)
		{
			this.Message = string_1;
			this.Error = bool_1;
			this.Type = genum5_1;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001302E File Offset: 0x0001122E
		public bool Error { get; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00013036 File Offset: 0x00011236
		public string Message { get; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001303E File Offset: 0x0001123E
		public GEnum5 Type { get; }

		// Token: 0x040002F2 RID: 754
		[CompilerGenerated]
		private readonly bool bool_0;

		// Token: 0x040002F3 RID: 755
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x040002F4 RID: 756
		[CompilerGenerated]
		private readonly GEnum5 genum5_0;
	}
}

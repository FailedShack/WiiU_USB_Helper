using System;
using System.Runtime.CompilerServices;
using NusHelper;

namespace ns0
{
	// Token: 0x0200010A RID: 266
	public abstract class GClass101
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00014BC0 File Offset: 0x00012DC0
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00014BC8 File Offset: 0x00012DC8
		public uint ContentId { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00032CAC File Offset: 0x00030EAC
		public string String_0
		{
			get
			{
				return this.ContentId.ToString("x8");
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000735 RID: 1845
		// (set) Token: 0x06000736 RID: 1846
		public abstract byte[] Hash { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00014BD1 File Offset: 0x00012DD1
		public bool Boolean_0
		{
			get
			{
				return (this.ushort_1 & 2) > 0;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00014BDE File Offset: 0x00012DDE
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00014BE6 File Offset: 0x00012DE6
		public ushort Index { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00014BEF File Offset: 0x00012DEF
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00014BF7 File Offset: 0x00012DF7
		public DataSize Size { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00014C00 File Offset: 0x00012E00
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00014C08 File Offset: 0x00012E08
		public GEnum6 GEnum6_0
		{
			get
			{
				return (GEnum6)this.ushort_1;
			}
			set
			{
				this.ushort_1 = (ushort)value;
			}
		}

		// Token: 0x0400043A RID: 1082
		[CompilerGenerated]
		private uint uint_0;

		// Token: 0x0400043B RID: 1083
		[CompilerGenerated]
		private ushort ushort_0;

		// Token: 0x0400043C RID: 1084
		[CompilerGenerated]
		private DataSize dataSize_0;

		// Token: 0x0400043D RID: 1085
		protected ushort ushort_1;
	}
}

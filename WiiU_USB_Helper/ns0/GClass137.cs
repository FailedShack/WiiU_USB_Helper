using System;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200015D RID: 349
	public class GClass137
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x00016129 File Offset: 0x00014329
		public GClass137(GClass134 gclass134_1, string string_1)
		{
			if (gclass134_1 == null)
			{
				throw new ArgumentException("animator cannot be null");
			}
			if (string.IsNullOrEmpty(string_1))
			{
				throw new ArgumentException("property cannot be null");
			}
			this.gclass134_0 = gclass134_1;
			this.string_0 = string_1;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00016160 File Offset: 0x00014360
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00016168 File Offset: 0x00014368
		public object Target { get; set; }

		// Token: 0x06000967 RID: 2407 RVA: 0x00016171 File Offset: 0x00014371
		public void method_0()
		{
			this.gclass134_0.method_0();
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001617E File Offset: 0x0001437E
		public void method_1()
		{
			if (this.Target == null)
			{
				return;
			}
			this.Target.GetType().GetProperty(this.string_0).SetValue(this.Target, this.gclass134_0.method_1());
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000161BA File Offset: 0x000143BA
		public void method_2()
		{
			this.gclass134_0.method_3();
		}

		// Token: 0x040005AF RID: 1455
		[CompilerGenerated]
		private object object_0;

		// Token: 0x040005B0 RID: 1456
		private GClass134 gclass134_0;

		// Token: 0x040005B1 RID: 1457
		private string string_0;
	}
}

using System;
using System.IO;
using NusHelper;

namespace ns0
{
	// Token: 0x02000070 RID: 112
	public class GClass33 : GClass30
	{
		// Token: 0x060002BD RID: 701 RVA: 0x000122B3 File Offset: 0x000104B3
		public GClass33(string string_7, TitleId titleId_1, string string_8, byte[] byte_2, DataSize dataSize_1, string string_9, string string_10, GEnum3 genum3_1) : base(string_7, titleId_1, string_8, byte_2, dataSize_1, string_10, genum3_1)
		{
			base.Version = string_9;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000122CE File Offset: 0x000104CE
		public override string String_6
		{
			get
			{
				return base.String_6 + " (UPDATE)";
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000263F4 File Offset: 0x000245F4
		public override string OutputPath
		{
			get
			{
				switch (base.System)
				{
				case GEnum3.const_0:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA_3DS",
						base.Region,
						"UPDATES",
						base.String_5 + string.Format(" (v{0})", base.Version)
					});
				case GEnum3.const_1:
					return Path.Combine(new string[]
					{
						base.OutputPath,
						"DATA",
						base.Region,
						"UPDATES",
						base.String_5 + string.Format(" (v{0})", base.Version)
					});
				case GEnum3.const_2:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
				}
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000122E0 File Offset: 0x000104E0
		public override string ToString()
		{
			return string.Format("{0} (UPDATE DATA) (v{1}) ({2}) ({3})", new object[]
			{
				base.Name,
				base.Version,
				base.Size,
				base.Region
			});
		}
	}
}

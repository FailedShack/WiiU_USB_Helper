using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000F6 RID: 246
	internal class Project64 : GClass95
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x00014855 File Offset: 0x00012A55
		public Project64(GClass30 title, bool forceUpdate) : base(title, "Project64", "http://www.pj64-emu.com/", forceUpdate, false)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00014224 File Offset: 0x00012424
		public override bool DlcIsInstalled()
		{
			return false;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001486A File Offset: 0x00012A6A
		public override string GetExecutable()
		{
			return Path.Combine(base.String_4, "Project64.exe");
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00014224 File Offset: 0x00012424
		public override bool UpdateIsInstalled()
		{
			return false;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000314E0 File Offset: 0x0002F6E0
		public override string GetRom()
		{
			string path = Path.Combine(this.CurrentGamePath, "content", "rom");
			if (!Directory.Exists(path))
			{
				return "";
			}
			string[] files = Directory.GetFiles(path);
			if (files.Any<string>())
			{
				return files[0];
			}
			return "";
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0003152C File Offset: 0x0002F72C
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			if (!base.Boolean_2 && this.gclass30_0.System == GEnum3.const_1)
			{
				IEnumerable<GClass12> ienumerable_ = from x in this.gclass30_0.method_15().Files
				where x.string_0.Contains("rom")
				select x;
				this.gclass30_0.method_16(base.String_5, true, directDownload, ienumerable_, true);
			}
			base.method_12(true);
		}
	}
}

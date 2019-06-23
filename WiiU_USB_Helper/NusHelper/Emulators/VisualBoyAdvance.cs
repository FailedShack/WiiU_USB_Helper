using System;
using System.IO;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000E8 RID: 232
	internal class VisualBoyAdvance : GClass95
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x0001420F File Offset: 0x0001240F
		public VisualBoyAdvance(GClass30 title, bool forceUpdate) : base(title, "VisualBoyAdvance", "https://sourceforge.net/projects/vba/", forceUpdate, false)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00014224 File Offset: 0x00012424
		public override bool DlcIsInstalled()
		{
			return false;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00014227 File Offset: 0x00012427
		public override string GetExecutable()
		{
			return Path.Combine(base.String_4, "VisualBoyAdvance.exe");
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00014224 File Offset: 0x00012424
		public override bool UpdateIsInstalled()
		{
			return false;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002F4A0 File Offset: 0x0002D6A0
		public override string GetRom()
		{
			if (this.gclass30_0.Platform != Platform.GameBoy_Color)
			{
				if (this.gclass30_0.Platform != Platform.GameBoy)
				{
					if (this.gclass30_0.Platform == Platform.GameBoy_Advance)
					{
						return Path.Combine(this.CurrentGamePath, "rom.gba");
					}
					throw new Exception("This type of game is not compatible with this emulator!");
				}
			}
			return Path.Combine(this.CurrentGamePath, "rom.gb");
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002F50C File Offset: 0x0002D70C
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			Class65.smethod_10();
			if (base.Boolean_2)
			{
				return;
			}
			if (this.gclass30_0.Platform != Platform.GameBoy_Color && this.gclass30_0.Platform != Platform.GameBoy)
			{
				return;
			}
			this.gclass30_0.method_4(this.CurrentGamePath, true, false, false);
			File.Move(new DirectoryInfo(Path.Combine(this.CurrentGamePath, "romfs", "rom")).GetFiles()[0].FullName, this.GetRom());
			base.method_12(true);
		}
	}
}

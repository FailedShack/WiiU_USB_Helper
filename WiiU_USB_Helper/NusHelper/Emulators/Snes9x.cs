using System;
using System.IO;
using Alphaleonis.Win32.Filesystem;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000F8 RID: 248
	internal class Snes9x : GClass95
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x0001489A File Offset: 0x00012A9A
		public Snes9x(GClass30 title, bool forceUpdate) : base(title, "Snes9x", "http://www.snes9x.com/", forceUpdate, false)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00014224 File Offset: 0x00012424
		public override bool DlcIsInstalled()
		{
			return false;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000148C6 File Offset: 0x00012AC6
		public override string GetArguments()
		{
			return base.GetArguments() + (base.FullScreen ? " -f" : "");
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000148E7 File Offset: 0x00012AE7
		public override string GetExecutable()
		{
			return System.IO.Path.Combine(base.String_4, "snes9x.exe");
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00014224 File Offset: 0x00012424
		public override bool UpdateIsInstalled()
		{
			return false;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000148F9 File Offset: 0x00012AF9
		public override string GetRom()
		{
			return System.IO.Path.Combine(base.String_5, this.gclass30_0.method_12(), "rom.sfc");
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000315A4 File Offset: 0x0002F7A4
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			if (!Alphaleonis.Win32.Filesystem.File.Exists(this.GetRom()))
			{
				base.method_9(directDownload);
				using (BinaryReader binaryReader = new BinaryReader(Alphaleonis.Win32.Filesystem.File.Open(base.method_10(), FileMode.Open)))
				{
					using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.Create(this.GetRom()))
					{
						GClass95.smethod_0(binaryReader.BaseStream, this._titleTag);
						binaryReader.BaseStream.Seek(-22L, SeekOrigin.Current);
						byte[] array = new byte[2];
						binaryReader.Read(array, 0, 2);
						Array.Reverse(array);
						int num = (int)((long)(BitConverter.ToUInt16(array, 0) * 256));
						binaryReader.BaseStream.Seek(32L, SeekOrigin.Current);
						byte[] array2 = new byte[num];
						binaryReader.Read(array2, 0, array2.Length);
						fileStream.Write(array2, 0, array2.Length);
					}
				}
			}
			base.method_12(true);
		}

		// Token: 0x040003D9 RID: 985
		private readonly byte[] _titleTag = new byte[]
		{
			87,
			85,
			80,
			45
		};
	}
}

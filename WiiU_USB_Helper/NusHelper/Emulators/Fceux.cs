using System;
using System.IO;
using Alphaleonis.Win32.Filesystem;
using ns0;

namespace NusHelper.Emulators
{
	// Token: 0x020000F5 RID: 245
	internal class Fceux : GClass95
	{
		// Token: 0x060006CE RID: 1742 RVA: 0x00014805 File Offset: 0x00012A05
		public Fceux(GClass30 title, bool forceUpdate) : base(title, "Fceux", "http://www.fceux.com/", forceUpdate, false)
		{
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00014224 File Offset: 0x00012424
		public override bool DlcIsInstalled()
		{
			return false;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00014831 File Offset: 0x00012A31
		public override string GetExecutable()
		{
			return System.IO.Path.Combine(base.String_4, "fceux.exe");
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00014224 File Offset: 0x00012424
		public override bool UpdateIsInstalled()
		{
			return false;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00014843 File Offset: 0x00012A43
		public override string GetRom()
		{
			return System.IO.Path.Combine(this.CurrentGamePath, "rom.nes");
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000313CC File Offset: 0x0002F5CC
		protected override void PrepareRomIfNecessary(bool directDownload)
		{
			if (!Alphaleonis.Win32.Filesystem.File.Exists(this.GetRom()))
			{
				base.method_9(directDownload);
				using (BinaryReader binaryReader = new BinaryReader(Alphaleonis.Win32.Filesystem.File.Open(base.method_10(), FileMode.Open)))
				{
					using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.Create(this.GetRom()))
					{
						GClass95.smethod_0(binaryReader.BaseStream, this._nesTag);
						binaryReader.BaseStream.Seek(-18L, SeekOrigin.Current);
						byte[] array = new byte[2];
						binaryReader.Read(array, 0, 2);
						Array.Reverse(array);
						long num = (long)(BitConverter.ToUInt16(array, 0) * 256 + 12);
						binaryReader.BaseStream.Seek(20L, SeekOrigin.Current);
						fileStream.Write(new byte[]
						{
							78,
							69,
							83,
							26
						}, 0, 4);
						byte[] array2 = new byte[num];
						binaryReader.Read(array2, 0, array2.Length);
						fileStream.Write(array2, 0, array2.Length);
					}
				}
			}
			base.method_12(true);
		}

		// Token: 0x040003D6 RID: 982
		private readonly byte[] _nesTag = new byte[]
		{
			78,
			69,
			83
		};
	}
}

using System;
using System.IO;
using System.IO.Compression;

namespace ns0
{
	// Token: 0x02000049 RID: 73
	public static class GClass24
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x0002245C File Offset: 0x0002065C
		public static void smethod_0(this ZipArchive zipArchive_0, string string_0, bool bool_0)
		{
			if (!bool_0)
			{
				zipArchive_0.ExtractToDirectory(string_0);
				return;
			}
			foreach (ZipArchiveEntry zipArchiveEntry in zipArchive_0.Entries)
			{
				try
				{
					Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(string_0, zipArchiveEntry.FullName)));
				}
				catch
				{
				}
			}
			foreach (ZipArchiveEntry zipArchiveEntry2 in zipArchive_0.Entries)
			{
				string text = Path.Combine(string_0, zipArchiveEntry2.FullName);
				if (zipArchiveEntry2.Name == "")
				{
					Directory.CreateDirectory(Path.GetDirectoryName(text));
				}
				else
				{
					zipArchiveEntry2.ExtractToFile(text, true);
				}
			}
		}
	}
}

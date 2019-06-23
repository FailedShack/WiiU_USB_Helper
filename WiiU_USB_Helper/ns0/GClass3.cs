using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ns0
{
	// Token: 0x02000007 RID: 7
	public static class GClass3
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00010866 File Offset: 0x0000EA66
		public static void smethod_0(GClass30 gclass30_0)
		{
			if (!GClass3.list_0.Contains(gclass30_0.TitleId.IdRaw))
			{
				GClass3.list_0.Add(gclass30_0.TitleId.IdRaw);
			}
			GClass3.smethod_2();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00010899 File Offset: 0x0000EA99
		public static void smethod_1(GClass30 gclass30_0)
		{
			if (GClass3.list_0.Contains(gclass30_0.TitleId.IdRaw))
			{
				GClass3.list_0.Remove(gclass30_0.TitleId.IdRaw);
			}
			GClass3.smethod_2();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0001A700 File Offset: 0x00018900
		private static void smethod_2()
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using (FileStream fileStream = File.Create(Path.Combine(GClass88.CachePath, GClass3.string_0)))
			{
				binaryFormatter.Serialize(fileStream, GClass3.list_0);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000108CD File Offset: 0x0000EACD
		public static bool smethod_3(GClass30 gclass30_0)
		{
			return GClass3.list_0.Contains(gclass30_0.TitleId.IdRaw);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0001A750 File Offset: 0x00018950
		internal static void smethod_4()
		{
			try
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				using (FileStream fileStream = File.Open(Path.Combine(GClass88.CachePath, GClass3.string_0), FileMode.Open))
				{
					GClass3.list_0 = (List<string>)binaryFormatter.Deserialize(fileStream);
				}
			}
			catch
			{
				GClass3.list_0 = new List<string>();
			}
		}

		// Token: 0x04000004 RID: 4
		private static readonly string string_0 = "emuExceptions";

		// Token: 0x04000005 RID: 5
		private static List<string> list_0 = new List<string>();
	}
}

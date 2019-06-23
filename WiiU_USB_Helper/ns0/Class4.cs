using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace ns0
{
	// Token: 0x02000016 RID: 22
	internal static class Class4
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0001B540 File Offset: 0x00019740
		public static void smethod_0(GClass30 gclass30_0, IPAddress ipaddress_0, string string_0)
		{
			if (gclass30_0.TitleId.IdType != GEnum1.const_1)
			{
				throw new Exception("You can only backup game saves!");
			}
			if (gclass30_0.System != GEnum3.const_1)
			{
				throw new Exception("Save backup is only compatible with Wii U Games");
			}
			Class58 @class = new Class58(ipaddress_0.ToString(), "anonymous", "");
			if (!@class.method_4("/storage_usb/usr/save/00050000/").Contains(gclass30_0.TitleId.High.ToLower()))
			{
				throw new GException0();
			}
			@class.method_5("/storage_usb/usr/save/00050000/" + gclass30_0.TitleId.High.ToLower() + "/", string_0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0001B5DC File Offset: 0x000197DC
		public static void smethod_1(GClass30 gclass30_0, IPAddress ipaddress_0, string string_0)
		{
			if (gclass30_0.TitleId.IdType != GEnum1.const_1)
			{
				throw new Exception("You can only backup game saves!");
			}
			if (gclass30_0.System != GEnum3.const_1)
			{
				throw new Exception("Save backup is only compatible with Wii U Games");
			}
			Class58 @class = new Class58(ipaddress_0.ToString(), "anonymous", "");
			using (FileStream fileStream = File.Open(string_0, FileMode.Open))
			{
				using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read))
				{
					@class.method_15("/storage_usb/usr/save/00050000/" + gclass30_0.TitleId.High.ToLower() + "/", zipArchive);
				}
			}
		}
	}
}

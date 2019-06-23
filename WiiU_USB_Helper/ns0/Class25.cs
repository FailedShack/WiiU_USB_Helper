using System;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NusHelper.Emulators;

namespace ns0
{
	// Token: 0x0200003E RID: 62
	internal static class Class25
	{
		// Token: 0x0600017C RID: 380 RVA: 0x000116B9 File Offset: 0x0000F8B9
		public static void smethod_0(GClass32 gclass32_0)
		{
			Class25.Class26 @class = new Class25.Class26();
			@class.gclass32_0 = gclass32_0;
			Task.Run(new Action(@class.method_0));
		}

		// Token: 0x0200003F RID: 63
		[CompilerGenerated]
		private sealed class Class26
		{
			// Token: 0x0600017E RID: 382 RVA: 0x000209D8 File Offset: 0x0001EBD8
			internal void method_0()
			{
				try
				{
					Cemu cemu;
					if ((cemu = (this.gclass32_0.method_14(false) as Cemu)) != null)
					{
						string text = Path.Combine(cemu.ShaderTransferDir, cemu.GetId() + ".bin");
						if (File.Exists(text))
						{
							long length = new FileInfo(text).Length;
							string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
							if (GClass6.smethod_20(string.Format("{0}/shaders/proposal.php", Class65.String_1), new NameValueCollection
							{
								{
									"id",
									fileNameWithoutExtension
								},
								{
									"size",
									length.ToString()
								}
							}) == "INTERESTED")
							{
								string text2 = Path.GetTempPath() + fileNameWithoutExtension + ".zip";
								GClass6.smethod_6(text2);
								using (FileStream fileStream = File.Create(text2))
								{
									using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Create))
									{
										zipArchive.CreateEntryFromFile(text, fileNameWithoutExtension + ".bin");
									}
								}
								Encoding.UTF8.GetString(new WebClient().UploadFile(string.Format("{0}/shaders/submit.php", Class65.String_1), text2));
								GClass6.smethod_5(text2);
							}
						}
					}
				}
				catch
				{
				}
			}

			// Token: 0x040000D0 RID: 208
			public GClass32 gclass32_0;
		}
	}
}

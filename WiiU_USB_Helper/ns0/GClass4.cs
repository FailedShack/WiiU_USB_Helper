using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Alphaleonis.Win32.Filesystem;
using Telerik.WinControls.Zip;

namespace ns0
{
	// Token: 0x02000008 RID: 8
	public static class GClass4
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0001A7C4 File Offset: 0x000189C4
		public static void smethod_0(string string_0, string string_1, string string_2)
		{
			GClass6.smethod_5(string_2);
			Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string_2);
			GClass4.smethod_3(string_0);
			using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(string_1))
			{
				using (ZipArchive zipArchive = new ZipArchive(fileStream, ZipArchiveMode.Read, false, null, null, GClass4.encryptionSettings_0))
				{
					string[] array = null;
					using (ZipArchiveEntry entry = zipArchive.GetEntry("usb_helper_fst"))
					{
						using (StreamReader streamReader = new StreamReader(entry.Open()))
						{
							array = streamReader.ReadToEnd().Split(new string[]
							{
								Environment.NewLine
							}, StringSplitOptions.RemoveEmptyEntries);
						}
					}
					byte[] array2 = new byte[1024];
					string[] array3 = array;
					for (int i = 0; i < array3.Length; i++)
					{
						string[] array4 = array3[i].Split(new char[]
						{
							':'
						});
						string a = array4[0];
						string text = array4[1];
						string text2 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
						{
							string_2,
							text
						});
						string text3 = Alphaleonis.Win32.Filesystem.Path.Combine(new string[]
						{
							string_0,
							text
						});
						Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(text2);
						using (MD5.Create())
						{
							if (!(a == "CRT"))
							{
								if (!(a == "COP"))
								{
									if (a == "DIR")
									{
										Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(text2);
									}
								}
								else
								{
									GClass4.smethod_1(text3, array4[2]);
									Alphaleonis.Win32.Filesystem.File.Copy(text3, text2, true);
								}
							}
							else
							{
								using (FileStream fileStream2 = Alphaleonis.Win32.Filesystem.File.Create(text2))
								{
									using (ZipArchiveEntry entry2 = zipArchive.GetEntry(text))
									{
										using (Stream stream = entry2.Open())
										{
											int num;
											do
											{
												num = stream.Read(array2, 0, array2.Length);
												fileStream2.Write(array2, 0, num);
											}
											while (num > 0);
										}
									}
								}
								GClass4.smethod_1(text2, array4[2]);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0001AA80 File Offset: 0x00018C80
		private static void smethod_1(string string_0, string string_1)
		{
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(string_0))
				{
					if (Convert.ToBase64String(md.ComputeHash(fileStream)) != string_1)
					{
						throw new Exception("Hash check failed!");
					}
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0001AAEC File Offset: 0x00018CEC
		private static List<GClass4.GClass5> smethod_2(string string_0)
		{
			GClass4.Class0 @class = new GClass4.Class0();
			@class.uri_0 = new Uri(string_0);
			return new Alphaleonis.Win32.Filesystem.DirectoryInfo(string_0).GetDirectories("*", SearchOption.AllDirectories).Select(new Func<Alphaleonis.Win32.Filesystem.DirectoryInfo, GClass4.GClass5>(@class.method_0)).ToList<GClass4.GClass5>();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0001AB34 File Offset: 0x00018D34
		private static List<GClass4.GClass5> smethod_3(string string_0)
		{
			GClass4.Class1 @class = new GClass4.Class1();
			@class.uri_0 = new Uri(string_0);
			return new Alphaleonis.Win32.Filesystem.DirectoryInfo(string_0).GetFiles("*", SearchOption.AllDirectories).Select(new Func<Alphaleonis.Win32.Filesystem.FileInfo, GClass4.GClass5>(@class.method_0)).ToList<GClass4.GClass5>();
		}

		// Token: 0x04000006 RID: 6
		private static readonly EncryptionSettings encryptionSettings_0 = new DefaultEncryptionSettings
		{
			Password = "rL'.*##y%YV5s8YK%~@X?p"
		};

		// Token: 0x02000009 RID: 9
		public class GClass5
		{
			// Token: 0x06000027 RID: 39 RVA: 0x000108FB File Offset: 0x0000EAFB
			public GClass5(string string_2, string string_3)
			{
				this.string_0 = string_2;
				this.string_1 = string_3;
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00010911 File Offset: 0x0000EB11
			public override bool Equals(object obj)
			{
				return obj is GClass4.GClass5 && ((GClass4.GClass5)obj).string_1 == this.string_1;
			}

			// Token: 0x04000007 RID: 7
			public string string_0;

			// Token: 0x04000008 RID: 8
			public string string_1;
		}

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		private sealed class Class0
		{
			// Token: 0x0600002A RID: 42 RVA: 0x00010933 File Offset: 0x0000EB33
			internal GClass4.GClass5 method_0(Alphaleonis.Win32.Filesystem.DirectoryInfo directoryInfo_0)
			{
				return new GClass4.GClass5(directoryInfo_0.FullName, this.uri_0.MakeRelativeUri(new Uri(directoryInfo_0.FullName)).OriginalString);
			}

			// Token: 0x04000009 RID: 9
			public Uri uri_0;
		}

		// Token: 0x0200000B RID: 11
		[CompilerGenerated]
		private sealed class Class1
		{
			// Token: 0x0600002C RID: 44 RVA: 0x0001095B File Offset: 0x0000EB5B
			internal GClass4.GClass5 method_0(Alphaleonis.Win32.Filesystem.FileInfo fileInfo_0)
			{
				return new GClass4.GClass5(fileInfo_0.FullName, this.uri_0.MakeRelativeUri(new Uri(fileInfo_0.FullName)).OriginalString);
			}

			// Token: 0x0400000A RID: 10
			public Uri uri_0;
		}
	}
}

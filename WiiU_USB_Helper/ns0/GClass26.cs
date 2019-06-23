using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using NusHelper;
using SharpCompress.Common;
using SharpCompress.Readers;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
	// Token: 0x0200004E RID: 78
	public static class GClass26
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000119B2 File Offset: 0x0000FBB2
		public static string DbVersionCode { get; } = "";

		// Token: 0x060001D9 RID: 473 RVA: 0x00022830 File Offset: 0x00020A30
		public static void smethod_0(string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, bool bool_0, byte[] byte_0, byte[] byte_1, byte[] byte_2, GStruct2 gstruct2_0, Action<int> action_0 = null)
		{
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(GClass26.<>c.<>c_0.method_0));
			ServicePointManager.DefaultConnectionLimit = 8;
			GClass26.string_0 = string_5;
			GClass26.string_1 = string_6;
			GClass26.string_2 = string_7;
			GClass88.smethod_13(GClass26.string_0);
			Directory.CreateDirectory(GClass17.string_0);
			Class65.RootDomain = string_8;
			GClass28.string_5 = Class65.smethod_22();
			GClass28.list_2 = Class65.smethod_2();
			GClass28.string_4 = string_4;
			GClass28.dictionary_0.Clear();
			GClass28.list_6.Clear();
			GClass28.dictionary_3.Clear();
			GClass28.dictionary_1.Clear();
			GClass28.dictionary_2.Clear();
			GClass30.smethod_0();
			Class65.smethod_13();
			Class65.smethod_20("out/games.json");
			Class65.smethod_20("out/customs.json");
			Class65.smethod_20("out/injections.json");
			Class65.smethod_20("out/games3ds.json");
			Class65.smethod_20("out/gamesWii.json");
			Class65.smethod_21("out/updates.json");
			Class65.smethod_21("out/updates3ds.json");
			Class65.smethod_19("out/dlcs.json");
			Class65.smethod_19("out/dlcs3ds.json");
			if (!bool_0)
			{
				try
				{
					GClass26.smethod_5(byte_0);
					goto IL_1C2;
				}
				catch
				{
					Settings.Default.TicketsPath = "";
					Settings.Default.TicketsPath3DS = "";
					Settings.Default.TicketsPathWii = "";
					RadMessageBox.Show("The application was unable to parse the specified archive. The app will now restart. Please specify another archive or use the title key site instead (recommended)");
					Settings.Default.Save();
					Application.Restart();
					return;
				}
			}
			string string_10 = "";
			string string_11 = "";
			string string_12 = "";
			if (byte_0 != null)
			{
				string_10 = Encoding.UTF8.GetString(byte_0);
			}
			if (byte_1 != null)
			{
				string_11 = Encoding.UTF8.GetString(byte_1);
			}
			if (byte_2 != null)
			{
				string_12 = Encoding.UTF8.GetString(byte_2);
			}
			GClass26.smethod_6(string_10, string_11, string_12);
			IL_1C2:
			if (GClass28.dictionary_0.Count == 0)
			{
				throw new Exception("No titles available. Please check your ticket source.");
			}
			foreach (GClass32 gclass in GClass28.dictionary_0.Values)
			{
				foreach (GClass31 gclass2 in GClass28.list_6)
				{
					if (!(gclass.TitleId.High != gclass2.TitleId.High) && gclass.System == gclass2.System)
					{
						gclass2.Name = gclass.Name;
						gclass.Dlc = gclass2;
						break;
					}
				}
			}
			if (GClass88.smethod_1("lasttitles"))
			{
				GClass26.Class32 @class = new GClass26.Class32();
				@class.string_0 = GClass88.smethod_7("lasttitles");
				GClass28.NewTitles = GClass28.dictionary_0.Values.Where(new Func<GClass32, bool>(@class.method_0)).ToList<GClass32>();
			}
			GClass88.smethod_10("lasttitles", GClass28.dictionary_0.Values.Select(new Func<GClass32, string>(GClass26.<>c.<>c_0.method_1)).ToArray<string>());
			if (GClass88.smethod_1("lastUpdates"))
			{
				GClass26.Class33 class2 = new GClass26.Class33();
				class2.string_0 = GClass88.smethod_7("lastUpdates");
				GClass28.NewUpdates = GClass28.dictionary_0.Values.Where(new Func<GClass32, bool>(GClass26.<>c.<>c_0.method_2)).Select(new Func<GClass32, GClass33>(GClass26.<>c.<>c_0.method_3)).Where(new Func<GClass33, bool>(class2.method_0)).ToList<GClass33>();
			}
			GClass88.smethod_10("lastUpdates", GClass28.dictionary_0.Values.Where(new Func<GClass32, bool>(GClass26.<>c.<>c_0.method_4)).Select(new Func<GClass32, string>(GClass26.<>c.<>c_0.method_5)).ToArray<string>());
			try
			{
				GClass26.smethod_3(new DirectoryInfo(Path.Combine(string_4, "DATA_3DS")).GetDirectories("*.*", System.IO.SearchOption.AllDirectories));
			}
			catch
			{
			}
			GClass26.smethod_1("http://wiiu.titlekeys.gq/rss");
			GClass26.smethod_1("http://3ds.titlekeys.gq/rss");
			GClass3.smethod_4();
			GClass28.dictionary_1.Clear();
			GClass28.dictionary_2.Clear();
			GClass28.dictionary_3.Clear();
			GClass28.string_5 = null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00022CE0 File Offset: 0x00020EE0
		private static void smethod_1(string string_4)
		{
			try
			{
				string xml = new GClass78().method_7(string_4, 7200);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				foreach (object obj in xmlDocument.GetElementsByTagName("description"))
				{
					string innerXml = ((XmlNode)obj).InnerXml;
					if (!(innerXml == "<![CDATA[Newest Keys]]>"))
					{
						TitleId key = new TitleId(innerXml.Substring(9, 16));
						if (GClass28.dictionary_0.ContainsKey(key))
						{
							GClass28.list_3.Add(GClass28.dictionary_0[key]);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00022DAC File Offset: 0x00020FAC
		private static void smethod_2(IEnumerable<DirectoryInfo> ienumerable_0)
		{
			foreach (DirectoryInfo directoryInfo in ienumerable_0.Where(new Func<DirectoryInfo, bool>(GClass26.<>c.<>c_0.method_6)))
			{
				try
				{
					int num = directoryInfo.Name.IndexOf('[') + 1;
					string text = directoryInfo.Name.Substring(num, directoryInfo.Name.IndexOf(']') - num);
					if (text.Length == 16)
					{
						TitleId titleId = new TitleId(text);
						if ((titleId.IdType == GEnum1.const_3 || titleId.IdType == GEnum1.const_1) && !GClass28.list_1.Contains(titleId))
						{
							GClass28.list_1.Add(titleId);
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00022E94 File Offset: 0x00021094
		private static void smethod_3(IEnumerable<DirectoryInfo> ienumerable_0)
		{
			foreach (DirectoryInfo directoryInfo in ienumerable_0.Where(new Func<DirectoryInfo, bool>(GClass26.<>c.<>c_0.method_7)))
			{
				TitleId titleId = new TitleId(directoryInfo.Name);
				GClass30 gclass = null;
				try
				{
					GClass26.Class34 @class = new GClass26.Class34();
					switch (titleId.IdType)
					{
					case GEnum1.const_0:
					{
						GClass100 gclass2 = GClass100.smethod_0(Path.Combine(directoryInfo.FullName, "title.tmd"), GEnum3.const_1);
						@class.ushort_0 = gclass2.TitleVersion;
						gclass = GClass28.dictionary_0[titleId.FullGame].Updates.First(new Func<GClass33, bool>(@class.method_0));
						break;
					}
					case GEnum1.const_1:
						gclass = GClass28.dictionary_0[titleId];
						break;
					case GEnum1.const_2:
						gclass = GClass28.dictionary_0[titleId.FullGame].Dlc;
						break;
					case GEnum1.const_3:
						gclass = GClass28.dictionary_0[titleId];
						break;
					}
				}
				catch
				{
					continue;
				}
				try
				{
					FileSystem.MoveDirectory(directoryInfo.FullName, gclass.OutputPath);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00022FF0 File Offset: 0x000211F0
		private static void smethod_4(GStruct2 gstruct2_0)
		{
			try
			{
				new WebClient().DownloadStringAsync(new Uri(string.Format("{0}/telemetry.php?distribution_media={1}&os_revision={2}&app_version={3}", new object[]
				{
					Class65.String_3,
					gstruct2_0.string_0,
					gstruct2_0.string_1,
					gstruct2_0.string_2
				})));
			}
			catch
			{
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00023054 File Offset: 0x00021254
		private static void smethod_5(byte[] byte_0)
		{
			try
			{
				using (Stream stream = new MemoryStream(byte_0))
				{
					using (IReader reader = ReaderFactory.Open(stream, null))
					{
						char c = (reader.ArchiveType == ArchiveType.Zip) ? '/' : '\\';
						while (reader.MoveToNextEntry())
						{
							GClass26.Class35 @class = new GClass26.Class35();
							if (!reader.Entry.IsDirectory)
							{
								@class.string_0 = reader.Entry.Key.Split(new char[]
								{
									c
								}, StringSplitOptions.RemoveEmptyEntries);
								if (@class.string_0.Length >= 4)
								{
									TitleId titleId = new TitleId(@class.string_0[2]);
									if (GClass28.dictionary_2.ContainsKey(titleId.FullGame) && titleId.IdType != GEnum1.const_0 && !GClass28.string_5.Contains(titleId.FullGame))
									{
										byte[] buffer;
										using (MemoryStream memoryStream = new MemoryStream())
										{
											reader.WriteEntryTo(memoryStream);
											buffer = memoryStream.GetBuffer();
										}
										GEnum1 idType = titleId.IdType;
										int num = (int)idType;
										if (num != 2)
										{
											if (num == 5)
											{
												continue;
											}
										}
										else if (GClass28.dictionary_1.ContainsKey(titleId))
										{
											GClass31 item = new GClass31("", titleId, @class.string_0[0], buffer, GClass28.dictionary_1[titleId].dataSize_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_1)
											{
												CfwOnly = true
											};
											GClass28.list_6.Add(item);
											continue;
										}
										List<GClass33> list = new List<GClass33>();
										if (GClass28.dictionary_3.ContainsKey(new TitleId(titleId.FullUpdate)))
										{
											list.AddRange(GClass28.dictionary_3[titleId.FullUpdate].Select(new Func<GClass80.GStruct5, GClass33>(@class.method_0)));
										}
										GClass32 gclass = new GClass32(@class.string_0[1], titleId, @class.string_0[0], buffer, GClass28.dictionary_2[titleId].Size, list, GClass28.dictionary_2[titleId].EshopId, GClass28.dictionary_2[titleId].ProductCode, GClass28.dictionary_2[titleId].IconUrl, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GClass28.dictionary_2[titleId].Platform, GEnum3.const_1);
										if (GClass28.dictionary_2[titleId.FullGame].ProductCode.Length < 6)
										{
											Console.WriteLine(string.Format("{0} {1} {2} has bad product code.", gclass.Name, gclass.TitleId, gclass.EshopId));
										}
										if (GClass28.dictionary_2[titleId.FullGame].IconUrl == "#N/A")
										{
											Console.WriteLine(string.Format("{0} {1} {2} has bad icon url.", gclass.Name, gclass.TitleId, gclass.EshopId));
										}
										if (!GClass28.dictionary_0.ContainsKey(gclass.TitleId))
										{
											GClass28.dictionary_0.Add(gclass.TitleId, gclass);
										}
									}
								}
							}
						}
					}
				}
			}
			catch
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000119B9 File Offset: 0x0000FBB9
		private static void smethod_6(string string_4, string string_5, string string_6)
		{
			new Class70(GClass26.string_1, GClass26.string_2, string_4, string_5, string_6).method_2();
		}

		// Token: 0x0400012D RID: 301
		private static string string_0;

		// Token: 0x0400012E RID: 302
		private static string string_1;

		// Token: 0x0400012F RID: 303
		private static string string_2;

		// Token: 0x04000130 RID: 304
		[CompilerGenerated]
		private static readonly string string_3;

		// Token: 0x0200004F RID: 79
		[CompilerGenerated]
		private sealed class Class32
		{
			// Token: 0x060001E1 RID: 481 RVA: 0x000119D2 File Offset: 0x0000FBD2
			internal bool method_0(GClass32 gclass32_0)
			{
				return !this.string_0.Contains(gclass32_0.TitleId.IdRaw);
			}

			// Token: 0x04000131 RID: 305
			public string[] string_0;
		}

		// Token: 0x02000050 RID: 80
		[CompilerGenerated]
		private sealed class Class33
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x000119ED File Offset: 0x0000FBED
			internal bool method_0(GClass33 gclass33_0)
			{
				return !this.string_0.Contains(gclass33_0.ToString()) && gclass33_0.GEnum2_0 != GEnum2.const_2;
			}

			// Token: 0x04000132 RID: 306
			public string[] string_0;
		}

		// Token: 0x02000052 RID: 82
		[CompilerGenerated]
		private sealed class Class34
		{
			// Token: 0x060001EF RID: 495 RVA: 0x00011AAE File Offset: 0x0000FCAE
			internal bool method_0(GClass33 gclass33_0)
			{
				return gclass33_0.Version == this.ushort_0.ToString();
			}

			// Token: 0x0400013C RID: 316
			public ushort ushort_0;
		}

		// Token: 0x02000053 RID: 83
		[CompilerGenerated]
		private sealed class Class35
		{
			// Token: 0x060001F1 RID: 497 RVA: 0x00011AC6 File Offset: 0x0000FCC6
			internal GClass33 method_0(GClass80.GStruct5 gstruct5_0)
			{
				return new GClass33(this.string_0[1], gstruct5_0.titleId_0, this.string_0[0], null, gstruct5_0.dataSize_0, gstruct5_0.string_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_1);
			}

			// Token: 0x0400013D RID: 317
			public string[] string_0;
		}
	}
}

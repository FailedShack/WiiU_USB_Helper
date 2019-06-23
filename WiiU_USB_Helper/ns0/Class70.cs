using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using NusHelper;
using NusHelper.Server;

namespace ns0
{
	// Token: 0x020000CB RID: 203
	internal class Class70
	{
		// Token: 0x06000539 RID: 1337 RVA: 0x00013791 File Offset: 0x00011991
		public Class70(string string_5, string string_6, string string_7, string string_8, string string_9)
		{
			this.string_4 = string_5;
			this.string_2 = string_7;
			this.string_3 = string_6;
			this.string_0 = string_8;
			this.string_1 = string_9;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0002AF20 File Offset: 0x00029120
		public List<Class70.Class72> method_0(string string_5)
		{
			if (string_5 == "")
			{
				return new List<Class70.Class72>();
			}
			return JsonConvert.DeserializeObject<List<Class70.Class72>>(string_5).Where(new Func<Class70.Class72, bool>(Class70.<>c.<>c_0.method_0)).ToList<Class70.Class72>();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0002AF70 File Offset: 0x00029170
		private GClass32 method_1(TitleId titleId_0, string string_5, string string_6, string string_7, DataSize dataSize_0)
		{
			GClass32 gclass = new GClass32(string_5, titleId_0, "ALL", null, dataSize_0, null, "0", "CTR-P-CTAP", "", "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/", Platform.Unknown, GEnum3.const_0);
			gclass.CfwOnly = true;
			gclass.TicketArray = GClass99.smethod_0(titleId_0.IdRaw, string_7, 0);
			gclass.byte_0 = string_6.smethod_6();
			gclass.Ticket = GClass99.smethod_7(gclass.TicketArray, GEnum3.const_0);
			gclass.Ticket.Byte_0 = string_6.smethod_6();
			return gclass;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002AFF0 File Offset: 0x000291F0
		public void method_2()
		{
			Class70.Class73 @class = new Class70.Class73();
			@class.class70_0 = this;
			@class.frmWait_0 = new FrmWait("USB Helper is preparing the ticket cache", true);
			Task.Run(new Action(@class.method_0));
			@class.frmWait_0.TopMost = true;
			@class.frmWait_0.ShowDialog();
			if (this.string_0 != "")
			{
				List<Class70.Class71> source = JsonConvert.DeserializeObject<List<Class70.Class71>>(this.string_0);
				foreach (Class70.Class71 class2 in source.Where(new Func<Class70.Class71, bool>(Class70.<>c.<>c_0.method_3)))
				{
					TitleId key = new TitleId(class2.titleID);
					if (GClass28.dictionary_3.ContainsKey(key))
					{
						for (int i = 0; i < GClass28.dictionary_3[key].Count; i++)
						{
							GClass80.GStruct5 gstruct = GClass28.dictionary_3[key][i];
							GClass28.dictionary_3[key][i] = new GClass80.GStruct5
							{
								dataSize_0 = gstruct.dataSize_0,
								titleId_0 = gstruct.titleId_0,
								string_0 = gstruct.string_0,
								string_2 = class2.titleKey,
								string_1 = class2.encTitleKey
							};
						}
					}
				}
				foreach (Class70.Class71 class3 in source.Where(new Func<Class70.Class71, bool>(Class70.<>c.<>c_0.method_4)))
				{
					TitleId titleId = new TitleId(class3.titleID);
					if (GClass28.dictionary_1.ContainsKey(titleId))
					{
						GClass80.GStruct4 gstruct2 = GClass28.dictionary_1[titleId];
						string string_ = HttpUtility.HtmlDecode(class3.name.Trim()).Replace("\n", " ");
						string string_2 = class3.region.Trim();
						GClass31 gclass = new GClass31(string_, titleId, string_2, null, gstruct2.dataSize_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_0)
						{
							CfwOnly = true,
							TicketArray = GClass99.smethod_0(titleId, class3.encTitleKey, 1),
							byte_0 = class3.titleKey.smethod_6()
						};
						gclass.Ticket = GClass99.smethod_7(gclass.TicketArray, GEnum3.const_0);
						gclass.Ticket.Byte_0 = class3.titleKey.smethod_6();
						GClass28.list_6.Add(gclass);
					}
				}
				foreach (Class70.Class71 class4 in source.Where(new Func<Class70.Class71, bool>(Class70.<>c.<>c_0.method_5)))
				{
					TitleId titleId2 = new TitleId(class4.titleID);
					if (titleId2.IdRaw == "0004009B00010202")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC1", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "0004009B00010402")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC2", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "0004009B00014002")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC3", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "0004009B00014102")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC4", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "0004009B00014202")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC5", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "0004009B00014302")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC6", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "000400DB00010302")
					{
						GClass28.list_0.Add(this.method_1(titleId2, "ARC7", class4.titleKey, class4.encTitleKey, new DataSize(1UL)));
					}
					if (titleId2.IdRaw == "0004009B00014002")
					{
						GClass28.gclass32_0 = this.method_1(titleId2, "Shared Font", class4.titleKey, class4.encTitleKey, new DataSize(1466880UL));
					}
					if ((titleId2.IdType == GEnum1.const_3 || titleId2.IdType == GEnum1.const_4) && GClass28.dictionary_2.ContainsKey(titleId2))
					{
						DbRow dbRow = GClass28.dictionary_2[titleId2];
						string text = HttpUtility.HtmlDecode(class4.name.Trim()).Replace("\n", " ");
						string string_3 = class4.region.Trim();
						List<GClass33> list = new List<GClass33>();
						if (GClass28.dictionary_3.ContainsKey(new TitleId(titleId2.FullUpdate)))
						{
							foreach (GClass80.GStruct5 gstruct3 in GClass28.dictionary_3[titleId2.FullUpdate])
							{
								if (gstruct3.string_2 != null && gstruct3.string_1 != null)
								{
									GClass33 gclass2 = new GClass33(text, gstruct3.titleId_0, string_3, null, gstruct3.dataSize_0, gstruct3.string_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_0)
									{
										CfwOnly = true
									};
									gclass2.TicketArray = GClass99.smethod_0(gstruct3.titleId_0, gstruct3.string_1, int.Parse(gstruct3.string_0));
									gclass2.byte_0 = gstruct3.string_2.smethod_6();
									gclass2.Ticket = GClass99.smethod_7(gclass2.TicketArray, GEnum3.const_0);
									gclass2.Ticket.Byte_0 = gstruct3.string_2.smethod_6();
									list.Add(gclass2);
								}
							}
						}
						GClass32 gclass3 = new GClass32(text, titleId2, dbRow.Region, null, dbRow.Size, list, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/", dbRow.Platform, GEnum3.const_0)
						{
							CfwOnly = true
						};
						gclass3.TicketArray = GClass99.smethod_0(titleId2.IdRaw, class4.encTitleKey, 1);
						gclass3.byte_0 = class4.titleKey.smethod_6();
						gclass3.Ticket = GClass99.smethod_7(gclass3.TicketArray, GEnum3.const_0);
						gclass3.Ticket.Byte_0 = class4.titleKey.smethod_6();
						GClass28.dictionary_0.Add(titleId2, gclass3);
					}
				}
			}
			if (this.string_1 != "")
			{
				foreach (Class70.Class72 class5 in this.method_0(this.string_1))
				{
					TitleId titleId3 = new TitleId(class5.titleID);
					if (GClass28.dictionary_2.ContainsKey(titleId3))
					{
						DbRow dbRow2 = GClass28.dictionary_2[titleId3];
						GClass32 gclass4 = new GClass32(class5.name, titleId3, dbRow2.Region, null, dbRow2.Size, new List<GClass33>(), dbRow2.EshopId, dbRow2.ProductCode, dbRow2.IconUrl, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", dbRow2.Platform, GEnum3.const_3)
						{
							CfwOnly = true
						};
						byte[] ticketArray = GClass99.smethod_1(dbRow2.TitleId, class5.titleKey, 0);
						gclass4.TicketArray = ticketArray;
						gclass4.Ticket = GClass99.smethod_7(gclass4.TicketArray, GEnum3.const_3);
						GClass28.dictionary_0.Add(dbRow2.TitleId, gclass4);
					}
				}
			}
		}

		// Token: 0x04000337 RID: 823
		private readonly string string_0;

		// Token: 0x04000338 RID: 824
		private readonly string string_1;

		// Token: 0x04000339 RID: 825
		private readonly string string_2;

		// Token: 0x0400033A RID: 826
		private readonly string string_3;

		// Token: 0x0400033B RID: 827
		private readonly string string_4;

		// Token: 0x020000CC RID: 204
		internal class Class71
		{
			// Token: 0x1700012F RID: 303
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x000137BE File Offset: 0x000119BE
			// (set) Token: 0x0600053F RID: 1343 RVA: 0x000137C6 File Offset: 0x000119C6
			public string encTitleKey { get; set; }

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000540 RID: 1344 RVA: 0x000137CF File Offset: 0x000119CF
			// (set) Token: 0x06000541 RID: 1345 RVA: 0x000137D7 File Offset: 0x000119D7
			public string name { get; set; }

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x000137E0 File Offset: 0x000119E0
			// (set) Token: 0x06000543 RID: 1347 RVA: 0x000137E8 File Offset: 0x000119E8
			public string region { get; set; }

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x000137F1 File Offset: 0x000119F1
			// (set) Token: 0x06000545 RID: 1349 RVA: 0x000137F9 File Offset: 0x000119F9
			public string serial { get; set; }

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000546 RID: 1350 RVA: 0x00013802 File Offset: 0x00011A02
			// (set) Token: 0x06000547 RID: 1351 RVA: 0x0001380A File Offset: 0x00011A0A
			public object size { get; set; }

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x00013813 File Offset: 0x00011A13
			// (set) Token: 0x06000549 RID: 1353 RVA: 0x0001381B File Offset: 0x00011A1B
			public string titleID { get; set; }

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600054A RID: 1354 RVA: 0x00013824 File Offset: 0x00011A24
			// (set) Token: 0x0600054B RID: 1355 RVA: 0x0001382C File Offset: 0x00011A2C
			public string titleKey { get; set; }

			// Token: 0x0400033C RID: 828
			[CompilerGenerated]
			private string string_0;

			// Token: 0x0400033D RID: 829
			[CompilerGenerated]
			private string string_1;

			// Token: 0x0400033E RID: 830
			[CompilerGenerated]
			private string string_2;

			// Token: 0x0400033F RID: 831
			[CompilerGenerated]
			private string string_3;

			// Token: 0x04000340 RID: 832
			[CompilerGenerated]
			private object object_0;

			// Token: 0x04000341 RID: 833
			[CompilerGenerated]
			private string string_4;

			// Token: 0x04000342 RID: 834
			[CompilerGenerated]
			private string string_5;
		}

		// Token: 0x020000CD RID: 205
		internal class Class72
		{
			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600054D RID: 1357 RVA: 0x00013835 File Offset: 0x00011A35
			// (set) Token: 0x0600054E RID: 1358 RVA: 0x0001383D File Offset: 0x00011A3D
			public string name { get; set; }

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600054F RID: 1359 RVA: 0x00013846 File Offset: 0x00011A46
			// (set) Token: 0x06000550 RID: 1360 RVA: 0x0001384E File Offset: 0x00011A4E
			public string region { get; set; }

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000551 RID: 1361 RVA: 0x00013857 File Offset: 0x00011A57
			// (set) Token: 0x06000552 RID: 1362 RVA: 0x0001385F File Offset: 0x00011A5F
			public string ticket { get; set; }

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000553 RID: 1363 RVA: 0x00013868 File Offset: 0x00011A68
			// (set) Token: 0x06000554 RID: 1364 RVA: 0x00013870 File Offset: 0x00011A70
			public string titleID { get; set; }

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000555 RID: 1365 RVA: 0x00013879 File Offset: 0x00011A79
			// (set) Token: 0x06000556 RID: 1366 RVA: 0x00013881 File Offset: 0x00011A81
			public string titleKey { get; set; }

			// Token: 0x04000343 RID: 835
			[CompilerGenerated]
			private string string_0;

			// Token: 0x04000344 RID: 836
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000345 RID: 837
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000346 RID: 838
			[CompilerGenerated]
			private string string_3;

			// Token: 0x04000347 RID: 839
			[CompilerGenerated]
			private string string_4;
		}

		// Token: 0x020000CF RID: 207
		[CompilerGenerated]
		private sealed class Class73
		{
			// Token: 0x06000560 RID: 1376 RVA: 0x0002B920 File Offset: 0x00029B20
			internal void method_0()
			{
				bool flag = true;
				string text = Path.Combine(GClass88.CachePath, "tickets");
				Directory.CreateDirectory(text);
				List<Class70.Class72> list = this.class70_0.method_0(this.class70_0.string_2);
				int num = list.Count(new Func<Class70.Class72, bool>(Class70.<>c.<>c_0.method_1));
				int num2 = 0;
				foreach (KeyValuePair<TitleId, DbRow> keyValuePair in GClass28.dictionary_2.Where(new Func<KeyValuePair<TitleId, DbRow>, bool>(Class70.<>c.<>c_0.method_2)))
				{
					DbRow value = keyValuePair.Value;
					GClass32 value2 = new GClass32(value.Name, value.TitleId, value.Region, null, value.Size, new List<GClass33>(), value.EshopId, value.ProductCode, value.IconUrl, "http://cdn.wiiuusbhelper.com/wiiu/download/", value.Platform, GEnum3.const_1)
					{
						CfwOnly = true
					};
					GClass28.dictionary_0.Add(value.TitleId, value2);
				}
				foreach (Class70.Class72 @class in list)
				{
					Class70.Class74 class2 = new Class70.Class74();
					TitleId titleId = new TitleId(@class.titleID.Trim());
					string titleKey = @class.titleKey;
					string text2 = (titleKey != null) ? titleKey.Trim() : null;
					class2.string_0 = HttpUtility.HtmlDecode(@class.name.Trim()).Replace("\n", " ");
					class2.string_1 = @class.region.Trim();
					if (GClass28.dictionary_2.ContainsKey(titleId.FullGame))
					{
						DbRow dbRow = GClass28.dictionary_2[titleId.FullGame];
						GEnum1 idType = titleId.IdType;
						if (idType != GEnum1.const_1)
						{
							if (idType == GEnum1.const_2)
							{
								if (GClass28.dictionary_1.ContainsKey(titleId))
								{
									byte[] byte_ = GClass99.smethod_2(titleId, text2, 0, false, true);
									GClass31 item = new GClass31(class2.string_0, titleId, class2.string_1, byte_, GClass28.dictionary_1[titleId].dataSize_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_1)
									{
										CfwOnly = true
									};
									GClass28.list_6.Add(item);
								}
							}
						}
						else
						{
							List<GClass33> list2 = new List<GClass33>();
							if (GClass28.dictionary_3.ContainsKey(new TitleId(titleId.FullUpdate)))
							{
								list2.AddRange(GClass28.dictionary_3[titleId.FullUpdate].Select(new Func<GClass80.GStruct5, GClass33>(class2.method_0)));
							}
							GClass32 gclass = new GClass32(class2.string_0, titleId, class2.string_1, null, dbRow.Size, list2, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", dbRow.Platform, GEnum3.const_1)
							{
								DiscOnly = (dbRow.DiscOnly || text2 == null)
							};
							if (@class.ticket == "1" && !new Platform[]
							{
								Platform.GameBoy_Advance,
								Platform.Nintendo_64,
								Platform.Nintendo_DS,
								Platform.TurboGrafx16,
								Platform.Super_NES,
								Platform.const_12,
								Platform.const_8,
								Platform.Wii
							}.Contains(dbRow.Platform) && !GClass28.list_2.Contains(@class.titleID.ToUpper()))
							{
								string text3 = string.Format("{0}/ticket/", this.class70_0.string_4) + @class.titleID + ".tik";
								gclass.bool_0 = true;
								gclass.string_0 = text3;
								string text4 = Path.Combine(text, @class.titleID.ToUpper() + ".tik");
								if (flag && (!File.Exists(text4) || new FileInfo(text4).Length == 0L))
								{
									new WebClient().DownloadFile(text3, text4);
								}
								num2++;
								this.frmWait_0.method_2((int)((double)num2 / (double)num * 100.0));
							}
							else if (text2 != null)
							{
								byte[] ticketArray = GClass99.smethod_2(titleId.IdRaw, text2, 0, false, false);
								gclass.CfwOnly = true;
								gclass.TicketArray = ticketArray;
								gclass.Ticket = GClass99.smethod_7(gclass.TicketArray, GEnum3.const_1);
							}
							GClass28.dictionary_0.Add(titleId, gclass);
						}
					}
				}
				this.frmWait_0.method_0();
			}

			// Token: 0x0400034F RID: 847
			public Class70 class70_0;

			// Token: 0x04000350 RID: 848
			public FrmWait frmWait_0;
		}

		// Token: 0x020000D0 RID: 208
		[CompilerGenerated]
		private sealed class Class74
		{
			// Token: 0x06000562 RID: 1378 RVA: 0x0001394C File Offset: 0x00011B4C
			internal GClass33 method_0(GClass80.GStruct5 gstruct5_0)
			{
				return new GClass33(this.string_0, gstruct5_0.titleId_0, this.string_1, null, gstruct5_0.dataSize_0, gstruct5_0.string_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_1);
			}

			// Token: 0x04000351 RID: 849
			public string string_0;

			// Token: 0x04000352 RID: 850
			public string string_1;
		}
	}
}

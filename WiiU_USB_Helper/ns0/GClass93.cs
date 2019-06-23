using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using NusHelper;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x020000D7 RID: 215
	public class GClass93 : GClass91
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00013D36 File Offset: 0x00011F36
		public GClass93(GClass32 gclass32_1) : base(gclass32_1)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00013C4A File Offset: 0x00011E4A
		public override string[] String_3
		{
			get
			{
				return new string[]
				{
					"Fetching the content",
					"Preparing the ROM",
					"Injecting the ROM",
					"Packing the game"
				};
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00013D55 File Offset: 0x00011F55
		public override bool vmethod_0(string string_6)
		{
			if (this.method_14(string_6))
			{
				this.string_3 = string_6;
				return true;
			}
			RadMessageBox.Show("USB Helper was unable to recognize this ROM. Make sure you have provided a ROM of the same region as the title you are trying to inject");
			return false;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00013D75 File Offset: 0x00011F75
		public override int vmethod_1()
		{
			if (!File.Exists(this.string_3))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00013D87 File Offset: 0x00011F87
		public override void vmethod_2()
		{
			base.vmethod_2();
			Task.Run(new Action(this.method_18));
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0002CD18 File Offset: 0x0002AF18
		public bool method_14(string string_6)
		{
			bool result;
			try
			{
				if (this.method_16(File.ReadAllBytes(string_6), 0))
				{
					result = true;
				}
				else
				{
					result = this.method_16(File.ReadAllBytes(string_6), 512);
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00013DA1 File Offset: 0x00011FA1
		private byte[] Byte_0
		{
			get
			{
				if (this.byte_0 == null)
				{
					this.byte_0 = base.method_6("hash").smethod_6();
				}
				return this.byte_0;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00013DC7 File Offset: 0x00011FC7
		private GClass30 GClass30_0
		{
			get
			{
				if (this.gclass30_0 == null)
				{
					this.gclass30_0 = GClass28.dictionary_0[new TitleId(base.method_6("template"))];
				}
				return this.gclass30_0;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00013CEE File Offset: 0x00011EEE
		public override string String_1
		{
			get
			{
				return "ROM";
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00013DF7 File Offset: 0x00011FF7
		public override string String_2
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0002CD64 File Offset: 0x0002AF64
		private void method_15()
		{
			string text = Path.Combine(base.WorkPath, "rawFiles");
			Directory.CreateDirectory(text);
			this.GClass30_0.method_16(text, false, false, null, false);
			string text2 = base.method_4("rpl2elf.exe");
			string text3 = base.method_4("RetroInject.exe");
			string text4 = base.method_4("game.elf");
			string text5 = base.method_4("game_injected.elf");
			string sourceFileName = base.method_4("game_injected.rpx");
			string fullName = new DirectoryInfo(Path.Combine(text, "code")).GetFiles().First(new Func<FileInfo, bool>(GClass93.<>c.<>c_0.method_0)).FullName;
			GClass6.smethod_8(string.Format("{0}/res/SNES/vc-template.zip", Class65.String_2), base.WorkPath);
			Task task = base.method_7();
			base.method_11(1);
			GClass91.smethod_1(text2, base.WorkPath, string.Format(" \"{0}\"  \"{1}\"", fullName, text4));
			GClass91.smethod_1(text3, base.WorkPath, string.Format(" \"{0}\"  \"{1}\"  \"{2}\"  ", text4, this.string_3, text5));
			base.method_11(2);
			this.method_17(text5);
			GClass6.smethod_6(fullName);
			File.Move(sourceFileName, fullName);
			task.Wait();
			base.method_11(3);
			this.vmethod_3();
			base.method_8();
			base.method_9();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
		private bool method_16(byte[] byte_1, int int_1 = 0)
		{
			bool result;
			using (SHA1 sha = SHA1.Create())
			{
				sha.TransformFinalBlock(byte_1, int_1, byte_1.Length - int_1);
				result = GClass27.smethod_1(this.Byte_0, sha.Hash);
			}
			return result;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002CC38 File Offset: 0x0002AE38
		private void method_17(string string_6)
		{
			string string_7 = base.method_4("patcher.exe");
			new GClass78().method_5(string.Format("{0}/res/SNES/bootDrc.tga", Class65.String_2), string_7, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
			GClass91.smethod_2(string_7, base.WorkPath, string.Format("-f -s -z9 -nolib \"{0}\"", string_6), "CAFE_ROOT", base.WorkPath);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00013DFE File Offset: 0x00011FFE
		protected override void vmethod_3()
		{
			base.method_2((GClass32)this.GClass30_0);
			GClass91.smethod_1(GClass91.String_0, base.WorkPath, string.Format("-jar \"{0}\" -in rawFiles", "NUSPacker.jar"));
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0002CF04 File Offset: 0x0002B104
		[CompilerGenerated]
		private void method_18()
		{
			try
			{
				base.method_11(0);
				if (this.GClass30_0.GEnum2_0 != GEnum2.const_2)
				{
					GClass80 gclass = new GClass80(null, false, false);
					gclass.Event_5 += this.method_19;
					gclass.method_1(new List<GClass30>(new GClass30[]
					{
						this.GClass30_0
					}), 100, 10000);
				}
				else
				{
					this.method_15();
				}
			}
			catch (Exception exception_)
			{
				base.method_10(exception_);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00013E30 File Offset: 0x00012030
		[CompilerGenerated]
		private void method_19(object object_0, GClass81 gclass81_0)
		{
			this.method_15();
		}

		// Token: 0x04000373 RID: 883
		private byte[] byte_0;

		// Token: 0x04000374 RID: 884
		private string string_3;

		// Token: 0x04000375 RID: 885
		private GClass30 gclass30_0;

		// Token: 0x04000376 RID: 886
		private string string_4 = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<app type=\"complex\" access=\"777\">\r\n  <version type=\"unsignedInt\" length=\"4\">14</version>\r\n  <os_version type=\"hexBinary\" length=\"8\">000500101000400A</os_version>\r\n  <title_id type=\"hexBinary\" length=\"8\">[TITLEID]</title_id>\r\n  <title_version type=\"hexBinary\" length=\"2\">0000</title_version>\r\n  <sdk_version type=\"unsignedInt\" length=\"4\">20811</sdk_version>\r\n  <app_type type=\"hexBinary\" length=\"4\">80000000</app_type>\r\n  <group_id type=\"hexBinary\" length=\"4\">00001095</group_id>\r\n</app>";

		// Token: 0x04000377 RID: 887
		private string string_5 = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<menu type=\"complex\" access=\"777\">\r\n  <version type=\"unsignedInt\" length=\"4\">32</version>\r\n  <product_code type=\"string\" length=\"32\">[PRODUCT-CODE]</product_code>\r\n  <content_platform type=\"string\" length=\"32\">WUP</content_platform>\r\n  <company_code type=\"string\" length=\"8\">0001</company_code>\r\n  <mastering_date type=\"string\" length=\"32\"></mastering_date>\r\n  <logo_type type=\"unsignedInt\" length=\"4\">0</logo_type>\r\n  <app_launch_type type=\"hexBinary\" length=\"4\">00000000</app_launch_type>\r\n  <invisible_flag type=\"hexBinary\" length=\"4\">00000000</invisible_flag>\r\n  <no_managed_flag type=\"hexBinary\" length=\"4\">00000000</no_managed_flag>\r\n  <no_event_log type=\"hexBinary\" length=\"4\">00000000</no_event_log>\r\n  <no_icon_database type=\"hexBinary\" length=\"4\">00000000</no_icon_database>\r\n  <launching_flag type=\"hexBinary\" length=\"4\">00000004</launching_flag>\r\n  <install_flag type=\"hexBinary\" length=\"4\">00000000</install_flag>\r\n  <closing_msg type=\"unsignedInt\" length=\"4\">0</closing_msg>\r\n  <title_version type=\"unsignedInt\" length=\"4\">0</title_version>\r\n  <title_id type=\"hexBinary\" length=\"8\">[TITLEID]</title_id>\r\n  <group_id type=\"hexBinary\" length=\"4\">00001095</group_id>\r\n  <boss_id type=\"hexBinary\" length=\"8\">0000000000000000</boss_id>\r\n  <os_version type=\"hexBinary\" length=\"8\">000500101000400A</os_version>\r\n  <app_size type=\"hexBinary\" length=\"8\">0000000000000000</app_size>\r\n  <common_save_size type=\"hexBinary\" length=\"8\">0000000000000000</common_save_size>\r\n  <account_save_size type=\"hexBinary\" length=\"8\">0000000000600000</account_save_size>\r\n  <common_boss_size type=\"hexBinary\" length=\"8\">0000000000000000</common_boss_size>\r\n  <account_boss_size type=\"hexBinary\" length=\"8\">0000000000000000</account_boss_size>\r\n  <save_no_rollback type=\"unsignedInt\" length=\"4\">0</save_no_rollback>\r\n  <join_game_id type=\"hexBinary\" length=\"4\">00000000</join_game_id>\r\n  <join_game_mode_mask type=\"hexBinary\" length=\"8\">0000000000000000</join_game_mode_mask>\r\n  <bg_daemon_enable type=\"unsignedInt\" length=\"4\">1</bg_daemon_enable>\r\n  <olv_accesskey type=\"unsignedInt\" length=\"4\">1831524951</olv_accesskey>\r\n  <wood_tin type=\"unsignedInt\" length=\"4\">0</wood_tin>\r\n  <e_manual type=\"unsignedInt\" length=\"4\">1</e_manual>\r\n  <e_manual_version type=\"unsignedInt\" length=\"4\">0</e_manual_version>\r\n  <region type=\"hexBinary\" length=\"4\">00000002</region>\r\n  <pc_cero type=\"unsignedInt\" length=\"4\">128</pc_cero>\r\n  <pc_esrb type=\"unsignedInt\" length=\"4\">6</pc_esrb>\r\n  <pc_bbfc type=\"unsignedInt\" length=\"4\">192</pc_bbfc>\r\n  <pc_usk type=\"unsignedInt\" length=\"4\">128</pc_usk>\r\n  <pc_pegi_gen type=\"unsignedInt\" length=\"4\">128</pc_pegi_gen>\r\n  <pc_pegi_fin type=\"unsignedInt\" length=\"4\">192</pc_pegi_fin>\r\n  <pc_pegi_prt type=\"unsignedInt\" length=\"4\">128</pc_pegi_prt>\r\n  <pc_pegi_bbfc type=\"unsignedInt\" length=\"4\">128</pc_pegi_bbfc>\r\n  <pc_cob type=\"unsignedInt\" length=\"4\">128</pc_cob>\r\n  <pc_grb type=\"unsignedInt\" length=\"4\">128</pc_grb>\r\n  <pc_cgsrr type=\"unsignedInt\" length=\"4\">128</pc_cgsrr>\r\n  <pc_oflc type=\"unsignedInt\" length=\"4\">128</pc_oflc>\r\n  <pc_reserved0 type=\"unsignedInt\" length=\"4\">192</pc_reserved0>\r\n  <pc_reserved1 type=\"unsignedInt\" length=\"4\">192</pc_reserved1>\r\n  <pc_reserved2 type=\"unsignedInt\" length=\"4\">192</pc_reserved2>\r\n  <pc_reserved3 type=\"unsignedInt\" length=\"4\">192</pc_reserved3>\r\n  <ext_dev_nunchaku type=\"unsignedInt\" length=\"4\">1</ext_dev_nunchaku>\r\n  <ext_dev_classic type=\"unsignedInt\" length=\"4\">1</ext_dev_classic>\r\n  <ext_dev_urcc type=\"unsignedInt\" length=\"4\">1</ext_dev_urcc>\r\n  <ext_dev_board type=\"unsignedInt\" length=\"4\">0</ext_dev_board>\r\n  <ext_dev_usb_keyboard type=\"unsignedInt\" length=\"4\">0</ext_dev_usb_keyboard>\r\n  <ext_dev_etc type=\"unsignedInt\" length=\"4\">0</ext_dev_etc>\r\n  <ext_dev_etc_name type=\"string\" length=\"512\"></ext_dev_etc_name>\r\n  <eula_version type=\"unsignedInt\" length=\"4\">0</eula_version>\r\n  <drc_use type=\"unsignedInt\" length=\"4\">1</drc_use>\r\n  <network_use type=\"unsignedInt\" length=\"4\">0</network_use>\r\n  <online_account_use type=\"unsignedInt\" length=\"4\">0</online_account_use>\r\n  <direct_boot type=\"unsignedInt\" length=\"4\">0</direct_boot>\r\n  <reserved_flag0 type=\"hexBinary\" length=\"4\">00020002</reserved_flag0>\r\n  <reserved_flag1 type=\"hexBinary\" length=\"4\">00000000</reserved_flag1>\r\n  <reserved_flag2 type=\"hexBinary\" length=\"4\">00000000</reserved_flag2>\r\n  <reserved_flag3 type=\"hexBinary\" length=\"4\">00000000</reserved_flag3>\r\n  <reserved_flag4 type=\"hexBinary\" length=\"4\">00000000</reserved_flag4>\r\n  <reserved_flag5 type=\"hexBinary\" length=\"4\">00000000</reserved_flag5>\r\n  <reserved_flag6 type=\"hexBinary\" length=\"4\">00000000</reserved_flag6>\r\n  <reserved_flag7 type=\"hexBinary\" length=\"4\">00000000</reserved_flag7>\r\n  <longname_ja type=\"string\" length=\"512\">[LONGNAME]</longname_ja>\r\n  <longname_en type=\"string\" length=\"512\">[LONGNAME]</longname_en>\r\n  <longname_fr type=\"string\" length=\"512\">[LONGNAME]</longname_fr>\r\n  <longname_de type=\"string\" length=\"512\">[LONGNAME]</longname_de>\r\n  <longname_it type=\"string\" length=\"512\">[LONGNAME]</longname_it>\r\n  <longname_es type=\"string\" length=\"512\">[LONGNAME]</longname_es>\r\n  <longname_zhs type=\"string\" length=\"512\">[LONGNAME]</longname_zhs>\r\n  <longname_ko type=\"string\" length=\"512\">[LONGNAME]</longname_ko>\r\n  <longname_nl type=\"string\" length=\"512\">[LONGNAME]</longname_nl>\r\n  <longname_pt type=\"string\" length=\"512\">[LONGNAME]</longname_pt>\r\n  <longname_ru type=\"string\" length=\"512\">[LONGNAME]</longname_ru>\r\n  <longname_zht type=\"string\" length=\"512\">[SHORTNAME]</longname_zht>\r\n  <shortname_ja type=\"string\" length=\"256\">[SHORTNAME]</shortname_ja>\r\n  <shortname_en type=\"string\" length=\"256\">[SHORTNAME]</shortname_en>\r\n  <shortname_fr type=\"string\" length=\"256\">[SHORTNAME]</shortname_fr>\r\n  <shortname_de type=\"string\" length=\"256\">[SHORTNAME]</shortname_de>\r\n  <shortname_it type=\"string\" length=\"256\">[SHORTNAME]</shortname_it>\r\n  <shortname_es type=\"string\" length=\"256\">[SHORTNAME]</shortname_es>\r\n  <shortname_zhs type=\"string\" length=\"256\">[SHORTNAME]</shortname_zhs>\r\n  <shortname_ko type=\"string\" length=\"256\">[SHORTNAME]</shortname_ko>\r\n  <shortname_nl type=\"string\" length=\"256\">[SHORTNAME]</shortname_nl>\r\n  <shortname_pt type=\"string\" length=\"256\">[SHORTNAME]</shortname_pt>\r\n  <shortname_ru type=\"string\" length=\"256\">[SHORTNAME]</shortname_ru>\r\n  <shortname_zht type=\"string\" length=\"256\">[SHORTNAME]</shortname_zht>\r\n  <publisher_ja type=\"string\" length=\"256\">[PUBLISHER]</publisher_ja>\r\n  <publisher_en type=\"string\" length=\"256\">[PUBLISHER]</publisher_en>\r\n  <publisher_fr type=\"string\" length=\"256\">[PUBLISHER]</publisher_fr>\r\n  <publisher_de type=\"string\" length=\"256\">[PUBLISHER]</publisher_de>\r\n  <publisher_it type=\"string\" length=\"256\">[PUBLISHER]</publisher_it>\r\n  <publisher_es type=\"string\" length=\"256\">[PUBLISHER]</publisher_es>\r\n  <publisher_zhs type=\"string\" length=\"256\">[PUBLISHER]</publisher_zhs>\r\n  <publisher_ko type=\"string\" length=\"256\">[PUBLISHER]</publisher_ko>\r\n  <publisher_nl type=\"string\" length=\"256\">[PUBLISHER]</publisher_nl>\r\n  <publisher_pt type=\"string\" length=\"256\">[PUBLISHER]</publisher_pt>\r\n  <publisher_ru type=\"string\" length=\"256\">[PUBLISHER]</publisher_ru>\r\n  <publisher_zht type=\"string\" length=\"256\">[PUBLISHER]</publisher_zht>\r\n  <add_on_unique_id0 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id0>\r\n  <add_on_unique_id1 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id1>\r\n  <add_on_unique_id2 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id2>\r\n  <add_on_unique_id3 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id3>\r\n  <add_on_unique_id4 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id4>\r\n  <add_on_unique_id5 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id5>\r\n  <add_on_unique_id6 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id6>\r\n  <add_on_unique_id7 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id7>\r\n  <add_on_unique_id8 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id8>\r\n  <add_on_unique_id9 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id9>\r\n  <add_on_unique_id10 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id10>\r\n  <add_on_unique_id11 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id11>\r\n  <add_on_unique_id12 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id12>\r\n  <add_on_unique_id13 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id13>\r\n  <add_on_unique_id14 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id14>\r\n  <add_on_unique_id15 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id15>\r\n  <add_on_unique_id16 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id16>\r\n  <add_on_unique_id17 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id17>\r\n  <add_on_unique_id18 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id18>\r\n  <add_on_unique_id19 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id19>\r\n  <add_on_unique_id20 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id20>\r\n  <add_on_unique_id21 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id21>\r\n  <add_on_unique_id22 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id22>\r\n  <add_on_unique_id23 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id23>\r\n  <add_on_unique_id24 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id24>\r\n  <add_on_unique_id25 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id25>\r\n  <add_on_unique_id26 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id26>\r\n  <add_on_unique_id27 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id27>\r\n  <add_on_unique_id28 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id28>\r\n  <add_on_unique_id29 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id29>\r\n  <add_on_unique_id30 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id30>\r\n  <add_on_unique_id31 type=\"hexBinary\" length=\"4\">00000000</add_on_unique_id31>\r\n</menu>";
	}
}

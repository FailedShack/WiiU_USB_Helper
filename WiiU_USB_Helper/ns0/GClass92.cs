using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NusHelper;
using Telerik.WinControls;

namespace ns0
{
	// Token: 0x020000D5 RID: 213
	public class GClass92 : GClass91
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00013C41 File Offset: 0x00011E41
		public GClass92(GClass32 gclass32_1) : base(gclass32_1)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00013C4A File Offset: 0x00011E4A
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

		// Token: 0x060005AB RID: 1451 RVA: 0x00013C72 File Offset: 0x00011E72
		public override bool vmethod_0(string string_4)
		{
			if (this.method_14(string_4))
			{
				this.string_3 = string_4;
				return true;
			}
			RadMessageBox.Show("USB Helper was unable to recognize this ROM. Make sure you have provided a ROM of the same region as the title you are trying to inject");
			return false;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00013C92 File Offset: 0x00011E92
		public override int vmethod_1()
		{
			if (!File.Exists(this.string_3))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00013CA4 File Offset: 0x00011EA4
		public override void vmethod_2()
		{
			base.vmethod_2();
			Task.Run(new Action(this.method_20));
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0002C968 File Offset: 0x0002AB68
		public bool method_14(string string_4)
		{
			bool result;
			try
			{
				result = base.List_0.Contains(this.method_16(string_4));
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00013CBE File Offset: 0x00011EBE
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00013CEE File Offset: 0x00011EEE
		public override string String_1
		{
			get
			{
				return "ROM";
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00013CF5 File Offset: 0x00011EF5
		public override string String_2
		{
			get
			{
				return "n64 (*.n64)|*.n64|z64 (*.z64)|*.z64|v64 (*.v64)|*.v64";
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		private void method_15()
		{
			string text = Path.Combine(base.WorkPath, "rawFiles");
			Directory.CreateDirectory(text);
			this.GClass30_0.method_16(text, false, false, null, false);
			Task task = base.method_7();
			base.method_11(1);
			string fullName = new DirectoryInfo(Path.Combine(text, "content", "rom")).GetFiles()[0].FullName;
			GClass6.smethod_6(fullName);
			File.WriteAllBytes(fullName, this.method_18(this.string_3, null));
			try
			{
				string fileName = Path.GetFileName(fullName);
				base.method_5("config", Path.Combine(text, "content", "config"));
				string text2 = Path.Combine(text, "content", "config", fileName + ".ini");
				GClass6.smethod_6(text2);
				File.Move(Path.Combine(text, "content", "config", "config"), text2);
			}
			catch
			{
			}
			GClass6.smethod_8(string.Format("{0}/res/SNES/vc-template.zip", Class65.String_2), base.WorkPath);
			task.Wait();
			base.method_11(3);
			this.vmethod_3();
			base.method_8();
			base.method_9();
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002CADC File Offset: 0x0002ACDC
		private string method_16(string string_4)
		{
			byte[] bytes = this.method_18(string_4, new int?(512));
			return Encoding.GetEncoding(932).GetString(bytes, 59, 4);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002CB10 File Offset: 0x0002AD10
		private GClass92.Enum2 method_17(string string_4)
		{
			GClass92.Enum2 result;
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_4)))
			{
				byte b = binaryReader.ReadByte();
				if (b != 55)
				{
					if (b != 64)
					{
						if (b == 128)
						{
							result = GClass92.Enum2.const_0;
						}
						else
						{
							result = GClass92.Enum2.const_3;
						}
					}
					else
					{
						result = GClass92.Enum2.const_1;
					}
				}
				else
				{
					result = GClass92.Enum2.const_2;
				}
			}
			return result;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002CB70 File Offset: 0x0002AD70
		private byte[] method_18(string string_4, int? nullable_0 = null)
		{
			GClass92.Enum2 @enum = this.method_17(string_4);
			int num = 1;
			switch (@enum)
			{
			case GClass92.Enum2.const_0:
				num = 1;
				break;
			case GClass92.Enum2.const_1:
				num = 4;
				break;
			case GClass92.Enum2.const_2:
				num = 2;
				break;
			}
			byte[] array = new byte[num];
			byte[] result;
			using (FileStream fileStream = File.OpenRead(string_4))
			{
				int? num2 = nullable_0;
				byte[] array2 = new byte[(num2 != null) ? ((long)num2.GetValueOrDefault()) : fileStream.Length];
				int num3 = 0;
				do
				{
					if (fileStream.Read(array, 0, num) > 0)
					{
						for (int i = num - 1; i >= 0; i--)
						{
							array2[num3++] = array[i];
						}
					}
				}
				while (num3 < array2.Length);
				result = array2;
			}
			return result;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0002CC38 File Offset: 0x0002AE38
		private void method_19(string string_4)
		{
			string string_5 = base.method_4("patcher.exe");
			new GClass78().method_5(string.Format("{0}/res/SNES/bootDrc.tga", Class65.String_2), string_5, 0UL, GClass78.GEnum4.const_0, null, 0L, null, null, 0);
			GClass91.smethod_2(string_5, base.WorkPath, string.Format("-f -s -z9 -nolib \"{0}\"", string_4), "CAFE_ROOT", base.WorkPath);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00013CFC File Offset: 0x00011EFC
		protected override void vmethod_3()
		{
			base.method_2((GClass32)this.GClass30_0);
			GClass91.smethod_1(GClass91.String_0, base.WorkPath, string.Format("-jar \"{0}\" -in rawFiles", "NUSPacker.jar"));
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0002CC98 File Offset: 0x0002AE98
		[CompilerGenerated]
		private void method_20()
		{
			try
			{
				base.method_11(0);
				if (this.GClass30_0.GEnum2_0 != GEnum2.const_2)
				{
					GClass80 gclass = new GClass80(null, false, false);
					gclass.Event_5 += this.method_21;
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

		// Token: 0x060005B9 RID: 1465 RVA: 0x00013D2E File Offset: 0x00011F2E
		[CompilerGenerated]
		private void method_21(object object_0, GClass81 gclass81_0)
		{
			this.method_15();
		}

		// Token: 0x0400036C RID: 876
		private string string_3;

		// Token: 0x0400036D RID: 877
		private GClass30 gclass30_0;

		// Token: 0x020000D6 RID: 214
		private enum Enum2
		{
			// Token: 0x0400036F RID: 879
			const_0,
			// Token: 0x04000370 RID: 880
			const_1,
			// Token: 0x04000371 RID: 881
			const_2,
			// Token: 0x04000372 RID: 882
			const_3
		}
	}
}

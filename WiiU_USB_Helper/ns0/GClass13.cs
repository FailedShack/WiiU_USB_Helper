using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200001A RID: 26
	public class GClass13
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0001BB14 File Offset: 0x00019D14
		public GClass13(byte[] byte_0)
		{
			using (BinaryReader binaryReader = new BinaryReader(new MemoryStream(byte_0)))
			{
				if (binaryReader.ReadUInt32() != 5526342u)
				{
					throw new Exception("Incorrect FST!");
				}
				binaryReader.smethod_2();
				int num = binaryReader.smethod_2();
				binaryReader.BaseStream.Seek(32L, SeekOrigin.Begin);
				for (int i = 0; i < num; i++)
				{
					binaryReader.ReadUInt32();
					binaryReader.smethod_4();
					binaryReader.ReadUInt32();
					binaryReader.BaseStream.Seek(20L, SeekOrigin.Current);
				}
				binaryReader.BaseStream.Seek((long)(32 + num * 32 + 8), SeekOrigin.Begin);
				uint num2 = binaryReader.smethod_4();
				binaryReader.BaseStream.Seek((long)(32 + num * 32), SeekOrigin.Begin);
				int num3 = 0;
				while ((long)num3 < (long)((ulong)num2))
				{
					GClass12 gclass = new GClass12
					{
						byte_0 = binaryReader.ReadByte()
					};
					gclass.bool_1 = ((gclass.byte_0 & 1) == 1);
					gclass.bool_0 = ((gclass.byte_0 & 128) > 0);
					binaryReader.smethod_0(3);
					gclass.uint_1 = binaryReader.smethod_4();
					gclass.uint_2 = binaryReader.smethod_4();
					gclass.short_1 = binaryReader.smethod_1();
					gclass.short_0 = binaryReader.smethod_1();
					this.Files.Add(gclass);
					num3++;
				}
				int num4 = 0;
				while ((long)num4 < (long)((ulong)num2))
				{
					string text = "";
					for (;;)
					{
						char c = binaryReader.ReadChar();
						if (c == '\0')
						{
							break;
						}
						text += c.ToString();
					}
					this.Files[num4].string_1 = text;
					num4++;
				}
				foreach (GClass12 gclass2 in this.Files.Where(new Func<GClass12, bool>(GClass13.<>c.<>c_0.method_0)).ToList<GClass12>())
				{
					gclass2.string_0 = Path.Combine(this.Files[(int)gclass2.uint_1].string_0 ?? "", gclass2.string_1);
				}
				List<int> list = new List<int>
				{
					(int)this.Files[0].uint_2
				};
				string text2 = "";
				int num5 = 1;
				while ((long)num5 < (long)((ulong)num2))
				{
					while (list.Last<int>() <= num5)
					{
						text2 = this.method_0(text2);
						list.RemoveAt(list.Count - 1);
					}
					if (this.Files[num5].bool_1)
					{
						text2 = Path.Combine(text2, this.Files[num5].string_1);
						list.Add((int)this.Files[num5].uint_2);
					}
					else
					{
						this.Files[num5].string_0 = Path.Combine(text2, this.Files[num5].string_1);
					}
					num5++;
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00010B60 File Offset: 0x0000ED60
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00010B68 File Offset: 0x0000ED68
		public List<GClass12> Files { get; set; } = new List<GClass12>();

		// Token: 0x0600006C RID: 108 RVA: 0x0001BE68 File Offset: 0x0001A068
		private string method_0(string string_0)
		{
			string result;
			try
			{
				result = string_0.Substring(0, string_0.LastIndexOfAny(new char[]
				{
					'\\'
				}));
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x04000036 RID: 54
		[CompilerGenerated]
		private List<GClass12> list_0;
	}
}

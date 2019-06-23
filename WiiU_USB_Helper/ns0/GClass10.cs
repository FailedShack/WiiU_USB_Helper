using System;
using System.Collections.Specialized;
using System.Linq;
using System.Xml.Linq;

namespace ns0
{
	// Token: 0x02000012 RID: 18
	public static class GClass10
	{
		// Token: 0x06000050 RID: 80 RVA: 0x0001B3A8 File Offset: 0x000195A8
		public static bool smethod_0(string string_0)
		{
			if (!string_0.Any(new Func<char, bool>(GClass10.<>c.<>c_0.method_0)))
			{
				if (!string_0.Any(new Func<char, bool>(GClass10.<>c.<>c_0.method_1)))
				{
					return string_0.Any(new Func<char, bool>(GClass10.<>c.<>c_0.method_2));
				}
			}
			return true;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0001B42C File Offset: 0x0001962C
		public static string smethod_1(string string_0)
		{
			string text = "";
			try
			{
				string text2 = GClass6.smethod_20("http://romaji.me/romaji.cgi", new NameValueCollection
				{
					{
						"type",
						"2"
					},
					{
						"unknown_text",
						string_0
					},
					{
						"text",
						string_0
					}
				});
				if (text2 == null)
				{
					return string_0;
				}
				foreach (XElement xelement in XDocument.Parse(text2).Descendants("ruby"))
				{
					XElement xelement2 = xelement.Descendants("rb").First<XElement>();
					XElement xelement3 = xelement.Descendants("rt").First<XElement>();
					if (xelement3.IsEmpty)
					{
						text = text + xelement2.Value + " ";
					}
					else
					{
						text = text + xelement3.Value + " ";
					}
				}
			}
			catch
			{
			}
			return text.Trim();
		}

		// Token: 0x04000017 RID: 23
		private const char char_0 = 'ゟ';

		// Token: 0x04000018 RID: 24
		private const char char_1 = '぀';

		// Token: 0x04000019 RID: 25
		private const char char_2 = '龿';

		// Token: 0x0400001A RID: 26
		private const char char_3 = '一';

		// Token: 0x0400001B RID: 27
		private const char char_4 = 'ヿ';

		// Token: 0x0400001C RID: 28
		private const char char_5 = '゠';
	}
}

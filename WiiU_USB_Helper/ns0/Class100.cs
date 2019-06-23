using System;
using System.Globalization;
using System.Text;

namespace ns0
{
	// Token: 0x0200012F RID: 303
	internal static class Class100
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x00034E28 File Offset: 0x00033028
		private static string smethod_0(this string string_1)
		{
			string text = string_1.Normalize(NormalizationForm.FormD);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c in text)
			{
				if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
		}

		// Token: 0x040004E2 RID: 1250
		public static string string_0;
	}
}

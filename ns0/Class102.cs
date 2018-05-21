// Decompiled with JetBrains decompiler
// Type: ns0.Class102
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Globalization;
using System.Text;

namespace ns0
{
  internal static class Class102
  {
    public static string string_0;

    private static string smethod_0(this string string_1)
    {
      string str = string_1.Normalize(NormalizationForm.FormD);
      StringBuilder stringBuilder = new StringBuilder();
      foreach (char ch in str)
      {
        if (CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
          stringBuilder.Append(ch);
      }
      return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }
  }
}

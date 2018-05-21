// Decompiled with JetBrains decompiler
// Type: ns0.GClass10
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Specialized;
using System.Linq;
using System.Xml.Linq;

namespace ns0
{
  public static class GClass10
  {
    private const char char_0 = 'ゟ';
    private const char char_1 = '\x3040';
    private const char char_2 = '龿';
    private const char char_3 = '一';
    private const char char_4 = 'ヿ';
    private const char char_5 = '゠';

    public static bool smethod_0(string string_0)
    {
      string source1 = string_0;
      Func<char, bool> func1 = (Func<char, bool>) (char_0 =>
      {
        if (char_0 >= '\x3040')
          return char_0 <= 'ゟ';
        return false;
      });
      Func<char, bool> predicate1;
      if (!source1.Any<char>(predicate1))
      {
        string source2 = string_0;
        Func<char, bool> func2 = (Func<char, bool>) (char_0 =>
        {
          if (char_0 >= '゠')
            return char_0 <= 'ヿ';
          return false;
        });
        Func<char, bool> predicate2;
        if (!source2.Any<char>(predicate2))
          return string_0.Any<char>((Func<char, bool>) (char_0 =>
          {
            if (char_0 >= '一')
              return char_0 <= '龿';
            return false;
          }));
      }
      return true;
    }

    public static string smethod_1(string string_0)
    {
      string str = "";
      try
      {
        string text = GClass6.smethod_20("http://romaji.me/romaji.cgi", new NameValueCollection()
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
        if (text == null)
          return string_0;
        foreach (XElement descendant in XDocument.Parse(text).Descendants((XName) "ruby"))
        {
          XElement xelement1 = descendant.Descendants((XName) "rb").First<XElement>();
          XElement xelement2 = descendant.Descendants((XName) "rt").First<XElement>();
          str = !xelement2.IsEmpty ? str + xelement2.Value + " " : str + xelement1.Value + " ";
        }
      }
      catch
      {
      }
      return str.Trim();
    }
  }
}

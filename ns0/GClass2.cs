// Decompiled with JetBrains decompiler
// Type: ns0.GClass2
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper.Emulators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ns0
{
  public static class GClass2
  {
    internal static void smethod_0()
    {
      try
      {
        string str1 = Path.Combine(GClass88.CachePath, "packs");
        Directory.CreateDirectory(str1);
        GClass27.smethod_7("https://github.com/slashiee/cemu_graphic_packs/archive/master.zip", str1);
        string[] files = Directory.GetFiles(str1, "*", System.IO.SearchOption.AllDirectories);
        string str2 = Path.Combine(new Cemu((GClass30) null, false).String_4, "graphicPacks");
        Directory.CreateDirectory(str2);
        foreach (string path in ((IEnumerable<string>) files).Where<string>((Func<string, bool>) (string_0 => string_0.Contains("rules.txt"))))
        {
          string directoryName = Path.GetDirectoryName(path);
          string str3 = Path.Combine(str2, new DirectoryInfo(Path.GetDirectoryName(path)).Name);
          if (Directory.Exists(Path.Combine(str2, str3)))
            Directory.Delete(str3, true);
          try
          {
            FileSystem.MoveDirectory(directoryName, str3);
          }
          catch
          {
          }
        }
      }
      catch
      {
      }
    }
  }
}

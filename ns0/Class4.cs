// Decompiled with JetBrains decompiler
// Type: ns0.Class4
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace ns0
{
  internal static class Class4
  {
    public static void smethod_0(GClass30 gclass30_0, IPAddress ipaddress_0, string string_0)
    {
      if (gclass30_0.TitleId.IdType != GEnum1.const_1)
        throw new Exception("You can only backup game saves!");
      if (gclass30_0.System != GEnum3.const_1)
        throw new Exception("Save backup is only compatible with Wii U Games");
      Class60 class60 = new Class60(ipaddress_0.ToString(), "anonymous", "");
      if (!class60.method_4("/storage_usb/usr/save/00050000/").Contains(gclass30_0.TitleId.High.ToLower()))
        throw new GException0();
      class60.method_5("/storage_usb/usr/save/00050000/" + gclass30_0.TitleId.High.ToLower() + "/", string_0);
    }

    public static void smethod_1(GClass30 gclass30_0, IPAddress ipaddress_0, string string_0)
    {
      if (gclass30_0.TitleId.IdType != GEnum1.const_1)
        throw new Exception("You can only backup game saves!");
      if (gclass30_0.System != GEnum3.const_1)
        throw new Exception("Save backup is only compatible with Wii U Games");
      using (FileStream fileStream = System.IO.File.Open(string_0, FileMode.Open))
      {
        using (ZipArchive zipArchive_0 = new ZipArchive((Stream) fileStream, ZipArchiveMode.Read))
          new Class60(ipaddress_0.ToString(), "anonymous", "").method_15("/storage_usb/usr/save/00050000/" + gclass30_0.TitleId.High.ToLower() + "/", zipArchive_0);
      }
    }
  }
}

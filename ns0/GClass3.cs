// Decompiled with JetBrains decompiler
// Type: ns0.GClass3
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ns0
{
  public static class GClass3
  {
    private static readonly string string_0 = "emuExceptions";
    private static List<string> list_0 = new List<string>();

    public static void smethod_0(GClass30 gclass30_0)
    {
      if (!GClass3.list_0.Contains(gclass30_0.TitleId.IdRaw))
        GClass3.list_0.Add(gclass30_0.TitleId.IdRaw);
      GClass3.smethod_2();
    }

    public static void smethod_1(GClass30 gclass30_0)
    {
      if (GClass3.list_0.Contains(gclass30_0.TitleId.IdRaw))
        GClass3.list_0.Remove(gclass30_0.TitleId.IdRaw);
      GClass3.smethod_2();
    }

    private static void smethod_2()
    {
      using (FileStream fileStream = File.Create(Path.Combine(GClass88.CachePath, GClass3.string_0)))
        new BinaryFormatter().Serialize((Stream) fileStream, (object) GClass3.list_0);
    }

    public static bool smethod_3(GClass30 gclass30_0)
    {
      return GClass3.list_0.Contains(gclass30_0.TitleId.IdRaw);
    }

    internal static void smethod_4()
    {
      try
      {
        using (FileStream fileStream = File.Open(Path.Combine(GClass88.CachePath, GClass3.string_0), FileMode.Open))
          GClass3.list_0 = (List<string>) new BinaryFormatter().Deserialize((Stream) fileStream);
      }
      catch
      {
        GClass3.list_0 = new List<string>();
      }
    }
  }
}

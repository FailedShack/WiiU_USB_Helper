// Decompiled with JetBrains decompiler
// Type: ns0.GClass24
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.IO;
using System.IO.Compression;

namespace ns0
{
  public static class GClass24
  {
    public static void UnZip_Process(this ZipArchive zipArchive_0, string Zip_Output_Dir, bool bool_0)
    {
      if (!bool_0)
      {
        zipArchive_0.ExtractToDirectory(Zip_Output_Dir);
      }
      else
      {
        foreach (ZipArchiveEntry entry in zipArchive_0.Entries)
        {
          try
          {
            Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(Zip_Output_Dir, entry.FullName)));
          }
          catch
          {
          }
        }
        foreach (ZipArchiveEntry entry in zipArchive_0.Entries)
        {
          string str = Path.Combine(Zip_Output_Dir, entry.FullName);
          if (entry.Name == "")
            Directory.CreateDirectory(Path.GetDirectoryName(str));
          else
            entry.ExtractToFile(str, true);
        }
      }
    }
  }
}

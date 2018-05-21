// Decompiled with JetBrains decompiler
// Type: NusHelper.Server.DbRow
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

namespace NusHelper.Server
{
  public sealed class DbRow
  {
    public bool DiscOnly { get; set; }

    public string EshopId { get; set; }

    public string IconUrl { get; set; }

    public string Name { get; set; }

    public Platform Platform { get; set; }

    public bool PreLoad { get; set; }

    public string ProductCode { get; set; }

    public string Region { get; set; }

    public DataSize Size { get; set; }

    public TitleId TitleId { get; set; }

    public string Version { get; set; }
  }
}

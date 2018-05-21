// Decompiled with JetBrains decompiler
// Type: ns0.GClass101
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;

namespace ns0
{
  public abstract class GClass101
  {
    protected ushort ushort_1;

    public uint ContentId { get; set; }

    public string String_0
    {
      get
      {
        return this.ContentId.ToString("x8");
      }
    }

    public abstract byte[] Hash { get; set; }

    public bool Boolean_0
    {
      get
      {
        return ((int) this.ushort_1 & 2) > 0;
      }
    }

    public ushort Index { get; set; }

    public DataSize Size { get; set; }

    public GEnum6 GEnum6_0
    {
      get
      {
        return (GEnum6) this.ushort_1;
      }
      set
      {
        this.ushort_1 = (ushort) value;
      }
    }
  }
}

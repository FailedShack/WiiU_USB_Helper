// Decompiled with JetBrains decompiler
// Type: NusHelper.TitleId
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using ns0;
using System;

namespace NusHelper
{
  public class TitleId : IEquatable<TitleId>
  {
    public readonly string IdRaw;
    private const string DlcLow3DS = "0004008C";
    private const string DlcLowSwitch = null;
    private const string DlcLowWiiu = "0005000C";
    private const string GameLow3DS = "00040000";
    private const string GameLowDsi = "00048004";
    private const string GameLowSwitch = null;
    private const string GameLowWii = "00010001";
    private const string GameLowWiiu = "00050000";
    private const string UpdateLow3DS = "0004000E";
    private const string UpdateLowSwitch = null;
    private const string UpdateLowWiiu = "0005000E";
    private readonly GEnum3 System;

    public TitleId(string id)
    {
      id = id.ToUpper();
      this.IdRaw = id.Substring(0, 16);
      string string_0 = id.Substring(0, 8);
      // ISSUE: reference to a compiler-generated method
      switch (Class200.smethod_0(string_0))
      {
        case 307253171:
          if (string_0 == "0005000C")
          {
            this.System = GEnum3.const_1;
            this.IdType = GEnum1.const_2;
            break;
          }
          goto default;
        case 407918885:
          if (string_0 == "0005000E")
          {
            this.System = GEnum3.const_1;
            this.IdType = GEnum1.const_0;
            break;
          }
          goto default;
        case 769560898:
          if (string_0 == "0004000E")
          {
            this.System = GEnum3.const_0;
            this.IdType = GEnum1.const_0;
            break;
          }
          goto default;
        case 792022325:
          if (string_0 == "00010001")
          {
            this.System = GEnum3.const_3;
            this.IdType = GEnum1.const_1;
            break;
          }
          goto default;
        case 2583915261:
          if (string_0 == "00048004")
          {
            this.System = GEnum3.const_0;
            this.IdType = GEnum1.const_4;
            break;
          }
          goto default;
        case 3135102009:
          if (string_0 == "00040000")
          {
            this.System = GEnum3.const_0;
            this.IdType = GEnum1.const_3;
            break;
          }
          goto default;
        case 3276788566:
          if (string_0 == "00050000")
          {
            this.System = GEnum3.const_1;
            this.IdType = GEnum1.const_1;
            break;
          }
          goto default;
        case 3622932888:
          if (string_0 == "0004008C")
          {
            this.System = GEnum3.const_0;
            this.IdType = GEnum1.const_2;
            break;
          }
          goto default;
        default:
          this.System = GEnum3.const_1;
          this.IdType = GEnum1.const_5;
          break;
      }
      this.Low = id.Substring(0, 8);
      this.High = id.Substring(8, 8);
    }

    public TitleId FullDlc
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return new TitleId("0004008C" + this.High);
          case GEnum3.const_1:
            return new TitleId("0005000C" + this.High);
          case GEnum3.const_2:
            throw new NotImplementedException();
          default:
            throw new NotImplementedException();
        }
      }
    }

    public TitleId FullGame
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return new TitleId((this.IdType != GEnum1.const_4 ? "00040000" : "00048004") + this.High);
          case GEnum3.const_1:
            return new TitleId("00050000" + this.High);
          case GEnum3.const_2:
            throw new NotImplementedException();
          case GEnum3.const_3:
            return new TitleId("00010001" + this.High);
          default:
            throw new NotImplementedException();
        }
      }
    }

    public TitleId FullUpdate
    {
      get
      {
        switch (this.System)
        {
          case GEnum3.const_0:
            return new TitleId("0004000E" + this.High);
          case GEnum3.const_1:
            return new TitleId("0005000E" + this.High);
          case GEnum3.const_2:
            throw new NotImplementedException();
          default:
            throw new NotImplementedException();
        }
      }
    }

    public GEnum1 IdType { get; }

    public static explicit operator TitleId(string id)
    {
      return new TitleId(id);
    }

    public static implicit operator string(TitleId id)
    {
      return id.IdRaw;
    }

    public bool Equals(TitleId other)
    {
      if (other != null)
        return other.IdRaw == this.IdRaw;
      return false;
    }

    public override bool Equals(object other)
    {
      if (other is TitleId)
        return ((TitleId) other).IdRaw == this.IdRaw;
      return false;
    }

    public override int GetHashCode()
    {
      return this.IdRaw.GetHashCode();
    }

    public string ToSplitString()
    {
      return this.IdRaw.Insert(8, "-");
    }

    public override string ToString()
    {
      return this.IdRaw;
    }

    internal string High { get; set; }

    internal string Low { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.Class72
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using NusHelper;
using NusHelper.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ns0
{
  internal class Class72
  {
    private readonly string string_0;
    private readonly string string_1;
    private readonly string string_2;
    private readonly string string_3;
    private readonly string string_4;

    public Class72(string string_5, string string_6, string string_7, string string_8, string string_9)
    {
      this.string_4 = string_5;
      this.string_2 = string_7;
      this.string_3 = string_6;
      this.string_0 = string_8;
      this.string_1 = string_9;
    }

    public List<Class72.Class74> method_0(string string_5)
    {
      if (string_5 == "")
        return new List<Class72.Class74>();
      return JsonConvert.DeserializeObject<List<Class72.Class74>>(string_5).Where<Class72.Class74>((Func<Class72.Class74, bool>) (class74_0 =>
      {
        if (!string.IsNullOrEmpty(class74_0.name) && !string.IsNullOrEmpty(class74_0.region))
          return !string.IsNullOrEmpty(class74_0.titleID);
        return false;
      })).ToList<Class72.Class74>();
    }

    private GClass32 method_1(TitleId titleId_0, string string_5, string string_6, string string_7, DataSize dataSize_0)
    {
      GClass32 gclass32 = new GClass32(string_5, titleId_0, "ALL", (byte[]) null, dataSize_0, (List<GClass33>) null, "0", "CTR-P-CTAP", "", "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/", Platform.Unknown, GEnum3.const_0);
      gclass32.CfwOnly = true;
      gclass32.TicketArray = GClass99.smethod_0(titleId_0.IdRaw, string_7, 0);
      gclass32.byte_0 = string_6.smethod_6();
      gclass32.Ticket = GClass99.smethod_7(gclass32.TicketArray, GEnum3.const_0);
      gclass32.Ticket.Byte_0 = string_6.smethod_6();
      return gclass32;
    }

    public void method_2()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class72.Class75 class75 = new Class72.Class75();
      // ISSUE: reference to a compiler-generated field
      class75.class72_0 = this;
      // ISSUE: reference to a compiler-generated field
      class75.frmWait_0 = new FrmWait("USB Helper is preparing the ticket cache", true);
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(class75.method_0));
      // ISSUE: reference to a compiler-generated field
      class75.frmWait_0.TopMost = true;
      // ISSUE: reference to a compiler-generated field
      int num1 = (int) class75.frmWait_0.ShowDialog();
      if (this.string_0 != "")
      {
        List<Class72.Class73> source = JsonConvert.DeserializeObject<List<Class72.Class73>>(this.string_0);
        foreach (Class72.Class73 class73 in source.Where<Class72.Class73>((Func<Class72.Class73, bool>) (class73_0 =>
        {
          if (class73_0.encTitleKey != null && class73_0.titleID != null)
            return new TitleId(class73_0.titleID).IdType == GEnum1.const_0;
          return false;
        })))
        {
          TitleId key = new TitleId(class73.titleID);
          if (GClass28.dictionary_3.ContainsKey(key))
          {
            for (int index = 0; index < GClass28.dictionary_3[key].Count; ++index)
            {
              GClass80.GStruct5 gstruct5 = GClass28.dictionary_3[key][index];
              GClass28.dictionary_3[key][index] = new GClass80.GStruct5()
              {
                dataSize_0 = gstruct5.dataSize_0,
                titleId_0 = gstruct5.titleId_0,
                string_0 = gstruct5.string_0,
                string_2 = class73.titleKey,
                string_1 = class73.encTitleKey
              };
            }
          }
        }
        foreach (Class72.Class73 class73 in source.Where<Class72.Class73>((Func<Class72.Class73, bool>) (class73_0 =>
        {
          if (class73_0.encTitleKey != null && class73_0.titleID != null)
            return new TitleId(class73_0.titleID).IdType == GEnum1.const_2;
          return false;
        })))
        {
          TitleId key = new TitleId(class73.titleID);
          if (GClass28.dictionary_1.ContainsKey(key))
          {
            GClass80.GStruct4 gstruct4 = GClass28.dictionary_1[key];
            string string_7 = HttpUtility.HtmlDecode(class73.name.Trim()).Replace("\n", " ");
            string str = class73.region.Trim();
            TitleId titleId_1 = key;
            string string_8 = str;
            // ISSUE: variable of the null type
            __Null local = null;
            DataSize dataSize0 = gstruct4.dataSize_0;
            string string_9 = "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/";
            int num2 = 0;
            GClass31 gclass31_1 = new GClass31(string_7, titleId_1, string_8, (byte[]) local, dataSize0, string_9, (GEnum3) num2);
            gclass31_1.CfwOnly = true;
            gclass31_1.TicketArray = GClass99.smethod_0((string) key, class73.encTitleKey, 1);
            gclass31_1.byte_0 = class73.titleKey.smethod_6();
            GClass31 gclass31_2 = gclass31_1;
            gclass31_2.Ticket = GClass99.smethod_7(gclass31_2.TicketArray, GEnum3.const_0);
            gclass31_2.Ticket.Byte_0 = class73.titleKey.smethod_6();
            GClass28.list_6.Add(gclass31_2);
          }
        }
        foreach (Class72.Class73 class73 in source.Where<Class72.Class73>((Func<Class72.Class73, bool>) (class73_0 =>
        {
          if (class73_0.encTitleKey != null)
            return class73_0.titleID != null;
          return false;
        })))
        {
          TitleId index = new TitleId(class73.titleID);
          if (index.IdRaw == "0004009B00010202")
            GClass28.list_0.Add(this.method_1(index, "ARC1", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "0004009B00010402")
            GClass28.list_0.Add(this.method_1(index, "ARC2", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "0004009B00014002")
            GClass28.list_0.Add(this.method_1(index, "ARC3", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "0004009B00014102")
            GClass28.list_0.Add(this.method_1(index, "ARC4", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "0004009B00014202")
            GClass28.list_0.Add(this.method_1(index, "ARC5", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "0004009B00014302")
            GClass28.list_0.Add(this.method_1(index, "ARC6", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "000400DB00010302")
            GClass28.list_0.Add(this.method_1(index, "ARC7", class73.titleKey, class73.encTitleKey, new DataSize(1UL)));
          if (index.IdRaw == "0004009B00014002")
            GClass28.gclass32_0 = this.method_1(index, "Shared Font", class73.titleKey, class73.encTitleKey, new DataSize(1466880UL));
          if ((index.IdType == GEnum1.const_3 || index.IdType == GEnum1.const_4) && GClass28.dictionary_2.ContainsKey(index))
          {
            DbRow dbRow = GClass28.dictionary_2[index];
            string str = HttpUtility.HtmlDecode(class73.name.Trim()).Replace("\n", " ");
            string string_8 = class73.region.Trim();
            List<GClass33> list_2 = new List<GClass33>();
            if (GClass28.dictionary_3.ContainsKey(new TitleId((string) index.FullUpdate)))
            {
              foreach (GClass80.GStruct5 gstruct5 in GClass28.dictionary_3[index.FullUpdate])
              {
                if (gstruct5.string_2 != null && gstruct5.string_1 != null)
                {
                  GClass33 gclass33_1 = new GClass33(str, gstruct5.titleId_0, string_8, (byte[]) null, gstruct5.dataSize_0, gstruct5.string_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_0);
                  gclass33_1.CfwOnly = true;
                  GClass33 gclass33_2 = gclass33_1;
                  gclass33_2.TicketArray = GClass99.smethod_0((string) gstruct5.titleId_0, gstruct5.string_1, int.Parse(gstruct5.string_0));
                  gclass33_2.byte_0 = gstruct5.string_2.smethod_6();
                  gclass33_2.Ticket = GClass99.smethod_7(gclass33_2.TicketArray, GEnum3.const_0);
                  gclass33_2.Ticket.Byte_0 = gstruct5.string_2.smethod_6();
                  list_2.Add(gclass33_2);
                }
              }
            }
            GClass32 gclass32_1 = new GClass32(str, index, dbRow.Region, (byte[]) null, dbRow.Size, list_2, dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, "http://ccs.cdn.c.shop.nintendowifi.net/ccs/download/", dbRow.Platform, GEnum3.const_0);
            gclass32_1.CfwOnly = true;
            GClass32 gclass32_2 = gclass32_1;
            gclass32_2.TicketArray = GClass99.smethod_0(index.IdRaw, class73.encTitleKey, 1);
            gclass32_2.byte_0 = class73.titleKey.smethod_6();
            gclass32_2.Ticket = GClass99.smethod_7(gclass32_2.TicketArray, GEnum3.const_0);
            gclass32_2.Ticket.Byte_0 = class73.titleKey.smethod_6();
            GClass28.dictionary_0.Add(index, gclass32_2);
          }
        }
      }
      if (!(this.string_1 != ""))
        return;
      foreach (Class72.Class74 class74 in this.method_0(this.string_1))
      {
        TitleId index = new TitleId(class74.titleID);
        if (GClass28.dictionary_2.ContainsKey(index))
        {
          DbRow dbRow = GClass28.dictionary_2[index];
          GClass32 gclass32_1 = new GClass32(class74.name, index, dbRow.Region, (byte[]) null, dbRow.Size, new List<GClass33>(), dbRow.EshopId, dbRow.ProductCode, dbRow.IconUrl, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", dbRow.Platform, GEnum3.const_3);
          gclass32_1.CfwOnly = true;
          GClass32 gclass32_2 = gclass32_1;
          byte[] numArray = GClass99.smethod_1((string) dbRow.TitleId, class74.titleKey, 0);
          gclass32_2.TicketArray = numArray;
          gclass32_2.Ticket = GClass99.smethod_7(gclass32_2.TicketArray, GEnum3.const_3);
          GClass28.dictionary_0.Add(dbRow.TitleId, gclass32_2);
        }
      }
    }

    internal class Class73
    {
      public string encTitleKey { get; set; }

      public string name { get; set; }

      public string region { get; set; }

      public string serial { get; set; }

      public object size { get; set; }

      public string titleID { get; set; }

      public string titleKey { get; set; }
    }

    internal class Class74
    {
      public string name { get; set; }

      public string region { get; set; }

      public string ticket { get; set; }

      public string titleID { get; set; }

      public string titleKey { get; set; }
    }
  }
}

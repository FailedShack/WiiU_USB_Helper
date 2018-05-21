// Decompiled with JetBrains decompiler
// Type: ns0.GClass26
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Telerik.WinControls;
using WIIU_Downloader.Properties;

namespace ns0
{
  public static class GClass26
  {
    private static string string_0;
    private static string string_1;
    private static string string_2;

    public static string DbVersionCode { get; } = "";

    public static void smethod_0(string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, bool bool_0, byte[] byte_0, byte[] byte_1, byte[] byte_2, GStruct2 gstruct2_0, Action<int> action_0 = null)
    {
      ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((object_0, x509Certificate_0, x509Chain_0, sslPolicyErrors_0) => true);
      ServicePointManager.DefaultConnectionLimit = 8;
      GClass26.string_0 = string_5;
      GClass26.string_1 = string_6;
      GClass26.string_2 = string_7;
      GClass88.smethod_13(GClass26.string_0);
      Directory.CreateDirectory(GClass17.string_0);
      Class67.RootDomain = string_8;
      GClass28.string_5 = Class67.smethod_22();
      GClass28.list_2 = Class67.smethod_2();
      GClass28.string_4 = string_4;
      GClass28.dictionary_0.Clear();
      GClass28.list_6.Clear();
      GClass28.dictionary_3.Clear();
      GClass28.dictionary_1.Clear();
      GClass28.dictionary_2.Clear();
      GClass30.smethod_0();
      Class67.smethod_13();
      Class67.smethod_20("out/games.json");
      Class67.smethod_20("out/customs.json");
      Class67.smethod_20("out/injections.json");
      Class67.smethod_20("out/games3ds.json");
      Class67.smethod_20("out/gamesWii.json");
      Class67.smethod_21("out/updates.json");
      Class67.smethod_21("out/updates3ds.json");
      Class67.smethod_19("out/dlcs.json");
      Class67.smethod_19("out/dlcs3ds.json");
      if (!bool_0)
      {
        try
        {
          GClass26.smethod_5(byte_0);
        }
        catch
        {
          Settings.Default.TicketsPath = "";
          Settings.Default.TicketsPath3DS = "";
          Settings.Default.TicketsPathWii = "";
          int num = (int) RadMessageBox.Show("The application was unable to parse the specified archive. The app will now restart. Please specify another archive or use the title key site instead (recommended)");
          Settings.Default.Save();
          Application.Restart();
          return;
        }
      }
      else
      {
        string string_4_1 = "";
        string string_5_1 = "";
        string string_6_1 = "";
        if (byte_0 != null)
          string_4_1 = Encoding.UTF8.GetString(byte_0);
        if (byte_1 != null)
          string_5_1 = Encoding.UTF8.GetString(byte_1);
        if (byte_2 != null)
          string_6_1 = Encoding.UTF8.GetString(byte_2);
        GClass26.smethod_6(string_4_1, string_5_1, string_6_1);
      }
      if (GClass28.dictionary_0.Count == 0)
        throw new Exception("No titles available. Please check your ticket source.");
      foreach (GClass32 gclass32 in GClass28.dictionary_0.Values)
      {
        foreach (GClass31 gclass31 in GClass28.list_6)
        {
          if (!(gclass32.TitleId.High != gclass31.TitleId.High) && gclass32.System == gclass31.System)
          {
            gclass31.Name = gclass32.Name;
            gclass32.Dlc = gclass31;
            break;
          }
        }
      }
      if (GClass88.smethod_1("lasttitles"))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        GClass28.NewTitles = GClass28.dictionary_0.Values.Where<GClass32>(new Func<GClass32, bool>(new GClass26.Class34()
        {
          string_0 = GClass88.smethod_7("lasttitles")
        }.method_0)).ToList<GClass32>();
      }
      GClass88.smethod_10("lasttitles", GClass28.dictionary_0.Values.Select<GClass32, string>((Func<GClass32, string>) (gclass32_0 => gclass32_0.TitleId.IdRaw)).ToArray<string>());
      if (GClass88.smethod_1("lastUpdates"))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        GClass28.NewUpdates = GClass28.dictionary_0.Values.Where<GClass32>((Func<GClass32, bool>) (gclass32_0 =>
        {
          if (gclass32_0.Boolean_5)
            return gclass32_0.Boolean_3;
          return false;
        })).Select<GClass32, GClass33>((Func<GClass32, GClass33>) (gclass32_0 => gclass32_0.Updates.Last<GClass33>())).Where<GClass33>(new Func<GClass33, bool>(new GClass26.Class35()
        {
          string_0 = GClass88.smethod_7("lastUpdates")
        }.method_0)).ToList<GClass33>();
      }
      GClass88.smethod_10("lastUpdates", GClass28.dictionary_0.Values.Where<GClass32>((Func<GClass32, bool>) (gclass32_0 =>
      {
        if (!gclass32_0.Boolean_3)
          return false;
        if (!gclass32_0.Boolean_5)
          return gclass32_0.Boolean_1;
        return true;
      })).Select<GClass32, string>((Func<GClass32, string>) (gclass32_0 => gclass32_0.Updates.Last<GClass33>().ToString())).ToArray<string>());
      try
      {
        GClass26.smethod_3((IEnumerable<DirectoryInfo>) new DirectoryInfo(Path.Combine(string_4, "DATA_3DS")).GetDirectories("*.*", System.IO.SearchOption.AllDirectories));
      }
      catch
      {
      }
      GClass26.smethod_1("http://wiiu.titlekeys.gq/rss");
      GClass26.smethod_1("http://3ds.titlekeys.gq/rss");
      GClass3.smethod_4();
      GClass28.dictionary_1.Clear();
      GClass28.dictionary_2.Clear();
      GClass28.dictionary_3.Clear();
      GClass28.string_5 = (string[]) null;
    }

    private static void smethod_1(string string_4)
    {
      try
      {
        string xml = new GClass78().method_7(string_4, 7200);
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xml);
        foreach (XmlNode xmlNode in xmlDocument.GetElementsByTagName("description"))
        {
          string innerXml = xmlNode.InnerXml;
          if (!(innerXml == "<![CDATA[Newest Keys]]>"))
          {
            TitleId key = new TitleId(innerXml.Substring(9, 16));
            if (GClass28.dictionary_0.ContainsKey(key))
              GClass28.list_3.Add(GClass28.dictionary_0[key]);
          }
        }
      }
      catch
      {
      }
    }

    private static void smethod_2(IEnumerable<DirectoryInfo> ienumerable_0)
    {
      foreach (DirectoryInfo directoryInfo in ienumerable_0.Where<DirectoryInfo>((Func<DirectoryInfo, bool>) (directoryInfo_0 =>
      {
        if (directoryInfo_0.Name.Length > 16 && directoryInfo_0.Name.Contains("["))
          return directoryInfo_0.Name.Contains("]");
        return false;
      })))
      {
        try
        {
          int startIndex = directoryInfo.Name.IndexOf('[') + 1;
          string id = directoryInfo.Name.Substring(startIndex, directoryInfo.Name.IndexOf(']') - startIndex);
          if (id.Length == 16)
          {
            TitleId titleId = new TitleId(id);
            if (titleId.IdType != GEnum1.const_3)
            {
              if (titleId.IdType != GEnum1.const_1)
                continue;
            }
            if (!GClass28.list_1.Contains(titleId))
              GClass28.list_1.Add(titleId);
          }
        }
        catch
        {
        }
      }
    }

    private static void smethod_3(IEnumerable<DirectoryInfo> ienumerable_0)
    {
      foreach (DirectoryInfo directoryInfo in ienumerable_0.Where<DirectoryInfo>((Func<DirectoryInfo, bool>) (directoryInfo_0 =>
      {
        ulong result;
        if (directoryInfo_0.Name.Length == 16 && ulong.TryParse(directoryInfo_0.Name, NumberStyles.HexNumber, (IFormatProvider) CultureInfo.CurrentCulture, out result) && !directoryInfo_0.FullName.Contains("EMULATORS"))
          return !directoryInfo_0.FullName.Contains("SAVES");
        return false;
      })))
      {
        TitleId index = new TitleId(directoryInfo.Name);
        GClass30 gclass30 = (GClass30) null;
        try
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass26.Class36 class36 = new GClass26.Class36();
          switch (index.IdType)
          {
            case GEnum1.const_0:
              GClass100 gclass100 = GClass100.smethod_0(Path.Combine(directoryInfo.FullName, "title.tmd"), GEnum3.const_1);
              // ISSUE: reference to a compiler-generated field
              class36.ushort_0 = gclass100.TitleVersion;
              // ISSUE: reference to a compiler-generated method
              gclass30 = (GClass30) GClass28.dictionary_0[index.FullGame].Updates.First<GClass33>(new Func<GClass33, bool>(class36.method_0));
              break;
            case GEnum1.const_1:
              gclass30 = (GClass30) GClass28.dictionary_0[index];
              break;
            case GEnum1.const_2:
              gclass30 = (GClass30) GClass28.dictionary_0[index.FullGame].Dlc;
              break;
            case GEnum1.const_3:
              gclass30 = (GClass30) GClass28.dictionary_0[index];
              break;
          }
        }
        catch
        {
          continue;
        }
        try
        {
          FileSystem.MoveDirectory(directoryInfo.FullName, gclass30.OutputPath);
        }
        catch
        {
        }
      }
    }

    private static void smethod_4(GStruct2 gstruct2_0)
    {
      try
      {
        new WebClient().DownloadStringAsync(new Uri(string.Format("{0}/telemetry.php?distribution_media={1}&os_revision={2}&app_version={3}", (object) Class67.String_3, (object) gstruct2_0.string_0, (object) gstruct2_0.string_1, (object) gstruct2_0.string_2)));
      }
      catch
      {
      }
    }

    private static void smethod_5(byte[] byte_0)
    {
      try
      {
        using (Stream stream = (Stream) new MemoryStream(byte_0))
        {
          using (IReader reader = ReaderFactory.Open(stream, (ReaderOptions) null))
          {
            char ch = reader.ArchiveType == ArchiveType.Zip ? '/' : '\\';
            while (reader.MoveToNextEntry())
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              GClass26.Class37 class37 = new GClass26.Class37();
              if (!reader.Entry.IsDirectory)
              {
                // ISSUE: reference to a compiler-generated field
                class37.string_0 = reader.Entry.Key.Split(new char[1]
                {
                  ch
                }, StringSplitOptions.RemoveEmptyEntries);
                // ISSUE: reference to a compiler-generated field
                if (class37.string_0.Length >= 4)
                {
                  // ISSUE: reference to a compiler-generated field
                  TitleId index = new TitleId(class37.string_0[2]);
                  if (GClass28.dictionary_2.ContainsKey(index.FullGame) && index.IdType != GEnum1.const_0 && !((IEnumerable<string>) GClass28.string_5).Contains<string>((string) index.FullGame))
                  {
                    byte[] buffer;
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                      reader.WriteEntryTo((Stream) memoryStream);
                      buffer = memoryStream.GetBuffer();
                    }
                    switch (index.IdType)
                    {
                      case GEnum1.const_2:
                        if (GClass28.dictionary_1.ContainsKey(index))
                        {
                          // ISSUE: reference to a compiler-generated field
                          GClass31 gclass31_1 = new GClass31("", index, class37.string_0[0], buffer, GClass28.dictionary_1[index].dataSize_0, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GEnum3.const_1);
                          gclass31_1.CfwOnly = true;
                          GClass31 gclass31_2 = gclass31_1;
                          GClass28.list_6.Add(gclass31_2);
                          continue;
                        }
                        break;
                      case GEnum1.const_5:
                        continue;
                    }
                    List<GClass33> list_2 = new List<GClass33>();
                    if (GClass28.dictionary_3.ContainsKey(new TitleId((string) index.FullUpdate)))
                    {
                      // ISSUE: reference to a compiler-generated method
                      list_2.AddRange(GClass28.dictionary_3[index.FullUpdate].Select<GClass80.GStruct5, GClass33>(new Func<GClass80.GStruct5, GClass33>(class37.method_0)));
                    }
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    GClass32 gclass32 = new GClass32(class37.string_0[1], index, class37.string_0[0], buffer, GClass28.dictionary_2[index].Size, list_2, GClass28.dictionary_2[index].EshopId, GClass28.dictionary_2[index].ProductCode, GClass28.dictionary_2[index].IconUrl, "http://ccs.cdn.wup.shop.nintendo.net/ccs/download/", GClass28.dictionary_2[index].Platform, GEnum3.const_1);
                    if (GClass28.dictionary_2[index.FullGame].ProductCode.Length < 6)
                      Console.WriteLine(string.Format("{0} {1} {2} has bad product code.", (object) gclass32.Name, (object) gclass32.TitleId, (object) gclass32.EshopId));
                    if (GClass28.dictionary_2[index.FullGame].IconUrl == "#N/A")
                      Console.WriteLine(string.Format("{0} {1} {2} has bad icon url.", (object) gclass32.Name, (object) gclass32.TitleId, (object) gclass32.EshopId));
                    if (!GClass28.dictionary_0.ContainsKey(gclass32.TitleId))
                      GClass28.dictionary_0.Add(gclass32.TitleId, gclass32);
                  }
                }
              }
            }
          }
        }
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    private static void smethod_6(string string_4, string string_5, string string_6)
    {
      new Class72(GClass26.string_1, GClass26.string_2, string_4, string_5, string_6).method_2();
    }
  }
}

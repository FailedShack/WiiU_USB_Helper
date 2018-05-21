// Decompiled with JetBrains decompiler
// Type: ns0.Class67
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Newtonsoft.Json;
using NusHelper.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
  internal static class Class67
  {
    private static readonly List<string> list_0 = new List<string>();
    private static Dictionary<string, IPAddress> dictionary_0 = new Dictionary<string, IPAddress>();
    private static object object_0 = new object();
    private static int int_0 = 0;
    private static ZipArchive zipArchive_0;
    private const string string_1 = "https://";

    public static string RootDomain { get; set; } = "wiiuusbhelper.com";

    public static string String_0
    {
      get
      {
        return "https://application." + Class67.RootDomain;
      }
    }

    public static string String_1
    {
      get
      {
        return "https://cloud." + Class67.RootDomain;
      }
    }

    public static string String_2
    {
      get
      {
        return "https://cdn." + Class67.RootDomain;
      }
    }

    public static string String_3
    {
      get
      {
        return "https://registration." + Class67.RootDomain;
      }
    }

    public static string String_4
    {
      get
      {
        return "https://support." + Class67.RootDomain;
      }
    }

    private static string String_5
    {
      get
      {
        return string.Format("{0}/res/db/datav6.enc", (object) Class67.String_2);
      }
    }

    public static List<GClass90> smethod_0()
    {
      try
      {
        return JsonConvert.DeserializeObject<List<GClass90>>(new GClass78().method_6(string.Format("{0}/getFaq.php", (object) Class67.String_4)));
      }
      catch
      {
        return new List<GClass90>();
      }
    }

    public static string smethod_1(string string_2, int int_1)
    {
      return string.Format("{0}/proxy.php?url=", (object) Class67.String_0) + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_2)) + "&cache=" + int_1.ToString();
    }

    public static List<string> smethod_2()
    {
      try
      {
        return new List<string>((IEnumerable<string>) new GClass78().method_6(string.Format("{0}/res/db/forceCFW.txt", (object) Class67.String_2)).ToUpper().Split(new string[1]
        {
          Environment.NewLine
        }, StringSplitOptions.RemoveEmptyEntries));
      }
      catch
      {
        return new List<string>();
      }
    }

    internal static void smethod_3(GClass95 gclass95_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class67.Class68 class68 = new Class67.Class68();
      // ISSUE: reference to a compiler-generated field
      class68.gclass95_0 = gclass95_0;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Class67.Class69 class69 = new Class67.Class69();
        // ISSUE: reference to a compiler-generated field
        class69.class68_0 = class68;
        // ISSUE: reference to a compiler-generated field
        class69.frmWait_0 = new FrmWait("USB Helper is fetching some additional files...", true);
        WebClient webClient = new WebClient();
        // ISSUE: reference to a compiler-generated method
        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(class69.method_0);
        // ISSUE: reference to a compiler-generated method
        webClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(class69.method_1);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        webClient.DownloadDataAsync(new Uri(class69.class68_0.gclass95_0.String_0));
        // ISSUE: reference to a compiler-generated field
        int num = (int) class69.frmWait_0.ShowDialog();
      }
      catch
      {
      }
    }

    internal static void smethod_4()
    {
      if (GClass27.smethod_2("xinput1_3.dll") && (!Environment.Is64BitOperatingSystem || GClass27.smethod_3("xinput1_3.dll")))
        return;
      Class67.smethod_7("dxwebsetup.exe");
    }

    private static void smethod_5(string string_2)
    {
      try
      {
        GClass6.smethod_6(string_2);
      }
      catch
      {
      }
    }

    internal static void smethod_6()
    {
      Class67.smethod_8("msvcr120.dll", "vcredist_x86.exe", "vcredist_x64.exe");
    }

    internal static void smethod_7(string string_2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class67.Class70 class70 = new Class67.Class70();
      // ISSUE: reference to a compiler-generated field
      class70.string_0 = Path.Combine(Path.GetTempPath(), string_2);
      // ISSUE: reference to a compiler-generated field
      GClass27.smethod_9(string.Format("{0}/res/prerequisites/{1}", (object) Class67.String_2, (object) string_2), class70.string_0, (string) null);
      Process process = new Process();
      // ISSUE: reference to a compiler-generated field
      process.StartInfo.FileName = class70.string_0;
      process.EnableRaisingEvents = true;
      process.StartInfo.UseShellExecute = true;
      process.StartInfo.Verb = "runas";
      // ISSUE: reference to a compiler-generated method
      process.Exited += new EventHandler(class70.method_0);
      process.Start();
      process.WaitForExit();
    }

    private static void smethod_8(string string_2, string string_3, string string_4)
    {
      if (GClass27.smethod_2(string_2) && (!Environment.Is64BitOperatingSystem || GClass27.smethod_3(string_2)))
        return;
      Class67.smethod_7(string_3);
      Class67.smethod_7(string_4);
    }

    internal static void smethod_9()
    {
      Class67.smethod_8("msvcr110.dll", "vcredist_x862012.exe", "vcredist_x642012.exe");
    }

    internal static void smethod_10()
    {
      if (GClass27.smethod_2("msvcp140.dll"))
        return;
      Class67.smethod_7("vcredist_x642015.exe");
    }

    public static string smethod_11()
    {
      return new GClass78().method_6(string.Format("{0}/res/txt/changelog.txt", (object) Class67.String_2));
    }

    public static string smethod_12()
    {
      return new GClass78().method_6(string.Format("{0}/getContributors.php", (object) Class67.String_3));
    }

    public static void smethod_13()
    {
      if (Class67.zipArchive_0 == null)
        return;
      Class67.zipArchive_0.Dispose();
      Class67.zipArchive_0 = (ZipArchive) null;
    }

    public static string smethod_14(string string_2, string string_3)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class67.Class71 class71 = new Class67.Class71();
      // ISSUE: reference to a compiler-generated field
      class71.frmWait_0 = new FrmWait("USB Helper is uploading data...", true);
      WebClient webClient = new WebClient();
      // ISSUE: reference to a compiler-generated field
      class71.string_0 = "";
      // ISSUE: reference to a compiler-generated method
      webClient.UploadProgressChanged += new UploadProgressChangedEventHandler(class71.method_0);
      // ISSUE: reference to a compiler-generated method
      webClient.UploadFileCompleted += new UploadFileCompletedEventHandler(class71.method_1);
      webClient.UploadFileAsync(new Uri(string_3), string_2);
      // ISSUE: reference to a compiler-generated field
      int num = (int) class71.frmWait_0.ShowDialog();
      // ISSUE: reference to a compiler-generated field
      return class71.string_0;
    }

    private static byte[] smethod_15()
    {
      ++Class67.int_0;
      byte[] buffer = new byte[16];
      Random random = new Random(18211852 * Class67.int_0 * 2);
      for (int index = 0; index < 100000 * Class67.int_0; ++index)
        random.NextBytes(buffer);
      using (MD5 md5 = MD5.Create())
      {
        for (int index = 0; index < 10000 * Class67.int_0 * Class67.int_0; ++index)
          buffer = md5.ComputeHash(buffer);
      }
      return buffer;
    }

    private static void smethod_16(MemoryStream memoryStream_0)
    {
      MemoryStream memoryStream = new MemoryStream();
      using (AesCryptoServiceProvider cryptoServiceProvider = new AesCryptoServiceProvider())
      {
        cryptoServiceProvider.Mode = CipherMode.CBC;
        cryptoServiceProvider.Key = Class67.smethod_15();
        cryptoServiceProvider.IV = Class67.smethod_15();
        byte[] buffer = new byte[512];
        using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream_0, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
        {
          int count;
          do
          {
            count = cryptoStream.Read(buffer, 0, 512);
            memoryStream.Write(buffer, 0, count);
            Class67.int_0 = 0;
          }
          while (count > 0);
        }
        for (int index = 0; index < 16; ++index)
        {
          cryptoServiceProvider.IV[index] = (byte) 0;
          cryptoServiceProvider.Key[index] = (byte) 0;
        }
      }
      Class67.zipArchive_0 = new ZipArchive((Stream) memoryStream);
    }

    private static void smethod_17(string string_2)
    {
      string string_0_1 = Path.Combine(GClass88.CachePath, "etag");
      string string_0_2 = Path.Combine(GClass88.CachePath, "db");
      using (MemoryStream memoryStream_0 = new MemoryStream(new GClass78().method_2(Class67.String_5)))
        Class67.smethod_16(memoryStream_0);
      GClass6.smethod_6(string_0_1);
      GClass6.smethod_6(string_0_2);
    }

    private static void smethod_18()
    {
      if (Class67.zipArchive_0 != null)
        return;
      string path = Path.Combine(GClass88.CachePath, "etag");
      string str = Path.Combine(GClass88.CachePath, "db");
      string string_2 = GClass6.smethod_14(Class67.String_5);
      if (System.IO.File.Exists(path) && System.IO.File.Exists(str))
      {
        if (!(System.IO.File.ReadAllText(path) != string_2) && new FileInfo(str).Length != 0L)
        {
          using (MemoryStream memoryStream_0 = new MemoryStream(System.IO.File.ReadAllBytes(str)))
            Class67.smethod_16(memoryStream_0);
        }
        else
          Class67.smethod_17(string_2);
      }
      else
        Class67.smethod_17(string_2);
    }

    public static void smethod_19(string string_2)
    {
      Class67.smethod_18();
      foreach (DbRow dbRow in JsonConvert.DeserializeObject<IEnumerable<DbRow>>(Class67.zipArchive_0.GetEntry(string_2).smethod_7()))
      {
        if (!GClass28.dictionary_1.ContainsKey(dbRow.TitleId))
          GClass28.dictionary_1.Add(dbRow.TitleId, new GClass80.GStruct4()
          {
            dataSize_0 = dbRow.Size,
            titleId_0 = dbRow.TitleId
          });
      }
    }

    public static void smethod_20(string string_2)
    {
      Class67.smethod_18();
      foreach (DbRow dbRow in JsonConvert.DeserializeObject<IEnumerable<DbRow>>(Class67.zipArchive_0.GetEntry(string_2).smethod_7()).Where<DbRow>((Func<DbRow, bool>) (dbRow_0 => !dbRow_0.PreLoad)))
        GClass28.dictionary_2.Add(dbRow.TitleId, dbRow);
    }

    public static void smethod_21(string string_2)
    {
      Class67.smethod_18();
      foreach (DbRow dbRow in JsonConvert.DeserializeObject<IEnumerable<DbRow>>(Class67.zipArchive_0.GetEntry(string_2).smethod_7()))
      {
        if (!GClass28.dictionary_3.ContainsKey(dbRow.TitleId))
          GClass28.dictionary_3.Add(dbRow.TitleId, new List<GClass80.GStruct5>());
        GClass28.dictionary_3[dbRow.TitleId].Add(new GClass80.GStruct5()
        {
          dataSize_0 = dbRow.Size,
          titleId_0 = dbRow.TitleId,
          string_0 = dbRow.Version
        });
      }
    }

    public static string[] smethod_22()
    {
      return new GClass78().method_6(string.Format("{0}/res/db/blackList.txt", (object) Class67.String_2)).Split(new string[1]
      {
        Environment.NewLine
      }, StringSplitOptions.RemoveEmptyEntries);
    }
  }
}

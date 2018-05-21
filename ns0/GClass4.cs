// Decompiled with JetBrains decompiler
// Type: ns0.GClass4
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Telerik.WinControls.Zip;

namespace ns0
{
  public static class GClass4
  {
    private static readonly EncryptionSettings encryptionSettings_0 = (EncryptionSettings) new DefaultEncryptionSettings()
    {
      Password = "rL'.*##y%YV5s8YK%~@X?p"
    };

    public static void smethod_0(string string_0, string string_1, string string_2)
    {
      GClass6.smethod_5(string_2);
      Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(string_2);
      GClass4.smethod_3(string_0);
      using (FileStream fileStream1 = Alphaleonis.Win32.Filesystem.File.OpenRead(string_1))
      {
        using (ZipArchive zipArchive = new ZipArchive((Stream) fileStream1, ZipArchiveMode.Read, false, (Encoding) null, (CompressionSettings) null, GClass4.encryptionSettings_0))
        {
          string[] strArray1 = (string[]) null;
          using (ZipArchiveEntry entry = zipArchive.GetEntry("usb_helper_fst"))
          {
            using (StreamReader streamReader = new StreamReader(entry.Open()))
              strArray1 = streamReader.ReadToEnd().Split(new string[1]
              {
                Environment.NewLine
              }, StringSplitOptions.RemoveEmptyEntries);
          }
          byte[] buffer = new byte[1024];
          foreach (string str1 in strArray1)
          {
            char[] chArray = new char[1]{ ':' };
            string[] strArray2 = str1.Split(chArray);
            string str2 = strArray2[0];
            string entryName = strArray2[1];
            string str3 = Alphaleonis.Win32.Filesystem.Path.Combine(string_2, entryName);
            string str4 = Alphaleonis.Win32.Filesystem.Path.Combine(string_0, entryName);
            Alphaleonis.Win32.Filesystem.Path.GetDirectoryName(str3);
            using (MD5.Create())
            {
              if (!(str2 == "CRT"))
              {
                if (!(str2 == "COP"))
                {
                  if (str2 == "DIR")
                    Alphaleonis.Win32.Filesystem.Directory.CreateDirectory(str3);
                }
                else
                {
                  GClass4.smethod_1(str4, strArray2[2]);
                  Alphaleonis.Win32.Filesystem.File.Copy(str4, str3, true);
                }
              }
              else
              {
                using (FileStream fileStream2 = Alphaleonis.Win32.Filesystem.File.Create(str3))
                {
                  using (ZipArchiveEntry entry = zipArchive.GetEntry(entryName))
                  {
                    using (Stream stream = entry.Open())
                    {
                      int count;
                      do
                      {
                        count = stream.Read(buffer, 0, buffer.Length);
                        fileStream2.Write(buffer, 0, count);
                      }
                      while (count > 0);
                    }
                  }
                }
                GClass4.smethod_1(str3, strArray2[2]);
              }
            }
          }
        }
      }
    }

    private static void smethod_1(string string_0, string string_1)
    {
      using (MD5 md5 = MD5.Create())
      {
        using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.OpenRead(string_0))
        {
          if (Convert.ToBase64String(md5.ComputeHash((Stream) fileStream)) != string_1)
            throw new Exception("Hash check failed!");
        }
      }
    }

    private static List<GClass4.GClass5> smethod_2(string string_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<Alphaleonis.Win32.Filesystem.DirectoryInfo>) new Alphaleonis.Win32.Filesystem.DirectoryInfo(string_0).GetDirectories("*", SearchOption.AllDirectories)).Select<Alphaleonis.Win32.Filesystem.DirectoryInfo, GClass4.GClass5>(new Func<Alphaleonis.Win32.Filesystem.DirectoryInfo, GClass4.GClass5>(new GClass4.Class0()
      {
        uri_0 = new Uri(string_0)
      }.method_0)).ToList<GClass4.GClass5>();
    }

    private static List<GClass4.GClass5> smethod_3(string string_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<Alphaleonis.Win32.Filesystem.FileInfo>) new Alphaleonis.Win32.Filesystem.DirectoryInfo(string_0).GetFiles("*", SearchOption.AllDirectories)).Select<Alphaleonis.Win32.Filesystem.FileInfo, GClass4.GClass5>(new Func<Alphaleonis.Win32.Filesystem.FileInfo, GClass4.GClass5>(new GClass4.Class1()
      {
        uri_0 = new Uri(string_0)
      }.method_0)).ToList<GClass4.GClass5>();
    }

    public class GClass5
    {
      public string string_0;
      public string string_1;

      public GClass5(string string_2, string string_3)
      {
        this.string_0 = string_2;
        this.string_1 = string_3;
      }

      public override bool Equals(object obj)
      {
        if (obj is GClass4.GClass5)
          return ((GClass4.GClass5) obj).string_1 == this.string_1;
        return false;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.GClass128
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using HtmlAgilityPack;
using IWshRuntimeLibrary;
using Microsoft.CSharp.RuntimeBinder;
using NusHelper;
using NusHelper.Emulators;
using SharpSteam;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using VDFParser.Models;

namespace ns0
{
  public static class GClass128
  {
    public static void smethod_0(GClass32 gclass32_0)
    {
      if (!gclass32_0.Boolean_1)
        return;
      try
      {
        GClass95 gclass95_0 = gclass32_0.method_14(false);
        if (!gclass95_0.Boolean_0)
        {
          if (!gclass95_0.EmuConfiguration_0.AutoUpdate)
          {
            int num = (int) RadMessageBox.Show(string.Format("No emulator detected. Please install it in {0} or enable Automatic updates in 'Emu. Settings'.", (object) gclass95_0.String_4));
            return;
          }
          gclass95_0.method_0();
        }
        gclass95_0.FullScreen = true;
        frmShortcutType frmShortcutType = new frmShortcutType((GClass30) gclass32_0);
        if (frmShortcutType.ShowDialog() != DialogResult.OK)
          return;
        if (frmShortcutType.ShortcutType == GEnum9.const_1)
          GClass128.smethod_5(gclass32_0, gclass95_0);
        else if (frmShortcutType.ShortcutType == GEnum9.const_0)
        {
          if (gclass95_0 is Cemu)
            (gclass95_0 as Cemu).RenderUpsideDown = frmShortcutType.SteamLinkFix;
          GClass128.smethod_7(gclass32_0, gclass95_0);
        }
        int num1 = (int) RadMessageBox.Show("Done!");
      }
      catch (Exception ex)
      {
        int num = (int) RadMessageBox.Show(ex.ToString());
      }
    }

    public static void smethod_1()
    {
      Task.Run((Action) (() =>
      {
        try
        {
          foreach (string user in SteamManager.GetUsers(SteamManager.GetSteamFolder()))
          {
            foreach (VDFEntry vdfEntry in ((IEnumerable<VDFEntry>) SteamManager.ReadShortcuts(user)).Where<VDFEntry>((Func<VDFEntry, bool>) (vdfentry_0 =>
            {
              if (vdfentry_0.Tags.Length >= 1)
                return vdfentry_0.Tags[0] == "Wii U USB Helper";
              return false;
            })))
            {
              try
              {
                ulong num = GClass128.smethod_3(vdfEntry.AppName, vdfEntry.Exe);
                string str = System.IO.Path.Combine(user, "config", "grid");
                System.IO.Directory.CreateDirectory(str);
                if (!System.IO.File.Exists(System.IO.Path.Combine(str, ((long) num).ToString() + ".png")))
                {
                  TitleId index = new TitleId(System.IO.Path.GetFileNameWithoutExtension(vdfEntry.Exe));
                  GClass128.smethod_2(GClass28.dictionary_0[index]);
                }
              }
              catch
              {
              }
            }
          }
        }
        catch
        {
        }
      }));
    }

    public static void smethod_2(GClass32 gclass32_0)
    {
      try
      {
        string str1 = GClass128.smethod_9(gclass32_0);
        if (str1 == null)
          return;
        string string_1 = GClass128.smethod_8(gclass32_0);
        foreach (string user in SteamManager.GetUsers(SteamManager.GetSteamFolder()))
        {
          ulong num = GClass128.smethod_3(gclass32_0.Name, string_1);
          string path2 = "config";
          string path3 = "grid";
          string str2 = System.IO.Path.Combine(user, path2, path3);
          System.IO.Directory.CreateDirectory(str2);
          string destFileName = System.IO.Path.Combine(str2, ((long) num).ToString() + ".png");
          System.IO.File.Copy(str1, destFileName, true);
        }
        GClass6.smethod_6(str1);
      }
      catch
      {
      }
    }

    private static string String_0
    {
      get
      {
        return System.IO.Path.Combine(GClass88.CachePath, "steam");
      }
    }

    private static ulong smethod_3(string string_0, string string_1)
    {
      GClass122 gclass122 = new GClass122();
      gclass122.method_2(Encoding.UTF8.GetBytes(string_1 + string_0));
      return (ulong) ((uint) gclass122.Int64_0 | 2147483648U) << 32 | 33554432UL;
    }

    private static string smethod_4(GClass32 gclass32_0, GClass95 gclass95_0)
    {
      System.IO.Path.Combine(GClass88.CachePath, "steam");
      string string_1 = GClass128.smethod_8(gclass32_0);
      System.IO.Directory.CreateDirectory(GClass128.String_0);
      new GClass78().method_5(string.Format("{0}/res/tools/Shortcut.exe", (object) Class67.String_2), string_1, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
      System.IO.File.WriteAllText(string_1 + ".arg", string.Format("{0}|{1}|{2}", (object) gclass95_0.GetExecutable(), (object) gclass95_0.GetArguments(), (object) System.IO.Path.GetDirectoryName(gclass95_0.GetExecutable())));
      return string_1;
    }

    private static void smethod_5(GClass32 gclass32_0, GClass95 gclass95_0)
    {
      string str1 = System.IO.Path.Combine(GClass88.CachePath, "icons");
      string str2 = System.IO.Path.Combine(str1, gclass32_0.TitleId.IdRaw + ".ico");
      System.IO.Directory.CreateDirectory(str1);
      using (MemoryStream memoryStream = new MemoryStream(new GClass78().method_2(gclass32_0.IconUrl)))
      {
        using (FileStream fileStream = System.IO.File.Create(str2))
          GClass124.smethod_0((Bitmap) Image.FromStream((Stream) memoryStream), (Stream) fileStream, 128, false);
      }
      string string_2 = GClass128.smethod_4(gclass32_0, gclass95_0);
      GClass128.smethod_6((GClass30) gclass32_0, GClass30.smethod_2(gclass32_0.Name), Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string_2, str2, gclass32_0.Name, "");
    }

    private static void smethod_6(GClass30 gclass30_0, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
    {
      string str1 = System.IO.Path.Combine(string_1, gclass30_0.TitleId.IdRaw + ".lnk");
      string str2 = System.IO.Path.Combine(string_1, string_0 + ".lnk");
      // ISSUE: variable of a compiler-generated type
      WshShell instance = (WshShell) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
      // ISSUE: reference to a compiler-generated field
      if (GClass128.Class113.callSite_0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        GClass128.Class113.callSite_0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (IWshShortcut), typeof (GClass128)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      IWshShortcut wshShortcut = GClass128.Class113.callSite_0.Target((CallSite) GClass128.Class113.callSite_0, instance.CreateShortcut(str1));
      wshShortcut.Arguments = string_5;
      wshShortcut.Description = string_4;
      wshShortcut.IconLocation = string_3;
      wshShortcut.TargetPath = string_2;
      wshShortcut.WorkingDirectory = System.IO.Path.GetDirectoryName(string_2);
      // ISSUE: reference to a compiler-generated method
      wshShortcut.Save();
      GClass6.smethod_6(str2);
      Alphaleonis.Win32.Filesystem.File.Move(str1, str2);
      GClass128.SHChangeNotify(134217728, 4096, IntPtr.Zero, IntPtr.Zero);
    }

    private static void smethod_7(GClass32 gclass32_0, GClass95 gclass95_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass128.Class114 class114 = new GClass128.Class114();
      // ISSUE: reference to a compiler-generated field
      class114.gclass32_0 = gclass32_0;
      if (GClass6.smethod_16("Steam"))
      {
        int num1 = (int) RadMessageBox.Show("Games cannot be added while Steam is running. Please close it and try again");
      }
      else
      {
        string steamFolder = SteamManager.GetSteamFolder();
        if (!System.IO.Directory.Exists(steamFolder))
        {
          int num2 = (int) RadMessageBox.Show("Steam is not installed. Cannot proceed.");
        }
        else
        {
          string[] users = SteamManager.GetUsers(steamFolder);
          if (users.Length == 0)
          {
            int num3 = (int) RadMessageBox.Show("USB Helper was unable to find any registered Steam user. Make sure you have logged in at least once.");
          }
          else
          {
            string str1 = System.IO.Path.Combine(GClass128.String_0, "backup");
            System.IO.Directory.CreateDirectory(GClass128.String_0);
            System.IO.Directory.CreateDirectory(str1);
            // ISSUE: reference to a compiler-generated field
            string str2 = System.IO.Path.Combine(GClass128.String_0, "icon" + class114.gclass32_0.TitleId.IdRaw + ".tmp");
            // ISSUE: reference to a compiler-generated field
            string filename = System.IO.Path.Combine(GClass128.String_0, "icon" + class114.gclass32_0.TitleId.IdRaw + ".png");
            // ISSUE: reference to a compiler-generated field
            new GClass78().method_5(class114.gclass32_0.IconUrl, str2, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
            Image image = Image.FromFile(str2);
            image.Save(filename, ImageFormat.Png);
            image.Dispose();
            GClass6.smethod_6(str2);
            // ISSUE: reference to a compiler-generated field
            string str3 = GClass128.smethod_4(class114.gclass32_0, gclass95_0);
            // ISSUE: reference to a compiler-generated field
            VDFEntry vdfEntry = new VDFEntry() { AppName = class114.gclass32_0.Name, Exe = str3, Icon = filename, Tags = new string[1]{ "Wii U USB Helper" } };
            foreach (string userPath in users)
            {
              List<VDFEntry> source = new List<VDFEntry>();
              try
              {
                source = new List<VDFEntry>((IEnumerable<VDFEntry>) SteamManager.ReadShortcuts(userPath));
              }
              catch
              {
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              if (!source.Any<VDFEntry>(class114.func_0 ?? (class114.func_0 = new Func<VDFEntry, bool>(class114.method_0))))
              {
                source.Add(vdfEntry);
                string str4 = userPath + "\\config\\shortcuts.vdf";
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(str4));
                if (System.IO.File.Exists(str4))
                  System.IO.File.Copy(str4, System.IO.Path.Combine(str1, DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString()), true);
                SteamManager.WriteShortcuts(source.ToArray(), str4);
              }
            }
            // ISSUE: reference to a compiler-generated field
            GClass128.smethod_2(class114.gclass32_0);
          }
        }
      }
    }

    private static string smethod_8(GClass32 gclass32_0)
    {
      return System.IO.Path.Combine(GClass128.String_0, gclass32_0.TitleId.IdRaw + ".exe");
    }

    [DllImport("Shell32.dll")]
    private static extern int SHChangeNotify(int int_0, int int_1, IntPtr intptr_0, IntPtr intptr_1);

    private static string smethod_9(GClass32 gclass32_0)
    {
      string string_1 = (string) null;
      try
      {
        try
        {
          string string_0 = string.Format("{0}/res/emulators/banners/{1}.png", (object) Class67.String_2, (object) gclass32_0.TitleId.IdRaw);
          string_1 = System.IO.Path.Combine(GClass128.String_0, gclass32_0.TitleId.IdRaw + ".banner.png");
          new GClass78().method_5(string_0, string_1, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
          return string_1;
        }
        catch
        {
          string_1 = (string) null;
        }
        string html1 = new GClass78().method_6("http://steambanners.booru.org/index.php?page=post&s=list&tags=" + GClass30.smethod_3(GClass30.smethod_3(gclass32_0.Name.ToLower())).Replace(' ', '+'));
        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
        htmlDocument.LoadHtml(html1);
        IEnumerable<string> source = htmlDocument.DocumentNode.Descendants("a").Where<HtmlNode>((Func<HtmlNode, bool>) (htmlNode_0 => htmlNode_0.Attributes.Contains("id"))).Select<HtmlNode, string>((Func<HtmlNode, string>) (htmlNode_0 => htmlNode_0.Attributes["href"].Value)).Where<string>((Func<string, bool>) (string_0 => string_0.Contains("index.php?page=post")));
        if (source.Any<string>())
        {
          string html2 = new GClass78().method_6("http://steambanners.booru.org/" + HtmlEntity.DeEntitize(source.ElementAt<string>(0)));
          htmlDocument.LoadHtml(html2);
          string string_0_1 = htmlDocument.DocumentNode.Descendants("img").Where<HtmlNode>((Func<HtmlNode, bool>) (htmlNode_0 => htmlNode_0.Attributes.Contains("src"))).Select<HtmlNode, string>((Func<HtmlNode, string>) (htmlNode_0 => htmlNode_0.Attributes["src"].Value)).Where<string>((Func<string, bool>) (string_0 => string_0.Contains("img.booru.org/steambanners//images"))).ElementAt<string>(0);
          string_1 = System.IO.Path.Combine(GClass128.String_0, gclass32_0.TitleId.IdRaw + ".banner.png");
          new GClass78().method_5(string_0_1, string_1, 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
        }
      }
      catch
      {
      }
      return string_1;
    }
  }
}

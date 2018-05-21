// Decompiled with JetBrains decompiler
// Type: ns0.GClass91
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using Microsoft.VisualBasic.FileIO;
using NusHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Telerik.WinControls;

namespace ns0
{
  public abstract class GClass91
  {
    private List<string> list_0;

    protected GClass91(GClass32 gclass32_1)
    {
      this.WorkPath = gclass32_1.String_2;
      this.ToInject = gclass32_1;
      if (!GClass91.Boolean_1 && GClass91.smethod_4() == null)
      {
        Class67.smethod_7("java.exe");
        if (GClass91.smethod_4() == null)
        {
          int num = (int) RadMessageBox.Show("Java was not installed, it is required to build custom games.");
          throw new Exception("Java is not installed!");
        }
      }
      this.Name = this.ToInject.Name;
      try
      {
        this.Name = this.method_6("name").Replace("\\n", "\n");
      }
      catch
      {
      }
    }

    public event EventHandler Event_0;

    public event EventHandler<Exception> Event_1;

    public event EventHandler<int> Event_2;

    public abstract string String_1 { get; }

    public static string String_0
    {
      get
      {
        if (GClass91.Boolean_1)
          return "java";
        return GClass91.smethod_4();
      }
    }

    public static bool Boolean_0
    {
      get
      {
        if (GClass91.Boolean_1)
          return true;
        return System.IO.File.Exists(GClass91.smethod_4());
      }
    }

    public string Name { get; set; }

    public bool Production { get; set; }

    public string Publisher { get; set; } = "Hikari06";

    public List<string> List_0
    {
      get
      {
        if (this.list_0 == null)
        {
          this.list_0 = new List<string>();
          this.list_0.Add(this.ToInject.ProductId);
          try
          {
            this.list_0.AddRange((IEnumerable<string>) this.method_6("product_codes").Split(new string[1]
            {
              Environment.NewLine
            }, StringSplitOptions.RemoveEmptyEntries));
          }
          catch
          {
          }
        }
        return this.list_0;
      }
    }

    public abstract string String_2 { get; }

    public int RomCount { get; set; } = 1;

    public abstract string[] String_3 { get; }

    public GClass32 ToInject { get; protected set; }

    public bool UseGamepad { get; set; } = true;

    public bool VerticalWiimote { get; set; }

    public bool HorizontalWiimote { get; set; }

    public string WorkPath { get; set; }

    protected bool method_0(string string_3, bool bool_4)
    {
      try
      {
        this.method_6(string_3);
        bool_4 = !bool_4;
      }
      catch
      {
      }
      return bool_4;
    }

    public static void smethod_0(string string_3, string string_4)
    {
      Process process = Process.Start(new ProcessStartInfo(string_3)
      {
        WorkingDirectory = string_4,
        UseShellExecute = true,
        WindowStyle = ProcessWindowStyle.Hidden
      });
      if (process == null)
        process = Process.Start(new ProcessStartInfo(string_3)
        {
          WorkingDirectory = string_4,
          UseShellExecute = false,
          WindowStyle = ProcessWindowStyle.Hidden
        });
      process.WaitForExit();
    }

    public static void smethod_1(string string_3, string string_4, string string_5)
    {
      Process process = Process.Start(new ProcessStartInfo(string_3)
      {
        Arguments = string_5,
        WorkingDirectory = string_4,
        UseShellExecute = true,
        WindowStyle = ProcessWindowStyle.Hidden
      });
      if (process == null)
        process = Process.Start(new ProcessStartInfo(string_3)
        {
          Arguments = string_5,
          WorkingDirectory = string_4,
          UseShellExecute = false,
          WindowStyle = ProcessWindowStyle.Hidden
        });
      process.WaitForExit();
    }

    public static void smethod_2(string string_3, string string_4, string string_5, string string_6, string string_7)
    {
      Process.Start(new ProcessStartInfo(string_3)
      {
        Arguments = string_5,
        WorkingDirectory = string_4,
        UseShellExecute = false,
        WindowStyle = ProcessWindowStyle.Hidden,
        EnvironmentVariables = {
          [string_6] = string_7
        }
      }).WaitForExit();
    }

    public abstract bool vmethod_0(string string_3);

    public void method_1()
    {
      foreach (Alphaleonis.Win32.Filesystem.FileInfo file in new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.WorkPath).GetFiles("*", System.IO.SearchOption.AllDirectories))
      {
        if (System.IO.Directory.GetParent(file.FullName).Name != "output")
          GClass6.smethod_6(file.FullName);
      }
      foreach (Alphaleonis.Win32.Filesystem.FileInfo file in new Alphaleonis.Win32.Filesystem.DirectoryInfo(System.IO.Path.Combine(this.WorkPath, "output")).GetFiles())
        FileSystem.MoveFile(file.FullName, file.FullName.Replace("output\\", ""));
      foreach (Alphaleonis.Win32.Filesystem.DirectoryInfo directory in new Alphaleonis.Win32.Filesystem.DirectoryInfo(this.WorkPath).GetDirectories())
        directory.Delete(true);
    }

    public abstract int vmethod_1();

    public virtual void vmethod_2()
    {
      GClass6.smethod_5(this.WorkPath);
      System.IO.Directory.CreateDirectory(this.WorkPath);
      GClass6.smethod_5(this.ToInject.OutputPath);
    }

    protected void method_2(GClass32 gclass32_1)
    {
      TitleId titleId = new TitleId(this.ToInject.TitleId.IdRaw.Replace("00050000F", "000500001").Replace("000500002", "000500001"));
      Class9 class9 = new Class9((GClass30) gclass32_1);
      GClass13 gclass13 = gclass32_1.method_15();
      string str = Encoding.UTF8.GetString(class9.method_0(gclass13.Files.First<GClass12>((Func<GClass12, bool>) (gclass12_0 => gclass12_0.string_1 == "meta.xml")), 0UL));
      XDocument xdocument1 = XDocument.Parse(Encoding.UTF8.GetString(class9.method_0(gclass13.Files.First<GClass12>((Func<GClass12, bool>) (gclass12_0 => gclass12_0.string_1 == "app.xml")), 0UL)).Trim('\xFEFF'));
      xdocument1.Document.Descendants((XName) "title_id").ElementAt<XElement>(0).Value = titleId.IdRaw;
      xdocument1.Save(this.method_4("rawFiles\\code\\app.xml"));
      string[] strArray = new string[12]
      {
        "ja",
        "en",
        "fr",
        "de",
        "it",
        "es",
        "zhs",
        "ko",
        "nl",
        "pt",
        "ru",
        "zht"
      };
      XDocument xdocument2 = XDocument.Parse(str.Trim('\xFEFF'));
      xdocument2.Document.Descendants((XName) "title_id").ElementAt<XElement>(0).Value = titleId.IdRaw;
      xdocument2.Document.Descendants((XName) "product_code").ElementAt<XElement>(0).Value = this.ToInject.ProductId;
      foreach (XElement xelement in xdocument2.Document.Descendants().Where<XElement>((Func<XElement, bool>) (xelement_0 => xelement_0.Name.LocalName.Contains("publisher_"))))
        xelement.Value = "Hikari06";
      foreach (XElement xelement in xdocument2.Document.Descendants().Where<XElement>((Func<XElement, bool>) (xelement_0 => xelement_0.Name.LocalName.Contains("longname_"))))
        xelement.Value = this.Name;
      foreach (XElement xelement in xdocument2.Document.Descendants().Where<XElement>((Func<XElement, bool>) (xelement_0 => xelement_0.Name.LocalName.Contains("shortname_"))))
        xelement.Value = this.Name;
      foreach (XElement xelement in xdocument2.Document.Descendants().Where<XElement>((Func<XElement, bool>) (xelement_0 => xelement_0.Name.LocalName.Contains("pc_"))))
        xelement.Value = "0";
      try
      {
        if (this.UseGamepad)
          xdocument2.Document.Descendants((XName) "drc_use").ElementAt<XElement>(0).Value = "65537";
        else
          xdocument2.Document.Descendants((XName) "drc_use").ElementAt<XElement>(0).Value = "0";
      }
      catch
      {
      }
      xdocument2.Save(this.method_4("rawFiles\\meta\\meta.xml"));
    }

    protected abstract void vmethod_3();

    protected void method_3(string string_3, string string_4)
    {
      System.IO.Directory.CreateDirectory(string_4);
      foreach (System.IO.FileInfo file in new System.IO.DirectoryInfo(string_3).GetFiles())
      {
        string path2 = file.Name.ToLower().Replace(".app", "");
        if (path2 == "title.tmd")
          path2 = "tmd";
        if (path2 == "title.tik")
          path2 = "cetk";
        if (path2 == "title.cert")
          path2 = "cert";
        System.IO.File.Copy(file.FullName, System.IO.Path.Combine(string_4, path2));
      }
    }

    protected string method_4(string string_3)
    {
      return System.IO.Path.Combine(this.WorkPath, string_3);
    }

    protected void method_5(string string_3, string string_4)
    {
      new GClass78().method_5(this.method_12(string_3), System.IO.Path.Combine(string_4, string_3), 0UL, GClass78.GEnum4.const_0, (WebProxy) null, 0L, (byte[]) null, (byte[]) null, (byte) 0);
    }

    protected string method_6(string string_3)
    {
      return new GClass78().method_6(this.method_12(string_3));
    }

    protected Task method_7()
    {
      Task task = new Task((Action) (() =>
      {
        this.method_5("bootDrcTex.tga", this.method_4("rawFiles\\meta\\"));
        this.method_5("bootTvTex.tga", this.method_4("rawFiles\\meta\\"));
        this.method_5("iconTex.tga", this.method_4("rawFiles\\meta\\"));
        this.method_5("bootSound.btsnd", this.method_4("rawFiles\\meta\\"));
      }));
      task.Start();
      return task;
    }

    protected void method_8()
    {
      try
      {
        this.method_1();
        FileSystem.MoveDirectory(this.WorkPath, this.ToInject.OutputPath);
      }
      catch (Exception ex)
      {
        int num = (int) RadMessageBox.Show("USB Helper was unable to find the packed data. Usually this means Java is not properly installed. Please go to https://www.java.com/en/, install it, resart the app and try again." + Environment.NewLine + (object) ex);
      }
    }

    protected void method_9()
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, (EventArgs) null);
    }

    protected void method_10(Exception exception_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<Exception> eventHandler1 = this.eventHandler_1;
      if (eventHandler1 == null)
        return;
      eventHandler1((object) this, exception_0);
    }

    protected void method_11(int int_1)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<int> eventHandler2 = this.eventHandler_2;
      if (eventHandler2 == null)
        return;
      eventHandler2((object) this, int_1);
    }

    private static bool Boolean_1
    {
      get
      {
        try
        {
          Process.Start(new ProcessStartInfo()
          {
            FileName = "java.exe",
            Arguments = " -version",
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
          });
          return true;
        }
        catch
        {
          return false;
        }
      }
    }

    private static string smethod_3(string string_3, string string_4)
    {
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass91.Class77 class77 = new GClass91.Class77();
        IEnumerable<System.IO.FileInfo> source = ((IEnumerable<System.IO.FileInfo>) new System.IO.DirectoryInfo(string_3).GetFiles(string_4, System.IO.SearchOption.AllDirectories)).Where<System.IO.FileInfo>((Func<System.IO.FileInfo, bool>) (fileInfo_0 => !fileInfo_0.FullName.Contains("jdk")));
        // ISSUE: reference to a compiler-generated field
        class77.dateTime_0 = source.Max<System.IO.FileInfo, DateTime>((Func<System.IO.FileInfo, DateTime>) (fileInfo_0 => fileInfo_0.CreationTime));
        // ISSUE: reference to a compiler-generated method
        return source.First<System.IO.FileInfo>(new Func<System.IO.FileInfo, bool>(class77.method_0)).FullName;
      }
      catch
      {
        return (string) null;
      }
    }

    private static string smethod_4()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass91.Class78 class78 = new GClass91.Class78();
      // ISSUE: reference to a compiler-generated field
      class78.list_0 = new List<string>();
      if (Environment.Is64BitOperatingSystem)
      {
        string str = GClass91.smethod_3(System.IO.Path.Combine(Environment.GetEnvironmentVariable("ProgramW6432"), "Java"), "java.exe");
        if (str != null)
        {
          // ISSUE: reference to a compiler-generated field
          class78.list_0.Add(str);
        }
      }
      string str1 = GClass91.smethod_3(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Java"), "java.exe");
      if (str1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        class78.list_0.Add(str1);
      }
      // ISSUE: reference to a compiler-generated field
      if (class78.list_0.Count == 0)
        return (string) null;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      return class78.list_0.First<string>(new Func<string, bool>(class78.method_0));
    }

    private string method_12(string string_3)
    {
      return string.Format("{0}/{1}", (object) this.ToInject.String_6, (object) string_3).Replace("https", "http");
    }
  }
}

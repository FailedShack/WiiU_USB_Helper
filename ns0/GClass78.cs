// Decompiled with JetBrains decompiler
// Type: ns0.GClass78
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ns0
{
  public sealed class GClass78
  {
    internal volatile bool bool_1 = true;
    private TimeSpan timeSpan_0 = new TimeSpan(0L);
    private DateTime dateTime_0 = new DateTime(0L);
    private DateTime dateTime_1 = new DateTime(0L);
    private DataSize dataSize_2 = new DataSize(0UL);
    private object object_0 = new object();
    public bool bool_0;
    private const int int_0 = 1;

    public GStruct3 DownloadSpeed { get; private set; } = new GStruct3(0UL);

    public Exception LastError { get; private set; }

    public ulong MaximumSpeed { get; set; }

    public DataSize TotalDataDownloaded { get; set; } = new DataSize(0UL);

    public DataSize TotalDownloadedCurrentGame { get; set; } = new DataSize(0UL);

    public event EventHandler<long> Event_0;

    public event EventHandler<long> Event_1;

    public void method_0()
    {
      this.bool_1 = false;
    }

    public void method_1()
    {
      this.TotalDataDownloaded = new DataSize(0UL);
    }

    public byte[] method_2(string string_0)
    {
      HttpWebRequest http = WebRequest.CreateHttp(string_0);
      if (this.bool_0)
        http.Accept = "application/json";
      http.Method = "GET";
      this.bool_1 = true;
      http.Timeout = 30000;
      using (WebResponse response = http.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (MemoryStream memoryStream = new MemoryStream())
          {
            int count;
            do
            {
              byte[] buffer = new byte[131072];
              count = responseStream.Read(buffer, 0, buffer.Length);
              memoryStream.Write(buffer, 0, count);
            }
            while (this.bool_1 && count > 0);
            memoryStream.Flush();
            return memoryStream.ToArray();
          }
        }
      }
    }

    public byte[] method_3(string string_0)
    {
      return this.method_2(Class67.smethod_1(string_0, 7200));
    }

    public byte[] method_4(string string_0, int int_1)
    {
      string string_1 = GClass88.smethod_8(string_0);
      if (GClass88.smethod_1(string_1))
      {
        if ((DateTime.Now - GClass88.smethod_6(string_1)).TotalHours <= (double) int_1)
          return GClass88.smethod_4(string_1);
        byte[] byte_1 = new WebClient().UploadValues(string.Format("{0}/requestZipHash.php", (object) Class67.String_0), new NameValueCollection()
        {
          {
            "url",
            Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0))
          }
        });
        using (MD5 md5 = MD5.Create())
        {
          byte[] buffer = GClass88.smethod_4(string_1);
          if (GClass27.smethod_1(md5.ComputeHash(buffer), byte_1))
            return buffer;
        }
      }
      using (MemoryStream memoryStream = new MemoryStream(this.method_2(string.Format("{0}/zipProxy.php?url=", (object) Class67.String_0) + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0)))))
      {
        using (ZipArchive zipArchive = new ZipArchive((Stream) memoryStream))
        {
          ZipArchiveEntry entry = zipArchive.GetEntry("content");
          byte[] numArray = new byte[entry.Length];
          using (Stream stream = entry.Open())
            stream.Read(numArray, 0, numArray.Length);
          GClass88.smethod_9(new Uri(string_0), numArray);
          return numArray;
        }
      }
    }

    public void method_5(string string_0, string string_1, ulong ulong_1, GClass78.GEnum4 genum4_0, WebProxy webProxy_0, long long_0 = 0, byte[] byte_0 = null, byte[] byte_1 = null, byte byte_2 = 0)
    {
      if (genum4_0 == GClass78.GEnum4.const_1)
        ulong_1 = ulong_1 / 65536UL * 65536UL;
      this.bool_1 = true;
      this.DownloadSpeed = new GStruct3(0UL);
      this.TotalDataDownloaded += new DataSize(ulong_1);
      this.TotalDownloadedCurrentGame += new DataSize(ulong_1);
      this.dataSize_2 = new DataSize(0UL);
      this.timeSpan_0 = new TimeSpan(0L);
      this.dateTime_1 = new DateTime(0L);
      if (GClass28.bool_2 && ulong_1 == 0UL && long_0 > 0L)
      {
        this.method_12(string_0, string_1, ulong_1, GClass78.GEnum4.const_1, webProxy_0, byte_0, byte_1, byte_2, long_0);
        if (!this.bool_1 || System.IO.File.Exists(string_1) && new FileInfo(string_1).Length == long_0)
          return;
        string str = string_1 + ".partial";
        ulong sz = 0;
        if (System.IO.File.Exists(str))
          sz = (ulong) new FileInfo(str).Length;
        this.TotalDataDownloaded -= new DataSize(sz);
        this.TotalDownloadedCurrentGame -= new DataSize(sz);
        GClass6.smethod_6(str);
        GClass6.smethod_6(string_1);
        this.method_10(string_0, string_1, ulong_1, genum4_0, webProxy_0, byte_0, byte_1, byte_2, long_0);
      }
      else
        this.method_10(string_0, string_1, ulong_1, genum4_0, webProxy_0, byte_0, byte_1, byte_2, long_0);
    }

    public string method_6(string string_0)
    {
      return Encoding.UTF8.GetString(this.method_2(string_0));
    }

    public string method_7(string string_0, int int_1 = 604800)
    {
      try
      {
        return this.method_6(Class67.smethod_1(string_0, int_1));
      }
      catch (Exception ex)
      {
        return "";
      }
    }

    public void method_8()
    {
      this.TotalDataDownloaded -= this.TotalDownloadedCurrentGame;
    }

    internal event EventHandler<Class58> Event_2;

    internal static void smethod_0(string string_0, string string_1, byte[] byte_0, byte[] byte_1, IEnumerable<int> ienumerable_0)
    {
      foreach (int num1 in ienumerable_0)
      {
        long num2 = (long) (65536 * num1);
        HttpWebRequest http = WebRequest.CreateHttp(string_0);
        http.Method = "GET";
        http.AddRange(num2);
        using (WebResponse response = http.GetResponse())
        {
          using (Stream responseStream = response.GetResponseStream())
          {
            using (FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
              fileStream.Seek(num2, SeekOrigin.Begin);
              byte[] numArray = new byte[65536];
              byte[] buffer = responseStream.smethod_3(numArray.Length, (Action<int>) null);
              fileStream.Write(buffer, 0, buffer.Length);
              fileStream.Flush();
            }
          }
        }
      }
    }

    internal void method_9()
    {
      this.TotalDownloadedCurrentGame = new DataSize(0UL);
    }

    private void method_10(string string_0, string string_1, ulong ulong_1, GClass78.GEnum4 genum4_0, WebProxy webProxy_0, byte[] byte_0 = null, byte[] byte_1 = null, byte byte_2 = 0, long long_0 = 0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass78.Class53 class53 = new GClass78.Class53();
      // ISSUE: reference to a compiler-generated field
      class53.gclass78_0 = this;
      // ISSUE: reference to a compiler-generated field
      class53.long_0 = (long) ulong_1;
      HttpWebRequest http = WebRequest.CreateHttp(string_0);
      http.Proxy = (IWebProxy) webProxy_0;
      http.Method = "GET";
      http.AddRange((long) ulong_1);
      http.Timeout = 10000;
      http.ReadWriteTimeout = 15000;
      int int_5 = (int) (ulong_1 / 65536UL);
      using (WebResponse response = http.GetResponse())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass78.Class54 class54 = new GClass78.Class54();
        // ISSUE: reference to a compiler-generated field
        class54.class53_0 = class53;
        // ISSUE: reference to a compiler-generated field
        class54.long_0 = response.ContentLength + (long) ulong_1;
        using (Stream0 stream_0 = new Stream0(response.GetResponseStream()))
        {
          int bufferSize = GClass28.bool_0 ? 4096 : 65536;
          using (FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite, bufferSize))
          {
            fileStream.Seek((long) ulong_1, SeekOrigin.Begin);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            while (this.bool_1 && class54.class53_0.long_0 < class54.long_0)
            {
              byte[] numArray = new byte[65536];
              stream_0.Int64_0 = (long) this.MaximumSpeed;
              long long_3;
              if (genum4_0 == GClass78.GEnum4.const_1)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                numArray = stream_0.smethod_3(numArray.Length, class54.action_0 ?? (class54.action_0 = new Action<int>(class54.method_0)));
                if (numArray.Length < 65536)
                  throw new Exception("Block has invalid size");
                if (GClass28.bool_1 && Class85.smethod_0(numArray, byte_0, int_5, byte_1, byte_2) == Enum3.const_1)
                  throw new Exception("Invalid block");
                ++int_5;
                long_3 = 65536L;
              }
              else
              {
                long_3 = (long) stream_0.Read(numArray, 0, numArray.Length);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class54.class53_0.long_0 += long_3;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.method_11(new Class58(long_3, class54.class53_0.long_0, class54.long_0));
              }
              if (long_3 != 0L)
                fileStream.Write(numArray, 0, (int) long_3);
              else
                break;
            }
            fileStream.Flush();
          }
        }
      }
    }

    private void method_11(Class58 class58_0)
    {
      DataSize dataSize = new DataSize((ulong) class58_0.long_0);
      this.dateTime_0 = DateTime.Now;
      this.TotalDownloadedCurrentGame += dataSize;
      this.TotalDataDownloaded += dataSize;
      this.dataSize_2 += dataSize;
      this.timeSpan_0 = DateTime.Now - this.dateTime_1;
      if (this.timeSpan_0.TotalSeconds >= 1.0)
      {
        this.DownloadSpeed = new GStruct3(this.dataSize_2, this.timeSpan_0);
        this.dataSize_2 = new DataSize(0UL);
        this.dateTime_1 = DateTime.Now;
      }
      // ISSUE: reference to a compiler-generated field
      EventHandler<Class58> eventHandler2 = this.eventHandler_2;
      if (eventHandler2 == null)
        return;
      eventHandler2.BeginInvoke((object) this, class58_0, (AsyncCallback) null, (object) null);
    }

    private void method_12(string string_0, string string_1, ulong ulong_1, GClass78.GEnum4 genum4_0, WebProxy webProxy_0, byte[] byte_0 = null, byte[] byte_1 = null, byte byte_2 = 0, long long_0 = 0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass78.Class55 class55 = new GClass78.Class55();
      // ISSUE: reference to a compiler-generated field
      class55.long_0 = long_0;
      // ISSUE: reference to a compiler-generated field
      class55.byte_0 = byte_0;
      // ISSUE: reference to a compiler-generated field
      class55.byte_1 = byte_1;
      // ISSUE: reference to a compiler-generated field
      class55.byte_2 = byte_2;
      // ISSUE: reference to a compiler-generated field
      class55.string_0 = string_0;
      // ISSUE: reference to a compiler-generated field
      class55.webProxy_0 = webProxy_0;
      // ISSUE: reference to a compiler-generated field
      class55.gclass78_0 = this;
      // ISSUE: reference to a compiler-generated field
      class55.long_1 = 0L;
      int num1 = 3;
      List<Task> taskList = new List<Task>();
      // ISSUE: reference to a compiler-generated field
      long e = (long) Math.Ceiling((double) class55.long_0 / 65536.0);
      // ISSUE: reference to a compiler-generated field
      EventHandler<long> eventHandler0 = this.eventHandler_0;
      if (eventHandler0 != null)
        eventHandler0((object) this, e);
      if (e < (long) num1)
        num1 = (int) e;
      long num2 = e / (long) num1;
      GClass6.smethod_6(string_1);
      // ISSUE: reference to a compiler-generated field
      class55.bool_0 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass78.Class56 class56 = new GClass78.Class56();
      // ISSUE: reference to a compiler-generated field
      class56.class55_0 = class55;
      // ISSUE: reference to a compiler-generated field
      class56.fileStream_0 = System.IO.File.Create(string_1 + ".partial", 65536);
      try
      {
        for (int index = 0; index < num1; ++index)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          GClass78.Class57 class57 = new GClass78.Class57();
          // ISSUE: reference to a compiler-generated field
          class57.class56_0 = class56;
          // ISSUE: reference to a compiler-generated field
          class57.long_1 = num2;
          if (index == num1 - 1)
          {
            // ISSUE: reference to a compiler-generated field
            class57.long_1 += e % (long) num1;
          }
          // ISSUE: reference to a compiler-generated field
          class57.long_0 = num2 * (long) index * 65536L;
          // ISSUE: reference to a compiler-generated field
          class57.int_0 = (int) num2 * index;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          if (class57.long_0 <= class57.class56_0.class55_0.long_0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class57.httpWebRequest_0 = WebRequest.CreateHttp(class57.class56_0.class55_0.string_0);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class57.httpWebRequest_0.AddRange(class57.long_0);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            class57.httpWebRequest_0.Proxy = (IWebProxy) class57.class56_0.class55_0.webProxy_0;
            // ISSUE: reference to a compiler-generated method
            Task task = new Task(new Action(class57.method_0));
            taskList.Add(task);
          }
          else
            break;
        }
        foreach (Task task in taskList)
          task.Start();
        foreach (Task task in taskList)
          task.Wait();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (class56.fileStream_0.Length != class56.class55_0.long_0)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          class56.class55_0.bool_0 = true;
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (class56.fileStream_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          class56.fileStream_0.Dispose();
        }
      }
      // ISSUE: reference to a compiler-generated field
      if (!this.bool_1 || class55.bool_0)
        return;
      System.IO.File.Move(string_1 + ".partial", string_1);
    }

    public enum GEnum4
    {
      const_0,
      const_1,
    }
  }
}

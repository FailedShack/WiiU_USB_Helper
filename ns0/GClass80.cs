// Decompiled with JetBrains decompiler
// Type: ns0.GClass80
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using NusHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace ns0
{
  public sealed class GClass80 : IDisposable
  {
    private volatile bool bool_0 = true;
    private List<int> list_0 = new List<int>();
    private readonly GClass78 gclass78_0 = new GClass78();
    private volatile bool bool_1 = true;
    private TimeSpan timeSpan_1 = new TimeSpan(0L);
    private TimeSpan timeSpan_2 = new TimeSpan(0L);
    private DataSize dataSize_0 = new DataSize(0UL);
    private DataSize dataSize_1 = new DataSize(0UL);
    private DateTime dateTime_0 = DateTime.MinValue;
    public int int_0;
    private const double double_0 = 0.1;
    private int int_1;
    private const int int_2 = 8;
    private List<GClass30> list_1;
    private bool bool_2;
    private bool bool_3;
    private GStruct3 gstruct3_0;
    private TimeSpan timeSpan_0;
    private int int_3;
    private int int_4;
    private bool bool_4;
    private int int_5;

    public GClass80(WebProxy webProxy_1, bool bool_5, bool bool_6)
    {
      this.Proxy = webProxy_1;
      this.gclass78_0.Event_2 += new EventHandler<Class58>(this.method_8);
      this.gclass78_0.Event_1 += (EventHandler<long>) ((object_0, long_0) =>
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler<long> eventHandler1 = this.eventHandler_1;
        if (eventHandler1 == null)
          return;
        eventHandler1(object_0, long_0);
      });
      this.gclass78_0.Event_0 += (EventHandler<long>) ((object_0, long_0) =>
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler<long> eventHandler2 = this.eventHandler_2;
        if (eventHandler2 == null)
          return;
        eventHandler2(object_0, long_0);
      });
      NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(this.method_7);
      this.bool_2 = bool_5;
      this.bool_3 = bool_6;
    }

    public WebProxy Proxy { get; set; }

    public ulong MaxSpeed { get; private set; }

    public event EventHandler<bool> Event_0;

    public event EventHandler<long> Event_1;

    public event EventHandler<long> Event_2;

    public ulong UInt64_0
    {
      get
      {
        try
        {
          if (this.list_0.Count > 0)
            return (ulong) this.list_0.Average();
        }
        catch
        {
        }
        return 0;
      }
    }

    public void method_0()
    {
      this.bool_0 = false;
    }

    public void method_1(List<GClass30> list_2, int int_6 = 100, int int_7 = 10000)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      new Thread(new ThreadStart(new GClass80.Class62()
      {
        gclass80_0 = this,
        list_0 = list_2,
        int_0 = int_6,
        int_1 = int_7
      }.method_0))
      {
        IsBackground = true,
        ApartmentState = ApartmentState.STA,
        Priority = ThreadPriority.Highest
      }.Start();
    }

    private void method_2(List<GClass30> list_2)
    {
      this.dataSize_0 = new DataSize(0UL);
      this.timeSpan_2 = new TimeSpan(0L);
      this.timeSpan_1 = new TimeSpan(0L);
      this.gstruct3_0 = new GStruct3(0UL);
      this.dataSize_1 = new DataSize(0UL);
      this.list_1 = list_2;
      this.method_3();
      for (int int0 = this.int_0; int0 < list_2.Count; ++int0)
      {
        // ISSUE: reference to a compiler-generated field
        EventHandler<GClass79> eventHandler4 = this.eventHandler_4;
        if (eventHandler4 != null)
          eventHandler4((object) this, new GClass79(list_2[int0], int0));
        this.method_17(string.Format("----Downloading game #{0} out of {1}----", (object) (this.int_0 + 1), (object) list_2.Count));
        int num = this.method_14(list_2[int0]) == GClass80.Enum1.const_0 ? 1 : 0;
        list_2[int0].CurrentlyDownloaded = false;
        list_2[int0].method_6();
        if (num == 0 || !this.bool_0)
          break;
        ++this.int_0;
      }
    }

    public void method_3()
    {
      this.dataSize_1 = new DataSize(0UL);
      foreach (GClass30 gclass30_0 in this.list_1)
      {
        if (gclass30_0.Boolean_0)
          this.dataSize_1 += 0UL;
        else
          this.dataSize_1 += this.method_15(gclass30_0, false).DataSize_0;
      }
      this.method_17(string.Format("Total content size is {0}", (object) this.dataSize_1));
    }

    public void method_4(ulong ulong_1)
    {
      this.gclass78_0.MaximumSpeed = ulong_1;
    }

    public void Dispose()
    {
      this.method_6(true);
      GC.SuppressFinalize((object) this);
    }

    ~GClass80()
    {
      this.method_6(false);
    }

    private static int smethod_0(DataSize dataSize_2, DataSize dataSize_3)
    {
      int num = (int) Math.Floor((double) dataSize_3.TotalBytes / (double) dataSize_2.TotalBytes * 100.0);
      if (num < 0)
        num = 0;
      if (num > 100)
        num = 100;
      return num;
    }

    public static int smethod_1(long long_0, long long_1)
    {
      if (long_1 == 0L)
        return 0;
      try
      {
        int num = (int) Math.Floor((double) long_0 / (double) long_1 * 100.0);
        if (num < 0)
          num = 0;
        if (num > 100)
          num = 100;
        return num;
      }
      catch
      {
        return 100;
      }
    }

    private void method_5(string string_0)
    {
      this.gclass78_0.method_0();
      throw new GException1(string_0);
    }

    private void method_6(bool bool_5)
    {
      this.bool_4 = true;
    }

    private void method_7(object sender, NetworkAvailabilityEventArgs e)
    {
      this.bool_1 = e.IsAvailable;
    }

    private void method_8(object object_0, Class58 class58_0)
    {
      GClass78 gclass78 = (GClass78) object_0;
      if (!this.bool_1)
        this.method_5("Network lost");
      if (!this.bool_0)
        this.gclass78_0.method_0();
      this.gstruct3_0 = gclass78.DownloadSpeed;
      ulong ulong0 = this.gstruct3_0.ulong_0;
      if (ulong0 > this.MaxSpeed)
        this.MaxSpeed = ulong0;
      try
      {
        this.timeSpan_1 = GStruct3.smethod_1(this.dataSize_0.Diff(gclass78.TotalDownloadedCurrentGame), this.gstruct3_0);
        this.timeSpan_2 = GStruct3.smethod_1(this.dataSize_1.Diff(gclass78.TotalDataDownloaded), this.gstruct3_0);
        this.timeSpan_0 = GStruct3.smethod_1(new DataSize((ulong) class58_0.long_2).Diff(new DataSize((ulong) class58_0.long_1)), this.gstruct3_0);
        this.int_4 = GClass80.smethod_0(this.dataSize_0, gclass78.TotalDownloadedCurrentGame);
        this.int_5 = GClass80.smethod_0(this.dataSize_1, gclass78.TotalDataDownloaded);
        this.int_3 = (int) ((double) class58_0.long_1 / (double) class58_0.long_2 * 100.0);
        if (this.int_1++ == 8)
        {
          this.list_0.Add((int) this.gstruct3_0.ulong_0);
          this.int_1 = 0;
        }
        this.method_16(this.int_4, this.int_5, this.int_3, this.timeSpan_1, this.timeSpan_2, this.timeSpan_0, this.gstruct3_0, (GClass30) null);
      }
      catch
      {
      }
    }

    private void method_9(GClass30 gclass30_0, GClass100 gclass100_0, string string_0)
    {
      this.method_17("Computing title.cert...");
      string str = Path.Combine(string_0, "title.cert");
      if (gclass30_0.System == GEnum3.const_3)
        System.IO.File.WriteAllBytes(str, GClass96.byte_0);
      else if (gclass30_0.Platform == Platform.Wii_U_Custom)
      {
        this.gclass78_0.method_5(string.Format("{0}cert", (object) gclass30_0.String_1), str, 0UL, GClass78.GEnum4.const_0, this.Proxy, 0L, (byte[]) null, (byte[]) null, (byte) 0);
      }
      else
      {
        using (BinaryWriter binaryWriter = new BinaryWriter((Stream) System.IO.File.Open(str, FileMode.Create)))
        {
          binaryWriter.Write(gclass100_0.Certificate1);
          binaryWriter.Write(gclass100_0.Certificate2);
          binaryWriter.Write(GClass100.Byte_0);
        }
      }
    }

    private GClass80.Enum1 method_10(GClass30 gclass30_0, GClass101 gclass101_0, string string_0, GClass80.Enum0 enum0_0, ulong ulong_1 = 0)
    {
      string str = gclass101_0.ContentId.ToString("x8") + (enum0_0 == GClass80.Enum0.const_0 ? ".h3" : "");
      this.method_17(string.Format("Downloading of {0} initiated.", (object) str));
      if (this.Proxy != null)
        this.method_17(string.Format("Using proxy {0}", (object) this.Proxy.Address));
      if (enum0_0 == GClass80.Enum0.const_0)
        this.gclass78_0.method_5(gclass30_0.String_1 + str, string_0 + ".h3", ulong_1, GClass78.GEnum4.const_0, this.Proxy, 0L, (byte[]) null, (byte[]) null, (byte) 0);
      else if (gclass101_0.Boolean_0)
        this.gclass78_0.method_5(gclass30_0.String_1 + str, string_0 + ".app", ulong_1, GClass78.GEnum4.const_1, this.Proxy, (long) gclass101_0.Size.TotalBytes, System.IO.File.ReadAllBytes(string_0 + ".h3"), gclass30_0.Ticket.Byte_0, (byte) gclass101_0.Index);
      else
        this.gclass78_0.method_5(gclass30_0.String_1 + str, string_0 + ".app", ulong_1, GClass78.GEnum4.const_0, this.Proxy, (long) gclass101_0.Size.TotalBytes, (byte[]) null, (byte[]) null, (byte) 0);
      return !this.gclass78_0.bool_1 ? GClass80.Enum1.const_1 : GClass80.Enum1.const_0;
    }

    private GClass99 method_11(GClass30 gclass30_0)
    {
      this.method_17("Fetching Ticket...");
      string str = Path.Combine(gclass30_0.OutputPath, "title.tik");
      if (gclass30_0.Platform != Platform.Wii_U_Custom && (!(gclass30_0 is GClass33) || gclass30_0.System != GEnum3.const_1))
      {
        if (!gclass30_0.bool_0)
        {
          this.method_17("Generating ticket");
          System.IO.File.WriteAllBytes(str, gclass30_0.TicketArray);
          return gclass30_0.Ticket;
        }
        this.method_17("Downloading ticket from that site");
        byte[] bytes = System.IO.File.ReadAllBytes(Path.Combine(Path.Combine(GClass88.CachePath, "tickets"), gclass30_0.TitleId.IdRaw + ".tik"));
        gclass30_0.TicketArray = bytes;
        System.IO.File.WriteAllBytes(str, bytes);
        gclass30_0.Ticket = GClass99.smethod_7(gclass30_0.TicketArray, gclass30_0.System);
        return gclass30_0.Ticket;
      }
      this.method_17("Downloading Ticket from NUS");
      this.gclass78_0.method_5(string.Format("{0}cetk", (object) gclass30_0.String_1), str, 0UL, GClass78.GEnum4.const_0, this.Proxy, 0L, (byte[]) null, (byte[]) null, (byte) 0);
      gclass30_0.TicketArray = System.IO.File.ReadAllBytes(str);
      gclass30_0.Ticket = GClass99.smethod_6(str, gclass30_0.System);
      return gclass30_0.Ticket;
    }

    private GClass80.Enum1 method_12(GClass32 gclass32_0)
    {
      int num = (int) new frmInjection(gclass32_0).ShowDialog();
      return GClass80.Enum1.const_0;
    }

    private void method_13(bool bool_5)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<bool> eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, bool_5);
    }

    private GClass80.Enum1 method_14(GClass30 gclass30_0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass80.Class63 class63 = new GClass80.Class63();
      // ISSUE: reference to a compiler-generated field
      class63.gclass30_0 = gclass30_0;
      // ISSUE: reference to a compiler-generated field
      GEnum2 genum20 = class63.gclass30_0.GEnum2_0;
      this.gclass78_0.method_9();
      this.timeSpan_1 = new TimeSpan(0L);
      this.timeSpan_0 = new TimeSpan(0L);
      this.gstruct3_0 = new GStruct3(0UL);
      // ISSUE: reference to a compiler-generated field
      class63.gclass30_0.CurrentlyDownloaded = true;
      // ISSUE: reference to a compiler-generated field
      if (!Directory.Exists(class63.gclass30_0.OutputPath))
      {
        // ISSUE: reference to a compiler-generated field
        Directory.CreateDirectory(class63.gclass30_0.OutputPath);
      }
      // ISSUE: reference to a compiler-generated field
      if (class63.gclass30_0.Boolean_0)
      {
        // ISSUE: reference to a compiler-generated field
        return this.method_12((GClass32) class63.gclass30_0);
      }
      // ISSUE: reference to a compiler-generated field
      GClass100 gclass100_0 = this.method_15(class63.gclass30_0, true);
      // ISSUE: reference to a compiler-generated field
      GClass99 gclass99 = this.method_11(class63.gclass30_0);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (class63.gclass30_0.System == GEnum3.const_1 || class63.gclass30_0.System == GEnum3.const_3)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.method_9(class63.gclass30_0, gclass100_0, class63.gclass30_0.OutputPath);
      }
      this.dataSize_0 = gclass100_0.DataSize_0;
      this.method_17(string.Format("Content size is {0}", (object) this.dataSize_0));
      // ISSUE: reference to a compiler-generated field
      this.method_16(0, this.int_5, 0, this.timeSpan_1, this.timeSpan_2, this.timeSpan_0, new GStruct3(0UL), class63.gclass30_0);
label_7:
      for (int index = 0; index < (int) gclass100_0.NumOfContents; ++index)
      {
        bool flag1 = false;
        if (!this.bool_0)
          return GClass80.Enum1.const_1;
        GClass101 gclass101_0;
        DataSize size;
        while (true)
        {
          gclass101_0 = gclass100_0.GClass101_0[index];
          this.method_17(string.Format("Downloading Content #{0} ({1:x8}) of {2}... ({3})", (object) (index + 1), (object) gclass101_0.ContentId, (object) gclass100_0.NumOfContents, (object) gclass101_0.Size));
          // ISSUE: reference to a compiler-generated field
          string string_0 = Path.Combine(class63.gclass30_0.OutputPath, gclass101_0.ContentId.ToString("x8"));
          ulong num1 = 0;
          GClass6.smethod_6(string_0 + ".app.partial");
          if (System.IO.File.Exists(string_0 + ".app"))
            goto label_35;
label_9:
          try
          {
            int num2 = (int) Class64.SetThreadExecutionState(2147483649U);
            this.method_17("Downloading content...");
            if (gclass101_0.Boolean_0)
            {
              // ISSUE: reference to a compiler-generated field
              int num3 = (int) this.method_10(class63.gclass30_0, gclass101_0, string_0, GClass80.Enum0.const_0, 0UL);
            }
            bool flag2 = false;
            // ISSUE: reference to a compiler-generated field
            if (class63.gclass30_0 is GClass33 && gclass101_0.Boolean_0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              foreach (GClass30 gclass30 in class63.gclass30_0.GClass32_0.Updates.Where<GClass33>(class63.func_0 ?? (class63.func_0 = new Func<GClass33, bool>(class63.method_0))))
              {
                string str1 = Path.Combine(gclass30.OutputPath, gclass101_0.ContentId.ToString("x8"));
                string str2 = str1 + ".app";
                string path = str1 + ".h3";
                if (System.IO.File.Exists(path) && System.IO.File.Exists(str2) && System.IO.File.ReadAllBytes(path).smethod_5(System.IO.File.ReadAllBytes(string_0 + ".h3")))
                {
                  long length = new FileInfo(str2).Length;
                  size = gclass101_0.Size;
                  long totalBytes1 = (long) size.TotalBytes;
                  if (length == totalBytes1)
                  {
                    this.method_17("Found similar file in older update. Copying...");
                    System.IO.File.Copy(str2, string_0 + ".app", true);
                    GClass78 gclass780 = this.gclass78_0;
                    DataSize downloadedCurrentGame = gclass780.TotalDownloadedCurrentGame;
                    size = gclass101_0.Size;
                    long totalBytes2 = (long) size.TotalBytes;
                    gclass780.TotalDownloadedCurrentGame = downloadedCurrentGame + (ulong) totalBytes2;
                    this.gclass78_0.TotalDataDownloaded += gclass101_0.Size;
                    flag2 = true;
                    break;
                  }
                }
              }
            }
            if (!flag2)
            {
              // ISSUE: reference to a compiler-generated field
              if (this.method_10(class63.gclass30_0, gclass101_0, string_0, GClass80.Enum0.const_1, num1) == GClass80.Enum1.const_1)
                return GClass80.Enum1.const_1;
              if (this.bool_2)
              {
                if (gclass101_0.Boolean_0)
                {
                  if (genum20 != GEnum2.const_2)
                    goto label_7;
                }
                this.method_17("Verifying download...");
                this.method_13(true);
                // ISSUE: reference to a compiler-generated field
                GStruct7 gstruct7 = Class85.smethod_4(class63.gclass30_0, gclass101_0, gclass99.Byte_0);
                this.method_13(false);
                if (!gstruct7.Boolean_0)
                {
                  this.gclass78_0.TotalDataDownloaded -= gclass101_0.Size;
                  this.gclass78_0.TotalDownloadedCurrentGame -= gclass101_0.Size;
                  continue;
                }
                goto label_7;
              }
              else
                goto label_7;
            }
            else
              goto label_7;
          }
          catch (Exception ex)
          {
            bool flag2 = false;
            WebException webException;
            if ((webException = ex as WebException) != null && webException.Status == WebExceptionStatus.ProtocolError && webException.Response != null)
              flag2 = ((HttpWebResponse) webException.Response).StatusCode == HttpStatusCode.NotFound;
            if (!flag2)
            {
              this.method_17(string.Format("Downloading Content #{0} of {1} failed...", (object) (index + 1), (object) gclass100_0.NumOfContents));
              this.method_17(ex.Message);
              // ISSUE: reference to a compiler-generated field
              class63.gclass30_0.CurrentlyDownloaded = false;
              this.method_5("Downloading Content Failed:\n" + ex.Message);
              goto label_48;
            }
            else
            {
              this.method_17(string.Format("Downloading Content #{0} of {1} failed... (File not on NUS)", (object) (index + 1), (object) gclass100_0.NumOfContents));
              goto label_48;
            }
          }
label_35:
          num1 = (ulong) new FileInfo(string_0 + ".app").Length;
          this.method_17("Local file detected. Checking size...");
          long num4 = (long) num1;
          size = gclass101_0.Size;
          long totalBytes = (long) size.TotalBytes;
          if (num4 == totalBytes)
          {
            this.method_17("Sizes match. Checking file....");
            if (gclass101_0.Boolean_0 && !System.IO.File.Exists(string_0 + ".h3"))
            {
              // ISSUE: reference to a compiler-generated field
              int num2 = (int) this.method_10(class63.gclass30_0, gclass101_0, string_0, GClass80.Enum0.const_0, 0UL);
            }
            if (this.bool_3)
            {
              this.method_13(true);
              // ISSUE: reference to a compiler-generated field
              GStruct7 gstruct7 = Class85.smethod_4(class63.gclass30_0, gclass101_0, gclass99.Byte_0);
              this.method_13(false);
              if (!gstruct7.Boolean_0)
              {
                // ISSUE: reference to a compiler-generated field
                if (gclass101_0.Boolean_0 && class63.gclass30_0.Platform != Platform.Wii_U_Custom && !flag1)
                {
                  this.method_17(string.Format("File has {0} corrupted block(s) for a total of  {1} bytes", (object) gstruct7.list_0.Count, (object) (gstruct7.list_0.Count * 65536)));
                  this.method_17("Attempting repair. This may take a while depending on the state of the file.");
                  string str = gclass101_0.ContentId.ToString("x8");
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  GClass78.smethod_0(class63.gclass30_0.String_1 + str, string_0 + ".app", System.IO.File.ReadAllBytes(string_0 + ".h3"), class63.gclass30_0.Ticket.Byte_0, (IEnumerable<int>) gstruct7.list_0);
                  flag1 = true;
                }
                else
                {
                  this.method_17("This file is corrupted but cannot be repaired. Now redownloading...");
                  GClass6.smethod_6(string_0 + ".app");
                }
              }
              else
                break;
            }
            else
              break;
          }
          else
          {
            size = gclass101_0.Size;
            if (size.TotalBytes < num1)
            {
              this.method_17("This file does not qualify for intelligent resuming. Redownloading...");
              GClass6.smethod_6(string_0 + ".app");
            }
            else
            {
              this.method_17(string.Format("Sizes mismatch. Resuming download at {0}", (object) new DataSize(num1)));
              goto label_9;
            }
          }
        }
        this.method_17("This file is good, skipping...");
        GClass78 gclass780_1 = this.gclass78_0;
        DataSize downloadedCurrentGame1 = gclass780_1.TotalDownloadedCurrentGame;
        size = gclass101_0.Size;
        long totalBytes3 = (long) size.TotalBytes;
        gclass780_1.TotalDownloadedCurrentGame = downloadedCurrentGame1 + (ulong) totalBytes3;
        this.gclass78_0.TotalDataDownloaded += gclass101_0.Size;
        continue;
label_48:
        GC.Collect();
      }
      // ISSUE: reference to a compiler-generated field
      this.method_17(string.Format("Downloading Title {0} v{1} Finished...", (object) class63.gclass30_0.TitleId, (object) gclass100_0.TitleVersion));
      // ISSUE: reference to a compiler-generated field
      this.method_16(100, this.int_5, 100, new TimeSpan(0L), this.timeSpan_2, new TimeSpan(0L), this.gstruct3_0, class63.gclass30_0);
      return GClass80.Enum1.const_0;
    }

    private GClass100 method_15(GClass30 gclass30_0, bool bool_5 = true)
    {
      this.method_17("Downloading TMD...");
      string path = Path.Combine(gclass30_0.OutputPath, "title.tmd");
      if (!bool_5 && gclass30_0.Tmd != null)
        return gclass30_0.Tmd;
      GClass78 gclass78 = new GClass78();
      byte[] numArray = (byte[]) null;
      try
      {
        numArray = !(gclass30_0 is GClass33) ? gclass78.method_2(gclass30_0.String_1 + "tmd") : gclass78.method_2(string.Format("{0}tmd.{1}", (object) gclass30_0.String_1, (object) gclass30_0.Version));
        gclass30_0.Tmd = GClass100.smethod_1(numArray, gclass30_0.System);
      }
      catch (Exception ex)
      {
        this.method_5("TMD not found\n" + ex.ToString() + "\n" + ex.InnerException?.ToString());
      }
      if (bool_5)
        System.IO.File.WriteAllBytes(path, numArray);
      return gclass30_0.Tmd;
    }

    public event EventHandler<string> Event_3;

    public event EventHandler<GClass79> Event_4;

    public event EventHandler<GClass81> Event_5;

    public event EventHandler<GEventArgs0> Event_6;

    private void method_16(int int_6, int int_7, int int_8, TimeSpan timeSpan_3, TimeSpan timeSpan_4, TimeSpan timeSpan_5, GStruct3 gstruct3_1, GClass30 gclass30_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<GEventArgs0> eventHandler6 = this.eventHandler_6;
      if (eventHandler6 == null)
        return;
      eventHandler6((object) this, new GEventArgs0(int_6, int_7, int_8, timeSpan_3, timeSpan_4, timeSpan_5, gstruct3_1, gclass30_0));
    }

    private void method_17(string string_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<string> eventHandler3 = this.eventHandler_3;
      if (eventHandler3 == null)
        return;
      eventHandler3((object) this, string_0);
    }

    private void method_18(string string_0, bool bool_5)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<GClass81> eventHandler5 = this.eventHandler_5;
      if (eventHandler5 == null)
        return;
      eventHandler5((object) this, new GClass81(string_0, bool_5, GEnum5.const_4));
    }

    public struct GStruct4
    {
      public DataSize dataSize_0;
      public TitleId titleId_0;
    }

    public struct GStruct5
    {
      public DataSize dataSize_0;
      public TitleId titleId_0;
      public string string_0;
      public string string_1;
      public string string_2;
    }

    private enum Enum0
    {
      const_0,
      const_1,
    }

    private enum Enum1
    {
      const_0,
      const_1,
    }
  }
}

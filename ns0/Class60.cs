// Decompiled with JetBrains decompiler
// Type: ns0.Class60
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ns0
{
  internal class Class60
  {
    private readonly int int_1 = 131072;
    public static volatile bool bool_0;
    private const int int_0 = 5;
    private readonly string string_0;
    private readonly string string_1;
    private readonly string string_2;
    private readonly string string_3;
    private volatile bool bool_1;
    private FtpWebRequest ftpWebRequest_0;
    private FtpWebResponse ftpWebResponse_0;
    private Stream stream_0;

    public Class60(string string_4, string string_5, string string_6)
    {
      this.string_1 = string_4;
      this.string_0 = "ftp://" + string_4;
      this.string_3 = string_5;
      this.string_2 = string_6;
    }

    public event EventHandler<long> Event_0;

    public event EventHandler Event_1;

    public GClass81 TransferStatus { get; private set; } = new GClass81("Upload complete!", false, GEnum5.const_6);

    public void method_0()
    {
      this.TransferStatus = new GClass81("Upload aborted.", true, GEnum5.const_2);
      this.bool_1 = true;
    }

    public bool method_1()
    {
      bool flag = true;
      try
      {
        this.ftpWebRequest_0 = this.method_16("/", "NLST");
        this.ftpWebRequest_0.Timeout = 10000;
        this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse();
      }
      catch (Exception ex)
      {
        flag = false;
      }
      try
      {
        FtpWebResponse ftpWebResponse0 = this.ftpWebResponse_0;
        if (ftpWebResponse0 != null)
          ftpWebResponse0.Close();
      }
      catch
      {
        flag = false;
      }
      return flag;
    }

    public void method_2(string string_4)
    {
      try
      {
        this.ftpWebRequest_0 = this.method_16(string_4, "MKD");
        this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse();
        this.ftpWebResponse_0.Close();
        this.ftpWebRequest_0 = (FtpWebRequest) null;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void method_3(string string_4)
    {
      try
      {
        this.ftpWebRequest_0 = this.method_16(string_4, "DELE");
        this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse();
        this.ftpWebResponse_0.Close();
        this.ftpWebRequest_0 = (FtpWebRequest) null;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public List<string> method_4(string string_4)
    {
      List<string> stringList = new List<string>();
      try
      {
        this.ftpWebRequest_0 = this.method_16(string_4, "NLST");
        using (this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse())
        {
          using (this.stream_0 = this.ftpWebResponse_0.GetResponseStream())
          {
            using (StreamReader streamReader = new StreamReader(this.stream_0))
            {
              try
              {
                stringList.AddRange((IEnumerable<string>) streamReader.ReadToEnd().Split(new string[1]
                {
                  Environment.NewLine
                }, StringSplitOptions.RemoveEmptyEntries));
              }
              catch (Exception ex)
              {
                Console.WriteLine(ex.ToString());
              }
            }
          }
        }
        this.ftpWebRequest_0 = (FtpWebRequest) null;
        return stringList;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return stringList;
    }

    public void method_5(string string_4, string string_5)
    {
      using (FileStream fileStream = System.IO.File.Create(string_5))
      {
        using (ZipArchive zipArchive_0 = new ZipArchive((Stream) fileStream, ZipArchiveMode.Create))
          this.method_8(string_4, zipArchive_0, "");
      }
    }

    public void method_6(string string_4, string string_5)
    {
      this.ftpWebRequest_0 = this.method_16(string_4, "RETR");
      using (FtpWebResponse response = (FtpWebResponse) this.ftpWebRequest_0.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (FileStream fileStream = new FileStream(string_5, FileMode.Create))
          {
            byte[] buffer = new byte[this.int_1];
            int count = responseStream.Read(buffer, 0, this.int_1);
            try
            {
              for (; count > 0; count = responseStream.Read(buffer, 0, this.int_1))
                fileStream.Write(buffer, 0, count);
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
          }
        }
      }
      this.ftpWebRequest_0 = (FtpWebRequest) null;
    }

    public byte[] method_7(string string_4)
    {
      this.ftpWebRequest_0 = this.method_16(string_4, "RETR");
      using (FtpWebResponse response = (FtpWebResponse) this.ftpWebRequest_0.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (MemoryStream memoryStream = new MemoryStream())
          {
            byte[] buffer = new byte[this.int_1];
            int count = responseStream.Read(buffer, 0, this.int_1);
            try
            {
              for (; count > 0; count = responseStream.Read(buffer, 0, this.int_1))
                memoryStream.Write(buffer, 0, count);
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
            return memoryStream.ToArray();
          }
        }
      }
    }

    public void method_8(string string_4, ZipArchive zipArchive_0, string string_5)
    {
      foreach (string str in this.method_4(string_4))
      {
        string string_5_1 = Path.Combine(string_5, str);
        if (Class60.smethod_1(str))
          this.method_8(Path.Combine(string_4, str) + "/", zipArchive_0, string_5_1);
        else
          this.method_17(Path.Combine(string_4, str), zipArchive_0, string_5_1);
      }
    }

    public string method_9(string string_4)
    {
      try
      {
        this.ftpWebRequest_0 = this.method_16(string_4, "MDTM");
        this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse();
        this.stream_0 = this.ftpWebResponse_0.GetResponseStream();
        StreamReader streamReader = new StreamReader(this.stream_0);
        string str = (string) null;
        try
        {
          str = streamReader.ReadToEnd();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
        streamReader.Close();
        this.stream_0.Close();
        this.ftpWebResponse_0.Close();
        this.ftpWebRequest_0 = (FtpWebRequest) null;
        return str;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return "";
    }

    public string method_10(string string_4)
    {
      try
      {
        this.ftpWebRequest_0 = this.method_16(string_4, "SIZE");
        this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse();
        this.stream_0 = this.ftpWebResponse_0.GetResponseStream();
        StreamReader streamReader = new StreamReader(this.stream_0);
        string str = (string) null;
        try
        {
          while (streamReader.Peek() != -1)
            str = streamReader.ReadToEnd();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
        streamReader.Close();
        this.stream_0.Close();
        this.ftpWebResponse_0.Close();
        this.ftpWebRequest_0 = (FtpWebRequest) null;
        return str;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
      return "";
    }

    public void method_11(string string_4, string string_5)
    {
      try
      {
        this.ftpWebRequest_0 = this.method_16(string_5, "RENAME");
        this.ftpWebRequest_0.RenameTo = string_5;
        this.ftpWebResponse_0 = (FtpWebResponse) this.ftpWebRequest_0.GetResponse();
        this.ftpWebResponse_0.Close();
        this.ftpWebRequest_0 = (FtpWebRequest) null;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void method_12(string string_4)
    {
      try
      {
        Class60.smethod_2(this.string_1, 21, this.string_3, this.string_2, "INST install/" + string_4);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void method_13(bool bool_2)
    {
      try
      {
        Class60.smethod_2(this.string_1, 21, this.string_3, this.string_2, "REMO " + (bool_2 ? "Y" : "N"));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public void method_14(string string_4, string string_5)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      Task.Run(new Action(new Class60.Class61()
      {
        class60_0 = this,
        string_0 = string_4,
        string_1 = string_5
      }.method_0));
    }

    public void method_15(string string_4, ZipArchive zipArchive_0)
    {
      this.method_2(string_4);
      List<string> stringList = new List<string>();
      foreach (ZipArchiveEntry entry in zipArchive_0.Entries)
      {
        string directoryName = Path.GetDirectoryName(entry.FullName);
        if (!stringList.Contains(directoryName))
        {
          stringList.Add(directoryName);
          string[] strArray = directoryName.Split('\\');
          string string_4_1 = string_4;
          foreach (string str in strArray)
          {
            string_4_1 = string_4_1 + "/" + str;
            this.method_2(string_4_1);
          }
        }
      }
      foreach (ZipArchiveEntry entry in zipArchive_0.Entries)
      {
        if (!(entry.FullName == "meta.json"))
        {
          string string_4_1 = Path.Combine(string_4, entry.FullName.Replace("\\", "/"));
          if (!Class60.smethod_1(string_4_1))
            this.method_19(string_4_1, entry);
        }
      }
    }

    private static void smethod_0(TcpClient tcpClient_0)
    {
      try
      {
        NetworkStream stream = tcpClient_0.GetStream();
        if (!(stream.CanWrite & stream.CanRead))
          return;
        byte[] numArray = new byte[tcpClient_0.ReceiveBufferSize + 1];
        stream.ReadTimeout = 10000;
        stream.Read(numArray, 0, Convert.ToInt32(tcpClient_0.ReceiveBufferSize));
        Encoding.ASCII.GetString(numArray);
      }
      catch
      {
      }
    }

    private static bool smethod_1(string string_4)
    {
      return Path.GetExtension(string_4) == string.Empty;
    }

    private static bool smethod_2(string string_4, int int_2, string string_5, string string_6, string string_7)
    {
      bool flag = false;
      try
      {
        TcpClient tcpClient_0 = new TcpClient();
        tcpClient_0.Connect(string_4, int_2);
        Class60.smethod_0(tcpClient_0);
        if (Class60.smethod_3(tcpClient_0, "user " + string_5).Contains("331") && Class60.smethod_3(tcpClient_0, "pass " + string_6).Contains("230") && Class60.smethod_3(tcpClient_0, string_7).Contains("200"))
          flag = true;
        tcpClient_0.Close();
      }
      catch (Exception ex)
      {
        Console.WriteLine("TransmitCommand exception: " + ex.Message);
      }
      return flag;
    }

    private static string smethod_3(TcpClient tcpClient_0, string string_4)
    {
      string str = "";
      try
      {
        NetworkStream stream = tcpClient_0.GetStream();
        if (stream.CanWrite & stream.CanRead)
        {
          byte[] bytes = Encoding.ASCII.GetBytes(string_4 + Environment.NewLine);
          stream.Write(bytes, 0, bytes.Length);
          str = new StreamReader((Stream) stream).ReadLine();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("TransmitCommand exception: " + ex.Message);
      }
      return str;
    }

    private FtpWebRequest method_16(string string_4, string string_5)
    {
      this.ftpWebRequest_0 = (FtpWebRequest) WebRequest.Create(this.string_0 + "/" + string_4);
      this.ftpWebRequest_0.Credentials = (ICredentials) new NetworkCredential(this.string_3, this.string_2);
      this.ftpWebRequest_0.UseBinary = true;
      this.ftpWebRequest_0.UsePassive = true;
      this.ftpWebRequest_0.KeepAlive = true;
      this.ftpWebRequest_0.Method = string_5;
      this.ftpWebRequest_0.Timeout = 10000;
      return this.ftpWebRequest_0;
    }

    private void method_17(string string_4, ZipArchive zipArchive_0, string string_5)
    {
      this.ftpWebRequest_0 = this.method_16(string_4, "RETR");
      using (FtpWebResponse response = (FtpWebResponse) this.ftpWebRequest_0.GetResponse())
      {
        using (Stream responseStream = response.GetResponseStream())
        {
          using (Stream stream = zipArchive_0.CreateEntry(string_5).Open())
          {
            byte[] buffer = new byte[this.int_1];
            int count = responseStream.Read(buffer, 0, this.int_1);
            try
            {
              for (; count > 0; count = responseStream.Read(buffer, 0, this.int_1))
                stream.Write(buffer, 0, count);
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.ToString());
            }
          }
        }
      }
      this.ftpWebRequest_0 = (FtpWebRequest) null;
    }

    private void method_18(long long_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<long> eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0((object) this, long_0);
    }

    private void method_19(string string_4, ZipArchiveEntry zipArchiveEntry_0)
    {
      this.ftpWebRequest_0 = this.method_16(string_4, "STOR");
      using (Stream requestStream = this.ftpWebRequest_0.GetRequestStream())
      {
        using (Stream stream = zipArchiveEntry_0.Open())
        {
          byte[] buffer = new byte[this.int_1];
          int count = stream.Read(buffer, 0, this.int_1);
          try
          {
            while (count != 0)
            {
              if (!this.bool_1)
              {
                requestStream.Write(buffer, 0, count);
                count = stream.Read(buffer, 0, this.int_1);
                this.method_18((long) count);
              }
              else
                break;
            }
          }
          catch (Exception ex)
          {
            if (!(ex is DivideByZeroException))
              this.TransferStatus = new GClass81(ex.Message, true, GEnum5.const_4);
          }
        }
      }
      this.ftpWebRequest_0 = (FtpWebRequest) null;
    }

    private void method_20(string string_4, string string_5)
    {
      this.ftpWebRequest_0 = this.method_16(string_4, "STOR");
      using (Stream requestStream = this.ftpWebRequest_0.GetRequestStream())
      {
        using (FileStream fileStream = new FileStream(string_5, FileMode.Open))
        {
          byte[] buffer = new byte[this.int_1];
          int count = fileStream.Read(buffer, 0, this.int_1);
          try
          {
            while (count != 0)
            {
              if (!this.bool_1)
              {
                requestStream.Write(buffer, 0, count);
                count = fileStream.Read(buffer, 0, this.int_1);
                this.method_18((long) count);
              }
              else
                break;
            }
          }
          catch (Exception ex)
          {
            if (!(ex is DivideByZeroException))
              this.TransferStatus = new GClass81(ex.Message, true, GEnum5.const_4);
          }
        }
      }
      this.ftpWebRequest_0 = (FtpWebRequest) null;
    }

    private void method_21(string string_4, string string_5)
    {
      foreach (FileInfo file in new DirectoryInfo(string_5).GetFiles())
      {
        Thread.Sleep(125);
        int num = 1;
        if (!this.bool_1 && !this.TransferStatus.Error)
        {
          while (num < 5)
          {
            try
            {
              this.method_20(Path.Combine(string_4, file.Name), file.FullName);
              num = 5;
            }
            catch (Exception ex)
            {
              ++num;
              if (num >= 5)
                this.TransferStatus = new GClass81(ex.Message, true, GEnum5.const_4);
            }
          }
        }
        else
          break;
      }
      // ISSUE: reference to a compiler-generated field
      EventHandler eventHandler1 = this.eventHandler_1;
      if (eventHandler1 == null)
        return;
      eventHandler1((object) this, (EventArgs) null);
    }
  }
}

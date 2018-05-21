// Decompiled with JetBrains decompiler
// Type: ns0.GClass107
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;

namespace ns0
{
  public class GClass107 : IDisposable
  {
    private DateTime dateTime_0 = new DateTime(1970, 1, 1);
    private byte[] byte_0 = new byte[0];
    private SHA1 sha1_0 = SHA1.Create();
    private string string_0;
    private string string_1;
    private string string_2;
    private string string_3;
    private GClass100 gclass100_0;
    private GClass108 gclass108_0;
    private bool bool_0;

    public void method_0(string string_4, string string_5, string string_6, string string_7)
    {
      this.gclass100_0 = GClass100.smethod_0(string_6, GEnum3.const_3);
      this.string_0 = string_4;
      this.string_1 = string_5;
      this.string_2 = string_6;
      this.string_3 = string_7;
      this.gclass108_0 = new GClass108();
    }

    public void method_1(string string_4)
    {
      if (File.Exists(string_4))
        File.Delete(string_4);
      using (FileStream fileStream = new FileStream(string_4, FileMode.Create))
        this.method_3((Stream) fileStream);
    }

    private string method_2(GClass101 gclass101_0)
    {
      return Path.Combine(this.string_3, gclass101_0.ContentId.ToString("x8") + ".app");
    }

    private void method_3(Stream stream_0)
    {
      int num1 = 0;
      for (int index = 0; index < this.gclass100_0.GClass101_0.Length - 1; ++index)
        num1 += GClass27.smethod_0((int) this.gclass100_0.GClass101_0[index].Size.TotalBytes, 64);
      this.gclass108_0.UInt32_0 = (uint) num1 + (uint) (int) this.gclass100_0.GClass101_0[this.gclass100_0.GClass101_0.Length - 1].Size.TotalBytes;
      byte[] buffer1 = File.ReadAllBytes(this.string_2);
      byte[] buffer2 = File.ReadAllBytes(this.string_0);
      byte[] numArray = File.ReadAllBytes(this.string_1);
      GClass99.smethod_7(numArray, GEnum3.const_3);
      this.gclass108_0.UInt32_2 = (uint) (484 + this.gclass100_0.GClass101_0.Length * 36);
      this.gclass108_0.UInt32_1 = 0U;
      stream_0.Seek(0L, SeekOrigin.Begin);
      this.gclass108_0.method_0(stream_0);
      stream_0.Seek((long) GClass27.smethod_0((int) stream_0.Position, 64), SeekOrigin.Begin);
      stream_0.Write(buffer2, 0, buffer2.Length);
      stream_0.Seek((long) GClass27.smethod_0((int) stream_0.Position, 64), SeekOrigin.Begin);
      stream_0.Write(numArray, 0, numArray.Length);
      stream_0.Seek((long) GClass27.smethod_0((int) stream_0.Position, 64), SeekOrigin.Begin);
      stream_0.Write(buffer1, 0, (int) this.gclass108_0.UInt32_2);
      byte[] buffer3 = new byte[4096];
      long num2 = 0;
      foreach (GClass101 gclass101_0 in this.gclass100_0.GClass101_0)
      {
        stream_0.Seek((long) GClass27.smethod_0((int) stream_0.Position, 64), SeekOrigin.Begin);
        using (FileStream fileStream = File.OpenRead(this.method_2(gclass101_0)))
        {
          int count;
          do
          {
            count = fileStream.Read(buffer3, 0, buffer3.Length);
            stream_0.Write(buffer3, 0, count);
            num2 += (long) count;
          }
          while (count > 0);
        }
        this.method_4((int) ((double) num2 / (double) this.gclass108_0.UInt32_0 * 100.0));
      }
      while (stream_0.Position % 64L != 0L)
        stream_0.WriteByte((byte) 0);
    }

    public void Dispose()
    {
      this.vmethod_0(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void vmethod_0(bool bool_1)
    {
      if (bool_1 && !this.bool_0)
      {
        this.sha1_0.Clear();
        this.sha1_0 = (SHA1) null;
        this.gclass108_0 = (GClass108) null;
        this.gclass100_0.Dispose();
        this.byte_0 = (byte[]) null;
      }
      this.bool_0 = true;
    }

    ~GClass107()
    {
      this.vmethod_0(false);
    }

    public event EventHandler<ProgressChangedEventArgs> Event_0;

    private void method_4(int int_0)
    {
      // ISSUE: reference to a compiler-generated field
      EventHandler<ProgressChangedEventArgs> eventHandler0 = this.eventHandler_0;
      if (eventHandler0 == null)
        return;
      eventHandler0(new object(), new ProgressChangedEventArgs(int_0, (object) string.Empty));
    }
  }
}

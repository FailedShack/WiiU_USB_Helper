// Decompiled with JetBrains decompiler
// Type: ns0.Stream0
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.IO;
using System.Threading;

namespace ns0
{
  internal class Stream0 : Stream
  {
    public const long long_0 = 0;
    private readonly Stream stream_0;
    private long long_1;
    private long long_2;
    private long long_3;

    public Stream0(Stream stream_1)
      : this(stream_1, 0L)
    {
    }

    public Stream0(Stream stream_1, long long_4)
    {
      if (stream_1 == null)
        throw new ArgumentNullException("baseStream");
      if (long_4 < 0L)
        throw new ArgumentOutOfRangeException("maximumBytesPerSecond", (object) long_4, "The maximum number of bytes per second can't be negatie.");
      this.stream_0 = stream_1;
      this.long_2 = long_4;
      this.long_3 = this.Int64_1;
      this.long_1 = 0L;
    }

    public override bool CanRead
    {
      get
      {
        return this.stream_0.CanRead;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return this.stream_0.CanSeek;
      }
    }

    public override bool CanWrite
    {
      get
      {
        return this.stream_0.CanWrite;
      }
    }

    public override long Length
    {
      get
      {
        return this.stream_0.Length;
      }
    }

    public long Int64_0
    {
      get
      {
        return this.long_2;
      }
      set
      {
        if (this.Int64_0 == value)
          return;
        this.long_2 = value;
        this.method_0();
      }
    }

    public override long Position
    {
      get
      {
        return this.stream_0.Position;
      }
      set
      {
        this.stream_0.Position = value;
      }
    }

    protected long Int64_1
    {
      get
      {
        return (long) Environment.TickCount;
      }
    }

    public override void Flush()
    {
      this.stream_0.Flush();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      this.method_1(count);
      return this.stream_0.Read(buffer, offset, count);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      return this.stream_0.Seek(offset, origin);
    }

    public override void SetLength(long value)
    {
      this.stream_0.SetLength(value);
    }

    public override string ToString()
    {
      return this.stream_0.ToString();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      this.method_1(count);
      this.stream_0.Write(buffer, offset, count);
    }

    protected void method_0()
    {
      if (this.Int64_1 - this.long_3 <= 1000L)
        return;
      this.long_1 = 0L;
      this.long_3 = this.Int64_1;
    }

    protected void method_1(int int_0)
    {
      if (this.long_2 <= 0L || int_0 <= 0)
        return;
      this.long_1 += (long) int_0;
      long num = this.Int64_1 - this.long_3;
      if (num <= 0L || this.long_1 * 1000L / num <= this.long_2)
        return;
      int millisecondsTimeout = (int) (this.long_1 * 1000L / this.long_2 - num);
      if (millisecondsTimeout <= 1)
        return;
      try
      {
        Thread.Sleep(millisecondsTimeout);
      }
      catch (ThreadAbortException ex)
      {
      }
      this.method_0();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ns0.Stream1
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ns0
{
  internal class Stream1 : Stream
  {
    private long long_0 = -1;
    private readonly IList<Stream> ilist_0;
    private readonly IList<int> ilist_1;
    private int int_0;
    private Stream stream_0;
    private long long_1;

    public Stream1(IList<Stream> ilist_2)
      : this(ilist_2, (IList<int>) null)
    {
    }

    public Stream1(IList<Stream> ilist_2, IList<int> ilist_3)
    {
      if (ilist_2 == null)
        throw new ArgumentNullException("streams");
      this.ilist_0 = ilist_2;
      this.ilist_1 = ilist_3;
      if (ilist_2.Count <= 0)
        return;
      this.stream_0 = ilist_2[this.int_0++];
    }

    public IList<Stream> IList_0
    {
      get
      {
        return this.ilist_0;
      }
    }

    public override void Flush()
    {
      if (this.stream_0 == null)
        return;
      this.stream_0.Flush();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
      throw new InvalidOperationException("Stream is not seekable.");
    }

    public override void SetLength(long value)
    {
      this.long_0 = value;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      int num1 = 0;
      int offset1 = offset;
      while (count > 0)
      {
        int num2 = this.stream_0.Read(buffer, offset1, count);
        num1 += num2;
        offset1 += num2;
        this.long_1 += (long) num2;
        if (num2 <= count)
          count -= num2;
        if (count > 0)
        {
          if (this.int_0 < this.ilist_0.Count)
            this.stream_0 = this.ilist_0[this.int_0++];
          else
            break;
        }
      }
      return num1;
    }

    public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Stream1.Class95 class95 = new Stream1.Class95();
      // ISSUE: reference to a compiler-generated field
      class95.stream1_0 = this;
      // ISSUE: reference to a compiler-generated field
      class95.int_0 = count;
      // ISSUE: reference to a compiler-generated field
      class95.asyncCallback_0 = callback;
      // ISSUE: reference to a compiler-generated field
      class95.byte_0 = buffer;
      // ISSUE: reference to a compiler-generated field
      class95.class94_0 = new Stream1.Class94(state);
      // ISSUE: reference to a compiler-generated field
      if (class95.int_0 > 0)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Stream1.Class96 class96 = new Stream1.Class96();
        // ISSUE: reference to a compiler-generated field
        class96.class95_0 = class95;
        // ISSUE: reference to a compiler-generated field
        class96.int_0 = offset;
        // ISSUE: reference to a compiler-generated field
        class96.asyncCallback_0 = (AsyncCallback) null;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        class96.asyncCallback_0 = new AsyncCallback(class96.method_0);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.stream_0.BeginRead(class96.class95_0.byte_0, class96.int_0, class96.class95_0.int_0, class96.asyncCallback_0, state);
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        class95.class94_0.CompletedSynchronously = true;
        // ISSUE: reference to a compiler-generated field
        class95.class94_0.method_0();
        // ISSUE: reference to a compiler-generated field
        class95.class94_0.IsCompleted = true;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        class95.asyncCallback_0((IAsyncResult) class95.class94_0);
      }
      // ISSUE: reference to a compiler-generated field
      return (IAsyncResult) class95.class94_0;
    }

    public override int EndRead(IAsyncResult asyncResult)
    {
      asyncResult.AsyncWaitHandle.WaitOne();
      Stream1.Class94 class94 = (Stream1.Class94) asyncResult;
      if (class94.Exception != null)
        throw class94.Exception;
      return class94.int_0;
    }

    public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
    {
      throw new InvalidOperationException("Stream is not writable");
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
      throw new InvalidOperationException("Stream is not writable");
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
      if (this.ilist_1 == null)
      {
        foreach (Stream stream in (IEnumerable<Stream>) this.IList_0)
          stream.Dispose();
      }
      else
      {
        for (int index = 0; index < this.IList_0.Count; ++index)
          this.IList_0[index].Dispose();
      }
    }

    public override bool CanRead
    {
      get
      {
        return true;
      }
    }

    public override bool CanSeek
    {
      get
      {
        return false;
      }
    }

    public override bool CanWrite
    {
      get
      {
        return false;
      }
    }

    public override long Length
    {
      get
      {
        if (this.long_0 == -1L)
        {
          this.long_0 = 0L;
          foreach (Stream stream in (IEnumerable<Stream>) this.ilist_0)
            this.long_0 += stream.Length;
        }
        return this.long_0;
      }
    }

    public override long Position
    {
      get
      {
        return this.long_1;
      }
      set
      {
        throw new NotImplementedException();
      }
    }

    internal class Class94 : IAsyncResult
    {
      private readonly object object_0;
      private readonly ManualResetEvent manualResetEvent_0;
      public int int_0;

      public Class94(object object_1)
      {
        this.object_0 = object_1;
        this.manualResetEvent_0 = new ManualResetEvent(false);
      }

      public bool IsCompleted { get; internal set; }

      public WaitHandle AsyncWaitHandle
      {
        get
        {
          return (WaitHandle) this.manualResetEvent_0;
        }
      }

      public object AsyncState
      {
        get
        {
          return this.object_0;
        }
      }

      public bool CompletedSynchronously { get; internal set; }

      public Exception Exception { get; internal set; }

      internal void method_0()
      {
        this.manualResetEvent_0.Set();
      }
    }
  }
}

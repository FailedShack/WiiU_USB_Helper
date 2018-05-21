// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.Snes9x
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using ns0;
using System;
using System.IO;

namespace NusHelper.Emulators
{
  internal class Snes9x : GClass95
  {
    private readonly byte[] _titleTag = new byte[4]
    {
      (byte) 87,
      (byte) 85,
      (byte) 80,
      (byte) 45
    };

    public Snes9x(GClass30 title, bool forceUpdate)
      : base(title, nameof (Snes9x), "http://www.snes9x.com/", forceUpdate, false)
    {
    }

    public override bool DlcIsInstalled()
    {
      return false;
    }

    public override string GetArguments()
    {
      return base.GetArguments() + (this.FullScreen ? " -f" : "");
    }

    public override string GetExecutable()
    {
      return System.IO.Path.Combine(this.String_4, "snes9x.exe");
    }

    public override bool UpdateIsInstalled()
    {
      return false;
    }

    public override string GetRom()
    {
      return System.IO.Path.Combine(this.String_5, this.gclass30_0.method_12(), "rom.sfc");
    }

    protected override void PrepareRomIfNecessary(bool directDownload)
    {
      if (!Alphaleonis.Win32.Filesystem.File.Exists(this.GetRom()))
      {
        this.method_9(directDownload);
        using (BinaryReader binaryReader = new BinaryReader((Stream) Alphaleonis.Win32.Filesystem.File.Open(this.method_10(), FileMode.Open)))
        {
          using (FileStream fileStream = Alphaleonis.Win32.Filesystem.File.Create(this.GetRom()))
          {
            GClass95.smethod_0(binaryReader.BaseStream, this._titleTag);
            binaryReader.BaseStream.Seek(-22L, SeekOrigin.Current);
            byte[] buffer1 = new byte[2];
            binaryReader.Read(buffer1, 0, 2);
            Array.Reverse((Array) buffer1);
            long length = (long) ((int) BitConverter.ToUInt16(buffer1, 0) * 256);
            binaryReader.BaseStream.Seek(32L, SeekOrigin.Current);
            byte[] buffer2 = new byte[length];
            binaryReader.Read(buffer2, 0, buffer2.Length);
            fileStream.Write(buffer2, 0, buffer2.Length);
          }
        }
      }
      this.method_12(true);
    }
  }
}

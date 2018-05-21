// Decompiled with JetBrains decompiler
// Type: NusHelper.Emulators.Fceux
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using ns0;
using System;
using System.IO;

namespace NusHelper.Emulators
{
  internal class Fceux : GClass95
  {
    private readonly byte[] _nesTag = new byte[3]
    {
      (byte) 78,
      (byte) 69,
      (byte) 83
    };

    public Fceux(GClass30 title, bool forceUpdate)
      : base(title, nameof (Fceux), "http://www.fceux.com/", forceUpdate, false)
    {
    }

    public override bool DlcIsInstalled()
    {
      return false;
    }

    public override string GetExecutable()
    {
      return System.IO.Path.Combine(this.String_4, "fceux.exe");
    }

    public override bool UpdateIsInstalled()
    {
      return false;
    }

    public override string GetRom()
    {
      return System.IO.Path.Combine(this.CurrentGamePath, "rom.nes");
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
            GClass95.smethod_0(binaryReader.BaseStream, this._nesTag);
            binaryReader.BaseStream.Seek(-18L, SeekOrigin.Current);
            byte[] buffer1 = new byte[2];
            binaryReader.Read(buffer1, 0, 2);
            Array.Reverse((Array) buffer1);
            long length = (long) ((int) BitConverter.ToUInt16(buffer1, 0) * 256 + 12);
            binaryReader.BaseStream.Seek(20L, SeekOrigin.Current);
            fileStream.Write(new byte[4]
            {
              (byte) 78,
              (byte) 69,
              (byte) 83,
              (byte) 26
            }, 0, 4);
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

// Decompiled with JetBrains decompiler
// Type: ns0.GClass124
// Assembly: WiiU_USB_Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8A8903FC-BD1C-4FCE-9A9B-6F50F8E0D0D6
// Assembly location: C:\0.6.1.655\WiiU_USB_Helper-cleaned.exe

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ns0
{
  public static class GClass124
  {
    public static bool smethod_0(Bitmap bitmap_0, Stream stream_0, int int_0 = 16, bool bool_0 = false)
    {
      if (bitmap_0 == null)
        return false;
      float num1 = (float) int_0;
      float num2 = (float) int_0;
      if (bool_0)
      {
        if (bitmap_0.Width > bitmap_0.Height)
          num2 = (float) bitmap_0.Height / (float) bitmap_0.Width * (float) int_0;
        else
          num1 = (float) bitmap_0.Width / (float) bitmap_0.Height * (float) int_0;
      }
      Bitmap bitmap = new Bitmap((Image) bitmap_0, new Size((int) num1, (int) num2));
      if (bitmap == null)
        return false;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        bitmap.Save((Stream) memoryStream, ImageFormat.Png);
        BinaryWriter binaryWriter = new BinaryWriter(stream_0);
        if (stream_0 == null || binaryWriter == null)
          return false;
        binaryWriter.Write((byte) 0);
        binaryWriter.Write((byte) 0);
        binaryWriter.Write((short) 1);
        binaryWriter.Write((short) 1);
        binaryWriter.Write((byte) num1);
        binaryWriter.Write((byte) num2);
        binaryWriter.Write((byte) 0);
        binaryWriter.Write((byte) 0);
        binaryWriter.Write((short) 0);
        binaryWriter.Write((short) 32);
        binaryWriter.Write((int) memoryStream.Length);
        binaryWriter.Write(22);
        binaryWriter.Write(memoryStream.ToArray());
        binaryWriter.Flush();
      }
      return true;
    }
  }
}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ns0
{
	// Token: 0x02000137 RID: 311
	public static class GClass124
	{
		// Token: 0x0600087E RID: 2174 RVA: 0x00035BD8 File Offset: 0x00033DD8
		public static bool smethod_0(Bitmap bitmap_0, Stream stream_0, int int_0 = 16, bool bool_0 = false)
		{
			if (bitmap_0 == null)
			{
				return false;
			}
			float num = (float)int_0;
			float num2 = (float)int_0;
			if (bool_0)
			{
				if (bitmap_0.Width > bitmap_0.Height)
				{
					num2 = (float)bitmap_0.Height / (float)bitmap_0.Width * (float)int_0;
				}
				else
				{
					num = (float)bitmap_0.Width / (float)bitmap_0.Height * (float)int_0;
				}
			}
			Bitmap bitmap = new Bitmap(bitmap_0, new Size((int)num, (int)num2));
			if (bitmap == null)
			{
				return false;
			}
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitmap.Save(memoryStream, ImageFormat.Png);
				BinaryWriter binaryWriter = new BinaryWriter(stream_0);
				if (stream_0 == null || binaryWriter == null)
				{
					return false;
				}
				binaryWriter.Write(0);
				binaryWriter.Write(0);
				binaryWriter.Write(1);
				binaryWriter.Write(1);
				binaryWriter.Write((byte)num);
				binaryWriter.Write((byte)num2);
				binaryWriter.Write(0);
				binaryWriter.Write(0);
				binaryWriter.Write(0);
				binaryWriter.Write(32);
				binaryWriter.Write((int)memoryStream.Length);
				binaryWriter.Write(22);
				binaryWriter.Write(memoryStream.ToArray());
				binaryWriter.Flush();
			}
			return true;
		}
	}
}

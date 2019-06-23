using System;
using System.IO;
using System.Text;

namespace ns0
{
	// Token: 0x02000045 RID: 69
	internal class Class29
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00021FDC File Offset: 0x000201DC
		public static double smethod_0(byte[] byte_0)
		{
			int num = (int)byte_0[23];
			return Math.Pow(2.0, (double)num) / 128.0;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00022008 File Offset: 0x00020208
		public static bool smethod_1(MemoryStream memoryStream_0)
		{
			bool result = false;
			byte[] array = new byte[512];
			memoryStream_0.Read(array, 0, 512);
			Encoding ascii = Encoding.ASCII;
			string a = BitConverter.ToString(array, 8, 3);
			string @string = ascii.GetString(array, 0, 11);
			string a2 = BitConverter.ToString(array, 30, 16);
			if (a == "AA-BB-04" || @string == "GAME DOCTOR" || a2 == "00-00-00-00-00-00-00-00-00-00-00-00-00-00-00-00")
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000117DF File Offset: 0x0000F9DF
		public static double smethod_2(MemoryStream memoryStream_0)
		{
			return (double)memoryStream_0.Length / Math.Pow(2.0, 20.0);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00011800 File Offset: 0x0000FA00
		public static string smethod_3(byte[] byte_0)
		{
			return Encoding.GetEncoding(932).GetString(byte_0).Substring(0, 21).Trim();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00022080 File Offset: 0x00020280
		public static byte[] smethod_4(MemoryStream memoryStream_0, int int_0)
		{
			byte[] array = new byte[32];
			memoryStream_0.Seek((long)int_0, SeekOrigin.Begin);
			memoryStream_0.Read(array, 0, 32);
			return array;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000220AC File Offset: 0x000202AC
		public static int smethod_5(MemoryStream memoryStream_0, bool bool_0, int int_0, bool bool_1)
		{
			byte[] array = new byte[32];
			if (bool_0)
			{
				int_0 += 512;
			}
			memoryStream_0.Seek((long)int_0, SeekOrigin.Begin);
			memoryStream_0.Read(array, 0, 32);
			ushort num = BitConverter.ToUInt16(array, 28);
			ushort num2 = BitConverter.ToUInt16(array, 30);
			if (num + num2 == 65535)
			{
				return int_0;
			}
			if (!bool_1)
			{
				return int_0;
			}
			return Class29.smethod_5(memoryStream_0, bool_0, 32704, false);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001181F File Offset: 0x0000FA1F
		public static string smethod_6(byte[] byte_0)
		{
			if (byte_0[25] != 0)
			{
				if (byte_0[25] != 1)
				{
					return "PAL";
				}
			}
			return "NTSC";
		}
	}
}

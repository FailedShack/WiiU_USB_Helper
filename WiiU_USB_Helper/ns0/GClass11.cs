﻿using System;
using System.IO;

namespace ns0
{
	// Token: 0x02000017 RID: 23
	public static class GClass11
	{
		// Token: 0x0600005B RID: 91 RVA: 0x0001B694 File Offset: 0x00019894
		public static byte[] smethod_0(this BinaryReader binaryReader_0, int int_0)
		{
			byte[] array = binaryReader_0.ReadBytes(int_0);
			if (array.Length != int_0)
			{
				throw new EndOfStreamException(string.Format("{0} bytes required from stream, but only {1} returned.", int_0, array.Length));
			}
			return array;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00010B07 File Offset: 0x0000ED07
		public static short smethod_1(this BinaryReader binaryReader_0)
		{
			return BitConverter.ToInt16(binaryReader_0.smethod_0(2).smethod_5(), 0);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00010B1B File Offset: 0x0000ED1B
		public static int smethod_2(this BinaryReader binaryReader_0)
		{
			return BitConverter.ToInt32(binaryReader_0.smethod_0(4).smethod_5(), 0);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00010B2F File Offset: 0x0000ED2F
		public static ushort smethod_3(this BinaryReader binaryReader_0)
		{
			return BitConverter.ToUInt16(binaryReader_0.smethod_0(2).smethod_5(), 0);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00010B43 File Offset: 0x0000ED43
		public static uint smethod_4(this BinaryReader binaryReader_0)
		{
			return BitConverter.ToUInt32(binaryReader_0.smethod_0(4).smethod_5(), 0);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00010B57 File Offset: 0x0000ED57
		public static byte[] smethod_5(this byte[] byte_0)
		{
			Array.Reverse(byte_0);
			return byte_0;
		}
	}
}

using System;

namespace NusHelper
{
	// Token: 0x02000048 RID: 72
	public struct DataSize : IComparable<DataSize>, IComparable
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0001183B File Offset: 0x0000FA3B
		public DataSize(ulong sz)
		{
			this.TotalBytes = sz;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00011844 File Offset: 0x0000FA44
		public ulong TotalBytes { get; }

		// Token: 0x060001B7 RID: 439 RVA: 0x0001184C File Offset: 0x0000FA4C
		public static explicit operator DataSize(string number)
		{
			return new DataSize(ulong.Parse(number));
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00011859 File Offset: 0x0000FA59
		public static DataSize operator -(DataSize size1, DataSize size2)
		{
			if (size2.TotalBytes >= size1.TotalBytes)
			{
				return new DataSize(0UL);
			}
			return new DataSize(size1.TotalBytes - size2.TotalBytes);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001188E File Offset: 0x0000FA8E
		public static bool operator !=(DataSize size1, ulong size2)
		{
			return size1.TotalBytes != size2;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001189D File Offset: 0x0000FA9D
		public static bool operator !=(DataSize size1, DataSize size2)
		{
			return size1.TotalBytes != size2.TotalBytes;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000118B2 File Offset: 0x0000FAB2
		public static DataSize operator +(DataSize size, ulong bt)
		{
			return new DataSize(size.TotalBytes + bt);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000118C2 File Offset: 0x0000FAC2
		public static DataSize operator +(DataSize size, DataSize bt)
		{
			return new DataSize(size.TotalBytes + bt.TotalBytes);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000118D8 File Offset: 0x0000FAD8
		public static DataSize operator +(ulong bt, DataSize size)
		{
			return new DataSize(size.TotalBytes + bt);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000118E8 File Offset: 0x0000FAE8
		public static bool operator ==(DataSize size1, DataSize size2)
		{
			return size1.TotalBytes == size2.TotalBytes;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000118FA File Offset: 0x0000FAFA
		public static bool operator ==(DataSize size1, ulong size2)
		{
			return size1.TotalBytes == size2;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00022284 File Offset: 0x00020484
		public int CompareTo(DataSize other)
		{
			return this.TotalBytes.CompareTo(other.TotalBytes);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000222A8 File Offset: 0x000204A8
		public int CompareTo(object obj)
		{
			if (obj is DataSize)
			{
				return this.TotalBytes.CompareTo(((DataSize)obj).TotalBytes);
			}
			return -1;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00011906 File Offset: 0x0000FB06
		public DataSize Diff(DataSize size2)
		{
			return new DataSize((ulong)Math.Abs((long)(this.TotalBytes - size2.TotalBytes)));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000222DC File Offset: 0x000204DC
		public override bool Equals(object obj)
		{
			return obj is DataSize && ((DataSize)obj).TotalBytes == this.TotalBytes;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002230C File Offset: 0x0002050C
		public override string ToString()
		{
			if (this.TotalBytes < Math.Pow(10.0, 6.0))
			{
				return (this.TotalBytes / Math.Pow(10.0, 3.0)).ToString("F3") + " KB";
			}
			if (this.TotalBytes < Math.Pow(10.0, 9.0))
			{
				return (this.TotalBytes / Math.Pow(10.0, 6.0)).ToString("F3") + " MB";
			}
			if (this.TotalBytes < Math.Pow(10.0, 12.0))
			{
				return (this.TotalBytes / Math.Pow(10.0, 9.0)).ToString("F3") + " GB";
			}
			return (this.TotalBytes / Math.Pow(10.0, 12.0)).ToString("F3") + " TB";
		}
	}
}

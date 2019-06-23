using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace ns0
{
	// Token: 0x0200003A RID: 58
	public static class GClass18
	{
		// Token: 0x0600016C RID: 364
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr FindWindow(string string_0, string string_1);

		// Token: 0x0600016D RID: 365
		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr intptr_0, out GClass18.GStruct1 gstruct1_0);

		// Token: 0x0600016E RID: 366
		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr intptr_0, ref GClass18.GStruct1 gstruct1_0);

		// Token: 0x0600016F RID: 367
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowTextLength(IntPtr intptr_0);

		// Token: 0x06000170 RID: 368
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowVisible(IntPtr intptr_0);

		// Token: 0x06000171 RID: 369
		[DllImport("kernel32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetFileTime(SafeFileHandle safeFileHandle_0, ref long long_0, ref long long_1, ref long long_2);

		// Token: 0x06000172 RID: 370
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetWindowPos(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, GClass18.GEnum0 genum0_0);

		// Token: 0x06000173 RID: 371 RVA: 0x00011627 File Offset: 0x0000F827
		public static void smethod_0(IntPtr intptr_0, IntPtr intptr_1)
		{
			GClass18.SetWindowPos(intptr_0, intptr_1, 0, 0, 0, 0, GClass18.GEnum0.flag_7 | GClass18.GEnum0.flag_12);
		}

		// Token: 0x0200003B RID: 59
		[Flags]
		public enum GEnum0 : uint
		{
			// Token: 0x040000AE RID: 174
			flag_0 = 16384u,
			// Token: 0x040000AF RID: 175
			flag_1 = 8192u,
			// Token: 0x040000B0 RID: 176
			flag_2 = 32u,
			// Token: 0x040000B1 RID: 177
			flag_3 = 32u,
			// Token: 0x040000B2 RID: 178
			flag_4 = 128u,
			// Token: 0x040000B3 RID: 179
			flag_5 = 16u,
			// Token: 0x040000B4 RID: 180
			flag_6 = 256u,
			// Token: 0x040000B5 RID: 181
			flag_7 = 2u,
			// Token: 0x040000B6 RID: 182
			flag_8 = 512u,
			// Token: 0x040000B7 RID: 183
			flag_9 = 8u,
			// Token: 0x040000B8 RID: 184
			flag_10 = 512u,
			// Token: 0x040000B9 RID: 185
			flag_11 = 1024u,
			// Token: 0x040000BA RID: 186
			flag_12 = 1u,
			// Token: 0x040000BB RID: 187
			flag_13 = 4u,
			// Token: 0x040000BC RID: 188
			flag_14 = 64u
		}

		// Token: 0x0200003C RID: 60
		public struct GStruct1
		{
			// Token: 0x06000174 RID: 372 RVA: 0x00011636 File Offset: 0x0000F836
			public GStruct1(int int_4, int int_5, int int_6, int int_7)
			{
				this.int_0 = int_4;
				this.int_1 = int_5;
				this.int_2 = int_6;
				this.int_3 = int_7;
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00011655 File Offset: 0x0000F855
			// (set) Token: 0x06000176 RID: 374 RVA: 0x00011664 File Offset: 0x0000F864
			public int Int32_0
			{
				get
				{
					return this.int_2 - this.int_0;
				}
				set
				{
					this.int_2 = value + this.int_0;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000177 RID: 375 RVA: 0x00011674 File Offset: 0x0000F874
			// (set) Token: 0x06000178 RID: 376 RVA: 0x00011683 File Offset: 0x0000F883
			public int Int32_1
			{
				get
				{
					return this.int_3 - this.int_1;
				}
				set
				{
					this.int_3 = value + this.int_1;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000179 RID: 377 RVA: 0x00011693 File Offset: 0x0000F893
			public Point Point_0
			{
				get
				{
					return new Point(this.int_0, this.int_1);
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600017A RID: 378 RVA: 0x000116A6 File Offset: 0x0000F8A6
			public Size Size_0
			{
				get
				{
					return new Size(this.Int32_0, this.Int32_1);
				}
			}

			// Token: 0x040000BD RID: 189
			public int int_0;

			// Token: 0x040000BE RID: 190
			public int int_1;

			// Token: 0x040000BF RID: 191
			public int int_2;

			// Token: 0x040000C0 RID: 192
			public int int_3;
		}

		// Token: 0x0200003D RID: 61
		public static class GClass19
		{
			// Token: 0x040000C1 RID: 193
			public static readonly int int_0 = 1;

			// Token: 0x040000C2 RID: 194
			public static readonly int int_1 = 2;

			// Token: 0x040000C3 RID: 195
			public static readonly int int_2 = 4;

			// Token: 0x040000C4 RID: 196
			public static readonly int int_3 = 8;

			// Token: 0x040000C5 RID: 197
			public static readonly int int_4 = 16;

			// Token: 0x040000C6 RID: 198
			public static readonly int int_5 = 32;

			// Token: 0x040000C7 RID: 199
			public static readonly int int_6 = 32;

			// Token: 0x040000C8 RID: 200
			public static readonly int int_7 = 64;

			// Token: 0x040000C9 RID: 201
			public static readonly int int_8 = 128;

			// Token: 0x040000CA RID: 202
			public static readonly int int_9 = 256;

			// Token: 0x040000CB RID: 203
			public static readonly int int_10 = 512;

			// Token: 0x040000CC RID: 204
			public static readonly int int_11 = 512;

			// Token: 0x040000CD RID: 205
			public static readonly int int_12 = 1024;

			// Token: 0x040000CE RID: 206
			public static readonly int int_13 = 8192;

			// Token: 0x040000CF RID: 207
			public static readonly int int_14 = 16384;
		}
	}
}

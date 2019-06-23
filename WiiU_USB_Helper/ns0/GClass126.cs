using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using WIIU_Downloader;

namespace ns0
{
	// Token: 0x0200013D RID: 317
	public class GClass126
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000157D5 File Offset: 0x000139D5
		public static bool Boolean_0
		{
			get
			{
				return GClass126.smethod_4() >= 300u;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x000157E6 File Offset: 0x000139E6
		public static MinerPofile MinerPofile_0
		{
			get
			{
				if (!GClass126.Boolean_0)
				{
					return MinerPofile.ACTIVE;
				}
				return MinerPofile.IDLE;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x000157F2 File Offset: 0x000139F2
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x000157FA File Offset: 0x000139FA
		public MinerPofile Profile { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00015803 File Offset: 0x00013A03
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0001580B File Offset: 0x00013A0B
		public bool StopWhenPlaying { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00015814 File Offset: 0x00013A14
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0001581C File Offset: 0x00013A1C
		public int ThreadCount { get; set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00015825 File Offset: 0x00013A25
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x0001582D File Offset: 0x00013A2D
		public bool UseGpu { get; set; }

		// Token: 0x0600089A RID: 2202 RVA: 0x000360FC File Offset: 0x000342FC
		public static GClass126 smethod_0(MinerPofile minerPofile_1)
		{
			GClass126 result;
			try
			{
				result = JsonConvert.DeserializeObject<GClass126>(File.ReadAllText(GClass126.smethod_3(minerPofile_1)));
			}
			catch
			{
				result = GClass126.smethod_2(minerPofile_1);
			}
			return result;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00015836 File Offset: 0x00013A36
		public void method_0()
		{
			File.WriteAllText(GClass126.smethod_3(this.Profile), JsonConvert.SerializeObject(this));
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0001584E File Offset: 0x00013A4E
		private static int smethod_1()
		{
			return Environment.ProcessorCount;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00036138 File Offset: 0x00034338
		private static GClass126 smethod_2(MinerPofile minerPofile_1)
		{
			if (minerPofile_1 == MinerPofile.ACTIVE)
			{
				return new GClass126
				{
					UseGpu = false,
					ThreadCount = 1,
					StopWhenPlaying = true
				};
			}
			if (minerPofile_1 != MinerPofile.IDLE)
			{
				return null;
			}
			return new GClass126
			{
				UseGpu = true,
				ThreadCount = GClass126.smethod_1(),
				StopWhenPlaying = true
			};
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00015855 File Offset: 0x00013A55
		private static string smethod_3(MinerPofile minerPofile_1)
		{
			return Path.Combine(GClass88.CachePath, "miner", Enum.GetName(typeof(MinerPofile), minerPofile_1) + ".json");
		}

		// Token: 0x0600089F RID: 2207
		[DllImport("user32.dll")]
		private static extern bool GetLastInputInfo(ref GClass126.Struct0 struct0_0);

		// Token: 0x060008A0 RID: 2208 RVA: 0x00036188 File Offset: 0x00034388
		private static uint smethod_4()
		{
			uint num = 0u;
			GClass126.Struct0 @struct = default(GClass126.Struct0);
			@struct.uint_0 = (uint)Marshal.SizeOf(@struct);
			@struct.uint_1 = 0u;
			uint tickCount = (uint)Environment.TickCount;
			if (GClass126.GetLastInputInfo(ref @struct))
			{
				uint uint_ = @struct.uint_1;
				num = tickCount - uint_;
			}
			if (num <= 0u)
			{
				return 0u;
			}
			return num / 1000u;
		}

		// Token: 0x0400050C RID: 1292
		[CompilerGenerated]
		private MinerPofile minerPofile_0;

		// Token: 0x0400050D RID: 1293
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400050E RID: 1294
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400050F RID: 1295
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000510 RID: 1296
		private const int int_1 = 300;

		// Token: 0x0200013E RID: 318
		private struct Struct0
		{
			// Token: 0x04000511 RID: 1297
			public static readonly int int_0 = Marshal.SizeOf(typeof(GClass126.Struct0));

			// Token: 0x04000512 RID: 1298
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_0;

			// Token: 0x04000513 RID: 1299
			[MarshalAs(UnmanagedType.U4)]
			public uint uint_1;
		}
	}
}

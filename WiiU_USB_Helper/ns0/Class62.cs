using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x020000B3 RID: 179
	internal static class Class62
	{
		// Token: 0x06000494 RID: 1172
		[DllImport("kernel32.dll")]
		public static extern uint SetThreadExecutionState(uint uint_2);

		// Token: 0x040002E8 RID: 744
		public const uint uint_0 = 2147483648u;

		// Token: 0x040002E9 RID: 745
		public const uint uint_1 = 1u;
	}
}

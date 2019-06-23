using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000215 RID: 533
	[TypeIdentifier]
	[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
	[CompilerGenerated]
	[ComImport]
	public interface IWshShell3 : IWshShell2
	{
		// Token: 0x06000E1C RID: 3612
		void _VtblGap1_4();

		// Token: 0x06000E1D RID: 3613
		[DispId(1002)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateShortcut([MarshalAs(UnmanagedType.BStr)] [In] string PathLink);
	}
}

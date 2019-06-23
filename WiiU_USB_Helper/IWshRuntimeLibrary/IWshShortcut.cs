using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x02000216 RID: 534
	[DefaultMember("FullName")]
	[CompilerGenerated]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShortcut
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000E1E RID: 3614
		[DispId(0)]
		string FullName { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000E1F RID: 3615
		// (set) Token: 0x06000E20 RID: 3616
		[DispId(1000)]
		string Arguments { [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E21 RID: 3617
		// (set) Token: 0x06000E22 RID: 3618
		[DispId(1001)]
		string Description { [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000E23 RID: 3619
		void _VtblGap1_2();

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E24 RID: 3620
		// (set) Token: 0x06000E25 RID: 3621
		[DispId(1003)]
		string IconLocation { [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000E26 RID: 3622
		void _VtblGap2_1();

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000E27 RID: 3623
		// (set) Token: 0x06000E28 RID: 3624
		[DispId(1005)]
		string TargetPath { [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000E29 RID: 3625
		void _VtblGap3_2();

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000E2A RID: 3626
		// (set) Token: 0x06000E2B RID: 3627
		[DispId(1007)]
		string WorkingDirectory { [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] set; }

		// Token: 0x06000E2C RID: 3628
		void _VtblGap4_1();

		// Token: 0x06000E2D RID: 3629
		[DispId(2001)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Save();
	}
}

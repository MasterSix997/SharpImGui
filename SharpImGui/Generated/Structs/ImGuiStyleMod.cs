using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyleMod
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiStyleModUnion
		{
			[FieldOffset(0)]
			public unsafe int* BackupInt;
			[FieldOffset(0)]
			public unsafe Vector2* BackupFloat;
		}
		public ImGuiStyleVar VarIdx;
		public ImGuiStyleModUnion Union;
	}
}

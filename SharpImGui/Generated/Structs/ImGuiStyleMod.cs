using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.<br/>
	/// </summary>
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

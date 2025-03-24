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
			public int BackupInt_0;
			[FieldOffset(0)]
			public int BackupInt_1;
			[FieldOffset(0)]
			public float BackupFloat_0;
			[FieldOffset(0)]
			public float BackupFloat_1;
		}
		public ImGuiStyleVar VarIdx;
		public ImGuiStyleModUnion Union;
	}
}

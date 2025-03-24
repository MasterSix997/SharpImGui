using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// [Internal] Key+Value for ImGuiStorage<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStoragePair
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiStoragePairUnion
		{
			[FieldOffset(0)]
			public int val_i;
			[FieldOffset(0)]
			public float val_f;
			[FieldOffset(0)]
			public unsafe void* val_p;
		}
		public uint key;
		public ImGuiStoragePairUnion Union;
	}
}

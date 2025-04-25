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
		public uint Key;
		public ImGuiStoragePairUnion Union;
	}

	/// <summary>
	/// [Internal] Key+Value for ImGuiStorage<br/>
	/// </summary>
	public unsafe partial struct ImGuiStoragePairPtr
	{
		public ImGuiStoragePair* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStoragePair this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiStoragePairPtr(ImGuiStoragePair* nativePtr) => NativePtr = nativePtr;
		public ImGuiStoragePairPtr(IntPtr nativePtr) => NativePtr = (ImGuiStoragePair*)nativePtr;
		public static implicit operator ImGuiStoragePairPtr(ImGuiStoragePair* ptr) => new ImGuiStoragePairPtr(ptr);
		public static implicit operator ImGuiStoragePairPtr(IntPtr ptr) => new ImGuiStoragePairPtr(ptr);
		public static implicit operator ImGuiStoragePair*(ImGuiStoragePairPtr nativePtr) => nativePtr.NativePtr;
	}
}

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

	/// <summary>
	/// Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.<br/>
	/// </summary>
	public unsafe partial struct ImGuiStyleModPtr
	{
		public ImGuiStyleMod* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStyleMod this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
		public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* ptr) => new ImGuiStyleModPtr(ptr);
		public static implicit operator ImGuiStyleModPtr(IntPtr ptr) => new ImGuiStyleModPtr(ptr);
		public static implicit operator ImGuiStyleMod*(ImGuiStyleModPtr nativePtr) => nativePtr.NativePtr;
	}
}

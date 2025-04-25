using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Stacked color modifier, backup of modified data so we can restore it<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiColorMod
	{
		public ImGuiCol Col;
		public Vector4 BackupValue;
	}

	/// <summary>
	/// Stacked color modifier, backup of modified data so we can restore it<br/>
	/// </summary>
	public unsafe partial struct ImGuiColorModPtr
	{
		public ImGuiColorMod* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiColorMod this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiColorModPtr(ImGuiColorMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiColorModPtr(IntPtr nativePtr) => NativePtr = (ImGuiColorMod*)nativePtr;
		public static implicit operator ImGuiColorModPtr(ImGuiColorMod* ptr) => new ImGuiColorModPtr(ptr);
		public static implicit operator ImGuiColorModPtr(IntPtr ptr) => new ImGuiColorModPtr(ptr);
		public static implicit operator ImGuiColorMod*(ImGuiColorModPtr nativePtr) => nativePtr.NativePtr;
	}
}

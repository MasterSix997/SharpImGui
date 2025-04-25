using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyleVarInfo
	{
		/// <summary>
		/// 1+<br/>
		/// </summary>
		public uint Count;
		public ImGuiDataType DataType;
		/// <summary>
		/// Offset in parent structure<br/>
		/// </summary>
		public uint Offset;
	}

	public unsafe partial struct ImGuiStyleVarInfoPtr
	{
		public ImGuiStyleVarInfo* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStyleVarInfo this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiStyleVarInfoPtr(ImGuiStyleVarInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiStyleVarInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleVarInfo*)nativePtr;
		public static implicit operator ImGuiStyleVarInfoPtr(ImGuiStyleVarInfo* ptr) => new ImGuiStyleVarInfoPtr(ptr);
		public static implicit operator ImGuiStyleVarInfoPtr(IntPtr ptr) => new ImGuiStyleVarInfoPtr(ptr);
		public static implicit operator ImGuiStyleVarInfo*(ImGuiStyleVarInfoPtr nativePtr) => nativePtr.NativePtr;
	}
}

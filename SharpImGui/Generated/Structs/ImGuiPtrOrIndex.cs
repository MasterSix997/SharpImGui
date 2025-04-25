using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPtrOrIndex
	{
		/// <summary>
		/// Either field can be set, not both. e.g. Dock node tab bars are loose while BeginTabBar() ones are in a pool.<br/>
		/// </summary>
		public unsafe void* Ptr;
		/// <summary>
		/// Usually index in a main pool.<br/>
		/// </summary>
		public int Index;
	}

	public unsafe partial struct ImGuiPtrOrIndexPtr
	{
		public ImGuiPtrOrIndex* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPtrOrIndex this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => NativePtr = nativePtr;
		public ImGuiPtrOrIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiPtrOrIndex*)nativePtr;
		public static implicit operator ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* ptr) => new ImGuiPtrOrIndexPtr(ptr);
		public static implicit operator ImGuiPtrOrIndexPtr(IntPtr ptr) => new ImGuiPtrOrIndexPtr(ptr);
		public static implicit operator ImGuiPtrOrIndex*(ImGuiPtrOrIndexPtr nativePtr) => nativePtr.NativePtr;
	}
}

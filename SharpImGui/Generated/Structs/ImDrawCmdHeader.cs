using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// <br/>[Internal] For use by ImDrawList<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawCmdHeader
	{
		public Vector4 ClipRect;
		public IntPtr TextureId;
		public uint VtxOffset;
	}

	/// <summary>
	/// <br/>[Internal] For use by ImDrawList<br/>
	/// </summary>
	public unsafe partial struct ImDrawCmdHeaderPtr
	{
		public ImDrawCmdHeader* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawCmdHeader this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImDrawCmdHeaderPtr(ImDrawCmdHeader* nativePtr) => NativePtr = nativePtr;
		public ImDrawCmdHeaderPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmdHeader*)nativePtr;
		public static implicit operator ImDrawCmdHeaderPtr(ImDrawCmdHeader* ptr) => new ImDrawCmdHeaderPtr(ptr);
		public static implicit operator ImDrawCmdHeaderPtr(IntPtr ptr) => new ImDrawCmdHeaderPtr(ptr);
		public static implicit operator ImDrawCmdHeader*(ImDrawCmdHeaderPtr nativePtr) => nativePtr.NativePtr;
	}
}

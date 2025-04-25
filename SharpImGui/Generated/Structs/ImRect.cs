using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImRect
	{
		/// <summary>
		/// Upper-left<br/>
		/// </summary>
		public Vector2 Min;
		/// <summary>
		/// Lower-right<br/>
		/// </summary>
		public Vector2 Max;
	}

	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	public unsafe partial struct ImRectPtr
	{
		public ImRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
		public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
		public static implicit operator ImRectPtr(ImRect* ptr) => new ImRectPtr(ptr);
		public static implicit operator ImRectPtr(IntPtr ptr) => new ImRectPtr(ptr);
		public static implicit operator ImRect*(ImRectPtr nativePtr) => nativePtr.NativePtr;
	}
}

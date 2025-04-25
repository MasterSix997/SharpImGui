using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImBitVector<br/>Store 1-bit per value.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImBitVector
	{
		public ImVector<uint> Storage;
	}

	/// <summary>
	/// Helper: ImBitVector<br/>Store 1-bit per value.<br/>
	/// </summary>
	public unsafe partial struct ImBitVectorPtr
	{
		public ImBitVector* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImBitVector this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImBitVectorPtr(ImBitVector* nativePtr) => NativePtr = nativePtr;
		public ImBitVectorPtr(IntPtr nativePtr) => NativePtr = (ImBitVector*)nativePtr;
		public static implicit operator ImBitVectorPtr(ImBitVector* ptr) => new ImBitVectorPtr(ptr);
		public static implicit operator ImBitVectorPtr(IntPtr ptr) => new ImBitVectorPtr(ptr);
		public static implicit operator ImBitVector*(ImBitVectorPtr nativePtr) => nativePtr.NativePtr;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImGuiTextIndex<br/>Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextIndex
	{
		public ImVector<int> LineOffsets;
		/// <summary>
		/// Because we don't own text buffer we need to maintain EndOffset (may bake in LineOffsets?)<br/>
		/// </summary>
		public int EndOffset;
	}

	/// <summary>
	/// Helper: ImGuiTextIndex<br/>Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextIndexPtr
	{
		public ImGuiTextIndex* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextIndex this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTextIndexPtr(ImGuiTextIndex* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextIndex*)nativePtr;
		public static implicit operator ImGuiTextIndexPtr(ImGuiTextIndex* ptr) => new ImGuiTextIndexPtr(ptr);
		public static implicit operator ImGuiTextIndexPtr(IntPtr ptr) => new ImGuiTextIndexPtr(ptr);
		public static implicit operator ImGuiTextIndex*(ImGuiTextIndexPtr nativePtr) => nativePtr.NativePtr;
	}
}

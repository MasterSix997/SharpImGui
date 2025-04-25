using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextBuffer
	{
		public ImVector<byte> Buf;
	}

	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextBufferPtr
	{
		public ImGuiTextBuffer* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextBuffer this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextBufferPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextBuffer*)nativePtr;
		public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* ptr) => new ImGuiTextBufferPtr(ptr);
		public static implicit operator ImGuiTextBufferPtr(IntPtr ptr) => new ImGuiTextBufferPtr(ptr);
		public static implicit operator ImGuiTextBuffer*(ImGuiTextBufferPtr nativePtr) => nativePtr.NativePtr;
	}
}

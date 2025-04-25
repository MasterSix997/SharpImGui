using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.<br/>This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawListSplitter
	{
		/// <summary>
		/// Current channel number (0)<br/>
		/// </summary>
		public int Current;
		/// <summary>
		/// Number of active channels (1+)<br/>
		/// </summary>
		public int Count;
		/// <summary>
		/// Draw channels (not resized down so _Count might be &lt; Channels.Size)<br/>
		/// </summary>
		public ImVector<ImDrawChannel> Channels;
	}

	/// <summary>
	/// Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.<br/>This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.<br/>
	/// </summary>
	public unsafe partial struct ImDrawListSplitterPtr
	{
		public ImDrawListSplitter* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawListSplitter this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) => NativePtr = nativePtr;
		public ImDrawListSplitterPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSplitter*)nativePtr;
		public static implicit operator ImDrawListSplitterPtr(ImDrawListSplitter* ptr) => new ImDrawListSplitterPtr(ptr);
		public static implicit operator ImDrawListSplitterPtr(IntPtr ptr) => new ImDrawListSplitterPtr(ptr);
		public static implicit operator ImDrawListSplitter*(ImDrawListSplitterPtr nativePtr) => nativePtr.NativePtr;
	}
}

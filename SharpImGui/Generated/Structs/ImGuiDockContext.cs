using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockContext
	{
		/// <summary>
		/// Map ID -&gt; ImGuiDockNode*: Active nodes<br/>
		/// </summary>
		public ImGuiStorage Nodes;
		public ImVector<EmptyStruct> Requests;
		public ImVector<EmptyStruct> NodesSettings;
		public byte WantFullRebuild;
	}

	public unsafe partial struct ImGuiDockContextPtr
	{
		public ImGuiDockContext* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDockContext this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiDockContextPtr(ImGuiDockContext* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockContextPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockContext*)nativePtr;
		public static implicit operator ImGuiDockContextPtr(ImGuiDockContext* ptr) => new ImGuiDockContextPtr(ptr);
		public static implicit operator ImGuiDockContextPtr(IntPtr ptr) => new ImGuiDockContextPtr(ptr);
		public static implicit operator ImGuiDockContext*(ImGuiDockContextPtr nativePtr) => nativePtr.NativePtr;
	}
}

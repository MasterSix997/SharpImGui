using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImNodesEditorContext
	{
	}

	public unsafe partial struct ImNodesEditorContextPtr
	{
		public ImNodesEditorContext* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImNodesEditorContext this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImNodesEditorContextPtr(ImNodesEditorContext* nativePtr) => NativePtr = nativePtr;
		public ImNodesEditorContextPtr(IntPtr nativePtr) => NativePtr = (ImNodesEditorContext*)nativePtr;
		public static implicit operator ImNodesEditorContextPtr(ImNodesEditorContext* ptr) => new ImNodesEditorContextPtr(ptr);
		public static implicit operator ImNodesEditorContextPtr(IntPtr ptr) => new ImNodesEditorContextPtr(ptr);
		public static implicit operator ImNodesEditorContext*(ImNodesEditorContextPtr nativePtr) => nativePtr.NativePtr;
	}
}

using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImNodesContext
	{
	}

	public unsafe partial struct ImNodesContextPtr
	{
		public ImNodesContext* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImNodesContext this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImNodesContextPtr(ImNodesContext* nativePtr) => NativePtr = nativePtr;
		public ImNodesContextPtr(IntPtr nativePtr) => NativePtr = (ImNodesContext*)nativePtr;
		public static implicit operator ImNodesContextPtr(ImNodesContext* ptr) => new ImNodesContextPtr(ptr);
		public static implicit operator ImNodesContextPtr(IntPtr ptr) => new ImNodesContextPtr(ptr);
		public static implicit operator ImNodesContext*(ImNodesContextPtr nativePtr) => nativePtr.NativePtr;
	}
}

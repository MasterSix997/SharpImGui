using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct LinkDetachWithModifierClick
	{
		public unsafe byte* Modifier;
	}

	public unsafe partial struct LinkDetachWithModifierClickPtr
	{
		public LinkDetachWithModifierClick* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public LinkDetachWithModifierClick this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* nativePtr) => NativePtr = nativePtr;
		public LinkDetachWithModifierClickPtr(IntPtr nativePtr) => NativePtr = (LinkDetachWithModifierClick*)nativePtr;
		public static implicit operator LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* ptr) => new LinkDetachWithModifierClickPtr(ptr);
		public static implicit operator LinkDetachWithModifierClickPtr(IntPtr ptr) => new LinkDetachWithModifierClickPtr(ptr);
		public static implicit operator LinkDetachWithModifierClick*(LinkDetachWithModifierClickPtr nativePtr) => nativePtr.NativePtr;
	}
}

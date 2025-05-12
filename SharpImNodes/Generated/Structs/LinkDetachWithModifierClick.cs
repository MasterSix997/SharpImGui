using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		public IntPtr Modifier { get => (IntPtr)NativePtr->Modifier; set => NativePtr->Modifier = (byte*)value; }
		public LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* nativePtr) => NativePtr = nativePtr;
		public LinkDetachWithModifierClickPtr(IntPtr nativePtr) => NativePtr = (LinkDetachWithModifierClick*)nativePtr;
		public static implicit operator LinkDetachWithModifierClickPtr(LinkDetachWithModifierClick* ptr) => new LinkDetachWithModifierClickPtr(ptr);
		public static implicit operator LinkDetachWithModifierClickPtr(IntPtr ptr) => new LinkDetachWithModifierClickPtr(ptr);
		public static implicit operator LinkDetachWithModifierClick*(LinkDetachWithModifierClickPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImNodesNative.LinkDetachWithModifierClickDestroy(NativePtr);
		}

		public LinkDetachWithModifierClickPtr LinkDetachWithModifierClick()
		{
			return ImNodesNative.LinkDetachWithModifierClickLinkDetachWithModifierClick();
		}

	}
}

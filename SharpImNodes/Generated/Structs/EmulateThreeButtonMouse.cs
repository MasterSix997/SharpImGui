using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct EmulateThreeButtonMouse
	{
		public unsafe byte* Modifier;
	}

	public unsafe partial struct EmulateThreeButtonMousePtr
	{
		public EmulateThreeButtonMouse* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public EmulateThreeButtonMouse this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public IntPtr Modifier { get => (IntPtr)NativePtr->Modifier; set => NativePtr->Modifier = (byte*)value; }
		public EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* nativePtr) => NativePtr = nativePtr;
		public EmulateThreeButtonMousePtr(IntPtr nativePtr) => NativePtr = (EmulateThreeButtonMouse*)nativePtr;
		public static implicit operator EmulateThreeButtonMousePtr(EmulateThreeButtonMouse* ptr) => new EmulateThreeButtonMousePtr(ptr);
		public static implicit operator EmulateThreeButtonMousePtr(IntPtr ptr) => new EmulateThreeButtonMousePtr(ptr);
		public static implicit operator EmulateThreeButtonMouse*(EmulateThreeButtonMousePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImNodesNative.EmulateThreeButtonMouseDestroy(NativePtr);
		}

		public EmulateThreeButtonMousePtr EmulateThreeButtonMouse()
		{
			return ImNodesNative.EmulateThreeButtonMouseEmulateThreeButtonMouse();
		}

	}
}

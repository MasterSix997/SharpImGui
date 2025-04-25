using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawDataBuilder
	{
		/// <summary>
		/// Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.<br/>
		/// </summary>
		public unsafe ImVector<ImDrawListPtr>* Layers_0;
		public unsafe ImVector<ImDrawListPtr>* Layers_1;
		public ImVector<ImDrawListPtr> LayerData1;
	}

	public unsafe partial struct ImDrawDataBuilderPtr
	{
		public ImDrawDataBuilder* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawDataBuilder this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => NativePtr = nativePtr;
		public ImDrawDataBuilderPtr(IntPtr nativePtr) => NativePtr = (ImDrawDataBuilder*)nativePtr;
		public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* ptr) => new ImDrawDataBuilderPtr(ptr);
		public static implicit operator ImDrawDataBuilderPtr(IntPtr ptr) => new ImDrawDataBuilderPtr(ptr);
		public static implicit operator ImDrawDataBuilder*(ImDrawDataBuilderPtr nativePtr) => nativePtr.NativePtr;
	}
}

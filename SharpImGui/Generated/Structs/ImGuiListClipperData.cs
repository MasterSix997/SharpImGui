using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Temporary clipper data, buffers shared/reused between instances<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperData
	{
		public unsafe ImGuiListClipper* ListClipper;
		public float LossynessOffset;
		public int StepNo;
		public int ItemsFrozen;
		public ImVector<ImGuiListClipperRange> Ranges;
	}

	/// <summary>
	/// Temporary clipper data, buffers shared/reused between instances<br/>
	/// </summary>
	public unsafe partial struct ImGuiListClipperDataPtr
	{
		public ImGuiListClipperData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiListClipperData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiListClipperDataPtr(ImGuiListClipperData* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperData*)nativePtr;
		public static implicit operator ImGuiListClipperDataPtr(ImGuiListClipperData* ptr) => new ImGuiListClipperDataPtr(ptr);
		public static implicit operator ImGuiListClipperDataPtr(IntPtr ptr) => new ImGuiListClipperDataPtr(ptr);
		public static implicit operator ImGuiListClipperData*(ImGuiListClipperDataPtr nativePtr) => nativePtr.NativePtr;
	}
}

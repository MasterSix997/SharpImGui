using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMetricsConfig
	{
		public byte ShowDebugLog;
		public byte ShowIdStackTool;
		public byte ShowWindowsRects;
		public byte ShowWindowsBeginOrder;
		public byte ShowTablesRects;
		public byte ShowDrawCmdMesh;
		public byte ShowDrawCmdBoundingBoxes;
		public byte ShowTextEncodingViewer;
		public byte ShowDockingNodes;
		public int ShowWindowsRectsType;
		public int ShowTablesRectsType;
		public int HighlightMonitorIdx;
		public uint HighlightViewportID;
	}

	public unsafe partial struct ImGuiMetricsConfigPtr
	{
		public ImGuiMetricsConfig* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiMetricsConfig this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => NativePtr = nativePtr;
		public ImGuiMetricsConfigPtr(IntPtr nativePtr) => NativePtr = (ImGuiMetricsConfig*)nativePtr;
		public static implicit operator ImGuiMetricsConfigPtr(ImGuiMetricsConfig* ptr) => new ImGuiMetricsConfigPtr(ptr);
		public static implicit operator ImGuiMetricsConfigPtr(IntPtr ptr) => new ImGuiMetricsConfigPtr(ptr);
		public static implicit operator ImGuiMetricsConfig*(ImGuiMetricsConfigPtr nativePtr) => nativePtr.NativePtr;
	}
}

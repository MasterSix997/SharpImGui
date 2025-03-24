using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMetricsConfig
	{
		public byte ShowDebugLog;
		public byte ShowIDStackTool;
		public byte ShowWindowsRects;
		public byte ShowWindowsBeginOrder;
		public byte ShowTablesRects;
		public byte ShowDrawCmdMesh;
		public byte ShowDrawCmdBoundingBoxes;
		public byte ShowTextEncodingViewer;
		public byte ShowAtlasTintedWithTextColor;
		public byte ShowDockingNodes;
		public int ShowWindowsRectsType;
		public int ShowTablesRectsType;
		public int HighlightMonitorIdx;
		public uint HighlightViewportID;
	}
}

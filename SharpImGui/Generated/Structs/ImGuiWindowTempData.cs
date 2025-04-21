using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowTempData
	{
		public Vector2 CursorPos;
		public Vector2 CursorPosPrevLine;
		public Vector2 CursorStartPos;
		public Vector2 CursorMaxPos;
		public Vector2 IdealMaxPos;
		public Vector2 CurrLineSize;
		public Vector2 PrevLineSize;
		public float CurrLineTextBaseOffset;
		public float PrevLineTextBaseOffset;
		public byte IsSameLine;
		public byte IsSetPos;
		public ImVec1 Indent;
		public ImVec1 ColumnsOffset;
		public ImVec1 GroupOffset;
		public Vector2 CursorStartPosLossyness;
		public ImGuiNavLayer NavLayerCurrent;
		public short NavLayersActiveMask;
		public short NavLayersActiveMaskNext;
		public byte NavIsScrollPushableX;
		public byte NavHideHighlightOneFrame;
		public byte NavWindowHasScrollY;
		public byte MenuBarAppending;
		public Vector2 MenuBarOffset;
		public ImGuiMenuColumns MenuColumns;
		public int TreeDepth;
		public uint TreeHasStackDataDepthMask;
		public ImVector<ImGuiWindowPtr> ChildWindows;
		public unsafe ImGuiStorage* StateStorage;
		public unsafe ImGuiOldColumns* CurrentColumns;
		public int CurrentTableIdx;
		public ImGuiLayoutType LayoutType;
		public ImGuiLayoutType ParentLayoutType;
		public uint ModalDimBgColor;
		public ImGuiItemStatusFlags WindowItemStatusFlags;
		public ImGuiItemStatusFlags ChildItemStatusFlags;
		public ImGuiItemStatusFlags DockTabItemStatusFlags;
		public ImRect DockTabItemRect;
		public float ItemWidth;
		public float TextWrapPos;
		public ImVector<float> ItemWidthStack;
		public ImVector<float> TextWrapPosStack;
	}
}

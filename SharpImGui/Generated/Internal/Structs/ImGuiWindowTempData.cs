using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Transient per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the DC variable name in ImGuiWindow.<br/>
	/// (That's theory, in practice the delimitation between ImGuiWindow and ImGuiWindowTempData is quite tenuous and could be reconsidered..)<br/>
	/// (This doesn't need a constructor because we zero-clear it as part of ImGuiWindow and all frame-temporary data are setup on Begin)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowTempData
	{
		/// <summary>
		/// <br/>
		///     // Layout<br/>
		/// Current emitting position, in absolute coordinates.<br/>
		/// </summary>
		public Vector2 CursorPos;
		public Vector2 CursorPosPrevLine;
		/// <summary>
		/// Initial position after Begin(), generally ~ window position + WindowPadding.<br/>
		/// </summary>
		public Vector2 CursorStartPos;
		/// <summary>
		/// Used to implicitly calculate ContentSize at the beginning of next frame, for scrolling range and auto-resize. Always growing during the frame.<br/>
		/// </summary>
		public Vector2 CursorMaxPos;
		/// <summary>
		/// Used to implicitly calculate ContentSizeIdeal at the beginning of next frame, for auto-resize only. Always growing during the frame.<br/>
		/// </summary>
		public Vector2 IdealMaxPos;
		public Vector2 CurrLineSize;
		public Vector2 PrevLineSize;
		/// <summary>
		/// Baseline offset (0.0f by default on a new line, generally == style.FramePadding.y when a framed item has been added).<br/>
		/// </summary>
		public float CurrLineTextBaseOffset;
		public float PrevLineTextBaseOffset;
		public byte IsSameLine;
		public byte IsSetPos;
		/// <summary>
		/// Indentation / start position from left of window (increased by TreePush/TreePop, etc.)<br/>
		/// </summary>
		public ImVec1 Indent;
		/// <summary>
		/// Offset to the current column (if ColumnsCurrent > 0). FIXME: This and the above should be a stack to allow use cases like Tree->Column->Tree. Need revamp columns API.<br/>
		/// </summary>
		public ImVec1 ColumnsOffset;
		public ImVec1 GroupOffset;
		/// <summary>
		/// Record the loss of precision of CursorStartPos due to really large scrolling amount. This is used by clipper to compensate and fix the most common use case of large scroll area.<br/>
		/// </summary>
		public Vector2 CursorStartPosLossyness;
		/// <summary>
		///     // Keyboard/Gamepad navigation<br/>
		/// Current layer, 0..31 (we currently only use 0..1)<br/>
		/// </summary>
		public ImGuiNavLayer NavLayerCurrent;
		/// <summary>
		/// Which layers have been written to (result from previous frame)<br/>
		/// </summary>
		public short NavLayersActiveMask;
		/// <summary>
		/// Which layers have been written to (accumulator for current frame)<br/>
		/// </summary>
		public short NavLayersActiveMaskNext;
		/// <summary>
		/// Set when current work location may be scrolled horizontally when moving left / right. This is generally always true UNLESS within a column.<br/>
		/// </summary>
		public byte NavIsScrollPushableX;
		public byte NavHideHighlightOneFrame;
		/// <summary>
		/// Set per window when scrolling can be used (== ScrollMax.y > 0.0f)<br/>
		/// </summary>
		public byte NavWindowHasScrollY;
		/// <summary>
		///     // Miscellaneous<br/>
		/// FIXME: Remove this<br/>
		/// </summary>
		public byte MenuBarAppending;
		/// <summary>
		/// MenuBarOffset.x is sort of equivalent of a per-layer CursorPos.x, saved/restored as we switch to the menu bar. The only situation when MenuBarOffset.y is > 0 if when (SafeAreaPadding.y > FramePadding.y), often used on TVs.<br/>
		/// </summary>
		public Vector2 MenuBarOffset;
		/// <summary>
		/// Simplified columns storage for menu items measurement<br/>
		/// </summary>
		public ImGuiMenuColumns MenuColumns;
		/// <summary>
		/// Current tree depth.<br/>
		/// </summary>
		public int TreeDepth;
		/// <summary>
		/// Store whether given depth has ImGuiTreeNodeStackData data. Could be turned into a ImU64 if necessary.<br/>
		/// </summary>
		public uint TreeHasStackDataDepthMask;
		public ImVector<ImGuiWindowPtr> ChildWindows;
		/// <summary>
		/// Current persistent per-window storage (store e.g. tree node open/close state)<br/>
		/// </summary>
		public unsafe ImGuiStorage* StateStorage;
		/// <summary>
		/// Current columns set<br/>
		/// </summary>
		public unsafe ImGuiOldColumns* CurrentColumns;
		/// <summary>
		/// Current table index (into g.Tables)<br/>
		/// </summary>
		public int CurrentTableIdx;
		public ImGuiLayoutType LayoutType;
		/// <summary>
		/// Layout type of parent window at the time of Begin()<br/>
		/// </summary>
		public ImGuiLayoutType ParentLayoutType;
		public uint ModalDimBgColor;
		/// <summary>
		///     // Status flags<br/>
		/// </summary>
		public ImGuiItemStatusFlags WindowItemStatusFlags;
		public ImGuiItemStatusFlags ChildItemStatusFlags;
		public ImGuiItemStatusFlags DockTabItemStatusFlags;
		public ImRect DockTabItemRect;
		/// <summary>
		///     // Local parameters stacks<br/>
		///     // We store the current settings outside of the vectors to increase memory locality (reduce cache misses). The vectors are rarely modified. Also it allows us to not heap allocate for short-lived windows which are not using those settings.<br/>
		/// Current item width (>0.0: width in pixels, <0.0: align xx pixels to the right of window).<br/>
		/// </summary>
		public float ItemWidth;
		/// <summary>
		/// Current text wrap pos.<br/>
		/// </summary>
		public float TextWrapPos;
		/// <summary>
		/// Store item widths to restore (attention: .back() is not == ItemWidth)<br/>
		/// </summary>
		public ImVector<float> ItemWidthStack;
		/// <summary>
		/// Store text wrap pos to restore (attention: .back() is not == TextWrapPos)<br/>
		/// </summary>
		public ImVector<float> TextWrapPosStack;
	}
}

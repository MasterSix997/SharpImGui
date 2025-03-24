using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// [Internal] sizeof() ~ 112<br/>
	/// We use the terminology "Enabled" to refer to a column that is not Hidden by user/api.<br/>
	/// We use the terminology "Clipped" to refer to a column that is out of sight because of scrolling/clipping.<br/>
	/// This is in contrast with some user-facing api such as IsItemVisible() / IsRectVisible() which use "Visible" to mean "not clipped".<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumn
	{
		/// <summary>
		/// Flags after some patching (not directly same as provided by user). See ImGuiTableColumnFlags_<br/>
		/// </summary>
		public ImGuiTableColumnFlags Flags;
		/// <summary>
		/// Final/actual width visible == (MaxX - MinX), locked in TableUpdateLayout(). May be > WidthRequest to honor minimum width, may be < WidthRequest to honor shrinking columns down in tight space.<br/>
		/// </summary>
		public float WidthGiven;
		/// <summary>
		/// Absolute positions<br/>
		/// </summary>
		public float MinX;
		public float MaxX;
		/// <summary>
		/// Master width absolute value when !(Flags & _WidthStretch). When Stretch this is derived every frame from StretchWeight in TableUpdateLayout()<br/>
		/// </summary>
		public float WidthRequest;
		/// <summary>
		/// Automatic width<br/>
		/// </summary>
		public float WidthAuto;
		/// <summary>
		/// Maximum width (FIXME: overwritten by each instance)<br/>
		/// </summary>
		public float WidthMax;
		/// <summary>
		/// Master width weight when (Flags & _WidthStretch). Often around ~1.0f initially.<br/>
		/// </summary>
		public float StretchWeight;
		/// <summary>
		/// Value passed to TableSetupColumn(). For Width it is a content width (_without padding_).<br/>
		/// </summary>
		public float InitStretchWeightOrWidth;
		/// <summary>
		/// Clipping rectangle for the column<br/>
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// Optional, value passed to TableSetupColumn()<br/>
		/// </summary>
		public uint UserID;
		/// <summary>
		/// Contents region min ~(MinX + CellPaddingX + CellSpacingX1) == cursor start position when entering column<br/>
		/// </summary>
		public float WorkMinX;
		/// <summary>
		/// Contents region max ~(MaxX - CellPaddingX - CellSpacingX2)<br/>
		/// </summary>
		public float WorkMaxX;
		/// <summary>
		/// Current item width for the column, preserved across rows<br/>
		/// </summary>
		public float ItemWidth;
		/// <summary>
		/// Contents maximum position for frozen rows (apart from headers), from which we can infer content width.<br/>
		/// </summary>
		public float ContentMaxXFrozen;
		public float ContentMaxXUnfrozen;
		/// <summary>
		/// Contents maximum position for headers rows (regardless of freezing). TableHeader() automatically softclip itself + report ideal desired size, to avoid creating extraneous draw calls<br/>
		/// </summary>
		public float ContentMaxXHeadersUsed;
		public float ContentMaxXHeadersIdeal;
		/// <summary>
		/// Offset into parent ColumnsNames[]<br/>
		/// </summary>
		public short NameOffset;
		/// <summary>
		/// Index within Table's IndexToDisplayOrder[] (column may be reordered by users)<br/>
		/// </summary>
		public short DisplayOrder;
		/// <summary>
		/// Index within enabled/visible set (<= IndexToDisplayOrder)<br/>
		/// </summary>
		public short IndexWithinEnabledSet;
		/// <summary>
		/// Index of prev enabled/visible column within Columns[], -1 if first enabled/visible column<br/>
		/// </summary>
		public short PrevEnabledColumn;
		/// <summary>
		/// Index of next enabled/visible column within Columns[], -1 if last enabled/visible column<br/>
		/// </summary>
		public short NextEnabledColumn;
		/// <summary>
		/// Index of this column within sort specs, -1 if not sorting on this column, 0 for single-sort, may be >0 on multi-sort<br/>
		/// </summary>
		public short SortOrder;
		/// <summary>
		/// Index within DrawSplitter.Channels[]<br/>
		/// </summary>
		public ushort DrawChannelCurrent;
		/// <summary>
		/// Draw channels for frozen rows (often headers)<br/>
		/// </summary>
		public ushort DrawChannelFrozen;
		/// <summary>
		/// Draw channels for unfrozen rows<br/>
		/// </summary>
		public ushort DrawChannelUnfrozen;
		/// <summary>
		/// IsUserEnabled && (Flags & ImGuiTableColumnFlags_Disabled) == 0<br/>
		/// </summary>
		public byte IsEnabled;
		/// <summary>
		/// Is the column not marked Hidden by the user? (unrelated to being off view, e.g. clipped by scrolling).<br/>
		/// </summary>
		public byte IsUserEnabled;
		public byte IsUserEnabledNextFrame;
		/// <summary>
		/// Is actually in view (e.g. overlapping the host window clipping rectangle, not scrolled).<br/>
		/// </summary>
		public byte IsVisibleX;
		public byte IsVisibleY;
		/// <summary>
		/// Return value for TableSetColumnIndex() / TableNextColumn(): whether we request user to output contents or not.<br/>
		/// </summary>
		public byte IsRequestOutput;
		/// <summary>
		/// Do we want item submissions to this column to be completely ignored (no layout will happen).<br/>
		/// </summary>
		public byte IsSkipItems;
		public byte IsPreserveWidthAuto;
		/// <summary>
		/// ImGuiNavLayer in 1 byte<br/>
		/// </summary>
		public sbyte NavLayerCurrent;
		/// <summary>
		/// Queue of 8 values for the next 8 frames to request auto-fit<br/>
		/// </summary>
		public byte AutoFitQueue;
		/// <summary>
		/// Queue of 8 values for the next 8 frames to disable Clipped/SkipItem<br/>
		/// </summary>
		public byte CannotSkipItemsQueue;
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending<br/>
		/// </summary>
		public byte SortDirection;
		/// <summary>
		/// Number of available sort directions (0 to 3)<br/>
		/// </summary>
		public byte SortDirectionsAvailCount;
		/// <summary>
		/// Mask of available sort directions (1-bit each)<br/>
		/// </summary>
		public byte SortDirectionsAvailMask;
		/// <summary>
		/// Ordered list of available sort directions (2-bits each, total 8-bits)<br/>
		/// </summary>
		public byte SortDirectionsAvailList;
	}
}

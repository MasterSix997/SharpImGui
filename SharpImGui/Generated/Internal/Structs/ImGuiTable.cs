using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() ~ 592 bytes + heap allocs described in TableBeginInitMemory()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTable
	{
		public uint ID;
		public ImGuiTableFlags Flags;
		/// <summary>
		/// Single allocation to hold Columns[], DisplayOrderToIndex[] and RowCellData[]<br/>
		/// </summary>
		public unsafe void* RawData;
		/// <summary>
		/// Transient data while table is active. Point within g.CurrentTableStack[]<br/>
		/// </summary>
		public unsafe ImGuiTableTempData* TempData;
		/// <summary>
		/// Point within RawData[]<br/>
		/// </summary>
		public ImSpan<ImGuiTableColumn> Columns;
		/// <summary>
		/// Point within RawData[]. Store display order of columns (when not reordered, the values are 0...Count-1)<br/>
		/// </summary>
		public ImSpan<short> DisplayOrderToIndex;
		/// <summary>
		/// Point within RawData[]. Store cells background requests for current row.<br/>
		/// </summary>
		public ImSpan<ImGuiTableCellData> RowCellData;
		/// <summary>
		/// Column DisplayOrder -> IsEnabled map<br/>
		/// </summary>
		public IntPtr EnabledMaskByDisplayOrder;
		/// <summary>
		/// Column Index -> IsEnabled map (== not hidden by user/api) in a format adequate for iterating column without touching cold data<br/>
		/// </summary>
		public IntPtr EnabledMaskByIndex;
		/// <summary>
		/// Column Index -> IsVisibleX|IsVisibleY map (== not hidden by user/api && not hidden by scrolling/cliprect)<br/>
		/// </summary>
		public IntPtr VisibleMaskByIndex;
		/// <summary>
		/// Which data were loaded from the .ini file (e.g. when order is not altered we won't save order)<br/>
		/// </summary>
		public ImGuiTableFlags SettingsLoadedFlags;
		/// <summary>
		/// Offset in g.SettingsTables<br/>
		/// </summary>
		public int SettingsOffset;
		public int LastFrameActive;
		/// <summary>
		/// Number of columns declared in BeginTable()<br/>
		/// </summary>
		public int ColumnsCount;
		public int CurrentRow;
		public int CurrentColumn;
		/// <summary>
		/// Count of BeginTable() calls with same ID in the same frame (generally 0). This is a little bit similar to BeginCount for a window, but multiple table with same ID look are multiple tables, they are just synched.<br/>
		/// </summary>
		public short InstanceCurrent;
		/// <summary>
		/// Mark which instance (generally 0) of the same ID is being interacted with<br/>
		/// </summary>
		public short InstanceInteracted;
		public float RowPosY1;
		public float RowPosY2;
		/// <summary>
		/// Height submitted to TableNextRow()<br/>
		/// </summary>
		public float RowMinHeight;
		/// <summary>
		/// Top and bottom padding. Reloaded during row change.<br/>
		/// </summary>
		public float RowCellPaddingY;
		public float RowTextBaseline;
		public float RowIndentOffsetX;
		/// <summary>
		/// Current row flags, see ImGuiTableRowFlags_<br/>
		/// </summary>
		public ImGuiTableRowFlags RowFlags;
		public ImGuiTableRowFlags LastRowFlags;
		/// <summary>
		/// Counter for alternating background colors (can be fast-forwarded by e.g clipper), not same as CurrentRow because header rows typically don't increase this.<br/>
		/// </summary>
		public int RowBgColorCounter;
		/// <summary>
		/// Background color override for current row.<br/>
		/// </summary>
		public uint RowBgColor_0;
		public uint RowBgColor_1;
		public uint BorderColorStrong;
		public uint BorderColorLight;
		public float BorderX1;
		public float BorderX2;
		public float HostIndentX;
		public float MinColumnWidth;
		public float OuterPaddingX;
		/// <summary>
		/// Padding from each borders. Locked in BeginTable()/Layout.<br/>
		/// </summary>
		public float CellPaddingX;
		/// <summary>
		/// Spacing between non-bordered cells. Locked in BeginTable()/Layout.<br/>
		/// </summary>
		public float CellSpacingX1;
		public float CellSpacingX2;
		/// <summary>
		/// User value passed to BeginTable(), see comments at the top of BeginTable() for details.<br/>
		/// </summary>
		public float InnerWidth;
		/// <summary>
		/// Sum of current column width<br/>
		/// </summary>
		public float ColumnsGivenWidth;
		/// <summary>
		/// Sum of ideal column width in order nothing to be clipped, used for auto-fitting and content width submission in outer window<br/>
		/// </summary>
		public float ColumnsAutoFitWidth;
		/// <summary>
		/// Sum of weight of all enabled stretching columns<br/>
		/// </summary>
		public float ColumnsStretchSumWeights;
		public float ResizedColumnNextWidth;
		/// <summary>
		/// Lock minimum contents width while resizing down in order to not create feedback loops. But we allow growing the table.<br/>
		/// </summary>
		public float ResizeLockMinContentsX2;
		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.<br/>
		/// </summary>
		public float RefScale;
		/// <summary>
		/// Set by TableAngledHeadersRow(), used in TableUpdateLayout()<br/>
		/// </summary>
		public float AngledHeadersHeight;
		/// <summary>
		/// Set by TableAngledHeadersRow(), used in TableUpdateLayout()<br/>
		/// </summary>
		public float AngledHeadersSlope;
		/// <summary>
		/// Note: for non-scrolling table, OuterRect.Max.y is often FLT_MAX until EndTable(), unless a height has been specified in BeginTable().<br/>
		/// </summary>
		public ImRect OuterRect;
		/// <summary>
		/// InnerRect but without decoration. As with OuterRect, for non-scrolling tables, InnerRect.Max.y is<br/>
		/// </summary>
		public ImRect InnerRect;
		public ImRect WorkRect;
		public ImRect InnerClipRect;
		/// <summary>
		/// We use this to cpu-clip cell background color fill, evolve during the frame as we cross frozen rows boundaries<br/>
		/// </summary>
		public ImRect BgClipRect;
		/// <summary>
		/// Actual ImDrawCmd clip rect for BG0/1 channel. This tends to be == OuterWindow->ClipRect at BeginTable() because output in BG0/BG1 is cpu-clipped<br/>
		/// </summary>
		public ImRect Bg0ClipRectForDrawCmd;
		/// <summary>
		/// Actual ImDrawCmd clip rect for BG2 channel. This tends to be a correct, tight-fit, because output to BG2 are done by widgets relying on regular ClipRect.<br/>
		/// </summary>
		public ImRect Bg2ClipRectForDrawCmd;
		/// <summary>
		/// This is used to check if we can eventually merge our columns draw calls into the current draw call of the current window.<br/>
		/// </summary>
		public ImRect HostClipRect;
		/// <summary>
		/// Backup of InnerWindow->ClipRect during PushTableBackground()/PopTableBackground()<br/>
		/// </summary>
		public ImRect HostBackupInnerClipRect;
		/// <summary>
		/// Parent window for the table<br/>
		/// </summary>
		public unsafe ImGuiWindow* OuterWindow;
		/// <summary>
		/// Window holding the table data (== OuterWindow or a child window)<br/>
		/// </summary>
		public unsafe ImGuiWindow* InnerWindow;
		/// <summary>
		/// Contiguous buffer holding columns names<br/>
		/// </summary>
		public ImGuiTextBuffer ColumnsNames;
		/// <summary>
		/// Shortcut to TempData->DrawSplitter while in table. Isolate draw commands per columns to avoid switching clip rect constantly<br/>
		/// </summary>
		public unsafe ImDrawListSplitter* DrawSplitter;
		public ImGuiTableInstanceData InstanceDataFirst;
		/// <summary>
		/// FIXME-OPT: Using a small-vector pattern would be good.<br/>
		/// </summary>
		public ImVector<ImGuiTableInstanceData> InstanceDataExtra;
		public ImGuiTableColumnSortSpecs SortSpecsSingle;
		/// <summary>
		/// FIXME-OPT: Using a small-vector pattern would be good.<br/>
		/// </summary>
		public ImVector<ImGuiTableColumnSortSpecs> SortSpecsMulti;
		/// <summary>
		/// Public facing sorts specs, this is what we return in TableGetSortSpecs()<br/>
		/// </summary>
		public ImGuiTableSortSpecs SortSpecs;
		public short SortSpecsCount;
		/// <summary>
		/// Number of enabled columns (<= ColumnsCount)<br/>
		/// </summary>
		public short ColumnsEnabledCount;
		/// <summary>
		/// Number of enabled columns using fixed width (<= ColumnsCount)<br/>
		/// </summary>
		public short ColumnsEnabledFixedCount;
		/// <summary>
		/// Count calls to TableSetupColumn()<br/>
		/// </summary>
		public short DeclColumnsCount;
		/// <summary>
		/// Count columns with angled headers<br/>
		/// </summary>
		public short AngledHeadersCount;
		/// <summary>
		/// Index of column whose visible region is being hovered. Important: == ColumnsCount when hovering empty region after the right-most column!<br/>
		/// </summary>
		public short HoveredColumnBody;
		/// <summary>
		/// Index of column whose right-border is being hovered (for resizing).<br/>
		/// </summary>
		public short HoveredColumnBorder;
		/// <summary>
		/// Index of column which should be highlighted.<br/>
		/// </summary>
		public short HighlightColumnHeader;
		/// <summary>
		/// Index of single column requesting auto-fit.<br/>
		/// </summary>
		public short AutoFitSingleColumn;
		/// <summary>
		/// Index of column being resized. Reset when InstanceCurrent==0.<br/>
		/// </summary>
		public short ResizedColumn;
		/// <summary>
		/// Index of column being resized from previous frame.<br/>
		/// </summary>
		public short LastResizedColumn;
		/// <summary>
		/// Index of column header being held.<br/>
		/// </summary>
		public short HeldHeaderColumn;
		/// <summary>
		/// Index of column being reordered. (not cleared)<br/>
		/// </summary>
		public short ReorderColumn;
		/// <summary>
		/// -1 or +1<br/>
		/// </summary>
		public short ReorderColumnDir;
		/// <summary>
		/// Index of left-most non-hidden column.<br/>
		/// </summary>
		public short LeftMostEnabledColumn;
		/// <summary>
		/// Index of right-most non-hidden column.<br/>
		/// </summary>
		public short RightMostEnabledColumn;
		/// <summary>
		/// Index of left-most stretched column.<br/>
		/// </summary>
		public short LeftMostStretchedColumn;
		/// <summary>
		/// Index of right-most stretched column.<br/>
		/// </summary>
		public short RightMostStretchedColumn;
		/// <summary>
		/// Column right-clicked on, of -1 if opening context menu from a neutral/empty spot<br/>
		/// </summary>
		public short ContextPopupColumn;
		/// <summary>
		/// Requested frozen rows count<br/>
		/// </summary>
		public short FreezeRowsRequest;
		/// <summary>
		/// Actual frozen row count (== FreezeRowsRequest, or == 0 when no scrolling offset)<br/>
		/// </summary>
		public short FreezeRowsCount;
		/// <summary>
		/// Requested frozen columns count<br/>
		/// </summary>
		public short FreezeColumnsRequest;
		/// <summary>
		/// Actual frozen columns count (== FreezeColumnsRequest, or == 0 when no scrolling offset)<br/>
		/// </summary>
		public short FreezeColumnsCount;
		/// <summary>
		/// Index of current RowCellData[] entry in current row<br/>
		/// </summary>
		public short RowCellDataCurrent;
		/// <summary>
		/// Redirect non-visible columns here.<br/>
		/// </summary>
		public ushort DummyDrawChannel;
		/// <summary>
		/// For Selectable() and other widgets drawing across columns after the freezing line. Index within DrawSplitter.Channels[]<br/>
		/// </summary>
		public ushort Bg2DrawChannelCurrent;
		public ushort Bg2DrawChannelUnfrozen;
		/// <summary>
		/// ImGuiNavLayer at the time of BeginTable().<br/>
		/// </summary>
		public sbyte NavLayer;
		/// <summary>
		/// Set by TableUpdateLayout() which is called when beginning the first row.<br/>
		/// </summary>
		public byte IsLayoutLocked;
		/// <summary>
		/// Set when inside TableBeginRow()/TableEndRow().<br/>
		/// </summary>
		public byte IsInsideRow;
		public byte IsInitializing;
		public byte IsSortSpecsDirty;
		/// <summary>
		/// Set when the first row had the ImGuiTableRowFlags_Headers flag.<br/>
		/// </summary>
		public byte IsUsingHeaders;
		/// <summary>
		/// Set when default context menu is open (also see: ContextPopupColumn, InstanceInteracted).<br/>
		/// </summary>
		public byte IsContextPopupOpen;
		/// <summary>
		/// Disable default context menu contents. You may submit your own using TableBeginContextMenuPopup()/EndPopup()<br/>
		/// </summary>
		public byte DisableDefaultContextMenu;
		public byte IsSettingsRequestLoad;
		/// <summary>
		/// Set when table settings have changed and needs to be reported into ImGuiTableSetttings data.<br/>
		/// </summary>
		public byte IsSettingsDirty;
		/// <summary>
		/// Set when display order is unchanged from default (DisplayOrder contains 0...Count-1)<br/>
		/// </summary>
		public byte IsDefaultDisplayOrder;
		public byte IsResetAllRequest;
		public byte IsResetDisplayOrderRequest;
		/// <summary>
		/// Set when we got past the frozen row.<br/>
		/// </summary>
		public byte IsUnfrozenRows;
		/// <summary>
		/// Set if user didn't explicitly set a sizing policy in BeginTable()<br/>
		/// </summary>
		public byte IsDefaultSizingPolicy;
		public byte IsActiveIdAliveBeforeTable;
		public byte IsActiveIdInTable;
		/// <summary>
		/// Whether ANY instance of this table had a vertical scrollbar during the current frame.<br/>
		/// </summary>
		public byte HasScrollbarYCurr;
		/// <summary>
		/// Whether ANY instance of this table had a vertical scrollbar during the previous.<br/>
		/// </summary>
		public byte HasScrollbarYPrev;
		public byte MemoryCompacted;
		/// <summary>
		/// Backup of InnerWindow->SkipItem at the end of BeginTable(), because we will overwrite InnerWindow->SkipItem on a per-column basis<br/>
		/// </summary>
		public byte HostSkipItems;
	}
}

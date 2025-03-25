using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	public static class InternalImGuiNative
	{
		public static extern unsafe void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r);
		public static extern unsafe void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r);
		public static extern unsafe void igWindowPosRelToAbs(Vector2* pOut, ImGuiWindow* window, Vector2 p);
		public static extern unsafe void igWindowPosAbsToRel(Vector2* pOut, ImGuiWindow* window, Vector2 p);
		public static extern unsafe void igUpdateWindowSkipRefresh(ImGuiWindow* window);
		public static extern unsafe void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
		public static extern unsafe void igUpdateMouseMovingWindowNewFrame();
		public static extern unsafe void igUpdateMouseMovingWindowEndFrame();
		public static extern unsafe void igUpdateInputEvents(byte trickle_fast_inputs);
		public static extern unsafe void igUpdateHoveredWindowAndCaptureFlags();
		public static extern unsafe int igTypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, void* get_item_name_func, void* user_data, int nav_item_idx);
		public static extern unsafe int igTypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, void* get_item_name_func, void* user_data, int nav_item_idx);
		public static extern unsafe int igTypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, void* get_item_name_func, void* user_data);
		public static extern unsafe void igTreePushOverrideID(uint id);
		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		public static extern unsafe byte igTreeNodeUpdateNextOpen(uint storage_id, ImGuiTreeNodeFlags flags);
		public static extern unsafe void igTreeNodeSetOpen(uint storage_id, byte open);
		public static extern unsafe byte igTreeNodeGetOpen(uint storage_id);
		public static extern unsafe byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
		public static extern unsafe void igTranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 old_pos, Vector2 new_pos, Vector2 old_size, Vector2 new_size);
		public static extern unsafe void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);
		public static extern unsafe byte igTestShortcutRouting(ImGuiKey key_chord, uint owner_id);
		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		public static extern unsafe byte igTestKeyOwner(ImGuiKey key, uint owner_id);
		public static extern unsafe byte igTempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);
		public static extern unsafe byte igTempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
		public static extern unsafe byte igTempInputIsActive(uint id);
		public static extern unsafe void igTeleportMousePos(Vector2 pos);
		public static extern unsafe void igTableUpdateLayout(ImGuiTable* table);
		public static extern unsafe void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table);
		public static extern unsafe void igTableUpdateBorders(ImGuiTable* table);
		public static extern unsafe void igTableSortSpecsSanitize(ImGuiTable* table);
		public static extern unsafe void igTableSortSpecsBuild(ImGuiTable* table);
		public static extern unsafe void igTableSetupDrawChannels(ImGuiTable* table);
		public static extern unsafe ImGuiTableSettings* igTableSettingsFindByID(uint id);
		public static extern unsafe ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count);
		public static extern unsafe void igTableSettingsAddSettingsHandler();
		public static extern unsafe void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
		public static extern unsafe void igTableSetColumnWidthAutoAll(ImGuiTable* table);
		public static extern unsafe void igTableSetColumnWidth(int column_n, float width);
		public static extern unsafe void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
		public static extern unsafe void igTableSaveSettings(ImGuiTable* table);
		public static extern unsafe void igTableResetSettings(ImGuiTable* table);
		public static extern unsafe void igTableRemove(ImGuiTable* table);
		public static extern unsafe void igTablePushBackgroundChannel();
		public static extern unsafe void igTablePopBackgroundChannel();
		public static extern unsafe void igTableOpenContextMenu(int column_n);
		public static extern unsafe void igTableMergeDrawChannels(ImGuiTable* table);
		public static extern unsafe void igTableLoadSettings(ImGuiTable* table);
		public static extern unsafe uint igTableGetInstanceID(ImGuiTable* table, int instance_no);
		public static extern unsafe ImGuiTableInstanceData* igTableGetInstanceData(ImGuiTable* table, int instance_no);
		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		public static extern unsafe int igTableGetHoveredRow();
		public static extern unsafe float igTableGetHeaderRowHeight();
		public static extern unsafe float igTableGetHeaderAngledMaxLabelWidth();
		public static extern unsafe float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
		public static extern unsafe uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);
		public static extern unsafe ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);
		public static extern unsafe byte* igTableGetColumnName(ImGuiTable* table, int column_n);
		public static extern unsafe void igTableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int column_n);
		public static extern unsafe ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table);
		public static extern unsafe void igTableGcCompactTransientBuffers(ImGuiTableTempData* table);
		public static extern unsafe void igTableGcCompactTransientBuffers(ImGuiTable* table);
		public static extern unsafe void igTableGcCompactSettings();
		public static extern unsafe void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
		public static extern unsafe ImGuiTable* igTableFindByID(uint id);
		public static extern unsafe void igTableEndRow(ImGuiTable* table);
		public static extern unsafe void igTableEndCell(ImGuiTable* table);
		public static extern unsafe void igTableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flags_for_section_to_display);
		public static extern unsafe void igTableDrawBorders(ImGuiTable* table);
		public static extern unsafe float igTableCalcMaxColumnWidth(ImGuiTable* table, int column_n);
		public static extern unsafe void igTableBeginRow(ImGuiTable* table);
		public static extern unsafe void igTableBeginInitMemory(ImGuiTable* table, int columns_count);
		public static extern unsafe byte igTableBeginContextMenuPopup(ImGuiTable* table);
		public static extern unsafe void igTableBeginCell(ImGuiTable* table, int column_n);
		public static extern unsafe void igTableBeginApplyRequests(ImGuiTable* table);
		public static extern unsafe void igTableAngledHeadersRowEx(uint row_id, float angle, float max_label_width, ImGuiTableHeaderData* data, int data_count);
		public static extern unsafe void igTabItemSpacing(byte* str_id, ImGuiTabItemFlags flags, float width);
		public static extern unsafe void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
		public static extern unsafe byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window);
		public static extern unsafe void igTabItemCalcSize(Vector2* pOut, ImGuiWindow* window);
		public static extern unsafe void igTabItemCalcSize(Vector2* pOut, byte* label, byte has_close_button_or_unsaved_marker);
		public static extern unsafe void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
		public static extern unsafe void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
		public static extern unsafe void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos);
		public static extern unsafe void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
		public static extern unsafe void igTabBarQueueFocus(ImGuiTabBar* tab_bar, byte* tab_name);
		public static extern unsafe void igTabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static extern unsafe byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);
		public static extern unsafe int igTabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static extern unsafe byte* igTabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static extern unsafe ImGuiTabItem* igTabBarGetCurrentTab(ImGuiTabBar* tab_bar);
		public static extern unsafe ImGuiTabItem* igTabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);
		public static extern unsafe ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
		public static extern unsafe ImGuiTabItem* igTabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
		public static extern unsafe void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static extern unsafe void igTabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window);
		public static extern unsafe void igStartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock);
		public static extern unsafe void igStartMouseMovingWindow(ImGuiWindow* window);
		public static extern unsafe byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col);
		public static extern unsafe byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		public static extern unsafe void igShutdown();
		public static extern unsafe void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
		public static extern unsafe void igShowFontAtlas(ImFontAtlas* atlas);
		public static extern unsafe byte igShortcut(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id);
		public static extern unsafe void igShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 pivot_in, float cos_a, float sin_a, Vector2 pivot_out);
		public static extern unsafe void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
		public static extern unsafe void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
		public static extern unsafe void igSetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		public static extern unsafe void igSetWindowSize(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
		public static extern unsafe void igSetWindowPos(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		public static extern unsafe void igSetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parent_window);
		public static extern unsafe void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
		public static extern unsafe void igSetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);
		public static extern unsafe void igSetWindowDock(ImGuiWindow* window, uint dock_id, ImGuiCond cond);
		public static extern unsafe void igSetWindowCollapsed(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
		public static extern unsafe void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);
		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		public static extern unsafe byte igSetShortcutRouting(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id);
		public static extern unsafe void igSetScrollY(ImGuiWindow* window, float scroll_y);
		public static extern unsafe void igSetScrollX(ImGuiWindow* window, float scroll_x);
		public static extern unsafe void igSetScrollFromPosY(ImGuiWindow* window, float local_y, float center_y_ratio);
		public static extern unsafe void igSetScrollFromPosX(ImGuiWindow* window, float local_x, float center_x_ratio);
		public static extern unsafe void igSetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags);
		public static extern unsafe void igSetNextItemRefVal(ImGuiDataType data_type, void* p_data);
		public static extern unsafe void igSetNavWindow(ImGuiWindow* window);
		public static extern unsafe void igSetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel);
		public static extern unsafe void igSetNavFocusScope(uint focus_scope_id);
		public static extern unsafe void igSetNavCursorVisibleAfterMove();
		public static extern unsafe void igSetLastItemData(uint item_id, ImGuiItemFlags item_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect);
		public static extern unsafe void igSetKeyOwnersForKeyChord(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
		public static extern unsafe void igSetKeyOwner(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		public static extern unsafe void igSetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags);
		public static extern unsafe void igSetHoveredID(uint id);
		public static extern unsafe void igSetFocusID(uint id, ImGuiWindow* window);
		public static extern unsafe void igSetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		public static extern unsafe void igSetCurrentFont(ImFont* font);
		public static extern unsafe void igSetActiveIdUsingAllKeyboardKeys();
		public static extern unsafe void igSetActiveID(uint id, ImGuiWindow* window);
		public static extern unsafe void igSeparatorTextEx(uint id, byte* label, byte* label_end, float extra_width);
		public static extern unsafe void igSeparatorEx(ImGuiSeparatorFlags flags, float thickness);
		public static extern unsafe byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags draw_rounding_flags);
		public static extern unsafe void igScrollbar(ImGuiAxis axis);
		public static extern unsafe void igScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
		public static extern unsafe void igScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
		public static extern unsafe void igScrollToItem(ImGuiScrollFlags flags);
		public static extern unsafe void igScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);
		public static extern unsafe void igScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
		public static extern unsafe void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
		public static extern unsafe void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
		public static extern unsafe void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
		public static extern unsafe void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
		public static extern unsafe void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
		public static extern unsafe void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);
		public static extern unsafe void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		public static extern unsafe void igRenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags);
		public static extern unsafe void igRenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
		public static extern unsafe void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
		public static extern unsafe void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte borders, float rounding);
		public static extern unsafe void igRenderDragDropTargetRect(ImRect bb, ImRect item_clip_rect);
		public static extern unsafe void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags);
		public static extern unsafe void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
		public static extern unsafe void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
		public static extern unsafe void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
		public static extern unsafe void igRenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col);
		public static extern unsafe void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
		public static extern unsafe void igRemoveSettingsHandler(byte* type_name);
		public static extern unsafe void igRemoveContextHook(IntPtr context, uint hook_to_remove);
		public static extern unsafe void igPushPasswordFont();
		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		public static extern unsafe void igPushOverrideID(uint id);
		public static extern unsafe void igPushMultiItemsWidths(int components, float width_full);
		public static extern unsafe void igPushFocusScope(uint id);
		public static extern unsafe void igPushColumnsBackground();
		public static extern unsafe void igPushColumnClipRect(int column_index);
		public static extern unsafe void igPopFocusScope();
		public static extern unsafe void igPopColumnsBackground();
		public static extern unsafe int igPlotEx(ImGuiPlotType plot_type, byte* label, void* values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 size_arg);
		public static extern unsafe void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags);
		public static extern unsafe void igNavUpdateCurrentWindowIsScrollPushableX();
		public static extern unsafe void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
		public static extern unsafe void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
		public static extern unsafe void igNavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data);
		public static extern unsafe void igNavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
		public static extern unsafe void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
		public static extern unsafe void igNavMoveRequestCancel();
		public static extern unsafe byte igNavMoveRequestButNoResultYet();
		public static extern unsafe void igNavMoveRequestApplyResult();
		public static extern unsafe void igNavInitWindow(ImGuiWindow* window, byte force_reinit);
		public static extern unsafe void igNavInitRequestApplyResult();
		public static extern unsafe void igNavHighlightActivated(uint id);
		public static extern unsafe void igNavClearPreferredPosForAxis(ImGuiAxis axis);
		public static extern unsafe void igMultiSelectItemHeader(uint id, byte* p_selected, ImGuiButtonFlags* p_button_flags);
		public static extern unsafe void igMultiSelectItemFooter(uint id, byte* p_selected, byte* p_pressed);
		public static extern unsafe void igMultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int range_dir, long first_item, long last_item);
		public static extern unsafe void igMultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected);
		public static extern unsafe ImGuiKey igMouseButtonToKey(ImGuiMouseButton button);
		public static extern unsafe byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		public static extern unsafe void igMarkItemEdited(uint id);
		public static extern unsafe void igMarkIniSettingsDirty(ImGuiWindow* window);
		public static extern unsafe void igMarkIniSettingsDirty();
		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		public static extern unsafe void igLogToBuffer(int auto_open_depth);
		public static extern unsafe void igLogSetNextTextDecoration(byte* prefix, byte* suffix);
		public static extern unsafe void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
		/// <summary>
		/// -> BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		public static extern unsafe void igLogBegin(ImGuiLogFlags flags, int auto_open_depth);
		public static extern unsafe void igLocalizeRegisterEntries(ImGuiLocEntry* entries, int count);
		public static extern unsafe byte* igLocalizeGetMsg(ImGuiLocKey key);
		public static extern unsafe void igKeepAliveID(uint id);
		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		public static extern unsafe void igItemSize(ImRect bb, float text_baseline_y);
		public static extern unsafe void igItemSize(Vector2 size, float text_baseline_y);
		public static extern unsafe byte igItemHoverable(ImRect bb, uint id, ImGuiItemFlags item_flags);
		public static extern unsafe byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb, ImGuiItemFlags extra_flags);
		public static extern unsafe byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
		public static extern unsafe byte igIsWindowNavFocusable(ImGuiWindow* window);
		public static extern unsafe byte igIsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags);
		public static extern unsafe byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy);
		public static extern unsafe byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
		public static extern unsafe byte igIsPopupOpen(uint id, ImGuiPopupFlags popup_flags);
		public static extern unsafe byte igIsNamedKeyOrMod(ImGuiKey key);
		public static extern unsafe byte igIsNamedKey(ImGuiKey key);
		public static extern unsafe byte igIsMouseReleased(ImGuiMouseButton button, uint owner_id);
		public static extern unsafe byte igIsMouseKey(ImGuiKey key);
		public static extern unsafe byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
		public static extern unsafe byte igIsMouseDown(ImGuiMouseButton button, uint owner_id);
		public static extern unsafe byte igIsMouseDoubleClicked(ImGuiMouseButton button, uint owner_id);
		public static extern unsafe byte igIsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, uint owner_id);
		public static extern unsafe byte igIsLegacyKey(ImGuiKey key);
		public static extern unsafe byte igIsLRModKey(ImGuiKey key);
		public static extern unsafe byte igIsKeyboardKey(ImGuiKey key);
		public static extern unsafe byte igIsKeyReleased(ImGuiKey key, uint owner_id);
		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		public static extern unsafe byte igIsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, uint owner_id);
		public static extern unsafe byte igIsKeyDown(ImGuiKey key, uint owner_id);
		public static extern unsafe byte igIsKeyChordPressed(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id);
		public static extern unsafe byte igIsGamepadKey(ImGuiKey key);
		public static extern unsafe byte igIsDragDropPayloadBeingAccepted();
		public static extern unsafe byte igIsDragDropActive();
		public static extern unsafe byte igIsClippedEx(ImRect bb, uint id);
		public static extern unsafe byte igIsAliasKey(ImGuiKey key);
		public static extern unsafe byte igIsActiveIdUsingNavDir(ImGuiDir dir);
		public static extern unsafe byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, void* callback, void* user_data);
		public static extern unsafe void igInputTextDeactivateHook(uint id);
		public static extern unsafe void igInitialize();
		public static extern unsafe byte igImageButtonEx(uint id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col, ImGuiButtonFlags flags);
		public static extern unsafe int igImUpperPowerOfTwo(int v);
		public static extern unsafe void igImTrunc(Vector2* pOut, Vector2 v);
		public static extern unsafe float igImTrunc(float f);
		public static extern unsafe byte igImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c);
		public static extern unsafe byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
		public static extern unsafe void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
		public static extern unsafe void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
		public static extern unsafe float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
		public static extern unsafe byte igImToUpper(byte c);
		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		public static extern unsafe int igImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end);
		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static extern unsafe int igImTextStrFromUtf8(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		public static extern unsafe byte* igImTextFindPreviousUtf8Codepoint(byte* in_text_start, byte* in_text_curr);
		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		public static extern unsafe int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		public static extern unsafe int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		public static extern unsafe int igImTextCountLines(byte* in_text, byte* in_text_end);
		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		public static extern unsafe int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		public static extern unsafe byte* igImTextCharToUtf8(byte* out_buf, uint c);
		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		public static extern unsafe int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		public static extern unsafe int igImStrnicmp(byte* str1, byte* str2, uint count);
		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		public static extern unsafe void igImStrncpy(byte* dst, byte* src, uint count);
		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		public static extern unsafe int igImStrlenW(ushort* str);
		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		public static extern unsafe byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		public static extern unsafe int igImStricmp(byte* str1, byte* str2);
		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		public static extern unsafe byte* igImStreolRange(byte* str, byte* str_end);
		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		public static extern unsafe byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		public static extern unsafe byte* igImStrdup(byte* str);
		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		public static extern unsafe byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);
		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		public static extern unsafe byte* igImStrbol(byte* buf_mid_line, byte* buf_begin);
		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		public static extern unsafe void igImStrTrimBlanks(byte* str);
		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		public static extern unsafe byte* igImStrSkipBlank(byte* str);
		public static extern unsafe double igImSign(double x);
		/// <summary>
		/// Sign operator - returns -1, 0 or 1 based on sign of argument<br/>
		/// </summary>
		public static extern unsafe float igImSign(float x);
		public static extern unsafe float igImSaturate(float f);
		public static extern unsafe double igImRsqrt(double x);
		public static extern unsafe float igImRsqrt(float x);
		public static extern unsafe void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);
		public static extern unsafe void igImQsort(void* @base, uint count, uint size_of_element, void* compare_func);
		public static extern unsafe double igImPow(double x, double y);
		/// <summary>
		/// DragBehaviorT/SliderBehaviorT uses ImPow with either float/double and need the precision<br/>
		/// </summary>
		public static extern unsafe float igImPow(float x, float y);
		public static extern unsafe byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
		public static extern unsafe byte* igImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
		public static extern unsafe void igImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
		public static extern unsafe int igImParseFormatPrecision(byte* format, int default_value);
		public static extern unsafe byte* igImParseFormatFindStart(byte* format);
		public static extern unsafe byte* igImParseFormatFindEnd(byte* format);
		public static extern unsafe void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
		public static extern unsafe int igImModPositive(int a, int b);
		public static extern unsafe void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
		public static extern unsafe void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
		public static extern unsafe ImGuiStoragePair* igImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, uint key);
		public static extern unsafe double igImLog(double x);
		/// <summary>
		/// DragBehaviorT/SliderBehaviorT uses ImLog with either float/double and need the precision<br/>
		/// </summary>
		public static extern unsafe float igImLog(float x);
		public static extern unsafe float igImLinearSweep(float current, float target, float speed);
		public static extern unsafe float igImLinearRemapClamp(float s0, float s1, float d0, float d1, float x);
		public static extern unsafe void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
		public static extern unsafe void igImLerp(Vector4* pOut, Vector4 a, Vector4 b, float t);
		public static extern unsafe void igImLerp(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
		public static extern unsafe void igImLerp(Vector2* pOut, Vector2 a, Vector2 b, float t);
		public static extern unsafe float igImLengthSqr(Vector4 lhs);
		public static extern unsafe float igImLengthSqr(Vector2 lhs);
		public static extern unsafe byte igImIsPowerOfTwo(ulong v);
		public static extern unsafe byte igImIsPowerOfTwo(int v);
		public static extern unsafe byte igImIsFloatAboveGuaranteedIntegerPrecision(float f);
		public static extern unsafe float igImInvLength(Vector2 lhs, float fail_value);
		public static extern unsafe uint igImHashStr(byte* data, uint data_size, uint seed);
		public static extern unsafe uint igImHashData(void* data, uint data_size, uint seed);
		public static extern unsafe void igImFormatStringToTempBuffer(byte** out_buf, byte** out_buf_end, byte* fmt);
		public static extern unsafe int igImFormatString(byte* buf, uint buf_size, byte* fmt);
		public static extern unsafe void igImFontAtlasUpdateConfigDataPointers(ImFontAtlas* atlas);
		public static extern unsafe IntPtr* igImFontAtlasGetBuilderForStbTruetype();
		public static extern unsafe void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
		public static extern unsafe void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value);
		public static extern unsafe void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);
		public static extern unsafe void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
		public static extern unsafe void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
		public static extern unsafe void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor);
		public static extern unsafe void igImFontAtlasBuildInit(ImFontAtlas* atlas);
		public static extern unsafe void igImFontAtlasBuildGetOversampleFactors(ImFontConfig* cfg, int* out_oversample_h, int* out_oversample_v);
		public static extern unsafe void igImFontAtlasBuildFinish(ImFontAtlas* atlas);
		public static extern unsafe void igImFloor(Vector2* pOut, Vector2 v);
		/// <summary>
		/// Decent replacement for floorf()<br/>
		/// </summary>
		public static extern unsafe float igImFloor(float f);
		public static extern unsafe ulong igImFileWrite(void* data, ulong size, ulong count, IntPtr file);
		public static extern unsafe ulong igImFileRead(void* data, ulong size, ulong count, IntPtr file);
		public static extern unsafe IntPtr igImFileOpen(byte* filename, byte* mode);
		public static extern unsafe void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
		public static extern unsafe ulong igImFileGetSize(IntPtr file);
		public static extern unsafe byte igImFileClose(IntPtr file);
		public static extern unsafe float igImExponentialMovingAverage(float avg, float sample, int n);
		public static extern unsafe float igImDot(Vector2 a, Vector2 b);
		public static extern unsafe void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
		public static extern unsafe byte igImCharIsXdigitA(byte c);
		public static extern unsafe byte igImCharIsBlankW(uint c);
		public static extern unsafe byte igImCharIsBlankA(byte c);
		public static extern unsafe byte igImBitArrayTestBit(uint* arr, int n);
		public static extern unsafe void igImBitArraySetBitRange(uint* arr, int n, int n2);
		public static extern unsafe void igImBitArraySetBit(uint* arr, int n);
		public static extern unsafe uint igImBitArrayGetStorageSizeInBytes(int bitcount);
		public static extern unsafe void igImBitArrayClearBit(uint* arr, int n);
		public static extern unsafe void igImBitArrayClearAllBits(uint* arr, int bitcount);
		public static extern unsafe void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);
		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		public static extern unsafe void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		public static extern unsafe void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
		public static extern unsafe void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
		public static extern unsafe uint igImAlphaBlendColors(uint col_a, uint col_b);
		public static extern unsafe double igImAbs(double x);
		public static extern unsafe float igImAbs(float x);
		public static extern unsafe int igImAbs(int x);
		public static extern unsafe void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
		public static extern unsafe uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		public static extern unsafe uint igGetWindowResizeCornerID(ImGuiWindow* window, int n);
		public static extern unsafe uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
		public static extern unsafe ImGuiDockNode* igGetWindowDockNode();
		public static extern unsafe byte igGetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
		public static extern unsafe ImGuiPlatformMonitor* igGetViewportPlatformMonitor(ImGuiViewport* viewport);
		public static extern unsafe ImGuiTypingSelectRequest* igGetTypingSelectRequest(ImGuiTypingSelectFlags flags);
		public static extern unsafe void igGetTypematicRepeatRate(ImGuiInputFlags flags, float* repeat_delay, float* repeat_rate);
		public static extern unsafe ImGuiWindow* igGetTopMostPopupModal();
		public static extern unsafe ImGuiWindow* igGetTopMostAndVisiblePopupModal();
		public static extern unsafe ImGuiDataVarInfo* igGetStyleVarInfo(ImGuiStyleVar idx);
		public static extern unsafe ImGuiKeyRoutingData* igGetShortcutRoutingData(ImGuiKey key_chord);
		public static extern unsafe void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
		public static extern unsafe ImGuiPlatformIO* igGetPlatformIOEx(IntPtr ctx);
		public static extern unsafe float igGetNavTweakPressedAmount(ImGuiAxis axis);
		public static extern unsafe ImGuiMultiSelectState* igGetMultiSelectState(uint id);
		public static extern unsafe ImGuiKeyOwnerData* igGetKeyOwnerData(IntPtr ctx, ImGuiKey key);
		public static extern unsafe uint igGetKeyOwner(ImGuiKey key);
		public static extern unsafe void igGetKeyMagnitude2d(Vector2* pOut, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);
		public static extern unsafe ImGuiKeyData* igGetKeyData(ImGuiKey key);
		public static extern unsafe ImGuiKeyData* igGetKeyData(IntPtr ctx, ImGuiKey key);
		public static extern unsafe byte* igGetKeyChordName(ImGuiKey key_chord);
		public static extern unsafe ImGuiItemStatusFlags igGetItemStatusFlags();
		public static extern unsafe ImGuiItemFlags igGetItemFlags();
		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		public static extern unsafe ImGuiInputTextState* igGetInputTextState(uint id);
		public static extern unsafe ImGuiIO* igGetIOEx(IntPtr ctx);
		public static extern unsafe uint igGetIDWithSeed(int n, uint seed);
		public static extern unsafe uint igGetIDWithSeed(byte* str_id_begin, byte* str_id_end, uint seed);
		public static extern unsafe uint igGetHoveredID();
		public static extern unsafe ImDrawList* igGetForegroundDrawList(ImGuiWindow* window);
		public static extern unsafe uint igGetFocusID();
		public static extern unsafe ImFont* igGetDefaultFont();
		public static extern unsafe ImGuiWindow* igGetCurrentWindowRead();
		public static extern unsafe ImGuiWindow* igGetCurrentWindow();
		public static extern unsafe ImGuiTable* igGetCurrentTable();
		public static extern unsafe ImGuiTabBar* igGetCurrentTabBar();
		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		public static extern unsafe uint igGetCurrentFocusScope();
		public static extern unsafe uint igGetColumnsID(byte* str_id, int count);
		public static extern unsafe float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
		public static extern unsafe float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
		public static extern unsafe ImGuiBoxSelectState* igGetBoxSelectState(uint id);
		public static extern unsafe uint igGetActiveID();
		public static extern unsafe void igGcCompactTransientWindowBuffers(ImGuiWindow* window);
		public static extern unsafe void igGcCompactTransientMiscBuffers();
		public static extern unsafe void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);
		public static extern unsafe void igFocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags);
		public static extern unsafe void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, ImGuiFocusRequestFlags flags);
		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		public static extern unsafe void igFocusItem();
		public static extern unsafe ImGuiKey igFixupKeyChord(ImGuiKey key_chord);
		public static extern unsafe ImGuiWindowSettings* igFindWindowSettingsByWindow(ImGuiWindow* window);
		public static extern unsafe ImGuiWindowSettings* igFindWindowSettingsByID(uint id);
		public static extern unsafe int igFindWindowDisplayIndex(ImGuiWindow* window);
		public static extern unsafe ImGuiWindow* igFindWindowByName(byte* name);
		public static extern unsafe ImGuiWindow* igFindWindowByID(uint id);
		public static extern unsafe ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);
		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static extern unsafe byte* igFindRenderedTextEnd(byte* text, byte* text_end);
		public static extern unsafe ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id);
		public static extern unsafe void igFindHoveredWindowEx(Vector2 pos, byte find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window);
		public static extern unsafe ImGuiViewportP* igFindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos);
		public static extern unsafe ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
		public static extern unsafe ImGuiWindow* igFindBlockingModal(ImGuiWindow* window);
		public static extern unsafe void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);
		public static extern unsafe void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
		public static extern unsafe void igErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* state_in);
		public static extern unsafe void igErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* state_in);
		public static extern unsafe void igErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out);
		public static extern unsafe byte igErrorLog(byte* msg);
		public static extern unsafe void igErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		public static extern unsafe void igErrorCheckEndFrameFinalizeErrorTooltip();
		public static extern unsafe void igEndErrorTooltip();
		public static extern unsafe void igEndDisabledOverrideReenable();
		public static extern unsafe void igEndComboPreview();
		/// <summary>
		/// close columns<br/>
		/// </summary>
		public static extern unsafe void igEndColumns();
		public static extern unsafe void igEndBoxSelect(ImRect scope_rect, ImGuiMultiSelectFlags ms_flags);
		public static extern unsafe byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe void igDockNodeWindowMenuHandler_Default(IntPtr ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);
		public static extern unsafe byte igDockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
		public static extern unsafe uint igDockNodeGetWindowMenuButtonId(ImGuiDockNode* node);
		public static extern unsafe ImGuiDockNode* igDockNodeGetRootNode(ImGuiDockNode* node);
		public static extern unsafe int igDockNodeGetDepth(ImGuiDockNode* node);
		public static extern unsafe void igDockNodeEndAmendTabBar();
		public static extern unsafe byte igDockNodeBeginAmendTabBar(ImGuiDockNode* node);
		public static extern unsafe void igDockContextShutdown(IntPtr ctx);
		public static extern unsafe void igDockContextRebuildNodes(IntPtr ctx);
		public static extern unsafe void igDockContextQueueUndockWindow(IntPtr ctx, ImGuiWindow* window);
		public static extern unsafe void igDockContextQueueUndockNode(IntPtr ctx, ImGuiDockNode* node);
		public static extern unsafe void igDockContextQueueDock(IntPtr ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer);
		public static extern unsafe void igDockContextProcessUndockWindow(IntPtr ctx, ImGuiWindow* window, byte clear_persistent_docking_ref);
		public static extern unsafe void igDockContextProcessUndockNode(IntPtr ctx, ImGuiDockNode* node);
		public static extern unsafe void igDockContextNewFrameUpdateUndocking(IntPtr ctx);
		public static extern unsafe void igDockContextNewFrameUpdateDocking(IntPtr ctx);
		public static extern unsafe void igDockContextInitialize(IntPtr ctx);
		public static extern unsafe uint igDockContextGenNodeID(IntPtr ctx);
		public static extern unsafe ImGuiDockNode* igDockContextFindNodeByID(IntPtr ctx, uint id);
		public static extern unsafe void igDockContextEndFrame(IntPtr ctx);
		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		public static extern unsafe void igDockContextClearNodes(IntPtr ctx, uint root_id, byte clear_settings_refs);
		public static extern unsafe byte igDockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, byte split_outer, Vector2* out_pos);
		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		public static extern unsafe uint igDockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir);
		public static extern unsafe void igDockBuilderSetNodeSize(uint node_id, Vector2 size);
		public static extern unsafe void igDockBuilderSetNodePos(uint node_id, Vector2 pos);
		public static extern unsafe void igDockBuilderRemoveNodeDockedWindows(uint node_id, byte clear_settings_refs);
		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		public static extern unsafe void igDockBuilderRemoveNodeChildNodes(uint node_id);
		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		public static extern unsafe void igDockBuilderRemoveNode(uint node_id);
		public static extern unsafe ImGuiDockNode* igDockBuilderGetNode(uint node_id);
		public static extern unsafe ImGuiDockNode* igDockBuilderGetCentralNode(uint node_id);
		public static extern unsafe void igDockBuilderFinish(uint node_id);
		public static extern unsafe void igDockBuilderDockWindow(byte* window_name, uint node_id);
		public static extern unsafe void igDockBuilderCopyWindowSettings(byte* src_name, byte* dst_name);
		public static extern unsafe void igDockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector<uint>* out_node_remap_pairs);
		public static extern unsafe void igDockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector<IntPtr>* in_window_remap_pairs);
		public static extern unsafe uint igDockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags);
		public static extern unsafe void igDestroyPlatformWindow(ImGuiViewportP* viewport);
		public static extern unsafe void igDebugTextUnformattedWithLocateItem(byte* line_begin, byte* line_end);
		public static extern unsafe void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);
		public static extern unsafe void igDebugRenderKeyboardPreview(ImDrawList* draw_list);
		public static extern unsafe void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);
		public static extern unsafe void igDebugNodeWindowsList(ImVector<ImGuiWindowPtr>* windows, byte* label);
		public static extern unsafe void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);
		public static extern unsafe void igDebugNodeWindow(ImGuiWindow* window, byte* label);
		public static extern unsafe void igDebugNodeViewport(ImGuiViewportP* viewport);
		public static extern unsafe void igDebugNodeTypingSelectState(ImGuiTypingSelectState* state);
		public static extern unsafe void igDebugNodeTableSettings(ImGuiTableSettings* settings);
		public static extern unsafe void igDebugNodeTable(ImGuiTable* table);
		public static extern unsafe void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);
		public static extern unsafe void igDebugNodeStorage(ImGuiStorage* storage, byte* label);
		public static extern unsafe void igDebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, byte* label, int idx);
		public static extern unsafe void igDebugNodeMultiSelectState(ImGuiMultiSelectState* state);
		public static extern unsafe void igDebugNodeInputTextState(ImGuiInputTextState* state);
		public static extern unsafe void igDebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph);
		public static extern unsafe void igDebugNodeFont(ImFont* font);
		public static extern unsafe void igDebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* draw_list, byte* label);
		public static extern unsafe void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);
		public static extern unsafe void igDebugNodeDockNode(ImGuiDockNode* node, byte* label);
		public static extern unsafe void igDebugNodeColumns(ImGuiOldColumns* columns);
		public static extern unsafe void igDebugLocateItemResolveWithLastItem();
		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		public static extern unsafe void igDebugLocateItemOnHover(uint target_id);
		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		public static extern unsafe void igDebugLocateItem(uint target_id);
		public static extern unsafe void igDebugHookIdInfo(uint id, ImGuiDataType data_type, void* data_id, void* data_id_end);
		public static extern unsafe void igDebugDrawLineExtents(uint col);
		public static extern unsafe void igDebugDrawItemRect(uint col);
		public static extern unsafe void igDebugDrawCursorPos(uint col);
		public static extern unsafe void igDebugBreakClearData();
		public static extern unsafe void igDebugBreakButtonTooltip(byte keyboard_only, byte* description_of_location);
		public static extern unsafe byte igDebugBreakButton(byte* label, byte* description_of_location);
		/// <summary>
		/// size >= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		public static extern unsafe void igDebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, uint size);
		public static extern unsafe byte igDataTypeIsZero(ImGuiDataType data_type, void* p_data);
		public static extern unsafe ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);
		public static extern unsafe int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
		public static extern unsafe int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);
		public static extern unsafe byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
		public static extern unsafe void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
		public static extern unsafe byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format, void* p_data_when_empty);
		public static extern unsafe ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);
		public static extern unsafe ImGuiKey igConvertSingleModFlagToKey(ImGuiKey key);
		public static extern unsafe void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
		public static extern unsafe void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
		public static extern unsafe void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
		public static extern unsafe byte igCollapseButton(uint id, Vector2 pos, ImGuiDockNode* dock_node);
		public static extern unsafe void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
		public static extern unsafe void igClosePopupsExceptModals();
		public static extern unsafe void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
		public static extern unsafe byte igCloseButton(uint id, Vector2 pos);
		public static extern unsafe void igClearWindowSettings(byte* name);
		public static extern unsafe void igClearIniSettings();
		public static extern unsafe void igClearDragDrop();
		public static extern unsafe void igClearActiveID();
		public static extern unsafe byte igCheckboxFlags(byte* label, ulong* flags, ulong flags_value);
		public static extern unsafe byte igCheckboxFlags(byte* label, long* flags, long flags_value);
		public static extern unsafe void igCallContextHooks(IntPtr context, ImGuiContextHookType type);
		public static extern unsafe float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
		public static extern unsafe void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);
		public static extern unsafe int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
		public static extern unsafe ImDrawFlags igCalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold);
		public static extern unsafe void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);
		public static extern unsafe byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
		public static extern unsafe byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
		public static extern unsafe void igBringWindowToFocusFront(ImGuiWindow* window);
		public static extern unsafe void igBringWindowToDisplayFront(ImGuiWindow* window);
		public static extern unsafe void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);
		public static extern unsafe void igBringWindowToDisplayBack(ImGuiWindow* window);
		public static extern unsafe byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);
		public static extern unsafe byte igBeginTooltipHidden();
		public static extern unsafe byte igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);
		public static extern unsafe byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
		public static extern unsafe byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags);
		public static extern unsafe byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_window_flags);
		public static extern unsafe byte igBeginMenuEx(byte* label, byte* icon, byte enabled);
		public static extern unsafe byte igBeginErrorTooltip();
		public static extern unsafe byte igBeginDragDropTargetCustom(ImRect bb, uint id);
		public static extern unsafe void igBeginDocked(ImGuiWindow* window, byte* p_open);
		public static extern unsafe void igBeginDockableDragDropTarget(ImGuiWindow* window);
		public static extern unsafe void igBeginDockableDragDropSource(ImGuiWindow* window);
		public static extern unsafe void igBeginDisabledOverrideReenable();
		public static extern unsafe byte igBeginComboPreview();
		public static extern unsafe byte igBeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags);
		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static extern unsafe void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);
		public static extern unsafe byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		public static extern unsafe byte igBeginBoxSelect(ImRect scope_rect, ImGuiWindow* window, uint box_select_id, ImGuiMultiSelectFlags ms_flags);
		public static extern unsafe byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
		public static extern unsafe void igAddSettingsHandler(ImGuiSettingsHandler* handler);
		public static extern unsafe void igAddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector<ImDrawListPtr>* out_list, ImDrawList* draw_list);
		public static extern unsafe uint igAddContextHook(IntPtr context, ImGuiContextHook* hook);
		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		public static extern unsafe void igActivateItemByID(uint id);
		public static extern unsafe void ImVec2ih_destroy(ImVec2ih* self);
		public static extern unsafe void ImVec2ih_ImVec2ih(Vector2 rhs);
		public static extern unsafe void ImVec2ih_ImVec2ih(short _x, short _y);
		public static extern unsafe void ImVec2ih_ImVec2ih();
		public static extern unsafe void ImVec1_destroy(ImVec1* self);
		public static extern unsafe void ImVec1_ImVec1(float _x);
		public static extern unsafe void ImVec1_ImVec1();
		public static extern unsafe void ImRect_destroy(ImRect* self);
		public static extern unsafe void ImRect_TranslateY(ImRect* self, float dy);
		public static extern unsafe void ImRect_TranslateX(ImRect* self, float dx);
		public static extern unsafe void ImRect_Translate(ImRect* self, Vector2 d);
		public static extern unsafe void ImRect_ToVec4(Vector4* pOut, ImRect* self);
		public static extern unsafe byte ImRect_Overlaps(ImRect* self, ImRect r);
		public static extern unsafe byte ImRect_IsInverted(ImRect* self);
		public static extern unsafe void ImRect_ImRect(float x1, float y1, float x2, float y2);
		public static extern unsafe void ImRect_ImRect(Vector4 v);
		public static extern unsafe void ImRect_ImRect(Vector2 min, Vector2 max);
		public static extern unsafe void ImRect_ImRect();
		public static extern unsafe float ImRect_GetWidth(ImRect* self);
		/// <summary>
		/// Top-right<br/>
		/// </summary>
		public static extern unsafe void ImRect_GetTR(Vector2* pOut, ImRect* self);
		/// <summary>
		/// Top-left<br/>
		/// </summary>
		public static extern unsafe void ImRect_GetTL(Vector2* pOut, ImRect* self);
		public static extern unsafe void ImRect_GetSize(Vector2* pOut, ImRect* self);
		public static extern unsafe float ImRect_GetHeight(ImRect* self);
		public static extern unsafe void ImRect_GetCenter(Vector2* pOut, ImRect* self);
		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		public static extern unsafe void ImRect_GetBR(Vector2* pOut, ImRect* self);
		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		public static extern unsafe void ImRect_GetBL(Vector2* pOut, ImRect* self);
		public static extern unsafe float ImRect_GetArea(ImRect* self);
		public static extern unsafe void ImRect_Floor(ImRect* self);
		public static extern unsafe void ImRect_Expand(ImRect* self, Vector2 amount);
		public static extern unsafe void ImRect_Expand(ImRect* self, float amount);
		public static extern unsafe byte ImRect_ContainsWithPad(ImRect* self, Vector2 p, Vector2 pad);
		public static extern unsafe byte ImRect_Contains(ImRect* self, ImRect r);
		public static extern unsafe byte ImRect_Contains(ImRect* self, Vector2 p);
		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		public static extern unsafe void ImRect_ClipWithFull(ImRect* self, ImRect r);
		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		public static extern unsafe void ImRect_ClipWith(ImRect* self, ImRect r);
		public static extern unsafe void ImRect_Add(ImRect* self, ImRect r);
		public static extern unsafe void ImRect_Add(ImRect* self, Vector2 p);
		public static extern unsafe void ImGuiWindow_destroy(ImGuiWindow* self);
		public static extern unsafe void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);
		public static extern unsafe void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);
		public static extern unsafe void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);
		public static extern unsafe void ImGuiWindow_ImGuiWindow(IntPtr context, byte* name);
		public static extern unsafe uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);
		public static extern unsafe uint ImGuiWindow_GetIDFromPos(ImGuiWindow* self, Vector2 p_abs);
		public static extern unsafe uint ImGuiWindow_GetID(ImGuiWindow* self, int n);
		public static extern unsafe uint ImGuiWindow_GetID(ImGuiWindow* self, void* ptr);
		public static extern unsafe uint ImGuiWindow_GetID(ImGuiWindow* self, byte* str, byte* str_end);
		public static extern unsafe float ImGuiWindow_CalcFontSize(ImGuiWindow* self);
		public static extern unsafe void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);
		public static extern unsafe void ImGuiWindowSettings_ImGuiWindowSettings();
		public static extern unsafe byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);
		public static extern unsafe void ImGuiViewportP_destroy(ImGuiViewportP* self);
		/// <summary>
		/// Update public fields<br/>
		/// </summary>
		public static extern unsafe void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);
		public static extern unsafe void ImGuiViewportP_ImGuiViewportP();
		public static extern unsafe void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self);
		public static extern unsafe void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self);
		public static extern unsafe void ImGuiViewportP_GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);
		public static extern unsafe void ImGuiViewportP_ClearRequestFlags(ImGuiViewportP* self);
		public static extern unsafe void ImGuiViewportP_CalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 inset_min, Vector2 inset_max);
		public static extern unsafe void ImGuiViewportP_CalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 inset_min);
		public static extern unsafe void ImGuiTypingSelectState_destroy(ImGuiTypingSelectState* self);
		public static extern unsafe void ImGuiTypingSelectState_ImGuiTypingSelectState();
		/// <summary>
		/// We preserve remaining data for easier debugging<br/>
		/// </summary>
		public static extern unsafe void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* self);
		public static extern unsafe int ImGuiTextIndex_size(ImGuiTextIndex* self);
		public static extern unsafe byte* ImGuiTextIndex_get_line_end(ImGuiTextIndex* self, byte* @base, int n);
		public static extern unsafe byte* ImGuiTextIndex_get_line_begin(ImGuiTextIndex* self, byte* @base, int n);
		public static extern unsafe void ImGuiTextIndex_clear(ImGuiTextIndex* self);
		public static extern unsafe void ImGuiTextIndex_append(ImGuiTextIndex* self, byte* @base, int old_size, int new_size);
		public static extern unsafe void ImGuiTable_destroy(ImGuiTable* self);
		public static extern unsafe void ImGuiTable_ImGuiTable();
		public static extern unsafe void ImGuiTableTempData_destroy(ImGuiTableTempData* self);
		public static extern unsafe void ImGuiTableTempData_ImGuiTableTempData();
		public static extern unsafe void ImGuiTableSettings_destroy(ImGuiTableSettings* self);
		public static extern unsafe void ImGuiTableSettings_ImGuiTableSettings();
		public static extern unsafe ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);
		public static extern unsafe void ImGuiTableInstanceData_destroy(ImGuiTableInstanceData* self);
		public static extern unsafe void ImGuiTableInstanceData_ImGuiTableInstanceData();
		public static extern unsafe void ImGuiTableColumn_destroy(ImGuiTableColumn* self);
		public static extern unsafe void ImGuiTableColumn_ImGuiTableColumn();
		public static extern unsafe void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self);
		public static extern unsafe void ImGuiTableColumnSettings_ImGuiTableColumnSettings();
		public static extern unsafe void ImGuiTabItem_destroy(ImGuiTabItem* self);
		public static extern unsafe void ImGuiTabItem_ImGuiTabItem();
		public static extern unsafe void ImGuiTabBar_destroy(ImGuiTabBar* self);
		public static extern unsafe void ImGuiTabBar_ImGuiTabBar();
		public static extern unsafe void ImGuiStyleMod_destroy(ImGuiStyleMod* self);
		public static extern unsafe void ImGuiStyleMod_ImGuiStyleMod(ImGuiStyleVar idx, Vector2 v);
		public static extern unsafe void ImGuiStyleMod_ImGuiStyleMod(ImGuiStyleVar idx, float v);
		public static extern unsafe void ImGuiStyleMod_ImGuiStyleMod(ImGuiStyleVar idx, int v);
		public static extern unsafe void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self);
		public static extern unsafe void ImGuiStackLevelInfo_ImGuiStackLevelInfo();
		public static extern unsafe void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);
		public static extern unsafe void ImGuiSettingsHandler_ImGuiSettingsHandler();
		public static extern unsafe void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);
		public static extern unsafe void ImGuiPtrOrIndex_ImGuiPtrOrIndex(int index);
		public static extern unsafe void ImGuiPtrOrIndex_ImGuiPtrOrIndex(void* ptr);
		public static extern unsafe void ImGuiPopupData_destroy(ImGuiPopupData* self);
		public static extern unsafe void ImGuiPopupData_ImGuiPopupData();
		public static extern unsafe void ImGuiOldColumns_destroy(ImGuiOldColumns* self);
		public static extern unsafe void ImGuiOldColumns_ImGuiOldColumns();
		public static extern unsafe void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self);
		public static extern unsafe void ImGuiOldColumnData_ImGuiOldColumnData();
		public static extern unsafe void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);
		public static extern unsafe void ImGuiNextWindowData_ImGuiNextWindowData();
		public static extern unsafe void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);
		public static extern unsafe void ImGuiNextItemData_destroy(ImGuiNextItemData* self);
		public static extern unsafe void ImGuiNextItemData_ImGuiNextItemData();
		/// <summary>
		/// Also cleared manually by ItemAdd()!<br/>
		/// </summary>
		public static extern unsafe void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);
		public static extern unsafe void ImGuiNavItemData_destroy(ImGuiNavItemData* self);
		public static extern unsafe void ImGuiNavItemData_ImGuiNavItemData();
		public static extern unsafe void ImGuiNavItemData_Clear(ImGuiNavItemData* self);
		public static extern unsafe void ImGuiMultiSelectTempData_destroy(ImGuiMultiSelectTempData* self);
		public static extern unsafe void ImGuiMultiSelectTempData_ImGuiMultiSelectTempData();
		public static extern unsafe void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* self);
		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.<br/>
		/// </summary>
		public static extern unsafe void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* self);
		public static extern unsafe void ImGuiMultiSelectState_destroy(ImGuiMultiSelectState* self);
		public static extern unsafe void ImGuiMultiSelectState_ImGuiMultiSelectState();
		public static extern unsafe void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);
		public static extern unsafe void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing);
		public static extern unsafe void ImGuiMenuColumns_ImGuiMenuColumns();
		public static extern unsafe float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);
		public static extern unsafe void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets);
		public static extern unsafe ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max);
		public static extern unsafe ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max);
		public static extern unsafe void ImGuiListClipperData_destroy(ImGuiListClipperData* self);
		public static extern unsafe void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);
		public static extern unsafe void ImGuiListClipperData_ImGuiListClipperData();
		public static extern unsafe void ImGuiLastItemData_destroy(ImGuiLastItemData* self);
		public static extern unsafe void ImGuiLastItemData_ImGuiLastItemData();
		public static extern unsafe void ImGuiKeyRoutingTable_destroy(ImGuiKeyRoutingTable* self);
		public static extern unsafe void ImGuiKeyRoutingTable_ImGuiKeyRoutingTable();
		public static extern unsafe void ImGuiKeyRoutingTable_Clear(ImGuiKeyRoutingTable* self);
		public static extern unsafe void ImGuiKeyRoutingData_destroy(ImGuiKeyRoutingData* self);
		public static extern unsafe void ImGuiKeyRoutingData_ImGuiKeyRoutingData();
		public static extern unsafe void ImGuiKeyOwnerData_destroy(ImGuiKeyOwnerData* self);
		public static extern unsafe void ImGuiKeyOwnerData_ImGuiKeyOwnerData();
		public static extern unsafe void ImGuiInputTextState_destroy(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* self);
		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation<br/>
		/// </summary>
		public static extern unsafe void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);
		public static extern unsafe void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* self, uint c);
		public static extern unsafe void ImGuiInputTextState_ImGuiInputTextState();
		public static extern unsafe byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);
		public static extern unsafe int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self);
		public static extern unsafe int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self);
		public static extern unsafe int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);
		public static extern unsafe void ImGuiInputTextDeactivatedState_destroy(ImGuiInputTextDeactivatedState* self);
		public static extern unsafe void ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState();
		public static extern unsafe void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* self);
		public static extern unsafe void ImGuiInputEvent_destroy(ImGuiInputEvent* self);
		public static extern unsafe void ImGuiInputEvent_ImGuiInputEvent();
		public static extern unsafe void ImGuiIDStackTool_destroy(ImGuiIDStackTool* self);
		public static extern unsafe void ImGuiIDStackTool_ImGuiIDStackTool();
		public static extern unsafe void ImGuiErrorRecoveryState_destroy(ImGuiErrorRecoveryState* self);
		public static extern unsafe void ImGuiErrorRecoveryState_ImGuiErrorRecoveryState();
		public static extern unsafe void ImGuiDockNode_destroy(ImGuiDockNode* self);
		public static extern unsafe void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* self);
		public static extern unsafe void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags);
		public static extern unsafe void ImGuiDockNode_Rect(ImRect* pOut, ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsSplitNode(ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsRootNode(ImGuiDockNode* self);
		/// <summary>
		/// Never show a tab bar<br/>
		/// </summary>
		public static extern unsafe byte ImGuiDockNode_IsNoTabBar(ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsLeafNode(ImGuiDockNode* self);
		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle<br/>
		/// </summary>
		public static extern unsafe byte ImGuiDockNode_IsHiddenTabBar(ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsFloatingNode(ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsEmpty(ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsDockSpace(ImGuiDockNode* self);
		public static extern unsafe byte ImGuiDockNode_IsCentralNode(ImGuiDockNode* self);
		public static extern unsafe void ImGuiDockNode_ImGuiDockNode(uint id);
		public static extern unsafe void ImGuiDockContext_destroy(ImGuiDockContext* self);
		public static extern unsafe void ImGuiDockContext_ImGuiDockContext();
		public static extern unsafe void ImGuiDebugAllocInfo_destroy(ImGuiDebugAllocInfo* self);
		public static extern unsafe void ImGuiDebugAllocInfo_ImGuiDebugAllocInfo();
		public static extern unsafe void* ImGuiDataVarInfo_GetVarPtr(ImGuiDataVarInfo* self, void* parent);
		public static extern unsafe void ImGuiContext_destroy(IntPtr self);
		public static extern unsafe void ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);
		public static extern unsafe void ImGuiContextHook_destroy(ImGuiContextHook* self);
		public static extern unsafe void ImGuiContextHook_ImGuiContextHook();
		public static extern unsafe void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self);
		public static extern unsafe void ImGuiComboPreviewData_ImGuiComboPreviewData();
		public static extern unsafe void ImGuiBoxSelectState_destroy(ImGuiBoxSelectState* self);
		public static extern unsafe void ImGuiBoxSelectState_ImGuiBoxSelectState();
		public static extern unsafe void ImDrawListSharedData_destroy(ImDrawListSharedData* self);
		public static extern unsafe void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error);
		public static extern unsafe void ImDrawListSharedData_ImDrawListSharedData();
		public static extern unsafe void ImDrawDataBuilder_destroy(ImDrawDataBuilder* self);
		public static extern unsafe void ImDrawDataBuilder_ImDrawDataBuilder();
		public static extern unsafe byte ImBitVector_TestBit(ImBitVector* self, int n);
		public static extern unsafe void ImBitVector_SetBit(ImBitVector* self, int n);
		public static extern unsafe void ImBitVector_Create(ImBitVector* self, int sz);
		public static extern unsafe void ImBitVector_ClearBit(ImBitVector* self, int n);
	}
}

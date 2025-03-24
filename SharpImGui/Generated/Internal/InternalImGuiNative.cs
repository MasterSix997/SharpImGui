using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	public unsafe struct InternalImGuiNative
	{
		public static unsafe extern void WindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, const ImRect r);
		public static unsafe extern void WindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, const ImRect r);
		public static unsafe extern void WindowPosRelToAbs(ImVec2* pOut, ImGuiWindow* window, const ImVec2 p);
		public static unsafe extern void WindowPosAbsToRel(ImVec2* pOut, ImGuiWindow* window, const ImVec2 p);
		public static unsafe extern void UpdateWindowSkipRefresh(ImGuiWindow* window);
		public static unsafe extern void UpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
		public static unsafe extern void UpdateMouseMovingWindowNewFrame();
		public static unsafe extern void UpdateMouseMovingWindowEndFrame();
		public static unsafe extern void UpdateInputEvents(bool trickle_fast_inputs);
		public static unsafe extern void UpdateHoveredWindowAndCaptureFlags();
		public static unsafe extern int TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, const char*(*)(void*,int) get_item_name_func, void* user_data, int nav_item_idx);
		public static unsafe extern int TypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, const char*(*)(void*,int) get_item_name_func, void* user_data, int nav_item_idx);
		public static unsafe extern int TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, const char*(*)(void*,int) get_item_name_func, void* user_data);
		public static unsafe extern void TreePushOverrideID(ImGuiID id);
		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		public static unsafe extern bool TreeNodeUpdateNextOpen(ImGuiID storage_id, ImGuiTreeNodeFlags flags);
		public static unsafe extern void TreeNodeSetOpen(ImGuiID storage_id, bool open);
		public static unsafe extern bool TreeNodeGetOpen(ImGuiID storage_id);
		public static unsafe extern bool TreeNodeBehavior(ImGuiID id, ImGuiTreeNodeFlags flags, const char* label, const char* label_end);
		public static unsafe extern void TranslateWindowsInViewport(ImGuiViewportP* viewport, const ImVec2 old_pos, const ImVec2 new_pos, const ImVec2 old_size, const ImVec2 new_size);
		public static unsafe extern void TextEx(const char* text, const char* text_end, ImGuiTextFlags flags);
		public static unsafe extern bool TestShortcutRouting(ImGuiKeyChord key_chord, ImGuiID owner_id);
		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		public static unsafe extern bool TestKeyOwner(ImGuiKey key, ImGuiID owner_id);
		public static unsafe extern bool TempInputText(const ImRect bb, ImGuiID id, const char* label, char* buf, int buf_size, ImGuiInputTextFlags flags);
		public static unsafe extern bool TempInputScalar(const ImRect bb, ImGuiID id, const char* label, ImGuiDataType data_type, void* p_data, const char* format, const void* p_clamp_min, const void* p_clamp_max);
		public static unsafe extern bool TempInputIsActive(ImGuiID id);
		public static unsafe extern void TeleportMousePos(const ImVec2 pos);
		public static unsafe extern void TableUpdateLayout(ImGuiTable* table);
		public static unsafe extern void TableUpdateColumnsWeightFromWidth(ImGuiTable* table);
		public static unsafe extern void TableUpdateBorders(ImGuiTable* table);
		public static unsafe extern void TableSortSpecsSanitize(ImGuiTable* table);
		public static unsafe extern void TableSortSpecsBuild(ImGuiTable* table);
		public static unsafe extern void TableSetupDrawChannels(ImGuiTable* table);
		public static unsafe extern ImGuiTableSettings* TableSettingsFindByID(ImGuiID id);
		public static unsafe extern ImGuiTableSettings* TableSettingsCreate(ImGuiID id, int columns_count);
		public static unsafe extern void TableSettingsAddSettingsHandler();
		public static unsafe extern void TableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
		public static unsafe extern void TableSetColumnWidthAutoAll(ImGuiTable* table);
		public static unsafe extern void TableSetColumnWidth(int column_n, float width);
		public static unsafe extern void TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, bool append_to_sort_specs);
		public static unsafe extern void TableSaveSettings(ImGuiTable* table);
		public static unsafe extern void TableResetSettings(ImGuiTable* table);
		public static unsafe extern void TableRemove(ImGuiTable* table);
		public static unsafe extern void TablePushBackgroundChannel();
		public static unsafe extern void TablePopBackgroundChannel();
		public static unsafe extern void TableOpenContextMenu(int column_n);
		public static unsafe extern void TableMergeDrawChannels(ImGuiTable* table);
		public static unsafe extern void TableLoadSettings(ImGuiTable* table);
		public static unsafe extern ImGuiID TableGetInstanceID(ImGuiTable* table, int instance_no);
		public static unsafe extern ImGuiTableInstanceData* TableGetInstanceData(ImGuiTable* table, int instance_no);
		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		public static unsafe extern int TableGetHoveredRow();
		public static unsafe extern float TableGetHeaderRowHeight();
		public static unsafe extern float TableGetHeaderAngledMaxLabelWidth();
		public static unsafe extern float TableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
		public static unsafe extern ImGuiID TableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);
		public static unsafe extern ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumn* column);
		public static unsafe extern const char* TableGetColumnName(const ImGuiTable* table, int column_n);
		public static unsafe extern void TableGetCellBgRect(ImRect* pOut, const ImGuiTable* table, int column_n);
		public static unsafe extern ImGuiTableSettings* TableGetBoundSettings(ImGuiTable* table);
		public static unsafe extern void TableGcCompactTransientBuffers(ImGuiTableTempData* table);
		public static unsafe extern void TableGcCompactTransientBuffers(ImGuiTable* table);
		public static unsafe extern void TableGcCompactSettings();
		public static unsafe extern void TableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
		public static unsafe extern ImGuiTable* TableFindByID(ImGuiID id);
		public static unsafe extern void TableEndRow(ImGuiTable* table);
		public static unsafe extern void TableEndCell(ImGuiTable* table);
		public static unsafe extern void TableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flags_for_section_to_display);
		public static unsafe extern void TableDrawBorders(ImGuiTable* table);
		public static unsafe extern float TableCalcMaxColumnWidth(const ImGuiTable* table, int column_n);
		public static unsafe extern void TableBeginRow(ImGuiTable* table);
		public static unsafe extern void TableBeginInitMemory(ImGuiTable* table, int columns_count);
		public static unsafe extern bool TableBeginContextMenuPopup(ImGuiTable* table);
		public static unsafe extern void TableBeginCell(ImGuiTable* table, int column_n);
		public static unsafe extern void TableBeginApplyRequests(ImGuiTable* table);
		public static unsafe extern void TableAngledHeadersRowEx(ImGuiID row_id, float angle, float max_label_width, const ImGuiTableHeaderData* data, int data_count);
		public static unsafe extern void TabItemSpacing(const char* str_id, ImGuiTabItemFlags flags, float width);
		public static unsafe extern void TabItemLabelAndCloseButton(ImDrawList* draw_list, const ImRect bb, ImGuiTabItemFlags flags, ImVec2 frame_padding, const char* label, ImGuiID tab_id, ImGuiID close_button_id, bool is_contents_visible, bool* out_just_closed, bool* out_text_clipped);
		public static unsafe extern bool TabItemEx(ImGuiTabBar* tab_bar, const char* label, bool* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window);
		public static unsafe extern void TabItemCalcSize(ImVec2* pOut, ImGuiWindow* window);
		public static unsafe extern void TabItemCalcSize(ImVec2* pOut, const char* label, bool has_close_button_or_unsaved_marker);
		public static unsafe extern void TabItemBackground(ImDrawList* draw_list, const ImRect bb, ImGuiTabItemFlags flags, ImU32 col);
		public static unsafe extern void TabBarRemoveTab(ImGuiTabBar* tab_bar, ImGuiID tab_id);
		public static unsafe extern void TabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, ImVec2 mouse_pos);
		public static unsafe extern void TabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
		public static unsafe extern void TabBarQueueFocus(ImGuiTabBar* tab_bar, const char* tab_name);
		public static unsafe extern void TabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static unsafe extern bool TabBarProcessReorder(ImGuiTabBar* tab_bar);
		public static unsafe extern int TabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static unsafe extern const char* TabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static unsafe extern ImGuiTabItem* TabBarGetCurrentTab(ImGuiTabBar* tab_bar);
		public static unsafe extern ImGuiTabItem* TabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);
		public static unsafe extern ImGuiTabItem* TabBarFindTabByID(ImGuiTabBar* tab_bar, ImGuiID tab_id);
		public static unsafe extern ImGuiTabItem* TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
		public static unsafe extern void TabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		public static unsafe extern void TabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window);
		public static unsafe extern void StartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, bool undock);
		public static unsafe extern void StartMouseMovingWindow(ImGuiWindow* window);
		public static unsafe extern bool SplitterBehavior(const ImRect bb, ImGuiID id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, ImU32 bg_col);
		public static unsafe extern bool SliderBehavior(const ImRect bb, ImGuiID id, ImGuiDataType data_type, void* p_v, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		public static unsafe extern void Shutdown();
		public static unsafe extern void ShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
		public static unsafe extern void ShowFontAtlas(ImFontAtlas* atlas);
		public static unsafe extern bool Shortcut(ImGuiKeyChord key_chord, ImGuiInputFlags flags, ImGuiID owner_id);
		public static unsafe extern void ShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, const ImVec2 pivot_in, float cos_a, float sin_a, const ImVec2 pivot_out);
		public static unsafe extern void ShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, const ImVec2 a, const ImVec2 b, const ImVec2 uv_a, const ImVec2 uv_b, bool clamp);
		public static unsafe extern void ShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, ImVec2 gradient_p0, ImVec2 gradient_p1, ImU32 col0, ImU32 col1);
		public static unsafe extern void SetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		public static unsafe extern void SetWindowSize(ImGuiWindow* window, const ImVec2 size, ImGuiCond cond);
		public static unsafe extern void SetWindowPos(ImGuiWindow* window, const ImVec2 pos, ImGuiCond cond);
		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		public static unsafe extern void SetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parent_window);
		public static unsafe extern void SetWindowHitTestHole(ImGuiWindow* window, const ImVec2 pos, const ImVec2 size);
		public static unsafe extern void SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);
		public static unsafe extern void SetWindowDock(ImGuiWindow* window, ImGuiID dock_id, ImGuiCond cond);
		public static unsafe extern void SetWindowCollapsed(ImGuiWindow* window, bool collapsed, ImGuiCond cond);
		public static unsafe extern void SetWindowClipRectBeforeSetChannel(ImGuiWindow* window, const ImRect clip_rect);
		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		public static unsafe extern bool SetShortcutRouting(ImGuiKeyChord key_chord, ImGuiInputFlags flags, ImGuiID owner_id);
		public static unsafe extern void SetScrollY(ImGuiWindow* window, float scroll_y);
		public static unsafe extern void SetScrollX(ImGuiWindow* window, float scroll_x);
		public static unsafe extern void SetScrollFromPosY(ImGuiWindow* window, float local_y, float center_y_ratio);
		public static unsafe extern void SetScrollFromPosX(ImGuiWindow* window, float local_x, float center_x_ratio);
		public static unsafe extern void SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags);
		public static unsafe extern void SetNextItemRefVal(ImGuiDataType data_type, void* p_data);
		public static unsafe extern void SetNavWindow(ImGuiWindow* window);
		public static unsafe extern void SetNavID(ImGuiID id, ImGuiNavLayer nav_layer, ImGuiID focus_scope_id, const ImRect rect_rel);
		public static unsafe extern void SetNavFocusScope(ImGuiID focus_scope_id);
		public static unsafe extern void SetNavCursorVisibleAfterMove();
		public static unsafe extern void SetLastItemData(ImGuiID item_id, ImGuiItemFlags item_flags, ImGuiItemStatusFlags status_flags, const ImRect item_rect);
		public static unsafe extern void SetKeyOwnersForKeyChord(ImGuiKeyChord key, ImGuiID owner_id, ImGuiInputFlags flags);
		public static unsafe extern void SetKeyOwner(ImGuiKey key, ImGuiID owner_id, ImGuiInputFlags flags);
		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		public static unsafe extern void SetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags);
		public static unsafe extern void SetHoveredID(ImGuiID id);
		public static unsafe extern void SetFocusID(ImGuiID id, ImGuiWindow* window);
		public static unsafe extern void SetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		public static unsafe extern void SetCurrentFont(ImFont* font);
		public static unsafe extern void SetActiveIdUsingAllKeyboardKeys();
		public static unsafe extern void SetActiveID(ImGuiID id, ImGuiWindow* window);
		public static unsafe extern void SeparatorTextEx(ImGuiID id, const char* label, const char* label_end, float extra_width);
		public static unsafe extern void SeparatorEx(ImGuiSeparatorFlags flags, float thickness);
		public static unsafe extern bool ScrollbarEx(const ImRect bb, ImGuiID id, ImGuiAxis axis, ImS64* p_scroll_v, ImS64 avail_v, ImS64 contents_v, ImDrawFlags draw_rounding_flags);
		public static unsafe extern void Scrollbar(ImGuiAxis axis);
		public static unsafe extern void ScrollToRectEx(ImVec2* pOut, ImGuiWindow* window, const ImRect rect, ImGuiScrollFlags flags);
		public static unsafe extern void ScrollToRect(ImGuiWindow* window, const ImRect rect, ImGuiScrollFlags flags);
		public static unsafe extern void ScrollToItem(ImGuiScrollFlags flags);
		public static unsafe extern void ScrollToBringRectIntoView(ImGuiWindow* window, const ImRect rect);
		public static unsafe extern void ScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
		public static unsafe extern void RenderTextWrapped(ImVec2 pos, const char* text, const char* text_end, float wrap_width);
		public static unsafe extern void RenderTextEllipsis(ImDrawList* draw_list, const ImVec2 pos_min, const ImVec2 pos_max, float clip_max_x, float ellipsis_max_x, const char* text, const char* text_end, const ImVec2* text_size_if_known);
		public static unsafe extern void RenderTextClippedEx(ImDrawList* draw_list, const ImVec2 pos_min, const ImVec2 pos_max, const char* text, const char* text_end, const ImVec2* text_size_if_known, const ImVec2 align, const ImRect* clip_rect);
		public static unsafe extern void RenderTextClipped(const ImVec2 pos_min, const ImVec2 pos_max, const char* text, const char* text_end, const ImVec2* text_size_if_known, const ImVec2 align, const ImRect* clip_rect);
		public static unsafe extern void RenderText(ImVec2 pos, const char* text, const char* text_end, bool hide_text_after_hash);
		public static unsafe extern void RenderRectFilledWithHole(ImDrawList* draw_list, const ImRect outer, const ImRect inner, ImU32 col, float rounding);
		public static unsafe extern void RenderRectFilledRangeH(ImDrawList* draw_list, const ImRect rect, ImU32 col, float x_start_norm, float x_end_norm, float rounding);
		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		public static unsafe extern void RenderNavCursor(const ImRect bb, ImGuiID id, ImGuiNavRenderCursorFlags flags);
		public static unsafe extern void RenderMouseCursor(ImVec2 pos, float scale, ImGuiMouseCursor mouse_cursor, ImU32 col_fill, ImU32 col_border, ImU32 col_shadow);
		public static unsafe extern void RenderFrameBorder(ImVec2 p_min, ImVec2 p_max, float rounding);
		public static unsafe extern void RenderFrame(ImVec2 p_min, ImVec2 p_max, ImU32 fill_col, bool borders, float rounding);
		public static unsafe extern void RenderDragDropTargetRect(const ImRect bb, const ImRect item_clip_rect);
		public static unsafe extern void RenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, ImVec2 p_min, ImVec2 p_max, ImU32 fill_col, float grid_step, ImVec2 grid_off, float rounding, ImDrawFlags flags);
		public static unsafe extern void RenderCheckMark(ImDrawList* draw_list, ImVec2 pos, ImU32 col, float sz);
		public static unsafe extern void RenderBullet(ImDrawList* draw_list, ImVec2 pos, ImU32 col);
		public static unsafe extern void RenderArrowPointingAt(ImDrawList* draw_list, ImVec2 pos, ImVec2 half_sz, ImGuiDir direction, ImU32 col);
		public static unsafe extern void RenderArrowDockMenu(ImDrawList* draw_list, ImVec2 p_min, float sz, ImU32 col);
		public static unsafe extern void RenderArrow(ImDrawList* draw_list, ImVec2 pos, ImU32 col, ImGuiDir dir, float scale);
		public static unsafe extern void RemoveSettingsHandler(const char* type_name);
		public static unsafe extern void RemoveContextHook(ImGuiContext* context, ImGuiID hook_to_remove);
		public static unsafe extern void PushPasswordFont();
		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		public static unsafe extern void PushOverrideID(ImGuiID id);
		public static unsafe extern void PushMultiItemsWidths(int components, float width_full);
		public static unsafe extern void PushFocusScope(ImGuiID id);
		public static unsafe extern void PushColumnsBackground();
		public static unsafe extern void PushColumnClipRect(int column_index);
		public static unsafe extern void PopFocusScope();
		public static unsafe extern void PopColumnsBackground();
		public static unsafe extern int PlotEx(ImGuiPlotType plot_type, const char* label, float(*)(void* data,int idx) values_getter, void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, const ImVec2 size_arg);
		public static unsafe extern void OpenPopupEx(ImGuiID id, ImGuiPopupFlags popup_flags);
		public static unsafe extern void NavUpdateCurrentWindowIsScrollPushableX();
		public static unsafe extern void NavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
		public static unsafe extern void NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
		public static unsafe extern void NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data);
		public static unsafe extern void NavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
		public static unsafe extern void NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
		public static unsafe extern void NavMoveRequestCancel();
		public static unsafe extern bool NavMoveRequestButNoResultYet();
		public static unsafe extern void NavMoveRequestApplyResult();
		public static unsafe extern void NavInitWindow(ImGuiWindow* window, bool force_reinit);
		public static unsafe extern void NavInitRequestApplyResult();
		public static unsafe extern void NavHighlightActivated(ImGuiID id);
		public static unsafe extern void NavClearPreferredPosForAxis(ImGuiAxis axis);
		public static unsafe extern void MultiSelectItemHeader(ImGuiID id, bool* p_selected, ImGuiButtonFlags* p_button_flags);
		public static unsafe extern void MultiSelectItemFooter(ImGuiID id, bool* p_selected, bool* p_pressed);
		public static unsafe extern void MultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, bool selected, int range_dir, ImGuiSelectionUserData first_item, ImGuiSelectionUserData last_item);
		public static unsafe extern void MultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, bool selected);
		public static unsafe extern ImGuiKey MouseButtonToKey(ImGuiMouseButton button);
		public static unsafe extern bool MenuItemEx(const char* label, const char* icon, const char* shortcut, bool selected, bool enabled);
		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		public static unsafe extern void MarkItemEdited(ImGuiID id);
		public static unsafe extern void MarkIniSettingsDirty(ImGuiWindow* window);
		public static unsafe extern void MarkIniSettingsDirty();
		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		public static unsafe extern void LogToBuffer(int auto_open_depth);
		public static unsafe extern void LogSetNextTextDecoration(const char* prefix, const char* suffix);
		public static unsafe extern void LogRenderedText(const ImVec2* ref_pos, const char* text, const char* text_end);
		/// <summary>
		/// -> BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		public static unsafe extern void LogBegin(ImGuiLogFlags flags, int auto_open_depth);
		public static unsafe extern void LocalizeRegisterEntries(const ImGuiLocEntry* entries, int count);
		public static unsafe extern const char* LocalizeGetMsg(ImGuiLocKey key);
		public static unsafe extern void KeepAliveID(ImGuiID id);
		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		public static unsafe extern void ItemSize(const ImRect bb, float text_baseline_y);
		public static unsafe extern void ItemSize(const ImVec2 size, float text_baseline_y);
		public static unsafe extern bool ItemHoverable(const ImRect bb, ImGuiID id, ImGuiItemFlags item_flags);
		public static unsafe extern bool ItemAdd(const ImRect bb, ImGuiID id, const ImRect* nav_bb, ImGuiItemFlags extra_flags);
		public static unsafe extern bool IsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
		public static unsafe extern bool IsWindowNavFocusable(ImGuiWindow* window);
		public static unsafe extern bool IsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags);
		public static unsafe extern bool IsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, bool popup_hierarchy, bool dock_hierarchy);
		public static unsafe extern bool IsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
		public static unsafe extern bool IsPopupOpen(ImGuiID id, ImGuiPopupFlags popup_flags);
		public static unsafe extern bool IsNamedKeyOrMod(ImGuiKey key);
		public static unsafe extern bool IsNamedKey(ImGuiKey key);
		public static unsafe extern bool IsMouseReleased(ImGuiMouseButton button, ImGuiID owner_id);
		public static unsafe extern bool IsMouseKey(ImGuiKey key);
		public static unsafe extern bool IsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
		public static unsafe extern bool IsMouseDown(ImGuiMouseButton button, ImGuiID owner_id);
		public static unsafe extern bool IsMouseDoubleClicked(ImGuiMouseButton button, ImGuiID owner_id);
		public static unsafe extern bool IsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, ImGuiID owner_id);
		public static unsafe extern bool IsLegacyKey(ImGuiKey key);
		public static unsafe extern bool IsLRModKey(ImGuiKey key);
		public static unsafe extern bool IsKeyboardKey(ImGuiKey key);
		public static unsafe extern bool IsKeyReleased(ImGuiKey key, ImGuiID owner_id);
		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		public static unsafe extern bool IsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, ImGuiID owner_id);
		public static unsafe extern bool IsKeyDown(ImGuiKey key, ImGuiID owner_id);
		public static unsafe extern bool IsKeyChordPressed(ImGuiKeyChord key_chord, ImGuiInputFlags flags, ImGuiID owner_id);
		public static unsafe extern bool IsGamepadKey(ImGuiKey key);
		public static unsafe extern bool IsDragDropPayloadBeingAccepted();
		public static unsafe extern bool IsDragDropActive();
		public static unsafe extern bool IsClippedEx(const ImRect bb, ImGuiID id);
		public static unsafe extern bool IsAliasKey(ImGuiKey key);
		public static unsafe extern bool IsActiveIdUsingNavDir(ImGuiDir dir);
		public static unsafe extern bool InputTextEx(const char* label, const char* hint, char* buf, int buf_size, const ImVec2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		public static unsafe extern void InputTextDeactivateHook(ImGuiID id);
		public static unsafe extern void Initialize();
		public static unsafe extern bool ImageButtonEx(ImGuiID id, ImTextureID user_texture_id, const ImVec2 image_size, const ImVec2 uv0, const ImVec2 uv1, const ImVec4 bg_col, const ImVec4 tint_col, ImGuiButtonFlags flags);
		public static unsafe extern int ImUpperPowerOfTwo(int v);
		public static unsafe extern void ImTrunc(ImVec2* pOut, const ImVec2 v);
		public static unsafe extern float ImTrunc(float f);
		public static unsafe extern bool ImTriangleIsClockwise(const ImVec2 a, const ImVec2 b, const ImVec2 c);
		public static unsafe extern bool ImTriangleContainsPoint(const ImVec2 a, const ImVec2 b, const ImVec2 c, const ImVec2 p);
		public static unsafe extern void ImTriangleClosestPoint(ImVec2* pOut, const ImVec2 a, const ImVec2 b, const ImVec2 c, const ImVec2 p);
		public static unsafe extern void ImTriangleBarycentricCoords(const ImVec2 a, const ImVec2 b, const ImVec2 c, const ImVec2 p, float* out_u, float* out_v, float* out_w);
		public static unsafe extern float ImTriangleArea(const ImVec2 a, const ImVec2 b, const ImVec2 c);
		public static unsafe extern char ImToUpper(char c);
		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		public static unsafe extern int ImTextStrToUtf8(char* out_buf, int out_buf_size, const ImWchar* in_text, const ImWchar* in_text_end);
		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static unsafe extern int ImTextStrFromUtf8(ImWchar* out_buf, int out_buf_size, const char* in_text, const char* in_text_end, const char** in_remaining);
		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		public static unsafe extern const char* ImTextFindPreviousUtf8Codepoint(const char* in_text_start, const char* in_text_curr);
		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		public static unsafe extern int ImTextCountUtf8BytesFromStr(const ImWchar* in_text, const ImWchar* in_text_end);
		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		public static unsafe extern int ImTextCountUtf8BytesFromChar(const char* in_text, const char* in_text_end);
		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		public static unsafe extern int ImTextCountLines(const char* in_text, const char* in_text_end);
		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		public static unsafe extern int ImTextCountCharsFromUtf8(const char* in_text, const char* in_text_end);
		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		public static unsafe extern const char* ImTextCharToUtf8(char[5] out_buf, unsigned int c);
		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		public static unsafe extern int ImTextCharFromUtf8(unsigned int* out_char, const char* in_text, const char* in_text_end);
		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		public static unsafe extern int ImStrnicmp(const char* str1, const char* str2, size_t count);
		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		public static unsafe extern void ImStrncpy(char* dst, const char* src, size_t count);
		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		public static unsafe extern int ImStrlenW(const ImWchar* str);
		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		public static unsafe extern const char* ImStristr(const char* haystack, const char* haystack_end, const char* needle, const char* needle_end);
		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		public static unsafe extern int ImStricmp(const char* str1, const char* str2);
		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		public static unsafe extern const char* ImStreolRange(const char* str, const char* str_end);
		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		public static unsafe extern char* ImStrdupcpy(char* dst, size_t* p_dst_size, const char* str);
		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		public static unsafe extern char* ImStrdup(const char* str);
		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		public static unsafe extern const char* ImStrchrRange(const char* str_begin, const char* str_end, char c);
		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		public static unsafe extern const char* ImStrbol(const char* buf_mid_line, const char* buf_begin);
		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		public static unsafe extern void ImStrTrimBlanks(char* str);
		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		public static unsafe extern const char* ImStrSkipBlank(const char* str);
		public static unsafe extern double ImSign(double x);
		/// <summary>
		/// Sign operator - returns -1, 0 or 1 based on sign of argument<br/>
		/// </summary>
		public static unsafe extern float ImSign(float x);
		public static unsafe extern float ImSaturate(float f);
		public static unsafe extern double ImRsqrt(double x);
		public static unsafe extern float ImRsqrt(float x);
		public static unsafe extern void ImRotate(ImVec2* pOut, const ImVec2 v, float cos_a, float sin_a);
		public static unsafe extern void ImQsort(void* base, size_t count, size_t size_of_element, int(*)(void const*,void const*) compare_func);
		public static unsafe extern double ImPow(double x, double y);
		/// <summary>
		/// DragBehaviorT/SliderBehaviorT uses ImPow with either float/double and need the precision<br/>
		/// </summary>
		public static unsafe extern float ImPow(float x, float y);
		public static unsafe extern const char* ImParseFormatTrimDecorations(const char* format, char* buf, size_t buf_size);
		public static unsafe extern const char* ImParseFormatSanitizeForScanning(const char* fmt_in, char* fmt_out, size_t fmt_out_size);
		public static unsafe extern void ImParseFormatSanitizeForPrinting(const char* fmt_in, char* fmt_out, size_t fmt_out_size);
		public static unsafe extern int ImParseFormatPrecision(const char* format, int default_value);
		public static unsafe extern const char* ImParseFormatFindStart(const char* format);
		public static unsafe extern const char* ImParseFormatFindEnd(const char* format);
		public static unsafe extern void ImMul(ImVec2* pOut, const ImVec2 lhs, const ImVec2 rhs);
		public static unsafe extern int ImModPositive(int a, int b);
		public static unsafe extern void ImMin(ImVec2* pOut, const ImVec2 lhs, const ImVec2 rhs);
		public static unsafe extern void ImMax(ImVec2* pOut, const ImVec2 lhs, const ImVec2 rhs);
		public static unsafe extern ImGuiStoragePair* ImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, ImGuiID key);
		public static unsafe extern double ImLog(double x);
		/// <summary>
		/// DragBehaviorT/SliderBehaviorT uses ImLog with either float/double and need the precision<br/>
		/// </summary>
		public static unsafe extern float ImLog(float x);
		public static unsafe extern float ImLinearSweep(float current, float target, float speed);
		public static unsafe extern float ImLinearRemapClamp(float s0, float s1, float d0, float d1, float x);
		public static unsafe extern void ImLineClosestPoint(ImVec2* pOut, const ImVec2 a, const ImVec2 b, const ImVec2 p);
		public static unsafe extern void ImLerp(ImVec4* pOut, const ImVec4 a, const ImVec4 b, float t);
		public static unsafe extern void ImLerp(ImVec2* pOut, const ImVec2 a, const ImVec2 b, const ImVec2 t);
		public static unsafe extern void ImLerp(ImVec2* pOut, const ImVec2 a, const ImVec2 b, float t);
		public static unsafe extern float ImLengthSqr(const ImVec4 lhs);
		public static unsafe extern float ImLengthSqr(const ImVec2 lhs);
		public static unsafe extern bool ImIsPowerOfTwo(ImU64 v);
		public static unsafe extern bool ImIsPowerOfTwo(int v);
		public static unsafe extern bool ImIsFloatAboveGuaranteedIntegerPrecision(float f);
		public static unsafe extern float ImInvLength(const ImVec2 lhs, float fail_value);
		public static unsafe extern ImGuiID ImHashStr(const char* data, size_t data_size, ImGuiID seed);
		public static unsafe extern ImGuiID ImHashData(const void* data, size_t data_size, ImGuiID seed);
		public static unsafe extern int ImFormatStringV(char* buf, size_t buf_size, const char* fmt, va_list args);
		public static unsafe extern void ImFormatStringToTempBufferV(const char** out_buf, const char** out_buf_end, const char* fmt, va_list args);
		public static unsafe extern void ImFormatStringToTempBuffer(const char** out_buf, const char** out_buf_end, const char* fmt, ... ...);
		public static unsafe extern int ImFormatString(char* buf, size_t buf_size, const char* fmt, ... ...);
		public static unsafe extern void ImFontAtlasUpdateConfigDataPointers(ImFontAtlas* atlas);
		public static unsafe extern const ImFontBuilderIO* ImFontAtlasGetBuilderForStbTruetype();
		public static unsafe extern void ImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
		public static unsafe extern void ImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, const char* in_str, char in_marker_char, unsigned char in_marker_pixel_value);
		public static unsafe extern void ImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, const char* in_str, char in_marker_char, unsigned int in_marker_pixel_value);
		public static unsafe extern void ImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
		public static unsafe extern void ImFontAtlasBuildMultiplyRectAlpha8(const unsigned char[256] table, unsigned char* pixels, int x, int y, int w, int h, int stride);
		public static unsafe extern void ImFontAtlasBuildMultiplyCalcLookupTable(unsigned char[256] out_table, float in_multiply_factor);
		public static unsafe extern void ImFontAtlasBuildInit(ImFontAtlas* atlas);
		public static unsafe extern void ImFontAtlasBuildGetOversampleFactors(const ImFontConfig* cfg, int* out_oversample_h, int* out_oversample_v);
		public static unsafe extern void ImFontAtlasBuildFinish(ImFontAtlas* atlas);
		public static unsafe extern void ImFloor(ImVec2* pOut, const ImVec2 v);
		/// <summary>
		/// Decent replacement for floorf()<br/>
		/// </summary>
		public static unsafe extern float ImFloor(float f);
		public static unsafe extern ImU64 ImFileWrite(const void* data, ImU64 size, ImU64 count, ImFileHandle file);
		public static unsafe extern ImU64 ImFileRead(void* data, ImU64 size, ImU64 count, ImFileHandle file);
		public static unsafe extern ImFileHandle ImFileOpen(const char* filename, const char* mode);
		public static unsafe extern void* ImFileLoadToMemory(const char* filename, const char* mode, size_t* out_file_size, int padding_bytes);
		public static unsafe extern ImU64 ImFileGetSize(ImFileHandle file);
		public static unsafe extern bool ImFileClose(ImFileHandle file);
		public static unsafe extern float ImExponentialMovingAverage(float avg, float sample, int n);
		public static unsafe extern float ImDot(const ImVec2 a, const ImVec2 b);
		public static unsafe extern void ImClamp(ImVec2* pOut, const ImVec2 v, const ImVec2 mn, const ImVec2 mx);
		public static unsafe extern bool ImCharIsXdigitA(char c);
		public static unsafe extern bool ImCharIsBlankW(unsigned int c);
		public static unsafe extern bool ImCharIsBlankA(char c);
		public static unsafe extern bool ImBitArrayTestBit(const ImU32* arr, int n);
		public static unsafe extern void ImBitArraySetBitRange(ImU32* arr, int n, int n2);
		public static unsafe extern void ImBitArraySetBit(ImU32* arr, int n);
		public static unsafe extern size_t ImBitArrayGetStorageSizeInBytes(int bitcount);
		public static unsafe extern void ImBitArrayClearBit(ImU32* arr, int n);
		public static unsafe extern void ImBitArrayClearAllBits(ImU32* arr, int bitcount);
		public static unsafe extern void ImBezierQuadraticCalc(ImVec2* pOut, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, float t);
		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		public static unsafe extern void ImBezierCubicClosestPointCasteljau(ImVec2* pOut, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, const ImVec2 p, float tess_tol);
		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		public static unsafe extern void ImBezierCubicClosestPoint(ImVec2* pOut, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, const ImVec2 p, int num_segments);
		public static unsafe extern void ImBezierCubicCalc(ImVec2* pOut, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, float t);
		public static unsafe extern ImU32 ImAlphaBlendColors(ImU32 col_a, ImU32 col_b);
		public static unsafe extern double ImAbs(double x);
		public static unsafe extern float ImAbs(float x);
		public static unsafe extern int ImAbs(int x);
		public static unsafe extern void GetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
		public static unsafe extern ImGuiID GetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		public static unsafe extern ImGuiID GetWindowResizeCornerID(ImGuiWindow* window, int n);
		public static unsafe extern ImGuiID GetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
		public static unsafe extern ImGuiDockNode* GetWindowDockNode();
		public static unsafe extern bool GetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
		public static unsafe extern const ImGuiPlatformMonitor* GetViewportPlatformMonitor(ImGuiViewport* viewport);
		public static unsafe extern ImGuiTypingSelectRequest* GetTypingSelectRequest(ImGuiTypingSelectFlags flags);
		public static unsafe extern void GetTypematicRepeatRate(ImGuiInputFlags flags, float* repeat_delay, float* repeat_rate);
		public static unsafe extern ImGuiWindow* GetTopMostPopupModal();
		public static unsafe extern ImGuiWindow* GetTopMostAndVisiblePopupModal();
		public static unsafe extern const ImGuiDataVarInfo* GetStyleVarInfo(ImGuiStyleVar idx);
		public static unsafe extern ImGuiKeyRoutingData* GetShortcutRoutingData(ImGuiKeyChord key_chord);
		public static unsafe extern void GetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
		public static unsafe extern ImGuiPlatformIO* GetPlatformIOEx(ImGuiContext* ctx);
		public static unsafe extern float GetNavTweakPressedAmount(ImGuiAxis axis);
		public static unsafe extern ImGuiMultiSelectState* GetMultiSelectState(ImGuiID id);
		public static unsafe extern ImGuiKeyOwnerData* GetKeyOwnerData(ImGuiContext* ctx, ImGuiKey key);
		public static unsafe extern ImGuiID GetKeyOwner(ImGuiKey key);
		public static unsafe extern void GetKeyMagnitude2d(ImVec2* pOut, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);
		public static unsafe extern ImGuiKeyData* GetKeyData(ImGuiKey key);
		public static unsafe extern ImGuiKeyData* GetKeyData(ImGuiContext* ctx, ImGuiKey key);
		public static unsafe extern const char* GetKeyChordName(ImGuiKeyChord key_chord);
		public static unsafe extern ImGuiItemStatusFlags GetItemStatusFlags();
		public static unsafe extern ImGuiItemFlags GetItemFlags();
		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		public static unsafe extern ImGuiInputTextState* GetInputTextState(ImGuiID id);
		public static unsafe extern ImGuiIO* GetIOEx(ImGuiContext* ctx);
		public static unsafe extern ImGuiID GetIDWithSeed(int n, ImGuiID seed);
		public static unsafe extern ImGuiID GetIDWithSeed(const char* str_id_begin, const char* str_id_end, ImGuiID seed);
		public static unsafe extern ImGuiID GetHoveredID();
		public static unsafe extern ImDrawList* GetForegroundDrawList(ImGuiWindow* window);
		public static unsafe extern ImGuiID GetFocusID();
		public static unsafe extern ImFont* GetDefaultFont();
		public static unsafe extern ImGuiWindow* GetCurrentWindowRead();
		public static unsafe extern ImGuiWindow* GetCurrentWindow();
		public static unsafe extern ImGuiTable* GetCurrentTable();
		public static unsafe extern ImGuiTabBar* GetCurrentTabBar();
		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		public static unsafe extern ImGuiID GetCurrentFocusScope();
		public static unsafe extern ImGuiID GetColumnsID(const char* str_id, int count);
		public static unsafe extern float GetColumnOffsetFromNorm(const ImGuiOldColumns* columns, float offset_norm);
		public static unsafe extern float GetColumnNormFromOffset(const ImGuiOldColumns* columns, float offset);
		public static unsafe extern ImGuiBoxSelectState* GetBoxSelectState(ImGuiID id);
		public static unsafe extern ImGuiID GetActiveID();
		public static unsafe extern void GcCompactTransientWindowBuffers(ImGuiWindow* window);
		public static unsafe extern void GcCompactTransientMiscBuffers();
		public static unsafe extern void GcAwakeTransientWindowBuffers(ImGuiWindow* window);
		public static unsafe extern void FocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags);
		public static unsafe extern void FocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, ImGuiFocusRequestFlags flags);
		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		public static unsafe extern void FocusItem();
		public static unsafe extern ImGuiKeyChord FixupKeyChord(ImGuiKeyChord key_chord);
		public static unsafe extern ImGuiWindowSettings* FindWindowSettingsByWindow(ImGuiWindow* window);
		public static unsafe extern ImGuiWindowSettings* FindWindowSettingsByID(ImGuiID id);
		public static unsafe extern int FindWindowDisplayIndex(ImGuiWindow* window);
		public static unsafe extern ImGuiWindow* FindWindowByName(const char* name);
		public static unsafe extern ImGuiWindow* FindWindowByID(ImGuiID id);
		public static unsafe extern ImGuiSettingsHandler* FindSettingsHandler(const char* type_name);
		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static unsafe extern const char* FindRenderedTextEnd(const char* text, const char* text_end);
		public static unsafe extern ImGuiOldColumns* FindOrCreateColumns(ImGuiWindow* window, ImGuiID id);
		public static unsafe extern void FindHoveredWindowEx(const ImVec2 pos, bool find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window);
		public static unsafe extern ImGuiViewportP* FindHoveredViewportFromPlatformWindowStack(const ImVec2 mouse_platform_pos);
		public static unsafe extern ImGuiWindow* FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
		public static unsafe extern ImGuiWindow* FindBlockingModal(ImGuiWindow* window);
		public static unsafe extern void FindBestWindowPosForPopupEx(ImVec2* pOut, const ImVec2 ref_pos, const ImVec2 size, ImGuiDir* last_dir, const ImRect r_outer, const ImRect r_avoid, ImGuiPopupPositionPolicy policy);
		public static unsafe extern void FindBestWindowPosForPopup(ImVec2* pOut, ImGuiWindow* window);
		public static unsafe extern void ErrorRecoveryTryToRecoverWindowState(const ImGuiErrorRecoveryState* state_in);
		public static unsafe extern void ErrorRecoveryTryToRecoverState(const ImGuiErrorRecoveryState* state_in);
		public static unsafe extern void ErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out);
		public static unsafe extern bool ErrorLog(const char* msg);
		public static unsafe extern void ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		public static unsafe extern void ErrorCheckEndFrameFinalizeErrorTooltip();
		public static unsafe extern void EndErrorTooltip();
		public static unsafe extern void EndDisabledOverrideReenable();
		public static unsafe extern void EndComboPreview();
		/// <summary>
		/// close columns<br/>
		/// </summary>
		public static unsafe extern void EndColumns();
		public static unsafe extern void EndBoxSelect(const ImRect scope_rect, ImGuiMultiSelectFlags ms_flags);
		public static unsafe extern bool DragBehavior(ImGuiID id, ImGuiDataType data_type, void* p_v, float v_speed, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern void DockNodeWindowMenuHandler_Default(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);
		public static unsafe extern bool DockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
		public static unsafe extern ImGuiID DockNodeGetWindowMenuButtonId(const ImGuiDockNode* node);
		public static unsafe extern ImGuiDockNode* DockNodeGetRootNode(ImGuiDockNode* node);
		public static unsafe extern int DockNodeGetDepth(const ImGuiDockNode* node);
		public static unsafe extern void DockNodeEndAmendTabBar();
		public static unsafe extern bool DockNodeBeginAmendTabBar(ImGuiDockNode* node);
		public static unsafe extern void DockContextShutdown(ImGuiContext* ctx);
		public static unsafe extern void DockContextRebuildNodes(ImGuiContext* ctx);
		public static unsafe extern void DockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window);
		public static unsafe extern void DockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
		public static unsafe extern void DockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, bool split_outer);
		public static unsafe extern void DockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window, bool clear_persistent_docking_ref);
		public static unsafe extern void DockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
		public static unsafe extern void DockContextNewFrameUpdateUndocking(ImGuiContext* ctx);
		public static unsafe extern void DockContextNewFrameUpdateDocking(ImGuiContext* ctx);
		public static unsafe extern void DockContextInitialize(ImGuiContext* ctx);
		public static unsafe extern ImGuiID DockContextGenNodeID(ImGuiContext* ctx);
		public static unsafe extern ImGuiDockNode* DockContextFindNodeByID(ImGuiContext* ctx, ImGuiID id);
		public static unsafe extern void DockContextEndFrame(ImGuiContext* ctx);
		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		public static unsafe extern void DockContextClearNodes(ImGuiContext* ctx, ImGuiID root_id, bool clear_settings_refs);
		public static unsafe extern bool DockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, bool split_outer, ImVec2* out_pos);
		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		public static unsafe extern ImGuiID DockBuilderSplitNode(ImGuiID node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, ImGuiID* out_id_at_dir, ImGuiID* out_id_at_opposite_dir);
		public static unsafe extern void DockBuilderSetNodeSize(ImGuiID node_id, ImVec2 size);
		public static unsafe extern void DockBuilderSetNodePos(ImGuiID node_id, ImVec2 pos);
		public static unsafe extern void DockBuilderRemoveNodeDockedWindows(ImGuiID node_id, bool clear_settings_refs);
		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		public static unsafe extern void DockBuilderRemoveNodeChildNodes(ImGuiID node_id);
		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		public static unsafe extern void DockBuilderRemoveNode(ImGuiID node_id);
		public static unsafe extern ImGuiDockNode* DockBuilderGetNode(ImGuiID node_id);
		public static unsafe extern ImGuiDockNode* DockBuilderGetCentralNode(ImGuiID node_id);
		public static unsafe extern void DockBuilderFinish(ImGuiID node_id);
		public static unsafe extern void DockBuilderDockWindow(const char* window_name, ImGuiID node_id);
		public static unsafe extern void DockBuilderCopyWindowSettings(const char* src_name, const char* dst_name);
		public static unsafe extern void DockBuilderCopyNode(ImGuiID src_node_id, ImGuiID dst_node_id, ImVector_ImGuiID* out_node_remap_pairs);
		public static unsafe extern void DockBuilderCopyDockSpace(ImGuiID src_dockspace_id, ImGuiID dst_dockspace_id, ImVector_const_charPtr* in_window_remap_pairs);
		public static unsafe extern ImGuiID DockBuilderAddNode(ImGuiID node_id, ImGuiDockNodeFlags flags);
		public static unsafe extern void DestroyPlatformWindow(ImGuiViewportP* viewport);
		public static unsafe extern void DebugTextUnformattedWithLocateItem(const char* line_begin, const char* line_end);
		public static unsafe extern void DebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, const ImRect bb);
		public static unsafe extern void DebugRenderKeyboardPreview(ImDrawList* draw_list);
		public static unsafe extern void DebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);
		public static unsafe extern void DebugNodeWindowsList(ImVector_ImGuiWindowPtr* windows, const char* label);
		public static unsafe extern void DebugNodeWindowSettings(ImGuiWindowSettings* settings);
		public static unsafe extern void DebugNodeWindow(ImGuiWindow* window, const char* label);
		public static unsafe extern void DebugNodeViewport(ImGuiViewportP* viewport);
		public static unsafe extern void DebugNodeTypingSelectState(ImGuiTypingSelectState* state);
		public static unsafe extern void DebugNodeTableSettings(ImGuiTableSettings* settings);
		public static unsafe extern void DebugNodeTable(ImGuiTable* table);
		public static unsafe extern void DebugNodeTabBar(ImGuiTabBar* tab_bar, const char* label);
		public static unsafe extern void DebugNodeStorage(ImGuiStorage* storage, const char* label);
		public static unsafe extern void DebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, const char* label, int idx);
		public static unsafe extern void DebugNodeMultiSelectState(ImGuiMultiSelectState* state);
		public static unsafe extern void DebugNodeInputTextState(ImGuiInputTextState* state);
		public static unsafe extern void DebugNodeFontGlyph(ImFont* font, const ImFontGlyph* glyph);
		public static unsafe extern void DebugNodeFont(ImFont* font);
		public static unsafe extern void DebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, const ImDrawList* draw_list, const char* label);
		public static unsafe extern void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, const ImDrawList* draw_list, const ImDrawCmd* draw_cmd, bool show_mesh, bool show_aabb);
		public static unsafe extern void DebugNodeDockNode(ImGuiDockNode* node, const char* label);
		public static unsafe extern void DebugNodeColumns(ImGuiOldColumns* columns);
		public static unsafe extern void DebugLocateItemResolveWithLastItem();
		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		public static unsafe extern void DebugLocateItemOnHover(ImGuiID target_id);
		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		public static unsafe extern void DebugLocateItem(ImGuiID target_id);
		public static unsafe extern void DebugHookIdInfo(ImGuiID id, ImGuiDataType data_type, const void* data_id, const void* data_id_end);
		public static unsafe extern void DebugDrawLineExtents(ImU32 col);
		public static unsafe extern void DebugDrawItemRect(ImU32 col);
		public static unsafe extern void DebugDrawCursorPos(ImU32 col);
		public static unsafe extern void DebugBreakClearData();
		public static unsafe extern void DebugBreakButtonTooltip(bool keyboard_only, const char* description_of_location);
		public static unsafe extern bool DebugBreakButton(const char* label, const char* description_of_location);
		/// <summary>
		/// size >= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		public static unsafe extern void DebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, size_t size);
		public static unsafe extern bool DataTypeIsZero(ImGuiDataType data_type, const void* p_data);
		public static unsafe extern const ImGuiDataTypeInfo* DataTypeGetInfo(ImGuiDataType data_type);
		public static unsafe extern int DataTypeFormatString(char* buf, int buf_size, ImGuiDataType data_type, const void* p_data, const char* format);
		public static unsafe extern int DataTypeCompare(ImGuiDataType data_type, const void* arg_1, const void* arg_2);
		public static unsafe extern bool DataTypeClamp(ImGuiDataType data_type, void* p_data, const void* p_min, const void* p_max);
		public static unsafe extern void DataTypeApplyOp(ImGuiDataType data_type, int op, void* output, const void* arg_1, const void* arg_2);
		public static unsafe extern bool DataTypeApplyFromText(const char* buf, ImGuiDataType data_type, void* p_data, const char* format, void* p_data_when_empty);
		public static unsafe extern ImGuiWindowSettings* CreateNewWindowSettings(const char* name);
		public static unsafe extern ImGuiKey ConvertSingleModFlagToKey(ImGuiKey key);
		public static unsafe extern void ColorTooltip(const char* text, const float* col, ImGuiColorEditFlags flags);
		public static unsafe extern void ColorPickerOptionsPopup(const float* ref_col, ImGuiColorEditFlags flags);
		public static unsafe extern void ColorEditOptionsPopup(const float* col, ImGuiColorEditFlags flags);
		public static unsafe extern bool CollapseButton(ImGuiID id, const ImVec2 pos, ImGuiDockNode* dock_node);
		public static unsafe extern void ClosePopupsOverWindow(ImGuiWindow* ref_window, bool restore_focus_to_window_under_popup);
		public static unsafe extern void ClosePopupsExceptModals();
		public static unsafe extern void ClosePopupToLevel(int remaining, bool restore_focus_to_window_under_popup);
		public static unsafe extern bool CloseButton(ImGuiID id, const ImVec2 pos);
		public static unsafe extern void ClearWindowSettings(const char* name);
		public static unsafe extern void ClearIniSettings();
		public static unsafe extern void ClearDragDrop();
		public static unsafe extern void ClearActiveID();
		public static unsafe extern bool CheckboxFlags(const char* label, ImU64* flags, ImU64 flags_value);
		public static unsafe extern bool CheckboxFlags(const char* label, ImS64* flags, ImS64 flags_value);
		public static unsafe extern void CallContextHooks(ImGuiContext* context, ImGuiContextHookType type);
		public static unsafe extern float CalcWrapWidthForPos(const ImVec2 pos, float wrap_pos_x);
		public static unsafe extern void CalcWindowNextAutoFitSize(ImVec2* pOut, ImGuiWindow* window);
		public static unsafe extern int CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
		public static unsafe extern ImDrawFlags CalcRoundingFlagsForRectInRect(const ImRect r_in, const ImRect r_outer, float threshold);
		public static unsafe extern void CalcItemSize(ImVec2* pOut, ImVec2 size, float default_w, float default_h);
		public static unsafe extern bool ButtonEx(const char* label, const ImVec2 size_arg, ImGuiButtonFlags flags);
		public static unsafe extern bool ButtonBehavior(const ImRect bb, ImGuiID id, bool* out_hovered, bool* out_held, ImGuiButtonFlags flags);
		public static unsafe extern void BringWindowToFocusFront(ImGuiWindow* window);
		public static unsafe extern void BringWindowToDisplayFront(ImGuiWindow* window);
		public static unsafe extern void BringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);
		public static unsafe extern void BringWindowToDisplayBack(ImGuiWindow* window);
		public static unsafe extern bool BeginViewportSideBar(const char* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);
		public static unsafe extern bool BeginTooltipHidden();
		public static unsafe extern bool BeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);
		public static unsafe extern bool BeginTableEx(const char* name, ImGuiID id, int columns_count, ImGuiTableFlags flags, const ImVec2 outer_size, float inner_width);
		public static unsafe extern bool BeginTabBarEx(ImGuiTabBar* tab_bar, const ImRect bb, ImGuiTabBarFlags flags);
		public static unsafe extern bool BeginPopupEx(ImGuiID id, ImGuiWindowFlags extra_window_flags);
		public static unsafe extern bool BeginMenuEx(const char* label, const char* icon, bool enabled);
		public static unsafe extern bool BeginErrorTooltip();
		public static unsafe extern bool BeginDragDropTargetCustom(const ImRect bb, ImGuiID id);
		public static unsafe extern void BeginDocked(ImGuiWindow* window, bool* p_open);
		public static unsafe extern void BeginDockableDragDropTarget(ImGuiWindow* window);
		public static unsafe extern void BeginDockableDragDropSource(ImGuiWindow* window);
		public static unsafe extern void BeginDisabledOverrideReenable();
		public static unsafe extern bool BeginComboPreview();
		public static unsafe extern bool BeginComboPopup(ImGuiID popup_id, const ImRect bb, ImGuiComboFlags flags);
		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static unsafe extern void BeginColumns(const char* str_id, int count, ImGuiOldColumnFlags flags);
		public static unsafe extern bool BeginChildEx(const char* name, ImGuiID id, const ImVec2 size_arg, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		public static unsafe extern bool BeginBoxSelect(const ImRect scope_rect, ImGuiWindow* window, ImGuiID box_select_id, ImGuiMultiSelectFlags ms_flags);
		public static unsafe extern bool ArrowButtonEx(const char* str_id, ImGuiDir dir, ImVec2 size_arg, ImGuiButtonFlags flags);
		public static unsafe extern void AddSettingsHandler(const ImGuiSettingsHandler* handler);
		public static unsafe extern void AddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector_ImDrawListPtr* out_list, ImDrawList* draw_list);
		public static unsafe extern ImGuiID AddContextHook(ImGuiContext* context, const ImGuiContextHook* hook);
		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		public static unsafe extern void ActivateItemByID(ImGuiID id);
		public static unsafe extern void Unknown(ImVec2ih* self);
		public static unsafe extern void ImVec2ih(const ImVec2 rhs);
		public static unsafe extern void ImVec2ih(short _x, short _y);
		public static unsafe extern void ImVec2ih();
		public static unsafe extern void Unknown(ImVec1* self);
		public static unsafe extern void ImVec1(float _x);
		public static unsafe extern void ImVec1();
		public static unsafe extern int size_in_bytes(ImSpan* self);
		public static unsafe extern int size(ImSpan* self);
		public static unsafe extern void set(ImSpan* self, T* data, T* data_end);
		public static unsafe extern void set(ImSpan* self, T* data, int size);
		public static unsafe extern int index_from_ptr(ImSpan* self, const T* it);
		public static unsafe extern const T* end(ImSpan* self);
		public static unsafe extern T* end(ImSpan* self);
		public static unsafe extern void Unknown(ImSpan* self);
		public static unsafe extern const T* begin(ImSpan* self);
		public static unsafe extern T* begin(ImSpan* self);
		public static unsafe extern void ImSpan(T* data, T* data_end);
		public static unsafe extern void ImSpan(T* data, int size);
		public static unsafe extern void ImSpan();
		public static unsafe extern void Unknown(ImSpanAllocator* self);
		public static unsafe extern void SetArenaBasePtr(ImSpanAllocator* self, void* base_ptr);
		public static unsafe extern void Reserve(ImSpanAllocator* self, int n, size_t sz, int a);
		public static unsafe extern void ImSpanAllocator();
		public static unsafe extern void* GetSpanPtrEnd(ImSpanAllocator* self, int n);
		public static unsafe extern void* GetSpanPtrBegin(ImSpanAllocator* self, int n);
		public static unsafe extern int GetArenaSizeInBytes(ImSpanAllocator* self);
		public static unsafe extern void Unknown(ImRect* self);
		public static unsafe extern void TranslateY(ImRect* self, float dy);
		public static unsafe extern void TranslateX(ImRect* self, float dx);
		public static unsafe extern void Translate(ImRect* self, const ImVec2 d);
		public static unsafe extern void ToVec4(ImVec4* pOut, ImRect* self);
		public static unsafe extern bool Overlaps(ImRect* self, const ImRect r);
		public static unsafe extern bool IsInverted(ImRect* self);
		public static unsafe extern void ImRect(float x1, float y1, float x2, float y2);
		public static unsafe extern void ImRect(const ImVec4 v);
		public static unsafe extern void ImRect(const ImVec2 min, const ImVec2 max);
		public static unsafe extern void ImRect();
		public static unsafe extern float GetWidth(ImRect* self);
		/// <summary>
		/// Top-right<br/>
		/// </summary>
		public static unsafe extern void GetTR(ImVec2* pOut, ImRect* self);
		/// <summary>
		/// Top-left<br/>
		/// </summary>
		public static unsafe extern void GetTL(ImVec2* pOut, ImRect* self);
		public static unsafe extern void GetSize(ImVec2* pOut, ImRect* self);
		public static unsafe extern float GetHeight(ImRect* self);
		public static unsafe extern void GetCenter(ImVec2* pOut, ImRect* self);
		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		public static unsafe extern void GetBR(ImVec2* pOut, ImRect* self);
		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		public static unsafe extern void GetBL(ImVec2* pOut, ImRect* self);
		public static unsafe extern float GetArea(ImRect* self);
		public static unsafe extern void Floor(ImRect* self);
		public static unsafe extern void Expand(ImRect* self, const ImVec2 amount);
		public static unsafe extern void Expand(ImRect* self, const float amount);
		public static unsafe extern bool ContainsWithPad(ImRect* self, const ImVec2 p, const ImVec2 pad);
		public static unsafe extern bool Contains(ImRect* self, const ImRect r);
		public static unsafe extern bool Contains(ImRect* self, const ImVec2 p);
		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		public static unsafe extern void ClipWithFull(ImRect* self, const ImRect r);
		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		public static unsafe extern void ClipWith(ImRect* self, const ImRect r);
		public static unsafe extern void Add(ImRect* self, const ImRect r);
		public static unsafe extern void Add(ImRect* self, const ImVec2 p);
		public static unsafe extern void Unknown(ImPool* self);
		public static unsafe extern T* TryGetMapData(ImPool* self, ImPoolIdx n);
		public static unsafe extern void Reserve(ImPool* self, int capacity);
		public static unsafe extern void Remove(ImPool* self, ImGuiID key, ImPoolIdx idx);
		public static unsafe extern void Remove(ImPool* self, ImGuiID key, const T* p);
		public static unsafe extern void ImPool();
		public static unsafe extern T* GetOrAddByKey(ImPool* self, ImGuiID key);
		/// <summary>
		/// It is the map we need iterate to find valid items, since we don't have "alive" storage anywhere<br/>
		/// </summary>
		public static unsafe extern int GetMapSize(ImPool* self);
		public static unsafe extern ImPoolIdx GetIndex(ImPool* self, const T* p);
		public static unsafe extern T* GetByKey(ImPool* self, ImGuiID key);
		public static unsafe extern T* GetByIndex(ImPool* self, ImPoolIdx n);
		public static unsafe extern int GetBufSize(ImPool* self);
		/// <summary>
		/// Number of active/alive items in the pool (for display purpose)<br/>
		/// </summary>
		public static unsafe extern int GetAliveCount(ImPool* self);
		public static unsafe extern bool Contains(ImPool* self, const T* p);
		public static unsafe extern void Clear(ImPool* self);
		public static unsafe extern T* Add(ImPool* self);
		public static unsafe extern void Unknown(ImGuiWindow* self);
		public static unsafe extern void TitleBarRect(ImRect* pOut, ImGuiWindow* self);
		public static unsafe extern void Rect(ImRect* pOut, ImGuiWindow* self);
		public static unsafe extern void MenuBarRect(ImRect* pOut, ImGuiWindow* self);
		public static unsafe extern void ImGuiWindow(ImGuiContext* context, const char* name);
		public static unsafe extern ImGuiID GetIDFromRectangle(ImGuiWindow* self, const ImRect r_abs);
		public static unsafe extern ImGuiID GetIDFromPos(ImGuiWindow* self, const ImVec2 p_abs);
		public static unsafe extern ImGuiID GetID(ImGuiWindow* self, int n);
		public static unsafe extern ImGuiID GetID(ImGuiWindow* self, const void* ptr);
		public static unsafe extern ImGuiID GetID(ImGuiWindow* self, const char* str, const char* str_end);
		public static unsafe extern float CalcFontSize(ImGuiWindow* self);
		public static unsafe extern void Unknown(ImGuiWindowSettings* self);
		public static unsafe extern void ImGuiWindowSettings();
		public static unsafe extern char* GetName(ImGuiWindowSettings* self);
		public static unsafe extern void Unknown(ImGuiViewportP* self);
		/// <summary>
		/// Update public fields<br/>
		/// </summary>
		public static unsafe extern void UpdateWorkRect(ImGuiViewportP* self);
		public static unsafe extern void ImGuiViewportP();
		public static unsafe extern void GetWorkRect(ImRect* pOut, ImGuiViewportP* self);
		public static unsafe extern void GetMainRect(ImRect* pOut, ImGuiViewportP* self);
		public static unsafe extern void GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);
		public static unsafe extern void ClearRequestFlags(ImGuiViewportP* self);
		public static unsafe extern void CalcWorkRectSize(ImVec2* pOut, ImGuiViewportP* self, const ImVec2 inset_min, const ImVec2 inset_max);
		public static unsafe extern void CalcWorkRectPos(ImVec2* pOut, ImGuiViewportP* self, const ImVec2 inset_min);
		public static unsafe extern void Unknown(ImGuiTypingSelectState* self);
		public static unsafe extern void ImGuiTypingSelectState();
		/// <summary>
		/// We preserve remaining data for easier debugging<br/>
		/// </summary>
		public static unsafe extern void Clear(ImGuiTypingSelectState* self);
		public static unsafe extern int size(ImGuiTextIndex* self);
		public static unsafe extern const char* get_line_end(ImGuiTextIndex* self, const char* base, int n);
		public static unsafe extern const char* get_line_begin(ImGuiTextIndex* self, const char* base, int n);
		public static unsafe extern void clear(ImGuiTextIndex* self);
		public static unsafe extern void append(ImGuiTextIndex* self, const char* base, int old_size, int new_size);
		public static unsafe extern void Unknown(ImGuiTable* self);
		public static unsafe extern void ImGuiTable();
		public static unsafe extern void Unknown(ImGuiTableTempData* self);
		public static unsafe extern void ImGuiTableTempData();
		public static unsafe extern void Unknown(ImGuiTableSettings* self);
		public static unsafe extern void ImGuiTableSettings();
		public static unsafe extern ImGuiTableColumnSettings* GetColumnSettings(ImGuiTableSettings* self);
		public static unsafe extern void Unknown(ImGuiTableInstanceData* self);
		public static unsafe extern void ImGuiTableInstanceData();
		public static unsafe extern void Unknown(ImGuiTableColumn* self);
		public static unsafe extern void ImGuiTableColumn();
		public static unsafe extern void Unknown(ImGuiTableColumnSettings* self);
		public static unsafe extern void ImGuiTableColumnSettings();
		public static unsafe extern void Unknown(ImGuiTabItem* self);
		public static unsafe extern void ImGuiTabItem();
		public static unsafe extern void Unknown(ImGuiTabBar* self);
		public static unsafe extern void ImGuiTabBar();
		public static unsafe extern void Unknown(ImGuiStyleMod* self);
		public static unsafe extern void ImGuiStyleMod(ImGuiStyleVar idx, ImVec2 v);
		public static unsafe extern void ImGuiStyleMod(ImGuiStyleVar idx, float v);
		public static unsafe extern void ImGuiStyleMod(ImGuiStyleVar idx, int v);
		public static unsafe extern void Unknown(ImGuiStackLevelInfo* self);
		public static unsafe extern void ImGuiStackLevelInfo();
		public static unsafe extern void Unknown(ImGuiSettingsHandler* self);
		public static unsafe extern void ImGuiSettingsHandler();
		public static unsafe extern void Unknown(ImGuiPtrOrIndex* self);
		public static unsafe extern void ImGuiPtrOrIndex(int index);
		public static unsafe extern void ImGuiPtrOrIndex(void* ptr);
		public static unsafe extern void Unknown(ImGuiPopupData* self);
		public static unsafe extern void ImGuiPopupData();
		public static unsafe extern void Unknown(ImGuiOldColumns* self);
		public static unsafe extern void ImGuiOldColumns();
		public static unsafe extern void Unknown(ImGuiOldColumnData* self);
		public static unsafe extern void ImGuiOldColumnData();
		public static unsafe extern void Unknown(ImGuiNextWindowData* self);
		public static unsafe extern void ImGuiNextWindowData();
		public static unsafe extern void ClearFlags(ImGuiNextWindowData* self);
		public static unsafe extern void Unknown(ImGuiNextItemData* self);
		public static unsafe extern void ImGuiNextItemData();
		/// <summary>
		/// Also cleared manually by ItemAdd()!<br/>
		/// </summary>
		public static unsafe extern void ClearFlags(ImGuiNextItemData* self);
		public static unsafe extern void Unknown(ImGuiNavItemData* self);
		public static unsafe extern void ImGuiNavItemData();
		public static unsafe extern void Clear(ImGuiNavItemData* self);
		public static unsafe extern void Unknown(ImGuiMultiSelectTempData* self);
		public static unsafe extern void ImGuiMultiSelectTempData();
		public static unsafe extern void ClearIO(ImGuiMultiSelectTempData* self);
		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.<br/>
		/// </summary>
		public static unsafe extern void Clear(ImGuiMultiSelectTempData* self);
		public static unsafe extern void Unknown(ImGuiMultiSelectState* self);
		public static unsafe extern void ImGuiMultiSelectState();
		public static unsafe extern void Unknown(ImGuiMenuColumns* self);
		public static unsafe extern void Update(ImGuiMenuColumns* self, float spacing, bool window_reappearing);
		public static unsafe extern void ImGuiMenuColumns();
		public static unsafe extern float DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);
		public static unsafe extern void CalcNextTotalWidth(ImGuiMenuColumns* self, bool update_offsets);
		public static unsafe extern ImGuiListClipperRange FromPositions(float y1, float y2, int off_min, int off_max);
		public static unsafe extern ImGuiListClipperRange FromIndices(int min, int max);
		public static unsafe extern void Unknown(ImGuiListClipperData* self);
		public static unsafe extern void Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);
		public static unsafe extern void ImGuiListClipperData();
		public static unsafe extern void Unknown(ImGuiLastItemData* self);
		public static unsafe extern void ImGuiLastItemData();
		public static unsafe extern void Unknown(ImGuiKeyRoutingTable* self);
		public static unsafe extern void ImGuiKeyRoutingTable();
		public static unsafe extern void Clear(ImGuiKeyRoutingTable* self);
		public static unsafe extern void Unknown(ImGuiKeyRoutingData* self);
		public static unsafe extern void ImGuiKeyRoutingData();
		public static unsafe extern void Unknown(ImGuiKeyOwnerData* self);
		public static unsafe extern void ImGuiKeyOwnerData();
		public static unsafe extern void Unknown(ImGuiInputTextState* self);
		public static unsafe extern void SelectAll(ImGuiInputTextState* self);
		public static unsafe extern void ReloadUserBufAndSelectAll(ImGuiInputTextState* self);
		public static unsafe extern void ReloadUserBufAndMoveToEnd(ImGuiInputTextState* self);
		public static unsafe extern void ReloadUserBufAndKeepSelection(ImGuiInputTextState* self);
		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation<br/>
		/// </summary>
		public static unsafe extern void OnKeyPressed(ImGuiInputTextState* self, int key);
		public static unsafe extern void OnCharPressed(ImGuiInputTextState* self, unsigned int c);
		public static unsafe extern void ImGuiInputTextState();
		public static unsafe extern bool HasSelection(ImGuiInputTextState* self);
		public static unsafe extern int GetSelectionStart(ImGuiInputTextState* self);
		public static unsafe extern int GetSelectionEnd(ImGuiInputTextState* self);
		public static unsafe extern int GetCursorPos(ImGuiInputTextState* self);
		public static unsafe extern void CursorClamp(ImGuiInputTextState* self);
		public static unsafe extern void CursorAnimReset(ImGuiInputTextState* self);
		public static unsafe extern void ClearText(ImGuiInputTextState* self);
		public static unsafe extern void ClearSelection(ImGuiInputTextState* self);
		public static unsafe extern void ClearFreeMemory(ImGuiInputTextState* self);
		public static unsafe extern void Unknown(ImGuiInputTextDeactivatedState* self);
		public static unsafe extern void ImGuiInputTextDeactivatedState();
		public static unsafe extern void ClearFreeMemory(ImGuiInputTextDeactivatedState* self);
		public static unsafe extern void Unknown(ImGuiInputEvent* self);
		public static unsafe extern void ImGuiInputEvent();
		public static unsafe extern void Unknown(ImGuiIDStackTool* self);
		public static unsafe extern void ImGuiIDStackTool();
		public static unsafe extern void Unknown(ImGuiErrorRecoveryState* self);
		public static unsafe extern void ImGuiErrorRecoveryState();
		public static unsafe extern void Unknown(ImGuiDockNode* self);
		public static unsafe extern void UpdateMergedFlags(ImGuiDockNode* self);
		public static unsafe extern void SetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags);
		public static unsafe extern void Rect(ImRect* pOut, ImGuiDockNode* self);
		public static unsafe extern bool IsSplitNode(ImGuiDockNode* self);
		public static unsafe extern bool IsRootNode(ImGuiDockNode* self);
		/// <summary>
		/// Never show a tab bar<br/>
		/// </summary>
		public static unsafe extern bool IsNoTabBar(ImGuiDockNode* self);
		public static unsafe extern bool IsLeafNode(ImGuiDockNode* self);
		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle<br/>
		/// </summary>
		public static unsafe extern bool IsHiddenTabBar(ImGuiDockNode* self);
		public static unsafe extern bool IsFloatingNode(ImGuiDockNode* self);
		public static unsafe extern bool IsEmpty(ImGuiDockNode* self);
		public static unsafe extern bool IsDockSpace(ImGuiDockNode* self);
		public static unsafe extern bool IsCentralNode(ImGuiDockNode* self);
		public static unsafe extern void ImGuiDockNode(ImGuiID id);
		public static unsafe extern void Unknown(ImGuiDockContext* self);
		public static unsafe extern void ImGuiDockContext();
		public static unsafe extern void Unknown(ImGuiDebugAllocInfo* self);
		public static unsafe extern void ImGuiDebugAllocInfo();
		public static unsafe extern void* GetVarPtr(ImGuiDataVarInfo* self, void* parent);
		public static unsafe extern void Unknown(ImGuiContext* self);
		public static unsafe extern void ImGuiContext(ImFontAtlas* shared_font_atlas);
		public static unsafe extern void Unknown(ImGuiContextHook* self);
		public static unsafe extern void ImGuiContextHook();
		public static unsafe extern void Unknown(ImGuiComboPreviewData* self);
		public static unsafe extern void ImGuiComboPreviewData();
		public static unsafe extern void Unknown(ImGuiBoxSelectState* self);
		public static unsafe extern void ImGuiBoxSelectState();
		public static unsafe extern void Unknown(ImDrawListSharedData* self);
		public static unsafe extern void SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error);
		public static unsafe extern void ImDrawListSharedData();
		public static unsafe extern void Unknown(ImDrawDataBuilder* self);
		public static unsafe extern void ImDrawDataBuilder();
		public static unsafe extern void swap(ImChunkStream* self, ImChunkStream_T * rhs);
		public static unsafe extern int size(ImChunkStream* self);
		public static unsafe extern T* ptr_from_offset(ImChunkStream* self, int off);
		public static unsafe extern int offset_from_ptr(ImChunkStream* self, const T* p);
		public static unsafe extern T* next_chunk(ImChunkStream* self, T* p);
		public static unsafe extern T* end(ImChunkStream* self);
		public static unsafe extern bool empty(ImChunkStream* self);
		public static unsafe extern void clear(ImChunkStream* self);
		public static unsafe extern int chunk_size(ImChunkStream* self, const T* p);
		public static unsafe extern T* begin(ImChunkStream* self);
		public static unsafe extern T* alloc_chunk(ImChunkStream* self, size_t sz);
		public static unsafe extern bool TestBit(ImBitVector* self, int n);
		public static unsafe extern void SetBit(ImBitVector* self, int n);
		public static unsafe extern void Create(ImBitVector* self, int sz);
		public static unsafe extern void ClearBit(ImBitVector* self, int n);
		public static unsafe extern void Clear(ImBitVector* self);
		public static unsafe extern void Unknown(ImBitArray* self);
		public static unsafe extern bool TestBit(ImBitArray* self, int n);
		/// <summary>
		/// Works on range [n..n2)<br/>
		/// </summary>
		public static unsafe extern void SetBitRange(ImBitArray* self, int n, int n2);
		public static unsafe extern void SetBit(ImBitArray* self, int n);
		public static unsafe extern void SetAllBits(ImBitArray* self);
		public static unsafe extern void ImBitArray();
		public static unsafe extern void ClearBit(ImBitArray* self, int n);
	}
}

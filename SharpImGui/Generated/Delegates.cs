using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	public unsafe delegate int ImGuiInputTextCallbackDelegate(ImGuiInputTextCallbackData* data);

	public unsafe delegate void ImGuiSizeCallbackDelegate(ImGuiSizeCallbackData* data);

	public unsafe delegate void* ImGuiMemAllocFuncDelegate(uint sz, void* user_data);

	public unsafe delegate void ImGuiMemFreeFuncDelegate(void* ptr, void* user_data);

	public unsafe delegate void ImDrawCallbackDelegate(ImDrawList* parent_list, ImDrawCmd* cmd);

	public unsafe delegate void ImGuiErrorCallbackDelegate(ImGuiContext* ctx, void* user_data, byte* msg);

	public unsafe delegate void ImGuiContextHookCallbackDelegate(ImGuiContext* ctx, ImGuiContextHook* hook);

	public unsafe delegate byte FontBuilder_BuildDelegate(ImFontAtlas* atlas);

	public unsafe delegate void DockNodeWindowMenuHandlerDelegate(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);

	public unsafe delegate byte* Platform_GetClipboardTextFnDelegate(ImGuiContext* ctx);

	public unsafe delegate void Platform_SetClipboardTextFnDelegate(ImGuiContext* ctx, byte* text);

	public unsafe delegate byte Platform_OpenInShellFnDelegate(ImGuiContext* ctx, byte* path);

	public unsafe delegate void Platform_SetImeDataFnDelegate(ImGuiContext* ctx, ImGuiViewport* viewport, ImGuiPlatformImeData* data);

	public unsafe delegate void Platform_CreateWindowDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_DestroyWindowDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_ShowWindowDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_SetWindowPosDelegate(ImGuiViewport* vp, Vector2 pos);

	public unsafe delegate Vector2 Platform_GetWindowPosDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_SetWindowSizeDelegate(ImGuiViewport* vp, Vector2 size);

	public unsafe delegate Vector2 Platform_GetWindowSizeDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_SetWindowFocusDelegate(ImGuiViewport* vp);

	public unsafe delegate byte Platform_GetWindowFocusDelegate(ImGuiViewport* vp);

	public unsafe delegate byte Platform_GetWindowMinimizedDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_SetWindowTitleDelegate(ImGuiViewport* vp, byte* str);

	public unsafe delegate void Platform_SetWindowAlphaDelegate(ImGuiViewport* vp, float alpha);

	public unsafe delegate void Platform_UpdateWindowDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_RenderWindowDelegate(ImGuiViewport* vp, void* render_arg);

	public unsafe delegate void Platform_SwapBuffersDelegate(ImGuiViewport* vp, void* render_arg);

	public unsafe delegate float Platform_GetWindowDpiScaleDelegate(ImGuiViewport* vp);

	public unsafe delegate void Platform_OnChangedViewportDelegate(ImGuiViewport* vp);

	public unsafe delegate Vector4 Platform_GetWindowWorkAreaInsetsDelegate(ImGuiViewport* vp);

	public unsafe delegate int Platform_CreateVkSurfaceDelegate(ImGuiViewport* vp, ulong vk_inst, void* vk_allocators, ulong* out_vk_surface);

	public unsafe delegate void Renderer_CreateWindowDelegate(ImGuiViewport* vp);

	public unsafe delegate void Renderer_DestroyWindowDelegate(ImGuiViewport* vp);

	public unsafe delegate void Renderer_SetWindowSizeDelegate(ImGuiViewport* vp, Vector2 size);

	public unsafe delegate void Renderer_RenderWindowDelegate(ImGuiViewport* vp, void* render_arg);

	public unsafe delegate void Renderer_SwapBuffersDelegate(ImGuiViewport* vp, void* render_arg);

	public unsafe delegate uint AdapterIndexToStorageIdDelegate(ImGuiSelectionBasicStorage* self, int idx);

	public unsafe delegate void AdapterSetItemSelectedDelegate(ImGuiSelectionExternalStorage* self, int idx, byte selected);

	public unsafe delegate void ClearAllFnDelegate(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void ReadInitFnDelegate(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void* ReadOpenFnDelegate(ImGuiContext* ctx, ImGuiSettingsHandler* handler, byte* name);

	public unsafe delegate void ReadLineFnDelegate(ImGuiContext* ctx, ImGuiSettingsHandler* handler, void* entry, byte* line);

	public unsafe delegate void ApplyAllFnDelegate(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void WriteAllFnDelegate(ImGuiContext* ctx, ImGuiSettingsHandler* handler, ImGuiTextBuffer* out_buf);

	public unsafe delegate byte* igCombo_getterDelegate(void* user_data, int idx);

	public unsafe delegate byte* igListBox_FnStrPtr_getterDelegate(void* user_data, int idx);

	public unsafe delegate float igPlotLines_values_getterDelegate(void* data, int idx);

	public unsafe delegate float igPlotHistogram_values_getterDelegate(void* data, int idx);

	public unsafe delegate int igImQsort_compare_funcDelegate(void* arg0, void* arg1);

	public unsafe delegate byte* igTypingSelectFindMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate byte* igTypingSelectFindNextSingleCharMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate byte* igTypingSelectFindBestLeadingMatch_get_item_name_funcDelegate(void* arg0, int arg1);

	public unsafe delegate float igPlotEx_values_getterDelegate(void* data, int idx);

	public unsafe delegate void ImGuiPlatformIO_Set_Platform_GetWindowPos_user_callbackDelegate(ImGuiViewport* vp, Vector2* out_pos);

	public unsafe delegate void ImGuiPlatformIO_Set_Platform_GetWindowSize_user_callbackDelegate(ImGuiViewport* vp, Vector2* out_size);
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	public unsafe delegate void ImDrawCallbackDelegate(ImDrawList* parent_list, ImDrawCmd* cmd);

	public unsafe delegate void ImGuiContextHookCallbackDelegate(IntPtr ctx, ImGuiContextHook* hook);

	public unsafe delegate void ImGuiErrorCallbackDelegate(IntPtr ctx, void* user_data, byte* msg);

	public unsafe delegate int ImGuiInputTextCallbackDelegate(ImGuiInputTextCallbackData* data);

	public unsafe delegate void* ImGuiMemAllocFuncDelegate(uint sz, void* user_data);

	public unsafe delegate void ImGuiMemFreeFuncDelegate(void* ptr, void* user_data);

	public unsafe delegate void ImGuiSizeCallbackDelegate(ImGuiSizeCallbackData* data);

	public unsafe delegate byte FontBuilder_BuildDelegate(ImFontAtlas* atlas);

	public unsafe delegate void DockNodeWindowMenuHandlerDelegate(IntPtr ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);

	public unsafe delegate byte* Platform_GetClipboardTextFnDelegate(IntPtr ctx);

	public unsafe delegate void Platform_SetClipboardTextFnDelegate(IntPtr ctx, byte* text);

	public unsafe delegate byte Platform_OpenInShellFnDelegate(IntPtr ctx, byte* path);

	public unsafe delegate void Platform_SetImeDataFnDelegate(IntPtr ctx, ImGuiViewport* viewport, ImGuiPlatformImeData* data);

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

	public unsafe delegate void ClearAllFnDelegate(IntPtr ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void ReadInitFnDelegate(IntPtr ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void* ReadOpenFnDelegate(IntPtr ctx, ImGuiSettingsHandler* handler, byte* name);

	public unsafe delegate void ReadLineFnDelegate(IntPtr ctx, ImGuiSettingsHandler* handler, void* entry, byte* line);

	public unsafe delegate void ApplyAllFnDelegate(IntPtr ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void WriteAllFnDelegate(IntPtr ctx, ImGuiSettingsHandler* handler, ImGuiTextBuffer* out_buf);
}

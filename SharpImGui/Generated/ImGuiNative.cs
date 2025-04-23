using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace SharpImGui
{
	public unsafe partial class ImGuiNative
	{
		static ImGuiNative()
		{
			InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
		}

		public static string GetLibraryName()
		{
			return "cimgui";
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2* ImVec2_ImVec2()
		{
			return (Vector2*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[0])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2_ImVec2_Nil_Construct(Vector2* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2_destroy(Vector2* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[2])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2* ImVec2_ImVec2(float _x, float _y)
		{
			return (Vector2*)((delegate* unmanaged[Cdecl]<float, float, IntPtr>)FuncTable[3])(_x, _y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2_ImVec2_Float_Construct(Vector2* self, float _x, float _y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[4])((IntPtr)self, _x, _y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4* ImVec4_ImVec4()
		{
			return (Vector4*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[5])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec4_ImVec4_Nil_Construct(Vector4* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[6])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec4_destroy(Vector4* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[7])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4* ImVec4_ImVec4(float _x, float _y, float _z, float _w)
		{
			return (Vector4*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[8])(_x, _y, _z, _w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec4_ImVec4_Float_Construct(Vector4* self, float _x, float _y, float _z, float _w)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[9])((IntPtr)self, _x, _y, _z, _w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContext* igCreateContext(ImFontAtlas* shared_font_atlas)
		{
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[10])((IntPtr)shared_font_atlas);
		}

		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDestroyContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[11])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContext* igGetCurrentContext()
		{
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[12])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCurrentContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[13])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIO* igGetIO()
		{
			return (ImGuiIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[14])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformIO* igGetPlatformIO()
		{
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[15])();
		}

		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyle* igGetStyle()
		{
			return (ImGuiStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[16])();
		}

		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNewFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[17])();
		}

		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[18])();
		}

		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRender()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[19])();
		}

		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawData* igGetDrawData()
		{
			return (ImDrawData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[20])();
		}

		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowDemoWindow(byte* p_open)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[21])((IntPtr)p_open);
		}

		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowMetricsWindow(byte* p_open)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[22])((IntPtr)p_open);
		}

		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowDebugLogWindow(byte* p_open)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[23])((IntPtr)p_open);
		}

		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowIDStackToolWindow(byte* p_open)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[24])((IntPtr)p_open);
		}

		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowAboutWindow(byte* p_open)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[25])((IntPtr)p_open);
		}

		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowStyleEditor(ImGuiStyle* @ref)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[26])((IntPtr)@ref);
		}

		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igShowStyleSelector(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[27])((IntPtr)label);
		}

		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowFontSelector(byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[28])((IntPtr)label);
		}

		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowUserGuide()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[29])();
		}

		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igGetVersion()
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[30])();
		}

		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igStyleColorsDark(ImGuiStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[31])((IntPtr)dst);
		}

		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igStyleColorsLight(ImGuiStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[32])((IntPtr)dst);
		}

		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igStyleColorsClassic(ImGuiStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[33])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiWindowFlags, byte>)FuncTable[34])((IntPtr)name, (IntPtr)p_open, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEnd()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[35])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginChild(byte* str_id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiChildFlags, ImGuiWindowFlags, byte>)FuncTable[36])((IntPtr)str_id, size, child_flags, window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginChild(uint id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, ImGuiChildFlags, ImGuiWindowFlags, byte>)FuncTable[37])(id, size, child_flags, window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndChild()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[38])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowAppearing()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[39])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowCollapsed()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[40])();
		}

		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowFocused(ImGuiFocusedFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiFocusedFlags, byte>)FuncTable[41])(flags);
		}

		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowHovered(ImGuiHoveredFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiHoveredFlags, byte>)FuncTable[42])(flags);
		}

		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* igGetWindowDrawList()
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[43])();
		}

		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetWindowDpiScale()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[44])();
		}

		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetWindowPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[45])((IntPtr)pOut);
		}

		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetWindowSize(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[46])((IntPtr)pOut);
		}

		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetWindowWidth()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[47])();
		}

		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetWindowHeight()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[48])();
		}

		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* igGetWindowViewport()
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[49])();
		}

		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, Vector2, void>)FuncTable[50])(pos, cond, pivot);
		}

		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowSize(Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, void>)FuncTable[51])(size, cond);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, void* custom_callback, void* custom_callback_data)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, IntPtr, IntPtr, void>)FuncTable[52])(size_min, size_max, (IntPtr)custom_callback, (IntPtr)custom_callback_data);
		}

		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowContentSize(Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[53])(size);
		}

		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImGuiCond, void>)FuncTable[54])(collapsed, cond);
		}

		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowFocus()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[55])();
		}

		/// <summary>
		/// set next window scrolling value (use < 0.0f to not affect a given axis).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowScroll(Vector2 scroll)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[56])(scroll);
		}

		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowBgAlpha(float alpha)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[57])(alpha);
		}

		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowViewport(uint viewport_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[58])(viewport_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowPos(Vector2 pos, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, void>)FuncTable[59])(pos, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowSize(Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, void>)FuncTable[60])(size, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowCollapsed(byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImGuiCond, void>)FuncTable[61])(collapsed, cond);
		}

		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowFocus()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[62])();
		}

		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowFontScale(float scale)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[63])(scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowPos(byte* name, Vector2 pos, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[64])((IntPtr)name, pos, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowSize(byte* name, Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[65])((IntPtr)name, size, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowCollapsed(byte* name, byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, ImGuiCond, void>)FuncTable[66])((IntPtr)name, collapsed, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowFocus(byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[67])((IntPtr)name);
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetScrollX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[68])();
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetScrollY()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[69])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollX(float scroll_x)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[70])(scroll_x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollY(float scroll_y)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[71])(scroll_y);
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetScrollMaxX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[72])();
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetScrollMaxY()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[73])();
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollHereX(float center_x_ratio)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[74])(center_x_ratio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollHereY(float center_y_ratio)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[75])(center_y_ratio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollFromPosX(float local_x, float center_x_ratio)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[76])(local_x, center_x_ratio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollFromPosY(float local_y, float center_y_ratio)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[77])(local_y, center_y_ratio);
		}

		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushFont(ImFont* font)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[78])((IntPtr)font);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopFont()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[79])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushStyleColor(ImGuiCol idx, uint col)
		{
			((delegate* unmanaged[Cdecl]<ImGuiCol, uint, void>)FuncTable[80])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushStyleColor(ImGuiCol idx, Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<ImGuiCol, Vector4, void>)FuncTable[81])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopStyleColor(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[82])(count);
		}

		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushStyleVar(ImGuiStyleVar idx, float val)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, void>)FuncTable[83])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushStyleVar(ImGuiStyleVar idx, Vector2 val)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, Vector2, void>)FuncTable[84])(idx, val);
		}

		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushStyleVarX(ImGuiStyleVar idx, float val_x)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, void>)FuncTable[85])(idx, val_x);
		}

		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushStyleVarY(ImGuiStyleVar idx, float val_y)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, void>)FuncTable[86])(idx, val_y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopStyleVar(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[87])(count);
		}

		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushItemFlag(ImGuiItemFlags option, byte enabled)
		{
			((delegate* unmanaged[Cdecl]<ImGuiItemFlags, byte, void>)FuncTable[88])(option, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopItemFlag()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[89])();
		}

		/// <summary>
		/// push width of items for common large "item+label" widgets. >0.0f: width in pixels, <0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushItemWidth(float item_width)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[90])(item_width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopItemWidth()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[91])();
		}

		/// <summary>
		/// set width of the _next_ common large "item+label" widget. >0.0f: width in pixels, <0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemWidth(float item_width)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[92])(item_width);
		}

		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igCalcItemWidth()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[93])();
		}

		/// <summary>
		/// push word-wrapping position for Text*() commands. < 0.0f: no wrapping; 0.0f: wrap to end of window (or column); > 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushTextWrapPos(float wrap_local_pos_x)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[94])(wrap_local_pos_x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopTextWrapPos()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[95])();
		}

		/// <summary>
		/// get current font<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* igGetFont()
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[96])();
		}

		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetFontSize()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[97])();
		}

		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetFontTexUvWhitePixel(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[98])((IntPtr)pOut);
		}

		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetColorU32(ImGuiCol idx, float alpha_mul)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiCol, float, uint>)FuncTable[99])(idx, alpha_mul);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetColorU32(Vector4 col)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, uint>)FuncTable[100])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetColorU32(uint col, float alpha_mul)
		{
			return ((delegate* unmanaged[Cdecl]<uint, float, uint>)FuncTable[101])(col, alpha_mul);
		}

		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4* igGetStyleColorVec4(ImGuiCol idx)
		{
			return (Vector4*)((delegate* unmanaged[Cdecl]<ImGuiCol, IntPtr>)FuncTable[102])(idx);
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetCursorScreenPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[103])((IntPtr)pOut);
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCursorScreenPos(Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[104])(pos);
		}

		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetContentRegionAvail(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[105])((IntPtr)pOut);
		}

		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetCursorPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[106])((IntPtr)pOut);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetCursorPosX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[107])();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetCursorPosY()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[108])();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCursorPos(Vector2 local_pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[109])(local_pos);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCursorPosX(float local_x)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[110])(local_x);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCursorPosY(float local_y)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[111])(local_y);
		}

		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetCursorStartPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[112])((IntPtr)pOut);
		}

		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSeparator()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[113])();
		}

		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSameLine(float offset_from_start_x, float spacing)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[114])(offset_from_start_x, spacing);
		}

		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNewLine()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[115])();
		}

		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSpacing()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[116])();
		}

		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDummy(Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[117])(size);
		}

		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w <= 0<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igIndent(float indent_w)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[118])(indent_w);
		}

		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w <= 0<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUnindent(float indent_w)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[119])(indent_w);
		}

		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginGroup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[120])();
		}

		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndGroup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[121])();
		}

		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igAlignTextToFramePadding()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[122])();
		}

		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetTextLineHeight()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[123])();
		}

		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetTextLineHeightWithSpacing()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[124])();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetFrameHeight()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[125])();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetFrameHeightWithSpacing()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[126])();
		}

		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushID(byte* str_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[127])((IntPtr)str_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushID(byte* str_id_begin, byte* str_id_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[128])((IntPtr)str_id_begin, (IntPtr)str_id_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushID(void* ptr_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[129])((IntPtr)ptr_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushID(int int_id)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[130])(int_id);
		}

		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopID()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[131])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetID(byte* str_id)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[132])((IntPtr)str_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetID(byte* str_id_begin, byte* str_id_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[133])((IntPtr)str_id_begin, (IntPtr)str_id_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetID(void* ptr_id)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[134])((IntPtr)ptr_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetID(int int_id)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint>)FuncTable[135])(int_id);
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTextUnformatted(byte* text, byte* text_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[136])((IntPtr)text, (IntPtr)text_end);
		}

		/// <summary>
		/// formatted text<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igText(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[137])((IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTextColored(Vector4 col, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<Vector4, IntPtr, void>)FuncTable[138])(col, (IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTextDisabled(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[139])((IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTextWrapped(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[140])((IntPtr)fmt);
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLabelText(byte* label, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[141])((IntPtr)label, (IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBulletText(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[142])((IntPtr)fmt);
		}

		/// <summary>
		/// currently: formatted text with a horizontal line<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSeparatorText(byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[143])((IntPtr)label);
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igButton(byte* label, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, byte>)FuncTable[144])((IntPtr)label, size);
		}

		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSmallButton(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[145])((IntPtr)label);
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiButtonFlags, byte>)FuncTable[146])((IntPtr)str_id, size, flags);
		}

		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igArrowButton(byte* str_id, ImGuiDir dir)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDir, byte>)FuncTable[147])((IntPtr)str_id, dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCheckbox(byte* label, byte* v)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[148])((IntPtr)label, (IntPtr)v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCheckboxFlags(byte* label, int* flags, int flags_value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte>)FuncTable[149])((IntPtr)label, (IntPtr)flags, flags_value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCheckboxFlags(byte* label, uint* flags, uint flags_value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, byte>)FuncTable[150])((IntPtr)label, (IntPtr)flags, flags_value);
		}

		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igRadioButton(byte* label, byte active)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[151])((IntPtr)label, active);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igRadioButton(byte* label, int* v, int v_button)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte>)FuncTable[152])((IntPtr)label, (IntPtr)v, v_button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igProgressBar(float fraction, Vector2 size_arg, byte* overlay)
		{
			((delegate* unmanaged[Cdecl]<float, Vector2, IntPtr, void>)FuncTable[153])(fraction, size_arg, (IntPtr)overlay);
		}

		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBullet()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[154])();
		}

		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTextLink(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[155])((IntPtr)label);
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTextLinkOpenURL(byte* label, byte* url)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[156])((IntPtr)label, (IntPtr)url);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImage(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[157])(user_texture_id, image_size, uv0, uv1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImageWithBg(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector4, Vector4, void>)FuncTable[158])(user_texture_id, image_size, uv0, uv1, bg_col, tint_col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImageButton(byte* str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, Vector2, Vector4, Vector4, byte>)FuncTable[159])((IntPtr)str_id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiComboFlags, byte>)FuncTable[160])((IntPtr)label, (IntPtr)preview_value, flags);
		}

		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndCombo()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[161])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCombo_Str_arr(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, byte>)FuncTable[162])((IntPtr)label, (IntPtr)current_item, (IntPtr)items, items_count, popup_max_height_in_items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCombo(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, byte>)FuncTable[163])((IntPtr)label, (IntPtr)current_item, (IntPtr)items_separated_by_zeros, popup_max_height_in_items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCombo(byte* label, int* current_item, void* getter, void* user_data, int items_count, int popup_max_height_in_items)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, byte>)FuncTable[164])((IntPtr)label, (IntPtr)current_item, (IntPtr)getter, (IntPtr)user_data, items_count, popup_max_height_in_items);
		}

		/// <summary>
		/// If v_min >= v_max we have no bound<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[165])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[166])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[167])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[168])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, float, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[169])((IntPtr)label, (IntPtr)v_current_min, (IntPtr)v_current_max, v_speed, v_min, v_max, (IntPtr)format, (IntPtr)format_max, flags);
		}

		/// <summary>
		/// If v_min >= v_max we have no bound<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[170])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[171])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[172])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[173])((IntPtr)label, (IntPtr)v, v_speed, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, int, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[174])((IntPtr)label, (IntPtr)v_current_min, (IntPtr)v_current_max, v_speed, v_min, v_max, (IntPtr)format, (IntPtr)format_max, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, float, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[175])((IntPtr)label, data_type, (IntPtr)p_data, v_speed, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, int, float, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[176])((IntPtr)label, data_type, (IntPtr)p_data, components, v_speed, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags);
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[177])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[178])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[179])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[180])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[181])((IntPtr)label, (IntPtr)v_rad, v_degrees_min, v_degrees_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[182])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[183])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[184])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[185])((IntPtr)label, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[186])((IntPtr)label, data_type, (IntPtr)p_data, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, int, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[187])((IntPtr)label, data_type, (IntPtr)p_data, components, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[188])((IntPtr)label, size, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[189])((IntPtr)label, size, (IntPtr)v, v_min, v_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[190])((IntPtr)label, size, data_type, (IntPtr)p_data, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, void* callback, void* user_data)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, ImGuiInputTextFlags, IntPtr, IntPtr, byte>)FuncTable[191])((IntPtr)label, (IntPtr)buf, buf_size, flags, (IntPtr)callback, (IntPtr)user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, void* callback, void* user_data)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, Vector2, ImGuiInputTextFlags, IntPtr, IntPtr, byte>)FuncTable[192])((IntPtr)label, (IntPtr)buf, buf_size, size, flags, (IntPtr)callback, (IntPtr)user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, void* callback, void* user_data)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, uint, ImGuiInputTextFlags, IntPtr, IntPtr, byte>)FuncTable[193])((IntPtr)label, (IntPtr)hint, (IntPtr)buf, buf_size, flags, (IntPtr)callback, (IntPtr)user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[194])((IntPtr)label, (IntPtr)v, step, step_fast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[195])((IntPtr)label, (IntPtr)v, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[196])((IntPtr)label, (IntPtr)v, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[197])((IntPtr)label, (IntPtr)v, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, ImGuiInputTextFlags, byte>)FuncTable[198])((IntPtr)label, (IntPtr)v, step, step_fast, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[199])((IntPtr)label, (IntPtr)v, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[200])((IntPtr)label, (IntPtr)v, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[201])((IntPtr)label, (IntPtr)v, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[202])((IntPtr)label, (IntPtr)v, step, step_fast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[203])((IntPtr)label, data_type, (IntPtr)p_data, (IntPtr)p_step, (IntPtr)p_step_fast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, int, IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[204])((IntPtr)label, data_type, (IntPtr)p_data, components, (IntPtr)p_step, (IntPtr)p_step_fast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, byte>)FuncTable[205])((IntPtr)label, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, byte>)FuncTable[206])((IntPtr)label, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, byte>)FuncTable[207])((IntPtr)label, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, IntPtr, byte>)FuncTable[208])((IntPtr)label, (IntPtr)col, flags, (IntPtr)ref_col);
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector4, ImGuiColorEditFlags, Vector2, byte>)FuncTable[209])((IntPtr)desc_id, col, flags, size);
		}

		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetColorEditOptions(ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiColorEditFlags, void>)FuncTable[210])(flags);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNode(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[211])((IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNode(byte* str_id, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[212])((IntPtr)str_id, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNode(void* ptr_id, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[213])((IntPtr)ptr_id, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNodeEx(byte* label, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, byte>)FuncTable[214])((IntPtr)label, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNodeEx(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, IntPtr, byte>)FuncTable[215])((IntPtr)str_id, flags, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNodeEx(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, IntPtr, byte>)FuncTable[216])((IntPtr)ptr_id, flags, (IntPtr)fmt);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTreePush(byte* str_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[217])((IntPtr)str_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTreePush(void* ptr_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[218])((IntPtr)ptr_id);
		}

		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTreePop()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[219])();
		}

		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetTreeNodeToLabelSpacing()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[220])();
		}

		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCollapsingHeader(byte* label, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, byte>)FuncTable[221])((IntPtr)label, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCollapsingHeader(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiTreeNodeFlags, byte>)FuncTable[222])((IntPtr)label, (IntPtr)p_visible, flags);
		}

		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemOpen(byte is_open, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImGuiCond, void>)FuncTable[223])(is_open, cond);
		}

		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemStorageID(uint storage_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[224])(storage_id);
		}

		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSelectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, ImGuiSelectableFlags, Vector2, byte>)FuncTable[225])((IntPtr)label, selected, flags, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSelectable(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiSelectableFlags, Vector2, byte>)FuncTable[226])((IntPtr)label, (IntPtr)p_selected, flags, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectIO* igBeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size, int items_count)
		{
			return (ImGuiMultiSelectIO*)((delegate* unmanaged[Cdecl]<ImGuiMultiSelectFlags, int, int, IntPtr>)FuncTable[227])(flags, selection_size, items_count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectIO* igEndMultiSelect()
		{
			return (ImGuiMultiSelectIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[228])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemSelectionUserData(long selection_user_data)
		{
			((delegate* unmanaged[Cdecl]<long, void>)FuncTable[229])(selection_user_data);
		}

		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemToggledSelection()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[230])();
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginListBox(byte* label, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, byte>)FuncTable[231])((IntPtr)label, size);
		}

		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndListBox()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[232])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igListBox_Str_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, byte>)FuncTable[233])((IntPtr)label, (IntPtr)current_item, (IntPtr)items, items_count, height_in_items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igListBox_FnStrPtr(byte* label, int* current_item, void* getter, void* user_data, int items_count, int height_in_items)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, int, int, byte>)FuncTable[234])((IntPtr)label, (IntPtr)current_item, (IntPtr)getter, (IntPtr)user_data, items_count, height_in_items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPlotLines(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, int, void>)FuncTable[235])((IntPtr)label, (IntPtr)values, values_count, values_offset, (IntPtr)overlay_text, scale_min, scale_max, graph_size, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPlotLines(byte* label, void* values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, void>)FuncTable[236])((IntPtr)label, (IntPtr)values_getter, (IntPtr)data, values_count, values_offset, (IntPtr)overlay_text, scale_min, scale_max, graph_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPlotHistogram(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, int, void>)FuncTable[237])((IntPtr)label, (IntPtr)values, values_count, values_offset, (IntPtr)overlay_text, scale_min, scale_max, graph_size, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPlotHistogram(byte* label, void* values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, void>)FuncTable[238])((IntPtr)label, (IntPtr)values_getter, (IntPtr)data, values_count, values_offset, (IntPtr)overlay_text, scale_min, scale_max, graph_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igValue(byte* prefix, byte b)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[239])((IntPtr)prefix, b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igValue(byte* prefix, int v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[240])((IntPtr)prefix, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igValue(byte* prefix, uint v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[241])((IntPtr)prefix, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igValue(byte* prefix, float v, byte* float_format)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, void>)FuncTable[242])((IntPtr)prefix, v, (IntPtr)float_format);
		}

		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginMenuBar()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[243])();
		}

		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndMenuBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[244])();
		}

		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginMainMenuBar()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[245])();
		}

		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndMainMenuBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[246])();
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginMenu(byte* label, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[247])((IntPtr)label, enabled);
		}

		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndMenu()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[248])();
		}

		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igMenuItem(byte* label, byte* shortcut, byte selected, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte, byte>)FuncTable[249])((IntPtr)label, (IntPtr)shortcut, selected, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igMenuItem(byte* label, byte* shortcut, byte* p_selected, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, byte>)FuncTable[250])((IntPtr)label, (IntPtr)shortcut, (IntPtr)p_selected, enabled);
		}

		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTooltip()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[251])();
		}

		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndTooltip()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[252])();
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetTooltip(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[253])((IntPtr)fmt);
		}

		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginItemTooltip()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[254])();
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetItemTooltip(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[255])((IntPtr)fmt);
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiWindowFlags, byte>)FuncTable[256])((IntPtr)str_id, flags);
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiWindowFlags, byte>)FuncTable[257])((IntPtr)name, (IntPtr)p_open, flags);
		}

		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndPopup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[258])();
		}

		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igOpenPopup(byte* str_id, ImGuiPopupFlags popup_flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, void>)FuncTable[259])((IntPtr)str_id, popup_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igOpenPopup(uint id, ImGuiPopupFlags popup_flags)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiPopupFlags, void>)FuncTable[260])(id, popup_flags);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, void>)FuncTable[261])((IntPtr)str_id, popup_flags);
		}

		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igCloseCurrentPopup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[262])();
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[263])((IntPtr)str_id, popup_flags);
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[264])((IntPtr)str_id, popup_flags);
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[265])((IntPtr)str_id, popup_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsPopupOpen(byte* str_id, ImGuiPopupFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[266])((IntPtr)str_id, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTable(byte* str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ImGuiTableFlags, Vector2, float, byte>)FuncTable[267])((IntPtr)str_id, columns, flags, outer_size, inner_width);
		}

		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndTable()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[268])();
		}

		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height)
		{
			((delegate* unmanaged[Cdecl]<ImGuiTableRowFlags, float, void>)FuncTable[269])(row_flags, min_row_height);
		}

		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTableNextColumn()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[270])();
		}

		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTableSetColumnIndex(int column_n)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[271])(column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTableColumnFlags, float, uint, void>)FuncTable[272])((IntPtr)label, flags, init_width_or_weight, user_id);
		}

		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetupScrollFreeze(int cols, int rows)
		{
			((delegate* unmanaged[Cdecl]<int, int, void>)FuncTable[273])(cols, rows);
		}

		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableHeader(byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[274])((IntPtr)label);
		}

		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableHeadersRow()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[275])();
		}

		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableAngledHeadersRow()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[276])();
		}

		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSortSpecs* igTableGetSortSpecs()
		{
			return (ImGuiTableSortSpecs*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[277])();
		}

		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTableGetColumnCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[278])();
		}

		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTableGetColumnIndex()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[279])();
		}

		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTableGetRowIndex()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[280])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igTableGetColumnName(int column_n)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<int, IntPtr>)FuncTable[281])(column_n);
		}

		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnFlags igTableGetColumnFlags(int column_n)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImGuiTableColumnFlags>)FuncTable[282])(column_n);
		}

		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetColumnEnabled(int column_n, byte v)
		{
			((delegate* unmanaged[Cdecl]<int, byte, void>)FuncTable[283])(column_n, v);
		}

		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTableGetHoveredColumn()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[284])();
		}

		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n)
		{
			((delegate* unmanaged[Cdecl]<ImGuiTableBgTarget, uint, int, void>)FuncTable[285])(target, color, column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColumns(int count, byte* id, byte borders)
		{
			((delegate* unmanaged[Cdecl]<int, IntPtr, byte, void>)FuncTable[286])(count, (IntPtr)id, borders);
		}

		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNextColumn()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[287])();
		}

		/// <summary>
		/// get current column index<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igGetColumnIndex()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[288])();
		}

		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetColumnWidth(int column_index)
		{
			return ((delegate* unmanaged[Cdecl]<int, float>)FuncTable[289])(column_index);
		}

		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetColumnWidth(int column_index, float width)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[290])(column_index, width);
		}

		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetColumnOffset(int column_index)
		{
			return ((delegate* unmanaged[Cdecl]<int, float>)FuncTable[291])(column_index);
		}

		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetColumnOffset(int column_index, float offset_x)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[292])(column_index, offset_x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igGetColumnsCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[293])();
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabBarFlags, byte>)FuncTable[294])((IntPtr)str_id, flags);
		}

		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndTabBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[295])();
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiTabItemFlags, byte>)FuncTable[296])((IntPtr)label, (IntPtr)p_open, flags);
		}

		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndTabItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[297])();
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTabItemButton(byte* label, ImGuiTabItemFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabItemFlags, byte>)FuncTable[298])((IntPtr)label, flags);
		}

		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetTabItemClosed(byte* tab_or_docked_window_label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[299])((IntPtr)tab_or_docked_window_label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igDockSpace(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, ImGuiDockNodeFlags, IntPtr, uint>)FuncTable[300])(dockspace_id, size, flags, (IntPtr)window_class);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igDockSpaceOverViewport(uint dockspace_id, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class)
		{
			return ((delegate* unmanaged[Cdecl]<uint, IntPtr, ImGuiDockNodeFlags, IntPtr, uint>)FuncTable[301])(dockspace_id, (IntPtr)viewport, flags, (IntPtr)window_class);
		}

		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowDockID(uint dock_id, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiCond, void>)FuncTable[302])(dock_id, cond);
		}

		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowClass(ImGuiWindowClass* window_class)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[303])((IntPtr)window_class);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetWindowDockID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[304])();
		}

		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowDocked()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[305])();
		}

		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogToTTY(int auto_open_depth)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[306])(auto_open_depth);
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogToFile(int auto_open_depth, byte* filename)
		{
			((delegate* unmanaged[Cdecl]<int, IntPtr, void>)FuncTable[307])(auto_open_depth, (IntPtr)filename);
		}

		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogToClipboard(int auto_open_depth)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[308])(auto_open_depth);
		}

		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogFinish()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[309])();
		}

		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogButtons()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[310])();
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogText(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[311])((IntPtr)fmt);
		}

		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginDragDropSource(ImGuiDragDropFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDragDropFlags, byte>)FuncTable[312])(flags);
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, ImGuiCond, byte>)FuncTable[313])((IntPtr)type, (IntPtr)data, sz, cond);
		}

		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndDragDropSource()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[314])();
		}

		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginDragDropTarget()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[315])();
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags)
		{
			return (ImGuiPayload*)((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDragDropFlags, IntPtr>)FuncTable[316])((IntPtr)type, flags);
		}

		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndDragDropTarget()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[317])();
		}

		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPayload* igGetDragDropPayload()
		{
			return (ImGuiPayload*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[318])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginDisabled(byte disabled)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[319])(disabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndDisabled()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[320])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, byte, void>)FuncTable[321])(clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopClipRect()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[322])();
		}

		/// <summary>
		/// make last item the default focused item of a newly appearing window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetItemDefaultFocus()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[323])();
		}

		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetKeyboardFocusHere(int offset)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[324])(offset);
		}

		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNavCursorVisible(byte visible)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[325])(visible);
		}

		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemAllowOverlap()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[326])();
		}

		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemHovered(ImGuiHoveredFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiHoveredFlags, byte>)FuncTable[327])(flags);
		}

		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[328])();
		}

		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemFocused()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[329])();
		}

		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemClicked(ImGuiMouseButton mouse_button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[330])(mouse_button);
		}

		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemVisible()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[331])();
		}

		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemEdited()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[332])();
		}

		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemActivated()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[333])();
		}

		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemDeactivated()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[334])();
		}

		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemDeactivatedAfterEdit()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[335])();
		}

		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemToggledOpen()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[336])();
		}

		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsAnyItemHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[337])();
		}

		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsAnyItemActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[338])();
		}

		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsAnyItemFocused()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[339])();
		}

		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetItemID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[340])();
		}

		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetItemRectMin(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[341])((IntPtr)pOut);
		}

		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetItemRectMax(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[342])((IntPtr)pOut);
		}

		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetItemRectSize(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[343])((IntPtr)pOut);
		}

		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* igGetMainViewport()
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[344])();
		}

		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* igGetBackgroundDrawList(ImGuiViewport* viewport)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[345])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* igGetForegroundDrawList(ImGuiViewport* viewport)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[346])((IntPtr)viewport);
		}

		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsRectVisible(Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, byte>)FuncTable[347])(size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsRectVisible(Vector2 rect_min, Vector2 rect_max)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, byte>)FuncTable[348])(rect_min, rect_max);
		}

		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double igGetTime()
		{
			return ((delegate* unmanaged[Cdecl]<double>)FuncTable[349])();
		}

		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igGetFrameCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[350])();
		}

		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawListSharedData* igGetDrawListSharedData()
		{
			return (ImDrawListSharedData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[351])();
		}

		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igGetStyleColorName(ImGuiCol idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiCol, IntPtr>)FuncTable[352])(idx);
		}

		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetStateStorage(ImGuiStorage* storage)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[353])((IntPtr)storage);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStorage* igGetStateStorage()
		{
			return (ImGuiStorage*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[354])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, float, void>)FuncTable[355])((IntPtr)pOut, (IntPtr)text, (IntPtr)text_end, hide_text_after_double_hash, wrap_width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColorConvertU32ToFloat4(Vector4* pOut, uint @in)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[356])((IntPtr)pOut, @in);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igColorConvertFloat4ToU32(Vector4 @in)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, uint>)FuncTable[357])(@in);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v)
		{
			((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[358])(r, g, b, (IntPtr)out_h, (IntPtr)out_s, (IntPtr)out_v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b)
		{
			((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[359])(h, s, v, (IntPtr)out_r, (IntPtr)out_g, (IntPtr)out_b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyDown(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[360])(key);
		}

		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyPressed(ImGuiKey key, byte repeat)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte, byte>)FuncTable[361])(key, repeat);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyReleased(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[362])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyChordPressed(ImGuiKey key_chord)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[363])(key_chord);
		}

		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be >1 if RepeatRate is small enough that DeltaTime > RepeatRate<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, float, float, int>)FuncTable[364])(key, repeat_delay, rate);
		}

		/// <summary>
		/// [DEBUG] returns English name of the key. Those names are provided for debugging purpose and are not meant to be saved persistently nor compared.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igGetKeyName(ImGuiKey key)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiKey, IntPtr>)FuncTable[365])(key);
		}

		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextFrameWantCaptureKeyboard(byte want_capture_keyboard)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[366])(want_capture_keyboard);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igShortcut(ImGuiKey key_chord, ImGuiInputFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, byte>)FuncTable[367])(key_chord, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemShortcut(ImGuiKey key_chord, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, void>)FuncTable[368])(key_chord, flags);
		}

		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetItemKeyOwner(ImGuiKey key)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, void>)FuncTable[369])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseDown(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[370])(button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseClicked(ImGuiMouseButton button, byte repeat)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte, byte>)FuncTable[371])(button, repeat);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseReleased(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[372])(button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseDoubleClicked(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[373])(button);
		}

		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay >= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseReleasedWithDelay(ImGuiMouseButton button, float delay)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, float, byte>)FuncTable[374])(button, delay);
		}

		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igGetMouseClickedCount(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, int>)FuncTable[375])(button);
		}

		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, byte, byte>)FuncTable[376])(r_min, r_max, clip);
		}

		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMousePosValid(Vector2* mouse_pos)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[377])((IntPtr)mouse_pos);
		}

		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsAnyMouseDown()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[378])();
		}

		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetMousePos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[379])((IntPtr)pOut);
		}

		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[380])((IntPtr)pOut);
		}

		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold < 0.0f)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, float, byte>)FuncTable[381])(button, lock_threshold);
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold < 0.0f)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseButton, float, void>)FuncTable[382])((IntPtr)pOut, button, lock_threshold);
		}

		/// <summary>
		/// //<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igResetMouseDragDelta(ImGuiMouseButton button)
		{
			((delegate* unmanaged[Cdecl]<ImGuiMouseButton, void>)FuncTable[383])(button);
		}

		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMouseCursor igGetMouseCursor()
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseCursor>)FuncTable[384])();
		}

		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetMouseCursor(ImGuiMouseCursor cursor_type)
		{
			((delegate* unmanaged[Cdecl]<ImGuiMouseCursor, void>)FuncTable[385])(cursor_type);
		}

		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextFrameWantCaptureMouse(byte want_capture_mouse)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[386])(want_capture_mouse);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igGetClipboardText()
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[387])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetClipboardText(byte* text)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[388])((IntPtr)text);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLoadIniSettingsFromDisk(byte* ini_filename)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[389])((IntPtr)ini_filename);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[390])((IntPtr)ini_data, ini_size);
		}

		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSaveIniSettingsToDisk(byte* ini_filename)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[391])((IntPtr)ini_filename);
		}

		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igSaveIniSettingsToMemory(uint* out_ini_size)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[392])((IntPtr)out_ini_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugTextEncoding(byte* text)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[393])((IntPtr)text);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugFlashStyleColor(ImGuiCol idx)
		{
			((delegate* unmanaged[Cdecl]<ImGuiCol, void>)FuncTable[394])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugStartItemPicker()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[395])();
		}

		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, uint, uint, uint, uint, byte>)FuncTable[396])((IntPtr)version_str, sz_io, sz_style, sz_vec2, sz_vec4, sz_drawvert, sz_drawidx);
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugLog(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[397])((IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[398])(alloc_func, free_func, (IntPtr)user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[399])((IntPtr)p_alloc_func, (IntPtr)p_free_func, (IntPtr)p_user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* igMemAlloc(uint size)
		{
			return (void*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[400])(size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMemFree(void* ptr)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[401])((IntPtr)ptr);
		}

		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdatePlatformWindows()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[402])();
		}

		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[403])((IntPtr)platform_render_arg, (IntPtr)renderer_render_arg);
		}

		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDestroyPlatformWindows()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[404])();
		}

		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* igFindViewportByID(uint id)
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[405])(id);
		}

		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* igFindViewportByPlatformHandle(void* platform_handle)
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[406])((IntPtr)platform_handle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs()
		{
			return (ImGuiTableSortSpecs*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[407])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSortSpecs_ImGuiTableSortSpecs_Construct(ImGuiTableSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[408])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[409])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs()
		{
			return (ImGuiTableColumnSortSpecs*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[410])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs_Construct(ImGuiTableColumnSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[411])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[412])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyle* ImGuiStyle_ImGuiStyle()
		{
			return (ImGuiStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[413])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyle_ImGuiStyle_Construct(ImGuiStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[414])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyle_destroy(ImGuiStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[415])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[416])((IntPtr)self, scale_factor);
		}

		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, byte, void>)FuncTable[417])((IntPtr)self, key, down);
		}

		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, byte, float, void>)FuncTable[418])((IntPtr)self, key, down, v);
		}

		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[419])((IntPtr)self, x, y);
		}

		/// <summary>
		/// Queue a mouse button change<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, byte, void>)FuncTable[420])((IntPtr)self, button, down);
		}

		/// <summary>
		/// Queue a mouse wheel update. wheel_y<0: scroll down, wheel_y>0: scroll up, wheel_x<0: scroll right, wheel_x>0: scroll left.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[421])((IntPtr)self, wheel_x, wheel_y);
		}

		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseSource, void>)FuncTable[422])((IntPtr)self, source);
		}

		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[423])((IntPtr)self, id);
		}

		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[424])((IntPtr)self, focused);
		}

		/// <summary>
		/// Queue a new character input<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[425])((IntPtr)self, c);
		}

		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, void>)FuncTable[426])((IntPtr)self, c);
		}

		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[427])((IntPtr)self, (IntPtr)str);
		}

		/// <summary>
		/// [Optional] Specify index for legacy <1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, int, int, int, void>)FuncTable[428])((IntPtr)self, key, native_keycode, native_scancode, native_legacy_index);
		}

		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[429])((IntPtr)self, accepting_events);
		}

		/// <summary>
		/// Clear all incoming events.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_ClearEventsQueue(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[430])((IntPtr)self);
		}

		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_ClearInputKeys(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[431])((IntPtr)self);
		}

		/// <summary>
		/// Clear current mouse state.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_ClearInputMouse(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[432])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIO* ImGuiIO_ImGuiIO()
		{
			return (ImGuiIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[433])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_ImGuiIO_Construct(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[434])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIO_destroy(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[435])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData()
		{
			return (ImGuiInputTextCallbackData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[436])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackData_ImGuiInputTextCallbackData_Construct(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[437])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[438])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[439])((IntPtr)self, pos, bytes_count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[440])((IntPtr)self, pos, (IntPtr)text, (IntPtr)text_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[441])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[442])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[443])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowClass* ImGuiWindowClass_ImGuiWindowClass()
		{
			return (ImGuiWindowClass*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[444])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowClass_ImGuiWindowClass_Construct(ImGuiWindowClass* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[445])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowClass_destroy(ImGuiWindowClass* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[446])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPayload* ImGuiPayload_ImGuiPayload()
		{
			return (ImGuiPayload*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[447])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPayload_ImGuiPayload_Construct(ImGuiPayload* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[448])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPayload_destroy(ImGuiPayload* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[449])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPayload_Clear(ImGuiPayload* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[450])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[451])((IntPtr)self, (IntPtr)type);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiPayload_IsPreview(ImGuiPayload* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[452])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiPayload_IsDelivery(ImGuiPayload* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[453])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame()
		{
			return (ImGuiOnceUponAFrame*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[454])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOnceUponAFrame_ImGuiOnceUponAFrame_Construct(ImGuiOnceUponAFrame* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[455])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[456])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter)
		{
			return (ImGuiTextFilter*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[457])((IntPtr)default_filter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilter_ImGuiTextFilter_Construct(ImGuiTextFilter* self, byte* default_filter)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[458])((IntPtr)self, (IntPtr)default_filter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilter_destroy(ImGuiTextFilter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[459])((IntPtr)self);
		}

		/// <summary>
		/// Helper calling InputText+Build<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, byte>)FuncTable[460])((IntPtr)self, (IntPtr)label, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte>)FuncTable[461])((IntPtr)self, (IntPtr)text, (IntPtr)text_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilter_Build(ImGuiTextFilter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[462])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilter_Clear(ImGuiTextFilter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[463])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[464])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextRange* ImGuiTextRange_ImGuiTextRange()
		{
			return (ImGuiTextRange*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[465])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRange_ImGuiTextRange_Nil_Construct(ImGuiTextRange* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[466])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRange_destroy(ImGuiTextRange* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[467])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextRange* ImGuiTextRange_ImGuiTextRange(byte* _b, byte* _e)
		{
			return (ImGuiTextRange*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[468])((IntPtr)_b, (IntPtr)_e);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRange_ImGuiTextRange_Str_Construct(ImGuiTextRange* self, byte* _b, byte* _e)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[469])((IntPtr)self, (IntPtr)_b, (IntPtr)_e);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextRange_empty(ImGuiTextRange* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[470])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector<ImGuiTextRange>* @out)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, void>)FuncTable[471])((IntPtr)self, separator, (IntPtr)@out);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer()
		{
			return (ImGuiTextBuffer*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[472])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_ImGuiTextBuffer_Construct(ImGuiTextBuffer* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[473])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[474])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[475])((IntPtr)self);
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[476])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiTextBuffer_size(ImGuiTextBuffer* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[477])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[478])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_clear(ImGuiTextBuffer* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[479])((IntPtr)self);
		}

		/// <summary>
		/// Similar to resize(0) on ImVector: empty string but don't free buffer.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_resize(ImGuiTextBuffer* self, int size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[480])((IntPtr)self, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[481])((IntPtr)self, capacity);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[482])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[483])((IntPtr)self, (IntPtr)str, (IntPtr)str_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair(uint _key, int _val)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<uint, int, IntPtr>)FuncTable[484])(_key, _val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePair_ImGuiStoragePair_Int_Construct(ImGuiStoragePair* self, uint _key, int _val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, int, void>)FuncTable[485])((IntPtr)self, _key, _val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePair_destroy(ImGuiStoragePair* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[486])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair(uint _key, float _val)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<uint, float, IntPtr>)FuncTable[487])(_key, _val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePair_ImGuiStoragePair_Float_Construct(ImGuiStoragePair* self, uint _key, float _val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, float, void>)FuncTable[488])((IntPtr)self, _key, _val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair(uint _key, void* _val)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr>)FuncTable[489])(_key, (IntPtr)_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePair_ImGuiStoragePair_Ptr_Construct(ImGuiStoragePair* self, uint _key, void* _val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, void>)FuncTable[490])((IntPtr)self, _key, (IntPtr)_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_Clear(ImGuiStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[491])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, int, int>)FuncTable[492])((IntPtr)self, key, default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, int, void>)FuncTable[493])((IntPtr)self, key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, byte>)FuncTable[494])((IntPtr)self, key, default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, void>)FuncTable[495])((IntPtr)self, key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, float, float>)FuncTable[496])((IntPtr)self, key, default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, float, void>)FuncTable[497])((IntPtr)self, key, val);
		}

		/// <summary>
		/// default_val is NULL<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[498])((IntPtr)self, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, void>)FuncTable[499])((IntPtr)self, key, (IntPtr)val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val)
		{
			return (int*)((delegate* unmanaged[Cdecl]<IntPtr, uint, int, IntPtr>)FuncTable[500])((IntPtr)self, key, default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, IntPtr>)FuncTable[501])((IntPtr)self, key, default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val)
		{
			return (float*)((delegate* unmanaged[Cdecl]<IntPtr, uint, float, IntPtr>)FuncTable[502])((IntPtr)self, key, default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val)
		{
			return (void**)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, IntPtr>)FuncTable[503])((IntPtr)self, key, (IntPtr)default_val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_BuildSortByKey(ImGuiStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[504])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[505])((IntPtr)self, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipper* ImGuiListClipper_ImGuiListClipper()
		{
			return (ImGuiListClipper*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[506])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_ImGuiListClipper_Construct(ImGuiListClipper* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[507])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_destroy(ImGuiListClipper* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[508])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, float, void>)FuncTable[509])((IntPtr)self, items_count, items_height);
		}

		/// <summary>
		/// Automatically called on the last call of Step() that returns false.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_End(ImGuiListClipper* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[510])((IntPtr)self);
		}

		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiListClipper_Step(ImGuiListClipper* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[511])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_IncludeItemByIndex(ImGuiListClipper* self, int item_index)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[512])((IntPtr)self, item_index);
		}

		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[513])((IntPtr)self, item_begin, item_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* self, int item_index)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[514])((IntPtr)self, item_index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColor_ImColor()
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[515])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_ImColor_Nil_Construct(ImColor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[516])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_destroy(ImColor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[517])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColor_ImColor(float r, float g, float b, float a)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[518])(r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_ImColor_Float_Construct(ImColor* self, float r, float g, float b, float a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[519])((IntPtr)self, r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColor_ImColor(Vector4 col)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<Vector4, IntPtr>)FuncTable[520])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_ImColor_Vec4_Construct(ImColor* self, Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector4, void>)FuncTable[521])((IntPtr)self, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColor_ImColor(int r, int g, int b, int a)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr>)FuncTable[522])(r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_ImColor_Int_Construct(ImColor* self, int r, int g, int b, int a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, void>)FuncTable[523])((IntPtr)self, r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColor_ImColor_U32(uint rgba)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[524])(rgba);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_ImColor_U32_Construct(ImColor* self, uint rgba)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[525])((IntPtr)self, rgba);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[526])((IntPtr)self, h, s, v, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[527])((IntPtr)pOut, h, s, v, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSelectionBasicStorage* ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage()
		{
			return (ImGuiSelectionBasicStorage*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[528])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage_Construct(ImGuiSelectionBasicStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[529])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorage_destroy(ImGuiSelectionBasicStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[530])((IntPtr)self);
		}

		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[531])((IntPtr)self, (IntPtr)ms_io);
		}

		/// <summary>
		/// Query if an item id is in selection.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* self, uint id)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, byte>)FuncTable[532])((IntPtr)self, id);
		}

		/// <summary>
		/// Clear selection<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[533])((IntPtr)self);
		}

		/// <summary>
		/// Swap two selections<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[534])((IntPtr)self, (IntPtr)r);
		}

		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, void>)FuncTable[535])((IntPtr)self, id, selected);
		}

		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, uint* out_id)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte>)FuncTable[536])((IntPtr)self, (IntPtr)opaque_it, (IntPtr)out_id);
		}

		/// <summary>
		/// Convert index to item id based on provided adapter.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[537])((IntPtr)self, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSelectionExternalStorage* ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage()
		{
			return (ImGuiSelectionExternalStorage*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[538])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage_Construct(ImGuiSelectionExternalStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[539])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionExternalStorage_destroy(ImGuiSelectionExternalStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[540])((IntPtr)self);
		}

		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[541])((IntPtr)self, (IntPtr)ms_io);
		}

		/// <summary>
		/// Also ensure our padding fields are zeroed<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawCmd* ImDrawCmd_ImDrawCmd()
		{
			return (ImDrawCmd*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[542])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawCmd_ImDrawCmd_Construct(ImDrawCmd* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[543])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawCmd_destroy(ImDrawCmd* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[544])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[545])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter()
		{
			return (ImDrawListSplitter*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[546])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_ImDrawListSplitter_Construct(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[547])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_destroy(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[548])((IntPtr)self);
		}

		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_Clear(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[549])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[550])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[551])((IntPtr)self, (IntPtr)draw_list, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[552])((IntPtr)self, (IntPtr)draw_list);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[553])((IntPtr)self, (IntPtr)draw_list, channel_idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* ImDrawList_ImDrawList(ImDrawListSharedData* shared_data)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[554])((IntPtr)shared_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_ImDrawList_Construct(ImDrawList* self, ImDrawListSharedData* shared_data)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[555])((IntPtr)self, (IntPtr)shared_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_destroy(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[556])((IntPtr)self);
		}

		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, byte, void>)FuncTable[557])((IntPtr)self, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PushClipRectFullScreen(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[558])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PopClipRect(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[559])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[560])((IntPtr)self, texture_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PopTextureID(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[561])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[562])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[563])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, void>)FuncTable[564])((IntPtr)self, p1, p2, col, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, ImDrawFlags, float, void>)FuncTable[565])((IntPtr)self, p_min, p_max, col, rounding, flags, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, ImDrawFlags, void>)FuncTable[566])((IntPtr)self, p_min, p_max, col, rounding, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, uint, uint, uint, void>)FuncTable[567])((IntPtr)self, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, float, void>)FuncTable[568])((IntPtr)self, p1, p2, p3, p4, col, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[569])((IntPtr)self, p1, p2, p3, p4, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, uint, float, void>)FuncTable[570])((IntPtr)self, p1, p2, p3, col, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, uint, void>)FuncTable[571])((IntPtr)self, p1, p2, p3, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, float, void>)FuncTable[572])((IntPtr)self, center, radius, col, num_segments, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, void>)FuncTable[573])((IntPtr)self, center, radius, col, num_segments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, float, void>)FuncTable[574])((IntPtr)self, center, radius, col, num_segments, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, void>)FuncTable[575])((IntPtr)self, center, radius, col, num_segments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, int, float, void>)FuncTable[576])((IntPtr)self, center, radius, col, rot, num_segments, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, int, void>)FuncTable[577])((IntPtr)self, center, radius, col, rot, num_segments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddText(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, IntPtr, IntPtr, void>)FuncTable[578])((IntPtr)self, pos, col, (IntPtr)text_begin, (IntPtr)text_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddText(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, Vector2, uint, IntPtr, IntPtr, float, IntPtr, void>)FuncTable[579])((IntPtr)self, (IntPtr)font, font_size, pos, col, (IntPtr)text_begin, (IntPtr)text_end, wrap_width, (IntPtr)cpu_fine_clip_rect);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, float, int, void>)FuncTable[580])((IntPtr)self, p1, p2, p3, p4, col, thickness, num_segments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, uint, float, int, void>)FuncTable[581])((IntPtr)self, p1, p2, p3, col, thickness, num_segments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, uint, ImDrawFlags, float, void>)FuncTable[582])((IntPtr)self, (IntPtr)points, num_points, col, flags, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, uint, void>)FuncTable[583])((IntPtr)self, (IntPtr)points, num_points, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddConcavePolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, uint, void>)FuncTable[584])((IntPtr)self, (IntPtr)points, num_points, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[585])((IntPtr)self, user_texture_id, p_min, p_max, uv_min, uv_max, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[586])((IntPtr)self, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, Vector2, Vector2, uint, float, ImDrawFlags, void>)FuncTable[587])((IntPtr)self, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathClear(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[588])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[589])((IntPtr)self, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[590])((IntPtr)self, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathFillConvex(ImDrawList* self, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[591])((IntPtr)self, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathFillConcave(ImDrawList* self, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[592])((IntPtr)self, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, ImDrawFlags, float, void>)FuncTable[593])((IntPtr)self, col, flags, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, float, int, void>)FuncTable[594])((IntPtr)self, center, radius, a_min, a_max, num_segments);
		}

		/// <summary>
		/// Use precomputed angles for a 12 steps circle<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, int, int, void>)FuncTable[595])((IntPtr)self, center, radius, a_min_of_12, a_max_of_12);
		}

		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float a_min, float a_max, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, float, float, int, void>)FuncTable[596])((IntPtr)self, center, radius, rot, a_min, a_max, num_segments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, int, void>)FuncTable[597])((IntPtr)self, p2, p3, p4, num_segments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, int, void>)FuncTable[598])((IntPtr)self, p2, p3, num_segments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, ImDrawFlags, void>)FuncTable[599])((IntPtr)self, rect_min, rect_max, rounding, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* userdata, uint userdata_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, uint, void>)FuncTable[600])((IntPtr)self, callback, (IntPtr)userdata, userdata_size);
		}

		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_AddDrawCmd(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[601])((IntPtr)self);
		}

		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* ImDrawList_CloneOutput(ImDrawList* self)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[602])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_ChannelsSplit(ImDrawList* self, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[603])((IntPtr)self, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_ChannelsMerge(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[604])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[605])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[606])((IntPtr)self, idx_count, vtx_count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[607])((IntPtr)self, idx_count, vtx_count);
		}

		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, void>)FuncTable[608])((IntPtr)self, a, b, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[609])((IntPtr)self, a, b, uv_a, uv_b, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[610])((IntPtr)self, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, void>)FuncTable[611])((IntPtr)self, pos, uv, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, void>)FuncTable[612])((IntPtr)self, idx);
		}

		/// <summary>
		/// Write vertex with unique index<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, void>)FuncTable[613])((IntPtr)self, pos, uv, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__ResetForNewFrame(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[614])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__ClearFreeMemory(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[615])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__PopUnusedDrawCmd(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[616])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__TryMergeDrawCmds(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[617])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__OnChangedClipRect(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[618])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__OnChangedTextureID(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[619])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__OnChangedVtxOffset(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[620])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__SetTextureID(ImDrawList* self, IntPtr texture_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[621])((IntPtr)self, texture_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, int>)FuncTable[622])((IntPtr)self, radius);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, int, int, int, void>)FuncTable[623])((IntPtr)self, center, radius, a_min_sample, a_max_sample, a_step);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, float, int, void>)FuncTable[624])((IntPtr)self, center, radius, a_min, a_max, num_segments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawData* ImDrawData_ImDrawData()
		{
			return (ImDrawData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[625])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawData_ImDrawData_Construct(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[626])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawData_destroy(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[627])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawData_Clear(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[628])((IntPtr)self);
		}

		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawData_AddDrawList(ImDrawData* self, ImDrawList* draw_list)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[629])((IntPtr)self, (IntPtr)draw_list);
		}

		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawData_DeIndexAllBuffers(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[630])((IntPtr)self);
		}

		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[631])((IntPtr)self, fb_scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontConfig* ImFontConfig_ImFontConfig()
		{
			return (ImFontConfig*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[632])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontConfig_ImFontConfig_Construct(ImFontConfig* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[633])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontConfig_destroy(ImFontConfig* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[634])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder()
		{
			return (ImFontGlyphRangesBuilder*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[635])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder_Construct(ImFontGlyphRangesBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[636])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[637])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[638])((IntPtr)self);
		}

		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, byte>)FuncTable[639])((IntPtr)self, n);
		}

		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[640])((IntPtr)self, n);
		}

		/// <summary>
		/// Add character<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, void>)FuncTable[641])((IntPtr)self, c);
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[642])((IntPtr)self, (IntPtr)text, (IntPtr)text_end);
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[643])((IntPtr)self, (IntPtr)ranges);
		}

		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector<ushort>* out_ranges)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[644])((IntPtr)self, (IntPtr)out_ranges);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect()
		{
			return (ImFontAtlasCustomRect*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[645])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasCustomRect_ImFontAtlasCustomRect_Construct(ImFontAtlasCustomRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[646])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[647])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[648])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontAtlas* ImFontAtlas_ImFontAtlas()
		{
			return (ImFontAtlas*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[649])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_ImFontAtlas_Construct(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[650])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_destroy(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[651])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[652])((IntPtr)self, (IntPtr)font_cfg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[653])((IntPtr)self, (IntPtr)font_cfg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>)FuncTable[654])((IntPtr)self, (IntPtr)filename, size_pixels, (IntPtr)font_cfg, (IntPtr)glyph_ranges);
		}

		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg->FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, IntPtr, IntPtr>)FuncTable[655])((IntPtr)self, (IntPtr)font_data, font_data_size, size_pixels, (IntPtr)font_cfg, (IntPtr)glyph_ranges);
		}

		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, IntPtr, IntPtr>)FuncTable[656])((IntPtr)self, (IntPtr)compressed_font_data, compressed_font_data_size, size_pixels, (IntPtr)font_cfg, (IntPtr)glyph_ranges);
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>)FuncTable[657])((IntPtr)self, (IntPtr)compressed_font_data_base85, size_pixels, (IntPtr)font_cfg, (IntPtr)glyph_ranges);
		}

		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_ClearInputData(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[658])((IntPtr)self);
		}

		/// <summary>
		/// Clear input+output font data (same as ClearInputData() + glyphs storage, UV coordinates).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_ClearFonts(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[659])((IntPtr)self);
		}

		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_ClearTexData(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[660])((IntPtr)self);
		}

		/// <summary>
		/// Clear all input and output.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_Clear(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[661])((IntPtr)self);
		}

		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlas_Build(ImFontAtlas* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[662])((IntPtr)self);
		}

		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[663])((IntPtr)self, (IntPtr)out_pixels, (IntPtr)out_width, (IntPtr)out_height, (IntPtr)out_bytes_per_pixel);
		}

		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[664])((IntPtr)self, (IntPtr)out_pixels, (IntPtr)out_width, (IntPtr)out_height, (IntPtr)out_bytes_per_pixel);
		}

		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlas_IsBuilt(ImFontAtlas* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[665])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[666])((IntPtr)self, id);
		}

		/// <summary>
		/// Basic Latin, Extended Latin<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[667])((IntPtr)self);
		}

		/// <summary>
		/// Default + Greek and Coptic<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[668])((IntPtr)self);
		}

		/// <summary>
		/// Default + Korean characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[669])((IntPtr)self);
		}

		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[670])((IntPtr)self);
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[671])((IntPtr)self);
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[672])((IntPtr)self);
		}

		/// <summary>
		/// Default + about 400 Cyrillic characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[673])((IntPtr)self);
		}

		/// <summary>
		/// Default + Thai characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[674])((IntPtr)self);
		}

		/// <summary>
		/// Default + Vietnamese characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[675])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int>)FuncTable[676])((IntPtr)self, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ushort, int, int, float, Vector2, int>)FuncTable[677])((IntPtr)self, (IntPtr)font, id, width, height, advance_x, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index)
		{
			return (ImFontAtlasCustomRect*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[678])((IntPtr)self, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[679])((IntPtr)self, (IntPtr)rect, (IntPtr)out_uv_min, (IntPtr)out_uv_max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFont_ImFont()
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[680])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_ImFont_Construct(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[681])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_destroy(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[682])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c)
		{
			return (ImFontGlyph*)((delegate* unmanaged[Cdecl]<IntPtr, ushort, IntPtr>)FuncTable[683])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c)
		{
			return (ImFontGlyph*)((delegate* unmanaged[Cdecl]<IntPtr, ushort, IntPtr>)FuncTable[684])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImFont_GetCharAdvance(ImFont* self, ushort c)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ushort, float>)FuncTable[685])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFont_IsLoaded(ImFont* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[686])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImFont_GetDebugName(ImFont* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[687])((IntPtr)self);
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[688])((IntPtr)pOut, (IntPtr)self, size, max_width, wrap_width, (IntPtr)text_begin, (IntPtr)text_end, (IntPtr)remaining);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, IntPtr>)FuncTable[689])((IntPtr)self, scale, (IntPtr)text, (IntPtr)text_end, wrap_width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, Vector2, uint, ushort, void>)FuncTable[690])((IntPtr)self, (IntPtr)draw_list, size, pos, col, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, Vector2, uint, Vector4, IntPtr, IntPtr, float, byte, void>)FuncTable[691])((IntPtr)self, (IntPtr)draw_list, size, pos, col, clip_rect, (IntPtr)text_begin, (IntPtr)text_end, wrap_width, cpu_fine_clip);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_BuildLookupTable(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[692])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_ClearOutputData(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[693])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_GrowIndex(ImFont* self, int new_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[694])((IntPtr)self, new_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ushort, float, float, float, float, float, float, float, float, float, void>)FuncTable[695])((IntPtr)self, (IntPtr)src_cfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
		}

		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, ushort, byte, void>)FuncTable[696])((IntPtr)self, dst, src, overwrite_dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, byte>)FuncTable[697])((IntPtr)self, c_begin, c_last);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* ImGuiViewport_ImGuiViewport()
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[698])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewport_ImGuiViewport_Construct(ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[699])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewport_destroy(ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[700])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[701])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[702])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO()
		{
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[703])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIO_ImGuiPlatformIO_Construct(ImGuiPlatformIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[704])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[705])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformMonitor* ImGuiPlatformMonitor_ImGuiPlatformMonitor()
		{
			return (ImGuiPlatformMonitor*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[706])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformMonitor_ImGuiPlatformMonitor_Construct(ImGuiPlatformMonitor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[707])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[708])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData()
		{
			return (ImGuiPlatformImeData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[709])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformImeData_ImGuiPlatformImeData_Construct(ImGuiPlatformImeData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[710])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[711])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igImHashData(void* data, uint data_size, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, uint>)FuncTable[712])((IntPtr)data, data_size, seed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igImHashStr(byte* data, uint data_size, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, uint>)FuncTable[713])((IntPtr)data, data_size, seed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImQsort(void* @base, uint count, uint size_of_element, void* compare_func)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, IntPtr, void>)FuncTable[714])((IntPtr)@base, count, size_of_element, (IntPtr)compare_func);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igImAlphaBlendColors(uint col_a, uint col_b)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint, uint>)FuncTable[715])(col_a, col_b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImIsPowerOfTwo(int v)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[716])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImIsPowerOfTwo(ulong v)
		{
			return ((delegate* unmanaged[Cdecl]<ulong, byte>)FuncTable[717])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImUpperPowerOfTwo(int v)
		{
			return ((delegate* unmanaged[Cdecl]<int, int>)FuncTable[718])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igImCountSetBits(uint v)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint>)FuncTable[719])(v);
		}

		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImStricmp(byte* str1, byte* str2)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[720])((IntPtr)str1, (IntPtr)str2);
		}

		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImStrnicmp(byte* str1, byte* str2, uint count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, int>)FuncTable[721])((IntPtr)str1, (IntPtr)str2, count);
		}

		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImStrncpy(byte* dst, byte* src, uint count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, void>)FuncTable[722])((IntPtr)dst, (IntPtr)src, count);
		}

		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStrdup(byte* str)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[723])((IntPtr)str);
		}

		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr>)FuncTable[724])((IntPtr)dst, (IntPtr)p_dst_size, (IntPtr)str);
		}

		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, IntPtr>)FuncTable[725])((IntPtr)str_begin, (IntPtr)str_end, c);
		}

		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStreolRange(byte* str, byte* str_end)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[726])((IntPtr)str, (IntPtr)str_end);
		}

		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)FuncTable[727])((IntPtr)haystack, (IntPtr)haystack_end, (IntPtr)needle, (IntPtr)needle_end);
		}

		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImStrTrimBlanks(byte* str)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[728])((IntPtr)str);
		}

		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStrSkipBlank(byte* str)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[729])((IntPtr)str);
		}

		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImStrlenW(ushort* str)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[730])((IntPtr)str);
		}

		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImStrbol(byte* buf_mid_line, byte* buf_begin)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[731])((IntPtr)buf_mid_line, (IntPtr)buf_begin);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImToUpper(byte c)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte>)FuncTable[732])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImCharIsBlankA(byte c)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte>)FuncTable[733])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImCharIsBlankW(uint c)
		{
			return ((delegate* unmanaged[Cdecl]<uint, byte>)FuncTable[734])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImCharIsXdigitA(byte c)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte>)FuncTable[735])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImFormatString(byte* buf, uint buf_size, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, int>)FuncTable[736])((IntPtr)buf, buf_size, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFormatStringToTempBuffer(byte** out_buf, byte** out_buf_end, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[737])((IntPtr)out_buf, (IntPtr)out_buf_end, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImParseFormatFindStart(byte* format)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[738])((IntPtr)format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImParseFormatFindEnd(byte* format)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[739])((IntPtr)format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, IntPtr>)FuncTable[740])((IntPtr)format, (IntPtr)buf, buf_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, void>)FuncTable[741])((IntPtr)fmt_in, (IntPtr)fmt_out, fmt_out_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, IntPtr>)FuncTable[742])((IntPtr)fmt_in, (IntPtr)fmt_out, fmt_out_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImParseFormatPrecision(byte* format, int default_value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)FuncTable[743])((IntPtr)format, default_value);
		}

		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImTextCharToUtf8(byte* out_buf, uint c)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[744])((IntPtr)out_buf, c);
		}

		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int>)FuncTable[745])((IntPtr)out_buf, out_buf_size, (IntPtr)in_text, (IntPtr)in_text_end);
		}

		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int>)FuncTable[746])((IntPtr)out_char, (IntPtr)in_text, (IntPtr)in_text_end);
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextStrFromUtf8(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, byte** in_remaining)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, int>)FuncTable[747])((IntPtr)out_buf, out_buf_size, (IntPtr)in_text, (IntPtr)in_text_end, (IntPtr)in_remaining);
		}

		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[748])((IntPtr)in_text, (IntPtr)in_text_end);
		}

		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[749])((IntPtr)in_text, (IntPtr)in_text_end);
		}

		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[750])((IntPtr)in_text, (IntPtr)in_text_end);
		}

		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igImTextFindPreviousUtf8Codepoint(byte* in_text_start, byte* in_text_curr)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[751])((IntPtr)in_text_start, (IntPtr)in_text_curr);
		}

		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImTextCountLines(byte* in_text, byte* in_text_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[752])((IntPtr)in_text, (IntPtr)in_text_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr igImFileOpen(byte* filename, byte* mode)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[753])((IntPtr)filename, (IntPtr)mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImFileClose(IntPtr file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[754])(file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong igImFileGetSize(IntPtr file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong>)FuncTable[755])(file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong igImFileRead(void* data, ulong size, ulong count, IntPtr file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong, ulong, IntPtr, ulong>)FuncTable[756])((IntPtr)data, size, count, file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong igImFileWrite(void* data, ulong size, ulong count, IntPtr file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong, ulong, IntPtr, ulong>)FuncTable[757])((IntPtr)data, size, count, file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr>)FuncTable[758])((IntPtr)filename, (IntPtr)mode, (IntPtr)out_file_size, padding_bytes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImPow_Float(float x, float y)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float>)FuncTable[759])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double igImPow_double(double x, double y)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, double>)FuncTable[760])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImLog_Float(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[761])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double igImLog_double(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[762])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImAbs_Int(int x)
		{
			return ((delegate* unmanaged[Cdecl]<int, int>)FuncTable[763])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImAbs_Float(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[764])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double igImAbs_double(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[765])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImSign_Float(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[766])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double igImSign_double(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[767])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImRsqrt_Float(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[768])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double igImRsqrt_double(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[769])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[770])((IntPtr)pOut, lhs, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[771])((IntPtr)pOut, lhs, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[772])((IntPtr)pOut, v, mn, mx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImLerp(Vector2* pOut, Vector2 a, Vector2 b, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, void>)FuncTable[773])((IntPtr)pOut, a, b, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImLerp(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[774])((IntPtr)pOut, a, b, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImLerp(Vector4* pOut, Vector4 a, Vector4 b, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector4, Vector4, float, void>)FuncTable[775])((IntPtr)pOut, a, b, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImSaturate(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[776])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImLengthSqr(Vector2 lhs)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, float>)FuncTable[777])(lhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImLengthSqr(Vector4 lhs)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, float>)FuncTable[778])(lhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImInvLength(Vector2 lhs, float fail_value)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, float, float>)FuncTable[779])(lhs, fail_value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImTrunc_Float(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[780])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImTrunc_Vec2(Vector2* pOut, Vector2 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[781])((IntPtr)pOut, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImFloor_Float(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[782])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFloor_Vec2(Vector2* pOut, Vector2 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[783])((IntPtr)pOut, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igImModPositive(int a, int b)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int>)FuncTable[784])(a, b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImDot(Vector2 a, Vector2 b)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, float>)FuncTable[785])(a, b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, void>)FuncTable[786])((IntPtr)pOut, v, cos_a, sin_a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImLinearSweep(float current, float target, float speed)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float>)FuncTable[787])(current, target, speed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImLinearRemapClamp(float s0, float s1, float d0, float d1, float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float>)FuncTable[788])(s0, s1, d0, d1, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[789])((IntPtr)pOut, lhs, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImIsFloatAboveGuaranteedIntegerPrecision(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, byte>)FuncTable[790])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImExponentialMovingAverage(float avg, float sample, int n)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, int, float>)FuncTable[791])(avg, sample, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, float, void>)FuncTable[792])((IntPtr)pOut, p1, p2, p3, p4, t);
		}

		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, int, void>)FuncTable[793])((IntPtr)pOut, p1, p2, p3, p4, p, num_segments);
		}

		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, float, void>)FuncTable[794])((IntPtr)pOut, p1, p2, p3, p4, p, tess_tol);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, float, void>)FuncTable[795])((IntPtr)pOut, p1, p2, p3, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[796])((IntPtr)pOut, a, b, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, Vector2, byte>)FuncTable[797])(a, b, c, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, void>)FuncTable[798])((IntPtr)pOut, a, b, c, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, Vector2, IntPtr, IntPtr, IntPtr, void>)FuncTable[799])(a, b, c, p, (IntPtr)out_u, (IntPtr)out_v, (IntPtr)out_w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, float>)FuncTable[800])(a, b, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, byte>)FuncTable[801])(a, b, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec1* ImVec1_ImVec1()
		{
			return (ImVec1*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[802])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec1_ImVec1_Nil_Construct(ImVec1* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[803])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec1_destroy(ImVec1* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[804])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec1* ImVec1_ImVec1(float _x)
		{
			return (ImVec1*)((delegate* unmanaged[Cdecl]<float, IntPtr>)FuncTable[805])(_x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec1_ImVec1_Float_Construct(ImVec1* self, float _x)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[806])((IntPtr)self, _x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec2ih* ImVec2ih_ImVec2ih()
		{
			return (ImVec2ih*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[807])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2ih_ImVec2ih_Nil_Construct(ImVec2ih* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[808])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2ih_destroy(ImVec2ih* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[809])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec2ih* ImVec2ih_ImVec2ih_short(short _x, short _y)
		{
			return (ImVec2ih*)((delegate* unmanaged[Cdecl]<short, short, IntPtr>)FuncTable[810])(_x, _y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2ih_ImVec2ih_short_Construct(ImVec2ih* self, short _x, short _y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, short, short, void>)FuncTable[811])((IntPtr)self, _x, _y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec2ih* ImVec2ih_ImVec2ih(Vector2 rhs)
		{
			return (ImVec2ih*)((delegate* unmanaged[Cdecl]<Vector2, IntPtr>)FuncTable[812])(rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2ih_ImVec2ih_Vec2_Construct(ImVec2ih* self, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[813])((IntPtr)self, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRect_ImRect()
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[814])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ImRect_Nil_Construct(ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[815])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_destroy(ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[816])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRect_ImRect(Vector2 min, Vector2 max)
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<Vector2, Vector2, IntPtr>)FuncTable[817])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ImRect_Vec2_Construct(ImRect* self, Vector2 min, Vector2 max)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[818])((IntPtr)self, min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRect_ImRect(Vector4 v)
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<Vector4, IntPtr>)FuncTable[819])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ImRect_Vec4_Construct(ImRect* self, Vector4 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector4, void>)FuncTable[820])((IntPtr)self, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRect_ImRect(float x1, float y1, float x2, float y2)
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[821])(x1, y1, x2, y2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ImRect_Float_Construct(ImRect* self, float x1, float y1, float x2, float y2)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[822])((IntPtr)self, x1, y1, x2, y2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_GetCenter(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[823])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_GetSize(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[824])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRect_GetWidth(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[825])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRect_GetHeight(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[826])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRect_GetArea(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[827])((IntPtr)self);
		}

		/// <summary>
		/// Top-left<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_GetTL(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[828])((IntPtr)pOut, (IntPtr)self);
		}

		/// <summary>
		/// Top-right<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_GetTR(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[829])((IntPtr)pOut, (IntPtr)self);
		}

		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_GetBL(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[830])((IntPtr)pOut, (IntPtr)self);
		}

		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_GetBR(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[831])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRect_Contains_Vec2(ImRect* self, Vector2 p)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, byte>)FuncTable[832])((IntPtr)self, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRect_Contains_Rect(ImRect* self, ImRect r)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, byte>)FuncTable[833])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRect_ContainsWithPad(ImRect* self, Vector2 p, Vector2 pad)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, byte>)FuncTable[834])((IntPtr)self, p, pad);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRect_Overlaps(ImRect* self, ImRect r)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, byte>)FuncTable[835])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_Add_Vec2(ImRect* self, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[836])((IntPtr)self, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_Add_Rect(ImRect* self, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[837])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_Expand(ImRect* self, float amount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[838])((IntPtr)self, amount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_Expand(ImRect* self, Vector2 amount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[839])((IntPtr)self, amount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_Translate(ImRect* self, Vector2 d)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[840])((IntPtr)self, d);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_TranslateX(ImRect* self, float dx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[841])((IntPtr)self, dx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_TranslateY(ImRect* self, float dy)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[842])((IntPtr)self, dy);
		}

		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ClipWith(ImRect* self, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[843])((IntPtr)self, r);
		}

		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ClipWithFull(ImRect* self, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[844])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_Floor(ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[845])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRect_IsInverted(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[846])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRect_ToVec4(Vector4* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[847])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igImBitArrayGetStorageSizeInBytes(int bitcount)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint>)FuncTable[848])(bitcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBitArrayClearAllBits(uint* arr, int bitcount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[849])((IntPtr)arr, bitcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImBitArrayTestBit(uint* arr, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[850])((IntPtr)arr, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBitArrayClearBit(uint* arr, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[851])((IntPtr)arr, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBitArraySetBit(uint* arr, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[852])((IntPtr)arr, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImBitArraySetBitRange(uint* arr, int n, int n2)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[853])((IntPtr)arr, n, n2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVector_Create(ImBitVector* self, int sz)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[854])((IntPtr)self, sz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVector_Clear(ImBitVector* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[855])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImBitVector_TestBit(ImBitVector* self, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[856])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVector_SetBit(ImBitVector* self, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[857])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVector_ClearBit(ImBitVector* self, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[858])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextIndex_clear(ImGuiTextIndex* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[859])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiTextIndex_size(ImGuiTextIndex* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[860])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextIndex_get_line_begin(ImGuiTextIndex* self, byte* @base, int n)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr>)FuncTable[861])((IntPtr)self, (IntPtr)@base, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextIndex_get_line_end(ImGuiTextIndex* self, byte* @base, int n)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr>)FuncTable[862])((IntPtr)self, (IntPtr)@base, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextIndex_append(ImGuiTextIndex* self, byte* @base, int old_size, int new_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, void>)FuncTable[863])((IntPtr)self, (IntPtr)@base, old_size, new_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* igImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, uint key)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, IntPtr>)FuncTable[864])((IntPtr)in_begin, (IntPtr)in_end, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawListSharedData* ImDrawListSharedData_ImDrawListSharedData()
		{
			return (ImDrawListSharedData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[865])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSharedData_ImDrawListSharedData_Construct(ImDrawListSharedData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[866])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSharedData_destroy(ImDrawListSharedData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[867])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[868])((IntPtr)self, max_error);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawDataBuilder* ImDrawDataBuilder_ImDrawDataBuilder()
		{
			return (ImDrawDataBuilder*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[869])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataBuilder_ImDrawDataBuilder_Construct(ImDrawDataBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[870])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataBuilder_destroy(ImDrawDataBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[871])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* ImGuiStyleVarInfo_GetVarPtr(ImGuiStyleVarInfo* self, void* parent)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[872])((IntPtr)self, (IntPtr)parent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod(ImGuiStyleVar idx, int v)
		{
			return (ImGuiStyleMod*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, int, IntPtr>)FuncTable[873])(idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleMod_ImGuiStyleMod_Int_Construct(ImGuiStyleMod* self, ImGuiStyleVar idx, int v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiStyleVar, int, void>)FuncTable[874])((IntPtr)self, idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleMod_destroy(ImGuiStyleMod* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[875])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod(ImGuiStyleVar idx, float v)
		{
			return (ImGuiStyleMod*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, IntPtr>)FuncTable[876])(idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleMod_ImGuiStyleMod_Float_Construct(ImGuiStyleMod* self, ImGuiStyleVar idx, float v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiStyleVar, float, void>)FuncTable[877])((IntPtr)self, idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod(ImGuiStyleVar idx, Vector2 v)
		{
			return (ImGuiStyleMod*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, Vector2, IntPtr>)FuncTable[878])(idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleMod_ImGuiStyleMod_Vec2_Construct(ImGuiStyleMod* self, ImGuiStyleVar idx, Vector2 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiStyleVar, Vector2, void>)FuncTable[879])((IntPtr)self, idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiComboPreviewData* ImGuiComboPreviewData_ImGuiComboPreviewData()
		{
			return (ImGuiComboPreviewData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[880])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiComboPreviewData_ImGuiComboPreviewData_Construct(ImGuiComboPreviewData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[881])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[882])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns()
		{
			return (ImGuiMenuColumns*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[883])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumns_ImGuiMenuColumns_Construct(ImGuiMenuColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[884])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[885])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, byte, void>)FuncTable[886])((IntPtr)self, spacing, window_reappearing);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, float>)FuncTable[887])((IntPtr)self, w_icon, w_label, w_shortcut, w_mark);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[888])((IntPtr)self, update_offsets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextDeactivatedState* ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState()
		{
			return (ImGuiInputTextDeactivatedState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[889])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState_Construct(ImGuiInputTextDeactivatedState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[890])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextDeactivatedState_destroy(ImGuiInputTextDeactivatedState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[891])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[892])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextState* ImGuiInputTextState_ImGuiInputTextState()
		{
			return (ImGuiInputTextState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[893])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ImGuiInputTextState_Construct(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[894])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_destroy(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[895])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ClearText(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[896])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[897])((IntPtr)self);
		}

		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[898])((IntPtr)self, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* self, uint c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[899])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[900])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[901])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[902])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[903])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[904])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[905])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[906])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[907])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[908])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[909])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[910])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData()
		{
			return (ImGuiNextWindowData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[911])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextWindowData_ImGuiNextWindowData_Construct(ImGuiNextWindowData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[912])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[913])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[914])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData()
		{
			return (ImGuiNextItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[915])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextItemData_ImGuiNextItemData_Construct(ImGuiNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[916])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextItemData_destroy(ImGuiNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[917])((IntPtr)self);
		}

		/// <summary>
		/// Also cleared manually by ItemAdd()!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[918])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiLastItemData* ImGuiLastItemData_ImGuiLastItemData()
		{
			return (ImGuiLastItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[919])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiLastItemData_ImGuiLastItemData_Construct(ImGuiLastItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[920])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiLastItemData_destroy(ImGuiLastItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[921])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiErrorRecoveryState* ImGuiErrorRecoveryState_ImGuiErrorRecoveryState()
		{
			return (ImGuiErrorRecoveryState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[922])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiErrorRecoveryState_ImGuiErrorRecoveryState_Construct(ImGuiErrorRecoveryState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[923])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiErrorRecoveryState_destroy(ImGuiErrorRecoveryState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[924])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex(void* ptr)
		{
			return (ImGuiPtrOrIndex*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[925])((IntPtr)ptr);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr_Construct(ImGuiPtrOrIndex* self, void* ptr)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[926])((IntPtr)self, (IntPtr)ptr);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[927])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex(int index)
		{
			return (ImGuiPtrOrIndex*)((delegate* unmanaged[Cdecl]<int, IntPtr>)FuncTable[928])(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int_Construct(ImGuiPtrOrIndex* self, int index)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[929])((IntPtr)self, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPopupData* ImGuiPopupData_ImGuiPopupData()
		{
			return (ImGuiPopupData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[930])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPopupData_ImGuiPopupData_Construct(ImGuiPopupData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[931])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPopupData_destroy(ImGuiPopupData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[932])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputEvent* ImGuiInputEvent_ImGuiInputEvent()
		{
			return (ImGuiInputEvent*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[933])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputEvent_ImGuiInputEvent_Construct(ImGuiInputEvent* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[934])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputEvent_destroy(ImGuiInputEvent* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[935])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyRoutingData* ImGuiKeyRoutingData_ImGuiKeyRoutingData()
		{
			return (ImGuiKeyRoutingData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[936])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingData_ImGuiKeyRoutingData_Construct(ImGuiKeyRoutingData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[937])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingData_destroy(ImGuiKeyRoutingData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[938])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyRoutingTable* ImGuiKeyRoutingTable_ImGuiKeyRoutingTable()
		{
			return (ImGuiKeyRoutingTable*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[939])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingTable_ImGuiKeyRoutingTable_Construct(ImGuiKeyRoutingTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[940])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingTable_destroy(ImGuiKeyRoutingTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[941])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingTable_Clear(ImGuiKeyRoutingTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[942])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyOwnerData* ImGuiKeyOwnerData_ImGuiKeyOwnerData()
		{
			return (ImGuiKeyOwnerData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[943])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyOwnerData_ImGuiKeyOwnerData_Construct(ImGuiKeyOwnerData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[944])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyOwnerData_destroy(ImGuiKeyOwnerData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[945])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, ImGuiListClipperRange>)FuncTable[946])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, int, int, ImGuiListClipperRange>)FuncTable[947])(y1, y2, off_min, off_max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipperData* ImGuiListClipperData_ImGuiListClipperData()
		{
			return (ImGuiListClipperData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[948])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperData_ImGuiListClipperData_Construct(ImGuiListClipperData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[949])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperData_destroy(ImGuiListClipperData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[950])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[951])((IntPtr)self, (IntPtr)clipper);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiNavItemData* ImGuiNavItemData_ImGuiNavItemData()
		{
			return (ImGuiNavItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[952])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNavItemData_ImGuiNavItemData_Construct(ImGuiNavItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[953])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNavItemData_destroy(ImGuiNavItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[954])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNavItemData_Clear(ImGuiNavItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[955])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTypingSelectState* ImGuiTypingSelectState_ImGuiTypingSelectState()
		{
			return (ImGuiTypingSelectState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[956])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTypingSelectState_ImGuiTypingSelectState_Construct(ImGuiTypingSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[957])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTypingSelectState_destroy(ImGuiTypingSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[958])((IntPtr)self);
		}

		/// <summary>
		/// We preserve remaining data for easier debugging<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[959])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOldColumnData* ImGuiOldColumnData_ImGuiOldColumnData()
		{
			return (ImGuiOldColumnData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[960])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumnData_ImGuiOldColumnData_Construct(ImGuiOldColumnData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[961])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[962])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOldColumns* ImGuiOldColumns_ImGuiOldColumns()
		{
			return (ImGuiOldColumns*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[963])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumns_ImGuiOldColumns_Construct(ImGuiOldColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[964])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumns_destroy(ImGuiOldColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[965])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiBoxSelectState* ImGuiBoxSelectState_ImGuiBoxSelectState()
		{
			return (ImGuiBoxSelectState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[966])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiBoxSelectState_ImGuiBoxSelectState_Construct(ImGuiBoxSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[967])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiBoxSelectState_destroy(ImGuiBoxSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[968])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectTempData* ImGuiMultiSelectTempData_ImGuiMultiSelectTempData()
		{
			return (ImGuiMultiSelectTempData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[969])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempData_ImGuiMultiSelectTempData_Construct(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[970])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempData_destroy(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[971])((IntPtr)self);
		}

		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[972])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[973])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectState* ImGuiMultiSelectState_ImGuiMultiSelectState()
		{
			return (ImGuiMultiSelectState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[974])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectState_ImGuiMultiSelectState_Construct(ImGuiMultiSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[975])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectState_destroy(ImGuiMultiSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[976])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* ImGuiDockNode_ImGuiDockNode(uint id)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[977])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNode_ImGuiDockNode_Construct(ImGuiDockNode* self, uint id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[978])((IntPtr)self, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNode_destroy(ImGuiDockNode* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[979])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsRootNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[980])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsDockSpace(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[981])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsFloatingNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[982])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsCentralNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[983])((IntPtr)self);
		}

		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsHiddenTabBar(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[984])((IntPtr)self);
		}

		/// <summary>
		/// Never show a tab bar<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsNoTabBar(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[985])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsSplitNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[986])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsLeafNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[987])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNode_IsEmpty(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[988])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNode_Rect(ImRect* pOut, ImGuiDockNode* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[989])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDockNodeFlags, void>)FuncTable[990])((IntPtr)self, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[991])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockContext* ImGuiDockContext_ImGuiDockContext()
		{
			return (ImGuiDockContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[992])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockContext_ImGuiDockContext_Construct(ImGuiDockContext* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[993])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockContext_destroy(ImGuiDockContext* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[994])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewportP* ImGuiViewportP_ImGuiViewportP()
		{
			return (ImGuiViewportP*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[995])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_ImGuiViewportP_Construct(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[996])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_destroy(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[997])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_ClearRequestFlags(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[998])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_CalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 inset_min)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[999])((IntPtr)pOut, (IntPtr)self, inset_min);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_CalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 inset_min, Vector2 inset_max)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, void>)FuncTable[1000])((IntPtr)pOut, (IntPtr)self, inset_min, inset_max);
		}

		/// <summary>
		/// Update public fields<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1001])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1002])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1003])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportP_GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1004])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* ImGuiWindowSettings_ImGuiWindowSettings()
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1005])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowSettings_ImGuiWindowSettings_Construct(ImGuiWindowSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1006])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1007])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1008])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler()
		{
			return (ImGuiSettingsHandler*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1009])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSettingsHandler_ImGuiSettingsHandler_Construct(ImGuiSettingsHandler* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1010])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1011])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDebugAllocInfo* ImGuiDebugAllocInfo_ImGuiDebugAllocInfo()
		{
			return (ImGuiDebugAllocInfo*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1012])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDebugAllocInfo_ImGuiDebugAllocInfo_Construct(ImGuiDebugAllocInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1013])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDebugAllocInfo_destroy(ImGuiDebugAllocInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1014])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStackLevelInfo* ImGuiStackLevelInfo_ImGuiStackLevelInfo()
		{
			return (ImGuiStackLevelInfo*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1015])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStackLevelInfo_ImGuiStackLevelInfo_Construct(ImGuiStackLevelInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1016])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1017])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIDStackTool* ImGuiIDStackTool_ImGuiIDStackTool()
		{
			return (ImGuiIDStackTool*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1018])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIDStackTool_ImGuiIDStackTool_Construct(ImGuiIDStackTool* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1019])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIDStackTool_destroy(ImGuiIDStackTool* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1020])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContextHook* ImGuiContextHook_ImGuiContextHook()
		{
			return (ImGuiContextHook*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1021])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContextHook_ImGuiContextHook_Construct(ImGuiContextHook* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1022])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContextHook_destroy(ImGuiContextHook* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1023])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContext* ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas)
		{
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1024])((IntPtr)shared_font_atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContext_ImGuiContext_Construct(ImGuiContext* self, ImFontAtlas* shared_font_atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1025])((IntPtr)self, (IntPtr)shared_font_atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContext_destroy(ImGuiContext* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1026])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* ImGuiWindow_ImGuiWindow(ImGuiContext* context, byte* name)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[1027])((IntPtr)context, (IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindow_ImGuiWindow_Construct(ImGuiWindow* self, ImGuiContext* context, byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1028])((IntPtr)self, (IntPtr)context, (IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindow_destroy(ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1029])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindow_GetID(ImGuiWindow* self, byte* str, byte* str_end)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, uint>)FuncTable[1030])((IntPtr)self, (IntPtr)str, (IntPtr)str_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindow_GetID(ImGuiWindow* self, void* ptr)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[1031])((IntPtr)self, (IntPtr)ptr);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindow_GetID(ImGuiWindow* self, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1032])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindow_GetIDFromPos(ImGuiWindow* self, Vector2 p_abs)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint>)FuncTable[1033])((IntPtr)self, p_abs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, uint>)FuncTable[1034])((IntPtr)self, r_abs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1035])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImGuiWindow_CalcFontSize(ImGuiWindow* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[1036])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1037])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1038])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* ImGuiTabItem_ImGuiTabItem()
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1039])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabItem_ImGuiTabItem_Construct(ImGuiTabItem* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1040])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabItem_destroy(ImGuiTabItem* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1041])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabBar* ImGuiTabBar_ImGuiTabBar()
		{
			return (ImGuiTabBar*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1042])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabBar_ImGuiTabBar_Construct(ImGuiTabBar* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1043])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabBar_destroy(ImGuiTabBar* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1044])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumn* ImGuiTableColumn_ImGuiTableColumn()
		{
			return (ImGuiTableColumn*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1045])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumn_ImGuiTableColumn_Construct(ImGuiTableColumn* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1046])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumn_destroy(ImGuiTableColumn* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1047])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableInstanceData* ImGuiTableInstanceData_ImGuiTableInstanceData()
		{
			return (ImGuiTableInstanceData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1048])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableInstanceData_ImGuiTableInstanceData_Construct(ImGuiTableInstanceData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1049])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableInstanceData_destroy(ImGuiTableInstanceData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1050])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTable* ImGuiTable_ImGuiTable()
		{
			return (ImGuiTable*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1051])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTable_ImGuiTable_Construct(ImGuiTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1052])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTable_destroy(ImGuiTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1053])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableTempData* ImGuiTableTempData_ImGuiTableTempData()
		{
			return (ImGuiTableTempData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1054])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableTempData_ImGuiTableTempData_Construct(ImGuiTableTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1055])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableTempData_destroy(ImGuiTableTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1056])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnSettings* ImGuiTableColumnSettings_ImGuiTableColumnSettings()
		{
			return (ImGuiTableColumnSettings*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1057])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSettings_ImGuiTableColumnSettings_Construct(ImGuiTableColumnSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1058])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1059])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* ImGuiTableSettings_ImGuiTableSettings()
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1060])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSettings_ImGuiTableSettings_Construct(ImGuiTableSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1061])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSettings_destroy(ImGuiTableSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1062])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self)
		{
			return (ImGuiTableColumnSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1063])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIO* igGetIO(ImGuiContext* ctx)
		{
			return (ImGuiIO*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1064])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformIO* igGetPlatformIO(ImGuiContext* ctx)
		{
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1065])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igGetCurrentWindowRead()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1066])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igGetCurrentWindow()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1067])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igFindWindowByID(uint id)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1068])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igFindWindowByName(byte* name)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1069])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiWindowFlags, IntPtr, void>)FuncTable[1070])((IntPtr)window, flags, (IntPtr)parent_window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdateWindowSkipRefresh(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1071])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1072])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte, byte>)FuncTable[1073])((IntPtr)window, (IntPtr)potential_parent, popup_hierarchy, dock_hierarchy);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1074])((IntPtr)window, (IntPtr)potential_parent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1075])((IntPtr)potential_above, (IntPtr)potential_below);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowNavFocusable(ImGuiWindow* window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1076])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowPos(ImGuiWindow* window, Vector2 pos, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[1077])((IntPtr)window, pos, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowSize(ImGuiWindow* window, Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[1078])((IntPtr)window, size, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowCollapsed(ImGuiWindow* window, byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, ImGuiCond, void>)FuncTable[1079])((IntPtr)window, collapsed, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[1080])((IntPtr)window, pos, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1081])((IntPtr)window);
		}

		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parent_window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1082])((IntPtr)window, (IntPtr)parent_window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, void>)FuncTable[1083])((IntPtr)pOut, (IntPtr)window, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, void>)FuncTable[1084])((IntPtr)pOut, (IntPtr)window, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igWindowPosAbsToRel(Vector2* pOut, ImGuiWindow* window, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[1085])((IntPtr)pOut, (IntPtr)window, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igWindowPosRelToAbs(Vector2* pOut, ImGuiWindow* window, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[1086])((IntPtr)pOut, (IntPtr)window, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igFocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiFocusRequestFlags, void>)FuncTable[1087])((IntPtr)window, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, ImGuiFocusRequestFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiFocusRequestFlags, void>)FuncTable[1088])((IntPtr)under_this_window, (IntPtr)ignore_window, (IntPtr)filter_viewport, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBringWindowToFocusFront(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1089])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBringWindowToDisplayFront(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1090])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBringWindowToDisplayBack(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1091])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1092])((IntPtr)window, (IntPtr)above_window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igFindWindowDisplayIndex(ImGuiWindow* window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[1093])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1094])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiWindowRefreshFlags, void>)FuncTable[1095])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCurrentFont(ImFont* font)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1096])((IntPtr)font);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* igGetDefaultFont()
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1097])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushPasswordFont()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1098])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* igGetForegroundDrawList(ImGuiWindow* window)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1099])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igAddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector<ImDrawListPtr>* out_list, ImDrawList* draw_list)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1100])((IntPtr)draw_data, (IntPtr)out_list, (IntPtr)draw_list);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igInitialize()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1101])();
		}

		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShutdown()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1102])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdateInputEvents(byte trickle_fast_inputs)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[1103])(trickle_fast_inputs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdateHoveredWindowAndCaptureFlags()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1104])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igFindHoveredWindowEx(Vector2 pos, byte find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window)
		{
			((delegate* unmanaged[Cdecl]<Vector2, byte, IntPtr, IntPtr, void>)FuncTable[1105])(pos, find_first_and_in_any_viewport, (IntPtr)out_hovered_window, (IntPtr)out_hovered_window_under_moving_window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igStartMouseMovingWindow(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1106])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igStartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[1107])((IntPtr)window, (IntPtr)node, undock);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdateMouseMovingWindowNewFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1108])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igUpdateMouseMovingWindowEndFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1109])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igAddContextHook(ImGuiContext* context, ImGuiContextHook* hook)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[1110])((IntPtr)context, (IntPtr)hook);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRemoveContextHook(ImGuiContext* context, uint hook_to_remove)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[1111])((IntPtr)context, hook_to_remove);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igCallContextHooks(ImGuiContext* context, ImGuiContextHookType type)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiContextHookType, void>)FuncTable[1112])((IntPtr)context, type);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 old_pos, Vector2 new_pos, Vector2 old_size, Vector2 new_size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, void>)FuncTable[1113])((IntPtr)viewport, old_pos, new_pos, old_size, new_size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igScaleWindowsInViewport(ImGuiViewportP* viewport, float scale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1114])((IntPtr)viewport, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDestroyPlatformWindow(ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1115])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1116])((IntPtr)window, (IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1117])((IntPtr)window, (IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformMonitor* igGetViewportPlatformMonitor(ImGuiViewport* viewport)
		{
			return (ImGuiPlatformMonitor*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1118])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewportP* igFindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos)
		{
			return (ImGuiViewportP*)((delegate* unmanaged[Cdecl]<Vector2, IntPtr>)FuncTable[1119])(mouse_platform_pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMarkIniSettingsDirty()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1120])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMarkIniSettingsDirty(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1121])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClearIniSettings()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1122])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igAddSettingsHandler(ImGuiSettingsHandler* handler)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1123])((IntPtr)handler);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRemoveSettingsHandler(byte* type_name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1124])((IntPtr)type_name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name)
		{
			return (ImGuiSettingsHandler*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1125])((IntPtr)type_name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* igCreateNewWindowSettings(byte* name)
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1126])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* igFindWindowSettingsByID(uint id)
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1127])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* igFindWindowSettingsByWindow(ImGuiWindow* window)
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1128])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClearWindowSettings(byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1129])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLocalizeRegisterEntries(ImGuiLocEntry* entries, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1130])((IntPtr)entries, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igLocalizeGetMsg(ImGuiLocKey key)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiLocKey, IntPtr>)FuncTable[1131])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollX(ImGuiWindow* window, float scroll_x)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1132])((IntPtr)window, scroll_x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollY(ImGuiWindow* window, float scroll_y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1133])((IntPtr)window, scroll_y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollFromPosX(ImGuiWindow* window, float local_x, float center_x_ratio)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[1134])((IntPtr)window, local_x, center_x_ratio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetScrollFromPosY(ImGuiWindow* window, float local_y, float center_y_ratio)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[1135])((IntPtr)window, local_y, center_y_ratio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igScrollToItem(ImGuiScrollFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiScrollFlags, void>)FuncTable[1136])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiScrollFlags, void>)FuncTable[1137])((IntPtr)window, rect, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, ImGuiScrollFlags, void>)FuncTable[1138])((IntPtr)pOut, (IntPtr)window, rect, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[1139])((IntPtr)window, rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiItemStatusFlags igGetItemStatusFlags()
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiItemStatusFlags>)FuncTable[1140])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiItemFlags igGetItemFlags()
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiItemFlags>)FuncTable[1141])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetActiveID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1142])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetFocusID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1143])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetActiveID(uint id, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, void>)FuncTable[1144])(id, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetFocusID(uint id, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, void>)FuncTable[1145])(id, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClearActiveID()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1146])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetHoveredID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1147])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetHoveredID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1148])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igKeepAliveID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1149])(id);
		}

		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMarkItemEdited(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1150])(id);
		}

		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushOverrideID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1151])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetIDWithSeed(byte* str_id_begin, byte* str_id_end, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, uint>)FuncTable[1152])((IntPtr)str_id_begin, (IntPtr)str_id_end, seed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetIDWithSeed(int n, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint, uint>)FuncTable[1153])(n, seed);
		}

		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igItemSize(Vector2 size, float text_baseline_y)
		{
			((delegate* unmanaged[Cdecl]<Vector2, float, void>)FuncTable[1154])(size, text_baseline_y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igItemSize(ImRect bb, float text_baseline_y)
		{
			((delegate* unmanaged[Cdecl]<ImRect, float, void>)FuncTable[1155])(bb, text_baseline_y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb, ImGuiItemFlags extra_flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, ImGuiItemFlags, byte>)FuncTable[1156])(bb, id, (IntPtr)nav_bb, extra_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igItemHoverable(ImRect bb, uint id, ImGuiItemFlags item_flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiItemFlags, byte>)FuncTable[1157])(bb, id, item_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiHoveredFlags, byte>)FuncTable[1158])((IntPtr)window, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsClippedEx(ImRect bb, uint id)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, byte>)FuncTable[1159])(bb, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetLastItemData(uint item_id, ImGuiItemFlags item_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiItemFlags, ImGuiItemStatusFlags, ImRect, void>)FuncTable[1160])(item_id, item_flags, status_flags, item_rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, void>)FuncTable[1161])((IntPtr)pOut, size, default_w, default_h);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, float, float>)FuncTable[1162])(pos, wrap_pos_x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushMultiItemsWidths(int components, float width_full)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[1163])(components, width_full);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, float, void>)FuncTable[1164])((IntPtr)items, count, width_excess);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleVarInfo* igGetStyleVarInfo(ImGuiStyleVar idx)
		{
			return (ImGuiStyleVarInfo*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, IntPtr>)FuncTable[1165])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginDisabledOverrideReenable()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1166])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndDisabledOverrideReenable()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1167])();
		}

		/// <summary>
		/// -> BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogBegin(ImGuiLogFlags flags, int auto_open_depth)
		{
			((delegate* unmanaged[Cdecl]<ImGuiLogFlags, int, void>)FuncTable[1168])(flags, auto_open_depth);
		}

		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogToBuffer(int auto_open_depth)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[1169])(auto_open_depth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1170])((IntPtr)ref_pos, (IntPtr)text, (IntPtr)text_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igLogSetNextTextDecoration(byte* prefix, byte* suffix)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1171])((IntPtr)prefix, (IntPtr)suffix);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, Vector2, ImGuiChildFlags, ImGuiWindowFlags, byte>)FuncTable[1172])((IntPtr)name, id, size_arg, child_flags, window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiWindowFlags, byte>)FuncTable[1173])(id, extra_window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginPopupMenuEx(uint id, byte* label, ImGuiWindowFlags extra_window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, IntPtr, ImGuiWindowFlags, byte>)FuncTable[1174])(id, (IntPtr)label, extra_window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiPopupFlags, void>)FuncTable[1175])(id, popup_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup)
		{
			((delegate* unmanaged[Cdecl]<int, byte, void>)FuncTable[1176])(remaining, restore_focus_to_window_under_popup);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[1177])((IntPtr)ref_window, restore_focus_to_window_under_popup);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClosePopupsExceptModals()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1178])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsPopupOpen(uint id, ImGuiPopupFlags popup_flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiPopupFlags, byte>)FuncTable[1179])(id, popup_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1180])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igGetTopMostPopupModal()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1181])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igGetTopMostAndVisiblePopupModal()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1182])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* igFindBlockingModal(ImGuiWindow* window)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1183])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1184])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, IntPtr, ImRect, ImRect, ImGuiPopupPositionPolicy, void>)FuncTable[1185])((IntPtr)pOut, ref_pos, size, (IntPtr)last_dir, r_outer, r_avoid, policy);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiTooltipFlags, ImGuiWindowFlags, byte>)FuncTable[1186])(tooltip_flags, extra_window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTooltipHidden()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1187])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiDir, float, ImGuiWindowFlags, byte>)FuncTable[1188])((IntPtr)name, (IntPtr)viewport, dir, size, window_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginMenuEx(byte* label, byte* icon, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte>)FuncTable[1189])((IntPtr)label, (IntPtr)icon, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, byte, byte>)FuncTable[1190])((IntPtr)label, (IntPtr)icon, (IntPtr)shortcut, selected, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImRect, ImGuiComboFlags, byte>)FuncTable[1191])(popup_id, bb, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginComboPreview()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1192])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndComboPreview()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1193])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavInitWindow(ImGuiWindow* window, byte force_reinit)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[1194])((IntPtr)window, force_reinit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavInitRequestApplyResult()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1195])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igNavMoveRequestButNoResultYet()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1196])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDir, ImGuiDir, ImGuiNavMoveFlags, ImGuiScrollFlags, void>)FuncTable[1197])(move_dir, clip_dir, move_flags, scroll_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDir, ImGuiDir, ImGuiNavMoveFlags, ImGuiScrollFlags, void>)FuncTable[1198])(move_dir, clip_dir, move_flags, scroll_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestResolveWithLastItem(ImGuiNavItemData* result)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1199])((IntPtr)result);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1200])((IntPtr)result, (IntPtr)tree_node_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestCancel()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1201])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestApplyResult()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1202])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiNavMoveFlags, void>)FuncTable[1203])((IntPtr)window, move_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavHighlightActivated(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1204])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavClearPreferredPosForAxis(ImGuiAxis axis)
		{
			((delegate* unmanaged[Cdecl]<ImGuiAxis, void>)FuncTable[1205])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNavCursorVisibleAfterMove()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1206])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igNavUpdateCurrentWindowIsScrollPushableX()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1207])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNavWindow(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1208])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiNavLayer, uint, ImRect, void>)FuncTable[1209])(id, nav_layer, focus_scope_id, rect_rel);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNavFocusScope(uint focus_scope_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1210])(focus_scope_id);
		}

		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igFocusItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1211])();
		}

		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igActivateItemByID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1212])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsNamedKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1213])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsNamedKeyOrMod(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1214])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsLegacyKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1215])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyboardKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1216])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsGamepadKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1217])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1218])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsAliasKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1219])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsLRModKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1220])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKey igFixupKeyChord(ImGuiKey key_chord)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiKey>)FuncTable[1221])(key_chord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKey igConvertSingleModFlagToKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiKey>)FuncTable[1222])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyData* igGetKeyData(ImGuiContext* ctx, ImGuiKey key)
		{
			return (ImGuiKeyData*)((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, IntPtr>)FuncTable[1223])((IntPtr)ctx, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyData* igGetKeyData(ImGuiKey key)
		{
			return (ImGuiKeyData*)((delegate* unmanaged[Cdecl]<ImGuiKey, IntPtr>)FuncTable[1224])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igGetKeyChordName(ImGuiKey key_chord)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiKey, IntPtr>)FuncTable[1225])(key_chord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKey igMouseButtonToKey(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, ImGuiKey>)FuncTable[1226])(button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, float, byte>)FuncTable[1227])(button, lock_threshold);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetKeyMagnitude2d(Vector2* pOut, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, ImGuiKey, ImGuiKey, ImGuiKey, void>)FuncTable[1228])((IntPtr)pOut, key_left, key_right, key_up, key_down);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetNavTweakPressedAmount(ImGuiAxis axis)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiAxis, float>)FuncTable[1229])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float, int>)FuncTable[1230])(t0, t1, repeat_delay, repeat_rate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetTypematicRepeatRate(ImGuiInputFlags flags, float* repeat_delay, float* repeat_rate)
		{
			((delegate* unmanaged[Cdecl]<ImGuiInputFlags, IntPtr, IntPtr, void>)FuncTable[1231])(flags, (IntPtr)repeat_delay, (IntPtr)repeat_rate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTeleportMousePos(Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[1232])(pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetActiveIdUsingAllKeyboardKeys()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1233])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsActiveIdUsingNavDir(ImGuiDir dir)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDir, byte>)FuncTable[1234])(dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetKeyOwner(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint>)FuncTable[1235])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetKeyOwner(ImGuiKey key, uint owner_id, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, uint, ImGuiInputFlags, void>)FuncTable[1236])(key, owner_id, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetKeyOwnersForKeyChord(ImGuiKey key, uint owner_id, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, uint, ImGuiInputFlags, void>)FuncTable[1237])(key, owner_id, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, void>)FuncTable[1238])(key, flags);
		}

		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTestKeyOwner(ImGuiKey key, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1239])(key, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyOwnerData* igGetKeyOwnerData(ImGuiContext* ctx, ImGuiKey key)
		{
			return (ImGuiKeyOwnerData*)((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, IntPtr>)FuncTable[1240])((IntPtr)ctx, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyDown(ImGuiKey key, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1241])(key, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, uint, byte>)FuncTable[1242])(key, flags, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyReleased(ImGuiKey key, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1243])(key, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsKeyChordPressed(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, uint, byte>)FuncTable[1244])(key_chord, flags, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseDown(ImGuiMouseButton button, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, uint, byte>)FuncTable[1245])(button, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, ImGuiInputFlags, uint, byte>)FuncTable[1246])(button, flags, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseReleased(ImGuiMouseButton button, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, uint, byte>)FuncTable[1247])(button, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsMouseDoubleClicked(ImGuiMouseButton button, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, uint, byte>)FuncTable[1248])(button, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igShortcut(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, uint, byte>)FuncTable[1249])(key_chord, flags, owner_id);
		}

		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSetShortcutRouting(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, uint, byte>)FuncTable[1250])(key_chord, flags, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTestShortcutRouting(ImGuiKey key_chord, uint owner_id)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1251])(key_chord, owner_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyRoutingData* igGetShortcutRoutingData(ImGuiKey key_chord)
		{
			return (ImGuiKeyRoutingData*)((delegate* unmanaged[Cdecl]<ImGuiKey, IntPtr>)FuncTable[1252])(key_chord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextInitialize(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1253])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextShutdown(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1254])((IntPtr)ctx);
		}

		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextClearNodes(ImGuiContext* ctx, uint root_id, byte clear_settings_refs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, void>)FuncTable[1255])((IntPtr)ctx, root_id, clear_settings_refs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextRebuildNodes(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1256])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextNewFrameUpdateUndocking(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1257])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextNewFrameUpdateDocking(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1258])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextEndFrame(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1259])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igDockContextGenNodeID(ImGuiContext* ctx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[1260])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, ImGuiDir, float, byte, void>)FuncTable[1261])((IntPtr)ctx, (IntPtr)target, (IntPtr)target_node, (IntPtr)payload, split_dir, split_ratio, split_outer);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1262])((IntPtr)ctx, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1263])((IntPtr)ctx, (IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window, byte clear_persistent_docking_ref)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[1264])((IntPtr)ctx, (IntPtr)window, clear_persistent_docking_ref);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1265])((IntPtr)ctx, (IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, byte split_outer, Vector2* out_pos)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, ImGuiDir, byte, IntPtr, byte>)FuncTable[1266])((IntPtr)target, (IntPtr)target_node, (IntPtr)payload_window, (IntPtr)payload_node, split_dir, split_outer, (IntPtr)out_pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* igDockContextFindNodeByID(ImGuiContext* ctx, uint id)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[1267])((IntPtr)ctx, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockNodeWindowMenuHandler_Default(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1268])((IntPtr)ctx, (IntPtr)node, (IntPtr)tab_bar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDockNodeBeginAmendTabBar(ImGuiDockNode* node)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1269])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockNodeEndAmendTabBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1270])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* igDockNodeGetRootNode(ImGuiDockNode* node)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1271])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1272])((IntPtr)node, (IntPtr)parent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igDockNodeGetDepth(ImGuiDockNode* node)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[1273])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igDockNodeGetWindowMenuButtonId(ImGuiDockNode* node)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[1274])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* igGetWindowDockNode()
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1275])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igGetWindowAlwaysWantOwnTabBar(ImGuiWindow* window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1276])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginDocked(ImGuiWindow* window, byte* p_open)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1277])((IntPtr)window, (IntPtr)p_open);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginDockableDragDropSource(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1278])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginDockableDragDropTarget(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1279])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowDock(ImGuiWindow* window, uint dock_id, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, ImGuiCond, void>)FuncTable[1280])((IntPtr)window, dock_id, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderDockWindow(byte* window_name, uint node_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[1281])((IntPtr)window_name, node_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* igDockBuilderGetNode(uint node_id)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1282])(node_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* igDockBuilderGetCentralNode(uint node_id)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1283])(node_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igDockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiDockNodeFlags, uint>)FuncTable[1284])(node_id, flags);
		}

		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderRemoveNode(uint node_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1285])(node_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderRemoveNodeDockedWindows(uint node_id, byte clear_settings_refs)
		{
			((delegate* unmanaged[Cdecl]<uint, byte, void>)FuncTable[1286])(node_id, clear_settings_refs);
		}

		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderRemoveNodeChildNodes(uint node_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1287])(node_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderSetNodePos(uint node_id, Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<uint, Vector2, void>)FuncTable[1288])(node_id, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderSetNodeSize(uint node_id, Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<uint, Vector2, void>)FuncTable[1289])(node_id, size);
		}

		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igDockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiDir, float, IntPtr, IntPtr, uint>)FuncTable[1290])(node_id, split_dir, size_ratio_for_node_at_dir, (IntPtr)out_id_at_dir, (IntPtr)out_id_at_opposite_dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector<IntPtr>* in_window_remap_pairs)
		{
			((delegate* unmanaged[Cdecl]<uint, uint, IntPtr, void>)FuncTable[1291])(src_dockspace_id, dst_dockspace_id, (IntPtr)in_window_remap_pairs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector<uint>* out_node_remap_pairs)
		{
			((delegate* unmanaged[Cdecl]<uint, uint, IntPtr, void>)FuncTable[1292])(src_node_id, dst_node_id, (IntPtr)out_node_remap_pairs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderCopyWindowSettings(byte* src_name, byte* dst_name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1293])((IntPtr)src_name, (IntPtr)dst_name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDockBuilderFinish(uint node_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1294])(node_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushFocusScope(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1295])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopFocusScope()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1296])();
		}

		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetCurrentFocusScope()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1297])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsDragDropActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1298])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginDragDropTargetCustom(ImRect bb, uint id)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, byte>)FuncTable[1299])(bb, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igClearDragDrop()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1300])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsDragDropPayloadBeingAccepted()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1301])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderDragDropTargetRect(ImRect bb, ImRect item_clip_rect)
		{
			((delegate* unmanaged[Cdecl]<ImRect, ImRect, void>)FuncTable[1302])(bb, item_clip_rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTypingSelectRequest* igGetTypingSelectRequest(ImGuiTypingSelectFlags flags)
		{
			return (ImGuiTypingSelectRequest*)((delegate* unmanaged[Cdecl]<ImGuiTypingSelectFlags, IntPtr>)FuncTable[1303])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, void* get_item_name_func, void* user_data, int nav_item_idx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, int>)FuncTable[1304])((IntPtr)req, items_count, (IntPtr)get_item_name_func, (IntPtr)user_data, nav_item_idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, void* get_item_name_func, void* user_data, int nav_item_idx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int, int>)FuncTable[1305])((IntPtr)req, items_count, (IntPtr)get_item_name_func, (IntPtr)user_data, nav_item_idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, void* get_item_name_func, void* user_data)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int>)FuncTable[1306])((IntPtr)req, items_count, (IntPtr)get_item_name_func, (IntPtr)user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginBoxSelect(ImRect scope_rect, ImGuiWindow* window, uint box_select_id, ImGuiMultiSelectFlags ms_flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, IntPtr, uint, ImGuiMultiSelectFlags, byte>)FuncTable[1307])(scope_rect, (IntPtr)window, box_select_id, ms_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndBoxSelect(ImRect scope_rect, ImGuiMultiSelectFlags ms_flags)
		{
			((delegate* unmanaged[Cdecl]<ImRect, ImGuiMultiSelectFlags, void>)FuncTable[1308])(scope_rect, ms_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMultiSelectItemHeader(uint id, byte* p_selected, ImGuiButtonFlags* p_button_flags)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr, void>)FuncTable[1309])(id, (IntPtr)p_selected, (IntPtr)p_button_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMultiSelectItemFooter(uint id, byte* p_selected, byte* p_pressed)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr, void>)FuncTable[1310])(id, (IntPtr)p_selected, (IntPtr)p_pressed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[1311])((IntPtr)ms, selected);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igMultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int range_dir, long first_item, long last_item)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, int, long, long, void>)FuncTable[1312])((IntPtr)ms, selected, range_dir, first_item, last_item);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiBoxSelectState* igGetBoxSelectState(uint id)
		{
			return (ImGuiBoxSelectState*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1313])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectState* igGetMultiSelectState(uint id)
		{
			return (ImGuiMultiSelectState*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1314])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[1315])((IntPtr)window, clip_rect);
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImGuiOldColumnFlags, void>)FuncTable[1316])((IntPtr)str_id, count, flags);
		}

		/// <summary>
		/// close columns<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndColumns()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1317])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushColumnClipRect(int column_index)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[1318])(column_index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPushColumnsBackground()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1319])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igPopColumnsBackground()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1320])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetColumnsID(byte* str_id, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1321])((IntPtr)str_id, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id)
		{
			return (ImGuiOldColumns*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[1322])((IntPtr)window, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, float>)FuncTable[1323])((IntPtr)columns, offset_norm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, float>)FuncTable[1324])((IntPtr)columns, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableOpenContextMenu(int column_n)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[1325])(column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetColumnWidth(int column_n, float width)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[1326])(column_n, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs)
		{
			((delegate* unmanaged[Cdecl]<int, ImGuiSortDirection, byte, void>)FuncTable[1327])(column_n, sort_direction, append_to_sort_specs);
		}

		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTableGetHoveredRow()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[1328])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igTableGetHeaderRowHeight()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1329])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igTableGetHeaderAngledMaxLabelWidth()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1330])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTablePushBackgroundChannel()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1331])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTablePopBackgroundChannel()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1332])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableAngledHeadersRowEx(uint row_id, float angle, float max_label_width, ImGuiTableHeaderData* data, int data_count)
		{
			((delegate* unmanaged[Cdecl]<uint, float, float, IntPtr, int, void>)FuncTable[1333])(row_id, angle, max_label_width, (IntPtr)data, data_count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTable* igGetCurrentTable()
		{
			return (ImGuiTable*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1334])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTable* igTableFindByID(uint id)
		{
			return (ImGuiTable*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1335])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, int, ImGuiTableFlags, Vector2, float, byte>)FuncTable[1336])((IntPtr)name, id, columns_count, flags, outer_size, inner_width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableBeginInitMemory(ImGuiTable* table, int columns_count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1337])((IntPtr)table, columns_count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableBeginApplyRequests(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1338])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetupDrawChannels(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1339])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableUpdateLayout(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1340])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableUpdateBorders(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1341])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1342])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableDrawBorders(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1343])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flags_for_section_to_display)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTableFlags, void>)FuncTable[1344])((IntPtr)table, flags_for_section_to_display);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTableBeginContextMenuPopup(ImGuiTable* table)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1345])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableMergeDrawChannels(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1346])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableInstanceData* igTableGetInstanceData(ImGuiTable* table, int instance_no)
		{
			return (ImGuiTableInstanceData*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[1347])((IntPtr)table, instance_no);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igTableGetInstanceID(ImGuiTable* table, int instance_no)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1348])((IntPtr)table, instance_no);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSortSpecsSanitize(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1349])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSortSpecsBuild(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1350])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiSortDirection>)FuncTable[1351])((IntPtr)column);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1352])((IntPtr)table, (IntPtr)column);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float>)FuncTable[1353])((IntPtr)table, (IntPtr)column);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableBeginRow(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1354])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableEndRow(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1355])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableBeginCell(ImGuiTable* table, int column_n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1356])((IntPtr)table, column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableEndCell(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1357])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int column_n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[1358])((IntPtr)pOut, (IntPtr)table, column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igTableGetColumnName(ImGuiTable* table, int column_n)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[1359])((IntPtr)table, column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int, uint>)FuncTable[1360])((IntPtr)table, column_n, instance_no);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igTableCalcMaxColumnWidth(ImGuiTable* table, int column_n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, float>)FuncTable[1361])((IntPtr)table, column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1362])((IntPtr)table, column_n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSetColumnWidthAutoAll(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1363])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableRemove(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1364])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableGcCompactTransientBuffers(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1365])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableGcCompactTransientBuffers(ImGuiTableTempData* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1366])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableGcCompactSettings()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1367])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableLoadSettings(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1368])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSaveSettings(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1369])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableResetSettings(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1370])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table)
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1371])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTableSettingsAddSettingsHandler()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1372])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count)
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<uint, int, IntPtr>)FuncTable[1373])(id, columns_count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* igTableSettingsFindByID(uint id)
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1374])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabBar* igGetCurrentTabBar()
		{
			return (ImGuiTabBar*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1375])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiTabBarFlags, byte>)FuncTable[1376])((IntPtr)tab_bar, bb, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[1377])((IntPtr)tab_bar, tab_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* igTabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[1378])((IntPtr)tab_bar, order);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* igTabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1379])((IntPtr)tab_bar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* igTabBarGetCurrentTab(ImGuiTabBar* tab_bar)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1380])((IntPtr)tab_bar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igTabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[1381])((IntPtr)tab_bar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igTabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[1382])((IntPtr)tab_bar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabItemFlags, IntPtr, void>)FuncTable[1383])((IntPtr)tab_bar, tab_flags, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[1384])((IntPtr)tab_bar, tab_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1385])((IntPtr)tab_bar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1386])((IntPtr)tab_bar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarQueueFocus(ImGuiTabBar* tab_bar, byte* tab_name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1387])((IntPtr)tab_bar, (IntPtr)tab_name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[1388])((IntPtr)tab_bar, (IntPtr)tab, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[1389])((IntPtr)tab_bar, (IntPtr)tab, mouse_pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTabBarProcessReorder(ImGuiTabBar* tab_bar)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1390])((IntPtr)tab_bar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiTabItemFlags, IntPtr, byte>)FuncTable[1391])((IntPtr)tab_bar, (IntPtr)label, (IntPtr)p_open, flags, (IntPtr)docked_window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabItemSpacing(byte* str_id, ImGuiTabItemFlags flags, float width)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabItemFlags, float, void>)FuncTable[1392])((IntPtr)str_id, flags, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabItemCalcSize(Vector2* pOut, byte* label, byte has_close_button_or_unsaved_marker)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[1393])((IntPtr)pOut, (IntPtr)label, has_close_button_or_unsaved_marker);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabItemCalcSize(Vector2* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1394])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiTabItemFlags, uint, void>)FuncTable[1395])((IntPtr)draw_list, bb, flags, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiTabItemFlags, Vector2, IntPtr, uint, uint, byte, IntPtr, IntPtr, void>)FuncTable[1396])((IntPtr)draw_list, bb, flags, frame_padding, (IntPtr)label, tab_id, close_button_id, is_contents_visible, (IntPtr)out_just_closed, (IntPtr)out_text_clipped);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash)
		{
			((delegate* unmanaged[Cdecl]<Vector2, IntPtr, IntPtr, byte, void>)FuncTable[1397])(pos, (IntPtr)text, (IntPtr)text_end, hide_text_after_hash);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width)
		{
			((delegate* unmanaged[Cdecl]<Vector2, IntPtr, IntPtr, float, void>)FuncTable[1398])(pos, (IntPtr)text, (IntPtr)text_end, wrap_width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, IntPtr, IntPtr, IntPtr, Vector2, IntPtr, void>)FuncTable[1399])(pos_min, pos_max, (IntPtr)text, (IntPtr)text_end, (IntPtr)text_size_if_known, align, (IntPtr)clip_rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, IntPtr, IntPtr, IntPtr, Vector2, IntPtr, void>)FuncTable[1400])((IntPtr)draw_list, pos_min, pos_max, (IntPtr)text, (IntPtr)text_end, (IntPtr)text_size_if_known, align, (IntPtr)clip_rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[1401])((IntPtr)draw_list, pos_min, pos_max, clip_max_x, ellipsis_max_x, (IntPtr)text, (IntPtr)text_end, (IntPtr)text_size_if_known);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte borders, float rounding)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, uint, byte, float, void>)FuncTable[1402])(p_min, p_max, fill_col, borders, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, float, void>)FuncTable[1403])(p_min, p_max, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, Vector2, float, ImDrawFlags, void>)FuncTable[1404])((IntPtr)draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
		}

		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiNavRenderCursorFlags, void>)FuncTable[1405])(bb, id, flags);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* igFindRenderedTextEnd(byte* text, byte* text_end)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[1406])((IntPtr)text, (IntPtr)text_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow)
		{
			((delegate* unmanaged[Cdecl]<Vector2, float, ImGuiMouseCursor, uint, uint, uint, void>)FuncTable[1407])(pos, scale, mouse_cursor, col_fill, col_border, col_shadow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, ImGuiDir, float, void>)FuncTable[1408])((IntPtr)draw_list, pos, col, dir, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, void>)FuncTable[1409])((IntPtr)draw_list, pos, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, float, void>)FuncTable[1410])((IntPtr)draw_list, pos, col, sz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, ImGuiDir, uint, void>)FuncTable[1411])((IntPtr)draw_list, pos, half_sz, direction, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, void>)FuncTable[1412])((IntPtr)draw_list, p_min, sz, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, uint, float, float, float, void>)FuncTable[1413])((IntPtr)draw_list, rect, col, x_start_norm, x_end_norm, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImRect, uint, float, void>)FuncTable[1414])((IntPtr)draw_list, outer, inner, col, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawFlags igCalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, ImRect, float, ImDrawFlags>)FuncTable[1415])(r_in, r_outer, threshold);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiTextFlags, void>)FuncTable[1416])((IntPtr)text, (IntPtr)text_end, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiButtonFlags, byte>)FuncTable[1417])((IntPtr)label, size_arg, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDir, Vector2, ImGuiButtonFlags, byte>)FuncTable[1418])((IntPtr)str_id, dir, size_arg, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImageButtonEx(uint id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, IntPtr, Vector2, Vector2, Vector2, Vector4, Vector4, ImGuiButtonFlags, byte>)FuncTable[1419])(id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSeparatorEx(ImGuiSeparatorFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<ImGuiSeparatorFlags, float, void>)FuncTable[1420])(flags, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSeparatorTextEx(uint id, byte* label, byte* label_end, float extra_width)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr, float, void>)FuncTable[1421])(id, (IntPtr)label, (IntPtr)label_end, extra_width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCheckboxFlags(byte* label, long* flags, long flags_value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, byte>)FuncTable[1422])((IntPtr)label, (IntPtr)flags, flags_value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCheckboxFlags(byte* label, ulong* flags, ulong flags_value)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ulong, byte>)FuncTable[1423])((IntPtr)label, (IntPtr)flags, flags_value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCloseButton(uint id, Vector2 pos)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, byte>)FuncTable[1424])(id, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igCollapseButton(uint id, Vector2 pos, ImGuiDockNode* dock_node)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, IntPtr, byte>)FuncTable[1425])(id, pos, (IntPtr)dock_node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igScrollbar(ImGuiAxis axis)
		{
			((delegate* unmanaged[Cdecl]<ImGuiAxis, void>)FuncTable[1426])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags draw_rounding_flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiAxis, IntPtr, long, long, ImDrawFlags, byte>)FuncTable[1427])(bb, id, axis, (IntPtr)p_scroll_v, avail_v, contents_v, draw_rounding_flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiAxis, void>)FuncTable[1428])((IntPtr)pOut, (IntPtr)window, axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiAxis, uint>)FuncTable[1429])((IntPtr)window, axis);
		}

		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetWindowResizeCornerID(ImGuiWindow* window, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1430])((IntPtr)window, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDir, uint>)FuncTable[1431])((IntPtr)window, dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, IntPtr, ImGuiButtonFlags, byte>)FuncTable[1432])(bb, id, (IntPtr)out_hovered, (IntPtr)out_held, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiDataType, IntPtr, float, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[1433])(id, data_type, (IntPtr)p_v, v_speed, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, IntPtr, byte>)FuncTable[1434])(bb, id, data_type, (IntPtr)p_v, (IntPtr)p_min, (IntPtr)p_max, (IntPtr)format, flags, (IntPtr)out_grab_bb);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiAxis, IntPtr, IntPtr, float, float, float, float, uint, byte>)FuncTable[1435])(bb, id, axis, (IntPtr)size1, (IntPtr)size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiTreeNodeFlags, IntPtr, IntPtr, byte>)FuncTable[1436])(id, flags, (IntPtr)label, (IntPtr)label_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTreePushOverrideID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1437])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNodeGetOpen(uint storage_id)
		{
			return ((delegate* unmanaged[Cdecl]<uint, byte>)FuncTable[1438])(storage_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igTreeNodeSetOpen(uint storage_id, byte open)
		{
			((delegate* unmanaged[Cdecl]<uint, byte, void>)FuncTable[1439])(storage_id, open);
		}

		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTreeNodeUpdateNextOpen(uint storage_id, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiTreeNodeFlags, byte>)FuncTable[1440])(storage_id, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type)
		{
			return (ImGuiDataTypeInfo*)((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr>)FuncTable[1441])(data_type);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ImGuiDataType, IntPtr, IntPtr, int>)FuncTable[1442])((IntPtr)buf, buf_size, data_type, (IntPtr)p_data, (IntPtr)format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDataType, int, IntPtr, IntPtr, IntPtr, void>)FuncTable[1443])(data_type, op, (IntPtr)output, (IntPtr)arg_1, (IntPtr)arg_2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format, void* p_data_when_empty)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1444])((IntPtr)buf, data_type, (IntPtr)p_data, (IntPtr)format, (IntPtr)p_data_when_empty);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, IntPtr, int>)FuncTable[1445])(data_type, (IntPtr)arg_1, (IntPtr)arg_2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1446])(data_type, (IntPtr)p_data, (IntPtr)p_min, (IntPtr)p_max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDataTypeIsZero(ImGuiDataType data_type, void* p_data)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, byte>)FuncTable[1447])(data_type, (IntPtr)p_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, void* callback, void* user_data)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, Vector2, ImGuiInputTextFlags, IntPtr, IntPtr, byte>)FuncTable[1448])((IntPtr)label, (IntPtr)hint, (IntPtr)buf, buf_size, size_arg, flags, (IntPtr)callback, (IntPtr)user_data);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igInputTextDeactivateHook(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1449])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, IntPtr, int, ImGuiInputTextFlags, byte>)FuncTable[1450])(bb, id, (IntPtr)label, (IntPtr)buf, buf_size, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1451])(bb, id, (IntPtr)label, data_type, (IntPtr)p_data, (IntPtr)format, (IntPtr)p_clamp_min, (IntPtr)p_clamp_max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igTempInputIsActive(uint id)
		{
			return ((delegate* unmanaged[Cdecl]<uint, byte>)FuncTable[1452])(id);
		}

		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextState* igGetInputTextState(uint id)
		{
			return (ImGuiInputTextState*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1453])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igSetNextItemRefVal(ImGuiDataType data_type, void* p_data)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, void>)FuncTable[1454])(data_type, (IntPtr)p_data);
		}

		/// <summary>
		/// This may be useful to apply workaround that a based on distinguish whenever an item is active as a text input field.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igIsItemActiveAsInputText()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1455])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, void>)FuncTable[1456])((IntPtr)text, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiColorEditFlags, void>)FuncTable[1457])((IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiColorEditFlags, void>)FuncTable[1458])((IntPtr)ref_col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int igPlotEx(ImGuiPlotType plot_type, byte* label, void* values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 size_arg)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiPlotType, IntPtr, IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, int>)FuncTable[1459])(plot_type, (IntPtr)label, (IntPtr)values_getter, (IntPtr)data, values_count, values_offset, (IntPtr)overlay_text, scale_min, scale_max, size_arg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, Vector2, uint, uint, void>)FuncTable[1460])((IntPtr)draw_list, vert_start_idx, vert_end_idx, gradient_p0, gradient_p1, col0, col1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, Vector2, Vector2, Vector2, byte, void>)FuncTable[1461])((IntPtr)draw_list, vert_start_idx, vert_end_idx, a, b, uv_a, uv_b, clamp);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 pivot_in, float cos_a, float sin_a, Vector2 pivot_out)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, float, float, Vector2, void>)FuncTable[1462])((IntPtr)draw_list, vert_start_idx, vert_end_idx, pivot_in, cos_a, sin_a, pivot_out);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGcCompactTransientMiscBuffers()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1463])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGcCompactTransientWindowBuffers(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1464])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igGcAwakeTransientWindowBuffers(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1465])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igErrorLog(byte* msg)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1466])((IntPtr)msg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1467])((IntPtr)state_out);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* state_in)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1468])((IntPtr)state_in);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* state_in)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1469])((IntPtr)state_in);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igErrorCheckUsingSetCursorPosToExtendParentBoundaries()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1470])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igErrorCheckEndFrameFinalizeErrorTooltip()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1471])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igBeginErrorTooltip()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1472])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igEndErrorTooltip()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1473])();
		}

		/// <summary>
		/// size >= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, uint size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, uint, void>)FuncTable[1474])((IntPtr)info, frame_count, (IntPtr)ptr, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugDrawCursorPos(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1475])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugDrawLineExtents(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1476])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugDrawItemRect(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1477])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugTextUnformattedWithLocateItem(byte* line_begin, byte* line_end)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1478])((IntPtr)line_begin, (IntPtr)line_end);
		}

		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugLocateItem(uint target_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1479])(target_id);
		}

		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugLocateItemOnHover(uint target_id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1480])(target_id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugLocateItemResolveWithLastItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1481])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugBreakClearData()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1482])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igDebugBreakButton(byte* label, byte* description_of_location)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1483])((IntPtr)label, (IntPtr)description_of_location);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugBreakButtonTooltip(byte keyboard_only, byte* description_of_location)
		{
			((delegate* unmanaged[Cdecl]<byte, IntPtr, void>)FuncTable[1484])(keyboard_only, (IntPtr)description_of_location);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igShowFontAtlas(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1485])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugHookIdInfo(uint id, ImGuiDataType data_type, void* data_id, void* data_id_end)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiDataType, IntPtr, IntPtr, void>)FuncTable[1486])(id, data_type, (IntPtr)data_id, (IntPtr)data_id_end);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeColumns(ImGuiOldColumns* columns)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1487])((IntPtr)columns);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeDockNode(ImGuiDockNode* node, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1488])((IntPtr)node, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* draw_list, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[1489])((IntPtr)window, (IntPtr)viewport, (IntPtr)draw_list, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, byte, void>)FuncTable[1490])((IntPtr)out_draw_list, (IntPtr)draw_list, (IntPtr)draw_cmd, show_mesh, show_aabb);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeFont(ImFont* font)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1491])((IntPtr)font);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1492])((IntPtr)font, (IntPtr)glyph);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeStorage(ImGuiStorage* storage, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1493])((IntPtr)storage, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1494])((IntPtr)tab_bar, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeTable(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1495])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeTableSettings(ImGuiTableSettings* settings)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1496])((IntPtr)settings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeInputTextState(ImGuiInputTextState* state)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1497])((IntPtr)state);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeTypingSelectState(ImGuiTypingSelectState* state)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1498])((IntPtr)state);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeMultiSelectState(ImGuiMultiSelectState* state)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1499])((IntPtr)state);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeWindow(ImGuiWindow* window, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1500])((IntPtr)window, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeWindowSettings(ImGuiWindowSettings* settings)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1501])((IntPtr)settings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeWindowsList(ImVector<ImGuiWindowPtr>* windows, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1502])((IntPtr)windows, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, void>)FuncTable[1503])((IntPtr)windows, windows_size, (IntPtr)parent_in_begin_stack);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodeViewport(ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1504])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, byte* label, int idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[1505])((IntPtr)monitor, (IntPtr)label, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugRenderKeyboardPreview(ImDrawList* draw_list)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1506])((IntPtr)draw_list);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, void>)FuncTable[1507])((IntPtr)draw_list, (IntPtr)viewport, bb);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr* igImFontAtlasGetBuilderForStbTruetype()
		{
			return (IntPtr*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1508])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasUpdateSourcesPointers(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1509])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildInit(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1510])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* src, float ascent, float descent)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, void>)FuncTable[1511])((IntPtr)atlas, (IntPtr)font, (IntPtr)src, ascent, descent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1512])((IntPtr)atlas, (IntPtr)stbrp_context_opaque);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildFinish(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1513])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, IntPtr, byte, byte, void>)FuncTable[1514])((IntPtr)atlas, x, y, w, h, (IntPtr)in_str, in_marker_char, in_marker_pixel_value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, IntPtr, byte, uint, void>)FuncTable[1515])((IntPtr)atlas, x, y, w, h, (IntPtr)in_str, in_marker_char, in_marker_pixel_value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1516])((IntPtr)out_table, in_multiply_factor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, int, int, void>)FuncTable[1517])((IntPtr)table, (IntPtr)pixels, x, y, w, h, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void igImFontAtlasBuildGetOversampleFactors(ImFontConfig* src, int* out_oversample_h, int* out_oversample_v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1518])((IntPtr)src, (IntPtr)out_oversample_h, (IntPtr)out_oversample_v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte igImFontAtlasGetMouseCursorTexData(ImFontAtlas* atlas, ImGuiMouseCursor cursor_type, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseCursor, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1519])((IntPtr)atlas, cursor_type, (IntPtr)out_offset, (IntPtr)out_size, (IntPtr)out_uv_border, (IntPtr)out_uv_fill);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1520])((IntPtr)self, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGET_FLT_MAX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1521])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float igGET_FLT_MIN()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1522])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVector<ushort>* ImVector_ImWchar_create()
		{
			return (ImVector<ushort>*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1523])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVector_ImWchar_destroy(ImVector<ushort>* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1524])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVector_ImWchar_Init(ImVector<ushort>* p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1525])((IntPtr)p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVector_ImWchar_UnInit(ImVector<ushort>* p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1526])((IntPtr)p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIO_Set_Platform_GetWindowPos(ImGuiPlatformIO* platform_io, void* user_callback)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1527])((IntPtr)platform_io, (IntPtr)user_callback);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIO_Set_Platform_GetWindowSize(ImGuiPlatformIO* platform_io, void* user_callback)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1528])((IntPtr)platform_io, (IntPtr)user_callback);
		}

	}
}

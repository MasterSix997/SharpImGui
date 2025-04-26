using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public static unsafe partial class ImGui
	{
		public static ImGuiContextPtr CreateContext(ImFontAtlasPtr sharedFontAtlas)
		{
			return ImGuiNative.CreateContext(sharedFontAtlas);
		}

		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		public static void DestroyContext(ImGuiContextPtr ctx)
		{
			ImGuiNative.DestroyContext(ctx);
		}

		public static ImGuiContextPtr GetCurrentContext()
		{
			return ImGuiNative.GetCurrentContext();
		}

		public static void SetCurrentContext(ImGuiContextPtr ctx)
		{
			ImGuiNative.SetCurrentContext(ctx);
		}

		public static ImGuiIOPtr GetIO()
		{
			return ImGuiNative.GetIO();
		}

		public static ImGuiPlatformIOPtr GetPlatformIO()
		{
			return ImGuiNative.GetPlatformIO();
		}

		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		public static ImGuiStylePtr GetStyle()
		{
			return ImGuiNative.GetStyle();
		}

		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		public static void NewFrame()
		{
			ImGuiNative.NewFrame();
		}

		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		public static void EndFrame()
		{
			ImGuiNative.EndFrame();
		}

		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		public static void Render()
		{
			ImGuiNative.Render();
		}

		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		public static ImDrawDataPtr GetDrawData()
		{
			return ImGuiNative.GetDrawData();
		}

		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		public static void ShowDemoWindow(ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImGuiNative.ShowDemoWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		public static void ShowMetricsWindow(ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImGuiNative.ShowMetricsWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		public static void ShowDebugLogWindow(ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImGuiNative.ShowDebugLogWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		public static void ShowIdStackToolWindow(ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImGuiNative.ShowIdStackToolWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		public static void ShowAboutWindow(ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImGuiNative.ShowAboutWindow(native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		public static void ShowStyleEditor(ImGuiStylePtr _ref)
		{
			ImGuiNative.ShowStyleEditor(_ref);
		}

		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		public static byte ShowStyleSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.ShowStyleSelector(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		public static void ShowFontSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ShowFontSelector(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		public static void ShowUserGuide()
		{
			ImGuiNative.ShowUserGuide();
		}

		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		public static ref byte GetVersion()
		{
			var nativeResult = ImGuiNative.GetVersion();
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		public static void StyleColorsDark(ImGuiStylePtr dst)
		{
			ImGuiNative.StyleColorsDark(dst);
		}

		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		public static void StyleColorsLht(ImGuiStylePtr dst)
		{
			ImGuiNative.StyleColorsLht(dst);
		}

		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		public static void StyleColorsClassic(ImGuiStylePtr dst)
		{
			ImGuiNative.StyleColorsClassic(dst);
		}

		public static byte Begin(ReadOnlySpan<char> name, ReadOnlySpan<char> pOpen, ImGuiWindowFlags flags)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			return ImGuiNative.Begin(native_name, native_pOpen, flags);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		public static void End()
		{
			ImGuiNative.End();
		}

		public static byte BeginChild(ReadOnlySpan<char> strId, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginChild(native_strId, size, childFlags, windowFlags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static byte BeginChild(uint id, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			return ImGuiNative.BeginChild(id, size, childFlags, windowFlags);
		}

		public static void EndChild()
		{
			ImGuiNative.EndChild();
		}

		public static byte IsWindowAppearing()
		{
			return ImGuiNative.IsWindowAppearing();
		}

		public static byte IsWindowCollapsed()
		{
			return ImGuiNative.IsWindowCollapsed();
		}

		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		public static byte IsWindowFocused(ImGuiFocusedFlags flags)
		{
			return ImGuiNative.IsWindowFocused(flags);
		}

		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		public static byte IsWindowHovered(ImGuiHoveredFlags flags)
		{
			return ImGuiNative.IsWindowHovered(flags);
		}

		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		public static ImDrawListPtr GetWindowDrawList()
		{
			return ImGuiNative.GetWindowDrawList();
		}

		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		public static float GetWindowDpiScale()
		{
			return ImGuiNative.GetWindowDpiScale();
		}

		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static void GetWindowPos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetWindowPos(native_pOut);
			}
		}

		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static void GetWindowSize(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetWindowSize(native_pOut);
			}
		}

		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		public static float GetWindowWidth()
		{
			return ImGuiNative.GetWindowWidth();
		}

		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		public static float GetWindowHeht()
		{
			return ImGuiNative.GetWindowHeht();
		}

		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		public static ImGuiViewportPtr GetWindowViewport()
		{
			return ImGuiNative.GetWindowViewport();
		}

		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
		{
			ImGuiNative.SetNextWindowPos(pos, cond, pivot);
		}

		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.SetNextWindowSize(size, cond);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 sizeMin, Vector2 sizeMax, ImGuiSizeCallback customCallback, IntPtr customCallbackData)
		{
			ImGuiNative.SetNextWindowSizeConstraints(sizeMin, sizeMax, customCallback, (void*)customCallbackData);
		}

		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowContentSize(Vector2 size)
		{
			ImGuiNative.SetNextWindowContentSize(size);
		}

		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetNextWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowFocus()
		{
			ImGuiNative.SetNextWindowFocus();
		}

		/// <summary>
		/// set next window scrolling value (use &lt; 0.0f to not affect a given axis).<br/>
		/// </summary>
		public static void SetNextWindowScroll(Vector2 scroll)
		{
			ImGuiNative.SetNextWindowScroll(scroll);
		}

		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		public static void SetNextWindowBgAlpha(float alpha)
		{
			ImGuiNative.SetNextWindowBgAlpha(alpha);
		}

		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		public static void SetNextWindowViewport(uint viewportId)
		{
			ImGuiNative.SetNextWindowViewport(viewportId);
		}

		public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
		{
			ImGuiNative.SetWindowPos(pos, cond);
		}

		public static void SetWindowSize(Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.SetWindowSize(size, cond);
		}

		public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		public static void SetWindowFocus()
		{
			ImGuiNative.SetWindowFocus();
		}

		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		public static void SetWindowFontScale(float scale)
		{
			ImGuiNative.SetWindowFontScale(scale);
		}

		public static void SetWindowPos(ReadOnlySpan<char> name, Vector2 pos, ImGuiCond cond)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.SetWindowPos(native_name, pos, cond);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void SetWindowSize(ReadOnlySpan<char> name, Vector2 size, ImGuiCond cond)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.SetWindowSize(native_name, size, cond);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void SetWindowCollapsed(ReadOnlySpan<char> name, bool collapsed, ImGuiCond cond)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetWindowCollapsed(native_name, native_collapsed, cond);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void SetWindowFocus(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.SetWindowFocus(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		public static float GetScrollX()
		{
			return ImGuiNative.GetScrollX();
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		public static float GetScrollY()
		{
			return ImGuiNative.GetScrollY();
		}

		public static void SetScrollX(float scrollX)
		{
			ImGuiNative.SetScrollX(scrollX);
		}

		public static void SetScrollY(float scrollY)
		{
			ImGuiNative.SetScrollY(scrollY);
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		public static float GetScrollMaxX()
		{
			return ImGuiNative.GetScrollMaxX();
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		public static float GetScrollMaxY()
		{
			return ImGuiNative.GetScrollMaxY();
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static void SetScrollHereX(float centerXRatio)
		{
			ImGuiNative.SetScrollHereX(centerXRatio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static void SetScrollHereY(float centerYRatio)
		{
			ImGuiNative.SetScrollHereY(centerYRatio);
		}

		public static void SetScrollFromPosX(float localX, float centerXRatio)
		{
			ImGuiNative.SetScrollFromPosX(localX, centerXRatio);
		}

		public static void SetScrollFromPosY(float localY, float centerYRatio)
		{
			ImGuiNative.SetScrollFromPosY(localY, centerYRatio);
		}

		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		public static void PushFont(ImFontPtr font)
		{
			ImGuiNative.PushFont(font);
		}

		public static void PopFont()
		{
			ImGuiNative.PopFont();
		}

		public static void PushStyleColor(ImGuiCol idx, uint col)
		{
			ImGuiNative.PushStyleColor(idx, col);
		}

		public static void PushStyleColor(ImGuiCol idx, Vector4 col)
		{
			ImGuiNative.PushStyleColor(idx, col);
		}

		public static void PopStyleColor(int count)
		{
			ImGuiNative.PopStyleColor(count);
		}

		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		public static void PushStyleVar(ImGuiStyleVar idx, float val)
		{
			ImGuiNative.PushStyleVar(idx, val);
		}

		public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val)
		{
			ImGuiNative.PushStyleVar(idx, val);
		}

		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static void PushStyleVarX(ImGuiStyleVar idx, float valX)
		{
			ImGuiNative.PushStyleVarX(idx, valX);
		}

		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static void PushStyleVarY(ImGuiStyleVar idx, float valY)
		{
			ImGuiNative.PushStyleVarY(idx, valY);
		}

		public static void PopStyleVar(int count)
		{
			ImGuiNative.PopStyleVar(count);
		}

		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		public static void PushItemFlag(ImGuiItemFlags option, bool enabled)
		{
			var native_enabled = enabled ? (byte)1 : (byte)0;
			ImGuiNative.PushItemFlag(option, native_enabled);
		}

		public static void PopItemFlag()
		{
			ImGuiNative.PopItemFlag();
		}

		/// <summary>
		/// push width of items for common large "item+label" widgets. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		public static void PushItemWidth(float itemWidth)
		{
			ImGuiNative.PushItemWidth(itemWidth);
		}

		public static void PopItemWidth()
		{
			ImGuiNative.PopItemWidth();
		}

		/// <summary>
		/// set width of the _next_ common large "item+label" widget. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		public static void SetNextItemWidth(float itemWidth)
		{
			ImGuiNative.SetNextItemWidth(itemWidth);
		}

		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		public static float CalcItemWidth()
		{
			return ImGuiNative.CalcItemWidth();
		}

		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		public static void PushTextWrapPos(float wrapLocalPosX)
		{
			ImGuiNative.PushTextWrapPos(wrapLocalPosX);
		}

		public static void PopTextWrapPos()
		{
			ImGuiNative.PopTextWrapPos();
		}

		/// <summary>
		/// get current font<br/>
		/// </summary>
		public static ImFontPtr GetFont()
		{
			return ImGuiNative.GetFont();
		}

		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		public static float GetFontSize()
		{
			return ImGuiNative.GetFontSize();
		}

		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		public static void GetFontTexUvWhitePixel(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetFontTexUvWhitePixel(native_pOut);
			}
		}

		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static uint GetColorU32(ImGuiCol idx, float alphaMul)
		{
			return ImGuiNative.GetColorU32(idx, alphaMul);
		}

		public static uint GetColorU32(Vector4 col)
		{
			return ImGuiNative.GetColorU32(col);
		}

		public static uint GetColorU32(uint col, float alphaMul)
		{
			return ImGuiNative.GetColorU32(col, alphaMul);
		}

		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		public static ref Vector4 GetStyleColorVec4(ImGuiCol idx)
		{
			var nativeResult = ImGuiNative.GetStyleColorVec4(idx);
			return ref *(Vector4*)&nativeResult;
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		public static void GetCursorScreenPos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetCursorScreenPos(native_pOut);
			}
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static void SetCursorScreenPos(Vector2 pos)
		{
			ImGuiNative.SetCursorScreenPos(pos);
		}

		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static void GetContentRegionAvail(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetContentRegionAvail(native_pOut);
			}
		}

		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		public static void GetCursorPos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetCursorPos(native_pOut);
			}
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static float GetCursorPosX()
		{
			return ImGuiNative.GetCursorPosX();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static float GetCursorPosY()
		{
			return ImGuiNative.GetCursorPosY();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static void SetCursorPos(Vector2 localPos)
		{
			ImGuiNative.SetCursorPos(localPos);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static void SetCursorPosX(float localX)
		{
			ImGuiNative.SetCursorPosX(localX);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static void SetCursorPosY(float localY)
		{
			ImGuiNative.SetCursorPosY(localY);
		}

		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		public static void GetCursorStartPos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetCursorStartPos(native_pOut);
			}
		}

		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		public static void Separator()
		{
			ImGuiNative.Separator();
		}

		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		public static void SameLine(float offsetFromStartX, float spacing)
		{
			ImGuiNative.SameLine(offsetFromStartX, spacing);
		}

		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		public static void NewLine()
		{
			ImGuiNative.NewLine();
		}

		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		public static void Spacing()
		{
			ImGuiNative.Spacing();
		}

		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		public static void Dummy(Vector2 size)
		{
			ImGuiNative.Dummy(size);
		}

		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		public static void Indent(float indentW)
		{
			ImGuiNative.Indent(indentW);
		}

		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		public static void Unindent(float indentW)
		{
			ImGuiNative.Unindent(indentW);
		}

		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		public static void BeginGroup()
		{
			ImGuiNative.BeginGroup();
		}

		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		public static void EndGroup()
		{
			ImGuiNative.EndGroup();
		}

		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		public static void AlnTextToFramePadding()
		{
			ImGuiNative.AlnTextToFramePadding();
		}

		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		public static float GetTextLineHeht()
		{
			return ImGuiNative.GetTextLineHeht();
		}

		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		public static float GetTextLineHehtWithSpacing()
		{
			return ImGuiNative.GetTextLineHehtWithSpacing();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		public static float GetFrameHeht()
		{
			return ImGuiNative.GetFrameHeht();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		public static float GetFrameHehtWithSpacing()
		{
			return ImGuiNative.GetFrameHehtWithSpacing();
		}

		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		public static void PushID(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuiNative.PushID(native_strId);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static void PushID(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* native_strIdBegin;
			var byteCount_strIdBegin = 0;
			if (strIdBegin != null)
			{
				byteCount_strIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCount_strIdBegin > Utils.MaxStackallocSize)
				{
					native_strIdBegin = Utils.Alloc<byte>(byteCount_strIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdBegin + 1];
					native_strIdBegin = stackallocBytes;
				}
				var strIdBegin_offset = Utils.EncodeStringUTF8(strIdBegin, native_strIdBegin, byteCount_strIdBegin);
				native_strIdBegin[strIdBegin_offset] = 0;
			}
			else native_strIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* native_strIdEnd;
			var byteCount_strIdEnd = 0;
			if (strIdEnd != null)
			{
				byteCount_strIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCount_strIdEnd > Utils.MaxStackallocSize)
				{
					native_strIdEnd = Utils.Alloc<byte>(byteCount_strIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdEnd + 1];
					native_strIdEnd = stackallocBytes;
				}
				var strIdEnd_offset = Utils.EncodeStringUTF8(strIdEnd, native_strIdEnd, byteCount_strIdEnd);
				native_strIdEnd[strIdEnd_offset] = 0;
			}
			else native_strIdEnd = null;

			ImGuiNative.PushID(native_strIdBegin, native_strIdEnd);
			// Freeing strIdBegin native string
			if (byteCount_strIdBegin > Utils.MaxStackallocSize)
				Utils.Free(native_strIdBegin);
			// Freeing strIdEnd native string
			if (byteCount_strIdEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strIdEnd);
		}

		public static void PushID(IntPtr ptrId)
		{
			ImGuiNative.PushID((void*)ptrId);
		}

		public static void PushID(int intId)
		{
			ImGuiNative.PushID(intId);
		}

		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		public static void PopID()
		{
			ImGuiNative.PopID();
		}

		public static uint GetID(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.GetID(native_strId);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static uint GetID(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* native_strIdBegin;
			var byteCount_strIdBegin = 0;
			if (strIdBegin != null)
			{
				byteCount_strIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCount_strIdBegin > Utils.MaxStackallocSize)
				{
					native_strIdBegin = Utils.Alloc<byte>(byteCount_strIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdBegin + 1];
					native_strIdBegin = stackallocBytes;
				}
				var strIdBegin_offset = Utils.EncodeStringUTF8(strIdBegin, native_strIdBegin, byteCount_strIdBegin);
				native_strIdBegin[strIdBegin_offset] = 0;
			}
			else native_strIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* native_strIdEnd;
			var byteCount_strIdEnd = 0;
			if (strIdEnd != null)
			{
				byteCount_strIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCount_strIdEnd > Utils.MaxStackallocSize)
				{
					native_strIdEnd = Utils.Alloc<byte>(byteCount_strIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdEnd + 1];
					native_strIdEnd = stackallocBytes;
				}
				var strIdEnd_offset = Utils.EncodeStringUTF8(strIdEnd, native_strIdEnd, byteCount_strIdEnd);
				native_strIdEnd[strIdEnd_offset] = 0;
			}
			else native_strIdEnd = null;

			return ImGuiNative.GetID(native_strIdBegin, native_strIdEnd);
			// Freeing strIdBegin native string
			if (byteCount_strIdBegin > Utils.MaxStackallocSize)
				Utils.Free(native_strIdBegin);
			// Freeing strIdEnd native string
			if (byteCount_strIdEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strIdEnd);
		}

		public static uint GetID(IntPtr ptrId)
		{
			return ImGuiNative.GetID((void*)ptrId);
		}

		public static uint GetID(int intId)
		{
			return ImGuiNative.GetID(intId);
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			ImGuiNative.TextUnformatted(native_text, native_textEnd);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		/// <summary>
		/// formatted text<br/>
		/// </summary>
		public static void Text(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.Text(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static void TextColored(Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.TextColored(col, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static void TextDisabled(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.TextDisabled(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		public static void TextWrapped(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.TextWrapped(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		public static void LabelText(ReadOnlySpan<char> label, ReadOnlySpan<char> fmt)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.LabelText(native_label, native_fmt);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		public static void BulletText(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.BulletText(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// currently: formatted text with a horizontal line<br/>
		/// </summary>
		public static void SeparatorText(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.SeparatorText(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		public static byte Button(ReadOnlySpan<char> label, Vector2 size)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.Button(native_label, size);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		public static byte SmallButton(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.SmallButton(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static byte InvisibleButton(ReadOnlySpan<char> strId, Vector2 size, ImGuiButtonFlags flags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.InvisibleButton(native_strId, size, flags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		public static byte ArrowButton(ReadOnlySpan<char> strId, ImGuiDir dir)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.ArrowButton(native_strId, dir);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static byte Checkbox(ReadOnlySpan<char> label, ReadOnlySpan<char> v)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling v to native string
			byte* native_v;
			var byteCount_v = 0;
			if (v != null)
			{
				byteCount_v = Encoding.UTF8.GetByteCount(v);
				if(byteCount_v > Utils.MaxStackallocSize)
				{
					native_v = Utils.Alloc<byte>(byteCount_v + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_v + 1];
					native_v = stackallocBytes;
				}
				var v_offset = Utils.EncodeStringUTF8(v, native_v, byteCount_v);
				native_v[v_offset] = 0;
			}
			else native_v = null;

			return ImGuiNative.Checkbox(native_label, native_v);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing v native string
			if (byteCount_v > Utils.MaxStackallocSize)
				Utils.Free(native_v);
		}

		public static byte CheckboxFlags(ReadOnlySpan<char> label, ref int flags, int flagsValue)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_flags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(native_label, native_flags, flagsValue);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte CheckboxFlags(ReadOnlySpan<char> label, ref uint flags, uint flagsValue)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (uint* native_flags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(native_label, native_flags, flagsValue);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		public static byte RadioButton(ReadOnlySpan<char> label, bool active)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var native_active = active ? (byte)1 : (byte)0;
			return ImGuiNative.RadioButton(native_label, native_active);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte RadioButton(ReadOnlySpan<char> label, ref int v, int vButton)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.RadioButton(native_label, native_v, vButton);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static void ProgressBar(float fraction, Vector2 sizeArg, ReadOnlySpan<char> overlay)
		{
			// Marshaling overlay to native string
			byte* native_overlay;
			var byteCount_overlay = 0;
			if (overlay != null)
			{
				byteCount_overlay = Encoding.UTF8.GetByteCount(overlay);
				if(byteCount_overlay > Utils.MaxStackallocSize)
				{
					native_overlay = Utils.Alloc<byte>(byteCount_overlay + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_overlay + 1];
					native_overlay = stackallocBytes;
				}
				var overlay_offset = Utils.EncodeStringUTF8(overlay, native_overlay, byteCount_overlay);
				native_overlay[overlay_offset] = 0;
			}
			else native_overlay = null;

			ImGuiNative.ProgressBar(fraction, sizeArg, native_overlay);
			// Freeing overlay native string
			if (byteCount_overlay > Utils.MaxStackallocSize)
				Utils.Free(native_overlay);
		}

		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		public static void Bullet()
		{
			ImGuiNative.Bullet();
		}

		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		public static byte TextLink(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.TextLink(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<char> label, ReadOnlySpan<char> url)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling url to native string
			byte* native_url;
			var byteCount_url = 0;
			if (url != null)
			{
				byteCount_url = Encoding.UTF8.GetByteCount(url);
				if(byteCount_url > Utils.MaxStackallocSize)
				{
					native_url = Utils.Alloc<byte>(byteCount_url + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_url + 1];
					native_url = stackallocBytes;
				}
				var url_offset = Utils.EncodeStringUTF8(url, native_url, byteCount_url);
				native_url[url_offset] = 0;
			}
			else native_url = null;

			ImGuiNative.TextLinkOpenURL(native_label, native_url);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing url native string
			if (byteCount_url > Utils.MaxStackallocSize)
				Utils.Free(native_url);
		}

		public static void Image(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1)
		{
			ImGuiNative.Image(userTextureId, imageSize, uv0, uv1);
		}

		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			ImGuiNative.ImageWithBg(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		public static byte ImageButton(ReadOnlySpan<char> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.ImageButton(native_strId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static byte BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> previewValue, ImGuiComboFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling previewValue to native string
			byte* native_previewValue;
			var byteCount_previewValue = 0;
			if (previewValue != null)
			{
				byteCount_previewValue = Encoding.UTF8.GetByteCount(previewValue);
				if(byteCount_previewValue > Utils.MaxStackallocSize)
				{
					native_previewValue = Utils.Alloc<byte>(byteCount_previewValue + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_previewValue + 1];
					native_previewValue = stackallocBytes;
				}
				var previewValue_offset = Utils.EncodeStringUTF8(previewValue, native_previewValue, byteCount_previewValue);
				native_previewValue[previewValue_offset] = 0;
			}
			else native_previewValue = null;

			return ImGuiNative.BeginCombo(native_label, native_previewValue, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing previewValue native string
			if (byteCount_previewValue > Utils.MaxStackallocSize)
				Utils.Free(native_previewValue);
		}

		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		public static void EndCombo()
		{
			ImGuiNative.EndCombo();
		}

		public static byte ComboStrArr(ReadOnlySpan<char> label, ref int currentItem, ref byte* items, int itemsCount, int popupMaxHeightInItems)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_currentItem = &currentItem)
			fixed (byte** native_items = &items)
			{
				var result = ImGuiNative.ComboStrArr(native_label, native_currentItem, native_items, itemsCount, popupMaxHeightInItems);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte Combo(ReadOnlySpan<char> label, ref int currentItem, ReadOnlySpan<char> itemsSeparatedByZeros, int popupMaxHeightInItems)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling itemsSeparatedByZeros to native string
			byte* native_itemsSeparatedByZeros;
			var byteCount_itemsSeparatedByZeros = 0;
			if (itemsSeparatedByZeros != null)
			{
				byteCount_itemsSeparatedByZeros = Encoding.UTF8.GetByteCount(itemsSeparatedByZeros);
				if(byteCount_itemsSeparatedByZeros > Utils.MaxStackallocSize)
				{
					native_itemsSeparatedByZeros = Utils.Alloc<byte>(byteCount_itemsSeparatedByZeros + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_itemsSeparatedByZeros + 1];
					native_itemsSeparatedByZeros = stackallocBytes;
				}
				var itemsSeparatedByZeros_offset = Utils.EncodeStringUTF8(itemsSeparatedByZeros, native_itemsSeparatedByZeros, byteCount_itemsSeparatedByZeros);
				native_itemsSeparatedByZeros[itemsSeparatedByZeros_offset] = 0;
			}
			else native_itemsSeparatedByZeros = null;

			fixed (int* native_currentItem = &currentItem)
			{
				var result = ImGuiNative.Combo(native_label, native_currentItem, native_itemsSeparatedByZeros, popupMaxHeightInItems);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing itemsSeparatedByZeros native string
				if (byteCount_itemsSeparatedByZeros > Utils.MaxStackallocSize)
					Utils.Free(native_itemsSeparatedByZeros);
				return result;
			}
		}

		public static byte Combo(ReadOnlySpan<char> label, ref int currentItem, IgComboGetter getter, IntPtr userData, int itemsCount, int popupMaxHeightInItems)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_currentItem = &currentItem)
			{
				var result = ImGuiNative.Combo(native_label, native_currentItem, getter, (void*)userData, itemsCount, popupMaxHeightInItems);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static byte DragFloat(ReadOnlySpan<char> label, ref float v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var result = ImGuiNative.DragFloat(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector2* native_v = &v)
			{
				var result = ImGuiNative.DragFloat2(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector3* native_v = &v)
			{
				var result = ImGuiNative.DragFloat3(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector4* native_v = &v)
			{
				var result = ImGuiNative.DragFloat4(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ReadOnlySpan<char> formatMax, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling formatMax to native string
			byte* native_formatMax;
			var byteCount_formatMax = 0;
			if (formatMax != null)
			{
				byteCount_formatMax = Encoding.UTF8.GetByteCount(formatMax);
				if(byteCount_formatMax > Utils.MaxStackallocSize)
				{
					native_formatMax = Utils.Alloc<byte>(byteCount_formatMax + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_formatMax + 1];
					native_formatMax = stackallocBytes;
				}
				var formatMax_offset = Utils.EncodeStringUTF8(formatMax, native_formatMax, byteCount_formatMax);
				native_formatMax[formatMax_offset] = 0;
			}
			else native_formatMax = null;

			fixed (float* native_vCurrentMin = &vCurrentMin)
			fixed (float* native_vCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(native_label, native_vCurrentMin, native_vCurrentMax, vSpeed, vMin, vMax, native_format, native_formatMax, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				// Freeing formatMax native string
				if (byteCount_formatMax > Utils.MaxStackallocSize)
					Utils.Free(native_formatMax);
				return result;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static byte DragInt(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.DragInt(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragInt2(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.DragInt2(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragInt3(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.DragInt3(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragInt4(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.DragInt4(native_label, native_v, vSpeed, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ReadOnlySpan<char> formatMax, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling formatMax to native string
			byte* native_formatMax;
			var byteCount_formatMax = 0;
			if (formatMax != null)
			{
				byteCount_formatMax = Encoding.UTF8.GetByteCount(formatMax);
				if(byteCount_formatMax > Utils.MaxStackallocSize)
				{
					native_formatMax = Utils.Alloc<byte>(byteCount_formatMax + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_formatMax + 1];
					native_formatMax = stackallocBytes;
				}
				var formatMax_offset = Utils.EncodeStringUTF8(formatMax, native_formatMax, byteCount_formatMax);
				native_formatMax[formatMax_offset] = 0;
			}
			else native_formatMax = null;

			fixed (int* native_vCurrentMin = &vCurrentMin)
			fixed (int* native_vCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(native_label, native_vCurrentMin, native_vCurrentMax, vSpeed, vMin, vMax, native_format, native_formatMax, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				// Freeing formatMax native string
				if (byteCount_formatMax > Utils.MaxStackallocSize)
					Utils.Free(native_formatMax);
				return result;
			}
		}

		public static byte DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.DragScalar(native_label, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.DragScalarN(native_label, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static byte SliderFloat(ReadOnlySpan<char> label, ref float v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var result = ImGuiNative.SliderFloat(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector2* native_v = &v)
			{
				var result = ImGuiNative.SliderFloat2(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector3* native_v = &v)
			{
				var result = ImGuiNative.SliderFloat3(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector4* native_v = &v)
			{
				var result = ImGuiNative.SliderFloat4(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderAngle(ReadOnlySpan<char> label, ref float vRad, float vDegreesMin, float vDegreesMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_vRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(native_label, native_vRad, vDegreesMin, vDegreesMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderInt(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.SliderInt(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderInt2(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.SliderInt2(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderInt3(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.SliderInt3(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderInt4(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.SliderInt4(native_label, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte SliderScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.SliderScalar(native_label, dataType, (void*)pData, (void*)pMin, (void*)pMax, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.SliderScalarN(native_label, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var result = ImGuiNative.VSliderFloat(native_label, size, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.VSliderInt(native_label, size, native_v, vMin, vMax, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.VSliderScalar(native_label, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte InputText(ReadOnlySpan<char> label, ReadOnlySpan<char> buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			return ImGuiNative.InputText(native_label, native_buf, bufSize, flags, callback, (void*)userData);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
		}

		public static byte InputTextMultiline(ReadOnlySpan<char> label, ReadOnlySpan<char> buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			return ImGuiNative.InputTextMultiline(native_label, native_buf, bufSize, size, flags, callback, (void*)userData);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
		}

		public static byte InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, ReadOnlySpan<char> buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling hint to native string
			byte* native_hint;
			var byteCount_hint = 0;
			if (hint != null)
			{
				byteCount_hint = Encoding.UTF8.GetByteCount(hint);
				if(byteCount_hint > Utils.MaxStackallocSize)
				{
					native_hint = Utils.Alloc<byte>(byteCount_hint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_hint + 1];
					native_hint = stackallocBytes;
				}
				var hint_offset = Utils.EncodeStringUTF8(hint, native_hint, byteCount_hint);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			return ImGuiNative.InputTextWithHint(native_label, native_hint, native_buf, bufSize, flags, callback, (void*)userData);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing hint native string
			if (byteCount_hint > Utils.MaxStackallocSize)
				Utils.Free(native_hint);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
		}

		public static byte InputFloat(ReadOnlySpan<char> label, ref float v, float step, float stepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var result = ImGuiNative.InputFloat(native_label, native_v, step, stepFast, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector2* native_v = &v)
			{
				var result = ImGuiNative.InputFloat2(native_label, native_v, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector3* native_v = &v)
			{
				var result = ImGuiNative.InputFloat3(native_label, native_v, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector4* native_v = &v)
			{
				var result = ImGuiNative.InputFloat4(native_label, native_v, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte InputInt(ReadOnlySpan<char> label, ref int v, int step, int stepFast, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.InputInt(native_label, native_v, step, stepFast, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte InputInt2(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.InputInt2(native_label, native_v, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte InputInt3(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.InputInt3(native_label, native_v, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte InputInt4(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var result = ImGuiNative.InputInt4(native_label, native_v, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte InputDouble(ReadOnlySpan<char> label, ref double v, double step, double stepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (double* native_v = &v)
			{
				var result = ImGuiNative.InputDouble(native_label, native_v, step, stepFast, native_format, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing format native string
				if (byteCount_format > Utils.MaxStackallocSize)
					Utils.Free(native_format);
				return result;
			}
		}

		public static byte InputScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.InputScalar(native_label, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte InputScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.InputScalarN(native_label, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, native_format, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_col = &col)
			{
				var result = ImGuiNative.ColorEdit3(native_label, native_col, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_col = &col)
			{
				var result = ImGuiNative.ColorEdit4(native_label, native_col, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_col = &col)
			{
				var result = ImGuiNative.ColorPicker3(native_label, native_col, flags);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags, ref float refCol)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_col = &col)
			fixed (float* native_refCol = &refCol)
			{
				var result = ImGuiNative.ColorPicker4(native_label, native_col, flags, native_refCol);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static byte ColorButton(ReadOnlySpan<char> descId, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
		{
			// Marshaling descId to native string
			byte* native_descId;
			var byteCount_descId = 0;
			if (descId != null)
			{
				byteCount_descId = Encoding.UTF8.GetByteCount(descId);
				if(byteCount_descId > Utils.MaxStackallocSize)
				{
					native_descId = Utils.Alloc<byte>(byteCount_descId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_descId + 1];
					native_descId = stackallocBytes;
				}
				var descId_offset = Utils.EncodeStringUTF8(descId, native_descId, byteCount_descId);
				native_descId[descId_offset] = 0;
			}
			else native_descId = null;

			return ImGuiNative.ColorButton(native_descId, col, flags, size);
			// Freeing descId native string
			if (byteCount_descId > Utils.MaxStackallocSize)
				Utils.Free(native_descId);
		}

		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		public static void SetColorEditOptions(ImGuiColorEditFlags flags)
		{
			ImGuiNative.SetColorEditOptions(flags);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		public static byte TreeNode(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.TreeNode(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte TreeNode(ReadOnlySpan<char> strId, ReadOnlySpan<char> fmt)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			return ImGuiNative.TreeNode(native_strId, native_fmt);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static byte TreeNode(IntPtr ptrId, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			return ImGuiNative.TreeNode((void*)ptrId, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static byte TreeNodeEx(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.TreeNodeEx(native_label, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte TreeNodeEx(ReadOnlySpan<char> strId, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			return ImGuiNative.TreeNodeEx(native_strId, flags, native_fmt);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static byte TreeNodeEx(IntPtr ptrId, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			return ImGuiNative.TreeNodeEx((void*)ptrId, flags, native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		public static void TreePush(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuiNative.TreePush(native_strId);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static void TreePush(IntPtr ptrId)
		{
			ImGuiNative.TreePush((void*)ptrId);
		}

		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		public static void TreePop()
		{
			ImGuiNative.TreePop();
		}

		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		public static float GetTreeNodeToLabelSpacing()
		{
			return ImGuiNative.GetTreeNodeToLabelSpacing();
		}

		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		public static byte CollapsingHeader(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.CollapsingHeader(native_label, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte CollapsingHeader(ReadOnlySpan<char> label, ReadOnlySpan<char> pVisible, ImGuiTreeNodeFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling pVisible to native string
			byte* native_pVisible;
			var byteCount_pVisible = 0;
			if (pVisible != null)
			{
				byteCount_pVisible = Encoding.UTF8.GetByteCount(pVisible);
				if(byteCount_pVisible > Utils.MaxStackallocSize)
				{
					native_pVisible = Utils.Alloc<byte>(byteCount_pVisible + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pVisible + 1];
					native_pVisible = stackallocBytes;
				}
				var pVisible_offset = Utils.EncodeStringUTF8(pVisible, native_pVisible, byteCount_pVisible);
				native_pVisible[pVisible_offset] = 0;
			}
			else native_pVisible = null;

			return ImGuiNative.CollapsingHeader(native_label, native_pVisible, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing pVisible native string
			if (byteCount_pVisible > Utils.MaxStackallocSize)
				Utils.Free(native_pVisible);
		}

		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		public static void SetNextItemOpen(bool isOpen, ImGuiCond cond)
		{
			var native_isOpen = isOpen ? (byte)1 : (byte)0;
			ImGuiNative.SetNextItemOpen(native_isOpen, cond);
		}

		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		public static void SetNextItemStorageID(uint storageId)
		{
			ImGuiNative.SetNextItemStorageID(storageId);
		}

		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		public static byte Selectable(ReadOnlySpan<char> label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			return ImGuiNative.Selectable(native_label, native_selected, flags, size);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte Selectable(ReadOnlySpan<char> label, ReadOnlySpan<char> pSelected, ImGuiSelectableFlags flags, Vector2 size)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling pSelected to native string
			byte* native_pSelected;
			var byteCount_pSelected = 0;
			if (pSelected != null)
			{
				byteCount_pSelected = Encoding.UTF8.GetByteCount(pSelected);
				if(byteCount_pSelected > Utils.MaxStackallocSize)
				{
					native_pSelected = Utils.Alloc<byte>(byteCount_pSelected + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pSelected + 1];
					native_pSelected = stackallocBytes;
				}
				var pSelected_offset = Utils.EncodeStringUTF8(pSelected, native_pSelected, byteCount_pSelected);
				native_pSelected[pSelected_offset] = 0;
			}
			else native_pSelected = null;

			return ImGuiNative.Selectable(native_label, native_pSelected, flags, size);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing pSelected native string
			if (byteCount_pSelected > Utils.MaxStackallocSize)
				Utils.Free(native_pSelected);
		}

		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags, int selectionSize, int itemsCount)
		{
			return ImGuiNative.BeginMultiSelect(flags, selectionSize, itemsCount);
		}

		public static ImGuiMultiSelectIOPtr EndMultiSelect()
		{
			return ImGuiNative.EndMultiSelect();
		}

		public static void SetNextItemSelectionUserData(long selectionUserData)
		{
			ImGuiNative.SetNextItemSelectionUserData(selectionUserData);
		}

		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		public static byte IsItemToggledSelection()
		{
			return ImGuiNative.IsItemToggledSelection();
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static byte BeginListBox(ReadOnlySpan<char> label, Vector2 size)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.BeginListBox(native_label, size);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		public static void EndListBox()
		{
			ImGuiNative.EndListBox();
		}

		public static byte ListBoxStrArr(ReadOnlySpan<char> label, ref int currentItem, ref byte* items, int itemsCount, int heightInItems)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_currentItem = &currentItem)
			fixed (byte** native_items = &items)
			{
				var result = ImGuiNative.ListBoxStrArr(native_label, native_currentItem, native_items, itemsCount, heightInItems);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte ListBoxFnStrPtr(ReadOnlySpan<char> label, ref int currentItem, IgComboGetter getter, IntPtr userData, int itemsCount, int heightInItems)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_currentItem = &currentItem)
			{
				var result = ImGuiNative.ListBoxFnStrPtr(native_label, native_currentItem, getter, (void*)userData, itemsCount, heightInItems);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static void PlotLines(ReadOnlySpan<char> label, ref float values, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling overlayText to native string
			byte* native_overlayText;
			var byteCount_overlayText = 0;
			if (overlayText != null)
			{
				byteCount_overlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCount_overlayText > Utils.MaxStackallocSize)
				{
					native_overlayText = Utils.Alloc<byte>(byteCount_overlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_overlayText + 1];
					native_overlayText = stackallocBytes;
				}
				var overlayText_offset = Utils.EncodeStringUTF8(overlayText, native_overlayText, byteCount_overlayText);
				native_overlayText[overlayText_offset] = 0;
			}
			else native_overlayText = null;

			fixed (float* native_values = &values)
			{
				ImGuiNative.PlotLines(native_label, native_values, valuesCount, valuesOffset, native_overlayText, scaleMin, scaleMax, graphSize, stride);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing overlayText native string
				if (byteCount_overlayText > Utils.MaxStackallocSize)
					Utils.Free(native_overlayText);
			}
		}

		public static void PlotLines(ReadOnlySpan<char> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling overlayText to native string
			byte* native_overlayText;
			var byteCount_overlayText = 0;
			if (overlayText != null)
			{
				byteCount_overlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCount_overlayText > Utils.MaxStackallocSize)
				{
					native_overlayText = Utils.Alloc<byte>(byteCount_overlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_overlayText + 1];
					native_overlayText = stackallocBytes;
				}
				var overlayText_offset = Utils.EncodeStringUTF8(overlayText, native_overlayText, byteCount_overlayText);
				native_overlayText[overlayText_offset] = 0;
			}
			else native_overlayText = null;

			ImGuiNative.PlotLines(native_label, valuesGetter, (void*)data, valuesCount, valuesOffset, native_overlayText, scaleMin, scaleMax, graphSize);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing overlayText native string
			if (byteCount_overlayText > Utils.MaxStackallocSize)
				Utils.Free(native_overlayText);
		}

		public static void PlotHistogram(ReadOnlySpan<char> label, ref float values, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling overlayText to native string
			byte* native_overlayText;
			var byteCount_overlayText = 0;
			if (overlayText != null)
			{
				byteCount_overlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCount_overlayText > Utils.MaxStackallocSize)
				{
					native_overlayText = Utils.Alloc<byte>(byteCount_overlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_overlayText + 1];
					native_overlayText = stackallocBytes;
				}
				var overlayText_offset = Utils.EncodeStringUTF8(overlayText, native_overlayText, byteCount_overlayText);
				native_overlayText[overlayText_offset] = 0;
			}
			else native_overlayText = null;

			fixed (float* native_values = &values)
			{
				ImGuiNative.PlotHistogram(native_label, native_values, valuesCount, valuesOffset, native_overlayText, scaleMin, scaleMax, graphSize, stride);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				// Freeing overlayText native string
				if (byteCount_overlayText > Utils.MaxStackallocSize)
					Utils.Free(native_overlayText);
			}
		}

		public static void PlotHistogram(ReadOnlySpan<char> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling overlayText to native string
			byte* native_overlayText;
			var byteCount_overlayText = 0;
			if (overlayText != null)
			{
				byteCount_overlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCount_overlayText > Utils.MaxStackallocSize)
				{
					native_overlayText = Utils.Alloc<byte>(byteCount_overlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_overlayText + 1];
					native_overlayText = stackallocBytes;
				}
				var overlayText_offset = Utils.EncodeStringUTF8(overlayText, native_overlayText, byteCount_overlayText);
				native_overlayText[overlayText_offset] = 0;
			}
			else native_overlayText = null;

			ImGuiNative.PlotHistogram(native_label, valuesGetter, (void*)data, valuesCount, valuesOffset, native_overlayText, scaleMin, scaleMax, graphSize);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing overlayText native string
			if (byteCount_overlayText > Utils.MaxStackallocSize)
				Utils.Free(native_overlayText);
		}

		public static void Value(ReadOnlySpan<char> prefix, bool b)
		{
			// Marshaling prefix to native string
			byte* native_prefix;
			var byteCount_prefix = 0;
			if (prefix != null)
			{
				byteCount_prefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCount_prefix > Utils.MaxStackallocSize)
				{
					native_prefix = Utils.Alloc<byte>(byteCount_prefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_prefix + 1];
					native_prefix = stackallocBytes;
				}
				var prefix_offset = Utils.EncodeStringUTF8(prefix, native_prefix, byteCount_prefix);
				native_prefix[prefix_offset] = 0;
			}
			else native_prefix = null;

			var native_b = b ? (byte)1 : (byte)0;
			ImGuiNative.Value(native_prefix, native_b);
			// Freeing prefix native string
			if (byteCount_prefix > Utils.MaxStackallocSize)
				Utils.Free(native_prefix);
		}

		public static void Value(ReadOnlySpan<char> prefix, int v)
		{
			// Marshaling prefix to native string
			byte* native_prefix;
			var byteCount_prefix = 0;
			if (prefix != null)
			{
				byteCount_prefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCount_prefix > Utils.MaxStackallocSize)
				{
					native_prefix = Utils.Alloc<byte>(byteCount_prefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_prefix + 1];
					native_prefix = stackallocBytes;
				}
				var prefix_offset = Utils.EncodeStringUTF8(prefix, native_prefix, byteCount_prefix);
				native_prefix[prefix_offset] = 0;
			}
			else native_prefix = null;

			ImGuiNative.Value(native_prefix, v);
			// Freeing prefix native string
			if (byteCount_prefix > Utils.MaxStackallocSize)
				Utils.Free(native_prefix);
		}

		public static void Value(ReadOnlySpan<char> prefix, uint v)
		{
			// Marshaling prefix to native string
			byte* native_prefix;
			var byteCount_prefix = 0;
			if (prefix != null)
			{
				byteCount_prefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCount_prefix > Utils.MaxStackallocSize)
				{
					native_prefix = Utils.Alloc<byte>(byteCount_prefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_prefix + 1];
					native_prefix = stackallocBytes;
				}
				var prefix_offset = Utils.EncodeStringUTF8(prefix, native_prefix, byteCount_prefix);
				native_prefix[prefix_offset] = 0;
			}
			else native_prefix = null;

			ImGuiNative.Value(native_prefix, v);
			// Freeing prefix native string
			if (byteCount_prefix > Utils.MaxStackallocSize)
				Utils.Free(native_prefix);
		}

		public static void Value(ReadOnlySpan<char> prefix, float v, ReadOnlySpan<char> floatFormat)
		{
			// Marshaling prefix to native string
			byte* native_prefix;
			var byteCount_prefix = 0;
			if (prefix != null)
			{
				byteCount_prefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCount_prefix > Utils.MaxStackallocSize)
				{
					native_prefix = Utils.Alloc<byte>(byteCount_prefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_prefix + 1];
					native_prefix = stackallocBytes;
				}
				var prefix_offset = Utils.EncodeStringUTF8(prefix, native_prefix, byteCount_prefix);
				native_prefix[prefix_offset] = 0;
			}
			else native_prefix = null;

			// Marshaling floatFormat to native string
			byte* native_floatFormat;
			var byteCount_floatFormat = 0;
			if (floatFormat != null)
			{
				byteCount_floatFormat = Encoding.UTF8.GetByteCount(floatFormat);
				if(byteCount_floatFormat > Utils.MaxStackallocSize)
				{
					native_floatFormat = Utils.Alloc<byte>(byteCount_floatFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_floatFormat + 1];
					native_floatFormat = stackallocBytes;
				}
				var floatFormat_offset = Utils.EncodeStringUTF8(floatFormat, native_floatFormat, byteCount_floatFormat);
				native_floatFormat[floatFormat_offset] = 0;
			}
			else native_floatFormat = null;

			ImGuiNative.Value(native_prefix, v, native_floatFormat);
			// Freeing prefix native string
			if (byteCount_prefix > Utils.MaxStackallocSize)
				Utils.Free(native_prefix);
			// Freeing floatFormat native string
			if (byteCount_floatFormat > Utils.MaxStackallocSize)
				Utils.Free(native_floatFormat);
		}

		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		public static byte BeginMenuBar()
		{
			return ImGuiNative.BeginMenuBar();
		}

		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		public static void EndMenuBar()
		{
			ImGuiNative.EndMenuBar();
		}

		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		public static byte BeginMainMenuBar()
		{
			return ImGuiNative.BeginMainMenuBar();
		}

		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		public static void EndMainMenuBar()
		{
			ImGuiNative.EndMainMenuBar();
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static byte BeginMenu(ReadOnlySpan<char> label, bool enabled)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var native_enabled = enabled ? (byte)1 : (byte)0;
			return ImGuiNative.BeginMenu(native_label, native_enabled);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		public static void EndMenu()
		{
			ImGuiNative.EndMenu();
		}

		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		public static byte MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling shortcut to native string
			byte* native_shortcut;
			var byteCount_shortcut = 0;
			if (shortcut != null)
			{
				byteCount_shortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCount_shortcut > Utils.MaxStackallocSize)
				{
					native_shortcut = Utils.Alloc<byte>(byteCount_shortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_shortcut + 1];
					native_shortcut = stackallocBytes;
				}
				var shortcut_offset = Utils.EncodeStringUTF8(shortcut, native_shortcut, byteCount_shortcut);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			return ImGuiNative.MenuItem(native_label, native_shortcut, native_selected, native_enabled);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing shortcut native string
			if (byteCount_shortcut > Utils.MaxStackallocSize)
				Utils.Free(native_shortcut);
		}

		public static byte MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, ReadOnlySpan<char> pSelected, bool enabled)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling shortcut to native string
			byte* native_shortcut;
			var byteCount_shortcut = 0;
			if (shortcut != null)
			{
				byteCount_shortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCount_shortcut > Utils.MaxStackallocSize)
				{
					native_shortcut = Utils.Alloc<byte>(byteCount_shortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_shortcut + 1];
					native_shortcut = stackallocBytes;
				}
				var shortcut_offset = Utils.EncodeStringUTF8(shortcut, native_shortcut, byteCount_shortcut);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling pSelected to native string
			byte* native_pSelected;
			var byteCount_pSelected = 0;
			if (pSelected != null)
			{
				byteCount_pSelected = Encoding.UTF8.GetByteCount(pSelected);
				if(byteCount_pSelected > Utils.MaxStackallocSize)
				{
					native_pSelected = Utils.Alloc<byte>(byteCount_pSelected + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pSelected + 1];
					native_pSelected = stackallocBytes;
				}
				var pSelected_offset = Utils.EncodeStringUTF8(pSelected, native_pSelected, byteCount_pSelected);
				native_pSelected[pSelected_offset] = 0;
			}
			else native_pSelected = null;

			var native_enabled = enabled ? (byte)1 : (byte)0;
			return ImGuiNative.MenuItem(native_label, native_shortcut, native_pSelected, native_enabled);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing shortcut native string
			if (byteCount_shortcut > Utils.MaxStackallocSize)
				Utils.Free(native_shortcut);
			// Freeing pSelected native string
			if (byteCount_pSelected > Utils.MaxStackallocSize)
				Utils.Free(native_pSelected);
		}

		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		public static byte BeginTooltip()
		{
			return ImGuiNative.BeginTooltip();
		}

		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		public static void EndTooltip()
		{
			ImGuiNative.EndTooltip();
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		public static void SetTooltip(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.SetTooltip(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		public static byte BeginItemTooltip()
		{
			return ImGuiNative.BeginItemTooltip();
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		public static void SetItemTooltip(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.SetItemTooltip(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static byte BeginPopup(ReadOnlySpan<char> strId, ImGuiWindowFlags flags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginPopup(native_strId, flags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static byte BeginPopupModal(ReadOnlySpan<char> name, ReadOnlySpan<char> pOpen, ImGuiWindowFlags flags)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			return ImGuiNative.BeginPopupModal(native_name, native_pOpen, flags);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		public static void EndPopup()
		{
			ImGuiNative.EndPopup();
		}

		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		public static void OpenPopup(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuiNative.OpenPopup(native_strId, popupFlags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static void OpenPopup(uint id, ImGuiPopupFlags popupFlags)
		{
			ImGuiNative.OpenPopup(id, popupFlags);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuiNative.OpenPopupOnItemClick(native_strId, popupFlags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		public static void CloseCurrentPopup()
		{
			ImGuiNative.CloseCurrentPopup();
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static byte BeginPopupContextItem(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginPopupContextItem(native_strId, popupFlags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static byte BeginPopupContextWindow(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginPopupContextWindow(native_strId, popupFlags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static byte BeginPopupContextVoid(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginPopupContextVoid(native_strId, popupFlags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static byte IsPopupOpen(ReadOnlySpan<char> strId, ImGuiPopupFlags flags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.IsPopupOpen(native_strId, flags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static byte BeginTable(ReadOnlySpan<char> strId, int columns, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginTable(native_strId, columns, flags, outerSize, innerWidth);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		public static void EndTable()
		{
			ImGuiNative.EndTable();
		}

		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		public static void TableNextRow(ImGuiTableRowFlags rowFlags, float minRowHeight)
		{
			ImGuiNative.TableNextRow(rowFlags, minRowHeight);
		}

		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		public static byte TableNextColumn()
		{
			return ImGuiNative.TableNextColumn();
		}

		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		public static byte TableSetColumnIndex(int columnN)
		{
			return ImGuiNative.TableSetColumnIndex(columnN);
		}

		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float initWidthOrWeight, uint userId)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.TableSetupColumn(native_label, flags, initWidthOrWeight, userId);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		public static void TableSetupScrollFreeze(int cols, int rows)
		{
			ImGuiNative.TableSetupScrollFreeze(cols, rows);
		}

		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		public static void TableHeader(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.TableHeader(native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		public static void TableHeadersRow()
		{
			ImGuiNative.TableHeadersRow();
		}

		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		public static void TableAngledHeadersRow()
		{
			ImGuiNative.TableAngledHeadersRow();
		}

		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		public static ImGuiTableSortSpecsPtr TableGetSortSpecs()
		{
			return ImGuiNative.TableGetSortSpecs();
		}

		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		public static int TableGetColumnCount()
		{
			return ImGuiNative.TableGetColumnCount();
		}

		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		public static int TableGetColumnIndex()
		{
			return ImGuiNative.TableGetColumnIndex();
		}

		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		public static int TableGetRowIndex()
		{
			return ImGuiNative.TableGetRowIndex();
		}

		public static ref byte TableGetColumnName(int columnN)
		{
			var nativeResult = ImGuiNative.TableGetColumnName(columnN);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		public static ImGuiTableColumnFlags TableGetColumnFlags(int columnN)
		{
			return ImGuiNative.TableGetColumnFlags(columnN);
		}

		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		public static void TableSetColumnEnabled(int columnN, bool v)
		{
			var native_v = v ? (byte)1 : (byte)0;
			ImGuiNative.TableSetColumnEnabled(columnN, native_v);
		}

		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		public static int TableGetHoveredColumn()
		{
			return ImGuiNative.TableGetHoveredColumn();
		}

		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int columnN)
		{
			ImGuiNative.TableSetBgColor(target, color, columnN);
		}

		public static void Columns(int count, ReadOnlySpan<char> id, bool borders)
		{
			// Marshaling id to native string
			byte* native_id;
			var byteCount_id = 0;
			if (id != null)
			{
				byteCount_id = Encoding.UTF8.GetByteCount(id);
				if(byteCount_id > Utils.MaxStackallocSize)
				{
					native_id = Utils.Alloc<byte>(byteCount_id + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_id + 1];
					native_id = stackallocBytes;
				}
				var id_offset = Utils.EncodeStringUTF8(id, native_id, byteCount_id);
				native_id[id_offset] = 0;
			}
			else native_id = null;

			var native_borders = borders ? (byte)1 : (byte)0;
			ImGuiNative.Columns(count, native_id, native_borders);
			// Freeing id native string
			if (byteCount_id > Utils.MaxStackallocSize)
				Utils.Free(native_id);
		}

		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		public static void NextColumn()
		{
			ImGuiNative.NextColumn();
		}

		/// <summary>
		/// get current column index<br/>
		/// </summary>
		public static int GetColumnIndex()
		{
			return ImGuiNative.GetColumnIndex();
		}

		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static float GetColumnWidth(int columnIndex)
		{
			return ImGuiNative.GetColumnWidth(columnIndex);
		}

		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static void SetColumnWidth(int columnIndex, float width)
		{
			ImGuiNative.SetColumnWidth(columnIndex, width);
		}

		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		public static float GetColumnOffset(int columnIndex)
		{
			return ImGuiNative.GetColumnOffset(columnIndex);
		}

		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		public static void SetColumnOffset(int columnIndex, float offsetX)
		{
			ImGuiNative.SetColumnOffset(columnIndex, offsetX);
		}

		public static int GetColumnsCount()
		{
			return ImGuiNative.GetColumnsCount();
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static byte BeginTabBar(ReadOnlySpan<char> strId, ImGuiTabBarFlags flags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.BeginTabBar(native_strId, flags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		public static void EndTabBar()
		{
			ImGuiNative.EndTabBar();
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static byte BeginTabItem(ReadOnlySpan<char> label, ReadOnlySpan<char> pOpen, ImGuiTabItemFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			return ImGuiNative.BeginTabItem(native_label, native_pOpen, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		public static void EndTabItem()
		{
			ImGuiNative.EndTabItem();
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static byte TabItemButton(ReadOnlySpan<char> label, ImGuiTabItemFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.TabItemButton(native_label, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		public static void SetTabItemClosed(ReadOnlySpan<char> tabOrDockedWindowLabel)
		{
			// Marshaling tabOrDockedWindowLabel to native string
			byte* native_tabOrDockedWindowLabel;
			var byteCount_tabOrDockedWindowLabel = 0;
			if (tabOrDockedWindowLabel != null)
			{
				byteCount_tabOrDockedWindowLabel = Encoding.UTF8.GetByteCount(tabOrDockedWindowLabel);
				if(byteCount_tabOrDockedWindowLabel > Utils.MaxStackallocSize)
				{
					native_tabOrDockedWindowLabel = Utils.Alloc<byte>(byteCount_tabOrDockedWindowLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_tabOrDockedWindowLabel + 1];
					native_tabOrDockedWindowLabel = stackallocBytes;
				}
				var tabOrDockedWindowLabel_offset = Utils.EncodeStringUTF8(tabOrDockedWindowLabel, native_tabOrDockedWindowLabel, byteCount_tabOrDockedWindowLabel);
				native_tabOrDockedWindowLabel[tabOrDockedWindowLabel_offset] = 0;
			}
			else native_tabOrDockedWindowLabel = null;

			ImGuiNative.SetTabItemClosed(native_tabOrDockedWindowLabel);
			// Freeing tabOrDockedWindowLabel native string
			if (byteCount_tabOrDockedWindowLabel > Utils.MaxStackallocSize)
				Utils.Free(native_tabOrDockedWindowLabel);
		}

		public static uint DockSpace(uint dockspaceId, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr windowClass)
		{
			return ImGuiNative.DockSpace(dockspaceId, size, flags, windowClass);
		}

		public static uint DockSpaceOverViewport(uint dockspaceId, ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr windowClass)
		{
			return ImGuiNative.DockSpaceOverViewport(dockspaceId, viewport, flags, windowClass);
		}

		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		public static void SetNextWindowDockID(uint dockId, ImGuiCond cond)
		{
			ImGuiNative.SetNextWindowDockID(dockId, cond);
		}

		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		public static void SetNextWindowClass(ImGuiWindowClassPtr windowClass)
		{
			ImGuiNative.SetNextWindowClass(windowClass);
		}

		public static uint GetWindowDockID()
		{
			return ImGuiNative.GetWindowDockID();
		}

		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		public static byte IsWindowDocked()
		{
			return ImGuiNative.IsWindowDocked();
		}

		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		public static void LogToTTY(int autoOpenDepth)
		{
			ImGuiNative.LogToTTY(autoOpenDepth);
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static void LogToFile(int autoOpenDepth, ReadOnlySpan<char> filename)
		{
			// Marshaling filename to native string
			byte* native_filename;
			var byteCount_filename = 0;
			if (filename != null)
			{
				byteCount_filename = Encoding.UTF8.GetByteCount(filename);
				if(byteCount_filename > Utils.MaxStackallocSize)
				{
					native_filename = Utils.Alloc<byte>(byteCount_filename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_filename + 1];
					native_filename = stackallocBytes;
				}
				var filename_offset = Utils.EncodeStringUTF8(filename, native_filename, byteCount_filename);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			ImGuiNative.LogToFile(autoOpenDepth, native_filename);
			// Freeing filename native string
			if (byteCount_filename > Utils.MaxStackallocSize)
				Utils.Free(native_filename);
		}

		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		public static void LogToClipboard(int autoOpenDepth)
		{
			ImGuiNative.LogToClipboard(autoOpenDepth);
		}

		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		public static void LogFinish()
		{
			ImGuiNative.LogFinish();
		}

		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		public static void LogButtons()
		{
			ImGuiNative.LogButtons();
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.LogText(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		public static byte BeginDragDropSource(ImGuiDragDropFlags flags)
		{
			return ImGuiNative.BeginDragDropSource(flags);
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static byte SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz, ImGuiCond cond)
		{
			// Marshaling type to native string
			byte* native_type;
			var byteCount_type = 0;
			if (type != null)
			{
				byteCount_type = Encoding.UTF8.GetByteCount(type);
				if(byteCount_type > Utils.MaxStackallocSize)
				{
					native_type = Utils.Alloc<byte>(byteCount_type + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_type + 1];
					native_type = stackallocBytes;
				}
				var type_offset = Utils.EncodeStringUTF8(type, native_type, byteCount_type);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			return ImGuiNative.SetDragDropPayload(native_type, (void*)data, sz, cond);
			// Freeing type native string
			if (byteCount_type > Utils.MaxStackallocSize)
				Utils.Free(native_type);
		}

		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		public static void EndDragDropSource()
		{
			ImGuiNative.EndDragDropSource();
		}

		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		public static byte BeginDragDropTarget()
		{
			return ImGuiNative.BeginDragDropTarget();
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type, ImGuiDragDropFlags flags)
		{
			// Marshaling type to native string
			byte* native_type;
			var byteCount_type = 0;
			if (type != null)
			{
				byteCount_type = Encoding.UTF8.GetByteCount(type);
				if(byteCount_type > Utils.MaxStackallocSize)
				{
					native_type = Utils.Alloc<byte>(byteCount_type + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_type + 1];
					native_type = stackallocBytes;
				}
				var type_offset = Utils.EncodeStringUTF8(type, native_type, byteCount_type);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			return ImGuiNative.AcceptDragDropPayload(native_type, flags);
			// Freeing type native string
			if (byteCount_type > Utils.MaxStackallocSize)
				Utils.Free(native_type);
		}

		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		public static void EndDragDropTarget()
		{
			ImGuiNative.EndDragDropTarget();
		}

		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		public static ImGuiPayloadPtr GetDragDropPayload()
		{
			return ImGuiNative.GetDragDropPayload();
		}

		public static void BeginDisabled(bool disabled)
		{
			var native_disabled = disabled ? (byte)1 : (byte)0;
			ImGuiNative.BeginDisabled(native_disabled);
		}

		public static void EndDisabled()
		{
			ImGuiNative.EndDisabled();
		}

		public static void PushClipRect(Vector2 clipRectMin, Vector2 clipRectMax, bool intersectWithCurrentClipRect)
		{
			var native_intersectWithCurrentClipRect = intersectWithCurrentClipRect ? (byte)1 : (byte)0;
			ImGuiNative.PushClipRect(clipRectMin, clipRectMax, native_intersectWithCurrentClipRect);
		}

		public static void PopClipRect()
		{
			ImGuiNative.PopClipRect();
		}

		/// <summary>
		/// make last item the default focused item of a newly appearing window.<br/>
		/// </summary>
		public static void SetItemDefaultFocus()
		{
			ImGuiNative.SetItemDefaultFocus();
		}

		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		public static void SetKeyboardFocusHere(int offset)
		{
			ImGuiNative.SetKeyboardFocusHere(offset);
		}

		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		public static void SetNavCursorVisible(bool visible)
		{
			var native_visible = visible ? (byte)1 : (byte)0;
			ImGuiNative.SetNavCursorVisible(native_visible);
		}

		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		public static void SetNextItemAllowOverlap()
		{
			ImGuiNative.SetNextItemAllowOverlap();
		}

		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		public static byte IsItemHovered(ImGuiHoveredFlags flags)
		{
			return ImGuiNative.IsItemHovered(flags);
		}

		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		public static byte IsItemActive()
		{
			return ImGuiNative.IsItemActive();
		}

		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		public static byte IsItemFocused()
		{
			return ImGuiNative.IsItemFocused();
		}

		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		public static byte IsItemClicked(ImGuiMouseButton mouseButton)
		{
			return ImGuiNative.IsItemClicked(mouseButton);
		}

		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		public static byte IsItemVisible()
		{
			return ImGuiNative.IsItemVisible();
		}

		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		public static byte IsItemEdited()
		{
			return ImGuiNative.IsItemEdited();
		}

		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		public static byte IsItemActivated()
		{
			return ImGuiNative.IsItemActivated();
		}

		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		public static byte IsItemDeactivated()
		{
			return ImGuiNative.IsItemDeactivated();
		}

		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		public static byte IsItemDeactivatedAfterEdit()
		{
			return ImGuiNative.IsItemDeactivatedAfterEdit();
		}

		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		public static byte IsItemToggledOpen()
		{
			return ImGuiNative.IsItemToggledOpen();
		}

		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		public static byte IsAnyItemHovered()
		{
			return ImGuiNative.IsAnyItemHovered();
		}

		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		public static byte IsAnyItemActive()
		{
			return ImGuiNative.IsAnyItemActive();
		}

		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		public static byte IsAnyItemFocused()
		{
			return ImGuiNative.IsAnyItemFocused();
		}

		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		public static uint GetItemID()
		{
			return ImGuiNative.GetItemID();
		}

		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static void GetItemRectMin(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetItemRectMin(native_pOut);
			}
		}

		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static void GetItemRectMax(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetItemRectMax(native_pOut);
			}
		}

		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		public static void GetItemRectSize(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetItemRectSize(native_pOut);
			}
		}

		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		public static ImGuiViewportPtr GetMainViewport()
		{
			return ImGuiNative.GetMainViewport();
		}

		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		public static ImDrawListPtr GetBackgroundDrawList(ImGuiViewportPtr viewport)
		{
			return ImGuiNative.GetBackgroundDrawList(viewport);
		}

		public static ImDrawListPtr GetForegroundDrawList(ImGuiViewportPtr viewport)
		{
			return ImGuiNative.GetForegroundDrawList(viewport);
		}

		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		public static byte IsRectVisible(Vector2 size)
		{
			return ImGuiNative.IsRectVisible(size);
		}

		public static byte IsRectVisible(Vector2 rectMin, Vector2 rectMax)
		{
			return ImGuiNative.IsRectVisible(rectMin, rectMax);
		}

		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		public static double GetTime()
		{
			return ImGuiNative.GetTime();
		}

		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		public static int GetFrameCount()
		{
			return ImGuiNative.GetFrameCount();
		}

		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		public static ImDrawListSharedDataPtr GetDrawListSharedData()
		{
			return ImGuiNative.GetDrawListSharedData();
		}

		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		public static ref byte GetStyleColorName(ImGuiCol idx)
		{
			var nativeResult = ImGuiNative.GetStyleColorName(idx);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		public static void SetStateStorage(ImGuiStoragePtr storage)
		{
			ImGuiNative.SetStateStorage(storage);
		}

		public static ImGuiStoragePtr GetStateStorage()
		{
			return ImGuiNative.GetStateStorage();
		}

		public static void CalcTextSize(ref Vector2 pOut, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, bool hideTextAfterDoubleHash, float wrapWidth)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			var native_hideTextAfterDoubleHash = hideTextAfterDoubleHash ? (byte)1 : (byte)0;
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.CalcTextSize(native_pOut, native_text, native_textEnd, native_hideTextAfterDoubleHash, wrapWidth);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
				// Freeing textEnd native string
				if (byteCount_textEnd > Utils.MaxStackallocSize)
					Utils.Free(native_textEnd);
			}
		}

		public static void ColorConvertU32ToFloat4(ref Vector4 pOut, uint _in)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImGuiNative.ColorConvertU32ToFloat4(native_pOut, _in);
			}
		}

		public static uint ColorConvertFloat4ToU32(Vector4 _in)
		{
			return ImGuiNative.ColorConvertFloat4ToU32(_in);
		}

		public static void ColorConvertRgBtoHSV(float r, float g, float b, ref float outH, ref float outS, ref float outV)
		{
			fixed (float* native_outH = &outH)
			fixed (float* native_outS = &outS)
			fixed (float* native_outV = &outV)
			{
				ImGuiNative.ColorConvertRgBtoHSV(r, g, b, native_outH, native_outS, native_outV);
			}
		}

		public static void ColorConvertHsVtoRGB(float h, float s, float v, ref float outR, ref float outG, ref float outB)
		{
			fixed (float* native_outR = &outR)
			fixed (float* native_outG = &outG)
			fixed (float* native_outB = &outB)
			{
				ImGuiNative.ColorConvertHsVtoRGB(h, s, v, native_outR, native_outG, native_outB);
			}
		}

		public static byte IsKeyDown(ImGuiKey key)
		{
			return ImGuiNative.IsKeyDown(key);
		}

		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		public static byte IsKeyPressed(ImGuiKey key, bool repeat)
		{
			var native_repeat = repeat ? (byte)1 : (byte)0;
			return ImGuiNative.IsKeyPressed(key, native_repeat);
		}

		public static byte IsKeyReleased(ImGuiKey key)
		{
			return ImGuiNative.IsKeyReleased(key);
		}

		public static byte IsKeyChordPressed(int keyChord)
		{
			return ImGuiNative.IsKeyChordPressed(keyChord);
		}

		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be &gt;1 if RepeatRate is small enough that DeltaTime &gt; RepeatRate<br/>
		/// </summary>
		public static int GetKeyPressedAmount(ImGuiKey key, float repeatDelay, float rate)
		{
			return ImGuiNative.GetKeyPressedAmount(key, repeatDelay, rate);
		}

		/// <summary>
		/// [DEBUG] returns English name of the key. Those names are provided for debugging purpose and are not meant to be saved persistently nor compared.<br/>
		/// </summary>
		public static ref byte GetKeyName(ImGuiKey key)
		{
			var nativeResult = ImGuiNative.GetKeyName(key);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		public static void SetNextFrameWantCaptureKeyboard(bool wantCaptureKeyboard)
		{
			var native_wantCaptureKeyboard = wantCaptureKeyboard ? (byte)1 : (byte)0;
			ImGuiNative.SetNextFrameWantCaptureKeyboard(native_wantCaptureKeyboard);
		}

		public static byte Shortcut(int keyChord, ImGuiInputFlags flags)
		{
			return ImGuiNative.Shortcut(keyChord, flags);
		}

		public static void SetNextItemShortcut(int keyChord, ImGuiInputFlags flags)
		{
			ImGuiNative.SetNextItemShortcut(keyChord, flags);
		}

		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		public static void SetItemKeyOwner(ImGuiKey key)
		{
			ImGuiNative.SetItemKeyOwner(key);
		}

		public static byte IsMouseDown(ImGuiMouseButton button)
		{
			return ImGuiNative.IsMouseDown(button);
		}

		public static byte IsMouseClicked(ImGuiMouseButton button, bool repeat)
		{
			var native_repeat = repeat ? (byte)1 : (byte)0;
			return ImGuiNative.IsMouseClicked(button, native_repeat);
		}

		public static byte IsMouseReleased(ImGuiMouseButton button)
		{
			return ImGuiNative.IsMouseReleased(button);
		}

		public static byte IsMouseDoubleClicked(ImGuiMouseButton button)
		{
			return ImGuiNative.IsMouseDoubleClicked(button);
		}

		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay &gt;= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		public static byte IsMouseReleasedWithDelay(ImGuiMouseButton button, float delay)
		{
			return ImGuiNative.IsMouseReleasedWithDelay(button, delay);
		}

		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		public static int GetMouseClickedCount(ImGuiMouseButton button)
		{
			return ImGuiNative.GetMouseClickedCount(button);
		}

		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		public static byte IsMouseHoveringRect(Vector2 rMin, Vector2 rMax, bool clip)
		{
			var native_clip = clip ? (byte)1 : (byte)0;
			return ImGuiNative.IsMouseHoveringRect(rMin, rMax, native_clip);
		}

		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		public static byte IsMousePosValid(ref Vector2 mousePos)
		{
			fixed (Vector2* native_mousePos = &mousePos)
			{
				var result = ImGuiNative.IsMousePosValid(native_mousePos);
				return result;
			}
		}

		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		public static byte IsAnyMouseDown()
		{
			return ImGuiNative.IsAnyMouseDown();
		}

		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		public static void GetMousePos(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetMousePos(native_pOut);
			}
		}

		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		public static void GetMousePosOnOpeningCurrentPopup(ref Vector2 pOut)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetMousePosOnOpeningCurrentPopup(native_pOut);
			}
		}

		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static byte IsMouseDragging(ImGuiMouseButton button, float lockThreshold)
		{
			return ImGuiNative.IsMouseDragging(button, lockThreshold);
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static void GetMouseDragDelta(ref Vector2 pOut, ImGuiMouseButton button, float lockThreshold)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetMouseDragDelta(native_pOut, button, lockThreshold);
			}
		}

		/// <summary>
		/// //<br/>
		/// </summary>
		public static void ResetMouseDragDelta(ImGuiMouseButton button)
		{
			ImGuiNative.ResetMouseDragDelta(button);
		}

		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		public static ImGuiMouseCursor GetMouseCursor()
		{
			return ImGuiNative.GetMouseCursor();
		}

		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		public static void SetMouseCursor(ImGuiMouseCursor cursorType)
		{
			ImGuiNative.SetMouseCursor(cursorType);
		}

		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		public static void SetNextFrameWantCaptureMouse(bool wantCaptureMouse)
		{
			var native_wantCaptureMouse = wantCaptureMouse ? (byte)1 : (byte)0;
			ImGuiNative.SetNextFrameWantCaptureMouse(native_wantCaptureMouse);
		}

		public static ref byte GetClipboardText()
		{
			var nativeResult = ImGuiNative.GetClipboardText();
			return ref *(byte*)&nativeResult;
		}

		public static void SetClipboardText(ReadOnlySpan<char> text)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.SetClipboardText(native_text);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		public static void LoadIniSettingsFromDisk(ReadOnlySpan<char> iniFilename)
		{
			// Marshaling iniFilename to native string
			byte* native_iniFilename;
			var byteCount_iniFilename = 0;
			if (iniFilename != null)
			{
				byteCount_iniFilename = Encoding.UTF8.GetByteCount(iniFilename);
				if(byteCount_iniFilename > Utils.MaxStackallocSize)
				{
					native_iniFilename = Utils.Alloc<byte>(byteCount_iniFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_iniFilename + 1];
					native_iniFilename = stackallocBytes;
				}
				var iniFilename_offset = Utils.EncodeStringUTF8(iniFilename, native_iniFilename, byteCount_iniFilename);
				native_iniFilename[iniFilename_offset] = 0;
			}
			else native_iniFilename = null;

			ImGuiNative.LoadIniSettingsFromDisk(native_iniFilename);
			// Freeing iniFilename native string
			if (byteCount_iniFilename > Utils.MaxStackallocSize)
				Utils.Free(native_iniFilename);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> iniData, uint iniSize)
		{
			// Marshaling iniData to native string
			byte* native_iniData;
			var byteCount_iniData = 0;
			if (iniData != null)
			{
				byteCount_iniData = Encoding.UTF8.GetByteCount(iniData);
				if(byteCount_iniData > Utils.MaxStackallocSize)
				{
					native_iniData = Utils.Alloc<byte>(byteCount_iniData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_iniData + 1];
					native_iniData = stackallocBytes;
				}
				var iniData_offset = Utils.EncodeStringUTF8(iniData, native_iniData, byteCount_iniData);
				native_iniData[iniData_offset] = 0;
			}
			else native_iniData = null;

			ImGuiNative.LoadIniSettingsFromMemory(native_iniData, iniSize);
			// Freeing iniData native string
			if (byteCount_iniData > Utils.MaxStackallocSize)
				Utils.Free(native_iniData);
		}

		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		public static void SaveIniSettingsToDisk(ReadOnlySpan<char> iniFilename)
		{
			// Marshaling iniFilename to native string
			byte* native_iniFilename;
			var byteCount_iniFilename = 0;
			if (iniFilename != null)
			{
				byteCount_iniFilename = Encoding.UTF8.GetByteCount(iniFilename);
				if(byteCount_iniFilename > Utils.MaxStackallocSize)
				{
					native_iniFilename = Utils.Alloc<byte>(byteCount_iniFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_iniFilename + 1];
					native_iniFilename = stackallocBytes;
				}
				var iniFilename_offset = Utils.EncodeStringUTF8(iniFilename, native_iniFilename, byteCount_iniFilename);
				native_iniFilename[iniFilename_offset] = 0;
			}
			else native_iniFilename = null;

			ImGuiNative.SaveIniSettingsToDisk(native_iniFilename);
			// Freeing iniFilename native string
			if (byteCount_iniFilename > Utils.MaxStackallocSize)
				Utils.Free(native_iniFilename);
		}

		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		public static ref byte SaveIniSettingsToMemory(ref uint outIniSize)
		{
			fixed (uint* native_outIniSize = &outIniSize)
			{
				var nativeResult = ImGuiNative.SaveIniSettingsToMemory(native_outIniSize);
				return ref *(byte*)&nativeResult;
			}
		}

		public static void DebugTextEncoding(ReadOnlySpan<char> text)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.DebugTextEncoding(native_text);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
		}

		public static void DebugFlashStyleColor(ImGuiCol idx)
		{
			ImGuiNative.DebugFlashStyleColor(idx);
		}

		public static void DebugStartItemPicker()
		{
			ImGuiNative.DebugStartItemPicker();
		}

		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		public static byte DebugCheckVersionAndDataLayout(ReadOnlySpan<char> versionStr, uint szIo, uint szStyle, uint szVec2, uint szVec4, uint szDrawvert, uint szDrawidx)
		{
			// Marshaling versionStr to native string
			byte* native_versionStr;
			var byteCount_versionStr = 0;
			if (versionStr != null)
			{
				byteCount_versionStr = Encoding.UTF8.GetByteCount(versionStr);
				if(byteCount_versionStr > Utils.MaxStackallocSize)
				{
					native_versionStr = Utils.Alloc<byte>(byteCount_versionStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_versionStr + 1];
					native_versionStr = stackallocBytes;
				}
				var versionStr_offset = Utils.EncodeStringUTF8(versionStr, native_versionStr, byteCount_versionStr);
				native_versionStr[versionStr_offset] = 0;
			}
			else native_versionStr = null;

			return ImGuiNative.DebugCheckVersionAndDataLayout(native_versionStr, szIo, szStyle, szVec2, szVec4, szDrawvert, szDrawidx);
			// Freeing versionStr native string
			if (byteCount_versionStr > Utils.MaxStackallocSize)
				Utils.Free(native_versionStr);
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		public static void DebugLog(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.DebugLog(native_fmt);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static void SetAllocatorFunctions(ImGuiMemAllocFunc allocFunc, ImGuiMemFreeFunc freeFunc, IntPtr userData)
		{
			ImGuiNative.SetAllocatorFunctions(allocFunc, freeFunc, (void*)userData);
		}

		public static void GetAllocatorFunctions(ref ImGuiMemAllocFunc pAllocFunc, ref ImGuiMemFreeFunc pFreeFunc, ref void* pUserData)
		{
			fixed (ImGuiMemAllocFunc* native_pAllocFunc = &pAllocFunc)
			fixed (ImGuiMemFreeFunc* native_pFreeFunc = &pFreeFunc)
			fixed (void** native_pUserData = &pUserData)
			{
				ImGuiNative.GetAllocatorFunctions(native_pAllocFunc, native_pFreeFunc, native_pUserData);
			}
		}

		public static IntPtr MemAlloc(uint size)
		{
			return (IntPtr)ImGuiNative.MemAlloc(size);
		}

		public static void MemFree(IntPtr ptr)
		{
			ImGuiNative.MemFree((void*)ptr);
		}

		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		public static void UpdatePlatformWindows()
		{
			ImGuiNative.UpdatePlatformWindows();
		}

		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		public static void RenderPlatformWindowsDefault(IntPtr platformRenderArg, IntPtr rendererRenderArg)
		{
			ImGuiNative.RenderPlatformWindowsDefault((void*)platformRenderArg, (void*)rendererRenderArg);
		}

		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		public static void DestroyPlatformWindows()
		{
			ImGuiNative.DestroyPlatformWindows();
		}

		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		public static ImGuiViewportPtr FindViewportByID(uint id)
		{
			return ImGuiNative.FindViewportByID(id);
		}

		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		public static ImGuiViewportPtr FindViewportByPlatformHandle(IntPtr platformHandle)
		{
			return ImGuiNative.FindViewportByPlatformHandle((void*)platformHandle);
		}

		public static uint ImHashData(IntPtr data, uint dataSize, uint seed)
		{
			return ImGuiNative.ImHashData((void*)data, dataSize, seed);
		}

		public static uint ImHashStr(ReadOnlySpan<char> data, uint dataSize, uint seed)
		{
			// Marshaling data to native string
			byte* native_data;
			var byteCount_data = 0;
			if (data != null)
			{
				byteCount_data = Encoding.UTF8.GetByteCount(data);
				if(byteCount_data > Utils.MaxStackallocSize)
				{
					native_data = Utils.Alloc<byte>(byteCount_data + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_data + 1];
					native_data = stackallocBytes;
				}
				var data_offset = Utils.EncodeStringUTF8(data, native_data, byteCount_data);
				native_data[data_offset] = 0;
			}
			else native_data = null;

			return ImGuiNative.ImHashStr(native_data, dataSize, seed);
			// Freeing data native string
			if (byteCount_data > Utils.MaxStackallocSize)
				Utils.Free(native_data);
		}

		public static void ImQsort(IntPtr _base, uint count, uint sizeOfElement, IgImQsortCompareFunc compareFunc)
		{
			ImGuiNative.ImQsort((void*)_base, count, sizeOfElement, compareFunc);
		}

		public static uint ImAlphaBlendColors(uint colA, uint colB)
		{
			return ImGuiNative.ImAlphaBlendColors(colA, colB);
		}

		public static byte ImIsPowerOfTwo(int v)
		{
			return ImGuiNative.ImIsPowerOfTwo(v);
		}

		public static byte ImIsPowerOfTwo(ulong v)
		{
			return ImGuiNative.ImIsPowerOfTwo(v);
		}

		public static int ImUpperPowerOfTwo(int v)
		{
			return ImGuiNative.ImUpperPowerOfTwo(v);
		}

		public static uint ImCountSetBits(uint v)
		{
			return ImGuiNative.ImCountSetBits(v);
		}

		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		public static int ImStricmp(ReadOnlySpan<char> str1, ReadOnlySpan<char> str2)
		{
			// Marshaling str1 to native string
			byte* native_str1;
			var byteCount_str1 = 0;
			if (str1 != null)
			{
				byteCount_str1 = Encoding.UTF8.GetByteCount(str1);
				if(byteCount_str1 > Utils.MaxStackallocSize)
				{
					native_str1 = Utils.Alloc<byte>(byteCount_str1 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str1 + 1];
					native_str1 = stackallocBytes;
				}
				var str1_offset = Utils.EncodeStringUTF8(str1, native_str1, byteCount_str1);
				native_str1[str1_offset] = 0;
			}
			else native_str1 = null;

			// Marshaling str2 to native string
			byte* native_str2;
			var byteCount_str2 = 0;
			if (str2 != null)
			{
				byteCount_str2 = Encoding.UTF8.GetByteCount(str2);
				if(byteCount_str2 > Utils.MaxStackallocSize)
				{
					native_str2 = Utils.Alloc<byte>(byteCount_str2 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str2 + 1];
					native_str2 = stackallocBytes;
				}
				var str2_offset = Utils.EncodeStringUTF8(str2, native_str2, byteCount_str2);
				native_str2[str2_offset] = 0;
			}
			else native_str2 = null;

			return ImGuiNative.ImStricmp(native_str1, native_str2);
			// Freeing str1 native string
			if (byteCount_str1 > Utils.MaxStackallocSize)
				Utils.Free(native_str1);
			// Freeing str2 native string
			if (byteCount_str2 > Utils.MaxStackallocSize)
				Utils.Free(native_str2);
		}

		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		public static int ImStrnicmp(ReadOnlySpan<char> str1, ReadOnlySpan<char> str2, uint count)
		{
			// Marshaling str1 to native string
			byte* native_str1;
			var byteCount_str1 = 0;
			if (str1 != null)
			{
				byteCount_str1 = Encoding.UTF8.GetByteCount(str1);
				if(byteCount_str1 > Utils.MaxStackallocSize)
				{
					native_str1 = Utils.Alloc<byte>(byteCount_str1 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str1 + 1];
					native_str1 = stackallocBytes;
				}
				var str1_offset = Utils.EncodeStringUTF8(str1, native_str1, byteCount_str1);
				native_str1[str1_offset] = 0;
			}
			else native_str1 = null;

			// Marshaling str2 to native string
			byte* native_str2;
			var byteCount_str2 = 0;
			if (str2 != null)
			{
				byteCount_str2 = Encoding.UTF8.GetByteCount(str2);
				if(byteCount_str2 > Utils.MaxStackallocSize)
				{
					native_str2 = Utils.Alloc<byte>(byteCount_str2 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str2 + 1];
					native_str2 = stackallocBytes;
				}
				var str2_offset = Utils.EncodeStringUTF8(str2, native_str2, byteCount_str2);
				native_str2[str2_offset] = 0;
			}
			else native_str2 = null;

			return ImGuiNative.ImStrnicmp(native_str1, native_str2, count);
			// Freeing str1 native string
			if (byteCount_str1 > Utils.MaxStackallocSize)
				Utils.Free(native_str1);
			// Freeing str2 native string
			if (byteCount_str2 > Utils.MaxStackallocSize)
				Utils.Free(native_str2);
		}

		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		public static void ImStrncpy(ReadOnlySpan<char> dst, ReadOnlySpan<char> src, uint count)
		{
			// Marshaling dst to native string
			byte* native_dst;
			var byteCount_dst = 0;
			if (dst != null)
			{
				byteCount_dst = Encoding.UTF8.GetByteCount(dst);
				if(byteCount_dst > Utils.MaxStackallocSize)
				{
					native_dst = Utils.Alloc<byte>(byteCount_dst + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_dst + 1];
					native_dst = stackallocBytes;
				}
				var dst_offset = Utils.EncodeStringUTF8(dst, native_dst, byteCount_dst);
				native_dst[dst_offset] = 0;
			}
			else native_dst = null;

			// Marshaling src to native string
			byte* native_src;
			var byteCount_src = 0;
			if (src != null)
			{
				byteCount_src = Encoding.UTF8.GetByteCount(src);
				if(byteCount_src > Utils.MaxStackallocSize)
				{
					native_src = Utils.Alloc<byte>(byteCount_src + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_src + 1];
					native_src = stackallocBytes;
				}
				var src_offset = Utils.EncodeStringUTF8(src, native_src, byteCount_src);
				native_src[src_offset] = 0;
			}
			else native_src = null;

			ImGuiNative.ImStrncpy(native_dst, native_src, count);
			// Freeing dst native string
			if (byteCount_dst > Utils.MaxStackallocSize)
				Utils.Free(native_dst);
			// Freeing src native string
			if (byteCount_src > Utils.MaxStackallocSize)
				Utils.Free(native_src);
		}

		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		public static ref byte ImStrdup(ReadOnlySpan<char> str)
		{
			// Marshaling str to native string
			byte* native_str;
			var byteCount_str = 0;
			if (str != null)
			{
				byteCount_str = Encoding.UTF8.GetByteCount(str);
				if(byteCount_str > Utils.MaxStackallocSize)
				{
					native_str = Utils.Alloc<byte>(byteCount_str + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str + 1];
					native_str = stackallocBytes;
				}
				var str_offset = Utils.EncodeStringUTF8(str, native_str, byteCount_str);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			var nativeResult = ImGuiNative.ImStrdup(native_str);
			// Freeing str native string
			if (byteCount_str > Utils.MaxStackallocSize)
				Utils.Free(native_str);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		public static ref byte ImStrdupcpy(ReadOnlySpan<char> dst, ref uint pDstSize, ReadOnlySpan<char> str)
		{
			// Marshaling dst to native string
			byte* native_dst;
			var byteCount_dst = 0;
			if (dst != null)
			{
				byteCount_dst = Encoding.UTF8.GetByteCount(dst);
				if(byteCount_dst > Utils.MaxStackallocSize)
				{
					native_dst = Utils.Alloc<byte>(byteCount_dst + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_dst + 1];
					native_dst = stackallocBytes;
				}
				var dst_offset = Utils.EncodeStringUTF8(dst, native_dst, byteCount_dst);
				native_dst[dst_offset] = 0;
			}
			else native_dst = null;

			// Marshaling str to native string
			byte* native_str;
			var byteCount_str = 0;
			if (str != null)
			{
				byteCount_str = Encoding.UTF8.GetByteCount(str);
				if(byteCount_str > Utils.MaxStackallocSize)
				{
					native_str = Utils.Alloc<byte>(byteCount_str + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str + 1];
					native_str = stackallocBytes;
				}
				var str_offset = Utils.EncodeStringUTF8(str, native_str, byteCount_str);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			fixed (uint* native_pDstSize = &pDstSize)
			{
				var nativeResult = ImGuiNative.ImStrdupcpy(native_dst, native_pDstSize, native_str);
				// Freeing dst native string
				if (byteCount_dst > Utils.MaxStackallocSize)
					Utils.Free(native_dst);
				// Freeing str native string
				if (byteCount_str > Utils.MaxStackallocSize)
					Utils.Free(native_str);
				return ref *(byte*)&nativeResult;
			}
		}

		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		public static ref byte ImStrchrRange(ReadOnlySpan<char> strBegin, ReadOnlySpan<char> strEnd, bool c)
		{
			// Marshaling strBegin to native string
			byte* native_strBegin;
			var byteCount_strBegin = 0;
			if (strBegin != null)
			{
				byteCount_strBegin = Encoding.UTF8.GetByteCount(strBegin);
				if(byteCount_strBegin > Utils.MaxStackallocSize)
				{
					native_strBegin = Utils.Alloc<byte>(byteCount_strBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strBegin + 1];
					native_strBegin = stackallocBytes;
				}
				var strBegin_offset = Utils.EncodeStringUTF8(strBegin, native_strBegin, byteCount_strBegin);
				native_strBegin[strBegin_offset] = 0;
			}
			else native_strBegin = null;

			// Marshaling strEnd to native string
			byte* native_strEnd;
			var byteCount_strEnd = 0;
			if (strEnd != null)
			{
				byteCount_strEnd = Encoding.UTF8.GetByteCount(strEnd);
				if(byteCount_strEnd > Utils.MaxStackallocSize)
				{
					native_strEnd = Utils.Alloc<byte>(byteCount_strEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strEnd + 1];
					native_strEnd = stackallocBytes;
				}
				var strEnd_offset = Utils.EncodeStringUTF8(strEnd, native_strEnd, byteCount_strEnd);
				native_strEnd[strEnd_offset] = 0;
			}
			else native_strEnd = null;

			var native_c = c ? (byte)1 : (byte)0;
			var nativeResult = ImGuiNative.ImStrchrRange(native_strBegin, native_strEnd, native_c);
			// Freeing strBegin native string
			if (byteCount_strBegin > Utils.MaxStackallocSize)
				Utils.Free(native_strBegin);
			// Freeing strEnd native string
			if (byteCount_strEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strEnd);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		public static ref byte ImStreolRange(ReadOnlySpan<char> str, ReadOnlySpan<char> strEnd)
		{
			// Marshaling str to native string
			byte* native_str;
			var byteCount_str = 0;
			if (str != null)
			{
				byteCount_str = Encoding.UTF8.GetByteCount(str);
				if(byteCount_str > Utils.MaxStackallocSize)
				{
					native_str = Utils.Alloc<byte>(byteCount_str + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str + 1];
					native_str = stackallocBytes;
				}
				var str_offset = Utils.EncodeStringUTF8(str, native_str, byteCount_str);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			// Marshaling strEnd to native string
			byte* native_strEnd;
			var byteCount_strEnd = 0;
			if (strEnd != null)
			{
				byteCount_strEnd = Encoding.UTF8.GetByteCount(strEnd);
				if(byteCount_strEnd > Utils.MaxStackallocSize)
				{
					native_strEnd = Utils.Alloc<byte>(byteCount_strEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strEnd + 1];
					native_strEnd = stackallocBytes;
				}
				var strEnd_offset = Utils.EncodeStringUTF8(strEnd, native_strEnd, byteCount_strEnd);
				native_strEnd[strEnd_offset] = 0;
			}
			else native_strEnd = null;

			var nativeResult = ImGuiNative.ImStreolRange(native_str, native_strEnd);
			// Freeing str native string
			if (byteCount_str > Utils.MaxStackallocSize)
				Utils.Free(native_str);
			// Freeing strEnd native string
			if (byteCount_strEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strEnd);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		public static ref byte ImStristr(ReadOnlySpan<char> haystack, ReadOnlySpan<char> haystackEnd, ReadOnlySpan<char> needle, ReadOnlySpan<char> needleEnd)
		{
			// Marshaling haystack to native string
			byte* native_haystack;
			var byteCount_haystack = 0;
			if (haystack != null)
			{
				byteCount_haystack = Encoding.UTF8.GetByteCount(haystack);
				if(byteCount_haystack > Utils.MaxStackallocSize)
				{
					native_haystack = Utils.Alloc<byte>(byteCount_haystack + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_haystack + 1];
					native_haystack = stackallocBytes;
				}
				var haystack_offset = Utils.EncodeStringUTF8(haystack, native_haystack, byteCount_haystack);
				native_haystack[haystack_offset] = 0;
			}
			else native_haystack = null;

			// Marshaling haystackEnd to native string
			byte* native_haystackEnd;
			var byteCount_haystackEnd = 0;
			if (haystackEnd != null)
			{
				byteCount_haystackEnd = Encoding.UTF8.GetByteCount(haystackEnd);
				if(byteCount_haystackEnd > Utils.MaxStackallocSize)
				{
					native_haystackEnd = Utils.Alloc<byte>(byteCount_haystackEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_haystackEnd + 1];
					native_haystackEnd = stackallocBytes;
				}
				var haystackEnd_offset = Utils.EncodeStringUTF8(haystackEnd, native_haystackEnd, byteCount_haystackEnd);
				native_haystackEnd[haystackEnd_offset] = 0;
			}
			else native_haystackEnd = null;

			// Marshaling needle to native string
			byte* native_needle;
			var byteCount_needle = 0;
			if (needle != null)
			{
				byteCount_needle = Encoding.UTF8.GetByteCount(needle);
				if(byteCount_needle > Utils.MaxStackallocSize)
				{
					native_needle = Utils.Alloc<byte>(byteCount_needle + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_needle + 1];
					native_needle = stackallocBytes;
				}
				var needle_offset = Utils.EncodeStringUTF8(needle, native_needle, byteCount_needle);
				native_needle[needle_offset] = 0;
			}
			else native_needle = null;

			// Marshaling needleEnd to native string
			byte* native_needleEnd;
			var byteCount_needleEnd = 0;
			if (needleEnd != null)
			{
				byteCount_needleEnd = Encoding.UTF8.GetByteCount(needleEnd);
				if(byteCount_needleEnd > Utils.MaxStackallocSize)
				{
					native_needleEnd = Utils.Alloc<byte>(byteCount_needleEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_needleEnd + 1];
					native_needleEnd = stackallocBytes;
				}
				var needleEnd_offset = Utils.EncodeStringUTF8(needleEnd, native_needleEnd, byteCount_needleEnd);
				native_needleEnd[needleEnd_offset] = 0;
			}
			else native_needleEnd = null;

			var nativeResult = ImGuiNative.ImStristr(native_haystack, native_haystackEnd, native_needle, native_needleEnd);
			// Freeing haystack native string
			if (byteCount_haystack > Utils.MaxStackallocSize)
				Utils.Free(native_haystack);
			// Freeing haystackEnd native string
			if (byteCount_haystackEnd > Utils.MaxStackallocSize)
				Utils.Free(native_haystackEnd);
			// Freeing needle native string
			if (byteCount_needle > Utils.MaxStackallocSize)
				Utils.Free(native_needle);
			// Freeing needleEnd native string
			if (byteCount_needleEnd > Utils.MaxStackallocSize)
				Utils.Free(native_needleEnd);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		public static void ImStrTrimBlanks(ReadOnlySpan<char> str)
		{
			// Marshaling str to native string
			byte* native_str;
			var byteCount_str = 0;
			if (str != null)
			{
				byteCount_str = Encoding.UTF8.GetByteCount(str);
				if(byteCount_str > Utils.MaxStackallocSize)
				{
					native_str = Utils.Alloc<byte>(byteCount_str + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str + 1];
					native_str = stackallocBytes;
				}
				var str_offset = Utils.EncodeStringUTF8(str, native_str, byteCount_str);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			ImGuiNative.ImStrTrimBlanks(native_str);
			// Freeing str native string
			if (byteCount_str > Utils.MaxStackallocSize)
				Utils.Free(native_str);
		}

		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		public static ref byte ImStrSkipBlank(ReadOnlySpan<char> str)
		{
			// Marshaling str to native string
			byte* native_str;
			var byteCount_str = 0;
			if (str != null)
			{
				byteCount_str = Encoding.UTF8.GetByteCount(str);
				if(byteCount_str > Utils.MaxStackallocSize)
				{
					native_str = Utils.Alloc<byte>(byteCount_str + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_str + 1];
					native_str = stackallocBytes;
				}
				var str_offset = Utils.EncodeStringUTF8(str, native_str, byteCount_str);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			var nativeResult = ImGuiNative.ImStrSkipBlank(native_str);
			// Freeing str native string
			if (byteCount_str > Utils.MaxStackallocSize)
				Utils.Free(native_str);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		public static int ImStrlenW(ref ushort str)
		{
			fixed (ushort* native_str = &str)
			{
				var result = ImGuiNative.ImStrlenW(native_str);
				return result;
			}
		}

		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		public static ref byte ImStrbol(ReadOnlySpan<char> bufMidLine, ReadOnlySpan<char> bufBegin)
		{
			// Marshaling bufMidLine to native string
			byte* native_bufMidLine;
			var byteCount_bufMidLine = 0;
			if (bufMidLine != null)
			{
				byteCount_bufMidLine = Encoding.UTF8.GetByteCount(bufMidLine);
				if(byteCount_bufMidLine > Utils.MaxStackallocSize)
				{
					native_bufMidLine = Utils.Alloc<byte>(byteCount_bufMidLine + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_bufMidLine + 1];
					native_bufMidLine = stackallocBytes;
				}
				var bufMidLine_offset = Utils.EncodeStringUTF8(bufMidLine, native_bufMidLine, byteCount_bufMidLine);
				native_bufMidLine[bufMidLine_offset] = 0;
			}
			else native_bufMidLine = null;

			// Marshaling bufBegin to native string
			byte* native_bufBegin;
			var byteCount_bufBegin = 0;
			if (bufBegin != null)
			{
				byteCount_bufBegin = Encoding.UTF8.GetByteCount(bufBegin);
				if(byteCount_bufBegin > Utils.MaxStackallocSize)
				{
					native_bufBegin = Utils.Alloc<byte>(byteCount_bufBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_bufBegin + 1];
					native_bufBegin = stackallocBytes;
				}
				var bufBegin_offset = Utils.EncodeStringUTF8(bufBegin, native_bufBegin, byteCount_bufBegin);
				native_bufBegin[bufBegin_offset] = 0;
			}
			else native_bufBegin = null;

			var nativeResult = ImGuiNative.ImStrbol(native_bufMidLine, native_bufBegin);
			// Freeing bufMidLine native string
			if (byteCount_bufMidLine > Utils.MaxStackallocSize)
				Utils.Free(native_bufMidLine);
			// Freeing bufBegin native string
			if (byteCount_bufBegin > Utils.MaxStackallocSize)
				Utils.Free(native_bufBegin);
			return ref *(byte*)&nativeResult;
		}

		public static byte ImToUpper(bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			return ImGuiNative.ImToUpper(native_c);
		}

		public static byte ImCharIsBlankA(bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			return ImGuiNative.ImCharIsBlankA(native_c);
		}

		public static byte ImCharIsBlankW(uint c)
		{
			return ImGuiNative.ImCharIsBlankW(c);
		}

		public static byte ImCharIsXditA(bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			return ImGuiNative.ImCharIsXditA(native_c);
		}

		public static int ImFormatString(ReadOnlySpan<char> buf, uint bufSize, ReadOnlySpan<char> fmt)
		{
			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			return ImGuiNative.ImFormatString(native_buf, bufSize, native_fmt);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
			// Freeing fmt native string
			if (byteCount_fmt > Utils.MaxStackallocSize)
				Utils.Free(native_fmt);
		}

		public static void ImFormatStringToTempBuffer(ref byte* outBuf, ref byte* outBufEnd, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* native_fmt;
			var byteCount_fmt = 0;
			if (fmt != null)
			{
				byteCount_fmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCount_fmt > Utils.MaxStackallocSize)
				{
					native_fmt = Utils.Alloc<byte>(byteCount_fmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmt + 1];
					native_fmt = stackallocBytes;
				}
				var fmt_offset = Utils.EncodeStringUTF8(fmt, native_fmt, byteCount_fmt);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			fixed (byte** native_outBuf = &outBuf)
			fixed (byte** native_outBufEnd = &outBufEnd)
			{
				ImGuiNative.ImFormatStringToTempBuffer(native_outBuf, native_outBufEnd, native_fmt);
				// Freeing fmt native string
				if (byteCount_fmt > Utils.MaxStackallocSize)
					Utils.Free(native_fmt);
			}
		}

		public static ref byte ImParseFormatFindStart(ReadOnlySpan<char> format)
		{
			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var nativeResult = ImGuiNative.ImParseFormatFindStart(native_format);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
			return ref *(byte*)&nativeResult;
		}

		public static ref byte ImParseFormatFindEnd(ReadOnlySpan<char> format)
		{
			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var nativeResult = ImGuiNative.ImParseFormatFindEnd(native_format);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
			return ref *(byte*)&nativeResult;
		}

		public static ref byte ImParseFormatTrimDecorations(ReadOnlySpan<char> format, ReadOnlySpan<char> buf, uint bufSize)
		{
			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			var nativeResult = ImGuiNative.ImParseFormatTrimDecorations(native_format, native_buf, bufSize);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
			return ref *(byte*)&nativeResult;
		}

		public static void ImParseFormatSanitizeForPrinting(ReadOnlySpan<char> fmtIn, ReadOnlySpan<char> fmtOut, uint fmtOutSize)
		{
			// Marshaling fmtIn to native string
			byte* native_fmtIn;
			var byteCount_fmtIn = 0;
			if (fmtIn != null)
			{
				byteCount_fmtIn = Encoding.UTF8.GetByteCount(fmtIn);
				if(byteCount_fmtIn > Utils.MaxStackallocSize)
				{
					native_fmtIn = Utils.Alloc<byte>(byteCount_fmtIn + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmtIn + 1];
					native_fmtIn = stackallocBytes;
				}
				var fmtIn_offset = Utils.EncodeStringUTF8(fmtIn, native_fmtIn, byteCount_fmtIn);
				native_fmtIn[fmtIn_offset] = 0;
			}
			else native_fmtIn = null;

			// Marshaling fmtOut to native string
			byte* native_fmtOut;
			var byteCount_fmtOut = 0;
			if (fmtOut != null)
			{
				byteCount_fmtOut = Encoding.UTF8.GetByteCount(fmtOut);
				if(byteCount_fmtOut > Utils.MaxStackallocSize)
				{
					native_fmtOut = Utils.Alloc<byte>(byteCount_fmtOut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmtOut + 1];
					native_fmtOut = stackallocBytes;
				}
				var fmtOut_offset = Utils.EncodeStringUTF8(fmtOut, native_fmtOut, byteCount_fmtOut);
				native_fmtOut[fmtOut_offset] = 0;
			}
			else native_fmtOut = null;

			ImGuiNative.ImParseFormatSanitizeForPrinting(native_fmtIn, native_fmtOut, fmtOutSize);
			// Freeing fmtIn native string
			if (byteCount_fmtIn > Utils.MaxStackallocSize)
				Utils.Free(native_fmtIn);
			// Freeing fmtOut native string
			if (byteCount_fmtOut > Utils.MaxStackallocSize)
				Utils.Free(native_fmtOut);
		}

		public static ref byte ImParseFormatSanitizeForScanning(ReadOnlySpan<char> fmtIn, ReadOnlySpan<char> fmtOut, uint fmtOutSize)
		{
			// Marshaling fmtIn to native string
			byte* native_fmtIn;
			var byteCount_fmtIn = 0;
			if (fmtIn != null)
			{
				byteCount_fmtIn = Encoding.UTF8.GetByteCount(fmtIn);
				if(byteCount_fmtIn > Utils.MaxStackallocSize)
				{
					native_fmtIn = Utils.Alloc<byte>(byteCount_fmtIn + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmtIn + 1];
					native_fmtIn = stackallocBytes;
				}
				var fmtIn_offset = Utils.EncodeStringUTF8(fmtIn, native_fmtIn, byteCount_fmtIn);
				native_fmtIn[fmtIn_offset] = 0;
			}
			else native_fmtIn = null;

			// Marshaling fmtOut to native string
			byte* native_fmtOut;
			var byteCount_fmtOut = 0;
			if (fmtOut != null)
			{
				byteCount_fmtOut = Encoding.UTF8.GetByteCount(fmtOut);
				if(byteCount_fmtOut > Utils.MaxStackallocSize)
				{
					native_fmtOut = Utils.Alloc<byte>(byteCount_fmtOut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_fmtOut + 1];
					native_fmtOut = stackallocBytes;
				}
				var fmtOut_offset = Utils.EncodeStringUTF8(fmtOut, native_fmtOut, byteCount_fmtOut);
				native_fmtOut[fmtOut_offset] = 0;
			}
			else native_fmtOut = null;

			var nativeResult = ImGuiNative.ImParseFormatSanitizeForScanning(native_fmtIn, native_fmtOut, fmtOutSize);
			// Freeing fmtIn native string
			if (byteCount_fmtIn > Utils.MaxStackallocSize)
				Utils.Free(native_fmtIn);
			// Freeing fmtOut native string
			if (byteCount_fmtOut > Utils.MaxStackallocSize)
				Utils.Free(native_fmtOut);
			return ref *(byte*)&nativeResult;
		}

		public static int ImParseFormatPrecision(ReadOnlySpan<char> format, int defaultValue)
		{
			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.ImParseFormatPrecision(native_format, defaultValue);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		public static ref byte ImTextCharToUtf8(ReadOnlySpan<char> outBuf, uint c)
		{
			// Marshaling outBuf to native string
			byte* native_outBuf;
			var byteCount_outBuf = 0;
			if (outBuf != null)
			{
				byteCount_outBuf = Encoding.UTF8.GetByteCount(outBuf);
				if(byteCount_outBuf > Utils.MaxStackallocSize)
				{
					native_outBuf = Utils.Alloc<byte>(byteCount_outBuf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outBuf + 1];
					native_outBuf = stackallocBytes;
				}
				var outBuf_offset = Utils.EncodeStringUTF8(outBuf, native_outBuf, byteCount_outBuf);
				native_outBuf[outBuf_offset] = 0;
			}
			else native_outBuf = null;

			var nativeResult = ImGuiNative.ImTextCharToUtf8(native_outBuf, c);
			// Freeing outBuf native string
			if (byteCount_outBuf > Utils.MaxStackallocSize)
				Utils.Free(native_outBuf);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrToUtf8(ReadOnlySpan<char> outBuf, int outBufSize, ref ushort inText, ref ushort inTextEnd)
		{
			// Marshaling outBuf to native string
			byte* native_outBuf;
			var byteCount_outBuf = 0;
			if (outBuf != null)
			{
				byteCount_outBuf = Encoding.UTF8.GetByteCount(outBuf);
				if(byteCount_outBuf > Utils.MaxStackallocSize)
				{
					native_outBuf = Utils.Alloc<byte>(byteCount_outBuf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outBuf + 1];
					native_outBuf = stackallocBytes;
				}
				var outBuf_offset = Utils.EncodeStringUTF8(outBuf, native_outBuf, byteCount_outBuf);
				native_outBuf[outBuf_offset] = 0;
			}
			else native_outBuf = null;

			fixed (ushort* native_inText = &inText)
			fixed (ushort* native_inTextEnd = &inTextEnd)
			{
				var result = ImGuiNative.ImTextStrToUtf8(native_outBuf, outBufSize, native_inText, native_inTextEnd);
				// Freeing outBuf native string
				if (byteCount_outBuf > Utils.MaxStackallocSize)
					Utils.Free(native_outBuf);
				return result;
			}
		}

		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextCharFromUtf8(ref uint outChar, ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* native_inText;
			var byteCount_inText = 0;
			if (inText != null)
			{
				byteCount_inText = Encoding.UTF8.GetByteCount(inText);
				if(byteCount_inText > Utils.MaxStackallocSize)
				{
					native_inText = Utils.Alloc<byte>(byteCount_inText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inText + 1];
					native_inText = stackallocBytes;
				}
				var inText_offset = Utils.EncodeStringUTF8(inText, native_inText, byteCount_inText);
				native_inText[inText_offset] = 0;
			}
			else native_inText = null;

			// Marshaling inTextEnd to native string
			byte* native_inTextEnd;
			var byteCount_inTextEnd = 0;
			if (inTextEnd != null)
			{
				byteCount_inTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCount_inTextEnd > Utils.MaxStackallocSize)
				{
					native_inTextEnd = Utils.Alloc<byte>(byteCount_inTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextEnd + 1];
					native_inTextEnd = stackallocBytes;
				}
				var inTextEnd_offset = Utils.EncodeStringUTF8(inTextEnd, native_inTextEnd, byteCount_inTextEnd);
				native_inTextEnd[inTextEnd_offset] = 0;
			}
			else native_inTextEnd = null;

			fixed (uint* native_outChar = &outChar)
			{
				var result = ImGuiNative.ImTextCharFromUtf8(native_outChar, native_inText, native_inTextEnd);
				// Freeing inText native string
				if (byteCount_inText > Utils.MaxStackallocSize)
					Utils.Free(native_inText);
				// Freeing inTextEnd native string
				if (byteCount_inTextEnd > Utils.MaxStackallocSize)
					Utils.Free(native_inTextEnd);
				return result;
			}
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrFromUtf8(ref ushort outBuf, int outBufSize, ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd, ref byte* inRemaining)
		{
			// Marshaling inText to native string
			byte* native_inText;
			var byteCount_inText = 0;
			if (inText != null)
			{
				byteCount_inText = Encoding.UTF8.GetByteCount(inText);
				if(byteCount_inText > Utils.MaxStackallocSize)
				{
					native_inText = Utils.Alloc<byte>(byteCount_inText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inText + 1];
					native_inText = stackallocBytes;
				}
				var inText_offset = Utils.EncodeStringUTF8(inText, native_inText, byteCount_inText);
				native_inText[inText_offset] = 0;
			}
			else native_inText = null;

			// Marshaling inTextEnd to native string
			byte* native_inTextEnd;
			var byteCount_inTextEnd = 0;
			if (inTextEnd != null)
			{
				byteCount_inTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCount_inTextEnd > Utils.MaxStackallocSize)
				{
					native_inTextEnd = Utils.Alloc<byte>(byteCount_inTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextEnd + 1];
					native_inTextEnd = stackallocBytes;
				}
				var inTextEnd_offset = Utils.EncodeStringUTF8(inTextEnd, native_inTextEnd, byteCount_inTextEnd);
				native_inTextEnd[inTextEnd_offset] = 0;
			}
			else native_inTextEnd = null;

			fixed (ushort* native_outBuf = &outBuf)
			fixed (byte** native_inRemaining = &inRemaining)
			{
				var result = ImGuiNative.ImTextStrFromUtf8(native_outBuf, outBufSize, native_inText, native_inTextEnd, native_inRemaining);
				// Freeing inText native string
				if (byteCount_inText > Utils.MaxStackallocSize)
					Utils.Free(native_inText);
				// Freeing inTextEnd native string
				if (byteCount_inTextEnd > Utils.MaxStackallocSize)
					Utils.Free(native_inTextEnd);
				return result;
			}
		}

		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		public static int ImTextCountCharsFromUtf8(ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* native_inText;
			var byteCount_inText = 0;
			if (inText != null)
			{
				byteCount_inText = Encoding.UTF8.GetByteCount(inText);
				if(byteCount_inText > Utils.MaxStackallocSize)
				{
					native_inText = Utils.Alloc<byte>(byteCount_inText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inText + 1];
					native_inText = stackallocBytes;
				}
				var inText_offset = Utils.EncodeStringUTF8(inText, native_inText, byteCount_inText);
				native_inText[inText_offset] = 0;
			}
			else native_inText = null;

			// Marshaling inTextEnd to native string
			byte* native_inTextEnd;
			var byteCount_inTextEnd = 0;
			if (inTextEnd != null)
			{
				byteCount_inTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCount_inTextEnd > Utils.MaxStackallocSize)
				{
					native_inTextEnd = Utils.Alloc<byte>(byteCount_inTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextEnd + 1];
					native_inTextEnd = stackallocBytes;
				}
				var inTextEnd_offset = Utils.EncodeStringUTF8(inTextEnd, native_inTextEnd, byteCount_inTextEnd);
				native_inTextEnd[inTextEnd_offset] = 0;
			}
			else native_inTextEnd = null;

			return ImGuiNative.ImTextCountCharsFromUtf8(native_inText, native_inTextEnd);
			// Freeing inText native string
			if (byteCount_inText > Utils.MaxStackallocSize)
				Utils.Free(native_inText);
			// Freeing inTextEnd native string
			if (byteCount_inTextEnd > Utils.MaxStackallocSize)
				Utils.Free(native_inTextEnd);
		}

		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		public static int ImTextCountUtf8BytesFromChar(ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* native_inText;
			var byteCount_inText = 0;
			if (inText != null)
			{
				byteCount_inText = Encoding.UTF8.GetByteCount(inText);
				if(byteCount_inText > Utils.MaxStackallocSize)
				{
					native_inText = Utils.Alloc<byte>(byteCount_inText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inText + 1];
					native_inText = stackallocBytes;
				}
				var inText_offset = Utils.EncodeStringUTF8(inText, native_inText, byteCount_inText);
				native_inText[inText_offset] = 0;
			}
			else native_inText = null;

			// Marshaling inTextEnd to native string
			byte* native_inTextEnd;
			var byteCount_inTextEnd = 0;
			if (inTextEnd != null)
			{
				byteCount_inTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCount_inTextEnd > Utils.MaxStackallocSize)
				{
					native_inTextEnd = Utils.Alloc<byte>(byteCount_inTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextEnd + 1];
					native_inTextEnd = stackallocBytes;
				}
				var inTextEnd_offset = Utils.EncodeStringUTF8(inTextEnd, native_inTextEnd, byteCount_inTextEnd);
				native_inTextEnd[inTextEnd_offset] = 0;
			}
			else native_inTextEnd = null;

			return ImGuiNative.ImTextCountUtf8BytesFromChar(native_inText, native_inTextEnd);
			// Freeing inText native string
			if (byteCount_inText > Utils.MaxStackallocSize)
				Utils.Free(native_inText);
			// Freeing inTextEnd native string
			if (byteCount_inTextEnd > Utils.MaxStackallocSize)
				Utils.Free(native_inTextEnd);
		}

		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		public static int ImTextCountUtf8BytesFromStr(ref ushort inText, ref ushort inTextEnd)
		{
			fixed (ushort* native_inText = &inText)
			fixed (ushort* native_inTextEnd = &inTextEnd)
			{
				var result = ImGuiNative.ImTextCountUtf8BytesFromStr(native_inText, native_inTextEnd);
				return result;
			}
		}

		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		public static ref byte ImTextFindPreviousUtf8Codepoint(ReadOnlySpan<char> inTextStart, ReadOnlySpan<char> inTextCurr)
		{
			// Marshaling inTextStart to native string
			byte* native_inTextStart;
			var byteCount_inTextStart = 0;
			if (inTextStart != null)
			{
				byteCount_inTextStart = Encoding.UTF8.GetByteCount(inTextStart);
				if(byteCount_inTextStart > Utils.MaxStackallocSize)
				{
					native_inTextStart = Utils.Alloc<byte>(byteCount_inTextStart + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextStart + 1];
					native_inTextStart = stackallocBytes;
				}
				var inTextStart_offset = Utils.EncodeStringUTF8(inTextStart, native_inTextStart, byteCount_inTextStart);
				native_inTextStart[inTextStart_offset] = 0;
			}
			else native_inTextStart = null;

			// Marshaling inTextCurr to native string
			byte* native_inTextCurr;
			var byteCount_inTextCurr = 0;
			if (inTextCurr != null)
			{
				byteCount_inTextCurr = Encoding.UTF8.GetByteCount(inTextCurr);
				if(byteCount_inTextCurr > Utils.MaxStackallocSize)
				{
					native_inTextCurr = Utils.Alloc<byte>(byteCount_inTextCurr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextCurr + 1];
					native_inTextCurr = stackallocBytes;
				}
				var inTextCurr_offset = Utils.EncodeStringUTF8(inTextCurr, native_inTextCurr, byteCount_inTextCurr);
				native_inTextCurr[inTextCurr_offset] = 0;
			}
			else native_inTextCurr = null;

			var nativeResult = ImGuiNative.ImTextFindPreviousUtf8Codepoint(native_inTextStart, native_inTextCurr);
			// Freeing inTextStart native string
			if (byteCount_inTextStart > Utils.MaxStackallocSize)
				Utils.Free(native_inTextStart);
			// Freeing inTextCurr native string
			if (byteCount_inTextCurr > Utils.MaxStackallocSize)
				Utils.Free(native_inTextCurr);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		public static int ImTextCountLines(ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* native_inText;
			var byteCount_inText = 0;
			if (inText != null)
			{
				byteCount_inText = Encoding.UTF8.GetByteCount(inText);
				if(byteCount_inText > Utils.MaxStackallocSize)
				{
					native_inText = Utils.Alloc<byte>(byteCount_inText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inText + 1];
					native_inText = stackallocBytes;
				}
				var inText_offset = Utils.EncodeStringUTF8(inText, native_inText, byteCount_inText);
				native_inText[inText_offset] = 0;
			}
			else native_inText = null;

			// Marshaling inTextEnd to native string
			byte* native_inTextEnd;
			var byteCount_inTextEnd = 0;
			if (inTextEnd != null)
			{
				byteCount_inTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCount_inTextEnd > Utils.MaxStackallocSize)
				{
					native_inTextEnd = Utils.Alloc<byte>(byteCount_inTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inTextEnd + 1];
					native_inTextEnd = stackallocBytes;
				}
				var inTextEnd_offset = Utils.EncodeStringUTF8(inTextEnd, native_inTextEnd, byteCount_inTextEnd);
				native_inTextEnd[inTextEnd_offset] = 0;
			}
			else native_inTextEnd = null;

			return ImGuiNative.ImTextCountLines(native_inText, native_inTextEnd);
			// Freeing inText native string
			if (byteCount_inText > Utils.MaxStackallocSize)
				Utils.Free(native_inText);
			// Freeing inTextEnd native string
			if (byteCount_inTextEnd > Utils.MaxStackallocSize)
				Utils.Free(native_inTextEnd);
		}

		public static IntPtr ImFileOpen(ReadOnlySpan<char> filename, ReadOnlySpan<char> mode)
		{
			// Marshaling filename to native string
			byte* native_filename;
			var byteCount_filename = 0;
			if (filename != null)
			{
				byteCount_filename = Encoding.UTF8.GetByteCount(filename);
				if(byteCount_filename > Utils.MaxStackallocSize)
				{
					native_filename = Utils.Alloc<byte>(byteCount_filename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_filename + 1];
					native_filename = stackallocBytes;
				}
				var filename_offset = Utils.EncodeStringUTF8(filename, native_filename, byteCount_filename);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			// Marshaling mode to native string
			byte* native_mode;
			var byteCount_mode = 0;
			if (mode != null)
			{
				byteCount_mode = Encoding.UTF8.GetByteCount(mode);
				if(byteCount_mode > Utils.MaxStackallocSize)
				{
					native_mode = Utils.Alloc<byte>(byteCount_mode + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_mode + 1];
					native_mode = stackallocBytes;
				}
				var mode_offset = Utils.EncodeStringUTF8(mode, native_mode, byteCount_mode);
				native_mode[mode_offset] = 0;
			}
			else native_mode = null;

			return (IntPtr)ImGuiNative.ImFileOpen(native_filename, native_mode);
			// Freeing filename native string
			if (byteCount_filename > Utils.MaxStackallocSize)
				Utils.Free(native_filename);
			// Freeing mode native string
			if (byteCount_mode > Utils.MaxStackallocSize)
				Utils.Free(native_mode);
		}

		public static byte ImFileClose(IntPtr file)
		{
			return ImGuiNative.ImFileClose((void*)file);
		}

		public static ulong ImFileGetSize(IntPtr file)
		{
			return ImGuiNative.ImFileGetSize((void*)file);
		}

		public static ulong ImFileRead(IntPtr data, ulong size, ulong count, IntPtr file)
		{
			return ImGuiNative.ImFileRead((void*)data, size, count, (void*)file);
		}

		public static ulong ImFileWrite(IntPtr data, ulong size, ulong count, IntPtr file)
		{
			return ImGuiNative.ImFileWrite((void*)data, size, count, (void*)file);
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<char> filename, ReadOnlySpan<char> mode, ref uint outFileSize, int paddingBytes)
		{
			// Marshaling filename to native string
			byte* native_filename;
			var byteCount_filename = 0;
			if (filename != null)
			{
				byteCount_filename = Encoding.UTF8.GetByteCount(filename);
				if(byteCount_filename > Utils.MaxStackallocSize)
				{
					native_filename = Utils.Alloc<byte>(byteCount_filename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_filename + 1];
					native_filename = stackallocBytes;
				}
				var filename_offset = Utils.EncodeStringUTF8(filename, native_filename, byteCount_filename);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			// Marshaling mode to native string
			byte* native_mode;
			var byteCount_mode = 0;
			if (mode != null)
			{
				byteCount_mode = Encoding.UTF8.GetByteCount(mode);
				if(byteCount_mode > Utils.MaxStackallocSize)
				{
					native_mode = Utils.Alloc<byte>(byteCount_mode + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_mode + 1];
					native_mode = stackallocBytes;
				}
				var mode_offset = Utils.EncodeStringUTF8(mode, native_mode, byteCount_mode);
				native_mode[mode_offset] = 0;
			}
			else native_mode = null;

			fixed (uint* native_outFileSize = &outFileSize)
			{
				var result = (IntPtr)ImGuiNative.ImFileLoadToMemory(native_filename, native_mode, native_outFileSize, paddingBytes);
				// Freeing filename native string
				if (byteCount_filename > Utils.MaxStackallocSize)
					Utils.Free(native_filename);
				// Freeing mode native string
				if (byteCount_mode > Utils.MaxStackallocSize)
					Utils.Free(native_mode);
				return result;
			}
		}

		public static float ImPowFloat(float x, float y)
		{
			return ImGuiNative.ImPowFloat(x, y);
		}

		public static double ImPowDouble(double x, double y)
		{
			return ImGuiNative.ImPowDouble(x, y);
		}

		public static float ImLogFloat(float x)
		{
			return ImGuiNative.ImLogFloat(x);
		}

		public static double ImLogDouble(double x)
		{
			return ImGuiNative.ImLogDouble(x);
		}

		public static int ImAbsInt(int x)
		{
			return ImGuiNative.ImAbsInt(x);
		}

		public static float ImAbsFloat(float x)
		{
			return ImGuiNative.ImAbsFloat(x);
		}

		public static double ImAbsDouble(double x)
		{
			return ImGuiNative.ImAbsDouble(x);
		}

		public static float ImSnFloat(float x)
		{
			return ImGuiNative.ImSnFloat(x);
		}

		public static double ImSnDouble(double x)
		{
			return ImGuiNative.ImSnDouble(x);
		}

		public static float ImRsqrtFloat(float x)
		{
			return ImGuiNative.ImRsqrtFloat(x);
		}

		public static double ImRsqrtDouble(double x)
		{
			return ImGuiNative.ImRsqrtDouble(x);
		}

		public static void ImMin(ref Vector2 pOut, Vector2 lhs, Vector2 rhs)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImMin(native_pOut, lhs, rhs);
			}
		}

		public static void ImMax(ref Vector2 pOut, Vector2 lhs, Vector2 rhs)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImMax(native_pOut, lhs, rhs);
			}
		}

		public static void ImClamp(ref Vector2 pOut, Vector2 v, Vector2 mn, Vector2 mx)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImClamp(native_pOut, v, mn, mx);
			}
		}

		public static void ImLerp(ref Vector2 pOut, Vector2 a, Vector2 b, float t)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImLerp(native_pOut, a, b, t);
			}
		}

		public static void ImLerp(ref Vector2 pOut, Vector2 a, Vector2 b, Vector2 t)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImLerp(native_pOut, a, b, t);
			}
		}

		public static void ImLerp(ref Vector4 pOut, Vector4 a, Vector4 b, float t)
		{
			fixed (Vector4* native_pOut = &pOut)
			{
				ImGuiNative.ImLerp(native_pOut, a, b, t);
			}
		}

		public static float ImSaturate(float f)
		{
			return ImGuiNative.ImSaturate(f);
		}

		public static float ImLengthSqr(Vector2 lhs)
		{
			return ImGuiNative.ImLengthSqr(lhs);
		}

		public static float ImLengthSqr(Vector4 lhs)
		{
			return ImGuiNative.ImLengthSqr(lhs);
		}

		public static float ImInvLength(Vector2 lhs, float failValue)
		{
			return ImGuiNative.ImInvLength(lhs, failValue);
		}

		public static float ImTruncFloat(float f)
		{
			return ImGuiNative.ImTruncFloat(f);
		}

		public static void ImTruncVec2(ref Vector2 pOut, Vector2 v)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImTruncVec2(native_pOut, v);
			}
		}

		public static float ImFloorFloat(float f)
		{
			return ImGuiNative.ImFloorFloat(f);
		}

		public static void ImFloorVec2(ref Vector2 pOut, Vector2 v)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImFloorVec2(native_pOut, v);
			}
		}

		public static int ImModPositive(int a, int b)
		{
			return ImGuiNative.ImModPositive(a, b);
		}

		public static float ImDot(Vector2 a, Vector2 b)
		{
			return ImGuiNative.ImDot(a, b);
		}

		public static void ImRotate(ref Vector2 pOut, Vector2 v, float cosA, float sinA)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImRotate(native_pOut, v, cosA, sinA);
			}
		}

		public static float ImLinearSweep(float current, float target, float speed)
		{
			return ImGuiNative.ImLinearSweep(current, target, speed);
		}

		public static float ImLinearRemapClamp(float s0, float s1, float d0, float d1, float x)
		{
			return ImGuiNative.ImLinearRemapClamp(s0, s1, d0, d1, x);
		}

		public static void ImMul(ref Vector2 pOut, Vector2 lhs, Vector2 rhs)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImMul(native_pOut, lhs, rhs);
			}
		}

		public static byte ImIsFloatAboveGuaranteedIntegerPrecision(float f)
		{
			return ImGuiNative.ImIsFloatAboveGuaranteedIntegerPrecision(f);
		}

		public static float ImExponentialMovingAverage(float avg, float sample, int n)
		{
			return ImGuiNative.ImExponentialMovingAverage(avg, sample, n);
		}

		public static void ImBezierCubicCalc(ref Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImBezierCubicCalc(native_pOut, p1, p2, p3, p4, t);
			}
		}

		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		public static void ImBezierCubicClosestPoint(ref Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int numSegments)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImBezierCubicClosestPoint(native_pOut, p1, p2, p3, p4, p, numSegments);
			}
		}

		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		public static void ImBezierCubicClosestPointCasteljau(ref Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tessTol)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImBezierCubicClosestPointCasteljau(native_pOut, p1, p2, p3, p4, p, tessTol);
			}
		}

		public static void ImBezierQuadraticCalc(ref Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImBezierQuadraticCalc(native_pOut, p1, p2, p3, t);
			}
		}

		public static void ImLineClosestPoint(ref Vector2 pOut, Vector2 a, Vector2 b, Vector2 p)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImLineClosestPoint(native_pOut, a, b, p);
			}
		}

		public static byte ImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return ImGuiNative.ImTriangleContainsPoint(a, b, c, p);
		}

		public static void ImTriangleClosestPoint(ref Vector2 pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ImTriangleClosestPoint(native_pOut, a, b, c, p);
			}
		}

		public static void ImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, ref float outU, ref float outV, ref float outW)
		{
			fixed (float* native_outU = &outU)
			fixed (float* native_outV = &outV)
			fixed (float* native_outW = &outW)
			{
				ImGuiNative.ImTriangleBarycentricCoords(a, b, c, p, native_outU, native_outV, native_outW);
			}
		}

		public static float ImTriangleArea(Vector2 a, Vector2 b, Vector2 c)
		{
			return ImGuiNative.ImTriangleArea(a, b, c);
		}

		public static byte ImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c)
		{
			return ImGuiNative.ImTriangleIsClockwise(a, b, c);
		}

		public static ImVec2IhPtr ImVec2IhImVec2Ih()
		{
			return ImGuiNative.ImVec2IhImVec2Ih();
		}

		public static void ImVec2IhImVec2IhNilConstruct(ImVec2IhPtr self)
		{
			ImGuiNative.ImVec2IhImVec2IhNilConstruct(self);
		}

		public static void ImVec2IhDestroy(ImVec2IhPtr self)
		{
			ImGuiNative.ImVec2IhDestroy(self);
		}

		public static ImVec2IhPtr ImVec2IhImVec2IhShort(short x, short y)
		{
			return ImGuiNative.ImVec2IhImVec2IhShort(x, y);
		}

		public static void ImVec2IhImVec2IhShortConstruct(ImVec2IhPtr self, short x, short y)
		{
			ImGuiNative.ImVec2IhImVec2IhShortConstruct(self, x, y);
		}

		public static ImVec2IhPtr ImVec2IhImVec2Ih(Vector2 rhs)
		{
			return ImGuiNative.ImVec2IhImVec2Ih(rhs);
		}

		public static void ImVec2IhImVec2IhVec2Construct(ImVec2IhPtr self, Vector2 rhs)
		{
			ImGuiNative.ImVec2IhImVec2IhVec2Construct(self, rhs);
		}

		public static uint ImBitArrayGetStorageSizeInBytes(int bitcount)
		{
			return ImGuiNative.ImBitArrayGetStorageSizeInBytes(bitcount);
		}

		public static void ImBitArrayClearAllBits(ref uint arr, int bitcount)
		{
			fixed (uint* native_arr = &arr)
			{
				ImGuiNative.ImBitArrayClearAllBits(native_arr, bitcount);
			}
		}

		public static byte ImBitArrayTestBit(ref uint arr, int n)
		{
			fixed (uint* native_arr = &arr)
			{
				var result = ImGuiNative.ImBitArrayTestBit(native_arr, n);
				return result;
			}
		}

		public static void ImBitArrayClearBit(ref uint arr, int n)
		{
			fixed (uint* native_arr = &arr)
			{
				ImGuiNative.ImBitArrayClearBit(native_arr, n);
			}
		}

		public static void ImBitArraySetBit(ref uint arr, int n)
		{
			fixed (uint* native_arr = &arr)
			{
				ImGuiNative.ImBitArraySetBit(native_arr, n);
			}
		}

		public static void ImBitArraySetBitRange(ref uint arr, int n, int n2)
		{
			fixed (uint* native_arr = &arr)
			{
				ImGuiNative.ImBitArraySetBitRange(native_arr, n, n2);
			}
		}

		public static ImGuiStoragePairPtr ImLowerBound(ImGuiStoragePairPtr inBegin, ImGuiStoragePairPtr inEnd, uint key)
		{
			return ImGuiNative.ImLowerBound(inBegin, inEnd, key);
		}

		public static ImGuiIdStackToolPtr ImGuiIdStackToolImGuiIdStackTool()
		{
			return ImGuiNative.ImGuiIdStackToolImGuiIdStackTool();
		}

		public static void ImGuiIdStackToolImGuiIdStackToolConstruct(ImGuiIdStackToolPtr self)
		{
			ImGuiNative.ImGuiIdStackToolImGuiIdStackToolConstruct(self);
		}

		public static void ImGuiIdStackToolDestroy(ImGuiIdStackToolPtr self)
		{
			ImGuiNative.ImGuiIdStackToolDestroy(self);
		}

		public static ImGuiIOPtr GetIO(ImGuiContextPtr ctx)
		{
			return ImGuiNative.GetIO(ctx);
		}

		public static ImGuiPlatformIOPtr GetPlatformIO(ImGuiContextPtr ctx)
		{
			return ImGuiNative.GetPlatformIO(ctx);
		}

		public static ImGuiWindowPtr GetCurrentWindowRead()
		{
			return ImGuiNative.GetCurrentWindowRead();
		}

		public static ImGuiWindowPtr GetCurrentWindow()
		{
			return ImGuiNative.GetCurrentWindow();
		}

		public static ImGuiWindowPtr FindWindowByID(uint id)
		{
			return ImGuiNative.FindWindowByID(id);
		}

		public static ImGuiWindowPtr FindWindowByName(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			return ImGuiNative.FindWindowByName(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void UpdateWindowParentAndRootLinks(ImGuiWindowPtr window, ImGuiWindowFlags flags, ImGuiWindowPtr parentWindow)
		{
			ImGuiNative.UpdateWindowParentAndRootLinks(window, flags, parentWindow);
		}

		public static void UpdateWindowSkipRefresh(ImGuiWindowPtr window)
		{
			ImGuiNative.UpdateWindowSkipRefresh(window);
		}

		public static void CalcWindowNextAutoFitSize(ref Vector2 pOut, ImGuiWindowPtr window)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.CalcWindowNextAutoFitSize(native_pOut, window);
			}
		}

		public static byte IsWindowChildOf(ImGuiWindowPtr window, ImGuiWindowPtr potentialParent, bool popupHierarchy, bool dockHierarchy)
		{
			var native_popupHierarchy = popupHierarchy ? (byte)1 : (byte)0;
			var native_dockHierarchy = dockHierarchy ? (byte)1 : (byte)0;
			return ImGuiNative.IsWindowChildOf(window, potentialParent, native_popupHierarchy, native_dockHierarchy);
		}

		public static byte IsWindowWithinBeginStackOf(ImGuiWindowPtr window, ImGuiWindowPtr potentialParent)
		{
			return ImGuiNative.IsWindowWithinBeginStackOf(window, potentialParent);
		}

		public static byte IsWindowAbove(ImGuiWindowPtr potentialAbove, ImGuiWindowPtr potentialBelow)
		{
			return ImGuiNative.IsWindowAbove(potentialAbove, potentialBelow);
		}

		public static byte IsWindowNavFocusable(ImGuiWindowPtr window)
		{
			return ImGuiNative.IsWindowNavFocusable(window);
		}

		public static void SetWindowPos(ImGuiWindowPtr window, Vector2 pos, ImGuiCond cond)
		{
			ImGuiNative.SetWindowPos(window, pos, cond);
		}

		public static void SetWindowSize(ImGuiWindowPtr window, Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.SetWindowSize(window, size, cond);
		}

		public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetWindowCollapsed(window, native_collapsed, cond);
		}

		public static void SetWindowHitTestHole(ImGuiWindowPtr window, Vector2 pos, Vector2 size)
		{
			ImGuiNative.SetWindowHitTestHole(window, pos, size);
		}

		public static void SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindowPtr window)
		{
			ImGuiNative.SetWindowHiddenAndSkipItemsForCurrentFrame(window);
		}

		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		public static void SetWindowParentWindowForFocusRoute(ImGuiWindowPtr window, ImGuiWindowPtr parentWindow)
		{
			ImGuiNative.SetWindowParentWindowForFocusRoute(window, parentWindow);
		}

		public static void WindowRectAbsToRel(ImRectPtr pOut, ImGuiWindowPtr window, ImRect r)
		{
			ImGuiNative.WindowRectAbsToRel(pOut, window, r);
		}

		public static void WindowRectRelToAbs(ImRectPtr pOut, ImGuiWindowPtr window, ImRect r)
		{
			ImGuiNative.WindowRectRelToAbs(pOut, window, r);
		}

		public static void WindowPosAbsToRel(ref Vector2 pOut, ImGuiWindowPtr window, Vector2 p)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.WindowPosAbsToRel(native_pOut, window, p);
			}
		}

		public static void WindowPosRelToAbs(ref Vector2 pOut, ImGuiWindowPtr window, Vector2 p)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.WindowPosRelToAbs(native_pOut, window, p);
			}
		}

		public static void FocusWindow(ImGuiWindowPtr window, ImGuiFocusRequestFlags flags)
		{
			ImGuiNative.FocusWindow(window, flags);
		}

		public static void FocusTopMostWindowUnderOne(ImGuiWindowPtr underThisWindow, ImGuiWindowPtr ignoreWindow, ImGuiViewportPtr filterViewport, ImGuiFocusRequestFlags flags)
		{
			ImGuiNative.FocusTopMostWindowUnderOne(underThisWindow, ignoreWindow, filterViewport, flags);
		}

		public static void BringWindowToFocusFront(ImGuiWindowPtr window)
		{
			ImGuiNative.BringWindowToFocusFront(window);
		}

		public static void BringWindowToDisplayFront(ImGuiWindowPtr window)
		{
			ImGuiNative.BringWindowToDisplayFront(window);
		}

		public static void BringWindowToDisplayBack(ImGuiWindowPtr window)
		{
			ImGuiNative.BringWindowToDisplayBack(window);
		}

		public static void BringWindowToDisplayBehind(ImGuiWindowPtr window, ImGuiWindowPtr aboveWindow)
		{
			ImGuiNative.BringWindowToDisplayBehind(window, aboveWindow);
		}

		public static int FindWindowDisplayIndex(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindWindowDisplayIndex(window);
		}

		public static ImGuiWindowPtr FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindBottomMostVisibleWindowWithinBeginStack(window);
		}

		public static void SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags)
		{
			ImGuiNative.SetNextWindowRefreshPolicy(flags);
		}

		public static void SetCurrentFont(ImFontPtr font)
		{
			ImGuiNative.SetCurrentFont(font);
		}

		public static ImFontPtr GetDefaultFont()
		{
			return ImGuiNative.GetDefaultFont();
		}

		public static void PushPasswordFont()
		{
			ImGuiNative.PushPasswordFont();
		}

		public static ImDrawListPtr GetForegroundDrawList(ImGuiWindowPtr window)
		{
			return ImGuiNative.GetForegroundDrawList(window);
		}

		public static void AddDrawListToDrawDataEx(ImDrawDataPtr drawData, ref ImVector<ImDrawListPtr> outList, ImDrawListPtr drawList)
		{
			fixed (ImVector<ImDrawListPtr>* native_outList = &outList)
			{
				ImGuiNative.AddDrawListToDrawDataEx(drawData, native_outList, drawList);
			}
		}

		public static void Initialize()
		{
			ImGuiNative.Initialize();
		}

		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		public static void Shutdown()
		{
			ImGuiNative.Shutdown();
		}

		public static void UpdateInputEvents(bool trickleFastInputs)
		{
			var native_trickleFastInputs = trickleFastInputs ? (byte)1 : (byte)0;
			ImGuiNative.UpdateInputEvents(native_trickleFastInputs);
		}

		public static void UpdateHoveredWindowAndCaptureFlags()
		{
			ImGuiNative.UpdateHoveredWindowAndCaptureFlags();
		}

		public static void FindHoveredWindowEx(Vector2 pos, bool findFirstAndInAnyViewport, ref ImGuiWindow* outHoveredWindow, ref ImGuiWindow* outHoveredWindowUnderMovingWindow)
		{
			var native_findFirstAndInAnyViewport = findFirstAndInAnyViewport ? (byte)1 : (byte)0;
			fixed (ImGuiWindow** native_outHoveredWindow = &outHoveredWindow)
			fixed (ImGuiWindow** native_outHoveredWindowUnderMovingWindow = &outHoveredWindowUnderMovingWindow)
			{
				ImGuiNative.FindHoveredWindowEx(pos, native_findFirstAndInAnyViewport, native_outHoveredWindow, native_outHoveredWindowUnderMovingWindow);
			}
		}

		public static void StartMouseMovingWindow(ImGuiWindowPtr window)
		{
			ImGuiNative.StartMouseMovingWindow(window);
		}

		public static void StartMouseMovingWindowOrNode(ImGuiWindowPtr window, ImGuiDockNodePtr node, bool undock)
		{
			var native_undock = undock ? (byte)1 : (byte)0;
			ImGuiNative.StartMouseMovingWindowOrNode(window, node, native_undock);
		}

		public static void UpdateMouseMovingWindowNewFrame()
		{
			ImGuiNative.UpdateMouseMovingWindowNewFrame();
		}

		public static void UpdateMouseMovingWindowEndFrame()
		{
			ImGuiNative.UpdateMouseMovingWindowEndFrame();
		}

		public static uint AddContextHook(ImGuiContextPtr context, ImGuiContextHookPtr hook)
		{
			return ImGuiNative.AddContextHook(context, hook);
		}

		public static void RemoveContextHook(ImGuiContextPtr context, uint hookToRemove)
		{
			ImGuiNative.RemoveContextHook(context, hookToRemove);
		}

		public static void CallContextHooks(ImGuiContextPtr context, ImGuiContextHookType type)
		{
			ImGuiNative.CallContextHooks(context, type);
		}

		public static void TranslateWindowsInViewport(ImGuiViewportPPtr viewport, Vector2 oldPos, Vector2 newPos, Vector2 oldSize, Vector2 newSize)
		{
			ImGuiNative.TranslateWindowsInViewport(viewport, oldPos, newPos, oldSize, newSize);
		}

		public static void ScaleWindowsInViewport(ImGuiViewportPPtr viewport, float scale)
		{
			ImGuiNative.ScaleWindowsInViewport(viewport, scale);
		}

		public static void DestroyPlatformWindow(ImGuiViewportPPtr viewport)
		{
			ImGuiNative.DestroyPlatformWindow(viewport);
		}

		public static void SetWindowViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
		{
			ImGuiNative.SetWindowViewport(window, viewport);
		}

		public static void SetCurrentViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
		{
			ImGuiNative.SetCurrentViewport(window, viewport);
		}

		public static ImGuiPlatformMonitorPtr GetViewportPlatformMonitor(ImGuiViewportPtr viewport)
		{
			return ImGuiNative.GetViewportPlatformMonitor(viewport);
		}

		public static ImGuiViewportPPtr FindHoveredViewportFromPlatformWindowStack(Vector2 mousePlatformPos)
		{
			return ImGuiNative.FindHoveredViewportFromPlatformWindowStack(mousePlatformPos);
		}

		public static void MarkIniSettingsDirty()
		{
			ImGuiNative.MarkIniSettingsDirty();
		}

		public static void MarkIniSettingsDirty(ImGuiWindowPtr window)
		{
			ImGuiNative.MarkIniSettingsDirty(window);
		}

		public static void ClearIniSettings()
		{
			ImGuiNative.ClearIniSettings();
		}

		public static void AddSettingsHandler(ImGuiSettingsHandlerPtr handler)
		{
			ImGuiNative.AddSettingsHandler(handler);
		}

		public static void RemoveSettingsHandler(ReadOnlySpan<char> typeName)
		{
			// Marshaling typeName to native string
			byte* native_typeName;
			var byteCount_typeName = 0;
			if (typeName != null)
			{
				byteCount_typeName = Encoding.UTF8.GetByteCount(typeName);
				if(byteCount_typeName > Utils.MaxStackallocSize)
				{
					native_typeName = Utils.Alloc<byte>(byteCount_typeName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_typeName + 1];
					native_typeName = stackallocBytes;
				}
				var typeName_offset = Utils.EncodeStringUTF8(typeName, native_typeName, byteCount_typeName);
				native_typeName[typeName_offset] = 0;
			}
			else native_typeName = null;

			ImGuiNative.RemoveSettingsHandler(native_typeName);
			// Freeing typeName native string
			if (byteCount_typeName > Utils.MaxStackallocSize)
				Utils.Free(native_typeName);
		}

		public static ImGuiSettingsHandlerPtr FindSettingsHandler(ReadOnlySpan<char> typeName)
		{
			// Marshaling typeName to native string
			byte* native_typeName;
			var byteCount_typeName = 0;
			if (typeName != null)
			{
				byteCount_typeName = Encoding.UTF8.GetByteCount(typeName);
				if(byteCount_typeName > Utils.MaxStackallocSize)
				{
					native_typeName = Utils.Alloc<byte>(byteCount_typeName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_typeName + 1];
					native_typeName = stackallocBytes;
				}
				var typeName_offset = Utils.EncodeStringUTF8(typeName, native_typeName, byteCount_typeName);
				native_typeName[typeName_offset] = 0;
			}
			else native_typeName = null;

			return ImGuiNative.FindSettingsHandler(native_typeName);
			// Freeing typeName native string
			if (byteCount_typeName > Utils.MaxStackallocSize)
				Utils.Free(native_typeName);
		}

		public static ImGuiWindowSettingsPtr CreateNewWindowSettings(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			return ImGuiNative.CreateNewWindowSettings(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static ImGuiWindowSettingsPtr FindWindowSettingsByID(uint id)
		{
			return ImGuiNative.FindWindowSettingsByID(id);
		}

		public static ImGuiWindowSettingsPtr FindWindowSettingsByWindow(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindWindowSettingsByWindow(window);
		}

		public static void ClearWindowSettings(ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.ClearWindowSettings(native_name);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void LocalizeRegisterEntries(ImGuiLocEntryPtr entries, int count)
		{
			ImGuiNative.LocalizeRegisterEntries(entries, count);
		}

		public static ref byte LocalizeGetMsg(ImGuiLocKey key)
		{
			var nativeResult = ImGuiNative.LocalizeGetMsg(key);
			return ref *(byte*)&nativeResult;
		}

		public static void SetScrollX(ImGuiWindowPtr window, float scrollX)
		{
			ImGuiNative.SetScrollX(window, scrollX);
		}

		public static void SetScrollY(ImGuiWindowPtr window, float scrollY)
		{
			ImGuiNative.SetScrollY(window, scrollY);
		}

		public static void SetScrollFromPosX(ImGuiWindowPtr window, float localX, float centerXRatio)
		{
			ImGuiNative.SetScrollFromPosX(window, localX, centerXRatio);
		}

		public static void SetScrollFromPosY(ImGuiWindowPtr window, float localY, float centerYRatio)
		{
			ImGuiNative.SetScrollFromPosY(window, localY, centerYRatio);
		}

		public static void ScrollToItem(ImGuiScrollFlags flags)
		{
			ImGuiNative.ScrollToItem(flags);
		}

		public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
		{
			ImGuiNative.ScrollToRect(window, rect, flags);
		}

		public static void ScrollToRectEx(ref Vector2 pOut, ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.ScrollToRectEx(native_pOut, window, rect, flags);
			}
		}

		public static void ScrollToBringRectIntoView(ImGuiWindowPtr window, ImRect rect)
		{
			ImGuiNative.ScrollToBringRectIntoView(window, rect);
		}

		public static ImGuiItemStatusFlags GetItemStatusFlags()
		{
			return ImGuiNative.GetItemStatusFlags();
		}

		public static ImGuiItemFlags GetItemFlags()
		{
			return ImGuiNative.GetItemFlags();
		}

		public static uint GetActiveID()
		{
			return ImGuiNative.GetActiveID();
		}

		public static uint GetFocusID()
		{
			return ImGuiNative.GetFocusID();
		}

		public static void SetActiveID(uint id, ImGuiWindowPtr window)
		{
			ImGuiNative.SetActiveID(id, window);
		}

		public static void SetFocusID(uint id, ImGuiWindowPtr window)
		{
			ImGuiNative.SetFocusID(id, window);
		}

		public static void ClearActiveID()
		{
			ImGuiNative.ClearActiveID();
		}

		public static uint GetHoveredID()
		{
			return ImGuiNative.GetHoveredID();
		}

		public static void SetHoveredID(uint id)
		{
			ImGuiNative.SetHoveredID(id);
		}

		public static void KeepAliveID(uint id)
		{
			ImGuiNative.KeepAliveID(id);
		}

		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		public static void MarkItemEdited(uint id)
		{
			ImGuiNative.MarkItemEdited(id);
		}

		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		public static void PushOverrideID(uint id)
		{
			ImGuiNative.PushOverrideID(id);
		}

		public static uint GetIdWithSeed(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd, uint seed)
		{
			// Marshaling strIdBegin to native string
			byte* native_strIdBegin;
			var byteCount_strIdBegin = 0;
			if (strIdBegin != null)
			{
				byteCount_strIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCount_strIdBegin > Utils.MaxStackallocSize)
				{
					native_strIdBegin = Utils.Alloc<byte>(byteCount_strIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdBegin + 1];
					native_strIdBegin = stackallocBytes;
				}
				var strIdBegin_offset = Utils.EncodeStringUTF8(strIdBegin, native_strIdBegin, byteCount_strIdBegin);
				native_strIdBegin[strIdBegin_offset] = 0;
			}
			else native_strIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* native_strIdEnd;
			var byteCount_strIdEnd = 0;
			if (strIdEnd != null)
			{
				byteCount_strIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCount_strIdEnd > Utils.MaxStackallocSize)
				{
					native_strIdEnd = Utils.Alloc<byte>(byteCount_strIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strIdEnd + 1];
					native_strIdEnd = stackallocBytes;
				}
				var strIdEnd_offset = Utils.EncodeStringUTF8(strIdEnd, native_strIdEnd, byteCount_strIdEnd);
				native_strIdEnd[strIdEnd_offset] = 0;
			}
			else native_strIdEnd = null;

			return ImGuiNative.GetIdWithSeed(native_strIdBegin, native_strIdEnd, seed);
			// Freeing strIdBegin native string
			if (byteCount_strIdBegin > Utils.MaxStackallocSize)
				Utils.Free(native_strIdBegin);
			// Freeing strIdEnd native string
			if (byteCount_strIdEnd > Utils.MaxStackallocSize)
				Utils.Free(native_strIdEnd);
		}

		public static uint GetIdWithSeed(int n, uint seed)
		{
			return ImGuiNative.GetIdWithSeed(n, seed);
		}

		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		public static void ItemSize(Vector2 size, float textBaselineY)
		{
			ImGuiNative.ItemSize(size, textBaselineY);
		}

		public static void ItemSize(ImRect bb, float textBaselineY)
		{
			ImGuiNative.ItemSize(bb, textBaselineY);
		}

		public static byte ItemAdd(ImRect bb, uint id, ImRectPtr navBb, ImGuiItemFlags extraFlags)
		{
			return ImGuiNative.ItemAdd(bb, id, navBb, extraFlags);
		}

		public static byte ItemHoverable(ImRect bb, uint id, ImGuiItemFlags itemFlags)
		{
			return ImGuiNative.ItemHoverable(bb, id, itemFlags);
		}

		public static byte IsWindowContentHoverable(ImGuiWindowPtr window, ImGuiHoveredFlags flags)
		{
			return ImGuiNative.IsWindowContentHoverable(window, flags);
		}

		public static byte IsClippedEx(ImRect bb, uint id)
		{
			return ImGuiNative.IsClippedEx(bb, id);
		}

		public static void SetLastItemData(uint itemId, ImGuiItemFlags itemFlags, ImGuiItemStatusFlags statusFlags, ImRect itemRect)
		{
			ImGuiNative.SetLastItemData(itemId, itemFlags, statusFlags, itemRect);
		}

		public static void CalcItemSize(ref Vector2 pOut, Vector2 size, float defaultW, float defaultH)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.CalcItemSize(native_pOut, size, defaultW, defaultH);
			}
		}

		public static float CalcWrapWidthForPos(Vector2 pos, float wrapPosX)
		{
			return ImGuiNative.CalcWrapWidthForPos(pos, wrapPosX);
		}

		public static void PushMultiItemsWidths(int components, float widthFull)
		{
			ImGuiNative.PushMultiItemsWidths(components, widthFull);
		}

		public static void ShrinkWidths(ImGuiShrinkWidthItemPtr items, int count, float widthExcess)
		{
			ImGuiNative.ShrinkWidths(items, count, widthExcess);
		}

		public static ImGuiStyleVarInfoPtr GetStyleVarInfo(ImGuiStyleVar idx)
		{
			return ImGuiNative.GetStyleVarInfo(idx);
		}

		public static void BeginDisabledOverrideReenable()
		{
			ImGuiNative.BeginDisabledOverrideReenable();
		}

		public static void EndDisabledOverrideReenable()
		{
			ImGuiNative.EndDisabledOverrideReenable();
		}

		/// <summary>
		/// -&gt; BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		public static void LogBegin(ImGuiLogFlags flags, int autoOpenDepth)
		{
			ImGuiNative.LogBegin(flags, autoOpenDepth);
		}

		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		public static void LogToBuffer(int autoOpenDepth)
		{
			ImGuiNative.LogToBuffer(autoOpenDepth);
		}

		public static void LogRenderedText(ref Vector2 refPos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			fixed (Vector2* native_refPos = &refPos)
			{
				ImGuiNative.LogRenderedText(native_refPos, native_text, native_textEnd);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
				// Freeing textEnd native string
				if (byteCount_textEnd > Utils.MaxStackallocSize)
					Utils.Free(native_textEnd);
			}
		}

		public static void LogSetNextTextDecoration(ReadOnlySpan<char> prefix, ReadOnlySpan<char> suffix)
		{
			// Marshaling prefix to native string
			byte* native_prefix;
			var byteCount_prefix = 0;
			if (prefix != null)
			{
				byteCount_prefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCount_prefix > Utils.MaxStackallocSize)
				{
					native_prefix = Utils.Alloc<byte>(byteCount_prefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_prefix + 1];
					native_prefix = stackallocBytes;
				}
				var prefix_offset = Utils.EncodeStringUTF8(prefix, native_prefix, byteCount_prefix);
				native_prefix[prefix_offset] = 0;
			}
			else native_prefix = null;

			// Marshaling suffix to native string
			byte* native_suffix;
			var byteCount_suffix = 0;
			if (suffix != null)
			{
				byteCount_suffix = Encoding.UTF8.GetByteCount(suffix);
				if(byteCount_suffix > Utils.MaxStackallocSize)
				{
					native_suffix = Utils.Alloc<byte>(byteCount_suffix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_suffix + 1];
					native_suffix = stackallocBytes;
				}
				var suffix_offset = Utils.EncodeStringUTF8(suffix, native_suffix, byteCount_suffix);
				native_suffix[suffix_offset] = 0;
			}
			else native_suffix = null;

			ImGuiNative.LogSetNextTextDecoration(native_prefix, native_suffix);
			// Freeing prefix native string
			if (byteCount_prefix > Utils.MaxStackallocSize)
				Utils.Free(native_prefix);
			// Freeing suffix native string
			if (byteCount_suffix > Utils.MaxStackallocSize)
				Utils.Free(native_suffix);
		}

		public static byte BeginChildEx(ReadOnlySpan<char> name, uint id, Vector2 sizeArg, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			return ImGuiNative.BeginChildEx(native_name, id, sizeArg, childFlags, windowFlags);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static byte BeginPopupEx(uint id, ImGuiWindowFlags extraWindowFlags)
		{
			return ImGuiNative.BeginPopupEx(id, extraWindowFlags);
		}

		public static byte BeginPopupMenuEx(uint id, ReadOnlySpan<char> label, ImGuiWindowFlags extraWindowFlags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.BeginPopupMenuEx(id, native_label, extraWindowFlags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void OpenPopupEx(uint id, ImGuiPopupFlags popupFlags)
		{
			ImGuiNative.OpenPopupEx(id, popupFlags);
		}

		public static void ClosePopupToLevel(int remaining, bool restoreFocusToWindowUnderPopup)
		{
			var native_restoreFocusToWindowUnderPopup = restoreFocusToWindowUnderPopup ? (byte)1 : (byte)0;
			ImGuiNative.ClosePopupToLevel(remaining, native_restoreFocusToWindowUnderPopup);
		}

		public static void ClosePopupsOverWindow(ImGuiWindowPtr refWindow, bool restoreFocusToWindowUnderPopup)
		{
			var native_restoreFocusToWindowUnderPopup = restoreFocusToWindowUnderPopup ? (byte)1 : (byte)0;
			ImGuiNative.ClosePopupsOverWindow(refWindow, native_restoreFocusToWindowUnderPopup);
		}

		public static void ClosePopupsExceptModals()
		{
			ImGuiNative.ClosePopupsExceptModals();
		}

		public static byte IsPopupOpen(uint id, ImGuiPopupFlags popupFlags)
		{
			return ImGuiNative.IsPopupOpen(id, popupFlags);
		}

		public static void GetPopupAllowedExtentRect(ImRectPtr pOut, ImGuiWindowPtr window)
		{
			ImGuiNative.GetPopupAllowedExtentRect(pOut, window);
		}

		public static ImGuiWindowPtr GetTopMostPopupModal()
		{
			return ImGuiNative.GetTopMostPopupModal();
		}

		public static ImGuiWindowPtr GetTopMostAndVisiblePopupModal()
		{
			return ImGuiNative.GetTopMostAndVisiblePopupModal();
		}

		public static ImGuiWindowPtr FindBlockingModal(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindBlockingModal(window);
		}

		public static void FindBestWindowPosForPopup(ref Vector2 pOut, ImGuiWindowPtr window)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.FindBestWindowPosForPopup(native_pOut, window);
			}
		}

		public static void FindBestWindowPosForPopupEx(ref Vector2 pOut, Vector2 refPos, Vector2 size, ref ImGuiDir lastDir, ImRect rOuter, ImRect rAvoid, ImGuiPopupPositionPolicy policy)
		{
			fixed (Vector2* native_pOut = &pOut)
			fixed (ImGuiDir* native_lastDir = &lastDir)
			{
				ImGuiNative.FindBestWindowPosForPopupEx(native_pOut, refPos, size, native_lastDir, rOuter, rAvoid, policy);
			}
		}

		public static byte BeginTooltipEx(ImGuiTooltipFlags tooltipFlags, ImGuiWindowFlags extraWindowFlags)
		{
			return ImGuiNative.BeginTooltipEx(tooltipFlags, extraWindowFlags);
		}

		public static byte BeginTooltipHidden()
		{
			return ImGuiNative.BeginTooltipHidden();
		}

		public static byte BeginViewportSideBar(ReadOnlySpan<char> name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags windowFlags)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			return ImGuiNative.BeginViewportSideBar(native_name, viewport, dir, size, windowFlags);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static byte BeginMenuEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, bool enabled)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling icon to native string
			byte* native_icon;
			var byteCount_icon = 0;
			if (icon != null)
			{
				byteCount_icon = Encoding.UTF8.GetByteCount(icon);
				if(byteCount_icon > Utils.MaxStackallocSize)
				{
					native_icon = Utils.Alloc<byte>(byteCount_icon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_icon + 1];
					native_icon = stackallocBytes;
				}
				var icon_offset = Utils.EncodeStringUTF8(icon, native_icon, byteCount_icon);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			var native_enabled = enabled ? (byte)1 : (byte)0;
			return ImGuiNative.BeginMenuEx(native_label, native_icon, native_enabled);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing icon native string
			if (byteCount_icon > Utils.MaxStackallocSize)
				Utils.Free(native_icon);
		}

		public static byte MenuItemEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling icon to native string
			byte* native_icon;
			var byteCount_icon = 0;
			if (icon != null)
			{
				byteCount_icon = Encoding.UTF8.GetByteCount(icon);
				if(byteCount_icon > Utils.MaxStackallocSize)
				{
					native_icon = Utils.Alloc<byte>(byteCount_icon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_icon + 1];
					native_icon = stackallocBytes;
				}
				var icon_offset = Utils.EncodeStringUTF8(icon, native_icon, byteCount_icon);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			// Marshaling shortcut to native string
			byte* native_shortcut;
			var byteCount_shortcut = 0;
			if (shortcut != null)
			{
				byteCount_shortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCount_shortcut > Utils.MaxStackallocSize)
				{
					native_shortcut = Utils.Alloc<byte>(byteCount_shortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_shortcut + 1];
					native_shortcut = stackallocBytes;
				}
				var shortcut_offset = Utils.EncodeStringUTF8(shortcut, native_shortcut, byteCount_shortcut);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			return ImGuiNative.MenuItemEx(native_label, native_icon, native_shortcut, native_selected, native_enabled);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing icon native string
			if (byteCount_icon > Utils.MaxStackallocSize)
				Utils.Free(native_icon);
			// Freeing shortcut native string
			if (byteCount_shortcut > Utils.MaxStackallocSize)
				Utils.Free(native_shortcut);
		}

		public static byte BeginComboPopup(uint popupId, ImRect bb, ImGuiComboFlags flags)
		{
			return ImGuiNative.BeginComboPopup(popupId, bb, flags);
		}

		public static byte BeginComboPreview()
		{
			return ImGuiNative.BeginComboPreview();
		}

		public static void EndComboPreview()
		{
			ImGuiNative.EndComboPreview();
		}

		public static void NavInitWindow(ImGuiWindowPtr window, bool forceReinit)
		{
			var native_forceReinit = forceReinit ? (byte)1 : (byte)0;
			ImGuiNative.NavInitWindow(window, native_forceReinit);
		}

		public static void NavInitRequestApplyResult()
		{
			ImGuiNative.NavInitRequestApplyResult();
		}

		public static byte NavMoveRequestButNoResultYet()
		{
			return ImGuiNative.NavMoveRequestButNoResultYet();
		}

		public static void NavMoveRequestSubmit(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags)
		{
			ImGuiNative.NavMoveRequestSubmit(moveDir, clipDir, moveFlags, scrollFlags);
		}

		public static void NavMoveRequestForward(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags)
		{
			ImGuiNative.NavMoveRequestForward(moveDir, clipDir, moveFlags, scrollFlags);
		}

		public static void NavMoveRequestResolveWithLastItem(ImGuiNavItemDataPtr result)
		{
			ImGuiNative.NavMoveRequestResolveWithLastItem(result);
		}

		public static void NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemDataPtr result, ImGuiTreeNodeStackDataPtr treeNodeData)
		{
			ImGuiNative.NavMoveRequestResolveWithPastTreeNode(result, treeNodeData);
		}

		public static void NavMoveRequestCancel()
		{
			ImGuiNative.NavMoveRequestCancel();
		}

		public static void NavMoveRequestApplyResult()
		{
			ImGuiNative.NavMoveRequestApplyResult();
		}

		public static void NavMoveRequestTryWrapping(ImGuiWindowPtr window, ImGuiNavMoveFlags moveFlags)
		{
			ImGuiNative.NavMoveRequestTryWrapping(window, moveFlags);
		}

		public static void NavHhlhtActivated(uint id)
		{
			ImGuiNative.NavHhlhtActivated(id);
		}

		public static void NavClearPreferredPosForAxis(ImGuiAxis axis)
		{
			ImGuiNative.NavClearPreferredPosForAxis(axis);
		}

		public static void SetNavCursorVisibleAfterMove()
		{
			ImGuiNative.SetNavCursorVisibleAfterMove();
		}

		public static void NavUpdateCurrentWindowIsScrollPushableX()
		{
			ImGuiNative.NavUpdateCurrentWindowIsScrollPushableX();
		}

		public static void SetNavWindow(ImGuiWindowPtr window)
		{
			ImGuiNative.SetNavWindow(window);
		}

		public static void SetNavID(uint id, ImGuiNavLayer navLayer, uint focusScopeId, ImRect rectRel)
		{
			ImGuiNative.SetNavID(id, navLayer, focusScopeId, rectRel);
		}

		public static void SetNavFocusScope(uint focusScopeId)
		{
			ImGuiNative.SetNavFocusScope(focusScopeId);
		}

		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		public static void FocusItem()
		{
			ImGuiNative.FocusItem();
		}

		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		public static void ActivateItemByID(uint id)
		{
			ImGuiNative.ActivateItemByID(id);
		}

		public static byte IsNamedKey(ImGuiKey key)
		{
			return ImGuiNative.IsNamedKey(key);
		}

		public static byte IsNamedKeyOrMod(ImGuiKey key)
		{
			return ImGuiNative.IsNamedKeyOrMod(key);
		}

		public static byte IsLegacyKey(ImGuiKey key)
		{
			return ImGuiNative.IsLegacyKey(key);
		}

		public static byte IsKeyboardKey(ImGuiKey key)
		{
			return ImGuiNative.IsKeyboardKey(key);
		}

		public static byte IsGamepadKey(ImGuiKey key)
		{
			return ImGuiNative.IsGamepadKey(key);
		}

		public static byte IsMouseKey(ImGuiKey key)
		{
			return ImGuiNative.IsMouseKey(key);
		}

		public static byte IsAliasKey(ImGuiKey key)
		{
			return ImGuiNative.IsAliasKey(key);
		}

		public static byte IsLrModKey(ImGuiKey key)
		{
			return ImGuiNative.IsLrModKey(key);
		}

		public static int FixupKeyChord(int keyChord)
		{
			return ImGuiNative.FixupKeyChord(keyChord);
		}

		public static ImGuiKey ConvertSingleModFlagToKey(ImGuiKey key)
		{
			return ImGuiNative.ConvertSingleModFlagToKey(key);
		}

		public static ImGuiKeyDataPtr GetKeyData(ImGuiContextPtr ctx, ImGuiKey key)
		{
			return ImGuiNative.GetKeyData(ctx, key);
		}

		public static ImGuiKeyDataPtr GetKeyData(ImGuiKey key)
		{
			return ImGuiNative.GetKeyData(key);
		}

		public static ref byte GetKeyChordName(int keyChord)
		{
			var nativeResult = ImGuiNative.GetKeyChordName(keyChord);
			return ref *(byte*)&nativeResult;
		}

		public static ImGuiKey MouseButtonToKey(ImGuiMouseButton button)
		{
			return ImGuiNative.MouseButtonToKey(button);
		}

		public static byte IsMouseDragPastThreshold(ImGuiMouseButton button, float lockThreshold)
		{
			return ImGuiNative.IsMouseDragPastThreshold(button, lockThreshold);
		}

		public static void GetKeyMagnitude2D(ref Vector2 pOut, ImGuiKey keyLeft, ImGuiKey keyRight, ImGuiKey keyUp, ImGuiKey keyDown)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.GetKeyMagnitude2D(native_pOut, keyLeft, keyRight, keyUp, keyDown);
			}
		}

		public static float GetNavTweakPressedAmount(ImGuiAxis axis)
		{
			return ImGuiNative.GetNavTweakPressedAmount(axis);
		}

		public static int CalcTypematicRepeatAmount(float t0, float t1, float repeatDelay, float repeatRate)
		{
			return ImGuiNative.CalcTypematicRepeatAmount(t0, t1, repeatDelay, repeatRate);
		}

		public static void GetTypematicRepeatRate(ImGuiInputFlags flags, ref float repeatDelay, ref float repeatRate)
		{
			fixed (float* native_repeatDelay = &repeatDelay)
			fixed (float* native_repeatRate = &repeatRate)
			{
				ImGuiNative.GetTypematicRepeatRate(flags, native_repeatDelay, native_repeatRate);
			}
		}

		public static void TeleportMousePos(Vector2 pos)
		{
			ImGuiNative.TeleportMousePos(pos);
		}

		public static void SetActiveIdUsingAllKeyboardKeys()
		{
			ImGuiNative.SetActiveIdUsingAllKeyboardKeys();
		}

		public static byte IsActiveIdUsingNavDir(ImGuiDir dir)
		{
			return ImGuiNative.IsActiveIdUsingNavDir(dir);
		}

		public static uint GetKeyOwner(ImGuiKey key)
		{
			return ImGuiNative.GetKeyOwner(key);
		}

		public static void SetKeyOwner(ImGuiKey key, uint ownerId, ImGuiInputFlags flags)
		{
			ImGuiNative.SetKeyOwner(key, ownerId, flags);
		}

		public static void SetKeyOwnersForKeyChord(int key, uint ownerId, ImGuiInputFlags flags)
		{
			ImGuiNative.SetKeyOwnersForKeyChord(key, ownerId, flags);
		}

		public static void SetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags)
		{
			ImGuiNative.SetItemKeyOwner(key, flags);
		}

		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		public static byte TestKeyOwner(ImGuiKey key, uint ownerId)
		{
			return ImGuiNative.TestKeyOwner(key, ownerId);
		}

		public static ImGuiKeyOwnerDataPtr GetKeyOwnerData(ImGuiContextPtr ctx, ImGuiKey key)
		{
			return ImGuiNative.GetKeyOwnerData(ctx, key);
		}

		public static byte IsKeyDown(ImGuiKey key, uint ownerId)
		{
			return ImGuiNative.IsKeyDown(key, ownerId);
		}

		public static byte IsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, uint ownerId)
		{
			return ImGuiNative.IsKeyPressed(key, flags, ownerId);
		}

		public static byte IsKeyReleased(ImGuiKey key, uint ownerId)
		{
			return ImGuiNative.IsKeyReleased(key, ownerId);
		}

		public static byte IsKeyChordPressed(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			return ImGuiNative.IsKeyChordPressed(keyChord, flags, ownerId);
		}

		public static byte IsMouseDown(ImGuiMouseButton button, uint ownerId)
		{
			return ImGuiNative.IsMouseDown(button, ownerId);
		}

		public static byte IsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, uint ownerId)
		{
			return ImGuiNative.IsMouseClicked(button, flags, ownerId);
		}

		public static byte IsMouseReleased(ImGuiMouseButton button, uint ownerId)
		{
			return ImGuiNative.IsMouseReleased(button, ownerId);
		}

		public static byte IsMouseDoubleClicked(ImGuiMouseButton button, uint ownerId)
		{
			return ImGuiNative.IsMouseDoubleClicked(button, ownerId);
		}

		public static byte Shortcut(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			return ImGuiNative.Shortcut(keyChord, flags, ownerId);
		}

		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		public static byte SetShortcutRouting(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			return ImGuiNative.SetShortcutRouting(keyChord, flags, ownerId);
		}

		public static byte TestShortcutRouting(int keyChord, uint ownerId)
		{
			return ImGuiNative.TestShortcutRouting(keyChord, ownerId);
		}

		public static ImGuiKeyRoutingDataPtr GetShortcutRoutingData(int keyChord)
		{
			return ImGuiNative.GetShortcutRoutingData(keyChord);
		}

		public static void DockContextInitialize(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextInitialize(ctx);
		}

		public static void DockContextShutdown(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextShutdown(ctx);
		}

		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		public static void DockContextClearNodes(ImGuiContextPtr ctx, uint rootId, bool clearSettingsRefs)
		{
			var native_clearSettingsRefs = clearSettingsRefs ? (byte)1 : (byte)0;
			ImGuiNative.DockContextClearNodes(ctx, rootId, native_clearSettingsRefs);
		}

		public static void DockContextRebuildNodes(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextRebuildNodes(ctx);
		}

		public static void DockContextNewFrameUpdateUndocking(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextNewFrameUpdateUndocking(ctx);
		}

		public static void DockContextNewFrameUpdateDocking(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextNewFrameUpdateDocking(ctx);
		}

		public static void DockContextEndFrame(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextEndFrame(ctx);
		}

		public static uint DockContextGenNodeID(ImGuiContextPtr ctx)
		{
			return ImGuiNative.DockContextGenNodeID(ctx);
		}

		public static void DockContextQueueDock(ImGuiContextPtr ctx, ImGuiWindowPtr target, ImGuiDockNodePtr targetNode, ImGuiWindowPtr payload, ImGuiDir splitDir, float splitRatio, bool splitOuter)
		{
			var native_splitOuter = splitOuter ? (byte)1 : (byte)0;
			ImGuiNative.DockContextQueueDock(ctx, target, targetNode, payload, splitDir, splitRatio, native_splitOuter);
		}

		public static void DockContextQueueUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window)
		{
			ImGuiNative.DockContextQueueUndockWindow(ctx, window);
		}

		public static void DockContextQueueUndockNode(ImGuiContextPtr ctx, ImGuiDockNodePtr node)
		{
			ImGuiNative.DockContextQueueUndockNode(ctx, node);
		}

		public static void DockContextProcessUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window, bool clearPersistentDockingRef)
		{
			var native_clearPersistentDockingRef = clearPersistentDockingRef ? (byte)1 : (byte)0;
			ImGuiNative.DockContextProcessUndockWindow(ctx, window, native_clearPersistentDockingRef);
		}

		public static void DockContextProcessUndockNode(ImGuiContextPtr ctx, ImGuiDockNodePtr node)
		{
			ImGuiNative.DockContextProcessUndockNode(ctx, node);
		}

		public static byte DockContextCalcDropPosForDocking(ImGuiWindowPtr target, ImGuiDockNodePtr targetNode, ImGuiWindowPtr payloadWindow, ImGuiDockNodePtr payloadNode, ImGuiDir splitDir, bool splitOuter, ref Vector2 outPos)
		{
			var native_splitOuter = splitOuter ? (byte)1 : (byte)0;
			fixed (Vector2* native_outPos = &outPos)
			{
				var result = ImGuiNative.DockContextCalcDropPosForDocking(target, targetNode, payloadWindow, payloadNode, splitDir, native_splitOuter, native_outPos);
				return result;
			}
		}

		public static ImGuiDockNodePtr DockContextFindNodeByID(ImGuiContextPtr ctx, uint id)
		{
			return ImGuiNative.DockContextFindNodeByID(ctx, id);
		}

		public static void DockNodeWindowMenuHandlerDefault(ImGuiContextPtr ctx, ImGuiDockNodePtr node, ImGuiTabBarPtr tabBar)
		{
			ImGuiNative.DockNodeWindowMenuHandlerDefault(ctx, node, tabBar);
		}

		public static byte DockNodeBeginAmendTabBar(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeBeginAmendTabBar(node);
		}

		public static void DockNodeEndAmendTabBar()
		{
			ImGuiNative.DockNodeEndAmendTabBar();
		}

		public static ImGuiDockNodePtr DockNodeGetRootNode(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeGetRootNode(node);
		}

		public static byte DockNodeIsInHierarchyOf(ImGuiDockNodePtr node, ImGuiDockNodePtr parent)
		{
			return ImGuiNative.DockNodeIsInHierarchyOf(node, parent);
		}

		public static int DockNodeGetDepth(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeGetDepth(node);
		}

		public static uint DockNodeGetWindowMenuButtonId(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeGetWindowMenuButtonId(node);
		}

		public static ImGuiDockNodePtr GetWindowDockNode()
		{
			return ImGuiNative.GetWindowDockNode();
		}

		public static byte GetWindowAlwaysWantOwnTabBar(ImGuiWindowPtr window)
		{
			return ImGuiNative.GetWindowAlwaysWantOwnTabBar(window);
		}

		public static void BeginDocked(ImGuiWindowPtr window, ReadOnlySpan<char> pOpen)
		{
			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			ImGuiNative.BeginDocked(window, native_pOpen);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		public static void BeginDockableDragDropSource(ImGuiWindowPtr window)
		{
			ImGuiNative.BeginDockableDragDropSource(window);
		}

		public static void BeginDockableDragDropTarget(ImGuiWindowPtr window)
		{
			ImGuiNative.BeginDockableDragDropTarget(window);
		}

		public static void SetWindowDock(ImGuiWindowPtr window, uint dockId, ImGuiCond cond)
		{
			ImGuiNative.SetWindowDock(window, dockId, cond);
		}

		public static void DockBuilderDockWindow(ReadOnlySpan<char> windowName, uint nodeId)
		{
			// Marshaling windowName to native string
			byte* native_windowName;
			var byteCount_windowName = 0;
			if (windowName != null)
			{
				byteCount_windowName = Encoding.UTF8.GetByteCount(windowName);
				if(byteCount_windowName > Utils.MaxStackallocSize)
				{
					native_windowName = Utils.Alloc<byte>(byteCount_windowName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_windowName + 1];
					native_windowName = stackallocBytes;
				}
				var windowName_offset = Utils.EncodeStringUTF8(windowName, native_windowName, byteCount_windowName);
				native_windowName[windowName_offset] = 0;
			}
			else native_windowName = null;

			ImGuiNative.DockBuilderDockWindow(native_windowName, nodeId);
			// Freeing windowName native string
			if (byteCount_windowName > Utils.MaxStackallocSize)
				Utils.Free(native_windowName);
		}

		public static ImGuiDockNodePtr DockBuilderGetNode(uint nodeId)
		{
			return ImGuiNative.DockBuilderGetNode(nodeId);
		}

		public static ImGuiDockNodePtr DockBuilderGetCentralNode(uint nodeId)
		{
			return ImGuiNative.DockBuilderGetCentralNode(nodeId);
		}

		public static uint DockBuilderAddNode(uint nodeId, ImGuiDockNodeFlags flags)
		{
			return ImGuiNative.DockBuilderAddNode(nodeId, flags);
		}

		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		public static void DockBuilderRemoveNode(uint nodeId)
		{
			ImGuiNative.DockBuilderRemoveNode(nodeId);
		}

		public static void DockBuilderRemoveNodeDockedWindows(uint nodeId, bool clearSettingsRefs)
		{
			var native_clearSettingsRefs = clearSettingsRefs ? (byte)1 : (byte)0;
			ImGuiNative.DockBuilderRemoveNodeDockedWindows(nodeId, native_clearSettingsRefs);
		}

		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		public static void DockBuilderRemoveNodeChildNodes(uint nodeId)
		{
			ImGuiNative.DockBuilderRemoveNodeChildNodes(nodeId);
		}

		public static void DockBuilderSetNodePos(uint nodeId, Vector2 pos)
		{
			ImGuiNative.DockBuilderSetNodePos(nodeId, pos);
		}

		public static void DockBuilderSetNodeSize(uint nodeId, Vector2 size)
		{
			ImGuiNative.DockBuilderSetNodeSize(nodeId, size);
		}

		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		public static uint DockBuilderSplitNode(uint nodeId, ImGuiDir splitDir, float sizeRatioForNodeAtDir, ref uint outIdAtDir, ref uint outIdAtOppositeDir)
		{
			fixed (uint* native_outIdAtDir = &outIdAtDir)
			fixed (uint* native_outIdAtOppositeDir = &outIdAtOppositeDir)
			{
				var result = ImGuiNative.DockBuilderSplitNode(nodeId, splitDir, sizeRatioForNodeAtDir, native_outIdAtDir, native_outIdAtOppositeDir);
				return result;
			}
		}

		public static void DockBuilderCopyDockSpace(uint srcDockspaceId, uint dstDockspaceId, ref ImVector<ImPointer<byte>> inWindowRemapPairs)
		{
			fixed (ImVector<ImPointer<byte>>* native_inWindowRemapPairs = &inWindowRemapPairs)
			{
				ImGuiNative.DockBuilderCopyDockSpace(srcDockspaceId, dstDockspaceId, native_inWindowRemapPairs);
			}
		}

		public static void DockBuilderCopyNode(uint srcNodeId, uint dstNodeId, ref ImVector<uint> outNodeRemapPairs)
		{
			fixed (ImVector<uint>* native_outNodeRemapPairs = &outNodeRemapPairs)
			{
				ImGuiNative.DockBuilderCopyNode(srcNodeId, dstNodeId, native_outNodeRemapPairs);
			}
		}

		public static void DockBuilderCopyWindowSettings(ReadOnlySpan<char> srcName, ReadOnlySpan<char> dstName)
		{
			// Marshaling srcName to native string
			byte* native_srcName;
			var byteCount_srcName = 0;
			if (srcName != null)
			{
				byteCount_srcName = Encoding.UTF8.GetByteCount(srcName);
				if(byteCount_srcName > Utils.MaxStackallocSize)
				{
					native_srcName = Utils.Alloc<byte>(byteCount_srcName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_srcName + 1];
					native_srcName = stackallocBytes;
				}
				var srcName_offset = Utils.EncodeStringUTF8(srcName, native_srcName, byteCount_srcName);
				native_srcName[srcName_offset] = 0;
			}
			else native_srcName = null;

			// Marshaling dstName to native string
			byte* native_dstName;
			var byteCount_dstName = 0;
			if (dstName != null)
			{
				byteCount_dstName = Encoding.UTF8.GetByteCount(dstName);
				if(byteCount_dstName > Utils.MaxStackallocSize)
				{
					native_dstName = Utils.Alloc<byte>(byteCount_dstName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_dstName + 1];
					native_dstName = stackallocBytes;
				}
				var dstName_offset = Utils.EncodeStringUTF8(dstName, native_dstName, byteCount_dstName);
				native_dstName[dstName_offset] = 0;
			}
			else native_dstName = null;

			ImGuiNative.DockBuilderCopyWindowSettings(native_srcName, native_dstName);
			// Freeing srcName native string
			if (byteCount_srcName > Utils.MaxStackallocSize)
				Utils.Free(native_srcName);
			// Freeing dstName native string
			if (byteCount_dstName > Utils.MaxStackallocSize)
				Utils.Free(native_dstName);
		}

		public static void DockBuilderFinish(uint nodeId)
		{
			ImGuiNative.DockBuilderFinish(nodeId);
		}

		public static void PushFocusScope(uint id)
		{
			ImGuiNative.PushFocusScope(id);
		}

		public static void PopFocusScope()
		{
			ImGuiNative.PopFocusScope();
		}

		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		public static uint GetCurrentFocusScope()
		{
			return ImGuiNative.GetCurrentFocusScope();
		}

		public static byte IsDragDropActive()
		{
			return ImGuiNative.IsDragDropActive();
		}

		public static byte BeginDragDropTargetCustom(ImRect bb, uint id)
		{
			return ImGuiNative.BeginDragDropTargetCustom(bb, id);
		}

		public static void ClearDragDrop()
		{
			ImGuiNative.ClearDragDrop();
		}

		public static byte IsDragDropPayloadBeingAccepted()
		{
			return ImGuiNative.IsDragDropPayloadBeingAccepted();
		}

		public static void RenderDragDropTargetRect(ImRect bb, ImRect itemClipRect)
		{
			ImGuiNative.RenderDragDropTargetRect(bb, itemClipRect);
		}

		public static ImGuiTypingSelectRequestPtr GetTypingSelectRequest(ImGuiTypingSelectFlags flags)
		{
			return ImGuiNative.GetTypingSelectRequest(flags);
		}

		public static int TypingSelectFindMatch(ImGuiTypingSelectRequestPtr req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, IntPtr userData, int navItemIdx)
		{
			return ImGuiNative.TypingSelectFindMatch(req, itemsCount, getItemNameFunc, (void*)userData, navItemIdx);
		}

		public static int TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequestPtr req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, IntPtr userData, int navItemIdx)
		{
			return ImGuiNative.TypingSelectFindNextSingleCharMatch(req, itemsCount, getItemNameFunc, (void*)userData, navItemIdx);
		}

		public static int TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequestPtr req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, IntPtr userData)
		{
			return ImGuiNative.TypingSelectFindBestLeadingMatch(req, itemsCount, getItemNameFunc, (void*)userData);
		}

		public static byte BeginBoxSelect(ImRect scopeRect, ImGuiWindowPtr window, uint boxSelectId, ImGuiMultiSelectFlags msFlags)
		{
			return ImGuiNative.BeginBoxSelect(scopeRect, window, boxSelectId, msFlags);
		}

		public static void EndBoxSelect(ImRect scopeRect, ImGuiMultiSelectFlags msFlags)
		{
			ImGuiNative.EndBoxSelect(scopeRect, msFlags);
		}

		public static void MultiSelectItemHeader(uint id, ReadOnlySpan<char> pSelected, ref ImGuiButtonFlags pButtonFlags)
		{
			// Marshaling pSelected to native string
			byte* native_pSelected;
			var byteCount_pSelected = 0;
			if (pSelected != null)
			{
				byteCount_pSelected = Encoding.UTF8.GetByteCount(pSelected);
				if(byteCount_pSelected > Utils.MaxStackallocSize)
				{
					native_pSelected = Utils.Alloc<byte>(byteCount_pSelected + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pSelected + 1];
					native_pSelected = stackallocBytes;
				}
				var pSelected_offset = Utils.EncodeStringUTF8(pSelected, native_pSelected, byteCount_pSelected);
				native_pSelected[pSelected_offset] = 0;
			}
			else native_pSelected = null;

			fixed (ImGuiButtonFlags* native_pButtonFlags = &pButtonFlags)
			{
				ImGuiNative.MultiSelectItemHeader(id, native_pSelected, native_pButtonFlags);
				// Freeing pSelected native string
				if (byteCount_pSelected > Utils.MaxStackallocSize)
					Utils.Free(native_pSelected);
			}
		}

		public static void MultiSelectItemFooter(uint id, ReadOnlySpan<char> pSelected, ReadOnlySpan<char> pPressed)
		{
			// Marshaling pSelected to native string
			byte* native_pSelected;
			var byteCount_pSelected = 0;
			if (pSelected != null)
			{
				byteCount_pSelected = Encoding.UTF8.GetByteCount(pSelected);
				if(byteCount_pSelected > Utils.MaxStackallocSize)
				{
					native_pSelected = Utils.Alloc<byte>(byteCount_pSelected + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pSelected + 1];
					native_pSelected = stackallocBytes;
				}
				var pSelected_offset = Utils.EncodeStringUTF8(pSelected, native_pSelected, byteCount_pSelected);
				native_pSelected[pSelected_offset] = 0;
			}
			else native_pSelected = null;

			// Marshaling pPressed to native string
			byte* native_pPressed;
			var byteCount_pPressed = 0;
			if (pPressed != null)
			{
				byteCount_pPressed = Encoding.UTF8.GetByteCount(pPressed);
				if(byteCount_pPressed > Utils.MaxStackallocSize)
				{
					native_pPressed = Utils.Alloc<byte>(byteCount_pPressed + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pPressed + 1];
					native_pPressed = stackallocBytes;
				}
				var pPressed_offset = Utils.EncodeStringUTF8(pPressed, native_pPressed, byteCount_pPressed);
				native_pPressed[pPressed_offset] = 0;
			}
			else native_pPressed = null;

			ImGuiNative.MultiSelectItemFooter(id, native_pSelected, native_pPressed);
			// Freeing pSelected native string
			if (byteCount_pSelected > Utils.MaxStackallocSize)
				Utils.Free(native_pSelected);
			// Freeing pPressed native string
			if (byteCount_pPressed > Utils.MaxStackallocSize)
				Utils.Free(native_pPressed);
		}

		public static void MultiSelectAddSetAll(ImGuiMultiSelectTempDataPtr ms, bool selected)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			ImGuiNative.MultiSelectAddSetAll(ms, native_selected);
		}

		public static void MultiSelectAddSetRange(ImGuiMultiSelectTempDataPtr ms, bool selected, int rangeDir, long firstItem, long lastItem)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			ImGuiNative.MultiSelectAddSetRange(ms, native_selected, rangeDir, firstItem, lastItem);
		}

		public static ImGuiBoxSelectStatePtr GetBoxSelectState(uint id)
		{
			return ImGuiNative.GetBoxSelectState(id);
		}

		public static ImGuiMultiSelectStatePtr GetMultiSelectState(uint id)
		{
			return ImGuiNative.GetMultiSelectState(id);
		}

		public static void SetWindowClipRectBeforeSetChannel(ImGuiWindowPtr window, ImRect clipRect)
		{
			ImGuiNative.SetWindowClipRectBeforeSetChannel(window, clipRect);
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<char> strId, int count, ImGuiOldColumnFlags flags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuiNative.BeginColumns(native_strId, count, flags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		/// <summary>
		/// close columns<br/>
		/// </summary>
		public static void EndColumns()
		{
			ImGuiNative.EndColumns();
		}

		public static void PushColumnClipRect(int columnIndex)
		{
			ImGuiNative.PushColumnClipRect(columnIndex);
		}

		public static void PushColumnsBackground()
		{
			ImGuiNative.PushColumnsBackground();
		}

		public static void PopColumnsBackground()
		{
			ImGuiNative.PopColumnsBackground();
		}

		public static uint GetColumnsID(ReadOnlySpan<char> strId, int count)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.GetColumnsID(native_strId, count);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static ImGuiOldColumnsPtr FindOrCreateColumns(ImGuiWindowPtr window, uint id)
		{
			return ImGuiNative.FindOrCreateColumns(window, id);
		}

		public static float GetColumnOffsetFromNorm(ImGuiOldColumnsPtr columns, float offsetNorm)
		{
			return ImGuiNative.GetColumnOffsetFromNorm(columns, offsetNorm);
		}

		public static float GetColumnNormFromOffset(ImGuiOldColumnsPtr columns, float offset)
		{
			return ImGuiNative.GetColumnNormFromOffset(columns, offset);
		}

		public static void TableOpenContextMenu(int columnN)
		{
			ImGuiNative.TableOpenContextMenu(columnN);
		}

		public static void TableSetColumnWidth(int columnN, float width)
		{
			ImGuiNative.TableSetColumnWidth(columnN, width);
		}

		public static void TableSetColumnSortDirection(int columnN, ImGuiSortDirection sortDirection, bool appendToSortSpecs)
		{
			var native_appendToSortSpecs = appendToSortSpecs ? (byte)1 : (byte)0;
			ImGuiNative.TableSetColumnSortDirection(columnN, sortDirection, native_appendToSortSpecs);
		}

		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		public static int TableGetHoveredRow()
		{
			return ImGuiNative.TableGetHoveredRow();
		}

		public static float TableGetHeaderRowHeht()
		{
			return ImGuiNative.TableGetHeaderRowHeht();
		}

		public static float TableGetHeaderAngledMaxLabelWidth()
		{
			return ImGuiNative.TableGetHeaderAngledMaxLabelWidth();
		}

		public static void TablePushBackgroundChannel()
		{
			ImGuiNative.TablePushBackgroundChannel();
		}

		public static void TablePopBackgroundChannel()
		{
			ImGuiNative.TablePopBackgroundChannel();
		}

		public static void TableAngledHeadersRowEx(uint rowId, float angle, float maxLabelWidth, ImGuiTableHeaderDataPtr data, int dataCount)
		{
			ImGuiNative.TableAngledHeadersRowEx(rowId, angle, maxLabelWidth, data, dataCount);
		}

		public static ImGuiTablePtr GetCurrentTable()
		{
			return ImGuiNative.GetCurrentTable();
		}

		public static ImGuiTablePtr TableFindByID(uint id)
		{
			return ImGuiNative.TableFindByID(id);
		}

		public static byte BeginTableEx(ReadOnlySpan<char> name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			// Marshaling name to native string
			byte* native_name;
			var byteCount_name = 0;
			if (name != null)
			{
				byteCount_name = Encoding.UTF8.GetByteCount(name);
				if(byteCount_name > Utils.MaxStackallocSize)
				{
					native_name = Utils.Alloc<byte>(byteCount_name + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_name + 1];
					native_name = stackallocBytes;
				}
				var name_offset = Utils.EncodeStringUTF8(name, native_name, byteCount_name);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			return ImGuiNative.BeginTableEx(native_name, id, columnsCount, flags, outerSize, innerWidth);
			// Freeing name native string
			if (byteCount_name > Utils.MaxStackallocSize)
				Utils.Free(native_name);
		}

		public static void TableBeginInitMemory(ImGuiTablePtr table, int columnsCount)
		{
			ImGuiNative.TableBeginInitMemory(table, columnsCount);
		}

		public static void TableBeginApplyRequests(ImGuiTablePtr table)
		{
			ImGuiNative.TableBeginApplyRequests(table);
		}

		public static void TableSetupDrawChannels(ImGuiTablePtr table)
		{
			ImGuiNative.TableSetupDrawChannels(table);
		}

		public static void TableUpdateLayout(ImGuiTablePtr table)
		{
			ImGuiNative.TableUpdateLayout(table);
		}

		public static void TableUpdateBorders(ImGuiTablePtr table)
		{
			ImGuiNative.TableUpdateBorders(table);
		}

		public static void TableUpdateColumnsWehtFromWidth(ImGuiTablePtr table)
		{
			ImGuiNative.TableUpdateColumnsWehtFromWidth(table);
		}

		public static void TableDrawBorders(ImGuiTablePtr table)
		{
			ImGuiNative.TableDrawBorders(table);
		}

		public static void TableDrawDefaultContextMenu(ImGuiTablePtr table, ImGuiTableFlags flagsForSectionToDisplay)
		{
			ImGuiNative.TableDrawDefaultContextMenu(table, flagsForSectionToDisplay);
		}

		public static byte TableBeginContextMenuPopup(ImGuiTablePtr table)
		{
			return ImGuiNative.TableBeginContextMenuPopup(table);
		}

		public static void TableMergeDrawChannels(ImGuiTablePtr table)
		{
			ImGuiNative.TableMergeDrawChannels(table);
		}

		public static ImGuiTableInstanceDataPtr TableGetInstanceData(ImGuiTablePtr table, int instanceNo)
		{
			return ImGuiNative.TableGetInstanceData(table, instanceNo);
		}

		public static uint TableGetInstanceID(ImGuiTablePtr table, int instanceNo)
		{
			return ImGuiNative.TableGetInstanceID(table, instanceNo);
		}

		public static void TableSortSpecsSanitize(ImGuiTablePtr table)
		{
			ImGuiNative.TableSortSpecsSanitize(table);
		}

		public static void TableSortSpecsBuild(ImGuiTablePtr table)
		{
			ImGuiNative.TableSortSpecsBuild(table);
		}

		public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumnPtr column)
		{
			return ImGuiNative.TableGetColumnNextSortDirection(column);
		}

		public static void TableFixColumnSortDirection(ImGuiTablePtr table, ImGuiTableColumnPtr column)
		{
			ImGuiNative.TableFixColumnSortDirection(table, column);
		}

		public static float TableGetColumnWidthAuto(ImGuiTablePtr table, ImGuiTableColumnPtr column)
		{
			return ImGuiNative.TableGetColumnWidthAuto(table, column);
		}

		public static void TableBeginRow(ImGuiTablePtr table)
		{
			ImGuiNative.TableBeginRow(table);
		}

		public static void TableEndRow(ImGuiTablePtr table)
		{
			ImGuiNative.TableEndRow(table);
		}

		public static void TableBeginCell(ImGuiTablePtr table, int columnN)
		{
			ImGuiNative.TableBeginCell(table, columnN);
		}

		public static void TableEndCell(ImGuiTablePtr table)
		{
			ImGuiNative.TableEndCell(table);
		}

		public static void TableGetCellBgRect(ImRectPtr pOut, ImGuiTablePtr table, int columnN)
		{
			ImGuiNative.TableGetCellBgRect(pOut, table, columnN);
		}

		public static ref byte TableGetColumnName(ImGuiTablePtr table, int columnN)
		{
			var nativeResult = ImGuiNative.TableGetColumnName(table, columnN);
			return ref *(byte*)&nativeResult;
		}

		public static uint TableGetColumnResizeID(ImGuiTablePtr table, int columnN, int instanceNo)
		{
			return ImGuiNative.TableGetColumnResizeID(table, columnN, instanceNo);
		}

		public static float TableCalcMaxColumnWidth(ImGuiTablePtr table, int columnN)
		{
			return ImGuiNative.TableCalcMaxColumnWidth(table, columnN);
		}

		public static void TableSetColumnWidthAutoSingle(ImGuiTablePtr table, int columnN)
		{
			ImGuiNative.TableSetColumnWidthAutoSingle(table, columnN);
		}

		public static void TableSetColumnWidthAutoAll(ImGuiTablePtr table)
		{
			ImGuiNative.TableSetColumnWidthAutoAll(table);
		}

		public static void TableRemove(ImGuiTablePtr table)
		{
			ImGuiNative.TableRemove(table);
		}

		public static void TableGcCompactTransientBuffers(ImGuiTablePtr table)
		{
			ImGuiNative.TableGcCompactTransientBuffers(table);
		}

		public static void TableGcCompactTransientBuffers(ImGuiTableTempDataPtr table)
		{
			ImGuiNative.TableGcCompactTransientBuffers(table);
		}

		public static void TableGcCompactSettings()
		{
			ImGuiNative.TableGcCompactSettings();
		}

		public static void TableLoadSettings(ImGuiTablePtr table)
		{
			ImGuiNative.TableLoadSettings(table);
		}

		public static void TableSaveSettings(ImGuiTablePtr table)
		{
			ImGuiNative.TableSaveSettings(table);
		}

		public static void TableResetSettings(ImGuiTablePtr table)
		{
			ImGuiNative.TableResetSettings(table);
		}

		public static ImGuiTableSettingsPtr TableGetBoundSettings(ImGuiTablePtr table)
		{
			return ImGuiNative.TableGetBoundSettings(table);
		}

		public static void TableSettingsAddSettingsHandler()
		{
			ImGuiNative.TableSettingsAddSettingsHandler();
		}

		public static ImGuiTableSettingsPtr TableSettingsCreate(uint id, int columnsCount)
		{
			return ImGuiNative.TableSettingsCreate(id, columnsCount);
		}

		public static ImGuiTableSettingsPtr TableSettingsFindByID(uint id)
		{
			return ImGuiNative.TableSettingsFindByID(id);
		}

		public static ImGuiTabBarPtr GetCurrentTabBar()
		{
			return ImGuiNative.GetCurrentTabBar();
		}

		public static byte BeginTabBarEx(ImGuiTabBarPtr tabBar, ImRect bb, ImGuiTabBarFlags flags)
		{
			return ImGuiNative.BeginTabBarEx(tabBar, bb, flags);
		}

		public static ImGuiTabItemPtr TabBarFindTabByID(ImGuiTabBarPtr tabBar, uint tabId)
		{
			return ImGuiNative.TabBarFindTabByID(tabBar, tabId);
		}

		public static ImGuiTabItemPtr TabBarFindTabByOrder(ImGuiTabBarPtr tabBar, int order)
		{
			return ImGuiNative.TabBarFindTabByOrder(tabBar, order);
		}

		public static ImGuiTabItemPtr TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBarPtr tabBar)
		{
			return ImGuiNative.TabBarFindMostRecentlySelectedTabForActiveWindow(tabBar);
		}

		public static ImGuiTabItemPtr TabBarGetCurrentTab(ImGuiTabBarPtr tabBar)
		{
			return ImGuiNative.TabBarGetCurrentTab(tabBar);
		}

		public static int TabBarGetTabOrder(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			return ImGuiNative.TabBarGetTabOrder(tabBar, tab);
		}

		public static ref byte TabBarGetTabName(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			var nativeResult = ImGuiNative.TabBarGetTabName(tabBar, tab);
			return ref *(byte*)&nativeResult;
		}

		public static void TabBarAddTab(ImGuiTabBarPtr tabBar, ImGuiTabItemFlags tabFlags, ImGuiWindowPtr window)
		{
			ImGuiNative.TabBarAddTab(tabBar, tabFlags, window);
		}

		public static void TabBarRemoveTab(ImGuiTabBarPtr tabBar, uint tabId)
		{
			ImGuiNative.TabBarRemoveTab(tabBar, tabId);
		}

		public static void TabBarCloseTab(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			ImGuiNative.TabBarCloseTab(tabBar, tab);
		}

		public static void TabBarQueueFocus(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			ImGuiNative.TabBarQueueFocus(tabBar, tab);
		}

		public static void TabBarQueueFocus(ImGuiTabBarPtr tabBar, ReadOnlySpan<char> tabName)
		{
			// Marshaling tabName to native string
			byte* native_tabName;
			var byteCount_tabName = 0;
			if (tabName != null)
			{
				byteCount_tabName = Encoding.UTF8.GetByteCount(tabName);
				if(byteCount_tabName > Utils.MaxStackallocSize)
				{
					native_tabName = Utils.Alloc<byte>(byteCount_tabName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_tabName + 1];
					native_tabName = stackallocBytes;
				}
				var tabName_offset = Utils.EncodeStringUTF8(tabName, native_tabName, byteCount_tabName);
				native_tabName[tabName_offset] = 0;
			}
			else native_tabName = null;

			ImGuiNative.TabBarQueueFocus(tabBar, native_tabName);
			// Freeing tabName native string
			if (byteCount_tabName > Utils.MaxStackallocSize)
				Utils.Free(native_tabName);
		}

		public static void TabBarQueueReorder(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab, int offset)
		{
			ImGuiNative.TabBarQueueReorder(tabBar, tab, offset);
		}

		public static void TabBarQueueReorderFromMousePos(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab, Vector2 mousePos)
		{
			ImGuiNative.TabBarQueueReorderFromMousePos(tabBar, tab, mousePos);
		}

		public static byte TabBarProcessReorder(ImGuiTabBarPtr tabBar)
		{
			return ImGuiNative.TabBarProcessReorder(tabBar);
		}

		public static byte TabItemEx(ImGuiTabBarPtr tabBar, ReadOnlySpan<char> label, ReadOnlySpan<char> pOpen, ImGuiTabItemFlags flags, ImGuiWindowPtr dockedWindow)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling pOpen to native string
			byte* native_pOpen;
			var byteCount_pOpen = 0;
			if (pOpen != null)
			{
				byteCount_pOpen = Encoding.UTF8.GetByteCount(pOpen);
				if(byteCount_pOpen > Utils.MaxStackallocSize)
				{
					native_pOpen = Utils.Alloc<byte>(byteCount_pOpen + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pOpen + 1];
					native_pOpen = stackallocBytes;
				}
				var pOpen_offset = Utils.EncodeStringUTF8(pOpen, native_pOpen, byteCount_pOpen);
				native_pOpen[pOpen_offset] = 0;
			}
			else native_pOpen = null;

			return ImGuiNative.TabItemEx(tabBar, native_label, native_pOpen, flags, dockedWindow);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing pOpen native string
			if (byteCount_pOpen > Utils.MaxStackallocSize)
				Utils.Free(native_pOpen);
		}

		public static void TabItemSpacing(ReadOnlySpan<char> strId, ImGuiTabItemFlags flags, float width)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			ImGuiNative.TabItemSpacing(native_strId, flags, width);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static void TabItemCalcSize(ref Vector2 pOut, ReadOnlySpan<char> label, bool hasCloseButtonOrUnsavedMarker)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var native_hasCloseButtonOrUnsavedMarker = hasCloseButtonOrUnsavedMarker ? (byte)1 : (byte)0;
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.TabItemCalcSize(native_pOut, native_label, native_hasCloseButtonOrUnsavedMarker);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
			}
		}

		public static void TabItemCalcSize(ref Vector2 pOut, ImGuiWindowPtr window)
		{
			fixed (Vector2* native_pOut = &pOut)
			{
				ImGuiNative.TabItemCalcSize(native_pOut, window);
			}
		}

		public static void TabItemBackground(ImDrawListPtr drawList, ImRect bb, ImGuiTabItemFlags flags, uint col)
		{
			ImGuiNative.TabItemBackground(drawList, bb, flags, col);
		}

		public static void TabItemLabelAndCloseButton(ImDrawListPtr drawList, ImRect bb, ImGuiTabItemFlags flags, Vector2 framePadding, ReadOnlySpan<char> label, uint tabId, uint closeButtonId, bool isContentsVisible, ReadOnlySpan<char> outJustClosed, ReadOnlySpan<char> outTextClipped)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var native_isContentsVisible = isContentsVisible ? (byte)1 : (byte)0;
			// Marshaling outJustClosed to native string
			byte* native_outJustClosed;
			var byteCount_outJustClosed = 0;
			if (outJustClosed != null)
			{
				byteCount_outJustClosed = Encoding.UTF8.GetByteCount(outJustClosed);
				if(byteCount_outJustClosed > Utils.MaxStackallocSize)
				{
					native_outJustClosed = Utils.Alloc<byte>(byteCount_outJustClosed + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outJustClosed + 1];
					native_outJustClosed = stackallocBytes;
				}
				var outJustClosed_offset = Utils.EncodeStringUTF8(outJustClosed, native_outJustClosed, byteCount_outJustClosed);
				native_outJustClosed[outJustClosed_offset] = 0;
			}
			else native_outJustClosed = null;

			// Marshaling outTextClipped to native string
			byte* native_outTextClipped;
			var byteCount_outTextClipped = 0;
			if (outTextClipped != null)
			{
				byteCount_outTextClipped = Encoding.UTF8.GetByteCount(outTextClipped);
				if(byteCount_outTextClipped > Utils.MaxStackallocSize)
				{
					native_outTextClipped = Utils.Alloc<byte>(byteCount_outTextClipped + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outTextClipped + 1];
					native_outTextClipped = stackallocBytes;
				}
				var outTextClipped_offset = Utils.EncodeStringUTF8(outTextClipped, native_outTextClipped, byteCount_outTextClipped);
				native_outTextClipped[outTextClipped_offset] = 0;
			}
			else native_outTextClipped = null;

			ImGuiNative.TabItemLabelAndCloseButton(drawList, bb, flags, framePadding, native_label, tabId, closeButtonId, native_isContentsVisible, native_outJustClosed, native_outTextClipped);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing outJustClosed native string
			if (byteCount_outJustClosed > Utils.MaxStackallocSize)
				Utils.Free(native_outJustClosed);
			// Freeing outTextClipped native string
			if (byteCount_outTextClipped > Utils.MaxStackallocSize)
				Utils.Free(native_outTextClipped);
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, bool hideTextAfterHash)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			var native_hideTextAfterHash = hideTextAfterHash ? (byte)1 : (byte)0;
			ImGuiNative.RenderText(pos, native_text, native_textEnd, native_hideTextAfterHash);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		public static void RenderTextWrapped(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, float wrapWidth)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			ImGuiNative.RenderTextWrapped(pos, native_text, native_textEnd, wrapWidth);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, ref Vector2 textSizeIfKnown, Vector2 align, ImRectPtr clipRect)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			fixed (Vector2* native_textSizeIfKnown = &textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, native_text, native_textEnd, native_textSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
				// Freeing textEnd native string
				if (byteCount_textEnd > Utils.MaxStackallocSize)
					Utils.Free(native_textEnd);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, ref Vector2 textSizeIfKnown, Vector2 align, ImRectPtr clipRect)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			fixed (Vector2* native_textSizeIfKnown = &textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, native_text, native_textEnd, native_textSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
				// Freeing textEnd native string
				if (byteCount_textEnd > Utils.MaxStackallocSize)
					Utils.Free(native_textEnd);
			}
		}

		public static void RenderTextEllipsis(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, float clipMaxX, float ellipsisMaxX, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, ref Vector2 textSizeIfKnown)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			fixed (Vector2* native_textSizeIfKnown = &textSizeIfKnown)
			{
				ImGuiNative.RenderTextEllipsis(drawList, posMin, posMax, clipMaxX, ellipsisMaxX, native_text, native_textEnd, native_textSizeIfKnown);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
				// Freeing textEnd native string
				if (byteCount_textEnd > Utils.MaxStackallocSize)
					Utils.Free(native_textEnd);
			}
		}

		public static void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol, bool borders, float rounding)
		{
			var native_borders = borders ? (byte)1 : (byte)0;
			ImGuiNative.RenderFrame(pMin, pMax, fillCol, native_borders, rounding);
		}

		public static void RenderFrameBorder(Vector2 pMin, Vector2 pMax, float rounding)
		{
			ImGuiNative.RenderFrameBorder(pMin, pMax, rounding);
		}

		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.RenderColorRectWithAlphaCheckerboard(drawList, pMin, pMax, fillCol, gridStep, gridOff, rounding, flags);
		}

		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		public static void RenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags)
		{
			ImGuiNative.RenderNavCursor(bb, id, flags);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static ref byte FindRenderedTextEnd(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			var nativeResult = ImGuiNative.FindRenderedTextEnd(native_text, native_textEnd);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
			return ref *(byte*)&nativeResult;
		}

		public static void RenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouseCursor, uint colFill, uint colBorder, uint colShadow)
		{
			ImGuiNative.RenderMouseCursor(pos, scale, mouseCursor, colFill, colBorder, colShadow);
		}

		public static void RenderArrow(ImDrawListPtr drawList, Vector2 pos, uint col, ImGuiDir dir, float scale)
		{
			ImGuiNative.RenderArrow(drawList, pos, col, dir, scale);
		}

		public static void RenderBullet(ImDrawListPtr drawList, Vector2 pos, uint col)
		{
			ImGuiNative.RenderBullet(drawList, pos, col);
		}

		public static void RenderCheckMark(ImDrawListPtr drawList, Vector2 pos, uint col, float sz)
		{
			ImGuiNative.RenderCheckMark(drawList, pos, col, sz);
		}

		public static void RenderArrowPointingAt(ImDrawListPtr drawList, Vector2 pos, Vector2 halfSz, ImGuiDir direction, uint col)
		{
			ImGuiNative.RenderArrowPointingAt(drawList, pos, halfSz, direction, col);
		}

		public static void RenderArrowDockMenu(ImDrawListPtr drawList, Vector2 pMin, float sz, uint col)
		{
			ImGuiNative.RenderArrowDockMenu(drawList, pMin, sz, col);
		}

		public static void RenderRectFilledRangeH(ImDrawListPtr drawList, ImRect rect, uint col, float xStartNorm, float xEndNorm, float rounding)
		{
			ImGuiNative.RenderRectFilledRangeH(drawList, rect, col, xStartNorm, xEndNorm, rounding);
		}

		public static void RenderRectFilledWithHole(ImDrawListPtr drawList, ImRect outer, ImRect inner, uint col, float rounding)
		{
			ImGuiNative.RenderRectFilledWithHole(drawList, outer, inner, col, rounding);
		}

		public static ImDrawFlags CalcRoundingFlagsForRectInRect(ImRect rIn, ImRect rOuter, float threshold)
		{
			return ImGuiNative.CalcRoundingFlagsForRectInRect(rIn, rOuter, threshold);
		}

		public static void TextEx(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, ImGuiTextFlags flags)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling textEnd to native string
			byte* native_textEnd;
			var byteCount_textEnd = 0;
			if (textEnd != null)
			{
				byteCount_textEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCount_textEnd > Utils.MaxStackallocSize)
				{
					native_textEnd = Utils.Alloc<byte>(byteCount_textEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_textEnd + 1];
					native_textEnd = stackallocBytes;
				}
				var textEnd_offset = Utils.EncodeStringUTF8(textEnd, native_textEnd, byteCount_textEnd);
				native_textEnd[textEnd_offset] = 0;
			}
			else native_textEnd = null;

			ImGuiNative.TextEx(native_text, native_textEnd, flags);
			// Freeing text native string
			if (byteCount_text > Utils.MaxStackallocSize)
				Utils.Free(native_text);
			// Freeing textEnd native string
			if (byteCount_textEnd > Utils.MaxStackallocSize)
				Utils.Free(native_textEnd);
		}

		public static byte ButtonEx(ReadOnlySpan<char> label, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			return ImGuiNative.ButtonEx(native_label, sizeArg, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static byte ArrowButtonEx(ReadOnlySpan<char> strId, ImGuiDir dir, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			// Marshaling strId to native string
			byte* native_strId;
			var byteCount_strId = 0;
			if (strId != null)
			{
				byteCount_strId = Encoding.UTF8.GetByteCount(strId);
				if(byteCount_strId > Utils.MaxStackallocSize)
				{
					native_strId = Utils.Alloc<byte>(byteCount_strId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_strId + 1];
					native_strId = stackallocBytes;
				}
				var strId_offset = Utils.EncodeStringUTF8(strId, native_strId, byteCount_strId);
				native_strId[strId_offset] = 0;
			}
			else native_strId = null;

			return ImGuiNative.ArrowButtonEx(native_strId, dir, sizeArg, flags);
			// Freeing strId native string
			if (byteCount_strId > Utils.MaxStackallocSize)
				Utils.Free(native_strId);
		}

		public static byte ImageButtonEx(uint id, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol, ImGuiButtonFlags flags)
		{
			return ImGuiNative.ImageButtonEx(id, userTextureId, imageSize, uv0, uv1, bgCol, tintCol, flags);
		}

		public static void SeparatorEx(ImGuiSeparatorFlags flags, float thickness)
		{
			ImGuiNative.SeparatorEx(flags, thickness);
		}

		public static void SeparatorTextEx(uint id, ReadOnlySpan<char> label, ReadOnlySpan<char> labelEnd, float extraWidth)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling labelEnd to native string
			byte* native_labelEnd;
			var byteCount_labelEnd = 0;
			if (labelEnd != null)
			{
				byteCount_labelEnd = Encoding.UTF8.GetByteCount(labelEnd);
				if(byteCount_labelEnd > Utils.MaxStackallocSize)
				{
					native_labelEnd = Utils.Alloc<byte>(byteCount_labelEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelEnd + 1];
					native_labelEnd = stackallocBytes;
				}
				var labelEnd_offset = Utils.EncodeStringUTF8(labelEnd, native_labelEnd, byteCount_labelEnd);
				native_labelEnd[labelEnd_offset] = 0;
			}
			else native_labelEnd = null;

			ImGuiNative.SeparatorTextEx(id, native_label, native_labelEnd, extraWidth);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing labelEnd native string
			if (byteCount_labelEnd > Utils.MaxStackallocSize)
				Utils.Free(native_labelEnd);
		}

		public static byte CheckboxFlags(ReadOnlySpan<char> label, ref long flags, long flagsValue)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (long* native_flags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(native_label, native_flags, flagsValue);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte CheckboxFlags(ReadOnlySpan<char> label, ref ulong flags, ulong flagsValue)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (ulong* native_flags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(native_label, native_flags, flagsValue);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
				return result;
			}
		}

		public static byte CloseButton(uint id, Vector2 pos)
		{
			return ImGuiNative.CloseButton(id, pos);
		}

		public static byte CollapseButton(uint id, Vector2 pos, ImGuiDockNodePtr dockNode)
		{
			return ImGuiNative.CollapseButton(id, pos, dockNode);
		}

		public static void Scrollbar(ImGuiAxis axis)
		{
			ImGuiNative.Scrollbar(axis);
		}

		public static byte ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, ref long pScrollV, long availV, long contentsV, ImDrawFlags drawRoundingFlags)
		{
			fixed (long* native_pScrollV = &pScrollV)
			{
				var result = ImGuiNative.ScrollbarEx(bb, id, axis, native_pScrollV, availV, contentsV, drawRoundingFlags);
				return result;
			}
		}

		public static void GetWindowScrollbarRect(ImRectPtr pOut, ImGuiWindowPtr window, ImGuiAxis axis)
		{
			ImGuiNative.GetWindowScrollbarRect(pOut, window, axis);
		}

		public static uint GetWindowScrollbarID(ImGuiWindowPtr window, ImGuiAxis axis)
		{
			return ImGuiNative.GetWindowScrollbarID(window, axis);
		}

		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		public static uint GetWindowResizeCornerID(ImGuiWindowPtr window, int n)
		{
			return ImGuiNative.GetWindowResizeCornerID(window, n);
		}

		public static uint GetWindowResizeBorderID(ImGuiWindowPtr window, ImGuiDir dir)
		{
			return ImGuiNative.GetWindowResizeBorderID(window, dir);
		}

		public static byte ButtonBehavior(ImRect bb, uint id, ReadOnlySpan<char> outHovered, ReadOnlySpan<char> outHeld, ImGuiButtonFlags flags)
		{
			// Marshaling outHovered to native string
			byte* native_outHovered;
			var byteCount_outHovered = 0;
			if (outHovered != null)
			{
				byteCount_outHovered = Encoding.UTF8.GetByteCount(outHovered);
				if(byteCount_outHovered > Utils.MaxStackallocSize)
				{
					native_outHovered = Utils.Alloc<byte>(byteCount_outHovered + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outHovered + 1];
					native_outHovered = stackallocBytes;
				}
				var outHovered_offset = Utils.EncodeStringUTF8(outHovered, native_outHovered, byteCount_outHovered);
				native_outHovered[outHovered_offset] = 0;
			}
			else native_outHovered = null;

			// Marshaling outHeld to native string
			byte* native_outHeld;
			var byteCount_outHeld = 0;
			if (outHeld != null)
			{
				byteCount_outHeld = Encoding.UTF8.GetByteCount(outHeld);
				if(byteCount_outHeld > Utils.MaxStackallocSize)
				{
					native_outHeld = Utils.Alloc<byte>(byteCount_outHeld + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outHeld + 1];
					native_outHeld = stackallocBytes;
				}
				var outHeld_offset = Utils.EncodeStringUTF8(outHeld, native_outHeld, byteCount_outHeld);
				native_outHeld[outHeld_offset] = 0;
			}
			else native_outHeld = null;

			return ImGuiNative.ButtonBehavior(bb, id, native_outHovered, native_outHeld, flags);
			// Freeing outHovered native string
			if (byteCount_outHovered > Utils.MaxStackallocSize)
				Utils.Free(native_outHovered);
			// Freeing outHeld native string
			if (byteCount_outHeld > Utils.MaxStackallocSize)
				Utils.Free(native_outHeld);
		}

		public static byte DragBehavior(uint id, ImGuiDataType dataType, IntPtr pV, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.DragBehavior(id, dataType, (void*)pV, vSpeed, (void*)pMin, (void*)pMax, native_format, flags);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte SliderBehavior(ImRect bb, uint id, ImGuiDataType dataType, IntPtr pV, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags, ImRectPtr outGrabBb)
		{
			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.SliderBehavior(bb, id, dataType, (void*)pV, (void*)pMin, (void*)pMax, native_format, flags, outGrabBb);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float minSize1, float minSize2, float hoverExtend, float hoverVisibilityDelay, uint bgCol)
		{
			fixed (float* native_size1 = &size1)
			fixed (float* native_size2 = &size2)
			{
				var result = ImGuiNative.SplitterBehavior(bb, id, axis, native_size1, native_size2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
				return result;
			}
		}

		public static byte TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> label, ReadOnlySpan<char> labelEnd)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling labelEnd to native string
			byte* native_labelEnd;
			var byteCount_labelEnd = 0;
			if (labelEnd != null)
			{
				byteCount_labelEnd = Encoding.UTF8.GetByteCount(labelEnd);
				if(byteCount_labelEnd > Utils.MaxStackallocSize)
				{
					native_labelEnd = Utils.Alloc<byte>(byteCount_labelEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_labelEnd + 1];
					native_labelEnd = stackallocBytes;
				}
				var labelEnd_offset = Utils.EncodeStringUTF8(labelEnd, native_labelEnd, byteCount_labelEnd);
				native_labelEnd[labelEnd_offset] = 0;
			}
			else native_labelEnd = null;

			return ImGuiNative.TreeNodeBehavior(id, flags, native_label, native_labelEnd);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing labelEnd native string
			if (byteCount_labelEnd > Utils.MaxStackallocSize)
				Utils.Free(native_labelEnd);
		}

		public static void TreePushOverrideID(uint id)
		{
			ImGuiNative.TreePushOverrideID(id);
		}

		public static byte TreeNodeGetOpen(uint storageId)
		{
			return ImGuiNative.TreeNodeGetOpen(storageId);
		}

		public static void TreeNodeSetOpen(uint storageId, bool open)
		{
			var native_open = open ? (byte)1 : (byte)0;
			ImGuiNative.TreeNodeSetOpen(storageId, native_open);
		}

		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		public static byte TreeNodeUpdateNextOpen(uint storageId, ImGuiTreeNodeFlags flags)
		{
			return ImGuiNative.TreeNodeUpdateNextOpen(storageId, flags);
		}

		public static ImGuiDataTypeInfoPtr DataTypeGetInfo(ImGuiDataType dataType)
		{
			return ImGuiNative.DataTypeGetInfo(dataType);
		}

		public static int DataTypeFormatString(ReadOnlySpan<char> buf, int bufSize, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format)
		{
			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.DataTypeFormatString(native_buf, bufSize, dataType, (void*)pData, native_format);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static void DataTypeApplyOp(ImGuiDataType dataType, int op, IntPtr output, IntPtr arg_1, IntPtr arg_2)
		{
			ImGuiNative.DataTypeApplyOp(dataType, op, (void*)output, (void*)arg_1, (void*)arg_2);
		}

		public static byte DataTypeApplyFromText(ReadOnlySpan<char> buf, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format, IntPtr pDataWhenEmpty)
		{
			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.DataTypeApplyFromText(native_buf, dataType, (void*)pData, native_format, (void*)pDataWhenEmpty);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static int DataTypeCompare(ImGuiDataType dataType, IntPtr arg_1, IntPtr arg_2)
		{
			return ImGuiNative.DataTypeCompare(dataType, (void*)arg_1, (void*)arg_2);
		}

		public static byte DataTypeClamp(ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax)
		{
			return ImGuiNative.DataTypeClamp(dataType, (void*)pData, (void*)pMin, (void*)pMax);
		}

		public static byte DataTypeIsZero(ImGuiDataType dataType, IntPtr pData)
		{
			return ImGuiNative.DataTypeIsZero(dataType, (void*)pData);
		}

		public static byte InputTextEx(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, ReadOnlySpan<char> buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling hint to native string
			byte* native_hint;
			var byteCount_hint = 0;
			if (hint != null)
			{
				byteCount_hint = Encoding.UTF8.GetByteCount(hint);
				if(byteCount_hint > Utils.MaxStackallocSize)
				{
					native_hint = Utils.Alloc<byte>(byteCount_hint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_hint + 1];
					native_hint = stackallocBytes;
				}
				var hint_offset = Utils.EncodeStringUTF8(hint, native_hint, byteCount_hint);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			return ImGuiNative.InputTextEx(native_label, native_hint, native_buf, bufSize, sizeArg, flags, callback, (void*)userData);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing hint native string
			if (byteCount_hint > Utils.MaxStackallocSize)
				Utils.Free(native_hint);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
		}

		public static void InputTextDeactivateHook(uint id)
		{
			ImGuiNative.InputTextDeactivateHook(id);
		}

		public static byte TempInputText(ImRect bb, uint id, ReadOnlySpan<char> label, ReadOnlySpan<char> buf, int bufSize, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling buf to native string
			byte* native_buf;
			var byteCount_buf = 0;
			if (buf != null)
			{
				byteCount_buf = Encoding.UTF8.GetByteCount(buf);
				if(byteCount_buf > Utils.MaxStackallocSize)
				{
					native_buf = Utils.Alloc<byte>(byteCount_buf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_buf + 1];
					native_buf = stackallocBytes;
				}
				var buf_offset = Utils.EncodeStringUTF8(buf, native_buf, byteCount_buf);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			return ImGuiNative.TempInputText(bb, id, native_label, native_buf, bufSize, flags);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing buf native string
			if (byteCount_buf > Utils.MaxStackallocSize)
				Utils.Free(native_buf);
		}

		public static byte TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format, IntPtr pClampMin, IntPtr pClampMax)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling format to native string
			byte* native_format;
			var byteCount_format = 0;
			if (format != null)
			{
				byteCount_format = Encoding.UTF8.GetByteCount(format);
				if(byteCount_format > Utils.MaxStackallocSize)
				{
					native_format = Utils.Alloc<byte>(byteCount_format + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_format + 1];
					native_format = stackallocBytes;
				}
				var format_offset = Utils.EncodeStringUTF8(format, native_format, byteCount_format);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			return ImGuiNative.TempInputScalar(bb, id, native_label, dataType, (void*)pData, native_format, (void*)pClampMin, (void*)pClampMax);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing format native string
			if (byteCount_format > Utils.MaxStackallocSize)
				Utils.Free(native_format);
		}

		public static byte TempInputIsActive(uint id)
		{
			return ImGuiNative.TempInputIsActive(id);
		}

		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		public static ImGuiInputTextStatePtr GetInputTextState(uint id)
		{
			return ImGuiNative.GetInputTextState(id);
		}

		public static void SetNextItemRefVal(ImGuiDataType dataType, IntPtr pData)
		{
			ImGuiNative.SetNextItemRefVal(dataType, (void*)pData);
		}

		/// <summary>
		/// This may be useful to apply workaround that a based on distinguish whenever an item is active as a text input field.<br/>
		/// </summary>
		public static byte IsItemActiveAsInputText()
		{
			return ImGuiNative.IsItemActiveAsInputText();
		}

		public static void ColorTooltip(ReadOnlySpan<char> text, ref float col, ImGuiColorEditFlags flags)
		{
			// Marshaling text to native string
			byte* native_text;
			var byteCount_text = 0;
			if (text != null)
			{
				byteCount_text = Encoding.UTF8.GetByteCount(text);
				if(byteCount_text > Utils.MaxStackallocSize)
				{
					native_text = Utils.Alloc<byte>(byteCount_text + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_text + 1];
					native_text = stackallocBytes;
				}
				var text_offset = Utils.EncodeStringUTF8(text, native_text, byteCount_text);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			fixed (float* native_col = &col)
			{
				ImGuiNative.ColorTooltip(native_text, native_col, flags);
				// Freeing text native string
				if (byteCount_text > Utils.MaxStackallocSize)
					Utils.Free(native_text);
			}
		}

		public static void ColorEditOptionsPopup(ref float col, ImGuiColorEditFlags flags)
		{
			fixed (float* native_col = &col)
			{
				ImGuiNative.ColorEditOptionsPopup(native_col, flags);
			}
		}

		public static void ColorPickerOptionsPopup(ref float refCol, ImGuiColorEditFlags flags)
		{
			fixed (float* native_refCol = &refCol)
			{
				ImGuiNative.ColorPickerOptionsPopup(native_refCol, flags);
			}
		}

		public static int PlotEx(ImGuiPlotType plotType, ReadOnlySpan<char> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 sizeArg)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling overlayText to native string
			byte* native_overlayText;
			var byteCount_overlayText = 0;
			if (overlayText != null)
			{
				byteCount_overlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCount_overlayText > Utils.MaxStackallocSize)
				{
					native_overlayText = Utils.Alloc<byte>(byteCount_overlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_overlayText + 1];
					native_overlayText = stackallocBytes;
				}
				var overlayText_offset = Utils.EncodeStringUTF8(overlayText, native_overlayText, byteCount_overlayText);
				native_overlayText[overlayText_offset] = 0;
			}
			else native_overlayText = null;

			return ImGuiNative.PlotEx(plotType, native_label, valuesGetter, (void*)data, valuesCount, valuesOffset, native_overlayText, scaleMin, scaleMax, sizeArg);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing overlayText native string
			if (byteCount_overlayText > Utils.MaxStackallocSize)
				Utils.Free(native_overlayText);
		}

		public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawListPtr drawList, int vertStartIdx, int vertEndIdx, Vector2 gradientP0, Vector2 gradientP1, uint col0, uint col1)
		{
			ImGuiNative.ShadeVertsLinearColorGradientKeepAlpha(drawList, vertStartIdx, vertEndIdx, gradientP0, gradientP1, col0, col1);
		}

		public static void ShadeVertsLinearUV(ImDrawListPtr drawList, int vertStartIdx, int vertEndIdx, Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, bool clamp)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			ImGuiNative.ShadeVertsLinearUV(drawList, vertStartIdx, vertEndIdx, a, b, uvA, uvB, native_clamp);
		}

		public static void ShadeVertsTransformPos(ImDrawListPtr drawList, int vertStartIdx, int vertEndIdx, Vector2 pivotIn, float cosA, float sinA, Vector2 pivotOut)
		{
			ImGuiNative.ShadeVertsTransformPos(drawList, vertStartIdx, vertEndIdx, pivotIn, cosA, sinA, pivotOut);
		}

		public static void GcCompactTransientMiscBuffers()
		{
			ImGuiNative.GcCompactTransientMiscBuffers();
		}

		public static void GcCompactTransientWindowBuffers(ImGuiWindowPtr window)
		{
			ImGuiNative.GcCompactTransientWindowBuffers(window);
		}

		public static void GcAwakeTransientWindowBuffers(ImGuiWindowPtr window)
		{
			ImGuiNative.GcAwakeTransientWindowBuffers(window);
		}

		public static byte ErrorLog(ReadOnlySpan<char> msg)
		{
			// Marshaling msg to native string
			byte* native_msg;
			var byteCount_msg = 0;
			if (msg != null)
			{
				byteCount_msg = Encoding.UTF8.GetByteCount(msg);
				if(byteCount_msg > Utils.MaxStackallocSize)
				{
					native_msg = Utils.Alloc<byte>(byteCount_msg + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_msg + 1];
					native_msg = stackallocBytes;
				}
				var msg_offset = Utils.EncodeStringUTF8(msg, native_msg, byteCount_msg);
				native_msg[msg_offset] = 0;
			}
			else native_msg = null;

			return ImGuiNative.ErrorLog(native_msg);
			// Freeing msg native string
			if (byteCount_msg > Utils.MaxStackallocSize)
				Utils.Free(native_msg);
		}

		public static void ErrorRecoveryStoreState(ImGuiErrorRecoveryStatePtr stateOut)
		{
			ImGuiNative.ErrorRecoveryStoreState(stateOut);
		}

		public static void ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryStatePtr stateIn)
		{
			ImGuiNative.ErrorRecoveryTryToRecoverState(stateIn);
		}

		public static void ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryStatePtr stateIn)
		{
			ImGuiNative.ErrorRecoveryTryToRecoverWindowState(stateIn);
		}

		public static void ErrorCheckUsingSetCursorPosToExtendParentBoundaries()
		{
			ImGuiNative.ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		}

		public static void ErrorCheckEndFrameFinalizeErrorTooltip()
		{
			ImGuiNative.ErrorCheckEndFrameFinalizeErrorTooltip();
		}

		public static byte BeginErrorTooltip()
		{
			return ImGuiNative.BeginErrorTooltip();
		}

		public static void EndErrorTooltip()
		{
			ImGuiNative.EndErrorTooltip();
		}

		/// <summary>
		/// size &gt;= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		public static void DebugAllocHook(ImGuiDebugAllocInfoPtr info, int frameCount, IntPtr ptr, uint size)
		{
			ImGuiNative.DebugAllocHook(info, frameCount, (void*)ptr, size);
		}

		public static void DebugDrawCursorPos(uint col)
		{
			ImGuiNative.DebugDrawCursorPos(col);
		}

		public static void DebugDrawLineExtents(uint col)
		{
			ImGuiNative.DebugDrawLineExtents(col);
		}

		public static void DebugDrawItemRect(uint col)
		{
			ImGuiNative.DebugDrawItemRect(col);
		}

		public static void DebugTextUnformattedWithLocateItem(ReadOnlySpan<char> lineBegin, ReadOnlySpan<char> lineEnd)
		{
			// Marshaling lineBegin to native string
			byte* native_lineBegin;
			var byteCount_lineBegin = 0;
			if (lineBegin != null)
			{
				byteCount_lineBegin = Encoding.UTF8.GetByteCount(lineBegin);
				if(byteCount_lineBegin > Utils.MaxStackallocSize)
				{
					native_lineBegin = Utils.Alloc<byte>(byteCount_lineBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_lineBegin + 1];
					native_lineBegin = stackallocBytes;
				}
				var lineBegin_offset = Utils.EncodeStringUTF8(lineBegin, native_lineBegin, byteCount_lineBegin);
				native_lineBegin[lineBegin_offset] = 0;
			}
			else native_lineBegin = null;

			// Marshaling lineEnd to native string
			byte* native_lineEnd;
			var byteCount_lineEnd = 0;
			if (lineEnd != null)
			{
				byteCount_lineEnd = Encoding.UTF8.GetByteCount(lineEnd);
				if(byteCount_lineEnd > Utils.MaxStackallocSize)
				{
					native_lineEnd = Utils.Alloc<byte>(byteCount_lineEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_lineEnd + 1];
					native_lineEnd = stackallocBytes;
				}
				var lineEnd_offset = Utils.EncodeStringUTF8(lineEnd, native_lineEnd, byteCount_lineEnd);
				native_lineEnd[lineEnd_offset] = 0;
			}
			else native_lineEnd = null;

			ImGuiNative.DebugTextUnformattedWithLocateItem(native_lineBegin, native_lineEnd);
			// Freeing lineBegin native string
			if (byteCount_lineBegin > Utils.MaxStackallocSize)
				Utils.Free(native_lineBegin);
			// Freeing lineEnd native string
			if (byteCount_lineEnd > Utils.MaxStackallocSize)
				Utils.Free(native_lineEnd);
		}

		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		public static void DebugLocateItem(uint targetId)
		{
			ImGuiNative.DebugLocateItem(targetId);
		}

		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		public static void DebugLocateItemOnHover(uint targetId)
		{
			ImGuiNative.DebugLocateItemOnHover(targetId);
		}

		public static void DebugLocateItemResolveWithLastItem()
		{
			ImGuiNative.DebugLocateItemResolveWithLastItem();
		}

		public static void DebugBreakClearData()
		{
			ImGuiNative.DebugBreakClearData();
		}

		public static byte DebugBreakButton(ReadOnlySpan<char> label, ReadOnlySpan<char> descriptionOfLocation)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling descriptionOfLocation to native string
			byte* native_descriptionOfLocation;
			var byteCount_descriptionOfLocation = 0;
			if (descriptionOfLocation != null)
			{
				byteCount_descriptionOfLocation = Encoding.UTF8.GetByteCount(descriptionOfLocation);
				if(byteCount_descriptionOfLocation > Utils.MaxStackallocSize)
				{
					native_descriptionOfLocation = Utils.Alloc<byte>(byteCount_descriptionOfLocation + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_descriptionOfLocation + 1];
					native_descriptionOfLocation = stackallocBytes;
				}
				var descriptionOfLocation_offset = Utils.EncodeStringUTF8(descriptionOfLocation, native_descriptionOfLocation, byteCount_descriptionOfLocation);
				native_descriptionOfLocation[descriptionOfLocation_offset] = 0;
			}
			else native_descriptionOfLocation = null;

			return ImGuiNative.DebugBreakButton(native_label, native_descriptionOfLocation);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
			// Freeing descriptionOfLocation native string
			if (byteCount_descriptionOfLocation > Utils.MaxStackallocSize)
				Utils.Free(native_descriptionOfLocation);
		}

		public static void DebugBreakButtonTooltip(bool keyboardOnly, ReadOnlySpan<char> descriptionOfLocation)
		{
			var native_keyboardOnly = keyboardOnly ? (byte)1 : (byte)0;
			// Marshaling descriptionOfLocation to native string
			byte* native_descriptionOfLocation;
			var byteCount_descriptionOfLocation = 0;
			if (descriptionOfLocation != null)
			{
				byteCount_descriptionOfLocation = Encoding.UTF8.GetByteCount(descriptionOfLocation);
				if(byteCount_descriptionOfLocation > Utils.MaxStackallocSize)
				{
					native_descriptionOfLocation = Utils.Alloc<byte>(byteCount_descriptionOfLocation + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_descriptionOfLocation + 1];
					native_descriptionOfLocation = stackallocBytes;
				}
				var descriptionOfLocation_offset = Utils.EncodeStringUTF8(descriptionOfLocation, native_descriptionOfLocation, byteCount_descriptionOfLocation);
				native_descriptionOfLocation[descriptionOfLocation_offset] = 0;
			}
			else native_descriptionOfLocation = null;

			ImGuiNative.DebugBreakButtonTooltip(native_keyboardOnly, native_descriptionOfLocation);
			// Freeing descriptionOfLocation native string
			if (byteCount_descriptionOfLocation > Utils.MaxStackallocSize)
				Utils.Free(native_descriptionOfLocation);
		}

		public static void ShowFontAtlas(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ShowFontAtlas(atlas);
		}

		public static void DebugHookIdInfo(uint id, ImGuiDataType dataType, IntPtr dataId, IntPtr dataIdEnd)
		{
			ImGuiNative.DebugHookIdInfo(id, dataType, (void*)dataId, (void*)dataIdEnd);
		}

		public static void DebugNodeColumns(ImGuiOldColumnsPtr columns)
		{
			ImGuiNative.DebugNodeColumns(columns);
		}

		public static void DebugNodeDockNode(ImGuiDockNodePtr node, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.DebugNodeDockNode(node, native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void DebugNodeDrawList(ImGuiWindowPtr window, ImGuiViewportPPtr viewport, ImDrawListPtr drawList, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.DebugNodeDrawList(window, viewport, drawList, native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawListPtr outDrawList, ImDrawListPtr drawList, ImDrawCmdPtr drawCmd, bool showMesh, bool showAabb)
		{
			var native_showMesh = showMesh ? (byte)1 : (byte)0;
			var native_showAabb = showAabb ? (byte)1 : (byte)0;
			ImGuiNative.DebugNodeDrawCmdShowMeshAndBoundingBox(outDrawList, drawList, drawCmd, native_showMesh, native_showAabb);
		}

		public static void DebugNodeFont(ImFontPtr font)
		{
			ImGuiNative.DebugNodeFont(font);
		}

		public static void DebugNodeFontGlyph(ImFontPtr font, ImFontGlyphPtr glyph)
		{
			ImGuiNative.DebugNodeFontGlyph(font, glyph);
		}

		public static void DebugNodeStorage(ImGuiStoragePtr storage, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.DebugNodeStorage(storage, native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void DebugNodeTabBar(ImGuiTabBarPtr tabBar, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.DebugNodeTabBar(tabBar, native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void DebugNodeTable(ImGuiTablePtr table)
		{
			ImGuiNative.DebugNodeTable(table);
		}

		public static void DebugNodeTableSettings(ImGuiTableSettingsPtr settings)
		{
			ImGuiNative.DebugNodeTableSettings(settings);
		}

		public static void DebugNodeInputTextState(ImGuiInputTextStatePtr state)
		{
			ImGuiNative.DebugNodeInputTextState(state);
		}

		public static void DebugNodeTypingSelectState(ImGuiTypingSelectStatePtr state)
		{
			ImGuiNative.DebugNodeTypingSelectState(state);
		}

		public static void DebugNodeMultiSelectState(ImGuiMultiSelectStatePtr state)
		{
			ImGuiNative.DebugNodeMultiSelectState(state);
		}

		public static void DebugNodeWindow(ImGuiWindowPtr window, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.DebugNodeWindow(window, native_label);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void DebugNodeWindowSettings(ImGuiWindowSettingsPtr settings)
		{
			ImGuiNative.DebugNodeWindowSettings(settings);
		}

		public static void DebugNodeWindowsList(ref ImVector<ImGuiWindowPtr> windows, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (ImVector<ImGuiWindowPtr>* native_windows = &windows)
			{
				ImGuiNative.DebugNodeWindowsList(native_windows, native_label);
				// Freeing label native string
				if (byteCount_label > Utils.MaxStackallocSize)
					Utils.Free(native_label);
			}
		}

		public static void DebugNodeWindowsListByBeginStackParent(ref ImGuiWindow* windows, int windowsSize, ImGuiWindowPtr parentInBeginStack)
		{
			fixed (ImGuiWindow** native_windows = &windows)
			{
				ImGuiNative.DebugNodeWindowsListByBeginStackParent(native_windows, windowsSize, parentInBeginStack);
			}
		}

		public static void DebugNodeViewport(ImGuiViewportPPtr viewport)
		{
			ImGuiNative.DebugNodeViewport(viewport);
		}

		public static void DebugNodePlatformMonitor(ImGuiPlatformMonitorPtr monitor, ReadOnlySpan<char> label, int idx)
		{
			// Marshaling label to native string
			byte* native_label;
			var byteCount_label = 0;
			if (label != null)
			{
				byteCount_label = Encoding.UTF8.GetByteCount(label);
				if(byteCount_label > Utils.MaxStackallocSize)
				{
					native_label = Utils.Alloc<byte>(byteCount_label + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_label + 1];
					native_label = stackallocBytes;
				}
				var label_offset = Utils.EncodeStringUTF8(label, native_label, byteCount_label);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.DebugNodePlatformMonitor(monitor, native_label, idx);
			// Freeing label native string
			if (byteCount_label > Utils.MaxStackallocSize)
				Utils.Free(native_label);
		}

		public static void DebugRenderKeyboardPreview(ImDrawListPtr drawList)
		{
			ImGuiNative.DebugRenderKeyboardPreview(drawList);
		}

		public static void DebugRenderViewportThumbnail(ImDrawListPtr drawList, ImGuiViewportPPtr viewport, ImRect bb)
		{
			ImGuiNative.DebugRenderViewportThumbnail(drawList, viewport, bb);
		}

		public static ImFontBuilderIOPtr ImFontAtlasGetBuilderForStbTruetype()
		{
			return ImGuiNative.ImFontAtlasGetBuilderForStbTruetype();
		}

		public static void ImFontAtlasUpdateSourcesPointers(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ImFontAtlasUpdateSourcesPointers(atlas);
		}

		public static void ImFontAtlasBuildInit(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ImFontAtlasBuildInit(atlas);
		}

		public static void ImFontAtlasBuildSetupFont(ImFontAtlasPtr atlas, ImFontPtr font, ImFontConfigPtr src, float ascent, float descent)
		{
			ImGuiNative.ImFontAtlasBuildSetupFont(atlas, font, src, ascent, descent);
		}

		public static void ImFontAtlasBuildPackCustomRects(ImFontAtlasPtr atlas, IntPtr stbrpContextOpaque)
		{
			ImGuiNative.ImFontAtlasBuildPackCustomRects(atlas, (void*)stbrpContextOpaque);
		}

		public static void ImFontAtlasBuildFinish(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ImFontAtlasBuildFinish(atlas);
		}

		public static void ImFontAtlasBuildRender8BppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, ReadOnlySpan<char> inStr, bool inMarkerChar, bool inMarkerPixelValue)
		{
			// Marshaling inStr to native string
			byte* native_inStr;
			var byteCount_inStr = 0;
			if (inStr != null)
			{
				byteCount_inStr = Encoding.UTF8.GetByteCount(inStr);
				if(byteCount_inStr > Utils.MaxStackallocSize)
				{
					native_inStr = Utils.Alloc<byte>(byteCount_inStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inStr + 1];
					native_inStr = stackallocBytes;
				}
				var inStr_offset = Utils.EncodeStringUTF8(inStr, native_inStr, byteCount_inStr);
				native_inStr[inStr_offset] = 0;
			}
			else native_inStr = null;

			var native_inMarkerChar = inMarkerChar ? (byte)1 : (byte)0;
			var native_inMarkerPixelValue = inMarkerPixelValue ? (byte)1 : (byte)0;
			ImGuiNative.ImFontAtlasBuildRender8BppRectFromString(atlas, x, y, w, h, native_inStr, native_inMarkerChar, native_inMarkerPixelValue);
			// Freeing inStr native string
			if (byteCount_inStr > Utils.MaxStackallocSize)
				Utils.Free(native_inStr);
		}

		public static void ImFontAtlasBuildRender32BppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, ReadOnlySpan<char> inStr, bool inMarkerChar, uint inMarkerPixelValue)
		{
			// Marshaling inStr to native string
			byte* native_inStr;
			var byteCount_inStr = 0;
			if (inStr != null)
			{
				byteCount_inStr = Encoding.UTF8.GetByteCount(inStr);
				if(byteCount_inStr > Utils.MaxStackallocSize)
				{
					native_inStr = Utils.Alloc<byte>(byteCount_inStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_inStr + 1];
					native_inStr = stackallocBytes;
				}
				var inStr_offset = Utils.EncodeStringUTF8(inStr, native_inStr, byteCount_inStr);
				native_inStr[inStr_offset] = 0;
			}
			else native_inStr = null;

			var native_inMarkerChar = inMarkerChar ? (byte)1 : (byte)0;
			ImGuiNative.ImFontAtlasBuildRender32BppRectFromString(atlas, x, y, w, h, native_inStr, native_inMarkerChar, inMarkerPixelValue);
			// Freeing inStr native string
			if (byteCount_inStr > Utils.MaxStackallocSize)
				Utils.Free(native_inStr);
		}

		public static void ImFontAtlasBuildMultiplyCalcLookupTable(ReadOnlySpan<char> outTable, float inMultiplyFactor)
		{
			// Marshaling outTable to native string
			byte* native_outTable;
			var byteCount_outTable = 0;
			if (outTable != null)
			{
				byteCount_outTable = Encoding.UTF8.GetByteCount(outTable);
				if(byteCount_outTable > Utils.MaxStackallocSize)
				{
					native_outTable = Utils.Alloc<byte>(byteCount_outTable + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_outTable + 1];
					native_outTable = stackallocBytes;
				}
				var outTable_offset = Utils.EncodeStringUTF8(outTable, native_outTable, byteCount_outTable);
				native_outTable[outTable_offset] = 0;
			}
			else native_outTable = null;

			ImGuiNative.ImFontAtlasBuildMultiplyCalcLookupTable(native_outTable, inMultiplyFactor);
			// Freeing outTable native string
			if (byteCount_outTable > Utils.MaxStackallocSize)
				Utils.Free(native_outTable);
		}

		public static void ImFontAtlasBuildMultiplyRectAlpha8(ReadOnlySpan<char> table, ReadOnlySpan<char> pixels, int x, int y, int w, int h, int stride)
		{
			// Marshaling table to native string
			byte* native_table;
			var byteCount_table = 0;
			if (table != null)
			{
				byteCount_table = Encoding.UTF8.GetByteCount(table);
				if(byteCount_table > Utils.MaxStackallocSize)
				{
					native_table = Utils.Alloc<byte>(byteCount_table + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_table + 1];
					native_table = stackallocBytes;
				}
				var table_offset = Utils.EncodeStringUTF8(table, native_table, byteCount_table);
				native_table[table_offset] = 0;
			}
			else native_table = null;

			// Marshaling pixels to native string
			byte* native_pixels;
			var byteCount_pixels = 0;
			if (pixels != null)
			{
				byteCount_pixels = Encoding.UTF8.GetByteCount(pixels);
				if(byteCount_pixels > Utils.MaxStackallocSize)
				{
					native_pixels = Utils.Alloc<byte>(byteCount_pixels + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCount_pixels + 1];
					native_pixels = stackallocBytes;
				}
				var pixels_offset = Utils.EncodeStringUTF8(pixels, native_pixels, byteCount_pixels);
				native_pixels[pixels_offset] = 0;
			}
			else native_pixels = null;

			ImGuiNative.ImFontAtlasBuildMultiplyRectAlpha8(native_table, native_pixels, x, y, w, h, stride);
			// Freeing table native string
			if (byteCount_table > Utils.MaxStackallocSize)
				Utils.Free(native_table);
			// Freeing pixels native string
			if (byteCount_pixels > Utils.MaxStackallocSize)
				Utils.Free(native_pixels);
		}

		public static void ImFontAtlasBuildGetOversampleFactors(ImFontConfigPtr src, ref int outOversampleH, ref int outOversampleV)
		{
			fixed (int* native_outOversampleH = &outOversampleH)
			fixed (int* native_outOversampleV = &outOversampleV)
			{
				ImGuiNative.ImFontAtlasBuildGetOversampleFactors(src, native_outOversampleH, native_outOversampleV);
			}
		}

		public static byte ImFontAtlasGetMouseCursorTexData(ImFontAtlasPtr atlas, ImGuiMouseCursor cursorType, ref Vector2 outOffset, ref Vector2 outSize, ref Vector2 outUvBorder, ref Vector2 outUvFill)
		{
			fixed (Vector2* native_outOffset = &outOffset)
			fixed (Vector2* native_outSize = &outSize)
			fixed (Vector2* native_outUvBorder = &outUvBorder)
			fixed (Vector2* native_outUvFill = &outUvFill)
			{
				var result = ImGuiNative.ImFontAtlasGetMouseCursorTexData(atlas, cursorType, native_outOffset, native_outSize, native_outUvBorder, native_outUvFill);
				return result;
			}
		}

		public static float GETFLTMAX()
		{
			return ImGuiNative.GETFLTMAX();
		}

		public static float GETFLTMIN()
		{
			return ImGuiNative.GETFLTMIN();
		}

		public static ref ImVector<ushort> ImVectorImWcharCreate()
		{
			var nativeResult = ImGuiNative.ImVectorImWcharCreate();
			return ref *(ImVector<ushort>*)&nativeResult;
		}

		public static void ImVectorImWcharDestroy(ref ImVector<ushort> self)
		{
			fixed (ImVector<ushort>* native_self = &self)
			{
				ImGuiNative.ImVectorImWcharDestroy(native_self);
			}
		}

		public static void ImVectorImWcharInit(ref ImVector<ushort> p)
		{
			fixed (ImVector<ushort>* native_p = &p)
			{
				ImGuiNative.ImVectorImWcharInit(native_p);
			}
		}

		public static void ImVectorImWcharUnInit(ref ImVector<ushort> p)
		{
			fixed (ImVector<ushort>* native_p = &p)
			{
				ImGuiNative.ImVectorImWcharUnInit(native_p);
			}
		}

	}
}

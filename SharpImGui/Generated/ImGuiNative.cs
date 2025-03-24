using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	struct ImGuiNative
	{
		public static unsafe extern void ClearAllBits(ImBitArray* self);
		public static unsafe extern void HSV(ImColor* pOut, float h, float s, float v, float a);
		public static unsafe extern void ImColor();
		public static unsafe extern void ImColor(float r, float g, float b, float a);
		public static unsafe extern void ImColor(const ImVec4 col);
		public static unsafe extern void ImColor(int r, int g, int b, int a);
		public static unsafe extern void ImColor(ImU32 rgba);
		public static unsafe extern void SetHSV(ImColor* self, float h, float s, float v, float a);
		public static unsafe extern void Unknown(ImColor* self);
		public static unsafe extern ImTextureID GetTexID(ImDrawCmd* self);
		/// <summary>
		/// Also ensure our padding fields are zeroed<br/>
		/// </summary>
		public static unsafe extern void ImDrawCmd();
		public static unsafe extern void Unknown(ImDrawCmd* self);
		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.<br/>
		/// </summary>
		public static unsafe extern void AddDrawList(ImDrawData* self, ImDrawList* draw_list);
		public static unsafe extern void Clear(ImDrawData* self);
		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!<br/>
		/// </summary>
		public static unsafe extern void DeIndexAllBuffers(ImDrawData* self);
		public static unsafe extern void ImDrawData();
		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.<br/>
		/// </summary>
		public static unsafe extern void ScaleClipRects(ImDrawData* self, const ImVec2 fb_scale);
		public static unsafe extern void Unknown(ImDrawData* self);
		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame<br/>
		/// </summary>
		public static unsafe extern void Clear(ImDrawListSplitter* self);
		public static unsafe extern void ClearFreeMemory(ImDrawListSplitter* self);
		public static unsafe extern void ImDrawListSplitter();
		public static unsafe extern void Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
		public static unsafe extern void SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
		public static unsafe extern void Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
		public static unsafe extern void Unknown(ImDrawListSplitter* self);
		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public static unsafe extern void AddBezierCubic(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, ImU32 col, float thickness, int num_segments);
		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public static unsafe extern void AddBezierQuadratic(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, ImU32 col, float thickness, int num_segments);
		public static unsafe extern void AddCallback(ImDrawList* self, ImDrawCallback callback, void* userdata, size_t userdata_size);
		public static unsafe extern void AddCircle(ImDrawList* self, const ImVec2 center, float radius, ImU32 col, int num_segments, float thickness);
		public static unsafe extern void AddCircleFilled(ImDrawList* self, const ImVec2 center, float radius, ImU32 col, int num_segments);
		public static unsafe extern void AddConcavePolyFilled(ImDrawList* self, const ImVec2* points, int num_points, ImU32 col);
		public static unsafe extern void AddConvexPolyFilled(ImDrawList* self, const ImVec2* points, int num_points, ImU32 col);
		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible<br/>
		/// </summary>
		public static unsafe extern void AddDrawCmd(ImDrawList* self);
		public static unsafe extern void AddEllipse(ImDrawList* self, const ImVec2 center, const ImVec2 radius, ImU32 col, float rot, int num_segments, float thickness);
		public static unsafe extern void AddEllipseFilled(ImDrawList* self, const ImVec2 center, const ImVec2 radius, ImU32 col, float rot, int num_segments);
		public static unsafe extern void AddImage(ImDrawList* self, ImTextureID user_texture_id, const ImVec2 p_min, const ImVec2 p_max, const ImVec2 uv_min, const ImVec2 uv_max, ImU32 col);
		public static unsafe extern void AddImageQuad(ImDrawList* self, ImTextureID user_texture_id, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, const ImVec2 uv1, const ImVec2 uv2, const ImVec2 uv3, const ImVec2 uv4, ImU32 col);
		public static unsafe extern void AddImageRounded(ImDrawList* self, ImTextureID user_texture_id, const ImVec2 p_min, const ImVec2 p_max, const ImVec2 uv_min, const ImVec2 uv_max, ImU32 col, float rounding, ImDrawFlags flags);
		public static unsafe extern void AddLine(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, ImU32 col, float thickness);
		public static unsafe extern void AddNgon(ImDrawList* self, const ImVec2 center, float radius, ImU32 col, int num_segments, float thickness);
		public static unsafe extern void AddNgonFilled(ImDrawList* self, const ImVec2 center, float radius, ImU32 col, int num_segments);
		public static unsafe extern void AddPolyline(ImDrawList* self, const ImVec2* points, int num_points, ImU32 col, ImDrawFlags flags, float thickness);
		public static unsafe extern void AddQuad(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, ImU32 col, float thickness);
		public static unsafe extern void AddQuadFilled(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, ImU32 col);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public static unsafe extern void AddRect(ImDrawList* self, const ImVec2 p_min, const ImVec2 p_max, ImU32 col, float rounding, ImDrawFlags flags, float thickness);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public static unsafe extern void AddRectFilled(ImDrawList* self, const ImVec2 p_min, const ImVec2 p_max, ImU32 col, float rounding, ImDrawFlags flags);
		public static unsafe extern void AddRectFilledMultiColor(ImDrawList* self, const ImVec2 p_min, const ImVec2 p_max, ImU32 col_upr_left, ImU32 col_upr_right, ImU32 col_bot_right, ImU32 col_bot_left);
		public static unsafe extern void AddText(ImDrawList* self, const ImVec2 pos, ImU32 col, const char* text_begin, const char* text_end);
		public static unsafe extern void AddText(ImDrawList* self, ImFont* font, float font_size, const ImVec2 pos, ImU32 col, const char* text_begin, const char* text_end, float wrap_width, const ImVec4* cpu_fine_clip_rect);
		public static unsafe extern void AddTriangle(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, ImU32 col, float thickness);
		public static unsafe extern void AddTriangleFilled(ImDrawList* self, const ImVec2 p1, const ImVec2 p2, const ImVec2 p3, ImU32 col);
		public static unsafe extern void ChannelsMerge(ImDrawList* self);
		public static unsafe extern void ChannelsSetCurrent(ImDrawList* self, int n);
		public static unsafe extern void ChannelsSplit(ImDrawList* self, int count);
		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.<br/>
		/// </summary>
		public static unsafe extern ImDrawList* CloneOutput(ImDrawList* self);
		public static unsafe extern void GetClipRectMax(ImVec2* pOut, ImDrawList* self);
		public static unsafe extern void GetClipRectMin(ImVec2* pOut, ImDrawList* self);
		public static unsafe extern void ImDrawList(ImDrawListSharedData* shared_data);
		public static unsafe extern void PathArcTo(ImDrawList* self, const ImVec2 center, float radius, float a_min, float a_max, int num_segments);
		/// <summary>
		/// Use precomputed angles for a 12 steps circle<br/>
		/// </summary>
		public static unsafe extern void PathArcToFast(ImDrawList* self, const ImVec2 center, float radius, int a_min_of_12, int a_max_of_12);
		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public static unsafe extern void PathBezierCubicCurveTo(ImDrawList* self, const ImVec2 p2, const ImVec2 p3, const ImVec2 p4, int num_segments);
		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public static unsafe extern void PathBezierQuadraticCurveTo(ImDrawList* self, const ImVec2 p2, const ImVec2 p3, int num_segments);
		public static unsafe extern void PathClear(ImDrawList* self);
		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		public static unsafe extern void PathEllipticalArcTo(ImDrawList* self, const ImVec2 center, const ImVec2 radius, float rot, float a_min, float a_max, int num_segments);
		public static unsafe extern void PathFillConcave(ImDrawList* self, ImU32 col);
		public static unsafe extern void PathFillConvex(ImDrawList* self, ImU32 col);
		public static unsafe extern void PathLineTo(ImDrawList* self, const ImVec2 pos);
		public static unsafe extern void PathLineToMergeDuplicate(ImDrawList* self, const ImVec2 pos);
		public static unsafe extern void PathRect(ImDrawList* self, const ImVec2 rect_min, const ImVec2 rect_max, float rounding, ImDrawFlags flags);
		public static unsafe extern void PathStroke(ImDrawList* self, ImU32 col, ImDrawFlags flags, float thickness);
		public static unsafe extern void PopClipRect(ImDrawList* self);
		public static unsafe extern void PopTextureID(ImDrawList* self);
		public static unsafe extern void PrimQuadUV(ImDrawList* self, const ImVec2 a, const ImVec2 b, const ImVec2 c, const ImVec2 d, const ImVec2 uv_a, const ImVec2 uv_b, const ImVec2 uv_c, const ImVec2 uv_d, ImU32 col);
		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)<br/>
		/// </summary>
		public static unsafe extern void PrimRect(ImDrawList* self, const ImVec2 a, const ImVec2 b, ImU32 col);
		public static unsafe extern void PrimRectUV(ImDrawList* self, const ImVec2 a, const ImVec2 b, const ImVec2 uv_a, const ImVec2 uv_b, ImU32 col);
		public static unsafe extern void PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
		public static unsafe extern void PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
		/// <summary>
		/// Write vertex with unique index<br/>
		/// </summary>
		public static unsafe extern void PrimVtx(ImDrawList* self, const ImVec2 pos, const ImVec2 uv, ImU32 col);
		public static unsafe extern void PrimWriteIdx(ImDrawList* self, ImDrawIdx idx);
		public static unsafe extern void PrimWriteVtx(ImDrawList* self, const ImVec2 pos, const ImVec2 uv, ImU32 col);
		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		public static unsafe extern void PushClipRect(ImDrawList* self, const ImVec2 clip_rect_min, const ImVec2 clip_rect_max, bool intersect_with_current_clip_rect);
		public static unsafe extern void PushClipRectFullScreen(ImDrawList* self);
		public static unsafe extern void PushTextureID(ImDrawList* self, ImTextureID texture_id);
		public static unsafe extern int _CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
		public static unsafe extern void _ClearFreeMemory(ImDrawList* self);
		public static unsafe extern void _OnChangedClipRect(ImDrawList* self);
		public static unsafe extern void _OnChangedTextureID(ImDrawList* self);
		public static unsafe extern void _OnChangedVtxOffset(ImDrawList* self);
		public static unsafe extern void _PathArcToFastEx(ImDrawList* self, const ImVec2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
		public static unsafe extern void _PathArcToN(ImDrawList* self, const ImVec2 center, float radius, float a_min, float a_max, int num_segments);
		public static unsafe extern void _PopUnusedDrawCmd(ImDrawList* self);
		public static unsafe extern void _ResetForNewFrame(ImDrawList* self);
		public static unsafe extern void _SetTextureID(ImDrawList* self, ImTextureID texture_id);
		public static unsafe extern void _TryMergeDrawCmds(ImDrawList* self);
		public static unsafe extern void Unknown(ImDrawList* self);
		public static unsafe extern void ImFontAtlasCustomRect();
		public static unsafe extern bool IsPacked(ImFontAtlasCustomRect* self);
		public static unsafe extern void Unknown(ImFontAtlasCustomRect* self);
		public static unsafe extern int AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ImWchar id, int width, int height, float advance_x, const ImVec2 offset);
		public static unsafe extern int AddCustomRectRegular(ImFontAtlas* self, int width, int height);
		public static unsafe extern ImFont* AddFont(ImFontAtlas* self, const ImFontConfig* font_cfg);
		public static unsafe extern ImFont* AddFontDefault(ImFontAtlas* self, const ImFontConfig* font_cfg);
		public static unsafe extern ImFont* AddFontFromFileTTF(ImFontAtlas* self, const char* filename, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public static unsafe extern ImFont* AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, const char* compressed_font_data_base85, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		public static unsafe extern ImFont* AddFontFromMemoryCompressedTTF(ImFontAtlas* self, const void* compressed_font_data, int compressed_font_data_size, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg->FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		public static unsafe extern ImFont* AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, const ImFontConfig* font_cfg, const ImWchar* glyph_ranges);
		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.<br/>
		/// </summary>
		public static unsafe extern bool Build(ImFontAtlas* self);
		public static unsafe extern void CalcCustomRectUV(ImFontAtlas* self, const ImFontAtlasCustomRect* rect, ImVec2* out_uv_min, ImVec2* out_uv_max);
		/// <summary>
		/// Clear all input and output.<br/>
		/// </summary>
		public static unsafe extern void Clear(ImFontAtlas* self);
		/// <summary>
		/// Clear input+output font data (same as ClearInputData() + glyphs storage, UV coordinates).<br/>
		/// </summary>
		public static unsafe extern void ClearFonts(ImFontAtlas* self);
		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.<br/>
		/// </summary>
		public static unsafe extern void ClearInputData(ImFontAtlas* self);
		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.<br/>
		/// </summary>
		public static unsafe extern void ClearTexData(ImFontAtlas* self);
		public static unsafe extern ImFontAtlasCustomRect* GetCustomRectByIndex(ImFontAtlas* self, int index);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesChineseFull(ImFontAtlas* self);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
		/// <summary>
		/// Default + about 400 Cyrillic characters<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesCyrillic(ImFontAtlas* self);
		/// <summary>
		/// Basic Latin, Extended Latin<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesDefault(ImFontAtlas* self);
		/// <summary>
		/// Default + Greek and Coptic<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesGreek(ImFontAtlas* self);
		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesJapanese(ImFontAtlas* self);
		/// <summary>
		/// Default + Korean characters<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesKorean(ImFontAtlas* self);
		/// <summary>
		/// Default + Thai characters<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesThai(ImFontAtlas* self);
		/// <summary>
		/// Default + Vietnamese characters<br/>
		/// </summary>
		public static unsafe extern const ImWchar* GetGlyphRangesVietnamese(ImFontAtlas* self);
		public static unsafe extern bool GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, ImVec2* out_offset, ImVec2* out_size, ImVec2[2] out_uv_border, ImVec2[2] out_uv_fill);
		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		public static unsafe extern void GetTexDataAsAlpha8(ImFontAtlas* self, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		public static unsafe extern void GetTexDataAsRGBA32(ImFontAtlas* self, unsigned char** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
		public static unsafe extern void ImFontAtlas();
		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...<br/>
		/// </summary>
		public static unsafe extern bool IsBuilt(ImFontAtlas* self);
		public static unsafe extern void SetTexID(ImFontAtlas* self, ImTextureID id);
		public static unsafe extern void Unknown(ImFontAtlas* self);
		public static unsafe extern void ImFontConfig();
		public static unsafe extern void Unknown(ImFontConfig* self);
		/// <summary>
		/// Add character<br/>
		/// </summary>
		public static unsafe extern void AddChar(ImFontGlyphRangesBuilder* self, ImWchar c);
		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		public static unsafe extern void AddRanges(ImFontGlyphRangesBuilder* self, const ImWchar* ranges);
		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public static unsafe extern void AddText(ImFontGlyphRangesBuilder* self, const char* text, const char* text_end);
		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		public static unsafe extern void BuildRanges(ImFontGlyphRangesBuilder* self, ImVector_ImWchar* out_ranges);
		public static unsafe extern void Clear(ImFontGlyphRangesBuilder* self);
		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		public static unsafe extern bool GetBit(ImFontGlyphRangesBuilder* self, size_t n);
		public static unsafe extern void ImFontGlyphRangesBuilder();
		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		public static unsafe extern void SetBit(ImFontGlyphRangesBuilder* self, size_t n);
		public static unsafe extern void Unknown(ImFontGlyphRangesBuilder* self);
		public static unsafe extern void AddGlyph(ImFont* self, const ImFontConfig* src_cfg, ImWchar c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public static unsafe extern void AddRemapChar(ImFont* self, ImWchar dst, ImWchar src, bool overwrite_dst);
		public static unsafe extern void BuildLookupTable(ImFont* self);
		/// <summary>
		/// utf8<br/>
		/// </summary>
		public static unsafe extern void CalcTextSizeA(ImVec2* pOut, ImFont* self, float size, float max_width, float wrap_width, const char* text_begin, const char* text_end, const char** remaining);
		public static unsafe extern const char* CalcWordWrapPositionA(ImFont* self, float scale, const char* text, const char* text_end, float wrap_width);
		public static unsafe extern void ClearOutputData(ImFont* self);
		public static unsafe extern const ImFontGlyph* FindGlyph(ImFont* self, ImWchar c);
		public static unsafe extern const ImFontGlyph* FindGlyphNoFallback(ImFont* self, ImWchar c);
		public static unsafe extern float GetCharAdvance(ImFont* self, ImWchar c);
		public static unsafe extern const char* GetDebugName(ImFont* self);
		public static unsafe extern void GrowIndex(ImFont* self, int new_size);
		public static unsafe extern void ImFont();
		public static unsafe extern bool IsGlyphRangeUnused(ImFont* self, unsigned int c_begin, unsigned int c_last);
		public static unsafe extern bool IsLoaded(ImFont* self);
		public static unsafe extern void RenderChar(ImFont* self, ImDrawList* draw_list, float size, const ImVec2 pos, ImU32 col, ImWchar c);
		public static unsafe extern void RenderText(ImFont* self, ImDrawList* draw_list, float size, const ImVec2 pos, ImU32 col, const ImVec4 clip_rect, const char* text_begin, const char* text_end, float wrap_width, bool cpu_fine_clip);
		public static unsafe extern void SetGlyphVisible(ImFont* self, ImWchar c, bool visible);
		public static unsafe extern void Unknown(ImFont* self);
		public static unsafe extern const ImFontBuilderIO* GetBuilderForFreeType();
		public static unsafe extern void SetAllocatorFunctions(void*(*)(size_t sz,void* user_data) alloc_func, void(*)(void* ptr,void* user_data) free_func, void* user_data);
		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)<br/>
		/// </summary>
		public static unsafe extern void AddFocusEvent(ImGuiIO* self, bool focused);
		/// <summary>
		/// Queue a new character input<br/>
		/// </summary>
		public static unsafe extern void AddInputCharacter(ImGuiIO* self, unsigned int c);
		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate<br/>
		/// </summary>
		public static unsafe extern void AddInputCharacterUTF16(ImGuiIO* self, ImWchar16 c);
		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		public static unsafe extern void AddInputCharactersUTF8(ImGuiIO* self, const char* str);
		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.<br/>
		/// </summary>
		public static unsafe extern void AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, bool down, float v);
		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)<br/>
		/// </summary>
		public static unsafe extern void AddKeyEvent(ImGuiIO* self, ImGuiKey key, bool down);
		/// <summary>
		/// Queue a mouse button change<br/>
		/// </summary>
		public static unsafe extern void AddMouseButtonEvent(ImGuiIO* self, int button, bool down);
		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)<br/>
		/// </summary>
		public static unsafe extern void AddMousePosEvent(ImGuiIO* self, float x, float y);
		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)<br/>
		/// </summary>
		public static unsafe extern void AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).<br/>
		/// </summary>
		public static unsafe extern void AddMouseViewportEvent(ImGuiIO* self, ImGuiID id);
		/// <summary>
		/// Queue a mouse wheel update. wheel_y<0: scroll down, wheel_y>0: scroll up, wheel_x<0: scroll right, wheel_x>0: scroll left.<br/>
		/// </summary>
		public static unsafe extern void AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);
		/// <summary>
		/// Clear all incoming events.<br/>
		/// </summary>
		public static unsafe extern void ClearEventsQueue(ImGuiIO* self);
		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.<br/>
		/// </summary>
		public static unsafe extern void ClearInputKeys(ImGuiIO* self);
		/// <summary>
		/// Clear current mouse state.<br/>
		/// </summary>
		public static unsafe extern void ClearInputMouse(ImGuiIO* self);
		public static unsafe extern void ImGuiIO();
		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.<br/>
		/// </summary>
		public static unsafe extern void SetAppAcceptingEvents(ImGuiIO* self, bool accepting_events);
		/// <summary>
		/// [Optional] Specify index for legacy <1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		public static unsafe extern void SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
		public static unsafe extern void Unknown(ImGuiIO* self);
		public static unsafe extern void ClearSelection(ImGuiInputTextCallbackData* self);
		public static unsafe extern void DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
		public static unsafe extern bool HasSelection(ImGuiInputTextCallbackData* self);
		public static unsafe extern void ImGuiInputTextCallbackData();
		public static unsafe extern void InsertChars(ImGuiInputTextCallbackData* self, int pos, const char* text, const char* text_end);
		public static unsafe extern void SelectAll(ImGuiInputTextCallbackData* self);
		public static unsafe extern void Unknown(ImGuiInputTextCallbackData* self);
		public static unsafe extern void Begin(ImGuiListClipper* self, int items_count, float items_height);
		/// <summary>
		/// Automatically called on the last call of Step() that returns false.<br/>
		/// </summary>
		public static unsafe extern void End(ImGuiListClipper* self);
		public static unsafe extern void ImGuiListClipper();
		public static unsafe extern void IncludeItemByIndex(ImGuiListClipper* self, int item_index);
		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.<br/>
		/// </summary>
		public static unsafe extern void IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end);
		public static unsafe extern void SeekCursorForItem(ImGuiListClipper* self, int item_index);
		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.<br/>
		/// </summary>
		public static unsafe extern bool Step(ImGuiListClipper* self);
		public static unsafe extern void Unknown(ImGuiListClipper* self);
		public static unsafe extern void ImGuiOnceUponAFrame();
		public static unsafe extern void Unknown(ImGuiOnceUponAFrame* self);
		public static unsafe extern void Clear(ImGuiPayload* self);
		public static unsafe extern void ImGuiPayload();
		public static unsafe extern bool IsDataType(ImGuiPayload* self, const char* type);
		public static unsafe extern bool IsDelivery(ImGuiPayload* self);
		public static unsafe extern bool IsPreview(ImGuiPayload* self);
		public static unsafe extern void Unknown(ImGuiPayload* self);
		public static unsafe extern void ImGuiPlatformIO();
		public static unsafe extern void Unknown(ImGuiPlatformIO* self);
		public static unsafe extern void ImGuiPlatformImeData();
		public static unsafe extern void Unknown(ImGuiPlatformImeData* self);
		public static unsafe extern void ImGuiPlatformMonitor();
		public static unsafe extern void Unknown(ImGuiPlatformMonitor* self);
		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()<br/>
		/// </summary>
		public static unsafe extern void ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io);
		/// <summary>
		/// Clear selection<br/>
		/// </summary>
		public static unsafe extern void Clear(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Query if an item id is in selection.<br/>
		/// </summary>
		public static unsafe extern bool Contains(ImGuiSelectionBasicStorage* self, ImGuiID id);
		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
		/// </summary>
		public static unsafe extern bool GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, ImGuiID* out_id);
		/// <summary>
		/// Convert index to item id based on provided adapter.<br/>
		/// </summary>
		public static unsafe extern ImGuiID GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);
		public static unsafe extern void ImGuiSelectionBasicStorage();
		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)<br/>
		/// </summary>
		public static unsafe extern void SetItemSelected(ImGuiSelectionBasicStorage* self, ImGuiID id, bool selected);
		/// <summary>
		/// Swap two selections<br/>
		/// </summary>
		public static unsafe extern void Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);
		public static unsafe extern void Unknown(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		public static unsafe extern void ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io);
		public static unsafe extern void ImGuiSelectionExternalStorage();
		public static unsafe extern void Unknown(ImGuiSelectionExternalStorage* self);
		public static unsafe extern void ImGuiStoragePair(ImGuiID _key, int _val);
		public static unsafe extern void ImGuiStoragePair(ImGuiID _key, float _val);
		public static unsafe extern void ImGuiStoragePair(ImGuiID _key, void* _val);
		public static unsafe extern void Unknown(ImGuiStoragePair* self);
		public static unsafe extern void BuildSortByKey(ImGuiStorage* self);
		public static unsafe extern void Clear(ImGuiStorage* self);
		public static unsafe extern bool GetBool(ImGuiStorage* self, ImGuiID key, bool default_val);
		public static unsafe extern bool* GetBoolRef(ImGuiStorage* self, ImGuiID key, bool default_val);
		public static unsafe extern float GetFloat(ImGuiStorage* self, ImGuiID key, float default_val);
		public static unsafe extern float* GetFloatRef(ImGuiStorage* self, ImGuiID key, float default_val);
		public static unsafe extern int GetInt(ImGuiStorage* self, ImGuiID key, int default_val);
		public static unsafe extern int* GetIntRef(ImGuiStorage* self, ImGuiID key, int default_val);
		/// <summary>
		/// default_val is NULL<br/>
		/// </summary>
		public static unsafe extern void* GetVoidPtr(ImGuiStorage* self, ImGuiID key);
		public static unsafe extern void** GetVoidPtrRef(ImGuiStorage* self, ImGuiID key, void* default_val);
		public static unsafe extern void SetAllInt(ImGuiStorage* self, int val);
		public static unsafe extern void SetBool(ImGuiStorage* self, ImGuiID key, bool val);
		public static unsafe extern void SetFloat(ImGuiStorage* self, ImGuiID key, float val);
		public static unsafe extern void SetInt(ImGuiStorage* self, ImGuiID key, int val);
		public static unsafe extern void SetVoidPtr(ImGuiStorage* self, ImGuiID key, void* val);
		public static unsafe extern void ImGuiStyle();
		public static unsafe extern void ScaleAllSizes(ImGuiStyle* self, float scale_factor);
		public static unsafe extern void Unknown(ImGuiStyle* self);
		public static unsafe extern void ImGuiTableColumnSortSpecs();
		public static unsafe extern void Unknown(ImGuiTableColumnSortSpecs* self);
		public static unsafe extern void ImGuiTableSortSpecs();
		public static unsafe extern void Unknown(ImGuiTableSortSpecs* self);
		public static unsafe extern void ImGuiTextBuffer();
		public static unsafe extern void append(ImGuiTextBuffer* self, const char* str, const char* str_end);
		public static unsafe extern void appendf(ImGuiTextBuffer* self,  const char* fmt, ... ...);
		public static unsafe extern void appendfv(ImGuiTextBuffer* self, const char* fmt, va_list args);
		public static unsafe extern const char* begin(ImGuiTextBuffer* self);
		public static unsafe extern const char* c_str(ImGuiTextBuffer* self);
		public static unsafe extern void clear(ImGuiTextBuffer* self);
		public static unsafe extern void Unknown(ImGuiTextBuffer* self);
		public static unsafe extern bool empty(ImGuiTextBuffer* self);
		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public static unsafe extern const char* end(ImGuiTextBuffer* self);
		public static unsafe extern void reserve(ImGuiTextBuffer* self, int capacity);
		public static unsafe extern int size(ImGuiTextBuffer* self);
		public static unsafe extern void Build(ImGuiTextFilter* self);
		public static unsafe extern void Clear(ImGuiTextFilter* self);
		/// <summary>
		/// Helper calling InputText+Build<br/>
		/// </summary>
		public static unsafe extern bool Draw(ImGuiTextFilter* self, const char* label, float width);
		public static unsafe extern void ImGuiTextFilter(const char* default_filter);
		public static unsafe extern bool IsActive(ImGuiTextFilter* self);
		public static unsafe extern bool PassFilter(ImGuiTextFilter* self, const char* text, const char* text_end);
		public static unsafe extern void Unknown(ImGuiTextFilter* self);
		public static unsafe extern void ImGuiTextRange();
		public static unsafe extern void ImGuiTextRange(const char* _b, const char* _e);
		public static unsafe extern void Unknown(ImGuiTextRange* self);
		public static unsafe extern bool empty(ImGuiTextRange* self);
		public static unsafe extern void split(ImGuiTextRange* self, char separator, ImVector_ImGuiTextRange* out);
		public static unsafe extern void GetCenter(ImVec2* pOut, ImGuiViewport* self);
		public static unsafe extern void GetWorkCenter(ImVec2* pOut, ImGuiViewport* self);
		public static unsafe extern void ImGuiViewport();
		public static unsafe extern void Unknown(ImGuiViewport* self);
		public static unsafe extern void ImGuiWindowClass();
		public static unsafe extern void Unknown(ImGuiWindowClass* self);
		public static unsafe extern void ImVec2();
		public static unsafe extern void ImVec2(float _x, float _y);
		public static unsafe extern void Unknown(ImVec2* self);
		public static unsafe extern void ImVec4();
		public static unsafe extern void ImVec4(float _x, float _y, float _z, float _w);
		public static unsafe extern void Unknown(ImVec4* self);
		public static unsafe extern void ImVector();
		public static unsafe extern void ImVector(const ImVector_T  src);
		public static unsafe extern int _grow_capacity(ImVector* self, int sz);
		public static unsafe extern T* back(ImVector* self);
		public static unsafe extern const T* back(ImVector* self);
		public static unsafe extern T* begin(ImVector* self);
		public static unsafe extern const T* begin(ImVector* self);
		public static unsafe extern int capacity(ImVector* self);
		/// <summary>
		/// Important: does not destruct anything<br/>
		/// </summary>
		public static unsafe extern void clear(ImVector* self);
		/// <summary>
		/// Important: never called automatically! always explicit.<br/>
		/// </summary>
		public static unsafe extern void clear_delete(ImVector* self);
		/// <summary>
		/// Important: never called automatically! always explicit.<br/>
		/// </summary>
		public static unsafe extern void clear_destruct(ImVector* self);
		public static unsafe extern bool contains(ImVector* self, const T v);
		public static unsafe extern void Unknown(ImVector* self);
		public static unsafe extern bool empty(ImVector* self);
		public static unsafe extern T* end(ImVector* self);
		public static unsafe extern const T* end(ImVector* self);
		public static unsafe extern T* erase(ImVector* self, const T* it);
		public static unsafe extern T* erase(ImVector* self, const T* it, const T* it_last);
		public static unsafe extern T* erase_unsorted(ImVector* self, const T* it);
		public static unsafe extern T* find(ImVector* self, const T v);
		public static unsafe extern const T* find(ImVector* self, const T v);
		public static unsafe extern bool find_erase(ImVector* self, const T v);
		public static unsafe extern bool find_erase_unsorted(ImVector* self, const T v);
		public static unsafe extern int find_index(ImVector* self, const T v);
		public static unsafe extern T* front(ImVector* self);
		public static unsafe extern const T* front(ImVector* self);
		public static unsafe extern int index_from_ptr(ImVector* self, const T* it);
		public static unsafe extern T* insert(ImVector* self, const T* it, const T v);
		public static unsafe extern int max_size(ImVector* self);
		public static unsafe extern void pop_back(ImVector* self);
		public static unsafe extern void push_back(ImVector* self, const T v);
		public static unsafe extern void push_front(ImVector* self, const T v);
		public static unsafe extern void reserve(ImVector* self, int new_capacity);
		public static unsafe extern void reserve_discard(ImVector* self, int new_capacity);
		public static unsafe extern void resize(ImVector* self, int new_size);
		public static unsafe extern void resize(ImVector* self, int new_size, const T v);
		/// <summary>
		/// Resize a vector to a smaller size, guaranteed not to cause a reallocation<br/>
		/// </summary>
		public static unsafe extern void shrink(ImVector* self, int new_size);
		public static unsafe extern int size(ImVector* self);
		public static unsafe extern int size_in_bytes(ImVector* self);
		public static unsafe extern void swap(ImVector* self, ImVector_T * rhs);
		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static unsafe extern const ImGuiPayload* AcceptDragDropPayload(const char* type, ImGuiDragDropFlags flags);
		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		public static unsafe extern void AlignTextToFramePadding();
		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		public static unsafe extern bool ArrowButton(const char* str_id, ImGuiDir dir);
		public static unsafe extern bool Begin(const char* name, bool* p_open, ImGuiWindowFlags flags);
		public static unsafe extern bool BeginChild(const char* str_id, const ImVec2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		public static unsafe extern bool BeginChild(ImGuiID id, const ImVec2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		public static unsafe extern bool BeginCombo(const char* label, const char* preview_value, ImGuiComboFlags flags);
		public static unsafe extern void BeginDisabled(bool disabled);
		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		public static unsafe extern bool BeginDragDropSource(ImGuiDragDropFlags flags);
		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		public static unsafe extern bool BeginDragDropTarget();
		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		public static unsafe extern void BeginGroup();
		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		public static unsafe extern bool BeginItemTooltip();
		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static unsafe extern bool BeginListBox(const char* label, const ImVec2 size);
		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		public static unsafe extern bool BeginMainMenuBar();
		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static unsafe extern bool BeginMenu(const char* label, bool enabled);
		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		public static unsafe extern bool BeginMenuBar();
		public static unsafe extern ImGuiMultiSelectIO* BeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size, int items_count);
		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static unsafe extern bool BeginPopup(const char* str_id, ImGuiWindowFlags flags);
		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static unsafe extern bool BeginPopupContextItem(const char* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static unsafe extern bool BeginPopupContextVoid(const char* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static unsafe extern bool BeginPopupContextWindow(const char* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static unsafe extern bool BeginPopupModal(const char* name, bool* p_open, ImGuiWindowFlags flags);
		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static unsafe extern bool BeginTabBar(const char* str_id, ImGuiTabBarFlags flags);
		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static unsafe extern bool BeginTabItem(const char* label, bool* p_open, ImGuiTabItemFlags flags);
		public static unsafe extern bool BeginTable(const char* str_id, int columns, ImGuiTableFlags flags, const ImVec2 outer_size, float inner_width);
		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		public static unsafe extern bool BeginTooltip();
		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		public static unsafe extern void Bullet();
		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		public static unsafe extern void BulletText(const char* fmt, ... ...);
		public static unsafe extern void BulletTextV(const char* fmt, va_list args);
		/// <summary>
		/// button<br/>
		/// </summary>
		public static unsafe extern bool Button(const char* label, const ImVec2 size);
		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		public static unsafe extern float CalcItemWidth();
		public static unsafe extern void CalcTextSize(ImVec2* pOut, const char* text, const char* text_end, bool hide_text_after_double_hash, float wrap_width);
		public static unsafe extern bool Checkbox(const char* label, bool* v);
		public static unsafe extern bool CheckboxFlags(const char* label, int* flags, int flags_value);
		public static unsafe extern bool CheckboxFlags(const char* label, unsigned int* flags, unsigned int flags_value);
		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		public static unsafe extern void CloseCurrentPopup();
		/// <summary>
		/// if returning 'true' the header is open. doesn't indent nor push on ID stack. user doesn't have to call TreePop().<br/>
		/// </summary>
		public static unsafe extern bool CollapsingHeader(const char* label, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		public static unsafe extern bool CollapsingHeader(const char* label, bool* p_visible, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static unsafe extern bool ColorButton(const char* desc_id, const ImVec4 col, ImGuiColorEditFlags flags, const ImVec2 size);
		public static unsafe extern ImU32 ColorConvertFloat4ToU32(const ImVec4 in);
		public static unsafe extern void ColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
		public static unsafe extern void ColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
		public static unsafe extern void ColorConvertU32ToFloat4(ImVec4* pOut, ImU32 in);
		public static unsafe extern bool ColorEdit3(const char* label, float[3] col, ImGuiColorEditFlags flags);
		public static unsafe extern bool ColorEdit4(const char* label, float[4] col, ImGuiColorEditFlags flags);
		public static unsafe extern bool ColorPicker3(const char* label, float[3] col, ImGuiColorEditFlags flags);
		public static unsafe extern bool ColorPicker4(const char* label, float[4] col, ImGuiColorEditFlags flags, const float* ref_col);
		public static unsafe extern void Columns(int count, const char* id, bool borders);
		public static unsafe extern bool Combo(const char* label, int* current_item, const char* const[] items, int items_count, int popup_max_height_in_items);
		/// <summary>
		/// Separate items with \0 within a string, end item-list with \0\0. e.g. "One\0Two\0Three\0"<br/>
		/// </summary>
		public static unsafe extern bool Combo(const char* label, int* current_item, const char* items_separated_by_zeros, int popup_max_height_in_items);
		public static unsafe extern bool Combo(const char* label, int* current_item, const char*(*)(void* user_data,int idx) getter, void* user_data, int items_count, int popup_max_height_in_items);
		public static unsafe extern ImGuiContext* CreateContext(ImFontAtlas* shared_font_atlas);
		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		public static unsafe extern bool DebugCheckVersionAndDataLayout(const char* version_str, size_t sz_io, size_t sz_style, size_t sz_vec2, size_t sz_vec4, size_t sz_drawvert, size_t sz_drawidx);
		public static unsafe extern void DebugFlashStyleColor(ImGuiCol idx);
		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		public static unsafe extern void DebugLog(const char* fmt, ... ...);
		public static unsafe extern void DebugLogV(const char* fmt, va_list args);
		public static unsafe extern void DebugStartItemPicker();
		public static unsafe extern void DebugTextEncoding(const char* text);
		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		public static unsafe extern void DestroyContext(ImGuiContext* ctx);
		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		public static unsafe extern void DestroyPlatformWindows();
		public static unsafe extern ImGuiID DockSpace(ImGuiID dockspace_id, const ImVec2 size, ImGuiDockNodeFlags flags, const ImGuiWindowClass* window_class);
		public static unsafe extern ImGuiID DockSpaceOverViewport(ImGuiID dockspace_id, const ImGuiViewport* viewport, ImGuiDockNodeFlags flags, const ImGuiWindowClass* window_class);
		/// <summary>
		/// If v_min >= v_max we have no bound<br/>
		/// </summary>
		public static unsafe extern bool DragFloat(const char* label, float* v, float v_speed, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragFloat2(const char* label, float[2] v, float v_speed, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragFloat3(const char* label, float[3] v, float v_speed, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragFloat4(const char* label, float[4] v, float v_speed, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragFloatRange2(const char* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, const char* format, const char* format_max, ImGuiSliderFlags flags);
		/// <summary>
		/// If v_min >= v_max we have no bound<br/>
		/// </summary>
		public static unsafe extern bool DragInt(const char* label, int* v, float v_speed, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragInt2(const char* label, int[2] v, float v_speed, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragInt3(const char* label, int[3] v, float v_speed, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragInt4(const char* label, int[4] v, float v_speed, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragIntRange2(const char* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, const char* format, const char* format_max, ImGuiSliderFlags flags);
		public static unsafe extern bool DragScalar(const char* label, ImGuiDataType data_type, void* p_data, float v_speed, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool DragScalarN(const char* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags);
		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		public static unsafe extern void Dummy(const ImVec2 size);
		public static unsafe extern void End();
		public static unsafe extern void EndChild();
		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndCombo();
		public static unsafe extern void EndDisabled();
		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndDragDropSource();
		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndDragDropTarget();
		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		public static unsafe extern void EndFrame();
		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		public static unsafe extern void EndGroup();
		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		public static unsafe extern void EndListBox();
		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndMainMenuBar();
		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndMenu();
		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndMenuBar();
		public static unsafe extern ImGuiMultiSelectIO* EndMultiSelect();
		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndPopup();
		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndTabBar();
		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndTabItem();
		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndTable();
		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		public static unsafe extern void EndTooltip();
		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		public static unsafe extern ImGuiViewport* FindViewportByID(ImGuiID id);
		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		public static unsafe extern ImGuiViewport* FindViewportByPlatformHandle(void* platform_handle);
		public static unsafe extern void GetAllocatorFunctions(ImGuiMemAllocFunc* p_alloc_func, ImGuiMemFreeFunc* p_free_func, void** p_user_data);
		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		public static unsafe extern ImDrawList* GetBackgroundDrawList(ImGuiViewport* viewport);
		public static unsafe extern const char* GetClipboardText();
		/// <summary>
		/// retrieve given style color with style alpha applied and optional extra alpha multiplier, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static unsafe extern ImU32 GetColorU32(ImGuiCol idx, float alpha_mul);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static unsafe extern ImU32 GetColorU32(const ImVec4 col);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static unsafe extern ImU32 GetColorU32(ImU32 col, float alpha_mul);
		/// <summary>
		/// get current column index<br/>
		/// </summary>
		public static unsafe extern int GetColumnIndex();
		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		public static unsafe extern float GetColumnOffset(int column_index);
		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static unsafe extern float GetColumnWidth(int column_index);
		public static unsafe extern int GetColumnsCount();
		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static unsafe extern void GetContentRegionAvail(ImVec2* pOut);
		public static unsafe extern ImGuiContext* GetCurrentContext();
		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		public static unsafe extern void GetCursorPos(ImVec2* pOut);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static unsafe extern float GetCursorPosX();
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static unsafe extern float GetCursorPosY();
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		public static unsafe extern void GetCursorScreenPos(ImVec2* pOut);
		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		public static unsafe extern void GetCursorStartPos(ImVec2* pOut);
		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		public static unsafe extern const ImGuiPayload* GetDragDropPayload();
		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		public static unsafe extern ImDrawData* GetDrawData();
		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		public static unsafe extern ImDrawListSharedData* GetDrawListSharedData();
		/// <summary>
		/// get current font<br/>
		/// </summary>
		public static unsafe extern ImFont* GetFont();
		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		public static unsafe extern float GetFontSize();
		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		public static unsafe extern void GetFontTexUvWhitePixel(ImVec2* pOut);
		/// <summary>
		/// get foreground draw list for the given viewport or viewport associated to the current window. this draw list will be the top-most rendered one. Useful to quickly draw shapes/text over dear imgui contents.<br/>
		/// </summary>
		public static unsafe extern ImDrawList* GetForegroundDrawList(ImGuiViewport* viewport);
		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		public static unsafe extern int GetFrameCount();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		public static unsafe extern float GetFrameHeight();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		public static unsafe extern float GetFrameHeightWithSpacing();
		/// <summary>
		/// calculate unique ID (hash of whole ID stack + given parameter). e.g. if you want to query into ImGuiStorage yourself<br/>
		/// </summary>
		public static unsafe extern ImGuiID GetID(const char* str_id);
		public static unsafe extern ImGuiID GetID(const char* str_id_begin, const char* str_id_end);
		public static unsafe extern ImGuiID GetID(const void* ptr_id);
		public static unsafe extern ImGuiID GetID(int int_id);
		/// <summary>
		/// access the ImGuiIO structure (mouse/keyboard/gamepad inputs, time, various configuration options/flags)<br/>
		/// </summary>
		public static unsafe extern ImGuiIO* GetIO();
		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		public static unsafe extern ImGuiID GetItemID();
		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static unsafe extern void GetItemRectMax(ImVec2* pOut);
		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static unsafe extern void GetItemRectMin(ImVec2* pOut);
		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		public static unsafe extern void GetItemRectSize(ImVec2* pOut);
		/// <summary>
		/// [DEBUG] returns English name of the key. Those names a provided for debugging purpose and are not meant to be saved persistently not compared.<br/>
		/// </summary>
		public static unsafe extern const char* GetKeyName(ImGuiKey key);
		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be >1 if RepeatRate is small enough that DeltaTime > RepeatRate<br/>
		/// </summary>
		public static unsafe extern int GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);
		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		public static unsafe extern ImGuiViewport* GetMainViewport();
		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		public static unsafe extern int GetMouseClickedCount(ImGuiMouseButton button);
		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		public static unsafe extern ImGuiMouseCursor GetMouseCursor();
		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold < 0.0f)<br/>
		/// </summary>
		public static unsafe extern void GetMouseDragDelta(ImVec2* pOut, ImGuiMouseButton button, float lock_threshold);
		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		public static unsafe extern void GetMousePos(ImVec2* pOut);
		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		public static unsafe extern void GetMousePosOnOpeningCurrentPopup(ImVec2* pOut);
		/// <summary>
		/// access the ImGuiPlatformIO structure (mostly hooks/functions to connect to platform/renderer and OS Clipboard, IME etc.)<br/>
		/// </summary>
		public static unsafe extern ImGuiPlatformIO* GetPlatformIO();
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		public static unsafe extern float GetScrollMaxX();
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		public static unsafe extern float GetScrollMaxY();
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		public static unsafe extern float GetScrollX();
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		public static unsafe extern float GetScrollY();
		public static unsafe extern ImGuiStorage* GetStateStorage();
		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		public static unsafe extern ImGuiStyle* GetStyle();
		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		public static unsafe extern const char* GetStyleColorName(ImGuiCol idx);
		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		public static unsafe extern const ImVec4* GetStyleColorVec4(ImGuiCol idx);
		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		public static unsafe extern float GetTextLineHeight();
		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		public static unsafe extern float GetTextLineHeightWithSpacing();
		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		public static unsafe extern double GetTime();
		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		public static unsafe extern float GetTreeNodeToLabelSpacing();
		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		public static unsafe extern const char* GetVersion();
		public static unsafe extern ImGuiID GetWindowDockID();
		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		public static unsafe extern float GetWindowDpiScale();
		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		public static unsafe extern ImDrawList* GetWindowDrawList();
		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		public static unsafe extern float GetWindowHeight();
		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static unsafe extern void GetWindowPos(ImVec2* pOut);
		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static unsafe extern void GetWindowSize(ImVec2* pOut);
		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		public static unsafe extern ImGuiViewport* GetWindowViewport();
		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		public static unsafe extern float GetWindowWidth();
		public static unsafe extern void Image(ImTextureID user_texture_id, const ImVec2 image_size, const ImVec2 uv0, const ImVec2 uv1, const ImVec4 tint_col, const ImVec4 border_col);
		public static unsafe extern bool ImageButton(const char* str_id, ImTextureID user_texture_id, const ImVec2 image_size, const ImVec2 uv0, const ImVec2 uv1, const ImVec4 bg_col, const ImVec4 tint_col);
		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w <= 0<br/>
		/// </summary>
		public static unsafe extern void Indent(float indent_w);
		public static unsafe extern bool InputDouble(const char* label, double* v, double step, double step_fast, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputFloat(const char* label, float* v, float step, float step_fast, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputFloat2(const char* label, float[2] v, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputFloat3(const char* label, float[3] v, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputFloat4(const char* label, float[4] v, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputInt(const char* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputInt2(const char* label, int[2] v, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputInt3(const char* label, int[3] v, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputInt4(const char* label, int[4] v, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputScalar(const char* label, ImGuiDataType data_type, void* p_data, const void* p_step, const void* p_step_fast, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputScalarN(const char* label, ImGuiDataType data_type, void* p_data, int components, const void* p_step, const void* p_step_fast, const char* format, ImGuiInputTextFlags flags);
		public static unsafe extern bool InputText(const char* label, char* buf, size_t buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		public static unsafe extern bool InputTextMultiline(const char* label, char* buf, size_t buf_size, const ImVec2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		public static unsafe extern bool InputTextWithHint(const char* label, const char* hint, char* buf, size_t buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static unsafe extern bool InvisibleButton(const char* str_id, const ImVec2 size, ImGuiButtonFlags flags);
		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		public static unsafe extern bool IsAnyItemActive();
		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		public static unsafe extern bool IsAnyItemFocused();
		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		public static unsafe extern bool IsAnyItemHovered();
		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		public static unsafe extern bool IsAnyMouseDown();
		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		public static unsafe extern bool IsItemActivated();
		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		public static unsafe extern bool IsItemActive();
		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		public static unsafe extern bool IsItemClicked(ImGuiMouseButton mouse_button);
		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		public static unsafe extern bool IsItemDeactivated();
		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		public static unsafe extern bool IsItemDeactivatedAfterEdit();
		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		public static unsafe extern bool IsItemEdited();
		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		public static unsafe extern bool IsItemFocused();
		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		public static unsafe extern bool IsItemHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		public static unsafe extern bool IsItemToggledOpen();
		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		public static unsafe extern bool IsItemToggledSelection();
		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		public static unsafe extern bool IsItemVisible();
		/// <summary>
		/// was key chord (mods + key) pressed, e.g. you can pass 'ImGuiMod_Ctrl | ImGuiKey_S' as a key-chord. This doesn't do any routing or focus check, please consider using Shortcut() function instead.<br/>
		/// </summary>
		public static unsafe extern bool IsKeyChordPressed(ImGuiKeyChord key_chord);
		/// <summary>
		/// is key being held.<br/>
		/// </summary>
		public static unsafe extern bool IsKeyDown(ImGuiKey key);
		/// <summary>
		/// was key pressed (went from !Down to Down)? if repeat=true, uses io.KeyRepeatDelay / KeyRepeatRate<br/>
		/// </summary>
		public static unsafe extern bool IsKeyPressed(ImGuiKey key, bool repeat);
		/// <summary>
		/// was key released (went from Down to !Down)?<br/>
		/// </summary>
		public static unsafe extern bool IsKeyReleased(ImGuiKey key);
		/// <summary>
		/// did mouse button clicked? (went from !Down to Down). Same as GetMouseClickedCount() == 1.<br/>
		/// </summary>
		public static unsafe extern bool IsMouseClicked(ImGuiMouseButton button, bool repeat);
		/// <summary>
		/// did mouse button double-clicked? Same as GetMouseClickedCount() == 2. (note that a double-click will also report IsMouseClicked() == true)<br/>
		/// </summary>
		public static unsafe extern bool IsMouseDoubleClicked(ImGuiMouseButton button);
		/// <summary>
		/// is mouse button held?<br/>
		/// </summary>
		public static unsafe extern bool IsMouseDown(ImGuiMouseButton button);
		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold < 0.0f)<br/>
		/// </summary>
		public static unsafe extern bool IsMouseDragging(ImGuiMouseButton button, float lock_threshold);
		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		public static unsafe extern bool IsMouseHoveringRect(const ImVec2 r_min, const ImVec2 r_max, bool clip);
		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		public static unsafe extern bool IsMousePosValid(const ImVec2* mouse_pos);
		/// <summary>
		/// did mouse button released? (went from Down to !Down)<br/>
		/// </summary>
		public static unsafe extern bool IsMouseReleased(ImGuiMouseButton button);
		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay >= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		public static unsafe extern bool IsMouseReleasedWithDelay(ImGuiMouseButton button, float delay);
		/// <summary>
		/// return true if the popup is open.<br/>
		/// </summary>
		public static unsafe extern bool IsPopupOpen(const char* str_id, ImGuiPopupFlags flags);
		/// <summary>
		/// test if rectangle (of given size, starting from cursor position) is visible / not clipped.<br/>
		/// </summary>
		public static unsafe extern bool IsRectVisible(const ImVec2 size);
		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		public static unsafe extern bool IsRectVisible(const ImVec2 rect_min, const ImVec2 rect_max);
		public static unsafe extern bool IsWindowAppearing();
		public static unsafe extern bool IsWindowCollapsed();
		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		public static unsafe extern bool IsWindowDocked();
		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		public static unsafe extern bool IsWindowFocused(ImGuiFocusedFlags flags);
		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		public static unsafe extern bool IsWindowHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		public static unsafe extern void LabelText(const char* label, const char* fmt, ... ...);
		public static unsafe extern void LabelTextV(const char* label, const char* fmt, va_list args);
		public static unsafe extern bool ListBox(const char* label, int* current_item, const char* const[] items, int items_count, int height_in_items);
		public static unsafe extern bool ListBox(const char* label, int* current_item, const char*(*)(void* user_data,int idx) getter, void* user_data, int items_count, int height_in_items);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		public static unsafe extern void LoadIniSettingsFromDisk(const char* ini_filename);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static unsafe extern void LoadIniSettingsFromMemory(const char* ini_data, size_t ini_size);
		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		public static unsafe extern void LogButtons();
		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		public static unsafe extern void LogFinish();
		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static unsafe extern void LogText(const char* fmt, ... ...);
		public static unsafe extern void LogTextV(const char* fmt, va_list args);
		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		public static unsafe extern void LogToClipboard(int auto_open_depth);
		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static unsafe extern void LogToFile(int auto_open_depth, const char* filename);
		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		public static unsafe extern void LogToTTY(int auto_open_depth);
		public static unsafe extern void* MemAlloc(size_t size);
		public static unsafe extern void MemFree(void* ptr);
		/// <summary>
		/// return true when activated.<br/>
		/// </summary>
		public static unsafe extern bool MenuItem(const char* label, const char* shortcut, bool selected, bool enabled);
		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		public static unsafe extern bool MenuItem(const char* label, const char* shortcut, bool* p_selected, bool enabled);
		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		public static unsafe extern void NewFrame();
		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		public static unsafe extern void NewLine();
		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		public static unsafe extern void NextColumn();
		/// <summary>
		/// call to mark popup as open (don't call every frame!).<br/>
		/// </summary>
		public static unsafe extern void OpenPopup(const char* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		public static unsafe extern void OpenPopup(ImGuiID id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static unsafe extern void OpenPopupOnItemClick(const char* str_id, ImGuiPopupFlags popup_flags);
		public static unsafe extern void PlotHistogram(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);
		public static unsafe extern void PlotHistogram(const char* label, float(*)(void* data,int idx) values_getter, void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size);
		public static unsafe extern void PlotLines(const char* label, const float* values, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size, int stride);
		public static unsafe extern void PlotLines(const char* label, float(*)(void* data,int idx) values_getter, void* data, int values_count, int values_offset, const char* overlay_text, float scale_min, float scale_max, ImVec2 graph_size);
		public static unsafe extern void PopClipRect();
		public static unsafe extern void PopFont();
		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		public static unsafe extern void PopID();
		public static unsafe extern void PopItemFlag();
		public static unsafe extern void PopItemWidth();
		public static unsafe extern void PopStyleColor(int count);
		public static unsafe extern void PopStyleVar(int count);
		public static unsafe extern void PopTextWrapPos();
		public static unsafe extern void ProgressBar(float fraction, const ImVec2 size_arg, const char* overlay);
		public static unsafe extern void PushClipRect(const ImVec2 clip_rect_min, const ImVec2 clip_rect_max, bool intersect_with_current_clip_rect);
		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		public static unsafe extern void PushFont(ImFont* font);
		/// <summary>
		/// push string into the ID stack (will hash string).<br/>
		/// </summary>
		public static unsafe extern void PushID(const char* str_id);
		/// <summary>
		/// push string into the ID stack (will hash string).<br/>
		/// </summary>
		public static unsafe extern void PushID(const char* str_id_begin, const char* str_id_end);
		/// <summary>
		/// push pointer into the ID stack (will hash pointer).<br/>
		/// </summary>
		public static unsafe extern void PushID(const void* ptr_id);
		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		public static unsafe extern void PushID(int int_id);
		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		public static unsafe extern void PushItemFlag(ImGuiItemFlags option, bool enabled);
		/// <summary>
		/// push width of items for common large "item+label" widgets. >0.0f: width in pixels, <0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		public static unsafe extern void PushItemWidth(float item_width);
		/// <summary>
		/// modify a style color. always use this if you modify the style after NewFrame().<br/>
		/// </summary>
		public static unsafe extern void PushStyleColor(ImGuiCol idx, ImU32 col);
		public static unsafe extern void PushStyleColor(ImGuiCol idx, const ImVec4 col);
		/// <summary>
		/// modify a style float variable. always use this if you modify the style after NewFrame()!<br/>
		/// </summary>
		public static unsafe extern void PushStyleVar(ImGuiStyleVar idx, float val);
		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		public static unsafe extern void PushStyleVar(ImGuiStyleVar idx, const ImVec2 val);
		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static unsafe extern void PushStyleVarX(ImGuiStyleVar idx, float val_x);
		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static unsafe extern void PushStyleVarY(ImGuiStyleVar idx, float val_y);
		/// <summary>
		/// push word-wrapping position for Text*() commands. < 0.0f: no wrapping; 0.0f: wrap to end of window (or column); > 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		public static unsafe extern void PushTextWrapPos(float wrap_local_pos_x);
		/// <summary>
		/// use with e.g. if (RadioButton("one", my_value==1))  my_value = 1; <br/>
		/// </summary>
		public static unsafe extern bool RadioButton(const char* label, bool active);
		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		public static unsafe extern bool RadioButton(const char* label, int* v, int v_button);
		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		public static unsafe extern void Render();
		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		public static unsafe extern void RenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
		/// <summary>
		/// //<br/>
		/// </summary>
		public static unsafe extern void ResetMouseDragDelta(ImGuiMouseButton button);
		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		public static unsafe extern void SameLine(float offset_from_start_x, float spacing);
		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		public static unsafe extern void SaveIniSettingsToDisk(const char* ini_filename);
		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		public static unsafe extern const char* SaveIniSettingsToMemory(size_t* out_ini_size);
		/// <summary>
		/// "bool selected" carry the selection state (read-only). Selectable() is clicked is returns true so you can modify your selection state. size.x==0.0: use remaining width, size.x>0.0: specify width. size.y==0.0: use label height, size.y>0.0: specify height<br/>
		/// </summary>
		public static unsafe extern bool Selectable(const char* label, bool selected, ImGuiSelectableFlags flags, const ImVec2 size);
		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		public static unsafe extern bool Selectable(const char* label, bool* p_selected, ImGuiSelectableFlags flags, const ImVec2 size);
		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		public static unsafe extern void Separator();
		/// <summary>
		/// currently: formatted text with an horizontal line<br/>
		/// </summary>
		public static unsafe extern void SeparatorText(const char* label);
		public static unsafe extern void SetAllocatorFunctions(ImGuiMemAllocFunc alloc_func, ImGuiMemFreeFunc free_func, void* user_data);
		public static unsafe extern void SetClipboardText(const char* text);
		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		public static unsafe extern void SetColorEditOptions(ImGuiColorEditFlags flags);
		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		public static unsafe extern void SetColumnOffset(int column_index, float offset_x);
		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static unsafe extern void SetColumnWidth(int column_index, float width);
		public static unsafe extern void SetCurrentContext(ImGuiContext* ctx);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static unsafe extern void SetCursorPos(const ImVec2 local_pos);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static unsafe extern void SetCursorPosX(float local_x);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static unsafe extern void SetCursorPosY(float local_y);
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static unsafe extern void SetCursorScreenPos(const ImVec2 pos);
		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static unsafe extern bool SetDragDropPayload(const char* type, const void* data, size_t sz, ImGuiCond cond);
		/// <summary>
		/// make last item the default focused item of of a newly appearing window.<br/>
		/// </summary>
		public static unsafe extern void SetItemDefaultFocus();
		/// <summary>
		/// Set key owner to last item ID if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		public static unsafe extern void SetItemKeyOwner(ImGuiKey key);
		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		public static unsafe extern void SetItemTooltip(const char* fmt, ... ...);
		public static unsafe extern void SetItemTooltipV(const char* fmt, va_list args);
		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		public static unsafe extern void SetKeyboardFocusHere(int offset);
		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		public static unsafe extern void SetMouseCursor(ImGuiMouseCursor cursor_type);
		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		public static unsafe extern void SetNavCursorVisible(bool visible);
		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		public static unsafe extern void SetNextFrameWantCaptureKeyboard(bool want_capture_keyboard);
		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		public static unsafe extern void SetNextFrameWantCaptureMouse(bool want_capture_mouse);
		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		public static unsafe extern void SetNextItemAllowOverlap();
		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		public static unsafe extern void SetNextItemOpen(bool is_open, ImGuiCond cond);
		public static unsafe extern void SetNextItemSelectionUserData(ImGuiSelectionUserData selection_user_data);
		public static unsafe extern void SetNextItemShortcut(ImGuiKeyChord key_chord, ImGuiInputFlags flags);
		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		public static unsafe extern void SetNextItemStorageID(ImGuiID storage_id);
		/// <summary>
		/// set width of the _next_ common large "item+label" widget. >0.0f: width in pixels, <0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		public static unsafe extern void SetNextItemWidth(float item_width);
		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowBgAlpha(float alpha);
		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowClass(const ImGuiWindowClass* window_class);
		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond);
		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowContentSize(const ImVec2 size);
		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowDockID(ImGuiID dock_id, ImGuiCond cond);
		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowFocus();
		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowPos(const ImVec2 pos, ImGuiCond cond, const ImVec2 pivot);
		/// <summary>
		/// set next window scrolling value (use < 0.0f to not affect a given axis).<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowScroll(const ImVec2 scroll);
		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowSize(const ImVec2 size, ImGuiCond cond);
		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowSizeConstraints(const ImVec2 size_min, const ImVec2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		public static unsafe extern void SetNextWindowViewport(ImGuiID viewport_id);
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.<br/>
		/// </summary>
		public static unsafe extern void SetScrollFromPosX(float local_x, float center_x_ratio);
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.<br/>
		/// </summary>
		public static unsafe extern void SetScrollFromPosY(float local_y, float center_y_ratio);
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static unsafe extern void SetScrollHereX(float center_x_ratio);
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static unsafe extern void SetScrollHereY(float center_y_ratio);
		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		public static unsafe extern void SetScrollX(float scroll_x);
		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		public static unsafe extern void SetScrollY(float scroll_y);
		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		public static unsafe extern void SetStateStorage(ImGuiStorage* storage);
		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		public static unsafe extern void SetTabItemClosed(const char* tab_or_docked_window_label);
		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		public static unsafe extern void SetTooltip(const char* fmt, ... ...);
		public static unsafe extern void SetTooltipV(const char* fmt, va_list args);
		/// <summary>
		/// (not recommended) set current window collapsed state. prefer using SetNextWindowCollapsed().<br/>
		/// </summary>
		public static unsafe extern void SetWindowCollapsed(bool collapsed, ImGuiCond cond);
		/// <summary>
		/// set named window collapsed state<br/>
		/// </summary>
		public static unsafe extern void SetWindowCollapsed(const char* name, bool collapsed, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window to be focused / top-most. prefer using SetNextWindowFocus().<br/>
		/// </summary>
		public static unsafe extern void SetWindowFocus();
		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		public static unsafe extern void SetWindowFocus(const char* name);
		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		public static unsafe extern void SetWindowFontScale(float scale);
		/// <summary>
		/// (not recommended) set current window position - call within Begin()/End(). prefer using SetNextWindowPos(), as this may incur tearing and side-effects.<br/>
		/// </summary>
		public static unsafe extern void SetWindowPos(const ImVec2 pos, ImGuiCond cond);
		/// <summary>
		/// set named window position.<br/>
		/// </summary>
		public static unsafe extern void SetWindowPos(const char* name, const ImVec2 pos, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window size - call within Begin()/End(). set to ImVec2(0, 0) to force an auto-fit. prefer using SetNextWindowSize(), as this may incur tearing and minor side-effects.<br/>
		/// </summary>
		public static unsafe extern void SetWindowSize(const ImVec2 size, ImGuiCond cond);
		/// <summary>
		/// set named window size. set axis to 0.0f to force an auto-fit on this axis.<br/>
		/// </summary>
		public static unsafe extern void SetWindowSize(const char* name, const ImVec2 size, ImGuiCond cond);
		public static unsafe extern bool Shortcut(ImGuiKeyChord key_chord, ImGuiInputFlags flags);
		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		public static unsafe extern void ShowAboutWindow(bool* p_open);
		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		public static unsafe extern void ShowDebugLogWindow(bool* p_open);
		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		public static unsafe extern void ShowDemoWindow(bool* p_open);
		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		public static unsafe extern void ShowFontSelector(const char* label);
		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		public static unsafe extern void ShowIDStackToolWindow(bool* p_open);
		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		public static unsafe extern void ShowMetricsWindow(bool* p_open);
		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		public static unsafe extern void ShowStyleEditor(ImGuiStyle* ref);
		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		public static unsafe extern bool ShowStyleSelector(const char* label);
		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		public static unsafe extern void ShowUserGuide();
		public static unsafe extern bool SliderAngle(const char* label, float* v_rad, float v_degrees_min, float v_degrees_max, const char* format, ImGuiSliderFlags flags);
		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static unsafe extern bool SliderFloat(const char* label, float* v, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderFloat2(const char* label, float[2] v, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderFloat3(const char* label, float[3] v, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderFloat4(const char* label, float[4] v, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderInt(const char* label, int* v, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderInt2(const char* label, int[2] v, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderInt3(const char* label, int[3] v, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderInt4(const char* label, int[4] v, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderScalar(const char* label, ImGuiDataType data_type, void* p_data, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool SliderScalarN(const char* label, ImGuiDataType data_type, void* p_data, int components, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags);
		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		public static unsafe extern bool SmallButton(const char* label);
		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		public static unsafe extern void Spacing();
		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		public static unsafe extern void StyleColorsClassic(ImGuiStyle* dst);
		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		public static unsafe extern void StyleColorsDark(ImGuiStyle* dst);
		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		public static unsafe extern void StyleColorsLight(ImGuiStyle* dst);
		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static unsafe extern bool TabItemButton(const char* label, ImGuiTabItemFlags flags);
		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		public static unsafe extern void TableAngledHeadersRow();
		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		public static unsafe extern int TableGetColumnCount();
		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		public static unsafe extern ImGuiTableColumnFlags TableGetColumnFlags(int column_n);
		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		public static unsafe extern int TableGetColumnIndex();
		/// <summary>
		/// return "" if column didn't have a name declared by TableSetupColumn(). Pass -1 to use current column.<br/>
		/// </summary>
		public static unsafe extern const char* TableGetColumnName(int column_n);
		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		public static unsafe extern int TableGetHoveredColumn();
		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		public static unsafe extern int TableGetRowIndex();
		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		public static unsafe extern ImGuiTableSortSpecs* TableGetSortSpecs();
		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		public static unsafe extern void TableHeader(const char* label);
		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		public static unsafe extern void TableHeadersRow();
		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		public static unsafe extern bool TableNextColumn();
		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		public static unsafe extern void TableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		public static unsafe extern void TableSetBgColor(ImGuiTableBgTarget target, ImU32 color, int column_n);
		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		public static unsafe extern void TableSetColumnEnabled(int column_n, bool v);
		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		public static unsafe extern bool TableSetColumnIndex(int column_n);
		public static unsafe extern void TableSetupColumn(const char* label, ImGuiTableColumnFlags flags, float init_width_or_weight, ImGuiID user_id);
		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		public static unsafe extern void TableSetupScrollFreeze(int cols, int rows);
		/// <summary>
		/// formatted text<br/>
		/// </summary>
		public static unsafe extern void Text(const char* fmt, ... ...);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static unsafe extern void TextColored(const ImVec4 col, const char* fmt, ... ...);
		public static unsafe extern void TextColoredV(const ImVec4 col, const char* fmt, va_list args);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static unsafe extern void TextDisabled(const char* fmt, ... ...);
		public static unsafe extern void TextDisabledV(const char* fmt, va_list args);
		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		public static unsafe extern bool TextLink(const char* label);
		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static unsafe extern void TextLinkOpenURL(const char* label, const char* url);
		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static unsafe extern void TextUnformatted(const char* text, const char* text_end);
		public static unsafe extern void TextV(const char* fmt, va_list args);
		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		public static unsafe extern void TextWrapped(const char* fmt, ... ...);
		public static unsafe extern void TextWrappedV(const char* fmt, va_list args);
		public static unsafe extern bool TreeNode(const char* label);
		/// <summary>
		/// helper variation to easily decorelate the id from the displayed string. Read the FAQ about why and how to use ID. to align arbitrary text at the same level as a TreeNode() you can use Bullet().<br/>
		/// </summary>
		public static unsafe extern bool TreeNode(const char* str_id, const char* fmt, ... ...);
		/// <summary>
		/// "<br/>
		/// </summary>
		public static unsafe extern bool TreeNode(const void* ptr_id, const char* fmt, ... ...);
		public static unsafe extern bool TreeNodeEx(const char* label, ImGuiTreeNodeFlags flags);
		public static unsafe extern bool TreeNodeEx(const char* str_id, ImGuiTreeNodeFlags flags, const char* fmt, ... ...);
		public static unsafe extern bool TreeNodeEx(const void* ptr_id, ImGuiTreeNodeFlags flags, const char* fmt, ... ...);
		public static unsafe extern bool TreeNodeExV(const char* str_id, ImGuiTreeNodeFlags flags, const char* fmt, va_list args);
		public static unsafe extern bool TreeNodeExV(const void* ptr_id, ImGuiTreeNodeFlags flags, const char* fmt, va_list args);
		public static unsafe extern bool TreeNodeV(const char* str_id, const char* fmt, va_list args);
		public static unsafe extern bool TreeNodeV(const void* ptr_id, const char* fmt, va_list args);
		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		public static unsafe extern void TreePop();
		/// <summary>
		/// ~ Indent()+PushID(). Already called by TreeNode() when returning true, but you can call TreePush/TreePop yourself if desired.<br/>
		/// </summary>
		public static unsafe extern void TreePush(const char* str_id);
		/// <summary>
		/// "<br/>
		/// </summary>
		public static unsafe extern void TreePush(const void* ptr_id);
		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w <= 0<br/>
		/// </summary>
		public static unsafe extern void Unindent(float indent_w);
		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		public static unsafe extern void UpdatePlatformWindows();
		public static unsafe extern bool VSliderFloat(const char* label, const ImVec2 size, float* v, float v_min, float v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool VSliderInt(const char* label, const ImVec2 size, int* v, int v_min, int v_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern bool VSliderScalar(const char* label, const ImVec2 size, ImGuiDataType data_type, void* p_data, const void* p_min, const void* p_max, const char* format, ImGuiSliderFlags flags);
		public static unsafe extern void Value(const char* prefix, bool b);
		public static unsafe extern void Value(const char* prefix, int v);
		public static unsafe extern void Value(const char* prefix, unsigned int v);
		public static unsafe extern void Value(const char* prefix, float v, const char* float_format);
	}
}

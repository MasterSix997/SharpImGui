using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	public static class ImGuiNative
	{
		public static extern unsafe void ImBitVector_Clear(ImBitVector* self);
		public static extern unsafe void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
		public static extern unsafe void ImColor_ImColor();
		public static extern unsafe void ImColor_ImColor(float r, float g, float b, float a);
		public static extern unsafe void ImColor_ImColor(Vector4 col);
		public static extern unsafe void ImColor_ImColor(int r, int g, int b, int a);
		public static extern unsafe void ImColor_ImColor(uint rgba);
		public static extern unsafe void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
		public static extern unsafe void ImColor_destroy(ImColor* self);
		public static extern unsafe IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self);
		/// <summary>
		/// Also ensure our padding fields are zeroed<br/>
		/// </summary>
		public static extern unsafe void ImDrawCmd_ImDrawCmd();
		public static extern unsafe void ImDrawCmd_destroy(ImDrawCmd* self);
		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.<br/>
		/// </summary>
		public static extern unsafe void ImDrawData_AddDrawList(ImDrawData* self, ImDrawList* draw_list);
		public static extern unsafe void ImDrawData_Clear(ImDrawData* self);
		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!<br/>
		/// </summary>
		public static extern unsafe void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
		public static extern unsafe void ImDrawData_ImDrawData();
		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.<br/>
		/// </summary>
		public static extern unsafe void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
		public static extern unsafe void ImDrawData_destroy(ImDrawData* self);
		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame<br/>
		/// </summary>
		public static extern unsafe void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
		public static extern unsafe void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
		public static extern unsafe void ImDrawListSplitter_ImDrawListSplitter();
		public static extern unsafe void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
		public static extern unsafe void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
		public static extern unsafe void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
		public static extern unsafe void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
		public static extern unsafe void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* userdata, uint userdata_size);
		public static extern unsafe void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
		public static extern unsafe void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
		public static extern unsafe void ImDrawList_AddConcavePolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
		public static extern unsafe void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_AddDrawCmd(ImDrawList* self);
		public static extern unsafe void ImDrawList_AddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments, float thickness);
		public static extern unsafe void ImDrawList_AddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments);
		public static extern unsafe void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
		public static extern unsafe void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
		public static extern unsafe void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);
		public static extern unsafe void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
		public static extern unsafe void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
		public static extern unsafe void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
		public static extern unsafe void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);
		public static extern unsafe void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
		public static extern unsafe void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);
		public static extern unsafe void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
		public static extern unsafe void ImDrawList_AddText(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
		public static extern unsafe void ImDrawList_AddText(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
		public static extern unsafe void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
		public static extern unsafe void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
		public static extern unsafe void ImDrawList_ChannelsMerge(ImDrawList* self);
		public static extern unsafe void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
		public static extern unsafe void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.<br/>
		/// </summary>
		public static extern unsafe ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
		public static extern unsafe void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
		public static extern unsafe void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
		public static extern unsafe void ImDrawList_ImDrawList(ImDrawListSharedData* shared_data);
		public static extern unsafe void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
		/// <summary>
		/// Use precomputed angles for a 12 steps circle<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
		public static extern unsafe void ImDrawList_PathClear(ImDrawList* self);
		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float a_min, float a_max, int num_segments);
		public static extern unsafe void ImDrawList_PathFillConcave(ImDrawList* self, uint col);
		public static extern unsafe void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
		public static extern unsafe void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
		public static extern unsafe void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
		public static extern unsafe void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);
		public static extern unsafe void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
		public static extern unsafe void ImDrawList_PopClipRect(ImDrawList* self);
		public static extern unsafe void ImDrawList_PopTextureID(ImDrawList* self);
		public static extern unsafe void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
		public static extern unsafe void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
		public static extern unsafe void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
		public static extern unsafe void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
		/// <summary>
		/// Write vertex with unique index<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
		public static extern unsafe void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
		public static extern unsafe void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		public static extern unsafe void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
		public static extern unsafe void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
		public static extern unsafe void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
		public static extern unsafe int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
		public static extern unsafe void ImDrawList__ClearFreeMemory(ImDrawList* self);
		public static extern unsafe void ImDrawList__OnChangedClipRect(ImDrawList* self);
		public static extern unsafe void ImDrawList__OnChangedTextureID(ImDrawList* self);
		public static extern unsafe void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
		public static extern unsafe void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
		public static extern unsafe void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
		public static extern unsafe void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
		public static extern unsafe void ImDrawList__ResetForNewFrame(ImDrawList* self);
		public static extern unsafe void ImDrawList__SetTextureID(ImDrawList* self, IntPtr texture_id);
		public static extern unsafe void ImDrawList__TryMergeDrawCmds(ImDrawList* self);
		public static extern unsafe void ImDrawList_destroy(ImDrawList* self);
		public static extern unsafe void ImFontAtlasCustomRect_ImFontAtlasCustomRect();
		public static extern unsafe byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
		public static extern unsafe void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
		public static extern unsafe int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
		public static extern unsafe int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
		public static extern unsafe ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
		public static extern unsafe ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
		public static extern unsafe ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public static extern unsafe ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		public static extern unsafe ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg->FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		public static extern unsafe ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.<br/>
		/// </summary>
		public static extern unsafe byte ImFontAtlas_Build(ImFontAtlas* self);
		public static extern unsafe void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
		/// <summary>
		/// Clear all input and output.<br/>
		/// </summary>
		public static extern unsafe void ImFontAtlas_Clear(ImFontAtlas* self);
		/// <summary>
		/// Clear input+output font data (same as ClearInputData() + glyphs storage, UV coordinates).<br/>
		/// </summary>
		public static extern unsafe void ImFontAtlas_ClearFonts(ImFontAtlas* self);
		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.<br/>
		/// </summary>
		public static extern unsafe void ImFontAtlas_ClearInputData(ImFontAtlas* self);
		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.<br/>
		/// </summary>
		public static extern unsafe void ImFontAtlas_ClearTexData(ImFontAtlas* self);
		public static extern unsafe ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
		/// <summary>
		/// Default + about 400 Cyrillic characters<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
		/// <summary>
		/// Basic Latin, Extended Latin<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
		/// <summary>
		/// Default + Greek and Coptic<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self);
		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
		/// <summary>
		/// Default + Korean characters<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
		/// <summary>
		/// Default + Thai characters<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
		/// <summary>
		/// Default + Vietnamese characters<br/>
		/// </summary>
		public static extern unsafe ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
		public static extern unsafe byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		public static extern unsafe void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		public static extern unsafe void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
		public static extern unsafe void ImFontAtlas_ImFontAtlas();
		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...<br/>
		/// </summary>
		public static extern unsafe byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
		public static extern unsafe void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
		public static extern unsafe void ImFontAtlas_destroy(ImFontAtlas* self);
		public static extern unsafe void ImFontConfig_ImFontConfig();
		public static extern unsafe void ImFontConfig_destroy(ImFontConfig* self);
		/// <summary>
		/// Add character<br/>
		/// </summary>
		public static extern unsafe void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		public static extern unsafe void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public static extern unsafe void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		public static extern unsafe void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector<ushort>* out_ranges);
		public static extern unsafe void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		public static extern unsafe byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
		public static extern unsafe void ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		public static extern unsafe void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
		public static extern unsafe void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
		public static extern unsafe void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public static extern unsafe void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
		public static extern unsafe void ImFont_BuildLookupTable(ImFont* self);
		/// <summary>
		/// utf8<br/>
		/// </summary>
		public static extern unsafe void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
		public static extern unsafe byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
		public static extern unsafe void ImFont_ClearOutputData(ImFont* self);
		public static extern unsafe ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
		public static extern unsafe ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
		public static extern unsafe float ImFont_GetCharAdvance(ImFont* self, ushort c);
		public static extern unsafe byte* ImFont_GetDebugName(ImFont* self);
		public static extern unsafe void ImFont_GrowIndex(ImFont* self, int new_size);
		public static extern unsafe void ImFont_ImFont();
		public static extern unsafe byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
		public static extern unsafe byte ImFont_IsLoaded(ImFont* self);
		public static extern unsafe void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
		public static extern unsafe void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
		public static extern unsafe void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);
		public static extern unsafe void ImFont_destroy(ImFont* self);
		public static extern unsafe IntPtr* ImGuiFreeType_GetBuilderForFreeType();
		public static extern unsafe void ImGuiFreeType_SetAllocatorFunctions(void* alloc_func, void* free_func, void* user_data);
		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);
		/// <summary>
		/// Queue a new character input<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);
		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);
		/// <summary>
		/// Queue a mouse button change<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);
		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);
		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id);
		/// <summary>
		/// Queue a mouse wheel update. wheel_y<0: scroll down, wheel_y>0: scroll up, wheel_x<0: scroll right, wheel_x>0: scroll left.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);
		/// <summary>
		/// Clear all incoming events.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_ClearEventsQueue(ImGuiIO* self);
		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_ClearInputKeys(ImGuiIO* self);
		/// <summary>
		/// Clear current mouse state.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_ClearInputMouse(ImGuiIO* self);
		public static extern unsafe void ImGuiIO_ImGuiIO();
		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events);
		/// <summary>
		/// [Optional] Specify index for legacy <1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		public static extern unsafe void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
		public static extern unsafe void ImGuiIO_destroy(ImGuiIO* self);
		public static extern unsafe void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
		public static extern unsafe void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
		public static extern unsafe byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
		public static extern unsafe void ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
		public static extern unsafe void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
		public static extern unsafe void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
		public static extern unsafe void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
		public static extern unsafe void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
		/// <summary>
		/// Automatically called on the last call of Step() that returns false.<br/>
		/// </summary>
		public static extern unsafe void ImGuiListClipper_End(ImGuiListClipper* self);
		public static extern unsafe void ImGuiListClipper_ImGuiListClipper();
		public static extern unsafe void ImGuiListClipper_IncludeItemByIndex(ImGuiListClipper* self, int item_index);
		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.<br/>
		/// </summary>
		public static extern unsafe void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end);
		public static extern unsafe void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* self, int item_index);
		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.<br/>
		/// </summary>
		public static extern unsafe byte ImGuiListClipper_Step(ImGuiListClipper* self);
		public static extern unsafe void ImGuiListClipper_destroy(ImGuiListClipper* self);
		public static extern unsafe void ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
		public static extern unsafe void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
		public static extern unsafe void ImGuiPayload_Clear(ImGuiPayload* self);
		public static extern unsafe void ImGuiPayload_ImGuiPayload();
		public static extern unsafe byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
		public static extern unsafe byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
		public static extern unsafe byte ImGuiPayload_IsPreview(ImGuiPayload* self);
		public static extern unsafe void ImGuiPayload_destroy(ImGuiPayload* self);
		public static extern unsafe void ImGuiPlatformIO_ImGuiPlatformIO();
		public static extern unsafe void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);
		public static extern unsafe void ImGuiPlatformImeData_ImGuiPlatformImeData();
		public static extern unsafe void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);
		public static extern unsafe void ImGuiPlatformMonitor_ImGuiPlatformMonitor();
		public static extern unsafe void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self);
		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()<br/>
		/// </summary>
		public static extern unsafe void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io);
		/// <summary>
		/// Clear selection<br/>
		/// </summary>
		public static extern unsafe void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Query if an item id is in selection.<br/>
		/// </summary>
		public static extern unsafe byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* self, uint id);
		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
		/// </summary>
		public static extern unsafe byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, uint* out_id);
		/// <summary>
		/// Convert index to item id based on provided adapter.<br/>
		/// </summary>
		public static extern unsafe uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);
		public static extern unsafe void ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage();
		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)<br/>
		/// </summary>
		public static extern unsafe void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected);
		/// <summary>
		/// Swap two selections<br/>
		/// </summary>
		public static extern unsafe void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);
		public static extern unsafe void ImGuiSelectionBasicStorage_destroy(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		public static extern unsafe void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io);
		public static extern unsafe void ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage();
		public static extern unsafe void ImGuiSelectionExternalStorage_destroy(ImGuiSelectionExternalStorage* self);
		public static extern unsafe void ImGuiStoragePair_ImGuiStoragePair(uint _key, int _val);
		public static extern unsafe void ImGuiStoragePair_ImGuiStoragePair(uint _key, float _val);
		public static extern unsafe void ImGuiStoragePair_ImGuiStoragePair(uint _key, void* _val);
		public static extern unsafe void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
		public static extern unsafe void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
		public static extern unsafe void ImGuiStorage_Clear(ImGuiStorage* self);
		public static extern unsafe byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
		public static extern unsafe byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
		public static extern unsafe float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
		public static extern unsafe float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
		public static extern unsafe int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
		public static extern unsafe int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
		/// <summary>
		/// default_val is NULL<br/>
		/// </summary>
		public static extern unsafe void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
		public static extern unsafe void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
		public static extern unsafe void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
		public static extern unsafe void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
		public static extern unsafe void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
		public static extern unsafe void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
		public static extern unsafe void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
		public static extern unsafe void ImGuiStyle_ImGuiStyle();
		public static extern unsafe void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
		public static extern unsafe void ImGuiStyle_destroy(ImGuiStyle* self);
		public static extern unsafe void ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
		public static extern unsafe void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
		public static extern unsafe void ImGuiTableSortSpecs_ImGuiTableSortSpecs();
		public static extern unsafe void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
		public static extern unsafe void ImGuiTextBuffer_ImGuiTextBuffer();
		public static extern unsafe void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
		public static extern unsafe void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
		public static extern unsafe byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
		public static extern unsafe byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
		public static extern unsafe void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
		public static extern unsafe void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
		public static extern unsafe byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public static extern unsafe byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
		public static extern unsafe void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
		public static extern unsafe int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
		public static extern unsafe void ImGuiTextFilter_Build(ImGuiTextFilter* self);
		public static extern unsafe void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
		/// <summary>
		/// Helper calling InputText+Build<br/>
		/// </summary>
		public static extern unsafe byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
		public static extern unsafe void ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
		public static extern unsafe byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
		public static extern unsafe byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
		public static extern unsafe void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
		public static extern unsafe void ImGuiTextRange_ImGuiTextRange();
		public static extern unsafe void ImGuiTextRange_ImGuiTextRange(byte* _b, byte* _e);
		public static extern unsafe void ImGuiTextRange_destroy(ImGuiTextRange* self);
		public static extern unsafe byte ImGuiTextRange_empty(ImGuiTextRange* self);
		public static extern unsafe void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector<ImGuiTextRange>* @out);
		public static extern unsafe void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);
		public static extern unsafe void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);
		public static extern unsafe void ImGuiViewport_ImGuiViewport();
		public static extern unsafe void ImGuiViewport_destroy(ImGuiViewport* self);
		public static extern unsafe void ImGuiWindowClass_ImGuiWindowClass();
		public static extern unsafe void ImGuiWindowClass_destroy(ImGuiWindowClass* self);
		public static extern unsafe void ImVec2_ImVec2();
		public static extern unsafe void ImVec2_ImVec2(float _x, float _y);
		public static extern unsafe void ImVec2_destroy(Vector2* self);
		public static extern unsafe void ImVec4_ImVec4();
		public static extern unsafe void ImVec4_ImVec4(float _x, float _y, float _z, float _w);
		public static extern unsafe void ImVec4_destroy(Vector4* self);
		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static extern unsafe ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		public static extern unsafe void igAlignTextToFramePadding();
		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		public static extern unsafe byte igArrowButton(byte* str_id, ImGuiDir dir);
		public static extern unsafe byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
		public static extern unsafe byte igBeginChild(byte* str_id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		public static extern unsafe byte igBeginChild(uint id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		public static extern unsafe byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
		public static extern unsafe void igBeginDisabled(byte disabled);
		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		public static extern unsafe byte igBeginDragDropSource(ImGuiDragDropFlags flags);
		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		public static extern unsafe byte igBeginDragDropTarget();
		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		public static extern unsafe void igBeginGroup();
		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		public static extern unsafe byte igBeginItemTooltip();
		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static extern unsafe byte igBeginListBox(byte* label, Vector2 size);
		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		public static extern unsafe byte igBeginMainMenuBar();
		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static extern unsafe byte igBeginMenu(byte* label, byte enabled);
		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		public static extern unsafe byte igBeginMenuBar();
		public static extern unsafe ImGuiMultiSelectIO* igBeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size, int items_count);
		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static extern unsafe byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static extern unsafe byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static extern unsafe byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static extern unsafe byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static extern unsafe byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static extern unsafe byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static extern unsafe byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
		public static extern unsafe byte igBeginTable(byte* str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		public static extern unsafe byte igBeginTooltip();
		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		public static extern unsafe void igBullet();
		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		public static extern unsafe void igBulletText(byte* fmt);
		/// <summary>
		/// button<br/>
		/// </summary>
		public static extern unsafe byte igButton(byte* label, Vector2 size);
		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		public static extern unsafe float igCalcItemWidth();
		public static extern unsafe void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
		public static extern unsafe byte igCheckbox(byte* label, byte* v);
		public static extern unsafe byte igCheckboxFlags(byte* label, int* flags, int flags_value);
		public static extern unsafe byte igCheckboxFlags(byte* label, uint* flags, uint flags_value);
		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		public static extern unsafe void igCloseCurrentPopup();
		/// <summary>
		/// if returning 'true' the header is open. doesn't indent nor push on ID stack. user doesn't have to call TreePop().<br/>
		/// </summary>
		public static extern unsafe byte igCollapsingHeader(byte* label, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		public static extern unsafe byte igCollapsingHeader(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static extern unsafe byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
		public static extern unsafe uint igColorConvertFloat4ToU32(Vector4 @in);
		public static extern unsafe void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
		public static extern unsafe void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
		public static extern unsafe void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
		public static extern unsafe byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
		public static extern unsafe byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
		public static extern unsafe byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
		public static extern unsafe byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
		public static extern unsafe void igColumns(int count, byte* id, byte borders);
		public static extern unsafe byte igCombo(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
		/// <summary>
		/// Separate items with \0 within a string, end item-list with \0\0. e.g. "One\0Two\0Three\0"<br/>
		/// </summary>
		public static extern unsafe byte igCombo(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
		public static extern unsafe byte igCombo(byte* label, int* current_item, void* getter, void* user_data, int items_count, int popup_max_height_in_items);
		public static extern unsafe IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		public static extern unsafe byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
		public static extern unsafe void igDebugFlashStyleColor(ImGuiCol idx);
		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		public static extern unsafe void igDebugLog(byte* fmt);
		public static extern unsafe void igDebugStartItemPicker();
		public static extern unsafe void igDebugTextEncoding(byte* text);
		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		public static extern unsafe void igDestroyContext(IntPtr ctx);
		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		public static extern unsafe void igDestroyPlatformWindows();
		public static extern unsafe uint igDockSpace(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
		public static extern unsafe uint igDockSpaceOverViewport(uint dockspace_id, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
		/// <summary>
		/// If v_min >= v_max we have no bound<br/>
		/// </summary>
		public static extern unsafe byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
		/// <summary>
		/// If v_min >= v_max we have no bound<br/>
		/// </summary>
		public static extern unsafe byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		public static extern unsafe void igDummy(Vector2 size);
		public static extern unsafe void igEnd();
		public static extern unsafe void igEndChild();
		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndCombo();
		public static extern unsafe void igEndDisabled();
		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndDragDropSource();
		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndDragDropTarget();
		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		public static extern unsafe void igEndFrame();
		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		public static extern unsafe void igEndGroup();
		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		public static extern unsafe void igEndListBox();
		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndMainMenuBar();
		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndMenu();
		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndMenuBar();
		public static extern unsafe ImGuiMultiSelectIO* igEndMultiSelect();
		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndPopup();
		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndTabBar();
		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndTabItem();
		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndTable();
		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		public static extern unsafe void igEndTooltip();
		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		public static extern unsafe ImGuiViewport* igFindViewportByID(uint id);
		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		public static extern unsafe ImGuiViewport* igFindViewportByPlatformHandle(void* platform_handle);
		public static extern unsafe void igGetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data);
		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		public static extern unsafe ImDrawList* igGetBackgroundDrawList(ImGuiViewport* viewport);
		public static extern unsafe byte* igGetClipboardText();
		/// <summary>
		/// retrieve given style color with style alpha applied and optional extra alpha multiplier, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static extern unsafe uint igGetColorU32(ImGuiCol idx, float alpha_mul);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static extern unsafe uint igGetColorU32(Vector4 col);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static extern unsafe uint igGetColorU32(uint col, float alpha_mul);
		/// <summary>
		/// get current column index<br/>
		/// </summary>
		public static extern unsafe int igGetColumnIndex();
		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		public static extern unsafe float igGetColumnOffset(int column_index);
		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static extern unsafe float igGetColumnWidth(int column_index);
		public static extern unsafe int igGetColumnsCount();
		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static extern unsafe void igGetContentRegionAvail(Vector2* pOut);
		public static extern unsafe IntPtr igGetCurrentContext();
		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		public static extern unsafe void igGetCursorPos(Vector2* pOut);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static extern unsafe float igGetCursorPosX();
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static extern unsafe float igGetCursorPosY();
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		public static extern unsafe void igGetCursorScreenPos(Vector2* pOut);
		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		public static extern unsafe void igGetCursorStartPos(Vector2* pOut);
		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		public static extern unsafe ImGuiPayload* igGetDragDropPayload();
		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		public static extern unsafe ImDrawData* igGetDrawData();
		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		public static extern unsafe ImDrawListSharedData* igGetDrawListSharedData();
		/// <summary>
		/// get current font<br/>
		/// </summary>
		public static extern unsafe ImFont* igGetFont();
		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		public static extern unsafe float igGetFontSize();
		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		public static extern unsafe void igGetFontTexUvWhitePixel(Vector2* pOut);
		/// <summary>
		/// get foreground draw list for the given viewport or viewport associated to the current window. this draw list will be the top-most rendered one. Useful to quickly draw shapes/text over dear imgui contents.<br/>
		/// </summary>
		public static extern unsafe ImDrawList* igGetForegroundDrawList(ImGuiViewport* viewport);
		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		public static extern unsafe int igGetFrameCount();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		public static extern unsafe float igGetFrameHeight();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		public static extern unsafe float igGetFrameHeightWithSpacing();
		/// <summary>
		/// calculate unique ID (hash of whole ID stack + given parameter). e.g. if you want to query into ImGuiStorage yourself<br/>
		/// </summary>
		public static extern unsafe uint igGetID(byte* str_id);
		public static extern unsafe uint igGetID(byte* str_id_begin, byte* str_id_end);
		public static extern unsafe uint igGetID(void* ptr_id);
		public static extern unsafe uint igGetID(int int_id);
		/// <summary>
		/// access the ImGuiIO structure (mouse/keyboard/gamepad inputs, time, various configuration options/flags)<br/>
		/// </summary>
		public static extern unsafe ImGuiIO* igGetIO();
		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		public static extern unsafe uint igGetItemID();
		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static extern unsafe void igGetItemRectMax(Vector2* pOut);
		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static extern unsafe void igGetItemRectMin(Vector2* pOut);
		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		public static extern unsafe void igGetItemRectSize(Vector2* pOut);
		/// <summary>
		/// [DEBUG] returns English name of the key. Those names a provided for debugging purpose and are not meant to be saved persistently not compared.<br/>
		/// </summary>
		public static extern unsafe byte* igGetKeyName(ImGuiKey key);
		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be >1 if RepeatRate is small enough that DeltaTime > RepeatRate<br/>
		/// </summary>
		public static extern unsafe int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);
		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		public static extern unsafe ImGuiViewport* igGetMainViewport();
		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		public static extern unsafe int igGetMouseClickedCount(ImGuiMouseButton button);
		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		public static extern unsafe ImGuiMouseCursor igGetMouseCursor();
		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold < 0.0f)<br/>
		/// </summary>
		public static extern unsafe void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		public static extern unsafe void igGetMousePos(Vector2* pOut);
		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		public static extern unsafe void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
		/// <summary>
		/// access the ImGuiPlatformIO structure (mostly hooks/functions to connect to platform/renderer and OS Clipboard, IME etc.)<br/>
		/// </summary>
		public static extern unsafe ImGuiPlatformIO* igGetPlatformIO();
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		public static extern unsafe float igGetScrollMaxX();
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		public static extern unsafe float igGetScrollMaxY();
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		public static extern unsafe float igGetScrollX();
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		public static extern unsafe float igGetScrollY();
		public static extern unsafe ImGuiStorage* igGetStateStorage();
		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		public static extern unsafe ImGuiStyle* igGetStyle();
		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		public static extern unsafe byte* igGetStyleColorName(ImGuiCol idx);
		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		public static extern unsafe Vector4* igGetStyleColorVec4(ImGuiCol idx);
		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		public static extern unsafe float igGetTextLineHeight();
		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		public static extern unsafe float igGetTextLineHeightWithSpacing();
		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		public static extern unsafe double igGetTime();
		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		public static extern unsafe float igGetTreeNodeToLabelSpacing();
		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		public static extern unsafe byte* igGetVersion();
		public static extern unsafe uint igGetWindowDockID();
		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		public static extern unsafe float igGetWindowDpiScale();
		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		public static extern unsafe ImDrawList* igGetWindowDrawList();
		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		public static extern unsafe float igGetWindowHeight();
		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static extern unsafe void igGetWindowPos(Vector2* pOut);
		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static extern unsafe void igGetWindowSize(Vector2* pOut);
		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		public static extern unsafe ImGuiViewport* igGetWindowViewport();
		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		public static extern unsafe float igGetWindowWidth();
		public static extern unsafe void igImage(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
		public static extern unsafe byte igImageButton(byte* str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);
		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w <= 0<br/>
		/// </summary>
		public static extern unsafe void igIndent(float indent_w);
		public static extern unsafe byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
		public static extern unsafe byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, void* callback, void* user_data);
		public static extern unsafe byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, void* callback, void* user_data);
		public static extern unsafe byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, void* callback, void* user_data);
		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static extern unsafe byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		public static extern unsafe byte igIsAnyItemActive();
		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		public static extern unsafe byte igIsAnyItemFocused();
		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		public static extern unsafe byte igIsAnyItemHovered();
		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		public static extern unsafe byte igIsAnyMouseDown();
		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		public static extern unsafe byte igIsItemActivated();
		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		public static extern unsafe byte igIsItemActive();
		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		public static extern unsafe byte igIsItemClicked(ImGuiMouseButton mouse_button);
		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		public static extern unsafe byte igIsItemDeactivated();
		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		public static extern unsafe byte igIsItemDeactivatedAfterEdit();
		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		public static extern unsafe byte igIsItemEdited();
		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		public static extern unsafe byte igIsItemFocused();
		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		public static extern unsafe byte igIsItemHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		public static extern unsafe byte igIsItemToggledOpen();
		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		public static extern unsafe byte igIsItemToggledSelection();
		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		public static extern unsafe byte igIsItemVisible();
		/// <summary>
		/// was key chord (mods + key) pressed, e.g. you can pass 'ImGuiMod_Ctrl | ImGuiKey_S' as a key-chord. This doesn't do any routing or focus check, please consider using Shortcut() function instead.<br/>
		/// </summary>
		public static extern unsafe byte igIsKeyChordPressed(ImGuiKey key_chord);
		/// <summary>
		/// is key being held.<br/>
		/// </summary>
		public static extern unsafe byte igIsKeyDown(ImGuiKey key);
		/// <summary>
		/// was key pressed (went from !Down to Down)? if repeat=true, uses io.KeyRepeatDelay / KeyRepeatRate<br/>
		/// </summary>
		public static extern unsafe byte igIsKeyPressed(ImGuiKey key, byte repeat);
		/// <summary>
		/// was key released (went from Down to !Down)?<br/>
		/// </summary>
		public static extern unsafe byte igIsKeyReleased(ImGuiKey key);
		/// <summary>
		/// did mouse button clicked? (went from !Down to Down). Same as GetMouseClickedCount() == 1.<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);
		/// <summary>
		/// did mouse button double-clicked? Same as GetMouseClickedCount() == 2. (note that a double-click will also report IsMouseClicked() == true)<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseDoubleClicked(ImGuiMouseButton button);
		/// <summary>
		/// is mouse button held?<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseDown(ImGuiMouseButton button);
		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold < 0.0f)<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		public static extern unsafe byte igIsMousePosValid(Vector2* mouse_pos);
		/// <summary>
		/// did mouse button released? (went from Down to !Down)<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseReleased(ImGuiMouseButton button);
		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay >= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		public static extern unsafe byte igIsMouseReleasedWithDelay(ImGuiMouseButton button, float delay);
		/// <summary>
		/// return true if the popup is open.<br/>
		/// </summary>
		public static extern unsafe byte igIsPopupOpen(byte* str_id, ImGuiPopupFlags flags);
		/// <summary>
		/// test if rectangle (of given size, starting from cursor position) is visible / not clipped.<br/>
		/// </summary>
		public static extern unsafe byte igIsRectVisible(Vector2 size);
		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		public static extern unsafe byte igIsRectVisible(Vector2 rect_min, Vector2 rect_max);
		public static extern unsafe byte igIsWindowAppearing();
		public static extern unsafe byte igIsWindowCollapsed();
		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		public static extern unsafe byte igIsWindowDocked();
		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		public static extern unsafe byte igIsWindowFocused(ImGuiFocusedFlags flags);
		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		public static extern unsafe byte igIsWindowHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		public static extern unsafe void igLabelText(byte* label, byte* fmt);
		public static extern unsafe byte igListBox(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
		public static extern unsafe byte igListBox(byte* label, int* current_item, void* getter, void* user_data, int items_count, int height_in_items);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		public static extern unsafe void igLoadIniSettingsFromDisk(byte* ini_filename);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static extern unsafe void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		public static extern unsafe void igLogButtons();
		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		public static extern unsafe void igLogFinish();
		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static extern unsafe void igLogText(byte* fmt);
		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		public static extern unsafe void igLogToClipboard(int auto_open_depth);
		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static extern unsafe void igLogToFile(int auto_open_depth, byte* filename);
		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		public static extern unsafe void igLogToTTY(int auto_open_depth);
		public static extern unsafe void* igMemAlloc(uint size);
		public static extern unsafe void igMemFree(void* ptr);
		/// <summary>
		/// return true when activated.<br/>
		/// </summary>
		public static extern unsafe byte igMenuItem(byte* label, byte* shortcut, byte selected, byte enabled);
		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		public static extern unsafe byte igMenuItem(byte* label, byte* shortcut, byte* p_selected, byte enabled);
		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		public static extern unsafe void igNewFrame();
		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		public static extern unsafe void igNewLine();
		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		public static extern unsafe void igNextColumn();
		/// <summary>
		/// call to mark popup as open (don't call every frame!).<br/>
		/// </summary>
		public static extern unsafe void igOpenPopup(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		public static extern unsafe void igOpenPopup(uint id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static extern unsafe void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
		public static extern unsafe void igPlotHistogram(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
		public static extern unsafe void igPlotHistogram(byte* label, void* values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);
		public static extern unsafe void igPlotLines(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
		public static extern unsafe void igPlotLines(byte* label, void* values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);
		public static extern unsafe void igPopClipRect();
		public static extern unsafe void igPopFont();
		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		public static extern unsafe void igPopID();
		public static extern unsafe void igPopItemFlag();
		public static extern unsafe void igPopItemWidth();
		public static extern unsafe void igPopStyleColor(int count);
		public static extern unsafe void igPopStyleVar(int count);
		public static extern unsafe void igPopTextWrapPos();
		public static extern unsafe void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
		public static extern unsafe void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		public static extern unsafe void igPushFont(ImFont* font);
		/// <summary>
		/// push string into the ID stack (will hash string).<br/>
		/// </summary>
		public static extern unsafe void igPushID(byte* str_id);
		/// <summary>
		/// push string into the ID stack (will hash string).<br/>
		/// </summary>
		public static extern unsafe void igPushID(byte* str_id_begin, byte* str_id_end);
		/// <summary>
		/// push pointer into the ID stack (will hash pointer).<br/>
		/// </summary>
		public static extern unsafe void igPushID(void* ptr_id);
		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		public static extern unsafe void igPushID(int int_id);
		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		public static extern unsafe void igPushItemFlag(ImGuiItemFlags option, byte enabled);
		/// <summary>
		/// push width of items for common large "item+label" widgets. >0.0f: width in pixels, <0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		public static extern unsafe void igPushItemWidth(float item_width);
		/// <summary>
		/// modify a style color. always use this if you modify the style after NewFrame().<br/>
		/// </summary>
		public static extern unsafe void igPushStyleColor(ImGuiCol idx, uint col);
		public static extern unsafe void igPushStyleColor(ImGuiCol idx, Vector4 col);
		/// <summary>
		/// modify a style float variable. always use this if you modify the style after NewFrame()!<br/>
		/// </summary>
		public static extern unsafe void igPushStyleVar(ImGuiStyleVar idx, float val);
		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		public static extern unsafe void igPushStyleVar(ImGuiStyleVar idx, Vector2 val);
		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static extern unsafe void igPushStyleVarX(ImGuiStyleVar idx, float val_x);
		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static extern unsafe void igPushStyleVarY(ImGuiStyleVar idx, float val_y);
		/// <summary>
		/// push word-wrapping position for Text*() commands. < 0.0f: no wrapping; 0.0f: wrap to end of window (or column); > 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		public static extern unsafe void igPushTextWrapPos(float wrap_local_pos_x);
		/// <summary>
		/// use with e.g. if (RadioButton("one", my_value==1))  my_value = 1; <br/>
		/// </summary>
		public static extern unsafe byte igRadioButton(byte* label, byte active);
		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		public static extern unsafe byte igRadioButton(byte* label, int* v, int v_button);
		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		public static extern unsafe void igRender();
		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		public static extern unsafe void igRenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
		/// <summary>
		/// //<br/>
		/// </summary>
		public static extern unsafe void igResetMouseDragDelta(ImGuiMouseButton button);
		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		public static extern unsafe void igSameLine(float offset_from_start_x, float spacing);
		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		public static extern unsafe void igSaveIniSettingsToDisk(byte* ini_filename);
		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		public static extern unsafe byte* igSaveIniSettingsToMemory(uint* out_ini_size);
		/// <summary>
		/// "bool selected" carry the selection state (read-only). Selectable() is clicked is returns true so you can modify your selection state. size.x==0.0: use remaining width, size.x>0.0: specify width. size.y==0.0: use label height, size.y>0.0: specify height<br/>
		/// </summary>
		public static extern unsafe byte igSelectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		public static extern unsafe byte igSelectable(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		public static extern unsafe void igSeparator();
		/// <summary>
		/// currently: formatted text with an horizontal line<br/>
		/// </summary>
		public static extern unsafe void igSeparatorText(byte* label);
		public static extern unsafe void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
		public static extern unsafe void igSetClipboardText(byte* text);
		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		public static extern unsafe void igSetColorEditOptions(ImGuiColorEditFlags flags);
		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		public static extern unsafe void igSetColumnOffset(int column_index, float offset_x);
		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static extern unsafe void igSetColumnWidth(int column_index, float width);
		public static extern unsafe void igSetCurrentContext(IntPtr ctx);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static extern unsafe void igSetCursorPos(Vector2 local_pos);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static extern unsafe void igSetCursorPosX(float local_x);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static extern unsafe void igSetCursorPosY(float local_y);
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static extern unsafe void igSetCursorScreenPos(Vector2 pos);
		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static extern unsafe byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
		/// <summary>
		/// make last item the default focused item of of a newly appearing window.<br/>
		/// </summary>
		public static extern unsafe void igSetItemDefaultFocus();
		/// <summary>
		/// Set key owner to last item ID if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		public static extern unsafe void igSetItemKeyOwner(ImGuiKey key);
		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		public static extern unsafe void igSetItemTooltip(byte* fmt);
		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		public static extern unsafe void igSetKeyboardFocusHere(int offset);
		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		public static extern unsafe void igSetMouseCursor(ImGuiMouseCursor cursor_type);
		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		public static extern unsafe void igSetNavCursorVisible(byte visible);
		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		public static extern unsafe void igSetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);
		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		public static extern unsafe void igSetNextFrameWantCaptureMouse(byte want_capture_mouse);
		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		public static extern unsafe void igSetNextItemAllowOverlap();
		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		public static extern unsafe void igSetNextItemOpen(byte is_open, ImGuiCond cond);
		public static extern unsafe void igSetNextItemSelectionUserData(long selection_user_data);
		public static extern unsafe void igSetNextItemShortcut(ImGuiKey key_chord, ImGuiInputFlags flags);
		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		public static extern unsafe void igSetNextItemStorageID(uint storage_id);
		/// <summary>
		/// set width of the _next_ common large "item+label" widget. >0.0f: width in pixels, <0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		public static extern unsafe void igSetNextItemWidth(float item_width);
		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowBgAlpha(float alpha);
		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowClass(ImGuiWindowClass* window_class);
		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowContentSize(Vector2 size);
		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowDockID(uint dock_id, ImGuiCond cond);
		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowFocus();
		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
		/// <summary>
		/// set next window scrolling value (use < 0.0f to not affect a given axis).<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowScroll(Vector2 scroll);
		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, void* custom_callback, void* custom_callback_data);
		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		public static extern unsafe void igSetNextWindowViewport(uint viewport_id);
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.<br/>
		/// </summary>
		public static extern unsafe void igSetScrollFromPosX(float local_x, float center_x_ratio);
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.<br/>
		/// </summary>
		public static extern unsafe void igSetScrollFromPosY(float local_y, float center_y_ratio);
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static extern unsafe void igSetScrollHereX(float center_x_ratio);
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static extern unsafe void igSetScrollHereY(float center_y_ratio);
		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		public static extern unsafe void igSetScrollX(float scroll_x);
		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		public static extern unsafe void igSetScrollY(float scroll_y);
		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		public static extern unsafe void igSetStateStorage(ImGuiStorage* storage);
		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		public static extern unsafe void igSetTabItemClosed(byte* tab_or_docked_window_label);
		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		public static extern unsafe void igSetTooltip(byte* fmt);
		/// <summary>
		/// (not recommended) set current window collapsed state. prefer using SetNextWindowCollapsed().<br/>
		/// </summary>
		public static extern unsafe void igSetWindowCollapsed(byte collapsed, ImGuiCond cond);
		/// <summary>
		/// set named window collapsed state<br/>
		/// </summary>
		public static extern unsafe void igSetWindowCollapsed(byte* name, byte collapsed, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window to be focused / top-most. prefer using SetNextWindowFocus().<br/>
		/// </summary>
		public static extern unsafe void igSetWindowFocus();
		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		public static extern unsafe void igSetWindowFocus(byte* name);
		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		public static extern unsafe void igSetWindowFontScale(float scale);
		/// <summary>
		/// (not recommended) set current window position - call within Begin()/End(). prefer using SetNextWindowPos(), as this may incur tearing and side-effects.<br/>
		/// </summary>
		public static extern unsafe void igSetWindowPos(Vector2 pos, ImGuiCond cond);
		/// <summary>
		/// set named window position.<br/>
		/// </summary>
		public static extern unsafe void igSetWindowPos(byte* name, Vector2 pos, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window size - call within Begin()/End(). set to ImVec2(0, 0) to force an auto-fit. prefer using SetNextWindowSize(), as this may incur tearing and minor side-effects.<br/>
		/// </summary>
		public static extern unsafe void igSetWindowSize(Vector2 size, ImGuiCond cond);
		/// <summary>
		/// set named window size. set axis to 0.0f to force an auto-fit on this axis.<br/>
		/// </summary>
		public static extern unsafe void igSetWindowSize(byte* name, Vector2 size, ImGuiCond cond);
		public static extern unsafe byte igShortcut(ImGuiKey key_chord, ImGuiInputFlags flags);
		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		public static extern unsafe void igShowAboutWindow(byte* p_open);
		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		public static extern unsafe void igShowDebugLogWindow(byte* p_open);
		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		public static extern unsafe void igShowDemoWindow(byte* p_open);
		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		public static extern unsafe void igShowFontSelector(byte* label);
		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		public static extern unsafe void igShowIDStackToolWindow(byte* p_open);
		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		public static extern unsafe void igShowMetricsWindow(byte* p_open);
		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		public static extern unsafe void igShowStyleEditor(ImGuiStyle* @ref);
		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		public static extern unsafe byte igShowStyleSelector(byte* label);
		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		public static extern unsafe void igShowUserGuide();
		public static extern unsafe byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static extern unsafe byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		public static extern unsafe byte igSmallButton(byte* label);
		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		public static extern unsafe void igSpacing();
		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		public static extern unsafe void igStyleColorsClassic(ImGuiStyle* dst);
		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		public static extern unsafe void igStyleColorsDark(ImGuiStyle* dst);
		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		public static extern unsafe void igStyleColorsLight(ImGuiStyle* dst);
		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static extern unsafe byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);
		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		public static extern unsafe void igTableAngledHeadersRow();
		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		public static extern unsafe int igTableGetColumnCount();
		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		public static extern unsafe ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);
		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		public static extern unsafe int igTableGetColumnIndex();
		/// <summary>
		/// return "" if column didn't have a name declared by TableSetupColumn(). Pass -1 to use current column.<br/>
		/// </summary>
		public static extern unsafe byte* igTableGetColumnName(int column_n);
		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		public static extern unsafe int igTableGetHoveredColumn();
		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		public static extern unsafe int igTableGetRowIndex();
		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		public static extern unsafe ImGuiTableSortSpecs* igTableGetSortSpecs();
		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		public static extern unsafe void igTableHeader(byte* label);
		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		public static extern unsafe void igTableHeadersRow();
		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		public static extern unsafe byte igTableNextColumn();
		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		public static extern unsafe void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		public static extern unsafe void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		public static extern unsafe void igTableSetColumnEnabled(int column_n, byte v);
		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		public static extern unsafe byte igTableSetColumnIndex(int column_n);
		public static extern unsafe void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		public static extern unsafe void igTableSetupScrollFreeze(int cols, int rows);
		/// <summary>
		/// formatted text<br/>
		/// </summary>
		public static extern unsafe void igText(byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static extern unsafe void igTextColored(Vector4 col, byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static extern unsafe void igTextDisabled(byte* fmt);
		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		public static extern unsafe byte igTextLink(byte* label);
		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static extern unsafe void igTextLinkOpenURL(byte* label, byte* url);
		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static extern unsafe void igTextUnformatted(byte* text, byte* text_end);
		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		public static extern unsafe void igTextWrapped(byte* fmt);
		public static extern unsafe byte igTreeNode(byte* label);
		/// <summary>
		/// helper variation to easily decorelate the id from the displayed string. Read the FAQ about why and how to use ID. to align arbitrary text at the same level as a TreeNode() you can use Bullet().<br/>
		/// </summary>
		public static extern unsafe byte igTreeNode(byte* str_id, byte* fmt);
		/// <summary>
		/// "<br/>
		/// </summary>
		public static extern unsafe byte igTreeNode(void* ptr_id, byte* fmt);
		public static extern unsafe byte igTreeNodeEx(byte* label, ImGuiTreeNodeFlags flags);
		public static extern unsafe byte igTreeNodeEx(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
		public static extern unsafe byte igTreeNodeEx(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		public static extern unsafe void igTreePop();
		/// <summary>
		/// ~ Indent()+PushID(). Already called by TreeNode() when returning true, but you can call TreePush/TreePop yourself if desired.<br/>
		/// </summary>
		public static extern unsafe void igTreePush(byte* str_id);
		/// <summary>
		/// "<br/>
		/// </summary>
		public static extern unsafe void igTreePush(void* ptr_id);
		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w <= 0<br/>
		/// </summary>
		public static extern unsafe void igUnindent(float indent_w);
		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		public static extern unsafe void igUpdatePlatformWindows();
		public static extern unsafe byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		public static extern unsafe void igValue(byte* prefix, byte b);
		public static extern unsafe void igValue(byte* prefix, int v);
		public static extern unsafe void igValue(byte* prefix, uint v);
		public static extern unsafe void igValue(byte* prefix, float v, byte* float_format);
	}
}

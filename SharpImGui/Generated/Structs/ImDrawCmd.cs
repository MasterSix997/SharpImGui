using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Typically, 1 command = 1 GPU draw call (unless command is a callback)<br/>
	/// - VtxOffset: When 'io.BackendFlags & ImGuiBackendFlags_RendererHasVtxOffset' is enabled,<br/>
	///   this fields allow us to render meshes larger than 64K vertices while keeping 16-bit indices.<br/>
	///   Backends made for <1.71. will typically ignore the VtxOffset fields.<br/>
	/// - The ClipRect/TextureId/VtxOffset fields must be contiguous as we memcmp() them together (this is asserted for).<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawCmd
	{
		/// <summary>
		/// 4*4  // Clipping rectangle (x1, y1, x2, y2). Subtract ImDrawData->DisplayPos to get clipping rectangle in "viewport" coordinates<br/>
		/// </summary>
		public Vector4 ClipRect;
		/// <summary>
		/// 4-8  // User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions. Ignore if never using images or multiple fonts atlas.<br/>
		/// </summary>
		public IntPtr TextureId;
		/// <summary>
		/// 4    // Start offset in vertex buffer. ImGuiBackendFlags_RendererHasVtxOffset: always 0, otherwise may be >0 to support meshes larger than 64K vertices with 16-bit indices.<br/>
		/// </summary>
		public uint VtxOffset;
		/// <summary>
		/// 4    // Start offset in index buffer.<br/>
		/// </summary>
		public uint IdxOffset;
		/// <summary>
		/// 4    // Number of indices (multiple of 3) to be rendered as triangles. Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].<br/>
		/// </summary>
		public uint ElemCount;
		/// <summary>
		/// 4-8  // If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.<br/>
		/// </summary>
		public IntPtr UserCallback;
		/// <summary>
		/// 4-8  // Callback user data (when UserCallback != NULL). If called AddCallback() with size == 0, this is a copy of the AddCallback() argument. If called AddCallback() with size > 0, this is pointing to a buffer where data is stored.<br/>
		/// </summary>
		public unsafe void* UserCallbackData;
		/// <summary>
		/// 4 // Size of callback user data when using storage, otherwise 0.<br/>
		/// </summary>
		public int UserCallbackDataSize;
		/// <summary>
		/// 4 // [Internal] Offset of callback user data when using storage, otherwise -1.<br/>
		/// </summary>
		public int UserCallbackDataOffset;
	}
}

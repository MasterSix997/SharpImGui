using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Draw command list<br/>
	/// This is the low-level list of polygons that ImGui:: functions are filling. At the end of the frame,<br/>
	/// all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.<br/>
	/// Each dear imgui window contains its own ImDrawList. You can use ImGui::GetWindowDrawList() to<br/>
	/// access the current window draw list and draw custom primitives.<br/>
	/// You can interleave normal ImGui:: calls and adding primitives to the current draw list.<br/>
	/// In single viewport mode, top-left is == GetMainViewport()->Pos (generally 0,0), bottom-right is == GetMainViewport()->Pos+Size (generally io.DisplaySize).<br/>
	/// You are totally free to apply whatever transformation matrix you want to the data (depending on the use of the transformation you may want to apply it to ClipRect as well!)<br/>
	/// Important: Primitives are always added to the list and not culled (culling is done at higher-level by ImGui:: functions), if you use this API a lot consider coarse culling your drawn objects.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawList
	{
		/// <summary>
		/// <br/>
		///     // This is what you have to render<br/>
		/// Draw commands. Typically 1 command = 1 GPU draw call, unless the command is a callback.<br/>
		/// </summary>
		public ImVector<ImDrawCmd> CmdBuffer;
		/// <summary>
		/// Index buffer. Each command consume ImDrawCmd::ElemCount of those<br/>
		/// </summary>
		public ImVector<ushort> IdxBuffer;
		/// <summary>
		/// Vertex buffer.<br/>
		/// </summary>
		public ImVector<ImDrawVert> VtxBuffer;
		/// <summary>
		/// Flags, you may poke into these to adjust anti-aliasing settings per-primitive.<br/>
		/// </summary>
		public ImDrawListFlags Flags;
		/// <summary>
		///     // [Internal, used while building lists]<br/>
		/// [Internal] generally == VtxBuffer.Size unless we are past 64K vertices, in which case this gets reset to 0.<br/>
		/// </summary>
		public uint _VtxCurrentIdx;
		/// <summary>
		/// Pointer to shared draw data (you can use ImGui::GetDrawListSharedData() to get the one from current ImGui context)<br/>
		/// </summary>
		public unsafe ImDrawListSharedData* _Data;
		/// <summary>
		/// [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)<br/>
		/// </summary>
		public unsafe ImDrawVert* _VtxWritePtr;
		/// <summary>
		/// [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector<> operators too much)<br/>
		/// </summary>
		public unsafe ushort* _IdxWritePtr;
		/// <summary>
		/// [Internal] current path building<br/>
		/// </summary>
		public ImVector<Vector2> _Path;
		/// <summary>
		/// [Internal] template of active commands. Fields should match those of CmdBuffer.back().<br/>
		/// </summary>
		public ImDrawCmdHeader _CmdHeader;
		/// <summary>
		/// [Internal] for channels api (note: prefer using your own persistent instance of ImDrawListSplitter!)<br/>
		/// </summary>
		public ImDrawListSplitter _Splitter;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImVector<Vector4> _ClipRectStack;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImVector<IntPtr> _TextureIdStack;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImVector<byte> _CallbacksDataBuf;
		/// <summary>
		/// [Internal] anti-alias fringe is scaled by this value, this helps to keep things sharp while zooming at vertex buffer content<br/>
		/// </summary>
		public float _FringeScale;
		/// <summary>
		/// Pointer to owner window's name for debugging<br/>
		/// </summary>
		public unsafe byte* _OwnerName;
	}

	public unsafe struct ImDrawListPtr
	{
		public ImDrawList* NativePtr;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// All draw data to render a Dear ImGui frame<br/>
	/// (NB: the style and the naming convention here is a little inconsistent, we currently preserve them for backward compatibility purpose,<br/>
	/// as this is one of the oldest structure exposed by the library! Basically, ImDrawList == CmdList)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawData
	{
		/// <summary>
		/// Only valid after Render() is called and before the next NewFrame() is called.<br/>
		/// </summary>
		public byte Valid;
		/// <summary>
		/// Number of ImDrawList* to render<br/>
		/// </summary>
		public int CmdListsCount;
		/// <summary>
		/// For convenience, sum of all ImDrawList's IdxBuffer.Size<br/>
		/// </summary>
		public int TotalIdxCount;
		/// <summary>
		/// For convenience, sum of all ImDrawList's VtxBuffer.Size<br/>
		/// </summary>
		public int TotalVtxCount;
		/// <summary>
		/// Array of ImDrawList* to render. The ImDrawLists are owned by ImGuiContext and only pointed to from here.<br/>
		/// </summary>
		public ImVector<ImDrawListPtr> CmdLists;
		/// <summary>
		/// Top-left position of the viewport to render (== top-left of the orthogonal projection matrix to use) (== GetMainViewport()->Pos for the main viewport, == (0.0) in most single-viewport applications)<br/>
		/// </summary>
		public Vector2 DisplayPos;
		/// <summary>
		/// Size of the viewport to render (== GetMainViewport()->Size for the main viewport, == io.DisplaySize in most single-viewport applications)<br/>
		/// </summary>
		public Vector2 DisplaySize;
		/// <summary>
		/// Amount of pixels for each unit of DisplaySize. Based on io.DisplayFramebufferScale. Generally (1,1) on normal display, (2,2) on OSX with Retina display.<br/>
		/// </summary>
		public Vector2 FramebufferScale;
		/// <summary>
		/// Viewport carrying the ImDrawData instance, might be of use to the renderer (generally not).<br/>
		/// </summary>
		public unsafe ImGuiViewport* OwnerViewport;
	}
}

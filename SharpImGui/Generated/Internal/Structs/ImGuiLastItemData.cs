using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Status storage for the last submitted item<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiLastItemData
	{
		public uint ID;
		/// <summary>
		/// See ImGuiItemFlags_ (called 'InFlags' before v1.91.4).<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// See ImGuiItemStatusFlags_<br/>
		/// </summary>
		public ImGuiItemStatusFlags StatusFlags;
		/// <summary>
		/// Full rectangle<br/>
		/// </summary>
		public ImRect Rect;
		/// <summary>
		/// Navigation scoring rectangle (not displayed)<br/>
		/// </summary>
		public ImRect NavRect;
		/// <summary>
		/// <br/>
		///     Rarely used fields are not explicitly cleared, only valid when the corresponding ImGuiItemStatusFlags are set.<br/>
		/// Display rectangle. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasDisplayRect) is set.<br/>
		/// </summary>
		public ImRect DisplayRect;
		/// <summary>
		/// Clip rectangle at the time of submitting item. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasClipRect) is set..<br/>
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// Shortcut at the time of submitting item. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasShortcut) is set..<br/>
		/// </summary>
		public ImGuiKey Shortcut;
	}
}

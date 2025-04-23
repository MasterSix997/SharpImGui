using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage for popup stacks (g.OpenPopupStack and g.BeginPopupStack)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPopupData
	{
		/// <summary>
		/// Set on OpenPopup()<br/>
		/// </summary>
		public uint PopupId;
		/// <summary>
		/// Resolved on BeginPopup() - may stay unresolved if user never calls OpenPopup()<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		/// <summary>
		/// Set on OpenPopup(), a NavWindow that will be restored on popup close<br/>
		/// </summary>
		public unsafe ImGuiWindow* RestoreNavWindow;
		/// <summary>
		/// Resolved on BeginPopup(). Actually a ImGuiNavLayer type (declared down below), initialized to -1 which is not part of an enum, but serves well-enough as "not any of layers" value<br/>
		/// </summary>
		public int ParentNavLayer;
		/// <summary>
		/// Set on OpenPopup()<br/>
		/// </summary>
		public int OpenFrameCount;
		/// <summary>
		/// Set on OpenPopup(), we need this to differentiate multiple menu sets from each others (e.g. inside menu bar vs loose menu items)<br/>
		/// </summary>
		public uint OpenParentId;
		/// <summary>
		/// Set on OpenPopup(), preferred popup position (typically == OpenMousePos when using mouse)<br/>
		/// </summary>
		public Vector2 OpenPopupPos;
		/// <summary>
		/// Set on OpenPopup(), copy of mouse position at the time of opening popup<br/>
		/// </summary>
		public Vector2 OpenMousePos;
	}
}

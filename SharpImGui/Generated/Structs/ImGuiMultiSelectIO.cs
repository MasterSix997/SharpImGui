using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Main IO structure returned by BeginMultiSelect()/EndMultiSelect().<br/>
	/// This mainly contains a list of selection requests.<br/>
	/// - Use 'Demo->Tools->Debug Log->Selection' to see requests as they happen.<br/>
	/// - Some fields are only useful if your list is dynamic and allows deletion (getting post-deletion focus/state right is shown in the demo)<br/>
	/// - Below: who reads/writes each fields? 'r'=read, 'w'=write, 'ms'=multi-select code, 'app'=application/user code.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectIO
	{
		/// <summary>
		/// <br/>
		///     //------------------------------------------BeginMultiSelect / EndMultiSelect<br/>
		///  ms:w, app:r     /  ms:w  app:r   Requests to apply to your selection data.<br/>
		/// </summary>
		public ImVector<ImGuiSelectionRequest> Requests;
		/// <summary>
		///  ms:w  app:r     /                (If using clipper) Begin: Source item (often the first selected item) must never be clipped: use clipper.IncludeItemByIndex() to ensure it is submitted.<br/>
		/// </summary>
		public long RangeSrcItem;
		/// <summary>
		///  ms:w, app:r     /                (If using deletion) Last known SetNextItemSelectionUserData() value for NavId (if part of submitted items).<br/>
		/// </summary>
		public long NavIdItem;
		/// <summary>
		///  ms:w, app:r     /        app:r   (If using deletion) Last known selection state for NavId (if part of submitted items).<br/>
		/// </summary>
		public byte NavIdSelected;
		/// <summary>
		///        app:w     /  ms:r          (If using deletion) Set before EndMultiSelect() to reset ResetSrcItem (e.g. if deleted selection).<br/>
		/// </summary>
		public byte RangeSrcReset;
		/// <summary>
		///  ms:w, app:r     /        app:r   'int items_count' parameter to BeginMultiSelect() is copied here for convenience, allowing simpler calls to your ApplyRequests handler. Not used internally.<br/>
		/// </summary>
		public int ItemsCount;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Manually clip large list of items.<br/>
	/// If you have lots evenly spaced items and you have random access to the list, you can perform coarse<br/>
	/// clipping based on visibility to only submit items that are in view.<br/>
	/// The clipper calculates the range of visible items and advance the cursor to compensate for the non-visible items we have skipped.<br/>
	/// (Dear ImGui already clip items based on their bounds but: it needs to first layout the item to do so, and generally<br/>
	///  fetching/submitting your own data incurs additional cost. Coarse clipping using ImGuiListClipper allows you to easily<br/>
	///  scale using lists with tens of thousands of items without a problem)<br/>
	/// Usage:<br/>
	///   ImGuiListClipper clipper;<br/>
	///   clipper.Begin(1000);         // We have 1000 elements, evenly spaced.<br/>
	///   while (clipper.Step())<br/>
	///       for (int i = clipper.DisplayStart; i < clipper.DisplayEnd; i++)<br/>
	///           ImGui::Text("line number %d", i);<br/>
	/// Generally what happens is:<br/>
	/// - Clipper lets you process the first element (DisplayStart = 0, DisplayEnd = 1) regardless of it being visible or not.<br/>
	/// - User code submit that one element.<br/>
	/// - Clipper can measure the height of the first element<br/>
	/// - Clipper calculate the actual range of elements to display based on the current clipping rectangle, position the cursor before the first visible element.<br/>
	/// - User code submit visible elements.<br/>
	/// - The clipper also handles various subtleties related to keyboard/gamepad navigation, wrapping etc.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipper
	{
		/// <summary>
		/// Parent UI context<br/>
		/// </summary>
		public IntPtr Ctx;
		/// <summary>
		/// First item to display, updated by each call to Step()<br/>
		/// </summary>
		public int DisplayStart;
		/// <summary>
		/// End of items to display (exclusive)<br/>
		/// </summary>
		public int DisplayEnd;
		/// <summary>
		/// [Internal] Number of items<br/>
		/// </summary>
		public int ItemsCount;
		/// <summary>
		/// [Internal] Height of item after a first step and item submission can calculate it<br/>
		/// </summary>
		public float ItemsHeight;
		/// <summary>
		/// [Internal] Cursor position at the time of Begin() or after table frozen rows are all processed<br/>
		/// </summary>
		public float StartPosY;
		/// <summary>
		/// [Internal] Account for frozen rows in a table and initial loss of precision in very large windows.<br/>
		/// </summary>
		public double StartSeekOffsetY;
		/// <summary>
		/// [Internal] Internal data<br/>
		/// </summary>
		public unsafe void* TempData;
	}
}

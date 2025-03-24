using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Persistent storage for multi-select (as long as selection is alive)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectState
	{
		public unsafe ImGuiWindow* Window;
		public uint ID;
		/// <summary>
		/// Last used frame-count, for GC.<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Set by BeginMultiSelect() based on optional info provided by user. May be -1 if unknown.<br/>
		/// </summary>
		public int LastSelectionSize;
		/// <summary>
		/// -1 (don't have) or true/false<br/>
		/// </summary>
		public sbyte RangeSelected;
		/// <summary>
		/// -1 (don't have) or true/false<br/>
		/// </summary>
		public sbyte NavIdSelected;
		/// <summary>
		/// //<br/>
		/// </summary>
		public long RangeSrcItem;
		/// <summary>
		/// SetNextItemSelectionUserData() value for NavId (if part of submitted items)<br/>
		/// </summary>
		public long NavIdItem;
	}
}

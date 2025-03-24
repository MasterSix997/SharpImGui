using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Temporary storage for multi-select<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectTempData
	{
		/// <summary>
		/// MUST BE FIRST FIELD. Requests are set and returned by BeginMultiSelect()/EndMultiSelect() + written to by user during the loop.<br/>
		/// </summary>
		public ImGuiMultiSelectIO IO;
		public unsafe ImGuiMultiSelectState* Storage;
		/// <summary>
		/// Copied from g.CurrentFocusScopeId (unless another selection scope was pushed manually)<br/>
		/// </summary>
		public uint FocusScopeId;
		public ImGuiMultiSelectFlags Flags;
		public Vector2 ScopeRectMin;
		public Vector2 BackupCursorMaxPos;
		/// <summary>
		/// Copy of last submitted item data, used to merge output ranges.<br/>
		/// </summary>
		public long LastSubmittedItem;
		public uint BoxSelectId;
		public ImGuiKey KeyMods;
		/// <summary>
		/// -1: no operation, 0: clear all, 1: select all.<br/>
		/// </summary>
		public sbyte LoopRequestSetAll;
		/// <summary>
		/// Set when switching IO from BeginMultiSelect() to EndMultiSelect() state.<br/>
		/// </summary>
		public byte IsEndIO;
		/// <summary>
		/// Set if currently focusing the selection scope (any item of the selection). May be used if you have custom shortcut associated to selection.<br/>
		/// </summary>
		public byte IsFocused;
		/// <summary>
		/// Set by BeginMultiSelect() when using Shift+Navigation. Because scrolling may be affected we can't afford a frame of lag with Shift+Navigation.<br/>
		/// </summary>
		public byte IsKeyboardSetRange;
		public byte NavIdPassedBy;
		/// <summary>
		/// Set by the item that matches RangeSrcItem.<br/>
		/// </summary>
		public byte RangeSrcPassedBy;
		/// <summary>
		/// Set by the item that matches NavJustMovedToId when IsSetRange is set.<br/>
		/// </summary>
		public byte RangeDstPassedBy;
	}
}

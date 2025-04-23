using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiBoxSelectState
	{
		/// <summary>
		/// <br/>
		///     Active box-selection data (persistent, 1 active at a time)<br/>
		/// </summary>
		public uint ID;
		public byte IsActive;
		public byte IsStarting;
		/// <summary>
		/// Starting click was not from an item.<br/>
		/// </summary>
		public byte IsStartedFromVoid;
		public byte IsStartedSetNavIdOnce;
		public byte RequestClear;
		/// <summary>
		/// Latched key-mods for box-select logic.<br/>
		/// </summary>
		public ImGuiKey KeyMods;
		/// <summary>
		/// Start position in window-contents relative space (to support scrolling)<br/>
		/// </summary>
		public Vector2 StartPosRel;
		/// <summary>
		/// End position in window-contents relative space<br/>
		/// </summary>
		public Vector2 EndPosRel;
		/// <summary>
		/// Scrolling accumulator (to behave at high-frame spaces)<br/>
		/// </summary>
		public Vector2 ScrollAccum;
		public unsafe ImGuiWindow* Window;
		/// <summary>
		///     Temporary/Transient data<br/>
		/// (Temp/Transient, here in hot area). Set/cleared by the BeginMultiSelect()/EndMultiSelect() owning active box-select.<br/>
		/// </summary>
		public byte UnclipMode;
		/// <summary>
		/// Rectangle where ItemAdd() clipping may be temporarily disabled. Need support by multi-select supporting widgets.<br/>
		/// </summary>
		public ImRect UnclipRect;
		/// <summary>
		/// Selection rectangle in absolute coordinates (derived every frame from BoxSelectStartPosRel and MousePos)<br/>
		/// </summary>
		public ImRect BoxSelectRectPrev;
		public ImRect BoxSelectRectCurr;
	}
}

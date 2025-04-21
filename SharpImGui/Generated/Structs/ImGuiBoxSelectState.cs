using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiBoxSelectState
	{
		public uint ID;
		public byte IsActive;
		public byte IsStarting;
		public byte IsStartedFromVoid;
		public byte IsStartedSetNavIdOnce;
		public byte RequestClear;
		public ImGuiKey KeyMods;
		public Vector2 StartPosRel;
		public Vector2 EndPosRel;
		public Vector2 ScrollAccum;
		public unsafe ImGuiWindow* Window;
		public byte UnclipMode;
		public ImRect UnclipRect;
		public ImRect BoxSelectRectPrev;
		public ImRect BoxSelectRectCurr;
	}
}

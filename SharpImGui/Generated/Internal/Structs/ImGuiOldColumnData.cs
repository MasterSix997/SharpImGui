using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOldColumnData
	{
		/// <summary>
		/// // Column start offset, normalized 0.0 (far left) -> 1.0 (far right)
		/// </summary>
		public float OffsetNorm;
		public float OffsetNormBeforeResize;
		/// <summary>
		/// // Not exposed
		/// </summary>
		public ImGuiOldColumnFlags Flags;
		public ImRect ClipRect;
	}
}

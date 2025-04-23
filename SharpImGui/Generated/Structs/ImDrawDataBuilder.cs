using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawDataBuilder
	{
		/// <summary>
		/// Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.<br/>
		/// </summary>
		public unsafe ImVector<ImDrawListPtr>* Layers_0;
		public unsafe ImVector<ImDrawListPtr>* Layers_1;
		public ImVector<ImDrawListPtr> LayerData1;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;
using SharpImGui;

namespace SharpImPlot3D
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlot3DStyle
	{
		/// <summary>
		/// <br/>    Item style<br/>
		/// Line weight in pixels<br/>
		/// </summary>
		public float LineWeight;
		/// <summary>
		/// Default marker type (ImPlot3DMarker_None)<br/>
		/// </summary>
		public int Marker;
		/// <summary>
		/// Marker size in pixels (roughly the marker's "radius")<br/>
		/// </summary>
		public float MarkerSize;
		/// <summary>
		/// Marker outline weight in pixels<br/>
		/// </summary>
		public float MarkerWeight;
		/// <summary>
		/// Alpha modifier applied to plot fills<br/>
		/// </summary>
		public float FillAlpha;
		/// <summary>
		/// <br/>    Plot style<br/>
		/// </summary>
		public Vector2 PlotDefaultSize;
		public Vector2 PlotMinSize;
		public Vector2 PlotPadding;
		public Vector2 LabelPadding;
		/// <summary>
		/// <br/>    Legend style<br/>
		/// Legend padding from plot edges<br/>
		/// </summary>
		public Vector2 LegendPadding;
		/// <summary>
		/// Legend inner padding from legend edges<br/>
		/// </summary>
		public Vector2 LegendInnerPadding;
		/// <summary>
		/// Spacing between legend entries<br/>
		/// </summary>
		public Vector2 LegendSpacing;
		/// <summary>
		/// <br/>    Colors<br/>
		/// </summary>
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;
		/// <summary>
		/// <br/>    Colormap<br/>
		/// The current colormap. Set this to either an ImPlot3DColormap_ enum or an index returned by AddColormap<br/>
		/// </summary>
		public ImPlot3DColormap Colormap;
	}

	public unsafe partial struct ImPlot3DStylePtr
	{
		public ImPlot3DStyle* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlot3DStyle this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImPlot3DStylePtr(ImPlot3DStyle* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DStylePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DStyle*)nativePtr;
		public static implicit operator ImPlot3DStylePtr(ImPlot3DStyle* ptr) => new ImPlot3DStylePtr(ptr);
		public static implicit operator ImPlot3DStylePtr(IntPtr ptr) => new ImPlot3DStylePtr(ptr);
		public static implicit operator ImPlot3DStyle*(ImPlot3DStylePtr nativePtr) => nativePtr.NativePtr;
	}
}

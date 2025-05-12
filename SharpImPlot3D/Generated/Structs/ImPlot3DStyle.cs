using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

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
		/// <summary>
		/// <br/>    Item style<br/>
		/// Line weight in pixels<br/>
		/// </summary>
		public ref float LineWeight => ref Unsafe.AsRef<float>(&NativePtr->LineWeight);
		/// <summary>
		/// Default marker type (ImPlot3DMarker_None)<br/>
		/// </summary>
		public ref int Marker => ref Unsafe.AsRef<int>(&NativePtr->Marker);
		/// <summary>
		/// Marker size in pixels (roughly the marker's "radius")<br/>
		/// </summary>
		public ref float MarkerSize => ref Unsafe.AsRef<float>(&NativePtr->MarkerSize);
		/// <summary>
		/// Marker outline weight in pixels<br/>
		/// </summary>
		public ref float MarkerWeight => ref Unsafe.AsRef<float>(&NativePtr->MarkerWeight);
		/// <summary>
		/// Alpha modifier applied to plot fills<br/>
		/// </summary>
		public ref float FillAlpha => ref Unsafe.AsRef<float>(&NativePtr->FillAlpha);
		/// <summary>
		/// <br/>    Plot style<br/>
		/// </summary>
		public ref Vector2 PlotDefaultSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotDefaultSize);
		public ref Vector2 PlotMinSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotMinSize);
		public ref Vector2 PlotPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotPadding);
		public ref Vector2 LabelPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LabelPadding);
		/// <summary>
		/// <br/>    Legend style<br/>
		/// Legend padding from plot edges<br/>
		/// </summary>
		public ref Vector2 LegendPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendPadding);
		/// <summary>
		/// Legend inner padding from legend edges<br/>
		/// </summary>
		public ref Vector2 LegendInnerPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendInnerPadding);
		/// <summary>
		/// Spacing between legend entries<br/>
		/// </summary>
		public ref Vector2 LegendSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendSpacing);
		/// <summary>
		/// <br/>    Colors<br/>
		/// </summary>
		public Span<Vector4> Colors => new Span<Vector4>(&NativePtr->Colors_0, 15);
		/// <summary>
		/// <br/>    Colormap<br/>
		/// The current colormap. Set this to either an ImPlot3DColormap_ enum or an index returned by AddColormap<br/>
		/// </summary>
		public ref ImPlot3DColormap Colormap => ref Unsafe.AsRef<ImPlot3DColormap>(&NativePtr->Colormap);
		public ImPlot3DStylePtr(ImPlot3DStyle* nativePtr) => NativePtr = nativePtr;
		public ImPlot3DStylePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DStyle*)nativePtr;
		public static implicit operator ImPlot3DStylePtr(ImPlot3DStyle* ptr) => new ImPlot3DStylePtr(ptr);
		public static implicit operator ImPlot3DStylePtr(IntPtr ptr) => new ImPlot3DStylePtr(ptr);
		public static implicit operator ImPlot3DStyle*(ImPlot3DStylePtr nativePtr) => nativePtr.NativePtr;
		public void StyleDestroy()
		{
			ImPlot3DNative.StyleDestroy(NativePtr);
		}

		public ImPlot3DStylePtr StyleStyle()
		{
			return ImPlot3DNative.StyleStyle();
		}

	}
}

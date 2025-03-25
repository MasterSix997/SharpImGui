using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Data shared between all ImDrawList instances<br/>
	/// Conceptually this could have been called e.g. ImDrawListSharedContext<br/>
	/// Typically one ImGui context would create and maintain one of this.<br/>
	/// You may want to create your own instance of you try to ImDrawList completely without ImGui. In that case, watch out for future changes to this structure.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawListSharedData
	{
		/// <summary>
		/// UV of white pixel in the atlas<br/>
		/// </summary>
		public Vector2 TexUvWhitePixel;
		/// <summary>
		/// UV of anti-aliased lines in the atlas<br/>
		/// </summary>
		public unsafe Vector4* TexUvLines;
		/// <summary>
		/// Current/default font (optional, for simplified AddText overload)<br/>
		/// </summary>
		public unsafe ImFont* Font;
		/// <summary>
		/// Current/default font size (optional, for simplified AddText overload)<br/>
		/// </summary>
		public float FontSize;
		/// <summary>
		/// Current/default font scale (== FontSize / Font->FontSize)<br/>
		/// </summary>
		public float FontScale;
		/// <summary>
		/// Tessellation tolerance when using PathBezierCurveTo()<br/>
		/// </summary>
		public float CurveTessellationTol;
		/// <summary>
		/// Number of circle segments to use per pixel of radius for AddCircle() etc<br/>
		/// </summary>
		public float CircleSegmentMaxError;
		/// <summary>
		/// Value for PushClipRectFullscreen()<br/>
		/// </summary>
		public Vector4 ClipRectFullscreen;
		/// <summary>
		/// Initial flags at the beginning of the frame (it is possible to alter flags on a per-drawlist basis afterwards)<br/>
		/// </summary>
		public ImDrawListFlags InitialFlags;
		/// <summary>
		/// Temporary write buffer<br/>
		/// </summary>
		public ImVector<Vector2> TempBuffer;
		/// <summary>
		///     Lookup tables<br/>
		/// Sample points on the quarter of the circle.<br/>
		/// </summary>
		public Vector2 ArcFastVtx_0;
		public Vector2 ArcFastVtx_1;
		public Vector2 ArcFastVtx_2;
		public Vector2 ArcFastVtx_3;
		public Vector2 ArcFastVtx_4;
		public Vector2 ArcFastVtx_5;
		public Vector2 ArcFastVtx_6;
		public Vector2 ArcFastVtx_7;
		public Vector2 ArcFastVtx_8;
		public Vector2 ArcFastVtx_9;
		public Vector2 ArcFastVtx_10;
		public Vector2 ArcFastVtx_11;
		public Vector2 ArcFastVtx_12;
		public Vector2 ArcFastVtx_13;
		public Vector2 ArcFastVtx_14;
		public Vector2 ArcFastVtx_15;
		public Vector2 ArcFastVtx_16;
		public Vector2 ArcFastVtx_17;
		public Vector2 ArcFastVtx_18;
		public Vector2 ArcFastVtx_19;
		public Vector2 ArcFastVtx_20;
		public Vector2 ArcFastVtx_21;
		public Vector2 ArcFastVtx_22;
		public Vector2 ArcFastVtx_23;
		public Vector2 ArcFastVtx_24;
		public Vector2 ArcFastVtx_25;
		public Vector2 ArcFastVtx_26;
		public Vector2 ArcFastVtx_27;
		public Vector2 ArcFastVtx_28;
		public Vector2 ArcFastVtx_29;
		public Vector2 ArcFastVtx_30;
		public Vector2 ArcFastVtx_31;
		public Vector2 ArcFastVtx_32;
		public Vector2 ArcFastVtx_33;
		public Vector2 ArcFastVtx_34;
		public Vector2 ArcFastVtx_35;
		public Vector2 ArcFastVtx_36;
		public Vector2 ArcFastVtx_37;
		public Vector2 ArcFastVtx_38;
		public Vector2 ArcFastVtx_39;
		public Vector2 ArcFastVtx_40;
		public Vector2 ArcFastVtx_41;
		public Vector2 ArcFastVtx_42;
		public Vector2 ArcFastVtx_43;
		public Vector2 ArcFastVtx_44;
		public Vector2 ArcFastVtx_45;
		public Vector2 ArcFastVtx_46;
		public Vector2 ArcFastVtx_47;
		/// <summary>
		/// Cutoff radius after which arc drawing will fallback to slower PathArcTo()<br/>
		/// </summary>
		public float ArcFastRadiusCutoff;
		/// <summary>
		/// Precomputed segment count for given radius before we calculate it dynamically (to avoid calculation overhead)<br/>
		/// </summary>
		public byte CircleSegmentCounts_0;
		public byte CircleSegmentCounts_1;
		public byte CircleSegmentCounts_2;
		public byte CircleSegmentCounts_3;
		public byte CircleSegmentCounts_4;
		public byte CircleSegmentCounts_5;
		public byte CircleSegmentCounts_6;
		public byte CircleSegmentCounts_7;
		public byte CircleSegmentCounts_8;
		public byte CircleSegmentCounts_9;
		public byte CircleSegmentCounts_10;
		public byte CircleSegmentCounts_11;
		public byte CircleSegmentCounts_12;
		public byte CircleSegmentCounts_13;
		public byte CircleSegmentCounts_14;
		public byte CircleSegmentCounts_15;
		public byte CircleSegmentCounts_16;
		public byte CircleSegmentCounts_17;
		public byte CircleSegmentCounts_18;
		public byte CircleSegmentCounts_19;
		public byte CircleSegmentCounts_20;
		public byte CircleSegmentCounts_21;
		public byte CircleSegmentCounts_22;
		public byte CircleSegmentCounts_23;
		public byte CircleSegmentCounts_24;
		public byte CircleSegmentCounts_25;
		public byte CircleSegmentCounts_26;
		public byte CircleSegmentCounts_27;
		public byte CircleSegmentCounts_28;
		public byte CircleSegmentCounts_29;
		public byte CircleSegmentCounts_30;
		public byte CircleSegmentCounts_31;
		public byte CircleSegmentCounts_32;
		public byte CircleSegmentCounts_33;
		public byte CircleSegmentCounts_34;
		public byte CircleSegmentCounts_35;
		public byte CircleSegmentCounts_36;
		public byte CircleSegmentCounts_37;
		public byte CircleSegmentCounts_38;
		public byte CircleSegmentCounts_39;
		public byte CircleSegmentCounts_40;
		public byte CircleSegmentCounts_41;
		public byte CircleSegmentCounts_42;
		public byte CircleSegmentCounts_43;
		public byte CircleSegmentCounts_44;
		public byte CircleSegmentCounts_45;
		public byte CircleSegmentCounts_46;
		public byte CircleSegmentCounts_47;
		public byte CircleSegmentCounts_48;
		public byte CircleSegmentCounts_49;
		public byte CircleSegmentCounts_50;
		public byte CircleSegmentCounts_51;
		public byte CircleSegmentCounts_52;
		public byte CircleSegmentCounts_53;
		public byte CircleSegmentCounts_54;
		public byte CircleSegmentCounts_55;
		public byte CircleSegmentCounts_56;
		public byte CircleSegmentCounts_57;
		public byte CircleSegmentCounts_58;
		public byte CircleSegmentCounts_59;
		public byte CircleSegmentCounts_60;
		public byte CircleSegmentCounts_61;
		public byte CircleSegmentCounts_62;
		public byte CircleSegmentCounts_63;
	}
}

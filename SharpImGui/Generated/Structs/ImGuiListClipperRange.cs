using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Note that Max is exclusive, so perhaps should be using a Begin/End convention.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperRange
	{
		public int Min;
		public int Max;
		/// <summary>
		/// Begin/End are absolute position (will be converted to indices later)<br/>
		/// </summary>
		public byte PosToIndexConvert;
		/// <summary>
		/// Add to Min after converting to indices<br/>
		/// </summary>
		public sbyte PosToIndexOffsetMin;
		/// <summary>
		/// Add to Min after converting to indices<br/>
		/// </summary>
		public sbyte PosToIndexOffsetMax;
	}
}

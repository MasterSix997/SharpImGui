using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Type information associated to one ImGuiDataType. Retrieve with DataTypeGetInfo().<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataTypeInfo
	{
		/// <summary>
		/// Size in bytes<br/>
		/// </summary>
		public uint Size;
		/// <summary>
		/// Short descriptive name for the type, for debugging<br/>
		/// </summary>
		public unsafe byte* Name;
		/// <summary>
		/// Default printf format for the type<br/>
		/// </summary>
		public unsafe byte* PrintFmt;
		/// <summary>
		/// Default scanf format for the type<br/>
		/// </summary>
		public unsafe byte* ScanFmt;
	}
}

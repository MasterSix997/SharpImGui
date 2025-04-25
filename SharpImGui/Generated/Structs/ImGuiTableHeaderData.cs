using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Parameters for TableAngledHeadersRowEx()<br/>This may end up being refactored for more general purpose.<br/>sizeof() ~ 12 bytes<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableHeaderData
	{
		/// <summary>
		/// Column index<br/>
		/// </summary>
		public short Index;
		public uint TextColor;
		public uint BgColor0;
		public uint BgColor1;
	}

	/// <summary>
	/// Parameters for TableAngledHeadersRowEx()<br/>This may end up being refactored for more general purpose.<br/>sizeof() ~ 12 bytes<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableHeaderDataPtr
	{
		public ImGuiTableHeaderData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableHeaderData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableHeaderDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableHeaderData*)nativePtr;
		public static implicit operator ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* ptr) => new ImGuiTableHeaderDataPtr(ptr);
		public static implicit operator ImGuiTableHeaderDataPtr(IntPtr ptr) => new ImGuiTableHeaderDataPtr(ptr);
		public static implicit operator ImGuiTableHeaderData*(ImGuiTableHeaderDataPtr nativePtr) => nativePtr.NativePtr;
	}
}

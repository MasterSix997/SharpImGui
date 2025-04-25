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

	/// <summary>
	/// Type information associated to one ImGuiDataType. Retrieve with DataTypeGetInfo().<br/>
	/// </summary>
	public unsafe partial struct ImGuiDataTypeInfoPtr
	{
		public ImGuiDataTypeInfo* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDataTypeInfo this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiDataTypeInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeInfo*)nativePtr;
		public static implicit operator ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* ptr) => new ImGuiDataTypeInfoPtr(ptr);
		public static implicit operator ImGuiDataTypeInfoPtr(IntPtr ptr) => new ImGuiDataTypeInfoPtr(ptr);
		public static implicit operator ImGuiDataTypeInfo*(ImGuiDataTypeInfoPtr nativePtr) => nativePtr.NativePtr;
	}
}

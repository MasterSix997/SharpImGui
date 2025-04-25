using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() ~ 16<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSettings
	{
		public float WidthOrWeight;
		public uint UserID;
		public short Index;
		public short DisplayOrder;
		public short SortOrder;
		public byte SortDirection;
		/// <summary>
		/// "Visible" in ini file<br/>
		/// </summary>
		public sbyte IsEnabled;
		public byte IsStretch;
	}

	/// <summary>
	/// sizeof() ~ 16<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSettingsPtr
	{
		public ImGuiTableColumnSettings* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableColumnSettings this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSettings*)nativePtr;
		public static implicit operator ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* ptr) => new ImGuiTableColumnSettingsPtr(ptr);
		public static implicit operator ImGuiTableColumnSettingsPtr(IntPtr ptr) => new ImGuiTableColumnSettingsPtr(ptr);
		public static implicit operator ImGuiTableColumnSettings*(ImGuiTableColumnSettingsPtr nativePtr) => nativePtr.NativePtr;
	}
}

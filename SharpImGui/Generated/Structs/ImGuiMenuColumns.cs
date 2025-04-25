using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMenuColumns
	{
		public uint TotalWidth;
		public uint NextTotalWidth;
		public ushort Spacing;
		/// <summary>
		/// Always zero for now<br/>
		/// </summary>
		public ushort OffsetIcon;
		/// <summary>
		/// Offsets are locked in Update()<br/>
		/// </summary>
		public ushort OffsetLabel;
		public ushort OffsetShortcut;
		public ushort OffsetMark;
		/// <summary>
		/// Width of:   Icon, Label, Shortcut, Mark  (accumulators for current frame)<br/>
		/// </summary>
		public ushort Widths_0;
		public ushort Widths_1;
		public ushort Widths_2;
		public ushort Widths_3;
	}

	/// <summary>
	/// Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.<br/>
	/// </summary>
	public unsafe partial struct ImGuiMenuColumnsPtr
	{
		public ImGuiMenuColumns* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiMenuColumns this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => NativePtr = nativePtr;
		public ImGuiMenuColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiMenuColumns*)nativePtr;
		public static implicit operator ImGuiMenuColumnsPtr(ImGuiMenuColumns* ptr) => new ImGuiMenuColumnsPtr(ptr);
		public static implicit operator ImGuiMenuColumnsPtr(IntPtr ptr) => new ImGuiMenuColumnsPtr(ptr);
		public static implicit operator ImGuiMenuColumns*(ImGuiMenuColumnsPtr nativePtr) => nativePtr.NativePtr;
	}
}

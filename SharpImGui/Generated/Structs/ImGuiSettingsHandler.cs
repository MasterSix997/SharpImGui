using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSettingsHandler
	{
		/// <summary>
		/// Short description stored in .ini file. Disallowed characters: '[' ']'<br/>
		/// </summary>
		public unsafe byte* TypeName;
		/// <summary>
		/// == ImHashStr(TypeName)<br/>
		/// </summary>
		public uint TypeHash;
		/// <summary>
		/// Clear all settings data<br/>
		/// </summary>
		public unsafe void* ClearAllFn;
		/// <summary>
		/// Read: Called before reading (in registration order)<br/>
		/// </summary>
		public unsafe void* ReadInitFn;
		/// <summary>
		/// Read: Called when entering into a new ini entry e.g. "[Window][Name]"<br/>
		/// </summary>
		public unsafe void* ReadOpenFn;
		/// <summary>
		/// Read: Called for every line of text within an ini entry<br/>
		/// </summary>
		public unsafe void* ReadLineFn;
		/// <summary>
		/// Read: Called after reading (in registration order)<br/>
		/// </summary>
		public unsafe void* ApplyAllFn;
		/// <summary>
		/// Write: Output every entries into 'out_buf'<br/>
		/// </summary>
		public unsafe void* WriteAllFn;
		public unsafe void* UserData;
	}

	public unsafe partial struct ImGuiSettingsHandlerPtr
	{
		public ImGuiSettingsHandler* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiSettingsHandler this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => NativePtr = nativePtr;
		public ImGuiSettingsHandlerPtr(IntPtr nativePtr) => NativePtr = (ImGuiSettingsHandler*)nativePtr;
		public static implicit operator ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* ptr) => new ImGuiSettingsHandlerPtr(ptr);
		public static implicit operator ImGuiSettingsHandlerPtr(IntPtr ptr) => new ImGuiSettingsHandlerPtr(ptr);
		public static implicit operator ImGuiSettingsHandler*(ImGuiSettingsHandlerPtr nativePtr) => nativePtr.NativePtr;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSettingsHandler
	{
		/// <summary>
		/// // Short description stored in .ini file. Disallowed characters: '[' ']'
		/// </summary>
		public unsafe byte* TypeName;
		/// <summary>
		/// // == ImHashStr(TypeName)
		/// </summary>
		public uint TypeHash;
		/// <summary>
		/// // Clear all settings data
		/// </summary>
		public unsafe void* ClearAllFn;
		/// <summary>
		/// // Read: Called before reading (in registration order)
		/// </summary>
		public unsafe void* ReadInitFn;
		/// <summary>
		/// // Read: Called when entering into a new ini entry e.g. "[Window][Name]"
		/// </summary>
		public unsafe void* ReadOpenFn;
		/// <summary>
		/// // Read: Called for every line of text within an ini entry
		/// </summary>
		public unsafe void* ReadLineFn;
		/// <summary>
		/// // Read: Called after reading (in registration order)
		/// </summary>
		public unsafe void* ApplyAllFn;
		/// <summary>
		/// // Write: Output every entries into 'out_buf'
		/// </summary>
		public unsafe void* WriteAllFn;
		public unsafe void* UserData;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSettingsHandler
	{
		public unsafe byte* TypeName;
		public uint TypeHash;
		public unsafe void* ClearAllFn;
		public unsafe void* ReadInitFn;
		public unsafe void* ReadOpenFn;
		public unsafe void* ReadLineFn;
		public unsafe void* ApplyAllFn;
		public unsafe void* WriteAllFn;
		public unsafe void* UserData;
	}
}

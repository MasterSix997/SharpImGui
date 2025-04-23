using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiContextHook
	{
		/// <summary>
		/// A unique ID assigned by AddContextHook()<br/>
		/// </summary>
		public uint HookId;
		public ImGuiContextHookType Type;
		public uint Owner;
		public unsafe void* Callback;
		public unsafe void* UserData;
	}
}

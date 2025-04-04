using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEvent
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiInputEventUnion
		{
			[FieldOffset(0)]
			public ImGuiInputEventMousePos MousePos;
			[FieldOffset(0)]
			public ImGuiInputEventMouseWheel MouseWheel;
			[FieldOffset(0)]
			public ImGuiInputEventMouseButton MouseButton;
			[FieldOffset(0)]
			public ImGuiInputEventMouseViewport MouseViewport;
			[FieldOffset(0)]
			public ImGuiInputEventKey Key;
			[FieldOffset(0)]
			public ImGuiInputEventText Text;
			[FieldOffset(0)]
			public ImGuiInputEventAppFocused AppFocused;
		}
		public ImGuiInputEventType Type;
		public ImGuiInputSource Source;
		/// <summary>
		/// // Unique, sequential increasing integer to identify an event (if you need to correlate them to other data).
		/// </summary>
		public uint EventId;
		/// <summary>
		/// // if Type == ImGuiInputEventType_MousePos// if Type == ImGuiInputEventType_MouseWheel// if Type == ImGuiInputEventType_MouseButton// if Type == ImGuiInputEventType_MouseViewport// if Type == ImGuiInputEventType_Key// if Type == ImGuiInputEventType_Text// if Type == ImGuiInputEventType_Focus
		/// </summary>
		public ImGuiInputEventUnion Union;
		public byte AddedByTestEngine;
	}
}

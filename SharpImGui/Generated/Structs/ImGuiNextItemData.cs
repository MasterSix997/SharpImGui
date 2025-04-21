using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextItemData
	{
		public ImGuiNextItemDataFlags HasFlags;
		public ImGuiItemFlags ItemFlags;
		public uint FocusScopeId;
		public long SelectionUserData;
		public float Width;
		public ImGuiKey Shortcut;
		public ImGuiInputFlags ShortcutFlags;
		public byte OpenVal;
		public byte OpenCond;
		public ImGuiDataTypeStorage RefVal;
		public uint StorageId;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionBasicStorage
	{
		public int Size;
		public byte PreserveOrder;
		public unsafe void* UserData;
		public unsafe void* AdapterIndexToStorageId;
		public int _SelectionOrder;
		public ImGuiStorage _Storage;
	}
}

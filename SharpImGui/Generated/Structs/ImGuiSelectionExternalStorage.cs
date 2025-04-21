using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionExternalStorage
	{
		public unsafe void* UserData;
		public unsafe void* AdapterSetItemSelected;
	}
}

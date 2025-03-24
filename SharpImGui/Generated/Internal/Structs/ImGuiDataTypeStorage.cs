using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataTypeStorage
	{
		/// <summary>
		/// // Opaque storage to fit any data up to ImGuiDataType_COUNT
		/// </summary>
		public byte Data_0;
		public byte Data_1;
		public byte Data_2;
		public byte Data_3;
		public byte Data_4;
		public byte Data_5;
		public byte Data_6;
		public byte Data_7;
	}
}

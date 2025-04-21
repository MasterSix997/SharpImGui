using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPayload
	{
		public unsafe void* Data;
		public int DataSize;
		public uint SourceId;
		public uint SourceParentId;
		public int DataFrameCount;
		public byte DataType_0;
		public byte DataType_1;
		public byte DataType_2;
		public byte DataType_3;
		public byte DataType_4;
		public byte DataType_5;
		public byte DataType_6;
		public byte DataType_7;
		public byte DataType_8;
		public byte DataType_9;
		public byte DataType_10;
		public byte DataType_11;
		public byte DataType_12;
		public byte DataType_13;
		public byte DataType_14;
		public byte DataType_15;
		public byte DataType_16;
		public byte DataType_17;
		public byte DataType_18;
		public byte DataType_19;
		public byte DataType_20;
		public byte DataType_21;
		public byte DataType_22;
		public byte DataType_23;
		public byte DataType_24;
		public byte DataType_25;
		public byte DataType_26;
		public byte DataType_27;
		public byte DataType_28;
		public byte DataType_29;
		public byte DataType_30;
		public byte DataType_31;
		public byte DataType_32;
		public byte Preview;
		public byte Delivery;
	}
}

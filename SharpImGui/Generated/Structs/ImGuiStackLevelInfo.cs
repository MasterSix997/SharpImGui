using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStackLevelInfo
	{
		public uint ID;
		/// <summary>
		/// >= 1: Query in progress<br/>
		/// </summary>
		public sbyte QueryFrameCount;
		/// <summary>
		/// Obtained result from DebugHookIdInfo()<br/>
		/// </summary>
		public byte QuerySuccess;
		public ImGuiDataType DataType;
		/// <summary>
		/// Arbitrarily sized buffer to hold a result (FIXME: could replace Results[] with a chunk stream?) FIXME: Now that we added CTRL+C this should be fixed.<br/>
		/// </summary>
		public byte Desc_0;
		public byte Desc_1;
		public byte Desc_2;
		public byte Desc_3;
		public byte Desc_4;
		public byte Desc_5;
		public byte Desc_6;
		public byte Desc_7;
		public byte Desc_8;
		public byte Desc_9;
		public byte Desc_10;
		public byte Desc_11;
		public byte Desc_12;
		public byte Desc_13;
		public byte Desc_14;
		public byte Desc_15;
		public byte Desc_16;
		public byte Desc_17;
		public byte Desc_18;
		public byte Desc_19;
		public byte Desc_20;
		public byte Desc_21;
		public byte Desc_22;
		public byte Desc_23;
		public byte Desc_24;
		public byte Desc_25;
		public byte Desc_26;
		public byte Desc_27;
		public byte Desc_28;
		public byte Desc_29;
		public byte Desc_30;
		public byte Desc_31;
		public byte Desc_32;
		public byte Desc_33;
		public byte Desc_34;
		public byte Desc_35;
		public byte Desc_36;
		public byte Desc_37;
		public byte Desc_38;
		public byte Desc_39;
		public byte Desc_40;
		public byte Desc_41;
		public byte Desc_42;
		public byte Desc_43;
		public byte Desc_44;
		public byte Desc_45;
		public byte Desc_46;
		public byte Desc_47;
		public byte Desc_48;
		public byte Desc_49;
		public byte Desc_50;
		public byte Desc_51;
		public byte Desc_52;
		public byte Desc_53;
		public byte Desc_54;
		public byte Desc_55;
		public byte Desc_56;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Data payload for Drag and Drop operations: AcceptDragDropPayload(), GetDragDropPayload()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPayload
	{
		/// <summary>
		/// <br/>
		///     // Members<br/>
		/// Data (copied and owned by dear imgui)<br/>
		/// </summary>
		public unsafe void* Data;
		/// <summary>
		/// Data size<br/>
		/// </summary>
		public int DataSize;
		/// <summary>
		///     // [Internal]<br/>
		/// Source item id<br/>
		/// </summary>
		public uint SourceId;
		/// <summary>
		/// Source parent id (if available)<br/>
		/// </summary>
		public uint SourceParentId;
		/// <summary>
		/// Data timestamp<br/>
		/// </summary>
		public int DataFrameCount;
		/// <summary>
		/// Data type tag (short user-supplied string, 32 characters max)<br/>
		/// </summary>
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
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse has been hovering the target item (nb: handle overlapping drag targets)<br/>
		/// </summary>
		public byte Preview;
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse button is released over the target item.<br/>
		/// </summary>
		public byte Delivery;
	}
}

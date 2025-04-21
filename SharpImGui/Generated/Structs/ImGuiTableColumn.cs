using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumn
	{
		public ImGuiTableColumnFlags Flags;
		public float WidthGiven;
		public float MinX;
		public float MaxX;
		public float WidthRequest;
		public float WidthAuto;
		public float WidthMax;
		public float StretchWeight;
		public float InitStretchWeightOrWidth;
		public ImRect ClipRect;
		public uint UserID;
		public float WorkMinX;
		public float WorkMaxX;
		public float ItemWidth;
		public float ContentMaxXFrozen;
		public float ContentMaxXUnfrozen;
		public float ContentMaxXHeadersUsed;
		public float ContentMaxXHeadersIdeal;
		public short NameOffset;
		public short DisplayOrder;
		public short IndexWithinEnabledSet;
		public short PrevEnabledColumn;
		public short NextEnabledColumn;
		public short SortOrder;
		public ushort DrawChannelCurrent;
		public ushort DrawChannelFrozen;
		public ushort DrawChannelUnfrozen;
		public byte IsEnabled;
		public byte IsUserEnabled;
		public byte IsUserEnabledNextFrame;
		public byte IsVisibleX;
		public byte IsVisibleY;
		public byte IsRequestOutput;
		public byte IsSkipItems;
		public byte IsPreserveWidthAuto;
		public sbyte NavLayerCurrent;
		public byte AutoFitQueue;
		public byte CannotSkipItemsQueue;
		public byte SortDirection;
		public byte SortDirectionsAvailCount;
		public byte SortDirectionsAvailMask;
		public byte SortDirectionsAvailList;
	}
}

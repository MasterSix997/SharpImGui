using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Selection request item<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionRequest
	{
		/// <summary>
		/// <br/>
		///     //------------------------------------------BeginMultiSelect / EndMultiSelect<br/>
		///  ms:w, app:r     /  ms:w, app:r   Request type. You'll most often receive 1 Clear + 1 SetRange with a single-item range.<br/>
		/// </summary>
		public ImGuiSelectionRequestType Type;
		/// <summary>
		///  ms:w, app:r     /  ms:w, app:r   Parameter for SetAll/SetRange requests (true = select, false = unselect)<br/>
		/// </summary>
		public byte Selected;
		/// <summary>
		///                  /  ms:w  app:r   Parameter for SetRange request: +1 when RangeFirstItem comes before RangeLastItem, -1 otherwise. Useful if you want to preserve selection order on a backward Shift+Click.<br/>
		/// </summary>
		public sbyte RangeDirection;
		/// <summary>
		///                  /  ms:w, app:r   Parameter for SetRange request (this is generally == RangeSrcItem when shift selecting from top to bottom).<br/>
		/// </summary>
		public long RangeFirstItem;
		/// <summary>
		///                  /  ms:w, app:r   Parameter for SetRange request (this is generally == RangeSrcItem when shift selecting from bottom to top). Inclusive!<br/>
		/// </summary>
		public long RangeLastItem;
	}
}

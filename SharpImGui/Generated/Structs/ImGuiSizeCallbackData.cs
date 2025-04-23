using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Resizing callback data to apply custom constraint. As enabled by SetNextWindowSizeConstraints(). Callback is called during the next Begin().<br/>
	/// NB: For basic min/max size constraint on each axis you don't need to use the callback! The SetNextWindowSizeConstraints() parameters are enough.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSizeCallbackData
	{
		/// <summary>
		/// Read-only.   What user passed to SetNextWindowSizeConstraints(). Generally store an integer or float in here (need reinterpret_cast<>).<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		/// Read-only.   Window position, for reference.<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Read-only.   Current window size.<br/>
		/// </summary>
		public Vector2 CurrentSize;
		/// <summary>
		/// Read-write.  Desired size, based on user's mouse position. Write to this field to restrain resizing.<br/>
		/// </summary>
		public Vector2 DesiredSize;
	}
}

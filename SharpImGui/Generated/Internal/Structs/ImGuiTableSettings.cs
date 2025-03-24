using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// This is designed to be stored in a single ImChunkStream (1 header followed by N ImGuiTableColumnSettings, etc.)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableSettings
	{
		/// <summary>
		/// Set to 0 to invalidate/delete the setting<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// Indicate data we want to save using the Resizable/Reorderable/Sortable/Hideable flags (could be using its own flags..)<br/>
		/// </summary>
		public ImGuiTableFlags SaveFlags;
		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.<br/>
		/// </summary>
		public float RefScale;
		public short ColumnsCount;
		/// <summary>
		/// Maximum number of columns this settings instance can store, we can recycle a settings instance with lower number of columns but not higher<br/>
		/// </summary>
		public short ColumnsCountMax;
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)<br/>
		/// </summary>
		public byte WantApply;
	}
}

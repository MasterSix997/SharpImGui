using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImBitVector<br/>
	/// Store 1-bit per value.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImBitVector
	{
		public ImVector<uint> Storage;
	}
}

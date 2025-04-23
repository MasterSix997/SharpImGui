using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// This extends ImGuiKeyData but only for named keys (legacy keys don't support the new features)<br/>
	/// Stored in main context (1 per named key). In the future it might be merged into ImGuiKeyData.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyOwnerData
	{
		public uint OwnerCurr;
		public uint OwnerNext;
		/// <summary>
		/// Reading this key requires explicit owner id (until end of frame). Set by ImGuiInputFlags_LockThisFrame.<br/>
		/// </summary>
		public byte LockThisFrame;
		/// <summary>
		/// Reading this key requires explicit owner id (until key is released). Set by ImGuiInputFlags_LockUntilRelease. When this is true LockThisFrame is always true as well.<br/>
		/// </summary>
		public byte LockUntilRelease;
	}
}

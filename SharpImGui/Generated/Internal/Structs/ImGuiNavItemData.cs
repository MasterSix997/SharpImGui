using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage for navigation query/results<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNavItemData
	{
		/// <summary>
		/// Init,Move    // Best candidate window (result->ItemWindow->RootWindowForNav == request->Window)<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		/// <summary>
		/// Init,Move    // Best candidate item ID<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// Init,Move    // Best candidate focus scope ID<br/>
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// Init,Move    // Best candidate bounding box in window relative space<br/>
		/// </summary>
		public ImRect RectRel;
		/// <summary>
		/// ????,Move    // Best candidate item flags<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		///      Move    // Best candidate box distance to current NavId<br/>
		/// </summary>
		public float DistBox;
		/// <summary>
		///      Move    // Best candidate center distance to current NavId<br/>
		/// </summary>
		public float DistCenter;
		/// <summary>
		///      Move    // Best candidate axial distance to current NavId<br/>
		/// </summary>
		public float DistAxial;
		/// <summary>
		/// //I+Mov    // Best candidate SetNextItemSelectionUserData() value. Valid if (ItemFlags & ImGuiItemFlags_HasSelectionUserData)<br/>
		/// </summary>
		public long SelectionUserData;
	}
}

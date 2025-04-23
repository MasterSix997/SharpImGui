using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Optional helper to apply multi-selection requests to existing randomly accessible storage.<br/>
	/// Convenient if you want to quickly wire multi-select API on e.g. an array of bool or items storing their own selection state.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionExternalStorage
	{
		/// <summary>
		/// <br/>
		///     Members<br/>
		/// User data for use by adapter function                                e.g. selection.UserData = (void*)my_items;<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		/// e.g. AdapterSetItemSelected = [](ImGuiSelectionExternalStorage* self, int idx, bool selected)  ((MyItems**)self->UserData)[idx]->Selected = selected; <br/>
		/// </summary>
		public unsafe void* AdapterSetItemSelected;
	}
}

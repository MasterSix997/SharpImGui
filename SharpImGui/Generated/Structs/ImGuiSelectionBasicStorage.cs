using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Optional helper to store multi-selection state + apply multi-selection requests.<br/>
	/// - Used by our demos and provided as a convenience to easily implement basic multi-selection.<br/>
	/// - Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
	///   Or you can check 'if (Contains(id))  ... ' for each possible object if their number is not too high to iterate.<br/>
	/// - USING THIS IS NOT MANDATORY. This is only a helper and not a required API.<br/>
	/// To store a multi-selection, in your application you could:<br/>
	/// - Use this helper as a convenience. We use our simple key->value ImGuiStorage as a std::set<ImGuiID> replacement.<br/>
	/// - Use your own external storage: e.g. std::set<MyObjectId>, std::vector<MyObjectId>, interval trees, intrusively stored selection etc.<br/>
	/// In ImGuiSelectionBasicStorage we:<br/>
	/// - always use indices in the multi-selection API (passed to SetNextItemSelectionUserData(), retrieved in ImGuiMultiSelectIO)<br/>
	/// - use the AdapterIndexToStorageId() indirection layer to abstract how persistent selection data is derived from an index.<br/>
	/// - use decently optimized logic to allow queries and insertion of very large selection sets.<br/>
	/// - do not preserve selection order.<br/>
	/// Many combinations are possible depending on how you prefer to store your items and how you prefer to store your selection.<br/>
	/// Large applications are likely to eventually want to get rid of this indirection layer and do their own thing.<br/>
	/// See https://github.com/ocornut/imgui/wiki/Multi-Select for details and pseudo-code using this helper.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionBasicStorage
	{
		/// <summary>
		/// <br/>
		///     Members<br/>
		///          Number of selected items, maintained by this helper.<br/>
		/// </summary>
		public int Size;
		/// <summary>
		/// = false  GetNextSelectedItem() will return ordered selection (currently implemented by two additional sorts of selection. Could be improved)<br/>
		/// </summary>
		public byte PreserveOrder;
		/// <summary>
		/// = NULL   User data for use by adapter function        e.g. selection.UserData = (void*)my_items;<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		/// e.g. selection.AdapterIndexToStorageId = [](ImGuiSelectionBasicStorage* self, int idx)  return ((MyItems**)self->UserData)[idx]->ID; ;<br/>
		/// </summary>
		public unsafe void* AdapterIndexToStorageId;
		/// <summary>
		/// [Internal] Increasing counter to store selection order<br/>
		/// </summary>
		public int _SelectionOrder;
		/// <summary>
		/// [Internal] Selection set. Think of this as similar to e.g. std::set<ImGuiID>. Prefer not accessing directly: iterate with GetNextSelectedItem().<br/>
		/// </summary>
		public ImGuiStorage _Storage;
	}
}

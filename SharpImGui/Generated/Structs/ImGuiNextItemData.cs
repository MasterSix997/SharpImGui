using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextItemData
	{
		/// <summary>
		/// Called HasFlags instead of Flags to avoid mistaking this<br/>
		/// </summary>
		public ImGuiNextItemDataFlags HasFlags;
		/// <summary>
		/// Currently only tested/used for ImGuiItemFlags_AllowOverlap and ImGuiItemFlags_HasSelectionUserData.<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		///     Members below are NOT cleared by ItemAdd() meaning they are still valid during e.g. NavProcessItem(). Always rely on HasFlags.<br/>
		/// Set by SetNextItemSelectionUserData()<br/>
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// Set by SetNextItemSelectionUserData() (note that NULL/0 is a valid value, we use -1 == ImGuiSelectionUserData_Invalid to mark invalid values)<br/>
		/// </summary>
		public long SelectionUserData;
		/// <summary>
		/// Set by SetNextItemWidth()<br/>
		/// </summary>
		public float Width;
		/// <summary>
		/// Set by SetNextItemShortcut()<br/>
		/// </summary>
		public ImGuiKey Shortcut;
		/// <summary>
		/// Set by SetNextItemShortcut()<br/>
		/// </summary>
		public ImGuiInputFlags ShortcutFlags;
		/// <summary>
		/// Set by SetNextItemOpen()<br/>
		/// </summary>
		public byte OpenVal;
		/// <summary>
		/// Set by SetNextItemOpen()<br/>
		/// </summary>
		public byte OpenCond;
		/// <summary>
		/// Not exposed yet, for ImGuiInputTextFlags_ParseEmptyAsRefVal<br/>
		/// </summary>
		public ImGuiDataTypeStorage RefVal;
		/// <summary>
		/// Set by SetNextItemStorageID()<br/>
		/// </summary>
		public uint StorageId;
	}
}

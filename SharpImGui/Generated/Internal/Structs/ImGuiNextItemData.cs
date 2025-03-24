using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextItemData
	{
		/// <summary>
		/// // Called HasFlags instead of Flags to avoid mistaking this
		/// </summary>
		public ImGuiNextItemDataFlags HasFlags;
		/// <summary>
		/// // Currently only tested/used for ImGuiItemFlags_AllowOverlap and ImGuiItemFlags_HasSelectionUserData.
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// 
		///     // Non-flags members are NOT cleared by ItemAdd() meaning they are still valid during NavProcessItem()
		/// // Set by SetNextItemSelectionUserData()
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// // Set by SetNextItemSelectionUserData() (note that NULL/0 is a valid value, we use -1 == ImGuiSelectionUserData_Invalid to mark invalid values)
		/// </summary>
		public long SelectionUserData;
		/// <summary>
		/// // Set by SetNextItemWidth()
		/// </summary>
		public float Width;
		/// <summary>
		/// // Set by SetNextItemShortcut()
		/// </summary>
		public ImGuiKey Shortcut;
		/// <summary>
		/// // Set by SetNextItemShortcut()
		/// </summary>
		public ImGuiInputFlags ShortcutFlags;
		/// <summary>
		/// // Set by SetNextItemOpen()
		/// </summary>
		public byte OpenVal;
		/// <summary>
		/// // Set by SetNextItemOpen()
		/// </summary>
		public byte OpenCond;
		/// <summary>
		/// // Not exposed yet, for ImGuiInputTextFlags_ParseEmptyAsRefVal
		/// </summary>
		public ImGuiDataTypeStorage RefVal;
		/// <summary>
		/// // Set by SetNextItemStorageID()
		/// </summary>
		public uint StorageId;
	}
}

using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Store data emitted by TreeNode() for usage by TreePop()<br/>- To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data<br/>  which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().<br/>  Only stored when the node is a potential candidate for landing on a Left arrow jump.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTreeNodeStackData
	{
		public uint ID;
		public ImGuiTreeNodeFlags TreeFlags;
		/// <summary>
		/// Used for nav landing<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// Used for nav landing<br/>
		/// </summary>
		public ImRect NavRect;
	}

	/// <summary>
	/// Store data emitted by TreeNode() for usage by TreePop()<br/>- To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data<br/>  which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().<br/>  Only stored when the node is a potential candidate for landing on a Left arrow jump.<br/>
	/// </summary>
	public unsafe partial struct ImGuiTreeNodeStackDataPtr
	{
		public ImGuiTreeNodeStackData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTreeNodeStackData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTreeNodeStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTreeNodeStackData*)nativePtr;
		public static implicit operator ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* ptr) => new ImGuiTreeNodeStackDataPtr(ptr);
		public static implicit operator ImGuiTreeNodeStackDataPtr(IntPtr ptr) => new ImGuiTreeNodeStackDataPtr(ptr);
		public static implicit operator ImGuiTreeNodeStackData*(ImGuiTreeNodeStackDataPtr nativePtr) => nativePtr.NativePtr;
	}
}

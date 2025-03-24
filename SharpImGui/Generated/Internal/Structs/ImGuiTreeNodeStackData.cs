using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Store data emitted by TreeNode() for usage by TreePop()<br/>
	/// - To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data<br/>
	///   which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().<br/>
	///   Only stored when the node is a potential candidate for landing on a Left arrow jump.<br/>
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
}

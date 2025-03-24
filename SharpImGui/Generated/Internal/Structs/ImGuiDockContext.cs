using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockContext
	{
		/// <summary>
		/// // Map ID -> ImGuiDockNode*: Active nodes
		/// </summary>
		public ImGuiStorage Nodes;
		public ImVector<EmptyStruct> Requests;
		public ImVector<EmptyStruct> NodesSettings;
		public byte WantFullRebuild;
	}
}

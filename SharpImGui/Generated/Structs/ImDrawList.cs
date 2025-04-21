using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawList
	{
		public ImVector<ImDrawCmd> CmdBuffer;
		public ImVector<ushort> IdxBuffer;
		public ImVector<ImDrawVert> VtxBuffer;
		public ImDrawListFlags Flags;
		public uint _VtxCurrentIdx;
		public unsafe ImDrawListSharedData* _Data;
		public unsafe ImDrawVert* _VtxWritePtr;
		public unsafe ushort* _IdxWritePtr;
		public ImVector<Vector2> _Path;
		public ImDrawCmdHeader _CmdHeader;
		public ImDrawListSplitter _Splitter;
		public ImVector<Vector4> _ClipRectStack;
		public ImVector<IntPtr> _TextureIdStack;
		public ImVector<byte> _CallbacksDataBuf;
		public float _FringeScale;
		public unsafe byte* _OwnerName;
	}

	public unsafe struct ImDrawListPtr
	{
		public ImDrawList* NativePtr;
	}
}

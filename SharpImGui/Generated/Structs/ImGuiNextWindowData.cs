using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// Storage for SetNexWindow** functions<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextWindowData
	{
		public ImGuiNextWindowDataFlags HasFlags;
		/// <summary>
		///     Members below are NOT cleared. Always rely on HasFlags.<br/>
		/// </summary>
		public ImGuiCond PosCond;
		public ImGuiCond SizeCond;
		public ImGuiCond CollapsedCond;
		public ImGuiCond DockCond;
		public Vector2 PosVal;
		public Vector2 PosPivotVal;
		public Vector2 SizeVal;
		public Vector2 ContentSizeVal;
		public Vector2 ScrollVal;
		/// <summary>
		/// Only honored by BeginTable()<br/>
		/// </summary>
		public ImGuiWindowFlags WindowFlags;
		public ImGuiChildFlags ChildFlags;
		public byte PosUndock;
		public byte CollapsedVal;
		public ImRect SizeConstraintRect;
		public unsafe void* SizeCallback;
		public unsafe void* SizeCallbackUserData;
		/// <summary>
		/// Override background alpha<br/>
		/// </summary>
		public float BgAlphaVal;
		public uint ViewportId;
		public uint DockId;
		public ImGuiWindowClass WindowClass;
		/// <summary>
		/// (Always on) This is not exposed publicly, so we don't clear it and it doesn't have a corresponding flag (could we? for consistency?)<br/>
		/// </summary>
		public Vector2 MenuBarOffsetMinVal;
		public ImGuiWindowRefreshFlags RefreshFlagsVal;
	}

	/// <summary>
	/// Storage for SetNexWindow** functions<br/>
	/// </summary>
	public unsafe partial struct ImGuiNextWindowDataPtr
	{
		public ImGuiNextWindowData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiNextWindowData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNextWindowDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextWindowData*)nativePtr;
		public static implicit operator ImGuiNextWindowDataPtr(ImGuiNextWindowData* ptr) => new ImGuiNextWindowDataPtr(ptr);
		public static implicit operator ImGuiNextWindowDataPtr(IntPtr ptr) => new ImGuiNextWindowDataPtr(ptr);
		public static implicit operator ImGuiNextWindowData*(ImGuiNextWindowDataPtr nativePtr) => nativePtr.NativePtr;
	}
}

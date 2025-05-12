using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotInputMap
	{
		public ImGuiMouseButton Pan;
		public int PanMod;
		public ImGuiMouseButton Fit;
		public ImGuiMouseButton Select;
		public ImGuiMouseButton SelectCancel;
		public int SelectMod;
		public int SelectHorzMod;
		public int SelectVertMod;
		public ImGuiMouseButton Menu;
		public int OverrideMod;
		public int ZoomMod;
		public float ZoomRate;
	}

	public unsafe partial struct ImPlotInputMapPtr
	{
		public ImPlotInputMap* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotInputMap this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiMouseButton Pan => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Pan);
		public ref int PanMod => ref Unsafe.AsRef<int>(&NativePtr->PanMod);
		public ref ImGuiMouseButton Fit => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Fit);
		public ref ImGuiMouseButton Select => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Select);
		public ref ImGuiMouseButton SelectCancel => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->SelectCancel);
		public ref int SelectMod => ref Unsafe.AsRef<int>(&NativePtr->SelectMod);
		public ref int SelectHorzMod => ref Unsafe.AsRef<int>(&NativePtr->SelectHorzMod);
		public ref int SelectVertMod => ref Unsafe.AsRef<int>(&NativePtr->SelectVertMod);
		public ref ImGuiMouseButton Menu => ref Unsafe.AsRef<ImGuiMouseButton>(&NativePtr->Menu);
		public ref int OverrideMod => ref Unsafe.AsRef<int>(&NativePtr->OverrideMod);
		public ref int ZoomMod => ref Unsafe.AsRef<int>(&NativePtr->ZoomMod);
		public ref float ZoomRate => ref Unsafe.AsRef<float>(&NativePtr->ZoomRate);
		public ImPlotInputMapPtr(ImPlotInputMap* nativePtr) => NativePtr = nativePtr;
		public ImPlotInputMapPtr(IntPtr nativePtr) => NativePtr = (ImPlotInputMap*)nativePtr;
		public static implicit operator ImPlotInputMapPtr(ImPlotInputMap* ptr) => new ImPlotInputMapPtr(ptr);
		public static implicit operator ImPlotInputMapPtr(IntPtr ptr) => new ImPlotInputMapPtr(ptr);
		public static implicit operator ImPlotInputMap*(ImPlotInputMapPtr nativePtr) => nativePtr.NativePtr;
		public void InputMapDestroy()
		{
			ImPlotNative.InputMapDestroy(NativePtr);
		}

		public ImPlotInputMapPtr InputMapInputMap()
		{
			return ImPlotNative.InputMapInputMap();
		}

	}
}

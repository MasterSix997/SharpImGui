using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImNodes
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImNodesStyle
	{
		public float GridSpacing;
		public float NodeCornerRounding;
		public Vector2 NodePadding;
		public float NodeBorderThickness;
		public float LinkThickness;
		public float LinkLineSegmentsPerLength;
		public float LinkHoverDistance;
		public float PinCircleRadius;
		public float PinQuadSideLength;
		public float PinTriangleSideLength;
		public float PinLineThickness;
		public float PinHoverRadius;
		public float PinOffset;
		public Vector2 MiniMapPadding;
		public Vector2 MiniMapOffset;
		public ImNodesStyleFlags Flags;
		public uint Colors_0;
		public uint Colors_1;
		public uint Colors_2;
		public uint Colors_3;
		public uint Colors_4;
		public uint Colors_5;
		public uint Colors_6;
		public uint Colors_7;
		public uint Colors_8;
		public uint Colors_9;
		public uint Colors_10;
		public uint Colors_11;
		public uint Colors_12;
		public uint Colors_13;
		public uint Colors_14;
		public uint Colors_15;
		public uint Colors_16;
		public uint Colors_17;
		public uint Colors_18;
		public uint Colors_19;
		public uint Colors_20;
		public uint Colors_21;
		public uint Colors_22;
		public uint Colors_23;
		public uint Colors_24;
		public uint Colors_25;
		public uint Colors_26;
		public uint Colors_27;
		public uint Colors_28;
	}

	public unsafe partial struct ImNodesStylePtr
	{
		public ImNodesStyle* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImNodesStyle this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float GridSpacing => ref Unsafe.AsRef<float>(&NativePtr->GridSpacing);
		public ref float NodeCornerRounding => ref Unsafe.AsRef<float>(&NativePtr->NodeCornerRounding);
		public ref Vector2 NodePadding => ref Unsafe.AsRef<Vector2>(&NativePtr->NodePadding);
		public ref float NodeBorderThickness => ref Unsafe.AsRef<float>(&NativePtr->NodeBorderThickness);
		public ref float LinkThickness => ref Unsafe.AsRef<float>(&NativePtr->LinkThickness);
		public ref float LinkLineSegmentsPerLength => ref Unsafe.AsRef<float>(&NativePtr->LinkLineSegmentsPerLength);
		public ref float LinkHoverDistance => ref Unsafe.AsRef<float>(&NativePtr->LinkHoverDistance);
		public ref float PinCircleRadius => ref Unsafe.AsRef<float>(&NativePtr->PinCircleRadius);
		public ref float PinQuadSideLength => ref Unsafe.AsRef<float>(&NativePtr->PinQuadSideLength);
		public ref float PinTriangleSideLength => ref Unsafe.AsRef<float>(&NativePtr->PinTriangleSideLength);
		public ref float PinLineThickness => ref Unsafe.AsRef<float>(&NativePtr->PinLineThickness);
		public ref float PinHoverRadius => ref Unsafe.AsRef<float>(&NativePtr->PinHoverRadius);
		public ref float PinOffset => ref Unsafe.AsRef<float>(&NativePtr->PinOffset);
		public ref Vector2 MiniMapPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->MiniMapPadding);
		public ref Vector2 MiniMapOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->MiniMapOffset);
		public ref ImNodesStyleFlags Flags => ref Unsafe.AsRef<ImNodesStyleFlags>(&NativePtr->Flags);
		public Span<uint> Colors => new Span<uint>(&NativePtr->Colors_0, 29);
		public ImNodesStylePtr(ImNodesStyle* nativePtr) => NativePtr = nativePtr;
		public ImNodesStylePtr(IntPtr nativePtr) => NativePtr = (ImNodesStyle*)nativePtr;
		public static implicit operator ImNodesStylePtr(ImNodesStyle* ptr) => new ImNodesStylePtr(ptr);
		public static implicit operator ImNodesStylePtr(IntPtr ptr) => new ImNodesStylePtr(ptr);
		public static implicit operator ImNodesStyle*(ImNodesStylePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImnodesNative.ImNodesStyleDestroy(NativePtr);
		}

		public ImNodesStylePtr ImNodesStyle()
		{
			return ImnodesNative.ImNodesStyleImNodesStyle();
		}

	}
}

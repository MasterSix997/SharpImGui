using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using SharpImGui;

namespace SharpImGuizmo
{
	public unsafe partial class ImGuizmoNative
	{
		static ImGuizmoNative()
		{
			InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
		}

		public static string GetLibraryName()
		{
			return "cimguizmo";
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetDrawlist(ImDrawList* drawlist)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[0])((IntPtr)drawlist);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoBeginFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetImGuiContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[2])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsOverNil()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[3])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsUsing()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[4])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsUsingViewManipulate()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[5])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsViewManipulateHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[6])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsUsingAny()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[7])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoEnable(byte enable)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[8])(enable);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoDecomposeMatrixToComponents(float* matrix, float* translation, float* rotation, float* scale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[9])((IntPtr)matrix, (IntPtr)translation, (IntPtr)rotation, (IntPtr)scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoRecomposeMatrixFromComponents(float* translation, float* rotation, float* scale, float* matrix)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[10])((IntPtr)translation, (IntPtr)rotation, (IntPtr)scale, (IntPtr)matrix);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetRect(float x, float y, float width, float height)
		{
			((delegate* unmanaged[Cdecl]<float, float, float, float, void>)FuncTable[11])(x, y, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetOrthographic(byte isOrthographic)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[12])(isOrthographic);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoDrawCubes(float* view, float* projection, float* matrices, int matrixCount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, void>)FuncTable[13])((IntPtr)view, (IntPtr)projection, (IntPtr)matrices, matrixCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoDrawGrid(float* view, float* projection, float* matrix, float gridSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, void>)FuncTable[14])((IntPtr)view, (IntPtr)projection, (IntPtr)matrix, gridSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoManipulate(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float* deltaMatrix, float* snap, float* localBounds, float* boundsSnap)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, OPERATION, MODE, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[15])((IntPtr)view, (IntPtr)projection, operation, mode, (IntPtr)matrix, (IntPtr)deltaMatrix, (IntPtr)snap, (IntPtr)localBounds, (IntPtr)boundsSnap);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoViewManipulateFloat(float* view, float length, Vector2 position, Vector2 size, uint backgroundColor)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, Vector2, Vector2, uint, void>)FuncTable[16])((IntPtr)view, length, position, size, backgroundColor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoViewManipulateFloatPtr(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float length, Vector2 position, Vector2 size, uint backgroundColor)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, OPERATION, MODE, IntPtr, float, Vector2, Vector2, uint, void>)FuncTable[17])((IntPtr)view, (IntPtr)projection, operation, mode, (IntPtr)matrix, length, position, size, backgroundColor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetAlternativeWindow(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[18])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetID(int id)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[19])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoPushIDStr(byte* strId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[20])((IntPtr)strId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoPushIDStrStr(byte* strIdBegin, byte* strIdEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[21])((IntPtr)strIdBegin, (IntPtr)strIdEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoPushIDPtr(void* ptrId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[22])((IntPtr)ptrId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoPushIDInt(int intId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[23])(intId);
		}

		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoPopID()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[24])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuizmoGetIDStr(byte* strId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[25])((IntPtr)strId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuizmoGetIDStrStr(byte* strIdBegin, byte* strIdEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[26])((IntPtr)strIdBegin, (IntPtr)strIdEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuizmoGetIDPtr(void* ptrId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[27])((IntPtr)ptrId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsOverOPERATION(OPERATION op)
		{
			return ((delegate* unmanaged[Cdecl]<OPERATION, byte>)FuncTable[28])(op);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetGizmoSizeClipSpace(float value)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[29])(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoAllowAxisFlip(byte value)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[30])(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetAxisLimit(float value)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[31])(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetAxisMask(byte x, byte y, byte z)
		{
			((delegate* unmanaged[Cdecl]<byte, byte, byte, void>)FuncTable[32])(x, y, z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuizmoSetPlaneLimit(float value)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[33])(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuizmoIsOverFloatPtr(float* position, float pixelRadius)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, byte>)FuncTable[34])((IntPtr)position, pixelRadius);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Style* StyleStyle()
		{
			return (Style*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[35])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleDestroy(Style* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[36])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Style* ImGuizmoGetStyle()
		{
			return (Style*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[37])();
		}

	}
}

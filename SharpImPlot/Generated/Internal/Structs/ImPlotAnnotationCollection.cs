using SharpImGui;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotAnnotationCollection
	{
		public ImVector<ImPlotAnnotation> Annotations;
		public ImGuiTextBuffer TextBuffer;
		public int Size;
	}

	public unsafe partial struct ImPlotAnnotationCollectionPtr
	{
		public ImPlotAnnotationCollection* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImPlotAnnotationCollection this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<ImPlotAnnotation> Annotations => ref Unsafe.AsRef<ImVector<ImPlotAnnotation>>(&NativePtr->Annotations);
		public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
		public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
		public ImPlotAnnotationCollectionPtr(ImPlotAnnotationCollection* nativePtr) => NativePtr = nativePtr;
		public ImPlotAnnotationCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotAnnotationCollection*)nativePtr;
		public static implicit operator ImPlotAnnotationCollectionPtr(ImPlotAnnotationCollection* ptr) => new ImPlotAnnotationCollectionPtr(ptr);
		public static implicit operator ImPlotAnnotationCollectionPtr(IntPtr ptr) => new ImPlotAnnotationCollectionPtr(ptr);
		public static implicit operator ImPlotAnnotationCollection*(ImPlotAnnotationCollectionPtr nativePtr) => nativePtr.NativePtr;
		public void AnnotationCollectionReset()
		{
			ImPlotNative.AnnotationCollectionReset(NativePtr);
		}

		public ref byte AnnotationCollectionGetText(int idx)
		{
			var nativeResult = ImPlotNative.AnnotationCollectionGetText(NativePtr, idx);
			return ref *(byte*)&nativeResult;
		}

		public void AnnotationCollectionAppend(Vector2 pos, Vector2 off, uint bg, uint fg, bool clamp, ReadOnlySpan<byte> fmt)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			fixed (byte* nativeFmt = fmt)
			{
				ImPlotNative.AnnotationCollectionAppend(NativePtr, pos, off, bg, fg, native_clamp, nativeFmt);
			}
		}

		public void AnnotationCollectionAppend(Vector2 pos, Vector2 off, uint bg, uint fg, bool clamp, ReadOnlySpan<char> fmt)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImPlotNative.AnnotationCollectionAppend(NativePtr, pos, off, bg, fg, native_clamp, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public void AnnotationCollectionDestroy()
		{
			ImPlotNative.AnnotationCollectionDestroy(NativePtr);
		}

		public ImPlotAnnotationCollectionPtr AnnotationCollectionAnnotationCollection()
		{
			return ImPlotNative.AnnotationCollectionAnnotationCollection();
		}

	}
}

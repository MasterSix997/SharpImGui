﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
    internal static unsafe class Util
    {
        internal const int StackAllocationSizeLimit = 2048;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string StringFromPtr(byte* ptr)
        {
            var characters = 0;
            while (ptr[characters] != 0)
                characters++;

            return Encoding.UTF8.GetString(ptr, characters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool AreStringsEqual(byte* a, int aLength, byte* b)
        {
            for (var i = 0; i < aLength; i++)
                if (a[i] != b[i]) return false;

            return b[aLength] == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte* Allocate(int byteCount) => (byte*)Marshal.AllocHGlobal(byteCount);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void Free(byte* ptr) => Marshal.FreeHGlobal((IntPtr)ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int CalcSizeInUtf8(ReadOnlySpan<char> s, int start, int length)
        {
            if (start < 0 || length < 0 || start + length > s.Length)
                throw new ArgumentOutOfRangeException();
            
            if(s.Length == 0) 
                return 0;

            fixed (char* utf16Ptr = s)
                return Encoding.UTF8.GetByteCount(utf16Ptr + start, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int GetUtf8(ReadOnlySpan<char> s, byte* utf8Bytes, int utf8ByteCount)
        {
            if (s.IsEmpty)
                return 0;

            fixed (char* utf16Ptr = s)
                return Encoding.UTF8.GetBytes(utf16Ptr, s.Length, utf8Bytes, utf8ByteCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int GetUtf8(string s, byte* utf8Bytes, int utf8ByteCount)
        {
            fixed (char* utf16Ptr = s)
                return Encoding.UTF8.GetBytes(utf16Ptr, s.Length, utf8Bytes, utf8ByteCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int GetUtf8(ReadOnlySpan<char> s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
        {
            if (start < 0 || length < 0 || start + length > s.Length)
                throw new ArgumentOutOfRangeException();
            
            if (s.Length == 0) 
                return 0;

            fixed (char* utf16Ptr = s)
                return Encoding.UTF8.GetBytes(utf16Ptr + start, length, utf8Bytes, utf8ByteCount);
        }
    }
}
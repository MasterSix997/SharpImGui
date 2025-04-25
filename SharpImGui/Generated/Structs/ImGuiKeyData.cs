using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// [Internal] Storage used by IsKeyDown(), IsKeyPressed() etc functions.<br/>If prior to 1.87 you used io.KeysDownDuration[] (which was marked as internal), you should use GetKeyData(key)-&gt;DownDuration and *NOT* io.KeysData[key]-&gt;DownDuration.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyData
	{
		/// <summary>
		/// True for if key is down<br/>
		/// </summary>
		public byte Down;
		/// <summary>
		/// Duration the key has been down (&lt;0.0f: not pressed, 0.0f: just pressed, &gt;0.0f: time held)<br/>
		/// </summary>
		public float DownDuration;
		/// <summary>
		/// Last frame duration the key has been down<br/>
		/// </summary>
		public float DownDurationPrev;
		/// <summary>
		/// 0.0f..1.0f for gamepad values<br/>
		/// </summary>
		public float AnalogValue;
	}

	/// <summary>
	/// [Internal] Storage used by IsKeyDown(), IsKeyPressed() etc functions.<br/>If prior to 1.87 you used io.KeysDownDuration[] (which was marked as internal), you should use GetKeyData(key)-&gt;DownDuration and *NOT* io.KeysData[key]-&gt;DownDuration.<br/>
	/// </summary>
	public unsafe partial struct ImGuiKeyDataPtr
	{
		public ImGuiKeyData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiKeyData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyData*)nativePtr;
		public static implicit operator ImGuiKeyDataPtr(ImGuiKeyData* ptr) => new ImGuiKeyDataPtr(ptr);
		public static implicit operator ImGuiKeyDataPtr(IntPtr ptr) => new ImGuiKeyDataPtr(ptr);
		public static implicit operator ImGuiKeyData*(ImGuiKeyDataPtr nativePtr) => nativePtr.NativePtr;
	}
}

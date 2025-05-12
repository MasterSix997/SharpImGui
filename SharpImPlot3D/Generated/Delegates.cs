using SharpImGui;
using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImPlot3D
{
	public unsafe delegate int ImPlot3DFormatter(float value, byte* buff, int size, void* userData);
}

using System;

namespace SharpImGuizmo
{
	/// <summary>
	///    call it when you want a gizmo<br/>   Needs view and projection matrices.<br/>   matrix parameter is the source matrix (where will be gizmo be drawn) and might be transformed by the function. Return deltaMatrix is optional<br/>   translation is applied in world space<br/>
	/// </summary>
	public enum OPERATION
	{
		TRANSLATEX = 1,
		TRANSLATEY = 2,
		TRANSLATEZ = 4,
		ROTATEX = 8,
		ROTATEY = 16,
		ROTATEZ = 32,
		ROTATESCREEN = 64,
		SCALEX = 128,
		SCALEY = 256,
		SCALEZ = 512,
		BOUNDS = 1024,
		SCALEXU = 2048,
		SCALEYU = 4096,
		SCALEZU = 8192,
		TRANSLATE = 7,
		ROTATE = 120,
		SCALE = 896,
		/// <summary>
		/// universal<br/>
		/// </summary>
		SCALEU = 14336,
		UNIVERSAL = 14463,
	}

	public enum MODE
	{
		LOCAL = 0,
		WORLD = 1,
	}

	public enum COLOR
	{
		/// <summary>
		/// directionColor[0]<br/>
		/// </summary>
		DIRECTIONX = 0,
		/// <summary>
		/// directionColor[1]<br/>
		/// </summary>
		DIRECTIONY = 1,
		/// <summary>
		/// directionColor[2]<br/>
		/// </summary>
		DIRECTIONZ = 2,
		/// <summary>
		/// planeColor[0]<br/>
		/// </summary>
		PLANEX = 3,
		/// <summary>
		/// planeColor[1]<br/>
		/// </summary>
		PLANEY = 4,
		/// <summary>
		/// planeColor[2]<br/>
		/// </summary>
		PLANEZ = 5,
		/// <summary>
		/// selectionColor<br/>
		/// </summary>
		SELECTION = 6,
		/// <summary>
		/// inactiveColor<br/>
		/// </summary>
		INACTIVE = 7,
		/// <summary>
		/// translationLineColor<br/>
		/// </summary>
		TRANSLATIONLINE = 8,
		SCALELINE = 9,
		ROTATIONUSINGBORDER = 10,
		ROTATIONUSINGFILL = 11,
		HATCHEDAXISLINES = 12,
		TEXT = 13,
		TEXTSHADOW = 14,
		COUNT = 15,
	}
}

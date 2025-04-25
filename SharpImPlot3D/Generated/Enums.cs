using System;

namespace SharpImPlot3D
{
	/// <summary>
	/// Flags for ImPlot3D::BeginPlot()<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// Hide plot title<br/>
		/// </summary>
		NoTitle = 1,
		/// <summary>
		/// Hide plot legend<br/>
		/// </summary>
		NoLegend = 2,
		/// <summary>
		/// Hide mouse position in plot coordinates<br/>
		/// </summary>
		NoMouseText = 4,
		/// <summary>
		/// Disable 3D box clipping<br/>
		/// </summary>
		NoClip = 8,
		/// <summary>
		/// The user will not be able to open context menus<br/>
		/// </summary>
		NoMenus = 16,
		CanvasOnly = 7,
	}

	/// <summary>
	/// Represents a condition for SetupAxisLimits etc. (same as ImGuiCond, but we only support a subset of those enums)<br/>
	/// </summary>
	public enum ImPlot3DCond
	{
		/// <summary>
		/// No condition (always set the variable), same as _Always<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// No condition (always set the variable)<br/>
		/// </summary>
		Always = 1,
		/// <summary>
		/// Set the variable once per runtime session (only the first call will succeed)<br/>
		/// </summary>
		Once = 2,
	}

	public enum ImPlot3DCol
	{
		/// <summary>
		/// Line color<br/>
		/// </summary>
		Line = 0,
		/// <summary>
		/// Fill color<br/>
		/// </summary>
		Fill = 1,
		/// <summary>
		/// Marker outline color<br/>
		/// </summary>
		MarkerOutline = 2,
		/// <summary>
		/// Marker fill color<br/>
		/// </summary>
		MarkerFill = 3,
		/// <summary>
		/// Title color<br/>
		/// </summary>
		TitleText = 4,
		/// <summary>
		/// Color for texts appearing inside of plots<br/>
		/// </summary>
		InlayText = 5,
		/// <summary>
		/// Frame background color<br/>
		/// </summary>
		FrameBg = 6,
		/// <summary>
		/// Plot area background color<br/>
		/// </summary>
		PlotBg = 7,
		/// <summary>
		/// Plot area border color<br/>
		/// </summary>
		PlotBorder = 8,
		/// <summary>
		/// Legend background color<br/>
		/// </summary>
		LegendBg = 9,
		/// <summary>
		/// Legend border color<br/>
		/// </summary>
		LegendBorder = 10,
		/// <summary>
		/// Legend text color<br/>
		/// </summary>
		LegendText = 11,
		/// <summary>
		/// Axis label and tick lables color<br/>
		/// </summary>
		AxisText = 12,
		/// <summary>
		/// Axis grid color<br/>
		/// </summary>
		AxisGrid = 13,
		/// <summary>
		/// Axis tick color (defaults to AxisGrid)<br/>
		/// </summary>
		AxisTick = 14,
		COUNT = 15,
	}

	/// <summary>
	/// Plot styling variables<br/>
	/// </summary>
	public enum ImPlot3DStyleVar
	{
		/// <summary>
		/// float, plot item line weight in pixels<br/>
		/// </summary>
		LineWeight = 0,
		/// <summary>
		/// int,   marker specification<br/>
		/// </summary>
		Marker = 1,
		/// <summary>
		/// float, marker size in pixels (roughly the marker's "radius")<br/>
		/// </summary>
		MarkerSize = 2,
		/// <summary>
		/// float, plot outline weight of markers in pixels<br/>
		/// </summary>
		MarkerWeight = 3,
		/// <summary>
		/// float, alpha modifier applied to all plot item fills<br/>
		/// </summary>
		FillAlpha = 4,
		/// <summary>
		/// ImVec2, default size used when ImVec2(0,0) is passed to BeginPlot<br/>
		/// </summary>
		PlotDefaultSize = 5,
		/// <summary>
		/// ImVec2, minimum size plot frame can be when shrunk<br/>
		/// </summary>
		PlotMinSize = 6,
		/// <summary>
		/// ImVec2, padding between widget frame and plot area, labels, or outside legends (i.e. main padding)<br/>
		/// </summary>
		PlotPadding = 7,
		/// <summary>
		/// ImVec2, padding between axes labels, tick labels, and plot edge<br/>
		/// </summary>
		LabelPadding = 8,
		/// <summary>
		/// ImVec2, legend padding from plot edges<br/>
		/// </summary>
		LegendPadding = 9,
		/// <summary>
		/// ImVec2, legend inner padding from legend edges<br/>
		/// </summary>
		LegendInnerPadding = 10,
		/// <summary>
		/// ImVec2, spacing between legend entries<br/>
		/// </summary>
		LegendSpacing = 11,
		COUNT = 12,
	}

	public enum ImPlot3DMarker
	{
		/// <summary>
		/// No marker<br/>
		/// </summary>
		None = -1,
		/// <summary>
		/// Circle marker (default)<br/>
		/// </summary>
		Circle = 0,
		/// <summary>
		/// Square maker<br/>
		/// </summary>
		Square = 1,
		/// <summary>
		/// Diamond marker<br/>
		/// </summary>
		Diamond = 2,
		/// <summary>
		/// Upward-pointing triangle marker<br/>
		/// </summary>
		Up = 3,
		/// <summary>
		/// Downward-pointing triangle marker<br/>
		/// </summary>
		Down = 4,
		/// <summary>
		/// Leftward-pointing triangle marker<br/>
		/// </summary>
		Left = 5,
		/// <summary>
		/// Rightward-pointing triangle marker<br/>
		/// </summary>
		Right = 6,
		/// <summary>
		/// Cross marker (not fillable)<br/>
		/// </summary>
		Cross = 7,
		/// <summary>
		/// Plus marker (not fillable)<br/>
		/// </summary>
		Plus = 8,
		/// <summary>
		/// Asterisk marker (not fillable)<br/>
		/// </summary>
		Asterisk = 9,
		COUNT = 10,
	}

	/// <summary>
	/// Flags for items<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DItemFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// The item won't have a legend entry displayed<br/>
		/// </summary>
		NoLegend = 1,
		/// <summary>
		/// The item won't be considered for plot fits<br/>
		/// </summary>
		NoFit = 2,
	}

	/// <summary>
	/// Flags for PlotScatter<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DScatterFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		NoLegend = 1,
		NoFit = 2,
	}

	/// <summary>
	/// Flags for PlotLine<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DLineFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		NoLegend = 1,
		NoFit = 2,
		/// <summary>
		/// A line segment will be rendered from every two consecutive points<br/>
		/// </summary>
		Segments = 1024,
		/// <summary>
		/// The last and first point will be connected to form a closed loop<br/>
		/// </summary>
		Loop = 2048,
		/// <summary>
		/// NaNs values will be skipped instead of rendered as missing data<br/>
		/// </summary>
		SkipNaN = 4096,
	}

	/// <summary>
	/// Flags for PlotTriangle<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DTriangleFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		NoLegend = 1,
		NoFit = 2,
	}

	/// <summary>
	/// Flags for PlotQuad<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DQuadFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		NoLegend = 1,
		NoFit = 2,
	}

	/// <summary>
	/// Flags for PlotSurface<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DSurfaceFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		NoLegend = 1,
		NoFit = 2,
	}

	/// <summary>
	/// Flags for PlotMesh<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DMeshFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		NoLegend = 1,
		NoFit = 2,
	}

	/// <summary>
	/// Flags for legends<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DLegendFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// Legend icons will not function as hide/show buttons<br/>
		/// </summary>
		NoButtons = 1,
		/// <summary>
		/// Plot items will not be highlighted when their legend entry is hovered<br/>
		/// </summary>
		NoHighlightItem = 2,
		/// <summary>
		/// Legend entries will be displayed horizontally<br/>
		/// </summary>
		Horizontal = 4,
	}

	/// <summary>
	/// Used to position legend on a plot<br/>
	/// </summary>
	public enum ImPlot3DLocation
	{
		/// <summary>
		/// Center-center<br/>
		/// </summary>
		Center = 0,
		/// <summary>
		/// Top-center<br/>
		/// </summary>
		North = 1,
		/// <summary>
		/// Bottom-center<br/>
		/// </summary>
		South = 2,
		/// <summary>
		/// Center-left<br/>
		/// </summary>
		West = 4,
		/// <summary>
		/// Center-right<br/>
		/// </summary>
		East = 8,
		/// <summary>
		/// Top-left<br/>
		/// </summary>
		NorthWest = 5,
		/// <summary>
		/// Top-right<br/>
		/// </summary>
		NorthEast = 9,
		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		SouthWest = 6,
		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		SouthEast = 10,
	}

	/// <summary>
	/// Flags for axis<br/>
	/// </summary>
	[Flags]
	public enum ImPlot3DAxisFlags
	{
		/// <summary>
		/// Default<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// No axis label will be displayed<br/>
		/// </summary>
		NoLabel = 1,
		/// <summary>
		/// No grid lines will be displayed<br/>
		/// </summary>
		NoGridLines = 2,
		/// <summary>
		/// No tick marks will be displayed<br/>
		/// </summary>
		NoTickMarks = 4,
		/// <summary>
		/// No tick labels will be displayed<br/>
		/// </summary>
		NoTickLabels = 8,
		/// <summary>
		/// The axis minimum value will be locked when panning/zooming<br/>
		/// </summary>
		LockMin = 16,
		/// <summary>
		/// The axis maximum value will be locked when panning/zooming<br/>
		/// </summary>
		LockMax = 32,
		/// <summary>
		/// Axis will be auto-fitting to data extents<br/>
		/// </summary>
		AutoFit = 64,
		/// <summary>
		/// The axis will be inverted<br/>
		/// </summary>
		Invert = 128,
		Lock = 48,
		NoDecorations = 11,
	}

	/// <summary>
	/// Axis indices<br/>
	/// </summary>
	public enum ImAxis3D
	{
		X = 0,
		Y = 1,
		Z = 2,
		COUNT = 3,
	}

	/// <summary>
	/// Plane indices<br/>
	/// </summary>
	public enum ImPlane3D
	{
		YZ = 0,
		XZ = 1,
		XY = 2,
		COUNT = 3,
	}

	/// <summary>
	/// Colormaps<br/>
	/// </summary>
	public enum ImPlot3DColormap
	{
		/// <summary>
		/// Same as seaborn "deep"<br/>
		/// </summary>
		Deep = 0,
		/// <summary>
		/// Same as matplotlib "Set1"<br/>
		/// </summary>
		Dark = 1,
		/// <summary>
		/// Same as matplotlib "Pastel1"<br/>
		/// </summary>
		Pastel = 2,
		/// <summary>
		/// Same as matplotlib "Paired"<br/>
		/// </summary>
		Paired = 3,
		/// <summary>
		/// Same as matplotlib "viridis"<br/>
		/// </summary>
		Viridis = 4,
		/// <summary>
		/// Same as matplotlib "plasma"<br/>
		/// </summary>
		Plasma = 5,
		/// <summary>
		/// Same as matplotlib/MATLAB "hot"<br/>
		/// </summary>
		Hot = 6,
		/// <summary>
		/// Same as matplotlib/MATLAB "cool"<br/>
		/// </summary>
		Cool = 7,
		/// <summary>
		/// Same as matplotlib/MATLAB "pink"<br/>
		/// </summary>
		Pink = 8,
		/// <summary>
		/// Same as matplotlib/MATLAB "jet"<br/>
		/// </summary>
		Jet = 9,
		/// <summary>
		/// Same as matplotlib "twilight"<br/>
		/// </summary>
		Twilight = 10,
		/// <summary>
		/// Same as matplotlib "RdBu"<br/>
		/// </summary>
		RdBu = 11,
		/// <summary>
		/// Same as matplotlib "BrGB"<br/>
		/// </summary>
		BrBG = 12,
		/// <summary>
		/// Same as matplotlib "PiYG"<br/>
		/// </summary>
		PiYG = 13,
		/// <summary>
		/// Same as matplotlib "Spectral"<br/>
		/// </summary>
		Spectral = 14,
		/// <summary>
		/// White/black<br/>
		/// </summary>
		Greys = 15,
	}
}

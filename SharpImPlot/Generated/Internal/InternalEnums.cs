using System;

namespace SharpImPlot
{
	public enum ImPlotTimeFmt
	{
		None = 0,
		Us = 1,
		SUs = 2,
		SMs = 3,
		S = 4,
		MinSMs = 5,
		HrMinSMs = 6,
		HrMinS = 7,
		HrMin = 8,
		Hr = 9,
	}

	public enum ImPlotDateFmt
	{
		None = 0,
		DayMo = 1,
		DayMoYr = 2,
		MoYr = 3,
		Mo = 4,
		Yr = 5,
	}

	public enum ImPlotTimeUnit
	{
		Us = 0,
		Ms = 1,
		S = 2,
		Min = 3,
		Hr = 4,
		Day = 5,
		Mo = 6,
		Yr = 7,
		COUNT = 8,
	}
}

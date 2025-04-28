using System;

namespace SharpImPlot
{
    public struct Tm : IEquatable<Tm>
    {
        /// <summary>
        /// seconds after the minute - [0, 60] including leap second
        /// </summary>
        public int Sec;

        /// <summary>
        /// minutes after the hour - [0, 59]
        /// </summary>
        public int Min;

        /// <summary>
        /// hours since midnight - [0, 23]
        /// </summary>
        public int Hour;

        /// <summary>
        /// day of the month - [1, 31]
        /// </summary>
        public int MDay;

        /// <summary>
        /// months since January - [0, 11]
        /// </summary>
        public int Mon;

        /// <summary>
        /// years since 1900
        /// </summary>
        public int Year;

        /// <summary>
        /// days since Sunday - [0, 6]
        /// </summary>
        public int WDay;

        /// <summary>
        /// days since January 1 - [0, 365]
        /// </summary>
        public int YDay;

        /// <summary>
        /// daylight savings time flag
        /// </summary>
        public int IsDst;

        public override bool Equals(object? obj)
        {
            return obj is Tm tm && Equals(tm);
        }

        public bool Equals(Tm other)
        {
            return Sec == other.Sec &&
                   Min == other.Min &&
                   Hour == other.Hour &&
                   MDay == other.MDay &&
                   Mon == other.Mon &&
                   Year == other.Year &&
                   WDay == other.WDay &&
                   YDay == other.YDay &&
                   IsDst == other.IsDst;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Sec);
            hash.Add(Min);
            hash.Add(Hour);
            hash.Add(MDay);
            hash.Add(Mon);
            hash.Add(Year);
            hash.Add(WDay);
            hash.Add(YDay);
            hash.Add(IsDst);
            return hash.ToHashCode();
        }

        public static bool operator ==(Tm left, Tm right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Tm left, Tm right)
        {
            return !(left == right);
        }
    }

    public unsafe partial struct TmPtr : IEquatable<TmPtr>
    {
        public Tm* NativePtr;
        
        /// <summary>
        /// seconds after the minute - [0, 60] including leap second
        /// </summary>
        public int Sec => NativePtr->Sec;

        /// <summary>
        /// minutes after the hour - [0, 59]
        /// </summary>
        public int Min => NativePtr->Min;

        /// <summary>
        /// hours since midnight - [0, 23]
        /// </summary>
        public int Hour => NativePtr->Hour;

        /// <summary>
        /// day of the month - [1, 31]
        /// </summary>
        public int MDay => NativePtr->MDay;

        /// <summary>
        /// months since January - [0, 11]
        /// </summary>
        public int Mon => NativePtr->Mon;

        /// <summary>
        /// years since 1900
        /// </summary>
        public int Year => NativePtr->Year;

        /// <summary>
        /// days since Sunday - [0, 6]
        /// </summary>
        public int WDay => NativePtr->WDay;

        /// <summary>
        /// days since January 1 - [0, 365]
        /// </summary>
        public int YDay => NativePtr->YDay;

        /// <summary>
        /// daylight savings time flag
        /// </summary>
        public int IsDst => NativePtr->IsDst;
        
        public bool IsNull => NativePtr == null;
        public Tm this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
        
        public TmPtr(Tm* nativePtr) => NativePtr = nativePtr;
        public TmPtr(IntPtr nativePtr) => NativePtr = (Tm*)nativePtr;
        public static implicit operator TmPtr(Tm* ptr) => new TmPtr(ptr);
        public static implicit operator TmPtr(IntPtr ptr) => new TmPtr(ptr);
        public static implicit operator Tm*(TmPtr nativePtr) => nativePtr.NativePtr;

        public override bool Equals(object? obj)
        {
            return obj is TmPtr tm && Equals(tm);
        }

        public bool Equals(TmPtr other)
        {
            return Sec == other.Sec &&
                   Min == other.Min &&
                   Hour == other.Hour &&
                   MDay == other.MDay &&
                   Mon == other.Mon &&
                   Year == other.Year &&
                   WDay == other.WDay &&
                   YDay == other.YDay &&
                   IsDst == other.IsDst;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Sec);
            hash.Add(Min);
            hash.Add(Hour);
            hash.Add(MDay);
            hash.Add(Mon);
            hash.Add(Year);
            hash.Add(WDay);
            hash.Add(YDay);
            hash.Add(IsDst);
            return hash.ToHashCode();
        }

        public static bool operator ==(TmPtr left, TmPtr right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TmPtr left, TmPtr right)
        {
            return !(left == right);
        }
    }
}
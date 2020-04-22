using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Drawing
{
    public struct PointF
    {
        public static readonly PointF Empty;
#pragma warning disable CS0824 // Constructor is marked external
        public extern PointF(float x, float y);
#pragma warning restore CS0824 // Constructor is marked external
        [Browsable(false)]
        public bool IsEmpty { get; }
        public float X { get; set; }
        public float Y { get; set; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF Add(PointF pt, SizeF sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF Add(PointF pt, Size sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF Subtract(PointF pt, Size sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF Subtract(PointF pt, SizeF sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override bool Equals(object obj);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override int GetHashCode();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF operator +(PointF pt, Size sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF operator +(PointF pt, SizeF sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF operator -(PointF pt, SizeF sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern PointF operator -(PointF pt, Size sz);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern bool operator ==(PointF left, PointF right);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern bool operator !=(PointF left, PointF right);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Drawing
{
    public struct SizeF
    {
        public static readonly SizeF Empty;
#pragma warning disable CS0824 // Constructor is marked external
        public extern SizeF(SizeF size);
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern SizeF(PointF pt);
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern SizeF(float width, float height);
#pragma warning restore CS0824 // Constructor is marked external
        [Browsable(false)]
        public bool IsEmpty { get; }
        public float Width { get; set; }
        public float Height { get; set; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern SizeF Add(SizeF sz1, SizeF sz2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern SizeF Subtract(SizeF sz1, SizeF sz2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override bool Equals(object obj);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override int GetHashCode();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern PointF ToPointF();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Size ToSize();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static SizeF operator +(SizeF sz1, SizeF sz2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static SizeF operator -(SizeF sz1, SizeF sz2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static bool operator ==(SizeF sz1, SizeF sz2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static bool operator !=(SizeF sz1, SizeF sz2);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern static explicit operator PointF(SizeF size);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
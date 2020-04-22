using System;

namespace NLog
{
    internal sealed class NotNullAttribute : Attribute
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern NotNullAttribute();
#pragma warning restore CS0824 // Constructor is marked external
    }
}
using System;

namespace TechTalk.SpecFlow
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BindingAttribute : Attribute
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern BindingAttribute();
#pragma warning restore CS0824 // Constructor is marked external
    }
}

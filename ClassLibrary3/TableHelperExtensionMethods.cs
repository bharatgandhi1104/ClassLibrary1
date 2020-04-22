using System;
using System.Collections.Generic;
using System.Text;

namespace TechTalk.SpecFlow.Assist
{
    public static class TableHelperExtensionMethods
    {
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern T CreateInstance<T>(this Table table);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern T CreateInstance<T>(this Table table, Func<T> methodToCreateTheInstance);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern IEnumerable<T> CreateSet<T>(this Table table);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern IEnumerable<T> CreateSet<T>(this Table table, Func<T> methodToCreateEachInstance);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern IEnumerable<T> CreateSet<T>(this Table table, Func<TableRow, T> methodToCreateEachInstance);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern void FillInstance(this Table table, object instance);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

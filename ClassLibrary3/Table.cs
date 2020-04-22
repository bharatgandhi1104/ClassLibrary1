using System;
using System.Collections.Generic;

namespace TechTalk.SpecFlow
{
    public class Table
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern Table(params string[] header);
#pragma warning restore CS0824 // Constructor is marked external

        public ICollection<string> Header { get; }
        public TableRows Rows { get; }
        public int RowCount { get; }

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRow(IDictionary<string, string> values);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddRow(params string[] cells);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ContainsColumn(string column);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void RenameColumn(string oldColumn, string newColumn);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ToString(bool headersOnly = false, bool withNewline = true);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

    }
}
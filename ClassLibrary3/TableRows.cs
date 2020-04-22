using System.Collections;
using System.Collections.Generic;

namespace TechTalk.SpecFlow
{
    public class TableRows : IEnumerable<TableRow>, IEnumerable
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern TableRows();
#pragma warning restore CS0824 // Constructor is marked external

        public extern TableRow this[int index] { get; }

        public int Count { get; }

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern IEnumerator<TableRow> GetEnumerator();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        IEnumerator<TableRow> IEnumerable<TableRow>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
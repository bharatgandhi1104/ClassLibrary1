using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class ExcelDataSource
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern ExcelDataSource();
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern ExcelDataSource(bool removeSpacesFromColumnNames, bool hasHeaderRecord = true, Dictionary<string, string> columnMappings = null);
#pragma warning restore CS0824 // Constructor is marked external

        public bool RemoveSpacesFromColumnNames { get; set; }
        public bool HasHeaderRecord { get; set; }
        public Dictionary<string, string> ColumnMappings { get; set; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern Task<IEnumerable<T>> ReadAllInternalAsync<T>(string input = null, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern Task<T> ReadInternalAsync<T>(string input = null, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
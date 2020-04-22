using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NLog;
using Objectivity.Test.Automation.Common;
using TechTalk.SpecFlow;

namespace ClassLibrary3
{
    public class StepDefinitionBase : IStepDefinitionBase
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        protected static readonly Logger Logger;
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning disable CS0824 // Constructor is marked external
        public extern StepDefinitionBase();

        public StepDefinitionBase(DriverContext driverContext, Credentials userDetails, ExcelDataSource excelHandler, int implicitlyWaitMilliseconds)
        {
            DriverContext = driverContext;
            UserDetails = userDetails;
            ExcelHandler = excelHandler;
            ImplicitlyWaitMilliseconds = implicitlyWaitMilliseconds;
        }
#pragma warning restore CS0824 // Constructor is marked external


        public DriverContext DriverContext { get; }
        public virtual Credentials UserDetails { get; }
        protected ExcelDataSource ExcelHandler { get; }
        protected int ImplicitlyWaitMilliseconds { get; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<bool> AssertDiscrepancies<T>(Task<ICollection<T>> expected, Task<ICollection<T>> actual, bool caseSensitive = true, int maxDifferences = 200, bool ignoreCollectionOrder = true, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<IEnumerable<IDictionary<string, object>>> ReadAllSqlAsDictionaryAsync(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        // [return: Dynamic(new[] { false, false, true })]
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<IEnumerable<dynamic>> ReadAllSqlAsync(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<IEnumerable<T>> ReadAllSqlAsync<T>(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<IDictionary<string, object>> ReadSqlAsDictionaryAsync(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<IDictionary<string, string>> ReadSqlAsStringDictionaryAsync(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        // [return: Dynamic(new[] { false, true })]
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<dynamic> ReadSqlAsync(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task<T> ReadSqlScalarAsync<T>(string input, string keyPrefix = null, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool VerifyDiffs(dynamic expected, dynamic actual, bool caseSensitive = true, int maxDifferences = 200, bool ignoreCollectionOrder = true, bool treatStringEmptyAndNullTheSame = true, bool warnOnly = true);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void VerifyThat(params Action[] asserts);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void VerifyThat(Action assert);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool WarnDiscrepancies<T>(ICollection<T> expected, ICollection<T> actual, bool caseSensitive = true, int maxDifferences = 200, bool ignoreCollectionOrder = true, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void WarnIf(Expression<Func<bool>> condition, string message = null, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Task WarnIf(Expression<Func<Task<bool>>> condition, string message = null, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void WarnIf(bool condition, string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Objectivity.Test.Automation.Common;

namespace ClassLibrary3
{
    public interface IStepDefinitionBase
    {
        DriverContext DriverContext { get; }
        Credentials UserDetails { get; }

        Task<bool> AssertDiscrepancies<T>(Task<ICollection<T>> expected, Task<ICollection<T>> actual, bool caseSensitive = true, int maxDifferences = 200, bool ignoreCollectionOrder = true, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
        Task<IEnumerable<IDictionary<string, object>>> ReadAllSqlAsDictionaryAsync(string input, string keyPrefix = null, params object[] args);
        Task<IEnumerable<dynamic>> ReadAllSqlAsync(string input, string keyPrefix = null, params object[] args);
        Task<IEnumerable<T>> ReadAllSqlAsync<T>(string input, string keyPrefix = null, params object[] args);
        Task<IDictionary<string, object>> ReadSqlAsDictionaryAsync(string input, string keyPrefix = null, params object[] args);
        Task<IDictionary<string, string>> ReadSqlAsStringDictionaryAsync(string input, string keyPrefix = null, params object[] args);
        Task<dynamic> ReadSqlAsync(string input, string keyPrefix = null, params object[] args);
        Task<T> ReadSqlScalarAsync<T>(string input, string keyPrefix = null, params object[] args);
        bool VerifyDiffs(dynamic expected, dynamic actual, bool caseSensitive = true, int maxDifferences = 200, bool ignoreCollectionOrder = true, bool treatStringEmptyAndNullTheSame = true, bool warnOnly = true);
        void VerifyThat(Action assert);
        void VerifyThat(params Action[] asserts);
        bool WarnDiscrepancies<T>(ICollection<T> expected, ICollection<T> actual, bool caseSensitive = true, int maxDifferences = 200, bool ignoreCollectionOrder = true, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
        void WarnIf(bool condition, string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
        void WarnIf(Expression<Func<bool>> condition, string message = null, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
        Task WarnIf(Expression<Func<Task<bool>>> condition, string message = null, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0);
    }
}
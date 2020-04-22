using System.Collections.Generic;
using Objectivity.Test.Automation.Common;

namespace Objectivity.Test.Automation.Common.Helpers
{
    public class PerformanceHelper
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern PerformanceHelper();
#pragma warning restore CS0824 // Constructor is marked external
        public IList<SavedTimes> GetloadTimeList { get; }
        public IEnumerable<AverageGroupedTimes> AllGroupedDurationsMilliseconds { get; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void StartMeasure();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void StopMeasure(string title);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
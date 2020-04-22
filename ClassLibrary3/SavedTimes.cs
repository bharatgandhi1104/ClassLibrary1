namespace Objectivity.Test.Automation.Common.Helpers
{
    public class SavedTimes
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern SavedTimes(string title);
#pragma warning restore CS0824 // Constructor is marked external
        public string Scenario { get; }
        public string BrowserName { get; }
        public long Duration { get; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SetDuration(long loadTime);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
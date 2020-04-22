namespace Objectivity.Test.Automation.Common.Helpers
{
    public class AverageGroupedTimes
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern AverageGroupedTimes();
#pragma warning restore CS0824 // Constructor is marked external
        public string StepName { get; set; }
        public string Browser { get; set; }
        public double AverageDuration { get; set; }
        public long Percentile90 { get; set; }
    }
}

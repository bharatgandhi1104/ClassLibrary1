using System.Collections.Generic;
using System.Globalization;

namespace TechTalk.SpecFlow.Bindings
{
    public class StepContext
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern StepContext(FeatureInfo featureInfo, ScenarioInfo scenarioInfo);
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern StepContext(string featureTitle, string scenarioTitle, IEnumerable<string> tags, CultureInfo language);
#pragma warning restore CS0824 // Constructor is marked external

        public string FeatureTitle { get; }
        public string ScenarioTitle { get; }
        public CultureInfo Language { get; }
        public IEnumerable<string> Tags { get; }
    }
}
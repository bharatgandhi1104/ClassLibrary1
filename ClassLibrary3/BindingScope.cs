namespace TechTalk.SpecFlow.Bindings
{
    public class BindingScope
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern BindingScope(string tag, string featureTitle, string scenarioTitle);
#pragma warning restore CS0824 // Constructor is marked external

        public string Tag { get; }
        public string FeatureTitle { get; }
        public string ScenarioTitle { get; }

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override bool Equals(object obj);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override int GetHashCode();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool Match(StepContext stepContext, out int scopeMatches);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern bool Equals(BindingScope other);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

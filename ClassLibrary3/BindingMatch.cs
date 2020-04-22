namespace TechTalk.SpecFlow.Bindings
{
    public class BindingMatch
    {
        public static readonly BindingMatch NonMatching;

#pragma warning disable CS0824 // Constructor is marked external
        public extern BindingMatch(IStepDefinitionBinding stepBinding, int scopeMatches, object[] arguments, StepContext stepContext);
#pragma warning restore CS0824 // Constructor is marked external

        public IStepDefinitionBinding StepBinding { get; }
        public bool Success { get; }
        public BindingObsoletion BindingObsoletion { get; }
        public bool IsObsolete { get; }
        public int ScopeMatches { get; }
        public bool IsScoped { get; }
        public object[] Arguments { get; }
        public StepContext StepContext { get; }
    }
}

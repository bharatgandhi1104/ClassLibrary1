namespace TechTalk.SpecFlow.Bindings
{
    public class BindingObsoletion
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern BindingObsoletion(IStepDefinitionBinding stepBinding);
#pragma warning restore CS0824 // Constructor is marked external

        public bool IsObsolete { get; }
        public string Message { get; }
    }
}

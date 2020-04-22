namespace TechTalk.SpecFlow
{
    public interface ITestRunner
    {
        ScenarioContext ScenarioContext { get; }
        int ThreadId { get; }
        FeatureContext FeatureContext { get; }

        void And(string text, string multilineTextArg, Table tableArg, string keyword = null);
        void But(string text, string multilineTextArg, Table tableArg, string keyword = null);
        void CollectScenarioErrors();
        void Given(string text, string multilineTextArg, Table tableArg, string keyword = null);
        void InitializeTestRunner(int threadId);
        void OnFeatureEnd();
        void OnFeatureStart(FeatureInfo featureInfo);
        void OnScenarioEnd();
        void OnScenarioInitialize(ScenarioInfo scenarioInfo);
        void OnScenarioStart();
        void OnTestRunEnd();
        void OnTestRunStart();
        void Pending();
        void Then(string text, string multilineTextArg, Table tableArg, string keyword = null);
        void When(string text, string multilineTextArg, Table tableArg, string keyword = null);
        void OnScenarioStart(ScenarioInfo scenarioInfo);
    }
}
namespace TechTalk.SpecFlow
{
    public enum ScenarioExecutionStatus
    {
        OK = 0,
        StepDefinitionPending = 1,
        UndefinedStep = 2,
        BindingError = 3,
        TestError = 4
    }
}
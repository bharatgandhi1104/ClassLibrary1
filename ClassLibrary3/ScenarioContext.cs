using System;
using BoDi;

namespace TechTalk.SpecFlow
{
    public class ScenarioContext : SpecFlowContext
    {
        public static ScenarioContext Current { get; }
        public ScenarioInfo ScenarioInfo { get; }
        public ScenarioBlock CurrentScenarioBlock { get; }
        public Exception TestError { get; }
        public IObjectContainer ScenarioContainer { get; }
        public ScenarioExecutionStatus ScenarioExecutionStatus { get; }
        public ScenarioStepContext StepContext { get; }

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern object GetBindingInstance(Type bindingType);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Pending();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using TechTalk.SpecFlow.Infrastructure;

namespace TechTalk.SpecFlow
{
    partial class Steps : IContainerDependentObject
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern Steps();
#pragma warning restore CS0824 // Constructor is marked external
        public ScenarioStepContext StepContext { get; }
        public FeatureContext FeatureContext { get; }
        public ScenarioContext ScenarioContext { get; }
        public TestThreadContext TestThreadContext { get; }
        protected ITestRunner TestRunner { get; }

        partial void And(string step, string multilineTextArg, Table tableArg);
        partial void And(string step, string multilineTextArg);
        partial void And(string step, Table tableArg);
        partial void And(string step);
        partial void But(string step, string multilineTextArg, Table tableArg);
        partial void But(string step, string multilineTextArg);
        partial void But(string step, Table tableArg);
        partial void But(string step);
        partial void Given(string step, string multilineTextArg, Table tableArg);
        partial void Given(string step, string multilineTextArg);
        partial void Given(string step, Table tableArg);
        partial void Given(string step);
        partial void SetObjectContainer(IObjectContainer container);
        partial void Then(string step, string multilineTextArg);
        partial void Then(string step, Table tableArg);
        partial void Then(string step);
        partial void Then(string step, string multilineTextArg, Table tableArg);
        partial void When(string step, string multilineTextArg, Table tableArg);
        partial void When(string step, string multilineTextArg);
        partial void When(string step, Table tableArg);
        partial void When(string step);
        partial void AssertInitialized();

        void IContainerDependentObject.SetObjectContainer(IObjectContainer container)
        {
            throw new NotImplementedException();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace TechTalk.SpecFlow
{
    public class ScenarioStepContext : SpecFlowContext
    {
        public static ScenarioStepContext Current { get; }
        public StepInfo StepInfo { get; }
    }
}

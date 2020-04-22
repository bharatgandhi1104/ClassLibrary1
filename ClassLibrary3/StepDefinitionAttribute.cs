using System;

namespace TechTalk.SpecFlow
{
    public class StepDefinitionAttribute : StepDefinitionBaseAttribute
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern StepDefinitionAttribute();
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern StepDefinitionAttribute(string regex);
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern StepDefinitionAttribute(string regex, string culture);
#pragma warning restore CS0824 // Constructor is marked external
    }
}
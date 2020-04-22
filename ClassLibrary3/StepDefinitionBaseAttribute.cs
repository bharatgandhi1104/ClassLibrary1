using System;
using TechTalk.SpecFlow.Bindings;

namespace TechTalk.SpecFlow
{
    public abstract class StepDefinitionBaseAttribute : Attribute
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern StepDefinitionBaseAttribute(string regex, StepDefinitionType[] types);
#pragma warning restore CS0824 // Constructor is marked external

        public string Regex { get; set; }
        public string Culture { get; set; }
    }
}
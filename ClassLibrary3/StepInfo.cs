using TechTalk.SpecFlow.Bindings;

namespace TechTalk.SpecFlow
{
    public class StepInfo
    {
        public extern StepInfo(StepDefinitionType stepDefinitionType, string text, Table table, string multilineText);

        public StepDefinitionType StepDefinitionType { get; }
        public string Text { get; }
        public Table Table { get; }
        public string MultilineText { get; }
        public BindingMatch BindingMatch { get; set; }
        public StepInstance StepInstance { get; set; }
    }
}
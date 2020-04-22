namespace TechTalk.SpecFlow.Bindings
{
    public class StepInstance
    {
        public extern StepInstance(StepDefinitionType stepDefinitionType, StepDefinitionKeyword stepDefinitionKeyword, string keywordWithTrailingSpaces, string text, StepContext stepContext);
        public extern StepInstance(StepDefinitionType type, StepDefinitionKeyword stepDefinitionKeyword, string keyword, string text, string multilineTextArgument, Table tableArgument, StepContext stepContext);

        public StepDefinitionType StepDefinitionType { get; }
        public StepDefinitionKeyword StepDefinitionKeyword { get; }
        public string Keyword { get; }
        public string Text { get; }
        public string MultilineTextArgument { get; set; }
        public Table TableArgument { get; set; }
        public StepContext StepContext { get; }
    }
}
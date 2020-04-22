namespace ClassLibrary3
{
    public class WebStepDefinitionBase : StepDefinitionBase
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern WebStepDefinitionBase();
#pragma warning restore CS0824 // Constructor is marked external

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ClickButtonByText(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ClickLabelByText(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ClickSubmitByText(string text);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void HasTitle(string title);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void ClickElementByText(string text, string type);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
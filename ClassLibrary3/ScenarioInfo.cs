namespace TechTalk.SpecFlow
{
    public class ScenarioInfo
    {
        private string v1;
        private string[] v2;

        public ScenarioInfo(string v1, string[] v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
#pragma warning disable CS0824 // Constructor is marked external
        public extern ScenarioInfo(string title, string description, params string[] tags);
#pragma warning restore CS0824 // Constructor is marked external

        public string[] Tags { get; }
        public string Title { get; }
        public string Description { get; }
    }
}
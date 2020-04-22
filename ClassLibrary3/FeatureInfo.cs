using System;
using System.Collections.Generic;
using System.Text;

using System.Globalization;

namespace TechTalk.SpecFlow
{
    public class FeatureInfo
    {
        private CultureInfo cultureInfo;
        private string v;
        private string v1;
        private string v2;
        private string[] cSharp;
        private string[] v3;

        public FeatureInfo(CultureInfo cultureInfo, string v)
        {
            this.cultureInfo = cultureInfo;
            this.v = v;
        }

        public extern FeatureInfo(CultureInfo language, string title, string description, params string[] tags);
        public extern FeatureInfo(CultureInfo language, string title, string description, ProgrammingLanguage programmingLanguage, params string[] tags);

        public FeatureInfo(CultureInfo cultureInfo, string v1, string v2, string[] cSharp, string[] v3)
        {
            this.cultureInfo = cultureInfo;
            this.v1 = v1;
            this.v2 = v2;
            this.cSharp = cSharp;
            this.v3 = v3;
        }

        public string[] Tags { get; }
        public ProgrammingLanguage GenerationTargetLanguage { get; }
        public string Title { get; }
        public string Description { get; }
        public CultureInfo Language { get; }
    }
}

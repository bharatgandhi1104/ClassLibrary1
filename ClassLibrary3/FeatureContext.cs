using BoDi;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TechTalk.SpecFlow
{
    public class FeatureContext : SpecFlowContext
    {
        public static FeatureContext Current { get; }
        public FeatureInfo FeatureInfo { get; }
        public CultureInfo BindingCulture { get; }
        public IObjectContainer FeatureContainer { get; }
    }
}

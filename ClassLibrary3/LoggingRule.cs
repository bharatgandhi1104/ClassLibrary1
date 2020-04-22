using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace NLog.Config
{
    public class LoggingRule
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingRule();
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingRule(string loggerNamePattern, Target target);
#pragma warning restore CS0824 // Constructor is marked external
    }
}

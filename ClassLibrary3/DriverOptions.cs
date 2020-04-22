using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace OpenQA.Selenium
{
    public abstract class DriverOptions
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern DriverOptions();
#pragma warning restore CS0824 // Constructor is marked external
        public UnhandledPromptBehavior UnhandledPromptBehavior { get; set; }
        public bool? AcceptInsecureCertificates { get; set; }
        public string PlatformName { get; set; }
        public string BrowserVersion { get; set; }
        public string BrowserName { get; protected set; }
        public PageLoadStrategy PageLoadStrategy { get; set; }
        public Proxy Proxy { get; set; }
        public abstract void AddAdditionalCapability(string capabilityName, object capabilityValue);
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual DriverOptionsMergeResult GetMergeResult(DriverOptions other);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SetLoggingPreference(string logType, LogLevel logLevel);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public abstract ICapabilities ToCapabilities();
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void AddKnownCapabilityName(string capabilityName, string typeSafeOptionName);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern DesiredCapabilities GenerateDesiredCapabilities(bool isSpecificationCompliant);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern Dictionary<string, object> GenerateLoggingPreferencesDictionary();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern string GetTypeSafeOptionName(string capabilityName);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern bool IsKnownCapabilityName(string capabilityName);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
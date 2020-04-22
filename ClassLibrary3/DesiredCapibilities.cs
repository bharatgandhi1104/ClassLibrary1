using System;
using System.Collections.Generic;
using System.Reflection;
using OpenQA.Selenium;

namespace OpenQA.Selenium
{
    public class DesiredCapabilities : ICapabilities, IHasCapabilitiesDictionary
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern DesiredCapabilities();
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0824 // Constructor is marked external
        public extern DesiredCapabilities(Dictionary<string, object> rawMap);
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the OpenQA.Selenium.Remote.DesiredCapabilities
        //     class
        //
        // Parameters:
        //   browser:
        //     Name of the browser e.g. firefox, internet explorer, safari
        //
        //   version:
        //     Version of the browser
        //
        //   platform:
        //     The platform it works on
        [Obsolete("Use of DesiredCapabilities has been deprecated in favor of browser-specific Options classes")]
        public extern DesiredCapabilities(string browser, string version, Platform platform);


        //
        // Summary:
        //     Gets the capability value with the specified name.
        //
        // Parameters:
        //   capabilityName:
        //     The name of the capability to get.
        //
        // Returns:
        //     The value of the capability.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The specified capability name is not in the set of capabilities.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern object this[string capabilityName] { get; set; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the browser name
        public string BrowserName { get; }
        //
        // Summary:
        //     Gets or sets the platform
        public Platform Platform { get; set; }
        //
        // Summary:
        //     Gets the browser version
        public string Version { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the browser accepts SSL certificates.
        public bool AcceptInsecureCerts { get; set; }


        //
        // Summary:
        //     Compare two DesiredCapabilities and will return either true or false
        //
        // Parameters:
        //   obj:
        //     DesiredCapabilities you wish to compare
        //
        // Returns:
        //     true if they are the same or false if they are not
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override bool Equals(object obj);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets a capability of the browser.
        //
        // Parameters:
        //   capability:
        //     The capability to get.
        //
        // Returns:
        //     An object associated with the capability, or null if the capability is not set
        //     on the browser.
        [Obsolete("Use of DesiredCapabilities has been deprecated in favor of browser-specific Options classes")]
        public extern object GetCapability(string capability);

        //
        // Summary:
        //     Return HashCode for the DesiredCapabilities that has been created
        //
        // Returns:
        //     Integer of HashCode generated
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override int GetHashCode();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets a value indicating whether the browser has a given capability.
        //
        // Parameters:
        //   capability:
        //     The capability to get.
        //
        // Returns:
        //     Returns true if the browser has the capability; otherwise, false.
        [Obsolete("Use of DesiredCapabilities has been deprecated in favor of browser-specific Options classes")]
        public extern bool HasCapability(string capability);
        //
        // Summary:
        //     Sets a capability of the browser.
        //
        // Parameters:
        //   capability:
        //     The capability to get.
        //
        //   capabilityValue:
        //     The value for the capability.
        [Obsolete("Use of DesiredCapabilities has been deprecated in favor of browser-specific Options classes")]
        public extern void SetCapability(string capability, object capabilityValue);

        //
        // Summary:
        //     Return a string of capabilities being used
        //
        // Returns:
        //     String of capabilities being used
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
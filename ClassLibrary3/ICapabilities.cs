using System.Reflection;

namespace OpenQA.Selenium
{
    public interface ICapabilities
    {
        object this[string capabilityName] { get; }

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
        object GetCapability(string capability);
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
        bool HasCapability(string capability);
    }
}
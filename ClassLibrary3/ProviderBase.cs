using System.Collections.Specialized;

namespace System.Configuration.Provider
{
    public abstract class ProviderBase
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern ProviderBase();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the friendly name used to refer to the provider during configuration.
        //
        // Returns:
        //     The friendly name used to refer to the provider during configuration.
        public virtual string Name { get; }
        //
        // Summary:
        //     Gets a brief, friendly description suitable for display in administrative tools
        //     or other user interfaces (UIs).
        //
        // Returns:
        //     A brief, friendly description suitable for display in administrative tools or
        //     other UIs.
        public virtual string Description { get; }


        //
        // Summary:
        //     Initializes the configuration builder.
        //
        // Parameters:
        //   name:
        //     The friendly name of the provider.
        //
        //   config:
        //     A collection of the name/value pairs representing the provider-specific attributes
        //     specified in the configuration for this provider.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The name of the provider is null.
        //
        //   T:System.ArgumentException:
        //     The name of the provider has a length of zero.
        //
        //   T:System.InvalidOperationException:
        //     An attempt is made to call System.Configuration.Provider.ProviderBase.Initialize(System.String,System.Collections.Specialized.NameValueCollection)
        //     on a provider after the provider has already been initialized.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual void Initialize(string name, NameValueCollection config);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
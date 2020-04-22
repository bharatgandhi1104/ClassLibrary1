using System.Collections;

namespace System.Configuration
{
    public class ConfigurationLocationCollection : ReadOnlyCollectionBase
    {
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationLocation this[int index] { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
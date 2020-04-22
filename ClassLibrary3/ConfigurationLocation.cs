namespace System.Configuration
{
    public class ConfigurationLocation
    {
        public string Path { get; }


        //
        // Summary:
        //     Creates an instance of a Configuration object.
        //
        // Returns:
        //     A Configuration object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Configuration OpenConfiguration();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
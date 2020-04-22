namespace System.Configuration
{
    public class ConnectionStringsSection
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern ConnectionStringsSection();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets a System.Configuration.ConnectionStringSettingsCollection collection of
        //     System.Configuration.ConnectionStringSettings objects.
        //
        // Returns:
        //     A System.Configuration.ConnectionStringSettingsCollection collection of System.Configuration.ConnectionStringSettings
        //     objects.
        // [ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
        public ConnectionStringSettingsCollection ConnectionStrings { get; }
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern ConfigurationPropertyCollection Properties { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern object RuntimeObject { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

namespace System.Configuration
{
    public class ConnectionStringSettings
    {
        public extern ConnectionStringSettings();
        //
        // Summary:
        //     Initializes a new instance of a System.Configuration.ConnectionStringSettings
        //     class.
        //
        // Parameters:
        //   name:
        //     The name of the connection string.
        //
        //   connectionString:
        //     The connection string.
        public extern ConnectionStringSettings(string name, string connectionString);
        //
        // Summary:
        //     Initializes a new instance of a System.Configuration.ConnectionStringSettings
        //     object.
        //
        // Parameters:
        //   name:
        //     The name of the connection string.
        //
        //   connectionString:
        //     The connection string.
        //
        //   providerName:
        //     The name of the provider to use with the connection string.
        public extern ConnectionStringSettings(string name, string connectionString, string providerName);

        //
        // Summary:
        //     Gets or sets the System.Configuration.ConnectionStringSettings name.
        //
        // Returns:
        //     The string value assigned to the System.Configuration.ConnectionStringSettings.Name
        //     property.
        //[ConfigurationProperty("name", Options = ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey, DefaultValue = "")]
        public string Name { get; set; }
        //
        // Summary:
        //     Gets or sets the connection string.
        //
        // Returns:
        //     The string value assigned to the System.Configuration.ConnectionStringSettings.ConnectionString
        //     property.
        // [ConfigurationProperty("connectionString", Options = ConfigurationPropertyOptions.IsRequired, DefaultValue = "")]
        public string ConnectionString { get; set; }
        //
        // Summary:
        //     Gets or sets the provider name property.
        //
        // Returns:
        //     Gets or sets the System.Configuration.ConnectionStringSettings.ProviderName property.
        // [ConfigurationProperty("providerName", DefaultValue = "System.Data.SqlClient")]
        public string ProviderName { get; set; }
        protected internal ConfigurationPropertyCollection Properties { get; }

        //
        // Summary:
        //     Returns a string representation of the object.
        //
        // Returns:
        //     A string representation of the object.
        public extern string ToString();
    }
}

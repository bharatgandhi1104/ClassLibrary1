namespace System.Configuration
{
    public class KeyValueConfigurationElement : ConfigurationElement
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern KeyValueConfigurationElement(string key, string value);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the key of the System.Configuration.KeyValueConfigurationElement object.
        //
        // Returns:
        //     The key of the System.Configuration.KeyValueConfigurationElement.
        //[ConfigurationProperty("key", Options = ConfigurationPropertyOptions.IsKey, DefaultValue = "")]
        public string Key { get; }
        //
        // Summary:
        //     Gets or sets the value of the System.Configuration.KeyValueConfigurationElement
        //     object.
        //
        // Returns:
        //     The value of the System.Configuration.KeyValueConfigurationElement.
        //[ConfigurationProperty("value", DefaultValue = "")]
        public string Value { get; set; }
        //
        // Summary:
        //     Gets the collection of properties.
        //
        // Returns:
        //     The System.Configuration.ConfigurationPropertyCollection of properties for the
        //     element.
        protected ConfigurationPropertyCollection Properties { get; }

        //
        // Summary:
        //     Sets the System.Configuration.KeyValueConfigurationElement object to its initial
        //     state.
        protected extern void Init();
    }
}
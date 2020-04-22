namespace System.Configuration
{
    public class KeyValueConfigurationCollection
    {
        public extern KeyValueConfigurationCollection();

        //
        // Summary:
        //     Gets the System.Configuration.KeyValueConfigurationElement object based on the
        //     supplied parameter.
        //
        // Parameters:
        //   key:
        //     The key of the System.Configuration.KeyValueConfigurationElement contained in
        //     the collection.
        //
        // Returns:
        //     A configuration element, or null if the key does not exist in the collection.
        public extern KeyValueConfigurationElement this[string key] { get; }

        //
        // Summary:
        //     Gets the keys to all items contained in the System.Configuration.KeyValueConfigurationCollection
        //     collection.
        //
        // Returns:
        //     A string array.
        public string[] AllKeys { get; }
        //
        // Summary:
        //     Gets a value indicating whether an attempt to add a duplicate System.Configuration.KeyValueConfigurationElement
        //     object to the System.Configuration.KeyValueConfigurationCollection collection
        //     will cause an exception to be thrown.
        //
        // Returns:
        //     true if an attempt to add a duplicate System.Configuration.KeyValueConfigurationElement
        //     to the System.Configuration.KeyValueConfigurationCollection will cause an exception
        //     to be thrown; otherwise, false.
        protected bool ThrowOnDuplicate { get; }
        //
        // Summary:
        //     Gets a collection of configuration properties.
        //
        // Returns:
        //     A collection of configuration properties.
        protected ConfigurationPropertyCollection Properties { get; }

        //
        // Summary:
        //     Adds a System.Configuration.KeyValueConfigurationElement object to the collection
        //     based on the supplied parameters.
        //
        // Parameters:
        //   keyValue:
        //     A System.Configuration.KeyValueConfigurationElement.
        public extern void Add(KeyValueConfigurationElement keyValue);
        //
        // Summary:
        //     Adds a System.Configuration.KeyValueConfigurationElement object to the collection
        //     based on the supplied parameters.
        //
        // Parameters:
        //   key:
        //     A string specifying the key.
        //
        //   value:
        //     A string specifying the value.
        public extern void Add(string key, string value);
        //
        // Summary:
        //     Clears the System.Configuration.KeyValueConfigurationCollection collection.
        public extern void Clear();
        //
        // Summary:
        //     Removes a System.Configuration.KeyValueConfigurationElement object from the collection.
        //
        // Parameters:
        //   key:
        //     A string specifying the key.
        public extern void Remove(string key);
        //
        // Summary:
        //     When overridden in a derived class, the System.Configuration.KeyValueConfigurationCollection.CreateNewElement
        //     method creates a new System.Configuration.KeyValueConfigurationElement object.
        //
        // Returns:
        //     A newly created System.Configuration.KeyValueConfigurationElement.
        protected extern ConfigurationElement CreateNewElement();
        //
        // Summary:
        //     Gets the element key for a specified configuration element when overridden in
        //     a derived class.
        //
        // Parameters:
        //   element:
        //     The System.Configuration.KeyValueConfigurationElement to which the key should
        //     be returned.
        //
        // Returns:
        //     An object that acts as the key for the specified System.Configuration.KeyValueConfigurationElement.
        protected extern object GetElementKey(ConfigurationElement element);
    }
}
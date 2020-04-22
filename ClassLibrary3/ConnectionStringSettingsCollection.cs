namespace System.Configuration
{
    public class ConnectionStringSettingsCollection
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern ConnectionStringSettingsCollection();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets or sets the connection string at the specified index in the collection.
        //
        // Parameters:
        //   index:
        //     The index of a System.Configuration.ConnectionStringSettings object in the collection.
        //
        // Returns:
        //     The System.Configuration.ConnectionStringSettings object at the specified index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConnectionStringSettings this[int index] { get; set; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets or sets the System.Configuration.ConnectionStringSettings object with the
        //     specified name in the collection.
        //
        // Parameters:
        //   name:
        //     The name of a System.Configuration.ConnectionStringSettings object in the collection.
        //
        // Returns:
        //     The System.Configuration.ConnectionStringSettings object with the specified name;
        //     otherwise, null.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConnectionStringSettings this[string name] { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        protected internal ConfigurationPropertyCollection Properties { get; }


        //
        // Summary:
        //     Adds a System.Configuration.ConnectionStringSettings object to the collection.
        //
        // Parameters:
        //   settings:
        //     A System.Configuration.ConnectionStringSettings object to add to the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Add(ConnectionStringSettings settings);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes all the System.Configuration.ConnectionStringSettings objects from the
        //     collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Clear();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns the collection index of the passed System.Configuration.ConnectionStringSettings
        //     object.
        //
        // Parameters:
        //   settings:
        //     A System.Configuration.ConnectionStringSettings object in the collection.
        //
        // Returns:
        //     The collection index of the specified System.Configuration.ConnectionStringSettingsCollection
        //     object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern int IndexOf(ConnectionStringSettings settings);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes the specified System.Configuration.ConnectionStringSettings object from
        //     the collection.
        //
        // Parameters:
        //   settings:
        //     A System.Configuration.ConnectionStringSettings object in the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Remove(ConnectionStringSettings settings);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes the specified System.Configuration.ConnectionStringSettings object from
        //     the collection.
        //
        // Parameters:
        //   name:
        //     The name of a System.Configuration.ConnectionStringSettings object in the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Remove(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes the System.Configuration.ConnectionStringSettings object at the specified
        //     index in the collection.
        //
        // Parameters:
        //   index:
        //     The index of a System.Configuration.ConnectionStringSettings object in the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void RemoveAt(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void BaseAdd(int index, ConfigurationElement element);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern ConfigurationElement CreateNewElement();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern object GetElementKey(ConfigurationElement element);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
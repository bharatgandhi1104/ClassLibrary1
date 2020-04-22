using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;


namespace System.Configuration
{
    public sealed class ConfigurationSectionCollection : NameObjectCollectionBase
    {
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSection this[string name] { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the specified System.Configuration.ConfigurationSection object.
        //
        // Parameters:
        //   index:
        //     The index of the System.Configuration.ConfigurationSection object to be returned.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSection object at the specified index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSection this[int index] { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the number of sections in this System.Configuration.ConfigurationSectionCollection
        //     object.
        //
        // Returns:
        //     An integer that represents the number of sections in the collection.
        public override int Count { get; }
        //
        // Summary:
        //     Gets the keys to all System.Configuration.ConfigurationSection objects contained
        //     in this System.Configuration.ConfigurationSectionCollection object.
        //
        // Returns:
        //     A System.Collections.Specialized.NameObjectCollectionBase.KeysCollection object
        //     that contains the keys of all sections in this collection.
        public override KeysCollection Keys { get; }


        //
        // Summary:
        //     Adds a System.Configuration.ConfigurationSection object to the System.Configuration.ConfigurationSectionCollection
        //     object.
        //
        // Parameters:
        //   name:
        //     The name of the section to be added.
        //
        //   section:
        //     The section to be added.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Add(string name, ConfigurationSection section);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Clears this System.Configuration.ConfigurationSectionCollection object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Clear();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Copies this System.Configuration.ConfigurationSectionCollection object to an
        //     array.
        //
        // Parameters:
        //   array:
        //     The array to copy the System.Configuration.ConfigurationSectionCollection object
        //     to.
        //
        //   index:
        //     The index location at which to begin copying.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     array is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of array is less than the value of System.Configuration.ConfigurationSectionCollection.Count
        //     plus index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void CopyTo(ConfigurationSection[] array, int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the specified System.Configuration.ConfigurationSection object contained
        //     in this System.Configuration.ConfigurationSectionCollection object.
        //
        // Parameters:
        //   index:
        //     The index of the System.Configuration.ConfigurationSection object to be returned.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSection object at the specified index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSection Get(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the specified System.Configuration.ConfigurationSection object contained
        //     in this System.Configuration.ConfigurationSectionCollection object.
        //
        // Parameters:
        //   name:
        //     The name of the System.Configuration.ConfigurationSection object to be returned.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSection object with the specified name.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     name is null or an empty string ("").
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSection Get(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets an enumerator that can iterate through this System.Configuration.ConfigurationSectionCollection
        //     object.
        //
        // Returns:
        //     An System.Collections.IEnumerator that can be used to iterate through this System.Configuration.ConfigurationSectionCollection
        //     object.
        // [IteratorStateMachine(typeof(< GetEnumerator > d__17))]
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override IEnumerator GetEnumerator();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the key of the specified System.Configuration.ConfigurationSection object
        //     contained in this System.Configuration.ConfigurationSectionCollection object.
        //
        // Parameters:
        //   index:
        //     The index of the System.Configuration.ConfigurationSection object whose key is
        //     to be returned.
        //
        // Returns:
        //     The key of the System.Configuration.ConfigurationSection object at the specified
        //     index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string GetKey(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Used by the system during serialization.
        //
        // Parameters:
        //   info:
        //     The applicable System.Runtime.Serialization.SerializationInfo object.
        //
        //   context:
        //     The applicable System.Runtime.Serialization.StreamingContext object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override void GetObjectData(SerializationInfo info, StreamingContext context);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes the specified System.Configuration.ConfigurationSection object from this
        //     System.Configuration.ConfigurationSectionCollection object.
        //
        // Parameters:
        //   name:
        //     The name of the section to be removed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Remove(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Removes the specified System.Configuration.ConfigurationSection object from this
        //     System.Configuration.ConfigurationSectionCollection object.
        //
        // Parameters:
        //   index:
        //     The index of the section to be removed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void RemoveAt(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
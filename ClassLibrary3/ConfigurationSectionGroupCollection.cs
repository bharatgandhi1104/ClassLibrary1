using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Configuration
{
    public sealed class ConfigurationSectionGroupCollection : NameObjectCollectionBase
    {
        public extern ConfigurationSectionGroup this[string name] { get; }
        //
        // Summary:
        //     Gets the System.Configuration.ConfigurationSectionGroup object whose index is
        //     specified from the collection.
        //
        // Parameters:
        //   index:
        //     The index of the System.Configuration.ConfigurationSectionGroup object to be
        //     returned.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSectionGroup object at the specified index.In
        //     C#, this property is the indexer for the System.Configuration.ConfigurationSectionCollection
        //     class.
        public extern ConfigurationSectionGroup this[int index] { get; }

        //
        // Summary:
        //     Gets the number of section groups in the collection.
        //
        // Returns:
        //     An integer that represents the number of section groups in the collection.
        public override int Count { get; }
        //
        // Summary:
        //     Gets the keys to all System.Configuration.ConfigurationSectionGroup objects contained
        //     in this System.Configuration.ConfigurationSectionGroupCollection object.
        //
        // Returns:
        //     A System.Collections.Specialized.NameObjectCollectionBase.KeysCollection object
        //     that contains the names of all section groups in this collection.
        public override KeysCollection Keys { get; }


        //
        // Summary:
        //     Adds a System.Configuration.ConfigurationSectionGroup object to this System.Configuration.ConfigurationSectionGroupCollection
        //     object.
        //
        // Parameters:
        //   name:
        //     The name of the System.Configuration.ConfigurationSectionGroup object to be added.
        //
        //   sectionGroup:
        //     The System.Configuration.ConfigurationSectionGroup object to be added.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Add(string name, ConfigurationSectionGroup sectionGroup);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Clears the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Clear();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Copies this System.Configuration.ConfigurationSectionGroupCollection object to
        //     an array.
        //
        // Parameters:
        //   array:
        //     The array to copy the object to.
        //
        //   index:
        //     The index location at which to begin copying.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     array is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of array is less than the value of System.Configuration.ConfigurationSectionGroupCollection.Count
        //     plus index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void CopyTo(ConfigurationSectionGroup[] array, int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the specified System.Configuration.ConfigurationSectionGroup object contained
        //     in the collection.
        //
        // Parameters:
        //   index:
        //     The index of the System.Configuration.ConfigurationSectionGroup object to be
        //     returned.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSectionGroup object at the specified index.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSectionGroup Get(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the specified System.Configuration.ConfigurationSectionGroup object from
        //     the collection.
        //
        // Parameters:
        //   name:
        //     The name of the System.Configuration.ConfigurationSectionGroup object to be returned.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSectionGroup object with the specified
        //     name.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     name is null or an empty string ("").
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSectionGroup Get(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets an enumerator that can iterate through the System.Configuration.ConfigurationSectionGroupCollection
        //     object.
        //
        // Returns:
        //     An System.Collections.IEnumerator that can be used to iterate through the System.Configuration.ConfigurationSectionGroupCollection
        //     object.
        // [IteratorStateMachine(typeof(< GetEnumerator > d__17))]
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override IEnumerator GetEnumerator();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the key of the specified System.Configuration.ConfigurationSectionGroup
        //     object contained in this System.Configuration.ConfigurationSectionGroupCollection
        //     object.
        //
        // Parameters:
        //   index:
        //     The index of the section group whose key is to be returned.
        //
        // Returns:
        //     The key of the System.Configuration.ConfigurationSectionGroup object at the specified
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
        //     Removes the System.Configuration.ConfigurationSectionGroup object whose name
        //     is specified from this System.Configuration.ConfigurationSectionGroupCollection
        //     object.
        //
        // Parameters:
        //   name:
        //     The name of the section group to be removed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Remove(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes the System.Configuration.ConfigurationSectionGroup object whose index
        //     is specified from this System.Configuration.ConfigurationSectionGroupCollection
        //     object.
        //
        // Parameters:
        //   index:
        //     The index of the section group to be removed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void RemoveAt(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
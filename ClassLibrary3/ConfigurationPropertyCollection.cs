﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections;
using System.Reflection;

namespace System.Configuration
{
    public class ConfigurationPropertyCollection : ICollection, IEnumerable
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern ConfigurationPropertyCollection();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the collection item with the specified name.
        //
        // Parameters:
        //   name:
        //     The System.Configuration.ConfigurationProperty to return.
        //
        // Returns:
        //     The System.Configuration.ConfigurationProperty with the specified name.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationProperty this[string name] { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the number of properties in the collection.
        //
        // Returns:
        //     The number of properties in the collection.
        public int Count { get; }
        //
        // Summary:
        //     Gets a value indicating whether access to the collection is synchronized (thread
        //     safe).
        //
        // Returns:
        //     true if access to the System.Configuration.ConfigurationPropertyCollection is
        //     synchronized; otherwise, false.
        public bool IsSynchronized { get; }
        //
        // Summary:
        //     Gets the object to synchronize access to the collection.
        //
        // Returns:
        //     The object to synchronize access to the collection.
        public object SyncRoot { get; }


        //
        // Summary:
        //     Adds a configuration property to the collection.
        //
        // Parameters:
        //   property:
        //     The System.Configuration.ConfigurationProperty to add.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Add(ConfigurationProperty property);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes all configuration property objects from the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Clear();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Specifies whether the configuration property is contained in this collection.
        //
        // Parameters:
        //   name:
        //     An identifier for the System.Configuration.ConfigurationProperty to verify.
        //
        // Returns:
        //     true if the specified System.Configuration.ConfigurationProperty is contained
        //     in the collection; otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool Contains(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Copies this ConfigurationPropertyCollection to an array.
        //
        // Parameters:
        //   array:
        //     Array to which to copy.
        //
        //   index:
        //     Index at which to begin copying.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void CopyTo(ConfigurationProperty[] array, int index);

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the System.Collections.IEnumerator object as it applies to the collection.
        //
        // Returns:
        //     The System.Collections.IEnumerator object as it applies to the collection
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern IEnumerator GetEnumerator();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Removes a configuration property from the collection.
        //
        // Parameters:
        //   name:
        //     The System.Configuration.ConfigurationProperty to remove.
        //
        // Returns:
        //     true if the specified System.Configuration.ConfigurationProperty was removed;
        //     otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool Remove(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
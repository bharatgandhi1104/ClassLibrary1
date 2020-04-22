using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace System.Configuration.Provider
{
    public class NameValueCollection
    {
        public extern NameValueCollection();
        //
        // Summary:
        //     Copies the entries from the specified System.Collections.Specialized.NameValueCollection
        //     to a new System.Collections.Specialized.NameValueCollection with the same initial
        //     capacity as the number of entries copied and using the same hash code provider
        //     and the same comparer as the source collection.
        //
        // Parameters:
        //   col:
        //     The System.Collections.Specialized.NameValueCollection to copy to the new System.Collections.Specialized.NameValueCollection
        //     instance.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     col is null.
        public extern NameValueCollection(NameValueCollection col);
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Specialized.NameValueCollection
        //     class that is empty, has the specified initial capacity and uses the default
        //     case-insensitive hash code provider and the default case-insensitive comparer.
        //
        // Parameters:
        //   capacity:
        //     The initial number of entries that the System.Collections.Specialized.NameValueCollection
        //     can contain.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     capacity is less than zero.
        public extern NameValueCollection(int capacity);
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Specialized.NameValueCollection
        //     class that is empty, has the default initial capacity, and uses the specified
        //     System.Collections.IEqualityComparer object.
        //
        // Parameters:
        //   equalityComparer:
        //     The System.Collections.IEqualityComparer object to use to determine whether two
        //     keys are equal and to generate hash codes for the keys in the collection.
        public extern NameValueCollection(IEqualityComparer equalityComparer);
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Specialized.NameValueCollection
        //     class that is empty, has the default initial capacity and uses the specified
        //     hash code provider and the specified comparer.
        //
        // Parameters:
        //   hashProvider:
        //     The System.Collections.IHashCodeProvider that will supply the hash codes for
        //     all keys in the System.Collections.Specialized.NameValueCollection.
        //
        //   comparer:
        //     The System.Collections.IComparer to use to determine whether two keys are equal.
        [Obsolete("Please use NameValueCollection(IEqualityComparer) instead.")]
        public extern NameValueCollection(Collections.IHashCodeProvider hashProvider, IComparer comparer);
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Specialized.NameValueCollection
        //     class that is empty, has the specified initial capacity, and uses the specified
        //     System.Collections.IEqualityComparer object.
        //
        // Parameters:
        //   capacity:
        //     The initial number of entries that the System.Collections.Specialized.NameValueCollection
        //     object can contain.
        //
        //   equalityComparer:
        //     The System.Collections.IEqualityComparer object to use to determine whether two
        //     keys are equal and to generate hash codes for the keys in the collection.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     capacity is less than zero.
        public extern NameValueCollection(int capacity, IEqualityComparer equalityComparer);
        //
        // Summary:
        //     Copies the entries from the specified System.Collections.Specialized.NameValueCollection
        //     to a new System.Collections.Specialized.NameValueCollection with the specified
        //     initial capacity or the same initial capacity as the number of entries copied,
        //     whichever is greater, and using the default case-insensitive hash code provider
        //     and the default case-insensitive comparer.
        //
        // Parameters:
        //   capacity:
        //     The initial number of entries that the System.Collections.Specialized.NameValueCollection
        //     can contain.
        //
        //   col:
        //     The System.Collections.Specialized.NameValueCollection to copy to the new System.Collections.Specialized.NameValueCollection
        //     instance.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     capacity is less than zero.
        //
        //   T:System.ArgumentNullException:
        //     col is null.
        public extern NameValueCollection(int capacity, NameValueCollection col);
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Specialized.NameValueCollection
        //     class that is empty, has the specified initial capacity and uses the specified
        //     hash code provider and the specified comparer.
        //
        // Parameters:
        //   capacity:
        //     The initial number of entries that the System.Collections.Specialized.NameValueCollection
        //     can contain.
        //
        //   hashProvider:
        //     The System.Collections.IHashCodeProvider that will supply the hash codes for
        //     all keys in the System.Collections.Specialized.NameValueCollection.
        //
        //   comparer:
        //     The System.Collections.IComparer to use to determine whether two keys are equal.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     capacity is less than zero.
        [Obsolete("Please use NameValueCollection(Int32, IEqualityComparer) instead.")]
        public extern NameValueCollection(int capacity, Collections.IHashCodeProvider hashProvider, IComparer comparer);
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Specialized.NameValueCollection
        //     class that is serializable and uses the specified System.Runtime.Serialization.SerializationInfo
        //     and System.Runtime.Serialization.StreamingContext.
        //
        // Parameters:
        //   info:
        //     A System.Runtime.Serialization.SerializationInfo object that contains the information
        //     required to serialize the new System.Collections.Specialized.NameValueCollection
        //     instance.
        //
        //   context:
        //     A System.Runtime.Serialization.StreamingContext object that contains the source
        //     and destination of the serialized stream associated with the new System.Collections.Specialized.NameValueCollection
        //     instance.
        protected extern NameValueCollection(SerializationInfo info, StreamingContext context);

        //
        // Summary:
        //     Gets or sets the entry with the specified key in the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   name:
        //     The System.String key of the entry to locate. The key can be null.
        //
        // Returns:
        //     A System.String that contains the comma-separated list of values associated with
        //     the specified key, if found; otherwise, null.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The collection is read-only and the operation attempts to modify the collection.
        public extern string this[string name] { get; set; }
        //
        // Summary:
        //     Gets the entry at the specified index of the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the entry to locate in the collection.
        //
        // Returns:
        //     A System.String that contains the comma-separated list of values at the specified
        //     index of the collection.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is outside the valid range of indexes for the collection.
        public extern string this[int index] { get; }

        //
        // Summary:
        //     Gets all the keys in the System.Collections.Specialized.NameValueCollection.
        //
        // Returns:
        //     A System.String array that contains all the keys of the System.Collections.Specialized.NameValueCollection.
        public virtual string[] AllKeys { get; }


        //
        // Summary:
        //     Copies the entries in the specified System.Collections.Specialized.NameValueCollection
        //     to the current System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   c:
        //     The System.Collections.Specialized.NameValueCollection to copy to the current
        //     System.Collections.Specialized.NameValueCollection.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The collection is read-only.
        //
        //   T:System.ArgumentNullException:
        //     c is null.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Add(NameValueCollection c);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Adds an entry with the specified name and value to the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   name:
        //     The System.String key of the entry to add. The key can be null.
        //
        //   value:
        //     The System.String value of the entry to add. The value can be null.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The collection is read-only.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual void Add(string name, string value);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Invalidates the cached arrays and removes all entries from the System.Collections.Specialized.NameValueCollection.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The collection is read-only.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual void Clear();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Copies the entire System.Collections.Specialized.NameValueCollection to a compatible
        //     one-dimensional System.Array, starting at the specified index of the target array.
        //
        // Parameters:
        //   dest:
        //     The one-dimensional System.Array that is the destination of the elements copied
        //     from System.Collections.Specialized.NameValueCollection. The System.Array must
        //     have zero-based indexing.
        //
        //   index:
        //     The zero-based index in dest at which copying begins.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     dest is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     index is less than zero.
        //
        //   T:System.ArgumentException:
        //     dest is multidimensional.-or- The number of elements in the source System.Collections.Specialized.NameValueCollection
        //     is greater than the available space from index to the end of the destination
        //     dest.
        //
        //   T:System.InvalidCastException:
        //     The type of the source System.Collections.Specialized.NameValueCollection cannot
        //     be cast automatically to the type of the destination dest.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void CopyTo(Array dest, int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the values associated with the specified key from the System.Collections.Specialized.NameValueCollection
        //     combined into one comma-separated list.
        //
        // Parameters:
        //   name:
        //     The System.String key of the entry that contains the values to get. The key can
        //     be null.
        //
        // Returns:
        //     A System.String that contains a comma-separated list of the values associated
        //     with the specified key from the System.Collections.Specialized.NameValueCollection,
        //     if found; otherwise, null.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual string Get(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the values at the specified index of the System.Collections.Specialized.NameValueCollection
        //     combined into one comma-separated list.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the entry that contains the values to get from the collection.
        //
        // Returns:
        //     A System.String that contains a comma-separated list of the values at the specified
        //     index of the System.Collections.Specialized.NameValueCollection, if found; otherwise,
        //     null.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is outside the valid range of indexes for the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual string Get(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the key at the specified index of the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the key to get from the collection.
        //
        // Returns:
        //     A System.String that contains the key at the specified index of the System.Collections.Specialized.NameValueCollection,
        //     if found; otherwise, null.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is outside the valid range of indexes for the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual string GetKey(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the values associated with the specified key from the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   name:
        //     The System.String key of the entry that contains the values to get. The key can
        //     be null.
        //
        // Returns:
        //     A System.String array that contains the values associated with the specified
        //     key from the System.Collections.Specialized.NameValueCollection, if found; otherwise,
        //     null.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual string[] GetValues(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets the values at the specified index of the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   index:
        //     The zero-based index of the entry that contains the values to get from the collection.
        //
        // Returns:
        //     A System.String array that contains the values at the specified index of the
        //     System.Collections.Specialized.NameValueCollection, if found; otherwise, null.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     index is outside the valid range of indexes for the collection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual string[] GetValues(int index);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Gets a value indicating whether the System.Collections.Specialized.NameValueCollection
        //     contains keys that are not null.
        //
        // Returns:
        //     true if the System.Collections.Specialized.NameValueCollection contains keys
        //     that are not null; otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool HasKeys();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Removes the entries with the specified key from the System.Collections.Specialized.NameObjectCollectionBase
        //     instance.
        //
        // Parameters:
        //   name:
        //     The System.String key of the entry to remove. The key can be null.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The collection is read-only.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual void Remove(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Sets the value of an entry in the System.Collections.Specialized.NameValueCollection.
        //
        // Parameters:
        //   name:
        //     The System.String key of the entry to add the new value to. The key can be null.
        //
        //   value:
        //     The System.Object that represents the new value to add to the specified entry.
        //     The value can be null.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The collection is read-only.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual void Set(string name, string value);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Resets the cached arrays of the collection to null.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void InvalidateCachedArrays();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
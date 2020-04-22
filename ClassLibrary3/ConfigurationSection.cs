using System.Runtime.Versioning;
using System.Xml;

namespace System.Configuration
{
    public abstract class ConfigurationSection : ConfigurationElement
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern ConfigurationSection();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets a System.Configuration.SectionInformation object that contains the non-customizable
        //     information and functionality of the System.Configuration.ConfigurationSection
        //     object.
        //
        // Returns:
        //     A System.Configuration.SectionInformation that contains the non-customizable
        //     information and functionality of the System.Configuration.ConfigurationSection.
        public SectionInformation SectionInformation { get; }


        //
        // Summary:
        //     Reads XML from the configuration file.
        //
        // Parameters:
        //   reader:
        //     The System.Xml.XmlReader object, which reads from the configuration file.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     reader found no elements in the configuration file.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void DeserializeSection(XmlReader reader);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns a custom object when overridden in a derived class.
        //
        // Returns:
        //     The object representing the section.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual object GetRuntimeObject();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it


        //
        // Summary:
        //     Indicates whether this configuration element has been modified since it was last
        //     saved or loaded when implemented in a derived class.
        //
        // Returns:
        //     true if the element has been modified; otherwise, false.
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern bool IsModified();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        //
        // Summary:
        //     Resets the value of the System.Configuration.ConfigurationElement.IsModified
        //     method to false when implemented in a derived class.
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void ResetModified();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        //
        // Summary:
        //     Creates an XML string containing an unmerged view of the System.Configuration.ConfigurationSection
        //     object as a single section to write to a file.
        //
        // Parameters:
        //   parentElement:
        //     The System.Configuration.ConfigurationElement instance to use as the parent when
        //     performing the un-merge.
        //
        //   name:
        //     The name of the section to create.
        //
        //   saveMode:
        //     The System.Configuration.ConfigurationSaveMode instance to use when writing to
        //     a string.
        //
        // Returns:
        //     An XML string containing an unmerged view of the System.Configuration.ConfigurationSection
        //     object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Indicates whether the specified element should be serialized when the configuration
        //     object hierarchy is serialized for the specified target version of the .NET Framework.
        //
        // Parameters:
        //   element:
        //     The System.Configuration.ConfigurationElement object that is a candidate for
        //     serialization.
        //
        //   elementName:
        //     The name of the System.Configuration.ConfigurationElement object as it occurs
        //     in XML.
        //
        //   targetFramework:
        //     The target version of the .NET Framework.
        //
        // Returns:
        //     true if the element should be serialized; otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual bool ShouldSerializeElementInTargetVersion(ConfigurationElement element, string elementName, FrameworkName targetFramework);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Indicates whether the specified property should be serialized when the configuration
        //     object hierarchy is serialized for the specified target version of the .NET Framework.
        //
        // Parameters:
        //   property:
        //     The System.Configuration.ConfigurationProperty object that is a candidate for
        //     serialization.
        //
        //   propertyName:
        //     The name of the System.Configuration.ConfigurationProperty object as it occurs
        //     in XML.
        //
        //   targetFramework:
        //     The target version of the .NET Framework.
        //
        //   parentConfigurationElement:
        //     The parent element of the property.
        //
        // Returns:
        //     true if the property should be serialized; otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual bool ShouldSerializePropertyInTargetVersion(ConfigurationProperty property, string propertyName, FrameworkName targetFramework, ConfigurationElement parentConfigurationElement);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Indicates whether the current System.Configuration.ConfigurationSection instance
        //     should be serialized when the configuration object hierarchy is serialized for
        //     the specified target version of the .NET Framework.
        //
        // Parameters:
        //   targetFramework:
        //     The target version of the .NET Framework.
        //
        // Returns:
        //     true if the current section should be serialized; otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual bool ShouldSerializeSectionInTargetVersion(FrameworkName targetFramework);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

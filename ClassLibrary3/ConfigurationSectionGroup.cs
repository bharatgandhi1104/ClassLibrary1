using System.Runtime.Versioning;

namespace System.Configuration
{
    public class ConfigurationSectionGroup
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern ConfigurationSectionGroup();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets a value that indicates whether this System.Configuration.ConfigurationSectionGroup
        //     object is declared.
        //
        // Returns:
        //     true if this System.Configuration.ConfigurationSectionGroup is declared; otherwise,
        //     false. The default is false.
        public bool IsDeclared { get; }
        //
        // Summary:
        //     Gets a value that indicates whether this System.Configuration.ConfigurationSectionGroup
        //     object declaration is required.
        //
        // Returns:
        //     true if this System.Configuration.ConfigurationSectionGroup declaration is required;
        //     otherwise, false.
        public bool IsDeclarationRequired { get; }
        //
        // Summary:
        //     Gets the section group name associated with this System.Configuration.ConfigurationSectionGroup.
        //
        // Returns:
        //     The section group name of this System.Configuration.ConfigurationSectionGroup
        //     object.
        public string SectionGroupName { get; }
        //
        // Summary:
        //     Gets the name property of this System.Configuration.ConfigurationSectionGroup
        //     object.
        //
        // Returns:
        //     The name property of this System.Configuration.ConfigurationSectionGroup object.
        public string Name { get; }
        //
        // Summary:
        //     Gets or sets the type for this System.Configuration.ConfigurationSectionGroup
        //     object.
        //
        // Returns:
        //     The type of this System.Configuration.ConfigurationSectionGroup object.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Configuration.ConfigurationSectionGroup object is the root section
        //     group.- or -The System.Configuration.ConfigurationSectionGroup object has a location.
        //
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The section or group is already defined at another level.
        public string Type { get; set; }
        //
        // Summary:
        //     Gets a System.Configuration.ConfigurationSectionCollection object that contains
        //     all of System.Configuration.ConfigurationSection objects within this System.Configuration.ConfigurationSectionGroup
        //     object.
        //
        // Returns:
        //     A System.Configuration.ConfigurationSectionCollection object that contains all
        //     the System.Configuration.ConfigurationSection objects within this System.Configuration.ConfigurationSectionGroup
        //     object.
        public ConfigurationSectionCollection Sections { get; }
        //
        // Summary:
        //     Gets a System.Configuration.ConfigurationSectionGroupCollection object that contains
        //     all the System.Configuration.ConfigurationSectionGroup objects that are children
        //     of this System.Configuration.ConfigurationSectionGroup object.
        //
        // Returns:
        //     A System.Configuration.ConfigurationSectionGroupCollection object that contains
        //     all the System.Configuration.ConfigurationSectionGroup objects that are children
        //     of this System.Configuration.ConfigurationSectionGroup object.
        public ConfigurationSectionGroupCollection SectionGroups { get; }


        //
        // Summary:
        //     Forces the declaration for this System.Configuration.ConfigurationSectionGroup
        //     object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ForceDeclaration();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Forces the declaration for this System.Configuration.ConfigurationSectionGroup
        //     object.
        //
        // Parameters:
        //   force:
        //     true if the System.Configuration.ConfigurationSectionGroup object must be written
        //     to the file; otherwise, false.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Configuration.ConfigurationSectionGroup object is the root section
        //     group.- or -The System.Configuration.ConfigurationSectionGroup object has a location.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ForceDeclaration(bool force);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Indicates whether the current System.Configuration.ConfigurationSectionGroup
        //     instance should be serialized when the configuration object hierarchy is serialized
        //     for the specified target version of the .NET Framework.
        //
        // Parameters:
        //   targetFramework:
        //     The target version of the .NET Framework.
        //
        // Returns:
        //     true if the current section group should be serialized; otherwise, false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern internal virtual bool ShouldSerializeSectionGroupInTargetVersion(FrameworkName targetFramework);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
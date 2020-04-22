using System.Runtime.Versioning;

namespace System.Configuration
{
    public sealed class Configuration
    {
        public string FilePath { get; }
        //
        // Summary:
        //     Specifies a function delegate that is used to transform type strings in configuration
        //     files.
        //
        // Returns:
        //     A delegate that transforms type strings. The default value is null.
        public Func<string, string> TypeStringTransformer { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the configuration file has an XML namespace.
        //
        // Returns:
        //     true if the configuration file has an XML namespace; otherwise, false.
        public bool NamespaceDeclared { get; set; }
        //
        // Summary:
        //     Gets a collection of the section groups defined by this configuration.
        //
        // Returns:
        //     A System.Configuration.ConfigurationSectionGroupCollection collection representing
        //     the collection of section groups for this System.Configuration.Configuration
        //     object.
        public ConfigurationSectionGroupCollection SectionGroups { get; }
        //
        // Summary:
        //     Gets a collection of the sections defined by this System.Configuration.Configuration
        //     object.
        //
        // Returns:
        //     A collection of the sections defined by this System.Configuration.Configuration
        //     object.
        public ConfigurationSectionCollection Sections { get; }
        //
        // Summary:
        //     Gets the root System.Configuration.ConfigurationSectionGroup for this System.Configuration.Configuration
        //     object.
        //
        // Returns:
        //     The root section group for this System.Configuration.Configuration object.
        public ConfigurationSectionGroup RootSectionGroup { get; }
        //
        // Summary:
        //     Gets the System.Configuration.ContextInformation object for the System.Configuration.Configuration
        //     object.
        //
        // Returns:
        //     The System.Configuration.ContextInformation object for the System.Configuration.Configuration
        //     object.
        public ContextInformation EvaluationContext { get; }
        //
        // Summary:
        //     Gets the locations defined within this System.Configuration.Configuration object.
        //
        // Returns:
        //     A System.Configuration.ConfigurationLocationCollection containing the locations
        //     defined within this System.Configuration.Configuration object.
        public ConfigurationLocationCollection Locations { get; }
        //
        // Summary:
        //     Gets a value that indicates whether a file exists for the resource represented
        //     by this System.Configuration.Configuration object.
        //
        // Returns:
        //     true if there is a configuration file; otherwise, false.
        public bool HasFile { get; }
        //
        // Summary:
        //     Specifies a function delegate that is used to transform assembly strings in configuration
        //     files.
        //
        // Returns:
        //     A delegate that transforms type strings. The default value is null.
        public Func<string, string> AssemblyStringTransformer { get; set; }
        //
        // Summary:
        //     Specifies the targeted version of the .NET Framework when a version earlier than
        //     the current one is targeted.
        //
        // Returns:
        //     The name of the targeted version of the .NET Framework. The default value is
        //     null, which indicates that the current version is targeted.
        public FrameworkName TargetFramework { get; set; }
        //
        // Summary:
        //     Gets the System.Configuration.AppSettingsSection object configuration section
        //     that applies to this System.Configuration.Configuration object.
        //
        // Returns:
        //     An System.Configuration.AppSettingsSection object representing the appSettings
        //     configuration section that applies to this System.Configuration.Configuration
        //     object.
        public AppSettingsSection AppSettings { get; }
        //
        // Summary:
        //     Gets a System.Configuration.ConnectionStringsSection configuration-section object
        //     that applies to this System.Configuration.Configuration object.
        //
        // Returns:
        //     A System.Configuration.ConnectionStringsSection configuration-section object
        //     representing the connectionStrings configuration section that applies to this
        //     System.Configuration.Configuration object.
        public ConnectionStringsSection ConnectionStrings { get; }

        //
        // Summary:
        //     Returns the specified System.Configuration.ConfigurationSection object.
        //
        // Parameters:
        //   sectionName:
        //     The path to the section to be returned.
        //
        // Returns:
        //     The specified System.Configuration.ConfigurationSection object.
        public extern ConfigurationSection GetSection(string sectionName);
        //
        // Summary:
        //     Gets the specified System.Configuration.ConfigurationSectionGroup object.
        //
        // Parameters:
        //   sectionGroupName:
        //     The path name of the System.Configuration.ConfigurationSectionGroup to return.
        //
        // Returns:
        //     The System.Configuration.ConfigurationSectionGroup specified.
        public extern ConfigurationSectionGroup GetSectionGroup(string sectionGroupName);

        //
        // Summary:
        //     Writes the configuration settings contained within this System.Configuration.Configuration
        //     object to the current XML configuration file.
        //
        // Parameters:
        //   saveMode:
        //     A System.Configuration.ConfigurationSaveMode value that determines which property
        //     values to save.
        //
        //   forceSaveAll:
        //     true to save even if the configuration was not modified; otherwise, false.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The configuration file could not be written to.- or -The configuration file has
        //     changed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Save(ConfigurationSaveMode saveMode, bool forceSaveAll);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Writes the configuration settings contained within this System.Configuration.Configuration
        //     object to the current XML configuration file.
        //
        // Parameters:
        //   saveMode:
        //     A System.Configuration.ConfigurationSaveMode value that determines which property
        //     values to save.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The configuration file could not be written to.- or -The configuration file has
        //     changed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Save(ConfigurationSaveMode saveMode);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Writes the configuration settings contained within this System.Configuration.Configuration
        //     object to the current XML configuration file.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The configuration file could not be written to.- or -The configuration file has
        //     changed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Save();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Writes the configuration settings contained within this System.Configuration.Configuration
        //     object to the specified XML configuration file.
        //
        // Parameters:
        //   filename:
        //     The path and file name to save the configuration file to.
        //
        //   saveMode:
        //     A System.Configuration.ConfigurationSaveMode value that determines which property
        //     values to save.
        //
        //   forceSaveAll:
        //     true to save even if the configuration was not modified; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     filename is null or an empty string ("").
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SaveAs(string filename, ConfigurationSaveMode saveMode, bool forceSaveAll);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Writes the configuration settings contained within this System.Configuration.Configuration
        //     object to the specified XML configuration file.
        //
        // Parameters:
        //   filename:
        //     The path and file name to save the configuration file to.
        //
        //   saveMode:
        //     A System.Configuration.ConfigurationSaveMode value that determines which property
        //     values to save.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The configuration file could not be written to.- or -The configuration file has
        //     changed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SaveAs(string filename, ConfigurationSaveMode saveMode);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Writes the configuration settings contained within this System.Configuration.Configuration
        //     object to the specified XML configuration file.
        //
        // Parameters:
        //   filename:
        //     The path and file name to save the configuration file to.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The configuration file could not be written to.- or -The configuration file has
        //     changed.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SaveAs(string filename);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}


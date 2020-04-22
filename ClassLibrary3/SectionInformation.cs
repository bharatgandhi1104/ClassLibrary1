namespace System.Configuration
{
    public class SectionInformation
    {
        public bool AllowOverride { get; set; }
        //
        // Summary:
        //     Gets a value that indicates whether the associated configuration section requires
        //     access permissions.
        //
        // Returns:
        //     true if the requirePermission attribute is set to true; otherwise, false. The
        //     default is true.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The selected value conflicts with a value that is already defined.
        public bool RequirePermission { get; set; }
        //
        // Summary:
        //     Gets or sets a value that specifies whether a change in an external configuration
        //     include file requires an application restart.
        //
        // Returns:
        //     true if a change in an external configuration include file requires an application
        //     restart; otherwise, false. The default is true.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The selected value conflicts with a value that is already defined.
        public bool RestartOnExternalChanges { get; set; }
        //
        // Summary:
        //     Gets the protected configuration provider for the associated configuration section.
        //
        // Returns:
        //     The protected configuration provider for this System.Configuration.ConfigurationSection
        //     object.
        public ProtectedConfigurationProvider ProtectionProvider { get; }
        //
        // Summary:
        //     Gets the System.Configuration.ConfigurationBuilder object for this configuration
        //     section.
        //
        // Returns:
        //     The System.Configuration.ConfigurationBuilder object for this configuration section.
        public ConfigurationBuilder ConfigurationBuilder { get; }
        //
        // Summary:
        //     Gets a value that indicates whether the associated configuration section is protected.
        //
        // Returns:
        //     true if this System.Configuration.ConfigurationSection is protected; otherwise,
        //     false. The default is false.
        public bool IsProtected { get; }
        //
        // Summary:
        //     Gets a value that indicates whether the associated configuration section is locked.
        //
        // Returns:
        //     true if the section is locked; otherwise, false.
        public bool IsLocked { get; }
        //
        // Summary:
        //     Gets a value that indicates whether the configuration section must be declared
        //     in the configuration file.
        //
        // Returns:
        //     true if the associated System.Configuration.ConfigurationSection object must
        //     be declared in the configuration file; otherwise, false.
        public bool IsDeclarationRequired { get; }
        //
        // Summary:
        //     Gets a value that indicates whether the associated configuration section is declared
        //     in the configuration file.
        //
        // Returns:
        //     true if this System.Configuration.ConfigurationSection is declared in the configuration
        //     file; otherwise, false. The default is true.
        public bool IsDeclared { get; }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the settings that are specified in
        //     the associated configuration section are inherited by applications that reside
        //     in a subdirectory of the relevant application.
        //
        // Returns:
        //     true if the settings specified in this System.Configuration.ConfigurationSection
        //     object are inherited by child applications; otherwise, false. The default is
        //     true.
        public bool InheritInChildApplications { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the include file in which the associated configuration
        //     section is defined, if such a file exists.
        //
        // Returns:
        //     The name of the include file in which the associated System.Configuration.ConfigurationSection
        //     is defined, if such a file exists; otherwise, an empty string ("").
        public string ConfigSource { get; set; }
        //
        // Summary:
        //     Gets the override behavior of a configuration section that is in turn based on
        //     whether child configuration files can lock the configuration section.
        //
        // Returns:
        //     One of the System.Configuration.OverrideMode enumeration values.
        public OverrideMode OverrideModeEffective { get; }
        //
        // Summary:
        //     Gets or sets the System.Configuration.OverrideMode enumeration value that specifies
        //     whether the associated configuration section can be overridden by child configuration
        //     files.
        //
        // Returns:
        //     One of the System.Configuration.OverrideMode enumeration values.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     An attempt was made to change both the System.Configuration.SectionInformation.AllowOverride
        //     and System.Configuration.SectionInformation.OverrideMode properties, which is
        //     not supported for compatibility reasons.
        public OverrideMode OverrideMode { get; set; }
        //
        // Summary:
        //     Gets or sets the section class name.
        //
        // Returns:
        //     The name of the class that is associated with this System.Configuration.ConfigurationSection
        //     section.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The selected value is null or an empty string ("").
        //
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The selected value conflicts with a value that is already defined.
        public string Type { get; set; }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the associated configuration section
        //     will be saved even if it has not been modified.
        //
        // Returns:
        //     true if the associated System.Configuration.ConfigurationSection object will
        //     be saved even if it has not been modified; otherwise, false. The default is false.If
        //     the configuration file is saved (even if there are no modifications), ASP.NET
        //     restarts the application.
        public bool ForceSave { get; set; }
        //
        // Summary:
        //     Gets or sets a value that specifies the default override behavior of a configuration
        //     section by child configuration files.
        //
        // Returns:
        //     One of the System.Configuration.OverrideMode enumeration values.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The override behavior is specified in a parent configuration section.
        public OverrideMode OverrideModeDefault { get; set; }
        //
        // Summary:
        //     Gets or sets a value that indicates where in the configuration file hierarchy
        //     the associated configuration section can be declared.
        //
        // Returns:
        //     A value that indicates where in the configuration file hierarchy the associated
        //     System.Configuration.ConfigurationSection object can be declared for .exe files.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The selected value conflicts with a value that is already defined.
        public ConfigurationAllowExeDefinition AllowExeDefinition { get; set; }
        //
        // Summary:
        //     Gets or sets a value that indicates where in the configuration file hierarchy
        //     the associated configuration section can be defined.
        //
        // Returns:
        //     A value that indicates where in the configuration file hierarchy the associated
        //     System.Configuration.ConfigurationSection object can be declared.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The selected value conflicts with a value that is already defined.
        public ConfigurationAllowDefinition AllowDefinition { get; set; }
        //
        // Summary:
        //     Gets the name of the associated configuration section.
        //
        // Returns:
        //     The complete name of the configuration section.
        public string Name { get; }
        //
        // Summary:
        //     Gets the name of the associated configuration section.
        //
        // Returns:
        //     The name of the associated System.Configuration.ConfigurationSection object.
        public string SectionName { get; }

        //
        // Summary:
        //     Gets or sets a value that indicates whether the configuration section allows
        //     the location attribute.
        //
        // Returns:
        //     true if the location attribute is allowed; otherwise, false. The default is true.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     The selected value conflicts with a value that is already defined.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool AllowLocation { get; set; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it


        //
        // Summary:
        //     Forces the associated configuration section to appear in the configuration file,
        //     or removes an existing section from the configuration file.
        //
        // Parameters:
        //   force:
        //     true if the associated section should be written in the configuration file; otherwise,
        //     false.
        //
        // Exceptions:
        //   T:System.Configuration.ConfigurationErrorsException:
        //     force is true and the associated section cannot be exported to the child configuration
        //     file, or it is undeclared.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ForceDeclaration(bool force);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Forces the associated configuration section to appear in the configuration file.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ForceDeclaration();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the configuration section that contains the configuration section associated
        //     with this object.
        //
        // Returns:
        //     The configuration section that contains the System.Configuration.ConfigurationSection
        //     that is associated with this System.Configuration.SectionInformation object.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The method is invoked from a parent section.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern ConfigurationSection GetParentSection();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns an XML node object that represents the associated configuration-section
        //     object.
        //
        // Returns:
        //     The XML representation for this configuration section.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     This configuration object is locked and cannot be edited.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string GetRawXml();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Marks a configuration section for protection.
        //
        // Parameters:
        //   protectionProvider:
        //     The name of the protection provider to use.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Configuration.SectionInformation.AllowLocation property is set to
        //     false.- or -The target section is already a protected data section.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ProtectSection(string protectionProvider);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Causes the associated configuration section to inherit all its values from the
        //     parent section.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     This method cannot be called outside editing mode.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void RevertToParent();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Sets the object to an XML representation of the associated configuration section
        //     within the configuration file.
        //
        // Parameters:
        //   rawXml:
        //     The XML to use.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     rawXml is null.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SetRawXml(string rawXml);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Removes the protected configuration encryption from the associated configuration
        //     section.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void UnprotectSection();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
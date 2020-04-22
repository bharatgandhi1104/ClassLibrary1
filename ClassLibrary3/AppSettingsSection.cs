using System.Xml;

namespace System.Configuration
{
    public class AppSettingsSection
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern AppSettingsSection();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets a collection of key/value pairs that contains application settings.
        //
        // Returns:
        //     A collection of key/value pairs that contains the application settings from the
        //     configuration file.
        // [ConfigurationProperty("", IsDefaultCollection = true)]
        public KeyValueConfigurationCollection Settings { get; }
        //
        // Summary:
        //     Gets or sets a configuration file that provides additional settings or overrides
        //     the settings specified in the appSettings element.
        //
        // Returns:
        //     A configuration file that provides additional settings or overrides the settings
        //     specified in the appSettings element.
        // [ConfigurationProperty("file", DefaultValue = "")]
        public string File { get; set; }
        protected extern ConfigurationPropertyCollection Properties { get; }

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void DeserializeElement(XmlReader reader, bool serializeCollectionKey);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern object GetRuntimeObject();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern bool IsModified();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern void Reset(ConfigurationElement parentSection);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

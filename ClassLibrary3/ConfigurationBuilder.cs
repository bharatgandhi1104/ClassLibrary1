using System.Configuration.Provider;
using System.Xml;

namespace System.Configuration
{
    public class ConfigurationBuilder : ProviderBase
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern ConfigurationBuilder();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Accepts a System.Configuration.ConfigurationSection object from the configuration
        //     system and returns a modified or new System.Configuration.ConfigurationSection
        //     object for further use.
        //
        // Parameters:
        //   configSection:
        //     The System.Configuration.ConfigurationSection to process.
        //
        // Returns:
        //     The processed System.Configuration.ConfigurationSection.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual ConfigurationSection ProcessConfigurationSection(ConfigurationSection configSection);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Accepts an System.Xml.XmlNode representing the raw configuration section from
        //     a config file and returns a modified or new System.Xml.XmlNode for further use.
        //
        // Parameters:
        //   rawXml:
        //     The System.Xml.XmlNode to process.
        //
        // Returns:
        //     The processed System.Xml.XmlNode.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern virtual XmlNode ProcessRawXml(XmlNode rawXml);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}

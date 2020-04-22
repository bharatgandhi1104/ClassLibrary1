using System.Xml;
using System.Configuration.Provider;

namespace System.Configuration
{
    public abstract class ProtectedConfigurationProvider : ProviderBase
    {
#pragma warning disable CS0824 // Constructor is marked external
        protected extern ProtectedConfigurationProvider();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Decrypts the passed System.Xml.XmlNode object from a configuration file.
        //
        // Parameters:
        //   encryptedNode:
        //     The System.Xml.XmlNode object to decrypt.
        //
        // Returns:
        //     The System.Xml.XmlNode object containing decrypted data.
        public abstract XmlNode Decrypt(XmlNode encryptedNode);
        //
        // Summary:
        //     Encrypts the passed System.Xml.XmlNode object from a configuration file.
        //
        // Parameters:
        //   node:
        //     The System.Xml.XmlNode object to encrypt.
        //
        // Returns:
        //     The System.Xml.XmlNode object containing encrypted data.
        public abstract XmlNode Encrypt(XmlNode node);
    }
}
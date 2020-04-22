using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenQA.Selenium
{
    public class Proxy
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern Proxy();
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the OpenQA.Selenium.Proxy class with the given
        //     proxy settings.
        //
        // Parameters:
        //   settings:
        //     A dictionary of settings to use with the proxy.
#pragma warning disable CS0824 // Constructor is marked external
        public extern Proxy(Dictionary<string, object> settings);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets or sets the value of the proxy for the SOCKS protocol.
        [JsonProperty("socksProxy", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string SocksProxy { get; set; }
        //
        // Summary:
        //     Gets or sets the value of the proxy for the SSL protocol.
        [JsonProperty("sslProxy", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string SslProxy { get; set; }
        //
        // Summary:
        //     Gets or sets the URL used for proxy automatic configuration.
        [JsonProperty("proxyAutoconfigUrl", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyAutoConfigUrl { get; set; }
        //
        // Summary:
        //     Gets the semicolon delimited list of address for which to bypass the proxy.
        [JsonProperty("noProxy", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string BypassProxyAddresses { get; }
        //
        // Summary:
        //     Gets or sets the value for bypass proxy addresses.
        [Obsolete("Add addresses to bypass with the proxy by using the AddBypassAddress method.")]
        public string NoProxy { get; set; }
        //
        // Summary:
        //     Gets or sets the value of the proxy for the HTTP protocol.
        [JsonProperty("httpProxy", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string HttpProxy { get; set; }
        //
        // Summary:
        //     Gets or sets the value of the proxy for the FTP protocol.
        [JsonProperty("ftpProxy", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string FtpProxy { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the proxy uses automatic detection.
        [JsonIgnore]
        public bool IsAutoDetect { get; set; }
        //
        // Summary:
        //     Gets the type of proxy as a string for JSON serialization.
        [JsonProperty("proxyType")]
        public string SerializableProxyKind { get; }
        //
        // Summary:
        //     Gets or sets the type of proxy.
        [JsonIgnore]
        public extern ProxyKind Kind { get; set; }
        //
        // Summary:
        //     Gets or sets the value of username for the SOCKS proxy.
        [JsonProperty("socksUsername", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string SocksUserName { get; set; }
        //
        // Summary:
        //     Gets or sets the value of password for the SOCKS proxy.
        [JsonProperty("socksPassword", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string SocksPassword { get; set; }


        //
        // Summary:
        //     Adds a single address to the list of addresses against which the proxy will not
        //     be used.
        //
        // Parameters:
        //   address:
        //     The address to add.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddBypassAddress(string address);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Adds addresses to the list of addresses against which the proxy will not be used.
        //
        // Parameters:
        //   addressesToAdd:
        //     An System.Collections.Generic.IEnumerable`1 object of arguments to add.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddBypassAddresses(IEnumerable<string> addressesToAdd);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Adds addresses to the list of addresses against which the proxy will not be used.
        //
        // Parameters:
        //   addressesToAdd:
        //     An array of addresses to add.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void AddBypassAddresses(params string[] addressesToAdd);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
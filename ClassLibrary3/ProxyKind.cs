namespace OpenQA.Selenium
{
    public enum ProxyKind
    {
        Direct = 0,
        //
        // Summary:
        //     Manual proxy settings (e.g., for httpProxy).
        Manual = 1,
        //
        // Summary:
        //     Proxy automatic configuration from URL.
        ProxyAutoConfigure = 2,
        //
        // Summary:
        //     Use proxy automatic detection.
        AutoDetect = 4,
        //
        // Summary:
        //     Use the system values for proxy settings (default on Linux).
        System = 5,
        //
        // Summary:
        //     No proxy type is specified.
        Unspecified = 6
    }
}
namespace System.Configuration
{
    public enum OverrideMode
    {
        Inherit = 0,
        //
        // Summary:
        //     The configuration setting of the element or group can be overridden by configuration
        //     settings that are in child directories.
        Allow = 1,
        //
        // Summary:
        //     The configuration setting of the element or group cannot be overridden by configuration
        //     settings that are in child directories.
        Deny = 2
    }
}
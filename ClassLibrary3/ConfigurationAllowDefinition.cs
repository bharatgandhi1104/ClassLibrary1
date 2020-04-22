namespace System.Configuration
{
    public enum ConfigurationAllowDefinition
    {
        MachineOnly = 0,
        //
        // Summary:
        //     The System.Configuration.ConfigurationSection can be defined in either the Machine.config
        //     file or the machine-level Web.config file found in the same directory as Machine.config,
        //     but not in application Web.config files.
        MachineToWebRoot = 100,
        //
        // Summary:
        //     The System.Configuration.ConfigurationSection can be defined in either the Machine.config
        //     file, the machine-level Web.config file found in the same directory as Machine.config,
        //     or the top-level application Web.config file found in the virtual-directory root,
        //     but not in subdirectories of a virtual root.
        MachineToApplication = 200,
        //
        // Summary:
        //     The System.Configuration.ConfigurationSection can be defined anywhere.
        Everywhere = 300
    }
}

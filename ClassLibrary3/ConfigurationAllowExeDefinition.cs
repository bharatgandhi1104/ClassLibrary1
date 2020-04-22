namespace System.Configuration
{
    public enum ConfigurationAllowExeDefinition
    {
        MachineOnly = 0,
        //
        // Summary:
        //     The System.Configuration.ConfigurationSection can be defined either in the Machine.config
        //     file or in the Exe.config file in the client application directory. This is the
        //     default value.
        MachineToApplication = 100,
        //
        // Summary:
        //     The System.Configuration.ConfigurationSection can be defined in the Machine.config
        //     file, in the Exe.config file in the client application directory, or in the User.config
        //     file in the roaming user directory.
        MachineToRoamingUser = 200,
        //
        // Summary:
        //     The System.Configuration.ConfigurationSection can be defined in the Machine.config
        //     file, in the Exe.config file in the client application directory, in the User.config
        //     file in the roaming user directory, or in the User.config file in the local user
        //     directory.
        MachineToLocalUser = 300
    }
}

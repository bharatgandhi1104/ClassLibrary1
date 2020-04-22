using System;
using System.Collections.Generic;
using System.Reflection;

namespace NLog.Internal.Fakeables
{
    public interface IAppDomain
    {
        string BaseDirectory { get; }
        //
        // Summary:
        //     Gets or sets the name of the configuration file for an application domain.
        string ConfigurationFile { get; }
        //
        // Summary:
        //     Gets or sets the list of directories under the application base directory that
        //     are probed for private assemblies.
        IEnumerable<string> PrivateBinPath { get; }
        //
        // Summary:
        //     Gets or set the friendly name.
        string FriendlyName { get; }
        //
        // Summary:
        //     Gets an integer that uniquely identifies the application domain within the process.
        int Id { get; }

        //
        // Summary:
        //     Process exit event.
        event EventHandler<EventArgs> ProcessExit;
        //
        // Summary:
        //     Domain unloaded event.
        event EventHandler<EventArgs> DomainUnload;

        //
        // Summary:
        //     Gets the assemblies that have been loaded into the execution context of this
        //     application domain.
        //
        // Returns:
        //     A list of assemblies in this application domain.
        IEnumerable<Assembly> GetAssemblies();
    }
}
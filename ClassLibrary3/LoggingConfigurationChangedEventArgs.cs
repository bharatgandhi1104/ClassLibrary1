using System;

namespace NLog.Config
{
    public class LoggingConfigurationChangedEventArgs : EventArgs
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingConfigurationChangedEventArgs(LoggingConfiguration activatedConfiguration, LoggingConfiguration deactivatedConfiguration);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the old configuration.
        public LoggingConfiguration DeactivatedConfiguration { get; }
        //
        // Summary:
        //     Gets the new configuration.
        public LoggingConfiguration ActivatedConfiguration { get; }
        //
        // Summary:
        //     Gets the new configuration
        [Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.5")]
        public LoggingConfiguration OldConfiguration { get; }
        //
        // Summary:
        //     Gets the old configuration
        [Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.5")]
        public LoggingConfiguration NewConfiguration { get; }
    }
}
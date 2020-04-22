using System;

namespace NLog.Config
{
    public class LoggingConfigurationReloadedEventArgs : EventArgs
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingConfigurationReloadedEventArgs(bool succeeded);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the NLog.Config.LoggingConfigurationReloadedEventArgs
        //     class.
        //
        // Parameters:
        //   succeeded:
        //     Whether configuration reload has succeeded.
        //
        //   exception:
        //     The exception during configuration reload.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LoggingConfigurationReloadedEventArgs(bool succeeded, Exception exception);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets a value indicating whether configuration reload has succeeded.
        public bool Succeeded { get; }
        //
        // Summary:
        //     Gets the exception which occurred during configuration reload.
        public Exception Exception { get; }
    }
}
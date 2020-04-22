using System;
using System.Collections.Generic;
using System.Globalization;
using NLog.Config;
using NLog.Internal.Fakeables;
using OpenQA.Selenium;

namespace NLog
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public class LogFactory : IDisposable
#pragma warning restore CS0436 // Type conflicts with imported type
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogFactory();
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.LogFactory class.
        //
        // Parameters:
        //   config:
        //     The config.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogFactory(LoggingConfiguration config);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the current NLog.Internal.Fakeables.IAppDomain.
        public static IAppDomain CurrentAppDomain { get; set; }
        //
        // Summary:
        //     Gets the default culture info to use as NLog.LogEventInfo.FormatProvider.
        [CanBeNullAttribute]
        public CultureInfo DefaultCultureInfo { get; }
        //
        // Summary:
        //     Gets or sets the global log level threshold. Log events below this threshold
        //     are not logged.
        public LogLevel GlobalThreshold { get; set; }
        //
        // Summary:
        //     Gets or sets the current logging configuration. After setting this property all
        //     existing loggers will be re-configured, so there is no need to call NLog.LogFactory.ReconfigExistingLoggers
        //     manually.
        public LoggingConfiguration Configuration { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether Variables should be kept on configuration
        //     reload. Default value - false.
        public bool KeepVariablesOnReload { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether NLog.NLogConfigurationException should
        //     be thrown. If null then NLog.LogFactory.ThrowExceptions is used.
        //
        // Remarks:
        //     This option is for backwards-compatiblity. By default exceptions are not thrown
        //     under any circumstances.
        public bool? ThrowConfigExceptions { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether exceptions should be thrown. See also
        //     NLog.LogFactory.ThrowConfigExceptions.
        //
        // Remarks:
        //     By default exceptions are not thrown under any circumstances.
        public bool ThrowExceptions { get; set; }

        //
        // Summary:
        //     Occurs when logging NLog.LogFactory.Configuration changes.
        public event EventHandler<LoggingConfigurationChangedEventArgs> ConfigurationChanged;
        //
        // Summary:
        //     Occurs when logging NLog.LogFactory.Configuration gets reloaded.
        // public event EventHandler<LoggingConfigurationReloadedEventArgs> ConfigurationReloaded;


        //
        // Summary:
        //     Creates a logger that discards all log messages.
        //
        // Returns:
        //     Null logger instance.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Logger CreateNullLogger();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Decreases the log enable counter and if it reaches -1 the logs are disabled.
        //
        // Returns:
        //     An object that implements IDisposable whose Dispose() method re-enables logging.
        //     To be used with C# using () statement.
        //
        // Remarks:
        //     Logging is enabled if the number of NLog.LogFactory.ResumeLogging calls is greater
        //     than or equal to NLog.LogFactory.SuspendLogging calls. This method was marked
        //     as obsolete on NLog 4.0 and it may be removed in a future release.
        [Obsolete("Use SuspendLogging() instead. Marked obsolete on NLog 4.0")]
#pragma warning disable CS0436 // Type conflicts with imported type
        public extern IDisposable DisableLogging();
#pragma warning restore CS0436 // Type conflicts with imported type
        //
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or resetting
        //     unmanaged resources.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Dispose();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Increases the log enable counter and if it reaches 0 the logs are disabled.
        //
        // Remarks:
        //     Logging is enabled if the number of NLog.LogFactory.ResumeLogging calls is greater
        //     than or equal to NLog.LogFactory.SuspendLogging calls. This method was marked
        //     as obsolete on NLog 4.0 and it may be removed in a future release.
        [Obsolete("Use ResumeLogging() instead. Marked obsolete on NLog 4.0")]
        public extern void EnableLogging();

        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets).
        //
        // Parameters:
        //   asyncContinuation:
        //     The asynchronous continuation.
        //
        //   timeout:
        //     Maximum time to allow for the flush. Any messages after that time will be discarded.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush(AsyncContinuation asyncContinuation, TimeSpan timeout);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets) with the default
        //     timeout of 15 seconds.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets).
        //
        // Parameters:
        //   asyncContinuation:
        //     The asynchronous continuation.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush(AsyncContinuation asyncContinuation);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets).
        //
        // Parameters:
        //   timeout:
        //     Maximum time to allow for the flush. Any messages after that time will be discarded.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush(TimeSpan timeout);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets).
        //
        // Parameters:
        //   timeoutMilliseconds:
        //     Maximum time to allow for the flush. Any messages after that time will be discarded.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush(int timeoutMilliseconds);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Flush any pending log messages (in case of asynchronous targets).
        //
        // Parameters:
        //   asyncContinuation:
        //     The asynchronous continuation.
        //
        //   timeoutMilliseconds:
        //     Maximum time to allow for the flush. Any messages after that time will be discarded.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Flush(AsyncContinuation asyncContinuation, int timeoutMilliseconds);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Get file paths (including filename) for the possible NLog config files.
        //
        // Returns:
        //     The filepaths to the possible config file
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern IEnumerable<string> GetCandidateConfigFilePaths();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the logger with the name of the current class.
        //
        // Returns:
        //     The logger.
        //
        // Remarks:
        //     This is a slow-running method. Make sure you're not doing this in a loop.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Logger GetCurrentClassLogger();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the logger with the name of the current class.
        //
        // Type parameters:
        //   T:
        //     Type of the logger
        //
        // Returns:
        //     The logger with type T.
        //
        // Remarks:
        //     This is a slow-running method. Make sure you're not doing this in a loop.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern T GetCurrentClassLogger<T>() where T : Logger;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets a custom logger with the name of the current class. Use loggerType to pass
        //     the type of the needed Logger.
        //
        // Parameters:
        //   loggerType:
        //     The type of the logger to create. The type must inherit from NLog.Logger
        //
        // Returns:
        //     The logger of type loggerType.
        //
        // Remarks:
        //     This is a slow-running method. Make sure you are not calling this method in a
        //     loop.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Logger GetCurrentClassLogger(Type loggerType);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the specified named logger. Use loggerType to pass the type of the needed
        //     Logger.
        //
        // Parameters:
        //   name:
        //     Name of the logger.
        //
        //   loggerType:
        //     The type of the logger to create. The type must inherit from NLog.Logger.
        //
        // Returns:
        //     The logger of type loggerType. Multiple calls to GetLogger with the same argument
        //     aren't guaranteed to return the same logger reference.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Logger GetLogger(string name, Type loggerType);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the specified named logger.
        //
        // Parameters:
        //   name:
        //     Name of the logger.
        //
        // Type parameters:
        //   T:
        //     Type of the logger
        //
        // Returns:
        //     The logger reference with type T. Multiple calls to GetLogger with the same argument
        //     are not guaranteed to return the same logger reference.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern T GetLogger<T>(string name) where T : Logger;
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Gets the specified named logger.
        //
        // Parameters:
        //   name:
        //     Name of the logger.
        //
        // Returns:
        //     The logger reference. Multiple calls to GetLogger with the same argument are
        //     not guaranteed to return the same logger reference.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Logger GetLogger(string name);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns true if logging is currently enabled.
        //
        // Returns:
        //     A value of true if logging is currently enabled, false otherwise.
        //
        // Remarks:
        //     Logging is enabled if the number of NLog.LogFactory.ResumeLogging calls is greater
        //     than or equal to NLog.LogFactory.SuspendLogging calls.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool IsLoggingEnabled();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Loads logging configuration from file (Currently only XML configuration files
        //     supported)
        //
        // Parameters:
        //   configFile:
        //     Configuration file to be read
        //
        // Returns:
        //     LogFactory instance for fluent interface
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern LogFactory LoadConfiguration(string configFile);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Loops through all loggers previously returned by GetLogger and recalculates their
        //     target and filter list. Useful after modifying the configuration programmatically
        //     to ensure that all loggers have been properly configured.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ReconfigExistingLoggers();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Clear the candidate file paths and return to the defaults.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ResetCandidateConfigFilePath();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Increases the log enable counter and if it reaches 0 the logs are disabled.
        //
        // Remarks:
        //     Logging is enabled if the number of NLog.LogFactory.ResumeLogging calls is greater
        //     than or equal to NLog.LogFactory.SuspendLogging calls.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void ResumeLogging();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Overwrite the paths (including filename) for the possible NLog config files.
        //
        // Parameters:
        //   filePaths:
        //     The filepaths to the possible config file
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SetCandidateConfigFilePaths(IEnumerable<string> filePaths);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Decreases the log enable counter and if it reaches -1 the logs are disabled.
        //
        // Returns:
        //     An object that implements IDisposable whose Dispose() method re-enables logging.
        //     To be used with C# using () statement.
        //
        // Remarks:
        //     Logging is enabled if the number of NLog.LogFactory.ResumeLogging calls is greater
        //     than or equal to NLog.LogFactory.SuspendLogging calls.
#pragma warning disable CS0436 // Type conflicts with imported type
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern IDisposable SuspendLogging();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning restore CS0436 // Type conflicts with imported type
        //
        // Summary:
        //     Releases unmanaged and - optionally - managed resources.
        //
        // Parameters:
        //   disposing:
        //     True to release both managed and unmanaged resources; false to release only unmanaged
        //     resources.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void Dispose(bool disposing);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Raises the event when the configuration is reloaded.
        //
        // Parameters:
        //   e:
        //     Event arguments.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void OnConfigurationChanged(LoggingConfigurationChangedEventArgs e);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Raises the event when the configuration is reloaded.
        //
        // Parameters:
        //   e:
        //     Event arguments
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        protected extern virtual void OnConfigurationReloaded(LoggingConfigurationReloadedEventArgs e);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
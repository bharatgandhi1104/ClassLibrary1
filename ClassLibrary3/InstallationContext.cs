using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace NLog.Config
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public sealed class InstallationContext : IDisposable
#pragma warning restore CS0436 // Type conflicts with imported type
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern InstallationContext();
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.Config.InstallationContext class.
        //
        // Parameters:
        //   logOutput:
        //     The log output.
#pragma warning disable CS0824 // Constructor is marked external
        public extern InstallationContext(TextWriter logOutput);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets or sets the installation log level.
        public LogLevel LogLevel { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether to ignore failures during installation.
        public bool IgnoreFailures { get; set; }
        //
        // Summary:
        //     Whether installation exceptions should be rethrown. If IgnoreFailures is set
        //     to true, this property has no effect (there are no exceptions to rethrow).
        public bool ThrowExceptions { get; set; }
        //
        // Summary:
        //     Gets the installation parameters.
        public IDictionary<string, string> Parameters { get; }
        //
        // Summary:
        //     Gets or sets the log output.
        public TextWriter LogOutput { get; set; }


        //
        // Summary:
        //     Creates the log event which can be used to render layouts during installation/uninstallations.
        //
        // Returns:
        //     Log event info object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern LogEventInfo CreateLogEvent();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Logs the specified debug message.
        //
        // Parameters:
        //   message:
        //     The message.
        //
        //   arguments:
        //     The arguments.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Debug([Localizable(false)] string message, params object[] arguments);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or resetting
        //     unmanaged resources.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Dispose();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Logs the specified error message.
        //
        // Parameters:
        //   message:
        //     The message.
        //
        //   arguments:
        //     The arguments.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Error([Localizable(false)] string message, params object[] arguments);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Logs the specified informational message.
        //
        // Parameters:
        //   message:
        //     The message.
        //
        //   arguments:
        //     The arguments.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Info([Localizable(false)] string message, params object[] arguments);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Logs the specified trace message.
        //
        // Parameters:
        //   message:
        //     The message.
        //
        //   arguments:
        //     The arguments.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Trace([Localizable(false)] string message, params object[] arguments);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Logs the specified warning message.
        //
        // Parameters:
        //   message:
        //     The message.
        //
        //   arguments:
        //     The arguments.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Warning([Localizable(false)] string message, params object[] arguments);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
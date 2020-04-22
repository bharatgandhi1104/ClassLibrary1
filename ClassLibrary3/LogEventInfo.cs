using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace NLog
{
    public class LogEventInfo
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogEventInfo();
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.LogEventInfo class.
        //
        // Parameters:
        //   level:
        //     Log level.
        //
        //   loggerName:
        //     Logger name.
        //
        //   message:
        //     Log message including parameter placeholders.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogEventInfo(LogLevel level, string loggerName, [Localizable(false)] string message);
#pragma warning restore CS0824 // Constructor is marked external
        //
        // Summary:
        //     Initializes a new instance of the NLog.LogEventInfo class.
        //
        // Parameters:
        //   level:
        //     Log level.
        //
        //   loggerName:
        //     Logger name.
        //
        //   message:
        //     Log message including parameter placeholders.
        //
        //   messageTemplateParameters:
        //     Log message including parameter placeholders.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogEventInfo(LogLevel level, string loggerName, [Localizable(false)] string message, IList<MessageTemplateParameter> messageTemplateParameters);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the NLog.LogEventInfo class.
        //
        // Parameters:
        //   level:
        //     Log level.
        //
        //   loggerName:
        //     Logger name.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     Log message including parameter placeholders.
        //
        //   parameters:
        //     Parameter array.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, [Localizable(false)] string message, object[] parameters);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Initializes a new instance of the NLog.LogEventInfo class.
        //
        // Parameters:
        //   level:
        //     Log level.
        //
        //   loggerName:
        //     Logger name.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     Log message including parameter placeholders.
        //
        //   parameters:
        //     Parameter array.
        //
        //   exception:
        //     Exception information.
#pragma warning disable CS0824 // Constructor is marked external
        public extern LogEventInfo(LogLevel level, string loggerName, IFormatProvider formatProvider, [Localizable(false)] string message, object[] parameters, Exception exception);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the callsite class name
        public string CallerClassName { get; }
        //
        // Summary:
        //     Gets the callsite member function name
        public string CallerMemberName { get; }
        //
        // Summary:
        //     Gets the callsite source file path
        public string CallerFilePath { get; }
        //
        // Summary:
        //     Gets the callsite source file line number
        public int CallerLineNumber { get; }
        //
        // Summary:
        //     Gets or sets the exception information.
        public Exception Exception { get; set; }
        //
        // Summary:
        //     Gets or sets the logger name.
        public string LoggerName { get; set; }
        //
        // Summary:
        //     Gets the logger short name.
        //
        // Remarks:
        //     This property was marked as obsolete on NLog 2.0 and it may be removed in a future
        //     release.
        [Obsolete("This property should not be used. Marked obsolete on NLog 2.0")]
        public string LoggerShortName { get; }
        //
        // Summary:
        //     Gets or sets the format provider that was provided while logging or null when
        //     no formatProvider was specified.
        public IFormatProvider FormatProvider { get; set; }
        //
        // Summary:
        //     Gets or sets the parameter values or null if no parameters have been specified.
        public object[] Parameters { get; set; }
        //
        // Summary:
        //     Gets the entire stack trace.
        public StackTrace StackTrace { get; }
        //
        // Summary:
        //     Gets or sets the message formatter for generating NLog.LogEventInfo.FormattedMessage
        //     Uses string.Format(...) when nothing else has been configured.
        public LogMessageFormatter MessageFormatter { get; set; }
        //
        // Summary:
        //     Gets the formatted message.
        public string FormattedMessage { get; }
        //
        // Summary:
        //     Checks if any per-event properties (Without allocation)
        public bool HasProperties { get; }
        //
        // Summary:
        //     Gets the dictionary of per-event context properties.
        public IDictionary<object, object> Properties { get; }
        //
        // Summary:
        //     Gets or sets the log message including any parameter placeholders.
        public string Message { get; set; }
        //
        // Summary:
        //     Gets the number index of the stack frame that represents the user code (not the
        //     NLog code).
        public int UserStackFrameNumber { get; }
        //
        // Summary:
        //     Gets or sets the level of the logging event.
        public LogLevel Level { get; set; }
        //
        // Summary:
        //     Gets a value indicating whether stack trace has been set for this event.
        public bool HasStackTrace { get; }
        //
        // Summary:
        //     Gets the stack frame of the method that did the logging.
        public StackFrame UserStackFrame { get; }
        //
        // Summary:
        //     Gets the unique identifier of log event which is automatically generated and
        //     monotonously increasing.
        public int SequenceID { get; }
        //
        // Summary:
        //     Gets the dictionary of per-event context properties.
        //
        // Remarks:
        //     This property was marked as obsolete on NLog 2.0 and it may be removed in a future
        //     release.
        [Obsolete("Use LogEventInfo.Properties instead.  Marked obsolete on NLog 2.0", true)]
        public IDictionary Context { get; }
        //
        // Summary:
        //     Gets the named parameters extracted from parsing NLog.LogEventInfo.Message as
        //     MessageTemplate
        public MessageTemplateParameters MessageTemplateParameters { get; }
        //
        // Summary:
        //     Gets or sets the timestamp of the logging event.
        public DateTime TimeStamp { get; set; }


        //
        // Summary:
        //     Creates the log event.
        //
        // Parameters:
        //   logLevel:
        //     The log level.
        //
        //   loggerName:
        //     Name of the logger.
        //
        //   exception:
        //     The exception.
        //
        //   formatProvider:
        //     The format provider.
        //
        //   message:
        //     The message.
        //
        // Returns:
        //     Instance of NLog.LogEventInfo.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern LogEventInfo Create(LogLevel logLevel, string loggerName, Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Creates the log event.
        //
        // Parameters:
        //   logLevel:
        //     The log level.
        //
        //   loggerName:
        //     Name of the logger.
        //
        //   message:
        //     The message.
        //
        //   exception:
        //     The exception.
        //
        // Returns:
        //     Instance of NLog.LogEventInfo.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("use Create(LogLevel logLevel, string loggerName, Exception exception, IFormatProvider formatProvider, string message) instead. Marked obsolete before v4.3.11")]
        public static extern LogEventInfo Create(LogLevel logLevel, string loggerName, [Localizable(false)] string message, Exception exception);

        //
        // Summary:
        //     Creates the log event.
        //
        // Parameters:
        //   logLevel:
        //     The log level.
        //
        //   loggerName:
        //     Name of the logger.
        //
        //   formatProvider:
        //     The format provider.
        //
        //   message:
        //     The message.
        //
        // Returns:
        //     Instance of NLog.LogEventInfo.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern LogEventInfo Create(LogLevel logLevel, string loggerName, IFormatProvider formatProvider, object message);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Creates the log event.
        //
        // Parameters:
        //   logLevel:
        //     The log level.
        //
        //   loggerName:
        //     Name of the logger.
        //
        //   formatProvider:
        //     The format provider.
        //
        //   message:
        //     The message.
        //
        //   parameters:
        //     The parameters.
        //
        // Returns:
        //     Instance of NLog.LogEventInfo.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern LogEventInfo Create(LogLevel logLevel, string loggerName, IFormatProvider formatProvider, [Localizable(false)] string message, object[] parameters);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Creates the log event.
        //
        // Parameters:
        //   logLevel:
        //     The log level.
        //
        //   loggerName:
        //     Name of the logger.
        //
        //   message:
        //     The message.
        //
        // Returns:
        //     Instance of NLog.LogEventInfo.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern LogEventInfo Create(LogLevel logLevel, string loggerName, [Localizable(false)] string message);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Creates the log event.
        //
        // Parameters:
        //   logLevel:
        //     The log level.
        //
        //   loggerName:
        //     Name of the logger.
        //
        //   exception:
        //     The exception.
        //
        //   formatProvider:
        //     The format provider.
        //
        //   message:
        //     The message.
        //
        //   parameters:
        //     The parameters.
        //
        // Returns:
        //     Instance of NLog.LogEventInfo.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern LogEventInfo Create(LogLevel logLevel, string loggerName, Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, object[] parameters);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Creates the null event.
        //
        // Returns:
        //     Null log event.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public static extern LogEventInfo CreateNullEvent();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Sets the details retrieved from the Caller Information Attributes
        //
        // Parameters:
        //   callerClassName:
        //
        //   callerMemberName:
        //
        //   callerFilePath:
        //
        //   callerLineNumber:
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SetCallerInfo(string callerClassName, string callerMemberName, string callerFilePath, int callerLineNumber);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Sets the stack trace for the event info.
        //
        // Parameters:
        //   stackTrace:
        //     The stack trace.
        //
        //   userStackFrame:
        //     Index of the first user stack frame within the stack trace.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SetStackTrace(StackTrace stackTrace, int userStackFrame);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Returns a string representation of this log event.
        //
        // Returns:
        //     String representation of the log event.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Creates NLog.Common.AsyncLogEventInfo from this NLog.LogEventInfo by attaching
        //     the specified asynchronous continuation.
        //
        // Parameters:
        //   asyncContinuation:
        //     The asynchronous continuation.
        //
        // Returns:
        //     Instance of NLog.Common.AsyncLogEventInfo with attached continuation.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern AsyncLogEventInfo WithContinuation(AsyncContinuation asyncContinuation);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }

    public class MessageTemplateParameters
    {
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern MessageTemplateParameter this[int index] { get; }
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Number of parameters
        public int Count { get; }
        //
        // Summary:
        //     Indicates whether the template should be interpreted as positional (all holes
        //     are numbers) or named.
        public bool IsPositional { get; }

        //
        public IEnumerator<MessageTemplateParameter> Enumerator { get; }
    }
}
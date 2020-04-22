using OpenQA.Selenium;
using System;
using System.ComponentModel;

namespace NLog
{
    public interface ILoggerBase
    {
        LogFactory Factory { get; }
        //
        // Summary:
        //     Gets the name of the logger.
        string Name { get; }

        //
        // Summary:
        //     Occurs when logger configuration changes.
        event EventHandler<EventArgs> LoggerReconfigured;

        //
        // Summary:
        //     Gets a value indicating whether logging is enabled for the specified level.
        //
        // Parameters:
        //   level:
        //     Log level to be checked.
        //
        // Returns:
        //     A value of true if logging is enabled for the specified level, otherwise it returns
        //     false.
        bool IsEnabled(LogLevel level);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, ulong argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, ulong argument);
        //
        // Summary:
        //     Writes the specified diagnostic message.
        //
        // Parameters:
        //   logEvent:
        //     Log event.
        void Log(LogEventInfo logEvent);
        //
        // Summary:
        //     Writes the specified diagnostic message.
        //
        // Parameters:
        //   wrapperType:
        //     The name of the type that wraps Logger.
        //
        //   logEvent:
        //     Log event.
        void Log(Type wrapperType, LogEventInfo logEvent);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Log<T>(LogLevel level, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     The value to be written.
        //
        // Type parameters:
        //   T:
        //     Type of the value.
        void Log<T>(LogLevel level, IFormatProvider formatProvider, T value);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   messageFunc:
        //     A function returning message to be written. Function is not evaluated if logging
        //     is not enabled.
        void Log(LogLevel level, LogMessageGenerator messageFunc);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string to be written.
        //
        //   args:
        //     Arguments to format.
        //
        //   exception:
        //     An exception to be logged.
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, uint argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameters
        //     and formatting them with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     Log message.
        void Log(LogLevel level, [Localizable(false)] string message);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameters.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing format items.
        //
        //   args:
        //     Arguments to format.
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args) instead. Marked obsolete before v4.3.11")]
        void Log(LogLevel level, [Localizable(false)] string message, Exception exception);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameter
        //     and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Log<TArgument>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        //
        // Type parameters:
        //   TArgument:
        //     The type of the argument.
        [MessageTemplateFormatMethod("message")]
        void Log<TArgument>(LogLevel level, [Localizable(false)] string message, TArgument argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified arguments
        //     formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Log<TArgument1, TArgument2>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameters.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        [MessageTemplateFormatMethod("message")]
        void Log<TArgument1, TArgument2>(LogLevel level, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameters.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument1:
        //     The first argument to format.
        //
        //   argument2:
        //     The second argument to format.
        //
        //   argument3:
        //     The third argument to format.
        //
        // Type parameters:
        //   TArgument1:
        //     The type of the first argument.
        //
        //   TArgument2:
        //     The type of the second argument.
        //
        //   TArgument3:
        //     The type of the third argument.
        [MessageTemplateFormatMethod("message")]
        void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string to be written.
        //
        //   args:
        //     Arguments to format.
        //
        //   exception:
        //     An exception to be logged.
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Log(LogLevel level, IFormatProvider formatProvider, object value);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameters.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, object arg1, object arg2);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified parameters.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing format items.
        //
        //   arg1:
        //     First argument to format.
        //
        //   arg2:
        //     Second argument to format.
        //
        //   arg3:
        //     Third argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, object arg1, object arg2, object arg3);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, bool argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, char argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, byte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, string argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, int argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, long argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, float argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, double argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, string message, decimal argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, object argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level using the specified value
        //     as a parameter and formatting it with the supplied format provider.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   formatProvider:
        //     An IFormatProvider that supplies culture-specific formatting information.
        //
        //   message:
        //     A string containing one format item.
        //
        //   argument:
        //     The argument to format.
        [EditorBrowsable(EditorBrowsableState.Never)]
        [MessageTemplateFormatMethod("message")]
        void Log(LogLevel level, IFormatProvider formatProvider, string message, sbyte argument);
        //
        // Summary:
        //     Writes the diagnostic message at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   value:
        //     A object to be written.
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Log(LogLevel level, object value);
        //
        // Summary:
        //     Writes the diagnostic message and exception at the specified level.
        //
        // Parameters:
        //   level:
        //     The log level.
        //
        //   message:
        //     A string to be written.
        //
        //   exception:
        //     An exception to be logged.
        //
        // Remarks:
        //     This method was marked as obsolete before NLog 4.3.11 and it may be removed in
        //     a future release.
        [Obsolete("Use Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args) instead. Marked obsolete before v4.3.11")]
        void LogException(LogLevel level, [Localizable(false)] string message, Exception exception);
    }
}
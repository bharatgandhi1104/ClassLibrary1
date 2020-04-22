using System.Collections.ObjectModel;

namespace OpenQA.Selenium
{
    public interface ILogs
    {
        ReadOnlyCollection<string> AvailableLogTypes { get; }

        //
        // Summary:
        //     Gets the set of OpenQA.Selenium.LogEntry objects for a specified log.
        //
        // Parameters:
        //   logKind:
        //     The log for which to retrieve the log entries. Log types can be found in the
        //     OpenQA.Selenium.LogType class.
        //
        // Returns:
        //     The list of OpenQA.Selenium.LogEntry objects for the specified log.
        ReadOnlyCollection<LogEntry> GetLog(string logKind);
    }
}
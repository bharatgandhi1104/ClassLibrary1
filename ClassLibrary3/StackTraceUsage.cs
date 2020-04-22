namespace NLog.Config
{
    public enum StackTraceUsage
    {
        None = 0,
        //
        // Summary:
        //     Stack trace should be captured without source-level information.
        WithoutSource = 1,
        //
        // Summary:
        //     Stack trace should be captured including source-level information such as line
        //     numbers.
        WithSource = 2,
        //
        // Summary:
        //     Capture maximum amount of the stack trace information supported on the platform.
        Max = 2
    }
}
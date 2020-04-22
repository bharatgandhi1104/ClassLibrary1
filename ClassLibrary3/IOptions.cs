namespace OpenQA.Selenium
{
    public interface IOptions
    {
        ICookieJar Cookies { get; }
        IWindow Window { get; }
        ILogs Logs { get; }
        ITimeouts Timeouts();
    }
}
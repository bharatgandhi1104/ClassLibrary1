namespace OpenQA.Selenium
{
    public enum PageLoadStrategy
    {
        Default = 0,
        //
        // Summary:
        //     Waits for pages to load and ready state to be 'complete'.
        Normal = 1,
        //
        // Summary:
        //     Waits for pages to load and for ready state to be 'interactive' or 'complete'.
        Eager = 2,
        //
        // Summary:
        //     Does not wait for pages to load, returning immediately.
        None = 3
    }
}
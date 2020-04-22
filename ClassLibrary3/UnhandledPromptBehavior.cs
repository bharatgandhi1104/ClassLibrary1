namespace OpenQA.Selenium
{
    public enum UnhandledPromptBehavior
    {
        Default = 0,
        //
        // Summary:
        //     Ignore unexpected alerts, such that the user must handle them.
        Ignore = 1,
        //
        // Summary:
        //     Accept unexpected alerts.
        Accept = 2,
        //
        // Summary:
        //     Dismiss unexpected alerts.
        Dismiss = 3,
        //
        // Summary:
        //     Accepts unexpected alerts and notifies the user that the alert has been accepted
        //     by throwing an OpenQA.Selenium.UnhandledAlertException
        AcceptAndNotify = 4,
        //
        // Summary:
        //     Dismisses unexpected alerts and notifies the user that the alert has been dismissed
        //     by throwing an OpenQA.Selenium.UnhandledAlertException
        DismissAndNotify = 5
    }
}
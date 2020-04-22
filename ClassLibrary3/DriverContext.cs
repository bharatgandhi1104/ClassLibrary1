using Objectivity.Test.Automation.Common.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace Objectivity.Test.Automation.Common
{
    public class DriverContext
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern DriverContext();
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets or sets the test title.
        public string TestTitle { get; set; }
        //
        //     Gets all verify messages
        // Summary:
        public Collection<ErrorDetail> VerifyMessages { get; }
        //
        // Summary:
        //     Gets driver Handle
        public IWebDriver Driver { get; }
        //
        // Summary:
        //     Gets or sets test logger
        public TestLogger LogTest { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether [test failed].
        public bool IsTestFailed { get; set; }
        //
        // Summary:
        //     Gets Sets Folder name for PageSource
        public string PageSourceFolder { get; }
        //
        // Summary:
        //     Gets Sets Folder name for Download
        public string DownloadFolder { get; }
        //
        // Summary:
        //     Gets Sets Folder name for ScreenShot
        public string ScreenShotFolder { get; }
        //
        // Summary:
        //     Gets or sets the Environment Browsers from App.config
        public string CrossBrowserEnvironment { get; set; }
        //
        // Summary:
        //     Gets instance of Performance PerformanceMeasures class
        public PerformanceHelper PerformanceMeasures { get; }
        //
        // Summary:
        //     Gets or sets directory where assembly files are located
        public string CurrentDirectory { get; set; }
        //
        // Summary:
        //     Gets or sets the CrossBrowserProfile from App.config
        public string CrossBrowserProfile { get; set; }

        //
        // Summary:
        //     Occurs when [driver options set].
        public event EventHandler<DriverOptionsSetEventArgs> DriverOptionsSet;
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void DeleteAllCookies();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool LogJavaScriptErrors();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string SavePageSource(string fileName);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string SaveScreenshot(ErrorDetail errorDetail, string folder, string title);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Start();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Stop();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern string[] TakeAndSaveScreenshot();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it                              
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern Screenshot TakeScreenshot();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void WindowMaximize();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
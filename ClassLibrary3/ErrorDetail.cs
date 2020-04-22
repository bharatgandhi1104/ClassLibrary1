using OpenQA.Selenium;
using System;

namespace Objectivity.Test.Automation.Common
{
    public class ErrorDetail
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern ErrorDetail(Screenshot screenshot, DateTime dateTime, Exception exception);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets or sets the screenshot.
        public Screenshot Screenshot { get; set; }
        //
        // Summary:
        //     Gets or sets the date time.
        public DateTime DateTime { get; set; }
        //
        // Summary:
        //     Gets or sets the exception.
        public Exception Exception { get; set; }
    }
}
using System;
using OpenQA.Selenium;

namespace Objectivity.Test.Automation.Common
{
    public class DriverOptionsSetEventArgs : EventArgs
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern DriverOptionsSetEventArgs(DriverOptions options);
#pragma warning restore CS0824 // Constructor is marked external
        public DriverOptions DriverOptions { get; }
    }
}
using System;

namespace Objectivity.Test.Automation.Common
{
    public class TestLogger
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern TestLogger();
#pragma warning restore CS0824 // Constructor is marked external
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Error(string message, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Info(string message, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void LogError(Exception e);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void LogTestEnding(DriverContext driverContext);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void LogTestStarting(DriverContext driverContext);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void Warn(string message, params object[] args);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
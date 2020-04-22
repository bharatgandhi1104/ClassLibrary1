namespace OpenQA.Selenium
{
    public class Platform
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern Platform(PlatformType typeValue);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the current platform.
        public static Platform CurrentPlatform { get; }
        //
        // Summary:
        //     Gets the major version of the platform operating system.
        public int MajorVersion { get; }
        //
        // Summary:
        //     Gets the major version of the platform operating system.
        public int MinorVersion { get; }
        //
        // Summary:
        //     Gets the type of the platform.
        public PlatformType PlatformType { get; }
        //
        // Summary:
        //     Gets the value of the platform type for transmission using the JSON Wire Protocol.
        public string ProtocolPlatformType { get; }


        //
        // Summary:
        //     Compares the platform to the specified type.
        //
        // Parameters:
        //   compareTo:
        //     A OpenQA.Selenium.Platform.PlatformType value to compare to.
        //
        // Returns:
        //     true if the platforms match; otherwise false.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern bool IsPlatformType(PlatformType compareTo);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

        //
        // Summary:
        //     Returns the string value for this platform type.
        //
        // Returns:
        //     The string value for this platform type.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
namespace OpenQA.Selenium
{
    public enum PlatformType
    {
        Any = 0,
        //
        // Summary:
        //     Any version of Microsoft Windows. This value is never returned by a driver, but
        //     can be used to find drivers with certain capabilities.
        Windows = 1,
        //
        // Summary:
        //     Any Windows NT-based version of Microsoft Windows. This value is never returned
        //     by a driver, but can be used to find drivers with certain capabilities. This
        //     value is equivalent to PlatformType.Windows.
        WinNT = 1,
        //
        // Summary:
        //     Versions of Microsoft Windows that are compatible with Windows XP.
        XP = 2,
        //
        // Summary:
        //     Versions of Microsoft Windows that are compatible with Windows Vista.
        Vista = 3,
        //
        // Summary:
        //     Any version of the Macintosh OS
        Mac = 4,
        //
        // Summary:
        //     Any version of the Unix operating system.
        Unix = 5,
        //
        // Summary:
        //     Any version of the Linux operating system.
        Linux = 6,
        //
        // Summary:
        //     A version of the Android mobile operating system.
        Android = 7
    }
}
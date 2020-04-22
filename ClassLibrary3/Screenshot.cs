namespace OpenQA.Selenium
{
    public class Screenshot
    {
#pragma warning disable CS0824 // Constructor is marked external
        public extern Screenshot(string base64EncodedScreenshot);
#pragma warning restore CS0824 // Constructor is marked external

        //
        // Summary:
        //     Gets the value of the screenshot image as a Base64-encoded string.
        public string AsBase64EncodedString { get; }
        //
        // Summary:
        //     Gets the value of the screenshot image as an array of bytes.
        public byte[] AsByteArray { get; }


        //
        // Summary:
        //     Saves the screenshot to a Portable Network Graphics (PNG) file, overwriting the
        //     file if it already exists.
        //
        // Parameters:
        //   fileName:
        //     The full path and file name to save the screenshot to.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SaveAsFile(string fileName);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Saves the screenshot to a file, overwriting the file if it already exists.
        //
        // Parameters:
        //   fileName:
        //     The full path and file name to save the screenshot to.
        //
        //   format:
        //     A OpenQA.Selenium.ScreenshotImageFormat value indicating the format to save the
        //     image to.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern void SaveAsFile(string fileName, ScreenshotImageFormat format);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        //
        // Summary:
        //     Returns a System.String that represents the current System.Object.
        //
        // Returns:
        //     A System.String that represents the current System.Object.
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
        public extern override string ToString();
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
    }
}
using System.Drawing;

namespace OpenQA.Selenium
{
    public interface IWindow
    {
        Point Position { get; set; }
        Size Size { get; set; }

        //
        // Summary:
        //     Sets the current window to full screen if it is not already in that state.
        void FullScreen();
        //
        // Summary:
        //     Maximizes the current window if it is not already maximized.
        void Maximize();
        //
        // Summary:
        //     Minimizes the current window if it is not already maximized.
        void Minimize();
    }
}
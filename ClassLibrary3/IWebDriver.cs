using System;
using System.Collections.ObjectModel;

namespace OpenQA.Selenium
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public interface IWebDriver : ISearchContext, IDisposable
#pragma warning restore CS0436 // Type conflicts with imported type
    {
        string Url { get; set; }
        string Title { get; }
        string PageSource { get; }
        string CurrentWindowHandle { get; }
        ReadOnlyCollection<string> WindowHandles { get; }
        void Close();
        IOptions Manage();
        INavigation Navigate();
        void Quit();
        ITargetLocator SwitchTo();
    }
}
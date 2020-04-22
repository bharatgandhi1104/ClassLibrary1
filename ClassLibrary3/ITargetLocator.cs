namespace OpenQA.Selenium
{
    public interface ITargetLocator
    {
        IWebElement ActiveElement();
        IAlert Alert();
        IWebDriver DefaultContent();
        IWebDriver Frame(int frameIndex);
        IWebDriver Frame(string frameName);
        IWebDriver Frame(IWebElement frameElement);
        IWebDriver ParentFrame();
        IWebDriver Window(string windowName);
    }
}
namespace OpenQA.Selenium
{
    public interface IAlert
    {
        string Text { get; }
        void Dismiss();
        void SendKeys(string keysToSend);
        void SetAuthenticationCredentials(string userName, string password);
    }
}

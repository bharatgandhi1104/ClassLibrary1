using System.Collections.ObjectModel;
using System.Net;

namespace OpenQA.Selenium
{
    public interface ICookieJar
    {
        ReadOnlyCollection<Cookie> AllCookies { get; }
        void AddCookie(Cookie cookie);
        void DeleteAllCookies();
        void DeleteCookie(Cookie cookie);
        void DeleteCookieNamed(string name);
        Cookie GetCookieNamed(string name);
    }
}
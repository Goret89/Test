using OpenQA.Selenium;
using System.Collections.Generic;

namespace BingTestsBLL.Pages
{
    public class ScopeDotsPage : BasePage
    {

        public IDictionary<string, IWebElement> ScopeDotsPageElem =
            new Dictionary<string, IWebElement>()
            {
                { "ScopeDots", FindElementWithWait(By.CssSelector("li#dots_overflow_menu_container"))},
                { "Video", FindElementWithWait(By.CssSelector("li#video a"))},
                { "Map", FindElementWithWait(By.CssSelector("li#local a"))},
                { "News", FindElementWithWait(By.CssSelector("li#news a"))},
                { "MSN", FindElementWithWait(By.CssSelector("li#msn a"))},
                { "Office", FindElementWithWait(By.CssSelector("li#office"))}
            };

    }
}

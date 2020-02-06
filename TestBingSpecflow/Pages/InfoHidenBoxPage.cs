using OpenQA.Selenium;
using System.Collections.Generic;

namespace BingTestsBLL.Pages
{
    public class InfoHidenBoxPage : BasePage
    {

        public IDictionary<string, IWebElement> InfoBoxPageElem =
            new Dictionary<string, IWebElement>()
            {
                {"InfoBlock", FindElementWithWait(By.CssSelector("div.musCardCont")) }, //instead of browser.FindElement(By.CssSelector("div.musCardCont"))
                { "DownloadLink", FindElementWithWait(By.CssSelector("a#downloadLink"))},
                { "TitleImage", FindElementWithWait(By.CssSelector("a#iotd_title"))},
                { "BottomSpace", FindElementWithWait(By.CssSelector("div#copyright"))}
            };

        public IDictionary<string, IList<IWebElement>> InfoBoxPageElemList =
            new Dictionary<string, IList<IWebElement>>()
            {
                {"ShareElements", FindElementsWithWait(By.CssSelector("ul.share a"))}   //instead of browser.FindElements(By.CssSelector(
            };
    }

}

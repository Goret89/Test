using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingTestsBLL.Pages
{
    public class SearchPage : BasePage
    {

        public IDictionary<string, IList<IWebElement>> SearchPageElemList =
        new Dictionary<string, IList<IWebElement>>()
        {
                { "SearchResult", FindElementsWithWait(By.CssSelector("li.b_algo h2 a"))}
        };

        public IDictionary<string, IWebElement> SearchPageElem =
        new Dictionary<string, IWebElement>()
        {
                { "RelatedSearchSpace", FindElementWithWait(By.CssSelector("div.b_rrsr h2"))}
        };


    }
}

using OpenQA.Selenium;
using System.Collections.Generic;

namespace BingTestsBLL.Pages
{
    public class MainPage: BasePage
    {

        public IDictionary<string, IWebElement> MainPageElem =
         new Dictionary<string, IWebElement>()
         {
                 { "Logo", FindElementWithWait(By.CssSelector("svg.logo")) },
                 { "SearchBox", FindElementWithWait(By.CssSelector("input.sb_form_q"))},
                 { "SearchButton", FindElementWithWait(By.CssSelector("#sb_form > label"))},
                 { "InfoButton", FindElementWithWait(By.CssSelector("a#headline_link"))},
                  
                 
         };

    }
}

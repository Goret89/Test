using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BingTestsBLL.Pages
{
    public class MenuPage : BasePage
    {
        public IDictionary<string, IWebElement> MenuButtomElem =
            new Dictionary<string, IWebElement>()
            {
                { "MenuButton", FindElementWithWait(By.CssSelector("#id_sc"))},
            };
    }

    public class MenuPage2 : MenuPage
    {
        public IDictionary<string, IWebElement> MenuPageElem =
            new Dictionary<string, IWebElement>()
            {
                { "Settings", FindElementWithWait(By.CssSelector("div#hbsettings"))},
                { "SafeSearch", FindElementWithWait(By.CssSelector("a.hb_section.hbic_safesearch_row"))},
                { "SafeSearchValue", FindElementWithWait(By.CssSelector("a.hb_section.hbic_safesearch_row div div.hb_value_col"))},
                { "SearchHistory", FindElementWithWait(By.CssSelector("#HBContent > a:nth-child(3)"))},
                { "Privacy", FindElementWithWait(By.CssSelector("#HBContent > a:nth-child(4)"))},
                { "Feedback", FindElementWithWait(By.CssSelector("#hb_feedback")) },
                { "CustomiseHomepage", FindElementWithWait(By.CssSelector("div.hp_qs.hb_sect_container.expanded > a"))},
                { "ShowMenuBar", FindElementWithWait(By.CssSelector("div.hb_expandible>div:nth-child(1) div.hb_titlerow"))},
                { "MenuBarLocked", FindElementWithWait(By.CssSelector("div.img.toggle_img.toggle_on#qs_menu_ctrl"))},
                { "MenuBarUnlocked", FindElementWithWait(By.CssSelector("div.img.toggle_img#qs_menu_ctrl"))},
                { "ShowHomepageImage", FindElementWithWait(By.CssSelector("div.hb_expandible>div:nth-child(2) div.hb_titlerow"))},
                //{ "HomepageImageIsVisible", FindElementWithWait(By.CssSelector("div.img.toggle_img.toggle_on#qs_iotd_ctrl"))},
                { "HomepageImageIsNotVisible", FindElementWithWait(By.CssSelector("div.img.toggle_img#qs_iotd_ctrl"))},
            };

    }

    public class SubSettingsPage : MenuPage2
    {
        public IDictionary<string, IWebElement> SubMenuSettings =
           new Dictionary<string, IWebElement>()
           {
                { "SubSettingsLanguage", FindElementWithWait(By.CssSelector("a:nth-child(1) div.hb_detrow"))},
                { "SubSettingsCountry", FindElementWithWait(By.CssSelector("a:nth-child(2) > div.hb_detrow"))}
           };
    }
}

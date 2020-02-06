using BingTestsBLL.Extentions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace BingTestsBLL.Pages
{
    public class BasePage
    {
        protected static IWebDriver browser; //1)made static field
        protected readonly string url;
        protected static int waitTime;

        public BasePage()
        {
            browser = Driver.Browser;//new ChromeDriver(); // тут потом переделать //1)deleted this. link
            this.url = ConfigurationManager.AppSettings["Url"];
            waitTime = ConstantNames.TimeWaitContant;
        }
        
        public void Navigate()
        {
            browser.Navigate().GoToUrl(this.url);
        }
        
        public static IWebElement FindElementWithWait(By locator)
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(waitTime));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return browser.FindElement(locator);
        }

        public static IList<IWebElement> FindElementsWithWait(By locator)
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(waitTime));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return browser.FindElements(locator);
        } 
        
        //public static int TimeWait()
        //{
        //    return ConstantNames.TimeWaitContant;
        //}
    }
}

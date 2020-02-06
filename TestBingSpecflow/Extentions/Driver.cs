using BingTestsBLL.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace BingTestsBLL.Extentions
{
    public static class Driver
    {
        private static IWebDriver browser;
        private static WebDriverWait browserWait;

        public static IWebDriver Browser
        {
            get
            {
                if(browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if(browser == null || browserWait == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }

        }

        public static Config config = new Config();
        public static void StartBrowser()
        {
            switch (config.GetBrowser())
            {
                case BrowserType.Chrome:
                    Browser = new ChromeDriver();
                    break;
                case BrowserType.Opera:
                    Browser = new OpenQA.Selenium.Opera.OperaDriver();
                    break;
                case BrowserType.IE:
                    Browser = new InternetExplorerDriver();
                    break;
                default: break;
            }
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(2000));
            Browser.Manage().Window.Maximize();
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}

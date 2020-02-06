using System;
using System.Configuration;

namespace BingTestsBLL.Configuration
{
    public class Config : IConfig
    {
        public BrowserType GetBrowser()
        {
            var webDriver = ConfigurationManager.AppSettings.Get("BrowserType");

            return (BrowserType)Enum.Parse(typeof(BrowserType), webDriver);
        }
    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace BingTestsBLL.Extentions
{
    public static class RandomClass
    {
       static Random random = new Random();
        public static int Rand(IList<IWebElement> elem)
        {
            return random.Next(0, elem.Count - 1);
        }
      
    }
}

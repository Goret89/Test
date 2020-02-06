using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace BingTestsBLL.Extentions
{
    public static class Move
    {
        public static void HoverMouse(IWebElement element)
        {
            Actions action = new Actions(Driver.Browser);
            action.MoveToElement(element).Perform();
        }
        
    }
}

using BingTestsBLL.Extentions;
using TechTalk.SpecFlow;

namespace BingTestsTest
{
    [Binding]
    class Initializer
    {
        [BeforeTestRun]
        public static void Start()
        {
            Driver.StartBrowser();
        }
        [AfterTestRun]
        public static void Stop()
        {
            Driver.StopBrowser();
        }
    }
}

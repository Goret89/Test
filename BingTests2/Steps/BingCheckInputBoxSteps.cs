using BingTestsBLL.Extentions;
using BingTestsBLL.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BingTestsTest.Steps
{
    [Binding]
    public class BingInputBoxCheckFeatureSteps
    {
        MainPage mainPage;
        public BingInputBoxCheckFeatureSteps()
        {
            mainPage = new MainPage();
        }
        [When(@"Mouse hovered the input box")]
        public void WhenMouseHoveredTheInputBox()
        {
            Move.HoverMouse(mainPage.MainPageElem["SearchBox"]);
        }
        
        [Then(@"The inscription should flash as (.*)")]
        public void ThenTheInscriptionShouldFlashAs_(string title)
        {
            title = ConstantNames.SearchBoxTitle;
            Assert.AreEqual(title, mainPage.MainPageElem["SearchBox"].GetAttribute("title"));
        }
    }
}

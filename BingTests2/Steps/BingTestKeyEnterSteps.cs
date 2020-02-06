using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using BingTestsBLL.Pages;
using BingTestsBLL.Extentions;

namespace BingTestsTest.Steps
{
    [Binding]
    public class BingTestKeyEnterFeatureSteps 
    {
        MainPage mainPage;
        SearchPage searchPage;

        public BingTestKeyEnterFeatureSteps()
        {
            mainPage = new MainPage();   
        }

        [Given(@"I have entered (.*) sentence")]
        public void GivenIHaveEntered_Sentence(string sentence)
        {
            sentence = ConstantNames.SearchPhrase;
            mainPage.MainPageElem["SearchBox"].SendKeys(sentence);
        }
        
        [When(@"I pressed the key Enter")]
        public void WhenIPressedTheKeyEnter()
        {
            mainPage.MainPageElem["SearchBox"].SendKeys(Keys.Enter);
        }
        
        [Then(@"A new page should open")]
        public void ThenANewPageShouldOpen()
        {
            searchPage = new SearchPage();
            Assert.IsNotNull(searchPage.SearchPageElem["RelatedSearchSpace"].Displayed);
        }
    }
}

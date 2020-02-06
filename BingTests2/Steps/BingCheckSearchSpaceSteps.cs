using BingTestsBLL.Extentions;
using BingTestsBLL.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BingTestsTest.Steps
{
    [Binding]
    public class BingSearchSpaceFeature1Steps 
    {
        BasePage basePage;
        MainPage mainPage;
        SearchPage searchPage;
        public BingSearchSpaceFeature1Steps()
        {
            basePage = new BasePage();
            basePage.Navigate();
            mainPage = new MainPage();
        }

        [Given(@"I have entered The Bing page")]
        public void GivenIHaveEnteredTheBingPage()
        {
            Move.HoverMouse(mainPage.MainPageElem["Logo"]);
        }
        [Given(@"I have entered (.*) into Bing search bar")]
        public void GivenIHaveEntered_IntoBingSearchBar(string searchText)
        {
            searchText = ConstantNames.SearchPhrase;
            mainPage.MainPageElem["SearchBox"].SendKeys(searchText);
        }

        [When(@"I pressed button Search")]
        public void WhenIPressedButtonSearch()
        {
            mainPage.MainPageElem["SearchButton"].Click();
        }
        
        [Then(@"the result should be a new page for (.*)")]
        public void ThenTheResultShouldBeANewPageFor_(string searchTextCount)
        {
            searchPage = new SearchPage();
            searchTextCount = ConstantNames.SearchCount;
            int convertToInt = Convert.ToInt32(searchTextCount);
            Assert.AreEqual(convertToInt, searchPage.SearchPageElemList["SearchResult"].Count);
        }
    }
}

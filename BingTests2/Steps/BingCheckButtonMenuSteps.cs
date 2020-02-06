using BingTestsBLL.Extentions;
using BingTestsBLL.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BingTestsTest.Steps
{
    [Binding]
    public class BingMenuButtonFeatureSteps
    {
        MenuPage menuPage;
        MenuPage2 menuPage2;
        SubSettingsPage subSettingsPage;

        public BingMenuButtonFeatureSteps()
        {
             menuPage = new MenuPage();
        }

        [Given(@"I have clicked to button Menu")]
        public void GivenIHaveClickedToButtonMenu()
        {
            menuPage.MenuButtomElem["MenuButton"].Click();
        }
        
        [When(@"I have clicked to the Settings Button")]
        public void WhenIHaveClickedToTheSettingsButton()
        {
            menuPage2 = new MenuPage2();
            menuPage2.MenuPageElem["Settings"].Click();
        }
        
        [When(@"I could hover all elements of SubSettings Menu")]
        public void WhenICouldHoverAllElementsOfSubSettingsMenu()
        {
            subSettingsPage = new SubSettingsPage();
            Move.HoverMouse(subSettingsPage.SubMenuSettings["SubSettingsLanguage"]);
            Move.HoverMouse(subSettingsPage.SubMenuSettings["SubSettingsCountry"]);
        }
  
        [When(@"I could hover all elements of Settings Menu")]
        public void WhenICouldHoverAllElementsOfSettingsMenu()
        {
            Move.HoverMouse(menuPage2.MenuPageElem["SafeSearch"]);
            Move.HoverMouse(menuPage2.MenuPageElem["SearchHistory"]);
            Move.HoverMouse(menuPage2.MenuPageElem["Privacy"]);
            Move.HoverMouse(menuPage2.MenuPageElem["Feedback"]);
            Move.HoverMouse(menuPage2.MenuPageElem["CustomiseHomepage"]);
        }
        
        [When(@"I have got two buttons for manage by homepage and change their values")]
        public void WhenIHaveGotTwoButtonsForManageByHomepageAndChangeTheirValues()
        {
            Move.HoverMouse(menuPage2.MenuPageElem["ShowMenuBar"]);
            menuPage2.MenuPageElem["ShowMenuBar"].Click();
            menuPage2.MenuPageElem["ShowMenuBar"].Click();
           
            Move.HoverMouse(menuPage2.MenuPageElem["ShowHomepageImage"]);
            menuPage2.MenuPageElem["ShowHomepageImage"].Click();
            menuPage2.MenuPageElem["ShowHomepageImage"].Click();
        }
        
        [Then(@"the result could write to the Table")]
        public void ThenTheResultCouldWriteToTheTable(Table table)
        {
            var menuTable = table.CreateInstance<MenuPage>();

            ConstantMenu menu = new ConstantMenu();

            menu.Language = table.Rows[0]["Value"];
            menu.Country = table.Rows[1]["Value"];
            menu.SafeSearch = table.Rows[2]["Value"];
            menu.ShowMenuBar = table.Rows[3]["Value"];
            menu.ShowHomePageImage = table.Rows[4]["Value"];

            Assert.IsNotNull(subSettingsPage.SubMenuSettings["SubSettingsLanguage"].Text, ConstantNames.ErrorLanguage);
            Assert.IsNotNull(subSettingsPage.SubMenuSettings["SubSettingsCountry"].Text, ConstantNames.ErrorCoutry);
            Assert.IsNotNull(menuPage2.MenuPageElem["SafeSearchValue"].Text, ConstantNames.ErrorSafeSearch);
            //Assert.IsNotNull(menuPage.MenuPageElem["MenuBarLocked"]);
            //Assert.IsNotNull(menuPage.MenuPageElem["HomepageImageIsNotVisible"]);
        }
    }
}

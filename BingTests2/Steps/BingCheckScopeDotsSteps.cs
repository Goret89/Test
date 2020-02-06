using BingTestsBLL.Extentions;
using BingTestsBLL.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BingTestsTest.Steps
{
    [Binding]
    public class BingScopeDotsFeatureSteps
    {
        ScopeDotsPage dotsPage;

        public BingScopeDotsFeatureSteps()
        {
            dotsPage = new ScopeDotsPage();
        }
        [When(@"I clicked at the Scope Dots button")]
        public void WhenIClickedAtTheScopeDotsButton()
        {
            ElementWait.Wait();
            dotsPage.ScopeDotsPageElem["ScopeDots"].Click();
        }
        
        [Then(@"the should get the next result field")]
        public void ThenTheShouldGetTheNextResultField(Table table)
        {
            var scopeDots = table.CreateInstance<ScopeDots>();
            ElementWait.Wait();

            Move.HoverMouse(dotsPage.ScopeDotsPageElem["Video"]);
            Move.HoverMouse(dotsPage.ScopeDotsPageElem["Map"]);
            Move.HoverMouse(dotsPage.ScopeDotsPageElem["News"]);
            Move.HoverMouse(dotsPage.ScopeDotsPageElem["MSN"]);
            Move.HoverMouse(dotsPage.ScopeDotsPageElem["Office"]);

            Assert.IsNotNull(dotsPage.ScopeDotsPageElem["Video"], ConstantNames.ErrorVideo);
            Assert.IsNotNull(dotsPage.ScopeDotsPageElem["Map"], ConstantNames.ErrorMap);
            Assert.IsNotNull(dotsPage.ScopeDotsPageElem["News"], ConstantNames.ErrorNews);
            Assert.IsNotNull(dotsPage.ScopeDotsPageElem["MSN"], ConstantNames.ErrorMSN);
            Assert.IsNotNull(dotsPage.ScopeDotsPageElem["Office"], ConstantNames.ErrorOffice);
        }
    }
}





























//Assert.IsNotNull(dotsPage.ScopeDotsPageElem["Video"]);
//Assert.IsNotNull(dotsPage.ScopeDotsPageElem["Map"]);
//Assert.IsNotNull(dotsPage.ScopeDotsPageElem["News"]);
//Assert.IsNotNull(dotsPage.ScopeDotsPageElem["MSN"]);
//Assert.IsNotNull(dotsPage.ScopeDotsPageElem["Office"]);

//scopeDots.Videos = table.Rows[0]["Value"];
//scopeDots.Maps = table.Rows[1]["Value"];
//scopeDots.News = table.Rows[2]["Value"];
//scopeDots.MSN = table.Rows[3]["Value"];
//scopeDots.Office = table.Rows[4]["Value"];


//| Videos | Maps  | News  | MSN   | Office |
//| true   | false | false | false | false  |
//| false  | true  | false | false | false  |
//| false  | false | true  | false | false  |
//| false  | false | false | true  | false  |
//| false  | false | false | false | true   |



//And I hovered to Videos Link
//	| Videos | Maps  | News  | MSN   | Office |
//	| true   | false | false | false | false  |
//	And I hover to Maps Link
//	| Videos | Maps | News  | MSN   | Office |
//	| false  | true | false | false | false  |
//	And I hover to News Link
//	| Videos | Maps  | News | MSN   | Office |
//	| false  | false | true | false | false  |
//	And I hover to MSN Link
//	| Videos | Maps  | News  | MSN  | Office |
//	| false  | false | false | true | false  |
//	And I hover to Office Link
//	| Videos | Maps  | News  | MSN   | Office |
//	| false  | false | false | false | true   |
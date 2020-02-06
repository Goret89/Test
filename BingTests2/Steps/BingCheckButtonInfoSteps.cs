using BingTestsBLL.Extentions;
using BingTestsBLL.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BingTestsTest.Steps
{
    [Binding]
    public class BingInfoButtonFeatureSteps
    {
        MainPage mainPage;
        InfoHidenBoxPage infoPage;

        public BingInfoButtonFeatureSteps()
        {
            mainPage = new MainPage();
        }

        [When(@"I hovered into Info Button")]
        public void WhenIHoveredIntoInfoButton()
        {
            Move.HoverMouse(mainPage.MainPageElem["InfoButton"]);
        }
        
        [When(@"I have seen hidden block")]
        public void WhenIHaveSeenHiddenBlock()
        {
            infoPage = new InfoHidenBoxPage();
            Move.HoverMouse(infoPage.InfoBoxPageElem["InfoBlock"]);
        }
        
        [When(@"I have seen all {.*} share icons")]
        public void WhenIHaveSeenAll_ShareIcons()
        {
            string[] iconName = { "Facebook", "Twitter", "Skype" };

            int indexOfElement = RandomClass.Rand(infoPage.InfoBoxPageElemList["ShareElements"]);
            
            if(iconName[indexOfElement] == infoPage.InfoBoxPageElemList["ShareElements"][indexOfElement].GetAttribute("title"))
            {
                Move.HoverMouse(infoPage.InfoBoxPageElemList["ShareElements"][indexOfElement]);
            }
            
        }

        [When(@"I have seen load link")]
        public void WhenIHaveSeenLoadLink()
        {
            infoPage.InfoBoxPageElem["DownloadLink"].Click();
        }

        [Then(@"I checked {.*} what image was loaded")]
        public void ThenIChecked_WhatImageWasLoaded(Table images)
        {
            dynamic image = images.CreateDynamicInstance();
            
            if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_1)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_1);
            else if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_2)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_2);
            else if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_3)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_3);
            else if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_4)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_4);
            else if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_5)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_5);
            else if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_6)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_6);
            if (infoPage.InfoBoxPageElem["TitleImage"].Text == image.Image_7)
                Assert.Contains(infoPage.InfoBoxPageElem["TitleImage"].Text, image.Image_7);

        }
    }
}

















//| ShareIcons |
//	| Facebook   |
//	| Twitter    |
//	| Skype      | 






//string image_1 = image.Image_1;
//string image_2 = image.Image_2;
//string image_3 = image.Image_3;
//string image_4 = image.Image_4;
//string image_5 = image.Image_5;
//string image_6 = image.Image_6;
//string image_7 = image.Image_7;

//if (infoPage.TitleImage.Text == image_1 || infoPage.TitleImage.Text == image_2 ||
//   infoPage.TitleImage.Text == image_3 || infoPage.TitleImage.Text == image_4 ||
//   infoPage.TitleImage.Text == image_5 || infoPage.TitleImage.Text == image_6 ||
//   infoPage.TitleImage.Text == image_7)
//    Assert.IsNotNull(infoPage.TitleImage.Text);











//Assert.Contains(infoPage.TitleImage.Text, );

//If I want to see an enumerable values

//IEnumerable<dynamic> imageList = images.CreateDynamicSet();
//var image = imageList.First();


//string image_1 = image.Image_1;
// string image_5 = image.Image_5;

// Console.WriteLine($"Image one is  and image five {image_5}"); /*{image_1}*/
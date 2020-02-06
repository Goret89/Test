Feature: BingCheckButtonInfo
In order to check button Info 
	As a user site
	I want to hover mouse into Info button 

@mytag
Scenario: Check Info button
	Given I have entered The Bing page
	When I hovered into Info Button
	And I have seen hidden block
	And I have seen all {.*} share icons
	And I have seen load link
	Then I checked {.*} what image was loaded
		| ActualImage | Value                                                                                                                |
		| Image_1     | "Sunlit ridges against volcanic scree on Eyjafjallajökull, a volcano in Iceland"                                     |
		| Image_2     | "Red lanterns hanging on branches"                                                                                   |
		| Image_3     | "Tree frog in Cadiz, Spain"                                                                                          |
		| Image_4     | "View of New York City from the International Space Station"                                                         |
		| Image_5     | "Aerial view of the glaciers and mountains of Kluane National Park and Reserve, near Haines Junction, Yukon, Canada" |
		| Image_6     | "Semuc Champey, a nature park in Guatemala"                                                                          |
		| Image_7     | "A reddish egret hunts in Fort De Soto Park, Florida"                                                                |
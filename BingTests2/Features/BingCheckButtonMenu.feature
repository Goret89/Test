Feature: BingCheckButtonMenu
	In order to check Menu Button
    As a site user
    I want to get a working menu   

@mytag
Scenario: Check button Menu 
    Given I have entered The Bing page
    And I have clicked to button Menu 
    When I have clicked to the Settings Button
    And I could hover all elements of SubSettings Menu
    And I could hover all elements of Settings Menu
    And I have got two buttons for manage by homepage and change their values
	Then the result could write to the Table
		| Elements          | Value           |
		| Language          | currentLanguage |
		| Country           | currentCountry  |
		| SafeSearch        | currectUser     |
		| ShowMenuBar       | isTurnOn        |
		| ShowHomePageImage | isExist         |

Feature: BingCheckInputBox
	In order to check InputBox
	As a site user
	I want to move a mouse to the InputBox

@mytag
Scenario: Check a correct title of InputBox
	Given I have entered The Bing page
	When Mouse hovered the input box
	Then The inscription should flash as (.*)


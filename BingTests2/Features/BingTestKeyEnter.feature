Feature: BingTestKeyEnter
	In order to check how to work The Key Enter
	As a site user
	I want to enter in an InputBox some text and click the Enter key on the keyboard

@mytag
Scenario: Enter some text in the input box and click key Enter in the keyboard
	Given I have entered The Bing page
	And I have entered (.*) sentence
	When I pressed the key Enter
	Then A new page should open

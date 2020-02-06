Feature: BingCheckSearchSpace
	In order to find keyword 
	As a site user
	I want to see a new page

@mytag
Scenario: Search Spec Flow in Bing search bar
	 Given I have entered The Bing page
    And I have entered (.*) into Bing search bar
    When I pressed button Search 
    Then the result should be a new page for (.*)


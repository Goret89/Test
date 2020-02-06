Feature: BingCheckScopeDots
	In order to check scope dots button  
	As a user site
	I want to get a whole field

@mytag
Scenario: Check Scope Dots button
	Given I have entered The Bing page
	When I clicked at the Scope Dots button 
	Then the should get the next result field
		| Field  | Value       |
		| Videos | videoValue  |
		| Maps   | mapValue    |
		| News   | newsValue   |
		| MSN    | msnValue    |
		| Office | officeValue |
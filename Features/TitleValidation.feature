Feature: Page title validation
Background: 
	Given I have the page url
	When I navigate to the page

@Smoke
Scenario: Check page title	
	Then the page title should be "Practice Software Testing - Toolshop - v5.0"



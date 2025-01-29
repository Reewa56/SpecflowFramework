Feature: Page title validation
Background: 
	Given I have the page url "https://practicesoftwaretesting.com/"
	When I navigate to the page

@Smoke
Scenario: Check page title	
	Then the page title should be "Practice Software Testing - Toolshop - v5.0"



Feature: Page title validation
Background: 
	When I navigate to the page url "https://ultimateqa.com/automation"

Scenario: Check page title		
	Then the page title should be "Automation Practice - Ultimate QA"
	
Scenario: Click Services check
	And Click on Services link

Scenario: Click Newsletter link
	And Click on Newsletter link

﻿Feature: Page title validation
Background: 
	Given I have the page url "https://practicesoftwaretesting.com/"
	When I navigate to the page

Scenario: Check page title		
	Then the page title should be "Practice Software Testing - Toolshop - v5.0"
	
Scenario: Validate sign in functionality
	When I click on sign in
	And I entered email address
	And I entered the password
	And I click the sign in button


	



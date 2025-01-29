Feature: SignIn validation
Background: 
	Given I have the page url "https://practicesoftwaretesting.com/"
	When I navigate to the page

@Regression	
Scenario: Validate sign in functionality
	When I click on sign in
	And I entered email address
	And I entered the password
	And I click the sign in button
	Then I validate that sign in is successfully done
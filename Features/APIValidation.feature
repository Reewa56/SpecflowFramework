Feature: Rest API Validation

Scenario: Validate login api
	Given I set the API url to "https://reqres.in/"
	And I set the endpoint to "/api/users/2"
	When I send a get request
	Then I validate status code
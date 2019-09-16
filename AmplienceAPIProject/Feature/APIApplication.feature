Feature: APIApplication
	

@Amplience Endpoint
Scenario: Get API response from an endpoint
	Given I have an endpoint "users"
	When I call Get method in API
	Then I get API response in Json format


	Scenario Outline: Get user information using userid
	Given I have an endpoint "users"
	When I call get method to get user information using <userid>
	Then I will get user information

	Examples: user info
	| userid |
	| 6wl    |
	| tomtt  |

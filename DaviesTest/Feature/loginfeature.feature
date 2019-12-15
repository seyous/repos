Feature: loginfeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: login user to create account with valid Email
	Given user is at the Home Page
	And user click on sign-in button
	And create account is displayed
	When user input their email address
	And click on create account button
	Then user sign up page should be displayed
	
	
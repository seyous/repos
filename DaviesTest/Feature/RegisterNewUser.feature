Feature: Register New User using your Email Address
	

@mytag
Scenario: Register New User With Email
	Given user navigate to the Home Page
	And user click on sign-in button
	When create an account is displayed
	And user input their email address
	And click on create account button
	Then user sign up page should be displayed
	And User enters the following mandator fields
	| Key        | Value                |
	| Firstname  | henry               |
	| Lastname   | Onwuka                |
	| Email      | vision01@gmail.com |
	| Password   | Blender1            |
	| First_name | henry               |
	| Last_name  | Onwuka               |
	| Address    | 5 Ivy Close          |
	| City       | Hopkins              |
	| State      | Minnesota            |
	| PostalCode | 55305              |
	| Country    | United State       |
	| Mobilephone | 07459672145          |
	| AddressAlias  | Podress1              |

	And Click on the Register button
	Then Successful LogIN message should display
	And  user click on sign-out button


	Scenario: Validate New User can login With Email
	Given user navigate to the Home Page
	And user click on sign-in button
	When user enters the username
	And user enters the password
	And user click  the sign-in button
	Then Successful LogIN message should display
	And user mouse over the dress menu bar and click
	When user click on the image
	And user add to the cart
	Then product is successfully added to cart
	And the user click on proceed to checkout
	And the user proceed to shopping cart summary page
	And the user proceed to checkout signin
	And the user proceed to checkout Address
	And the user procedd to checkout shipping
	And the user choose the method of <payment>
	And the user confirm the order

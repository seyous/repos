Feature: Create User account and validate field
	

@mytag
Scenario: Successful Login with Valid Credentials
	Given User is at the Sign up page
	When User enter credentials
	| Key      | Value      |
	| Firstname | Oluseyi |
	| Lastname | Ojo   |
	| Email| aka_seyous@yahoo.com |
	| Password | Obasanjo1 |
	| Firstname | Oluseyi |
	| Lastname | Ojo   |
	| Company |Rental Techo |
	| Address | 3 Westphil Close   |
	| City | Manchester |
	| State | Test@123   |
	| Zip/Postal Code | M236YB|
	| Country | United Kingdom  |
	| Mobile phone | 07459672135 |
	| Address Alias | Podress  |

	And Click on the Register button
	Then Successful LogIN message should display



	Scenario: Successful Login with InValid Credentials
	Given User is at the Sign up page
	When User enter credentials
	| Key      | Value      |
	| Firstname | testuser_1 |
	| Lastname | Test@123   |
	| Email| testuser_1 |
	| Password | Test@123   |
	| Firstname | testuser_1 |
	| Lastname | Test@123   |
	| Company | testuser_1 |
	| Address | Test@123   |
	| City | testuser_1 |
	| State | Test@123   |
	| Zip/Postal Code | testuser_1 |
	| Country | Test@123   |
	| Mobile phone | testuser_1 |
	| Address Alias | Test@123   |

	And Click on the Register button
	Then Successful LogIN message should display

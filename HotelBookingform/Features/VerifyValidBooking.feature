Feature: Verify Booking with Valid User details
	

@mybooking
Scenario Outline: The user enters valid credentials to create a booking

Given user navigate to the website form
When the user enters the firstname "<firstname>"
And the user enters the surname "<surname>"
And the user enters the price "<price>"
And the user enters the deposit "<deposit>"
And the user enters the checkin "<checkin>"
And the user enters the checkout "<checkout>"
And the click on the save button
Then the user information is displayed

Examples:
| firstname | surname | price | deposit | checkin    | checkout   |
| oluseyi   | ojo     | 706   | true    | 2019-12-13 | 2019-12-13 |
| willaims  | beth    | 532   | true    | 2019-12-13 | 2019-12-14 |
| brown     | phillip | 606   | false   | 2019-12-21 | 2020-05-13 |
| henry     | queen   | 932   | false   | 2019-12-14 | 2020-12-14 |



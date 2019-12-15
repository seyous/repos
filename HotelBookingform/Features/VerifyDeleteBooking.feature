Feature: Verify Delete Booking
	

@mybooking
Scenario: The user can delete a booking

Given user navigate to the website form
When the user enters the firstname "<firstname>"
And the user enters the surname "<surname>"
And the user enters the price "<price>"
And the user enters the deposit "<deposit>"
And the user enters the checkin "<checkin>"
And the user enters the checkout "<checkout>"
And the click on the save button
Then the user information is displayed
And the user delete the booking

Examples:
| firstname | surname | price | deposit | checkin    | checkout   |
| oluseyi   | ojo     | 706   | true    | 2019-12-13 | 2019-12-13 |
| james     | hillary | 532   | true    | 2019-12-13 | 2019-12-14 |

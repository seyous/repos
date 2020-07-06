Hotel Booking form
- The project was developed using BDD framework with .NET using speclow.


Clone
- clone on https://github.com/seyous/repos.git
- All files are contained in HotelBookingform folder, please ignore other folders.

Or

Get the link on github
https://github.com/seyous/repos/tree/master/HotelBookingform


Getting Started
- To access the project in Visual Studio install the following nuget package on visual studio, specflow, Nunit, Selenium.webdriver, selenium.support, nunitt3TestAdapter, nunit.console, nunit.runner, specflow.nunit, selenium.webdriver.chromedriver, Specflow.Tools.Msbuild.Generation


Installing
- install all the nuget package by going to reference and add nuget Packages


To Run the tests
- Please Double click Reports folder and double click Reportgenerator bat file. it will run the test and generate html report, xmlreport and a textreport inside the Reportfiles folder.



Break down into end to end tests
- There are 2 test. 1. for creation of a new booking using 4 scenarios, 2. deletion of booking using 2 scenarios.
which are 6 featues files in the features folder. To run the test in Visual Studio click Run All on the Test Explorer.


The Manual test contain 1 excel file - (Hotel Booking Test case.xls) which are made up of 3 Test cases for both positive and negative test
- Test case 1 - Verify the user can book with valid booking details
- Test case 2 - Verify user can not book with Invalid booking details
- Test case 3 - Verify user can delete a booking


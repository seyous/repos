using HotelBookingform.PageObj;
using HotelBookingform.Utilities;
using System;
using System.Drawing;
using TechTalk.SpecFlow;

namespace HotelBookingform.Steps
{
    [Binding]
    public class VerifyBookingWithValidUserDetailsSteps
    {

        private readonly FormObjects _formObjects;

        public VerifyBookingWithValidUserDetailsSteps(FormObjects formObjects)
        {
            _formObjects = formObjects;
        }

        [Given(@"user navigate to the website form")]
        public void GivenUserNavigateToTheWebsiteForm()
        {
            Hooks.driver.Navigate().GoToUrl("http://hotel-test.equalexperts.io/");
            Hooks.driver.Manage().Window.Maximize();
        }

        [When(@"the user enters the firstname ""(.*)""")]
        public void WhenTheUserEntersTheFirstname(string firstname)
        {
            WaitforElement.wait();
            _formObjects.Enterfirstname(firstname);
        }

        [When(@"the user enters the surname ""(.*)""")]
        public void WhenTheUserEntersTheSurname(string lastname)
        {
            _formObjects.Entersurname(lastname);
        }

        [When(@"the user enters the price ""(.*)""")]
        public void WhenTheUserEntersThePrice(int price)
        {
            WaitforElement.wait();
           _formObjects.EnterPrice(price);
        }
        [When(@"the user enters the deposit""(.*)""")]

        [When(@"the user enters the deposit ""(.*)""")]
        public void WhenTheUserEntersTheDeposit(string deposit)
        {
            WaitforElement.wait();
            _formObjects.Enterdeposit(deposit);
        }


        [When(@"the user enters the checkin ""(.*)""")]
        public void WhenTheUserEntersTheCheckin(string checkin)
        {
            WaitforElement.wait();
            _formObjects.Entercheckin(checkin);
        }

        [When(@"the user enters the checkout ""(.*)""")]
        public void WhenTheUserEntersTheCheckout(string checkout)
        {
            WaitforElement.wait();
            _formObjects.Entercheckout(checkout);
        }



        [When(@"the click on the save button")]
        public void WhenTheClickOnTheSaveButton()
        {
            WaitforElement.wait();
            _formObjects.ClicksaveButton();
        }
        
        [Then(@"the user information is displayed")]
        public void ThenTheUserInformationIsDisplayed()
        {
            WaitforElement.wait();
            _formObjects.BookingIsDisplayed();
        }

        [Then(@"the user delete the booking")]
        public void ThenTheUserDeleteTheBooking()
        {
            WaitforElement.wait();
            _formObjects.ClickdeleteButton();
        }

    }
}

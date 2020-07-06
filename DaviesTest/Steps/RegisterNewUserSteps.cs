using DaviesTest.pageobj;
using DaviesTest.Util;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System;

using TechTalk.SpecFlow;

namespace DaviesTest
{
    [Binding]
    public sealed class RegisterNewUserSteps
    {
        //loginpage _loginpage = new loginpage();

        //[Obsolete]
        //public RegisterNewUserSteps()
        //{
        //    PageFactory.InitElements(Hooks.driver, _loginpage);
        //}

        private readonly registerpage _registerpage;

        public RegisterNewUserSteps(registerpage registerpage)
        {
            _registerpage = registerpage;
        }


        [Given(@"user navigate to the Home Page")]
        public void GivenUserNavigateToTheHomePage()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com");
            WaitforElement.DriverWait();
            Hooks.driver.Manage().Window.Maximize();
        }

        [Given(@"user click on sign-in button")]
        public void GivenUserClickOnSign_InButton()
        {
            WaitforElement.wait();
            _registerpage.ClickSigninbutton();
        }

        [When(@"create an account is displayed")]
        public void WhenCreateAnAccountIsDisplayed()
        {
            bool message =_registerpage.IsCreateAccountDisplayed();
            Assert.That(message, Is.True);
        }


        [When(@"user input their email address")]
        public void WhenUserInputTheirEmailAddress()
        {
            WaitforElement.wait();
            _registerpage.Inputemail();
        }

        [When(@"click on create account button")]
        public void WhenClickOnCreateAccountButton()
        {
            _registerpage.ClickCreateAccountbutton();
        }

        [Then(@"user sign up page should be displayed")]
        public void ThenUserSignUpPageShouldBeDisplayed()
        {
           Assert.IsTrue(_registerpage.IsSignUpPageDisplayed());
        }
        

        [Then(@"User enters the following mandator fields")]
        public void ThenUserEntersTheFollowingMandatorFields(Table table)
        {
            _registerpage.UserEnterFields(table);
        }
        
        [Then(@"Click on the Register button")]
        public void ThenClickOnTheRegisterButton()
        {
            _registerpage.ClickRegisterbutton();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            WaitforElement.wait();
            string message =_registerpage.AccountCreated();
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", message);

        }
        [Then(@"user click on sign-out button")]
        public void ThenUserClickOnSign_OutButton()
        {
            _registerpage.ClickSignoutButton();
        }




    }
}

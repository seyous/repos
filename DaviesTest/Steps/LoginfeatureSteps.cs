using DaviesTest.pageobj;
using DaviesTest.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace DaviesTest.Steps
{
    [Binding]
    public sealed class LoginfeatureSteps
    {
        registerpage Loginpage = new registerpage();


        public LoginfeatureSteps()
        {
            PageFactory.InitElements(Hooks.driver, Loginpage);
        }

        [Given(@"user is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
           Hooks.driver.Navigate().GoToUrl ("http://automationpractice.com");
        }
        
        //[Given(@"user click on sign-in button")]
        //public void GivenUserClickOnSign_InButton()
        //{
        //    Loginpage.ClickSigninbutton();
        //}
        
        //[Given(@"create account is displayed")]
        //public void GivenCreateAccountIsDisplayed()
        //{
        //   IWebElement webElement = Hooks.driver.FindElementByXPath("//div[@id='center_column']/h1[contains(text(),'Authentication' )]");
        //    Assert.AreEqual(webElement, "Authenticaton");
        //}

        //[When(@"user input their email address")]
        //public void WhenUserInputTheirEmailAddress()
        //{
        //    Loginpage.Inputemail();
        //}


        //[When(@"click on create account button")]
        //public void WhenClickOnCreateAccountButton()
        //{
        //    Loginpage.ClickCreateAccountbutton();
        //}
        
        //[Then(@"user sign up page should be displayed")]
        //public void ThenUserSignUpPageShouldBeDisplayed()
        //{
        //   var createAccountTitle = Hooks.driver.FindElementsByCssSelector("#noSlide > h1");

        //    try
        //    {
        //        Assert.AreEqual(createAccountTitle, "CREATE AN ACCOUNT");
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
            
        }
    }


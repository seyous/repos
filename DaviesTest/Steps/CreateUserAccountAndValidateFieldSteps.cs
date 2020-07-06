using DaviesTest.pageobj;
using DaviesTest.Util;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace DaviesTest.Steps
{
    [Binding]
    public class CreateUserAccountAndValidateFieldSteps
    {
        registerpage Loginpage = new registerpage();

        public CreateUserAccountAndValidateFieldSteps()
        {
            PageFactory.InitElements(Hooks.driver, Loginpage);
        }

        [Given(@"User is at the Sign up page")]
        public void GivenUserIsAtTheSignUpPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        //[When(@"User enter credentials")]
        //public void WhenUserEnterCredentials(Table table)
        //{
        //   var dictionary = Tableextension.Todictionary(table);
        //   // Hooks.driver.fi

        //}
        
        [When(@"Click on the Register button")]
        public void WhenClickOnTheRegisterButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        //[Then(@"Successful LogIN message should display")]
        //public void ThenSuccessfulLogINMessageShouldDisplay()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}

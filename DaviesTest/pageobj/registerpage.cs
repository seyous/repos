using DaviesTest.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DaviesTest.pageobj
{
    public class registerpage
    {

        //[FindsBy(How = How.XPath, Using = "//div[@class ='header_user_info']//a[@class='login']")]
        //private IWebElement signIn;

        IWebElement signIn => Hooks.driver.FindElementByClassName("header_user_info");
        IWebElement emailTextbox => Hooks.driver.FindElementById("email_create");
        IWebElement createAccountbutton => Hooks.driver.FindElementById("SubmitCreate");
        IWebElement firstnameTextbox => Hooks.driver.FindElementById("customer_firstname");
        IWebElement lastnameTextbox => Hooks.driver.FindElementById("customer_lastname");
        IWebElement mailTextbox => Hooks.driver.FindElementById("email");
        IWebElement passwordTextbox => Hooks.driver.FindElementById("passwd");
        IWebElement first_nameTextbox => Hooks.driver.FindElementById("firstname");
        IWebElement last_nameTextbox => Hooks.driver.FindElementById("lastname");
        IWebElement addressTextbox => Hooks.driver.FindElementById("address1");
        IWebElement cityTextbox => Hooks.driver.FindElementById("city");
        IWebElement stateTextbox => Hooks.driver.FindElementById("id_state");
        IWebElement postalcodeTextbox => Hooks.driver.FindElementById("postcode");
        IWebElement countryTextbox => Hooks.driver.FindElementById("id_country");
        IWebElement mobilephoneTextbox => Hooks.driver.FindElementById("phone_mobile");

        IWebElement aliasTextbox => Hooks.driver.FindElementById("alias");
        IWebElement registerButton => Hooks.driver.FindElementById("submitAccount");

        IWebElement accountCreatedMessage => Hooks.driver.FindElementByCssSelector("#center_column > p");

        IWebElement signoutButton => Hooks.driver.FindElementByClassName("logout");





        //[FindsBy(How = How.Name, Using = "email_create")]
        //private  IWebElement emailTextbox;

        //[FindsBy(How = How.Id, Using = "SubmitCreate")]
        //private IWebElement createAccountbutton;

        //[FindsBy(How = How.Id, Using = "customer_firstname")]
        //private IWebElement firstnameTextbox;

        // [FindsBy(How = How.Id, Using = "SubmitCreate")]
        //private IWebElement lastTextbox;

        //[FindsBy(How = How.Id, Using = "email")]
        //private IWebElement mailTextbox;

        //[FindsBy(How = How.Id, Using = "passwd")]
        //private IWebElement passwordTextbox;

        //[FindsBy(How = How.Id, Using = "firstname")]
        //private IWebElement first_nameTextbox;

        //[FindsBy(How = How.Id, Using = "lastname")]
        //private IWebElement last_nameTextbox;

        //  [FindsBy(How = How.Id, Using = "address1")]
        //private IWebElement addressTextbox;

        // [FindsBy(How = How.Id, Using = "city")]
        //private IWebElement cityTextbox;

        // [FindsBy(How = How.Id, Using = "id_state")]
        //private IWebElement stateTextbox;

        //[FindsBy(How = How.Id, Using = "postcode")]
        //private IWebElement postalcodeTextbox;

        //[FindsBy(How = How.Id, Using = "id_country")]
        //private IWebElement id_country;

        //[FindsBy(How = How.Id, Using = "phone_mobile")]
        //private IWebElement mobilephoneTextbox;

        // [FindsBy(How = How.Id, Using = "alias")]
        //private IWebElement aliasTextbox;


        //[FindsBy(How = How.Id, Using = "submitAccount")]
        //private IWebElement registerButton;



        public void ClickSigninbutton()
        {
            signIn.Click();
        }


        public void Inputemail()
        {
            emailTextbox.Clear();
            emailTextbox.SendKeys("vision01@gmail.com");
        }

        public void ClickCreateAccountbutton()
        {
            createAccountbutton.Click();
            WaitforElement.wait();
        }

        public bool IsCreateAccountDisplayed()
        {
            bool createAccountBox = Hooks.driver.FindElementById("create-account_form").Displayed;
            return createAccountBox;
        }

        
        public string AccountCreated()
        {
            return accountCreatedMessage.Text;
        }

        public bool IsSignUpPageDisplayed()
        {
            //WaitforElement.wait();
            bool personalinformationblock = Hooks.driver.FindElementById("account-creation_form").Displayed;
            return personalinformationblock;
        }

        public void UserEnterFields(Table table)
        {
            var dictionary = Tableextension.Todictionary(table);
            firstnameTextbox.Clear();
            firstnameTextbox.SendKeys(dictionary["Firstname"]);
            lastnameTextbox.Clear();
            lastnameTextbox.SendKeys(dictionary["Lastname"]);
            mailTextbox.Clear();
            mailTextbox.SendKeys(dictionary["Email"]);
            passwordTextbox.Clear();
            passwordTextbox.SendKeys(dictionary["Password"]);
            first_nameTextbox.Clear();
            first_nameTextbox.SendKeys(dictionary["First_name"]);
            last_nameTextbox.Clear();
            last_nameTextbox.SendKeys(dictionary["Last_name"]);
            addressTextbox.Clear();
            addressTextbox.SendKeys(dictionary["Address"]);
            cityTextbox.Clear();
            cityTextbox.SendKeys(dictionary["City"]);
            //SelectElement selectElement = new SelectElement(stateTextbox);
            //selectElement.SelectByText(dictionary["State"]);
            
            stateTextbox.SendKeys(dictionary["State"]);
            postalcodeTextbox.Clear();
            postalcodeTextbox.SendKeys(dictionary["PostalCode"]);
            //SelectElement Element = new SelectElement(countryTextbox);
            //Element.SelectByText(dictionary["Country"]);
            countryTextbox.SendKeys(dictionary["Country"]);
            mobilephoneTextbox.Clear();
            mobilephoneTextbox.SendKeys(dictionary["Mobilephone"]);
            aliasTextbox.Clear();
            aliasTextbox.SendKeys(dictionary["AddressAlias"]);
        }

        public void ClickRegisterbutton()
        {
            registerButton.Click();
        }

        public void ClickSignoutButton()
        {
            signoutButton.Click();
        }

    }
}

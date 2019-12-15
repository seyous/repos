using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviesTest.pageobj
{
    public class loginpage
    {
        
       [FindsBy(How = How.XPath, Using = "//div[@class ='header_user_info']//a[@class='login']")]
       private IWebElement signIn;

        [FindsBy(How = How.Name, Using = "email_create")]
        private IWebElement emailTextbox;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement createAccountbutton;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        private IWebElement firstnameTextbox;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement lastTextbox;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement passwordTextbox;

        [FindsBy(How = How.Id, Using = "firstname")]
        private IWebElement first_nameTextbox;

        [FindsBy(How = How.Id, Using = "lastname")]
        private IWebElement last_nameTextbox;

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement addressTextbox;

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement cityTextbox;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement stateTextbox;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement postalcodeTextbox;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement countryTextbox;

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        private IWebElement mobilephoneTextbox;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement aliasTextbox;

        public void ClickSigninbutton()
        {
            signIn.Click();
        }
      
        
        public void Inputemail()
        {
            emailTextbox.Clear();
            emailTextbox.SendKeys("aka_seyous@yahoo.com");
        }

         public void ClickCreateAccountbutton()
        {
            createAccountbutton.Click();
        }
    }
}

using DaviesTest.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviesTest.pageobj
{
    public class loginpage
    {
        IWebElement mailTextbox => Hooks.driver.FindElementById("email");
        IWebElement passwordTextbox => Hooks.driver.FindElementById("passwd");

        IWebElement signoutButton => Hooks.driver.FindElementByClassName("logout");

        IWebElement submitloginButton => Hooks.driver.FindElementById("SubmitLogin");

        IWebElement signinMessage => Hooks.driver.FindElementByCssSelector("#center_column > p");


        public void ClickSignout()
        {
            signoutButton.Click();
        }

        public void Enteremailaddress()
        {
            WaitforElement.wait();
            mailTextbox.Clear();
            mailTextbox.SendKeys("vision01@gmail.com");
        }

        public void EnterPassword()
        {
            passwordTextbox.Clear();
            passwordTextbox.SendKeys("Blender1");
        }

        public void ClickSigninbutton()
        {
            submitloginButton.Click();
        }

        public string SignInmassage()
        {
            return signinMessage.Text;
        }

    }
}

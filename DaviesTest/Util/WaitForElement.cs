using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaviesTest.Util
{
   
        public static class WaitforElement
        {
            public static IWebElement webElement;

            public static void wait()
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
            }

            public static void ImplicitWaitforElement()
            {
                Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            }

            public static void DriverWait()
            {
                WebDriverWait wait = new WebDriverWait(Hooks.driver, TimeSpan.FromSeconds(4));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("header_user_info")));
            }
        }

    
}
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelBookingform.Utilities
{
   
    public static class WaitforElement
    {
        public static IWebElement webElement;  

        public static void wait()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        public static void ImplicitWaitforElement()
        {
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
                
                }

        public static void DriverWait()
        {
           // WebDriverWait wait = new WebDriverWait(wb, 20);
            //webElement = wait.Until(.visibilityOfElementLocated(By.id("about_me")));
        }
    }
}

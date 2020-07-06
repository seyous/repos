using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace HotelBookingform.Utilities
{
    [Binding]
    public sealed class Hooks
    {
        public static ChromeDriver driver;

        [BeforeScenario]
        public void Beforescenario ()
        {
            driver = new ChromeDriver();
            WaitforElement.wait();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Dispose();
        }
    }
}

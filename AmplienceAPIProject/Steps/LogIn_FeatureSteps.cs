using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowDemo1.Utils;
using System;
using TechTalk.SpecFlow;

namespace AmplienceAPI.Steps
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        public static  IWebDriver driver;


        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\aka_s\source\repos\SpecflowDemo1\Chrome\chromedriver.exe");

            driver = new ChromeDriver();
            driver.Url = "https://github.com/mojombo";
        }
        
        
       
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            bool OverviewTab =  driver.FindElement(By.XPath("//*[@id='js-pjax-container']/div/div[3]/div[2]/nav/a[1])")).Displayed;
            Assert.IsTrue(OverviewTab);
        }
        
      
    }
}

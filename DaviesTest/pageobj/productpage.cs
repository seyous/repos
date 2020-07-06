using DaviesTest.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaviesTest.pageobj
{
   public class productpage
    {
        IWebElement womenMenu => Hooks.driver.FindElementByXPath("//*[@id='block_top_menu']/ul/li[1]/a");
        IWebElement dressesMenu => Hooks.driver.FindElementByXPath("//*[@id='block_top_menu']/ul/li[2]/a");

        IWebElement tshirtMenu => Hooks.driver.FindElementByXPath("//*[@id='block_top_menu']/ul/li[3]/a");

        IWebElement blousesdropdownMenu => Hooks.driver.FindElementByXPath("//*[@id='block_top_menu']/ul/li[1]/ul/li[1]/ul/li[2]/a");

        IWebElement summerdressesdropdownMenu => Hooks.driver.FindElementByXPath("//*[@id='block_top_menu']/ul/li[1]/ul/li[2]/ul/li[3]/a");

        IWebElement blousedress => Hooks.driver.FindElementByClassName("product-container");

        IWebElement addtocart => Hooks.driver.FindElementById("add_to_cart");

        IWebElement proceedtocheckout => Hooks.driver.FindElementByXPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a");

        IWebElement proceedtocheckoutsignin => Hooks.driver.FindElementByXPath("//a[@href='http://automationpractice.com/index.php?controller=order&step=1']");

        IWebElement proceedtocheckoutAddress => Hooks.driver.FindElementByXPath("//button[@name='processAddress']");

        IWebElement proceedtocheckoutShipping => Hooks.driver.FindElementByXPath("//button[@name='processCarrier']");
        IWebElement termsofService => Hooks.driver.FindElementById("cgv");

        IWebElement ClickPaybyWire => Hooks.driver.FindElementByClassName("bankwire");
        IWebElement ClickbyCheck => Hooks.driver.FindElementByClassName("cheque");

        IWebElement ClickconfirmmyOrder => Hooks.driver.FindElementByXPath("//button[@type='submit']");


        //button[@name="processCarrier"]

        public void ClickblouseWomenDropdownMenu()
        {
            Actions action = new Actions(Hooks.driver);
            action.MoveToElement(womenMenu).Perform();
            WaitforElement.wait();
            blousesdropdownMenu.Click();
        }

        public void ClickWomenSummerDresses()
        {
            Actions action = new Actions(Hooks.driver);
            action.MoveToElement(womenMenu).Perform();
            WaitforElement.wait();
            summerdressesdropdownMenu.Click();

        }

        public void ClickBlouse()
        {
           // Actions actions = new Actions(Hooks.driver);
           // actions.MoveToElement(blousedress).Perform();
            //WaitforElement.wait();
//actions.Click();

           IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,250)", "");
            WaitforElement.wait();
            blousedress.Click();
        }

        public void ClickProceedCheckout()
        {
            WaitforElement.wait();
            proceedtocheckout.Click();
        }

        public bool ShoppingCartSummaryPage()
        {
            WaitforElement.wait();
             bool summarytable = Hooks.driver.FindElementById("order-detail-content").Displayed;
           return  summarytable;
        }
        public void AddtoCart()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,250)", "");
            WaitforElement.wait();
           // String parentHandle = Hooks.driver.CurrentWindowHandle; // get the current window handle
            addtocart.Click();
            WaitforElement.wait();
            //IWebElement newFrame = Hooks.driver.FindElementByClassName("clearfix");
            //Hooks.driver.SwitchTo().NewWindow(0);
            Hooks.driver.SwitchTo().Window(Hooks.driver.WindowHandles.Last());

            //// foreach (String winHandle in Hooks.driver.CurrentWindowHandle)
            // {
            //    Hooks.driver.SwitchTo().Window(winHandle); // switch focus of WebDriver to the next found window handle (that's your newly opened window)
            // }
            // foreach (string winHandle in context.GetDriver().WindowHandles)
            // {

            //     context.GetDriver().SwitchTo().Window(winHandle);
            //                           }

            // Store the current window handle
            // String winHandleBefore = Hooks.driver.CurrentWindowHandle;

            // Perform the click operation that opens new window

            // Switch to new window opened
            //for (String winHandle : Hooks.driver.CurrentWindowHandle)
            //{
            //    Hooks.driver.SwitchTo().Window(winHandle);
            //}

            //// Perform the actions on new window

            //// Close the new window, if that window no more required
            //Hooks.driver.Close();

            //// Switch back to original browser (first window)
            //Hooks.driver.SwitchTo().Window(winHandleBefore);

            //// Continue with original browser (first window)

        }

        public bool IsProductReturned()
        {
            WaitforElement.ImplicitWaitforElement();
            bool messageicon = Hooks.driver.FindElementByClassName("icon-ok").Displayed;
            return messageicon;
        }

        public void ClickProceedCheckoutSignin()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,450)", "");
            WaitforElement.wait();
            proceedtocheckoutsignin.Click();
        }

        public void ClickProceedCheckoutAddress()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,450)", "");
            WaitforElement.wait();
            proceedtocheckoutAddress.Click();
        }

        public void ClickProceedCheckoutShipping()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,250)", "");
            termsofService.Click();
            WaitforElement.ImplicitWaitforElement();
            proceedtocheckoutShipping.Click();

        }

        public void ClickPayByWire()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,450)", "");
            WaitforElement.wait();
            ClickPaybyWire.Click();

        }

        public void ClickByCheque()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0,450)", "");
            WaitforElement.wait();
            ClickbyCheck.Click();

        }

        public void ConfirmmyOrder()
        {
            ClickconfirmmyOrder.Click();
        }
    }
}

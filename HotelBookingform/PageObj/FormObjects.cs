using HotelBookingform.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingform.PageObj
{
    public class FormObjects
    {
        IWebElement firstnameTextBox => Hooks.driver.FindElementById("firstname");
        IWebElement surnameTextBox => Hooks.driver.FindElementById("lastname");
        IWebElement priceTextBox => Hooks.driver.FindElementById("totalprice");
        IWebElement depositTextBox => Hooks.driver.FindElementById("depositpaid");
        IWebElement checkinTextBox => Hooks.driver.FindElementById("checkin");
        IWebElement checkoutTextBox => Hooks.driver.FindElementById("checkout");
        IWebElement saveButton => Hooks.driver.FindElementByXPath("//*[@id='form']/div/div[7]/input");
        IWebElement deleteButton => Hooks.driver.FindElementByXPath("//*/div[7]/input");




        public void Enterfirstname(String text)
        {
            firstnameTextBox.Clear();
            firstnameTextBox.SendKeys(text);
        }
        public void Entersurname(String text)
        {
            surnameTextBox.Clear();
            surnameTextBox.SendKeys(text);
        }


        public void EnterPrice(int number)
        {
            priceTextBox.SendKeys((number).ToString());
            //price.SendKeys(number);
        }
        public void Enterdeposit(String text)
        {
            SelectElement element = new SelectElement(depositTextBox);
            element.SelectByText(text);
        }

        public void Entercheckin(String text)
        {
            checkinTextBox.Clear();
            checkinTextBox.SendKeys(text);
        }

        public void Entercheckout(string text)
        {
            checkoutTextBox.Clear();
            checkoutTextBox.SendKeys(text);
        }

        public void ClicksaveButton()
        {
            saveButton.Click();

        }

       
        public bool BookingIsDisplayed()
        {
            for (int i = 0; i <= 5; i++)
            {
            
            bool searchIconPresence = Hooks.driver.FindElementByClassName("row").Displayed;
                if (searchIconPresence == true)
                {
                    WaitforElement.wait();
                    return true;
                }
                else
                {
                    return false;
                }
               
        }
            return false;

    }
        public void ClickdeleteButton()
        {
            for (int i = 1; i <= 3; i++) {
                deleteButton.Click();
                WaitforElement.wait();

            }
        }


    }
}

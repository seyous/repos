using DaviesTest.pageobj;
using DaviesTest.Util;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DaviesTest.Steps
{
    [Binding]
    public sealed class ConfirmNewUserPurchaseSteps
    {

        loginpage _loginpage = new loginpage();
        productpage _productpage = new productpage();



       
       
        [When(@"user enters the username")]
        public void WhenUserEntersTheUsername()
        {
            _loginpage.Enteremailaddress();
        }


        //[Given(@"user enters the password")]
        //public void GivenUserEntersThePassword()
        //{
        //    _loginpage.EnterPassword();
        //}

        [When(@"user enters the password")]
        public void WhenUserEntersThePassword()
        {
            _loginpage.EnterPassword();
        }

        //[Given(@"user click  the sign-in button")]
        //public void GivenUserClickTheSign_InButton()
        //{
        //    WaitforElement.wait();
        //    _loginpage.ClickSigninbutton();
        //}

        [When(@"user click  the sign-in button")]
        public void WhenUserClickTheSign_InButton()
        {
            WaitforElement.wait();
            _loginpage.ClickSigninbutton();
        }

    

        [Then(@"user mouse over the dress menu bar and click")]
        public void ThenUserMouseOverTheDressMenuBarAndClick()
        {
            _productpage.ClickblouseWomenDropdownMenu();
        }



        [When(@"user click on the image")]
        public void WhenUserClickOnTheImage()
        {
            _productpage.ClickBlouse();
        }

        [When(@"user add to the cart")]
        public void WhenUserAddToTheCart()
        {
            _productpage.AddtoCart();
        }

        [Then(@"product is successfully added to cart")]
        public void ThenProductIsSuccessfullyAddedToCart()
        {
            Assert.IsTrue(_productpage.IsProductReturned());
        }

        [Then(@"the user click on proceed to checkout")]
        public void ThenTheUserClickOnProceedToCheckout()
        {
            _productpage.ClickProceedCheckout();
        }

        [Then(@"the user proceed to shopping cart summary page")]
        public void ThenTheUserProceedToShoppingCartSummaryPage()
        {
            bool itempurchased = _productpage.ShoppingCartSummaryPage();
            Assert.IsTrue(itempurchased);
        }
        [Then(@"the user proceed to checkout signin")]
        public void ThenTheUserProceedToCheckoutSignin()
        {
            _productpage.ClickProceedCheckoutSignin();
        }

        [Then(@"the user proceed to checkout Address")]
        public void ThenTheUserProceedToCheckoutAddress()
        {
            _productpage.ClickProceedCheckoutAddress();
        }
        [Then(@"the user procedd to checkout shipping")]
        public void ThenTheUserProceddToCheckoutShipping()
        {
            _productpage.ClickProceedCheckoutShipping();
        }


        [Then(@"the user choose the method of (.*)")]
        public void ThenTheUserChooseTheMethodOf(string paymenttype)
        {
            //string TypeofPay = string.Empty;

            //switch (paymenttype)
            //{
            //    case "AB":
            //        _productpage.ClickPayByWire();
            //        break;
            //    case "BB":
            //        _productpage.ClickByCheque();
            //        break;
            bool typePay = false;

            if (paymenttype != null)
            {
                _productpage.ClickPayByWire();
            }
            else
            {
                _productpage.ClickPayByWire();
            }
                       
        }

        

        [Then(@"the user confirm the order")]
        public void ThenTheUserConfirmTheOrder()
        {

            _productpage.ConfirmmyOrder();
        }


    }
}

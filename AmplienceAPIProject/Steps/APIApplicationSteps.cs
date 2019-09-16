
using AmplienceAPI.Pageobj;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace APIApplication.Steps
{
    [Binding]
    public sealed class APIApplicationSteps
    {


        [Given(@"I have an endpoint ""(.*)""")]
        public void GivenIHaveAnEndpoint(string endpoint)
        {
            RestAPIHelper.seturl(endpoint);
        }
        
        [When(@"I call Get method in API")]
        public void WhenICallGetMethodInAPI()
        {
            RestAPIHelper.GetRequest();
        }
        
        [Then(@"I get API response in Json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            var expected = "something";
            var response = RestAPIHelper.GetResponse();
            Assert.That(response.Content, Is.EqualTo(expected), "Error Message");

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.Content, Is.EqualTo(expected), "Error Message");
            }

        }

        [When(@"I call get method to get user information using (.*)wl")]
        public void WhenICallGetMethodToGetUserInformationUsingWl(string userid)
        {
            RestAPIHelper.GetRequest(userid);
        }

        [Then(@"I will get user information")]
        public void ThenIWillGetUserInformation()
        {
            var response = RestAPIHelper.GetResponse();

        }


    }
}

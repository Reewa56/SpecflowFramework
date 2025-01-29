using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using RestSharp;
using TechTalk.SpecFlow;

namespace NorthStandardProject.StepDefinitions
{
    [Binding]
    public class APIValidationStep
    {
        private RestClient client;
        private RestRequest request;
        private RestResponse response;
        private string endpoint;

        [Given(@"I set the API url to ""(.*)""")]
        public void WhenIsettheAPIurlto(string APIurl)
        {
            client = new RestClient(APIurl);

        }

        [Given(@"I set the endpoint to ""(.*)""")]
        public void GivenIsettheendpointto(string endpointurl)
        {

            endpoint = endpointurl;
        }

        [When(@"I send a get request")]
        public void WhenIsendagetrequest()
        {
            request = new RestRequest(endpoint, Method.Get);
            response = client.Execute(request);
        }

        [Then(@"I validate status code")]
        public void ThenIValidateStatusCode200()
        {
            Assert.That(HttpStatusCode.OK, Is.EqualTo(response.StatusCode));
        }





    }
}

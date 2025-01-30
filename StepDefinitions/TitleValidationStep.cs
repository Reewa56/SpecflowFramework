using System.Configuration;
using Microsoft.Web.Administration;
using NorthStandardProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace NorthStandardProject.StepDefinitions
{
    [Binding]
    [TestFixture]
    
    public sealed class TitleValidationStep 
    {
      //  private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver? driver;
        private string? _url = null;

        TitleValidationTest titleValidationTestPage;
        
        public TitleValidationStep(IWebDriver driver)
        {
            this.driver = driver;
            titleValidationTestPage = new TitleValidationTest(driver);
        }



        [Given(@"I have the page url")]
        public void GivenIhavethepageurl()
        {
            if (_url == null)
            {
                _url =  ConfigurationManager.AppSettings["url"];
            }
        }

        [When(@"I navigate to the page")]
        public void WhenInavigatetothepage()
        {
            titleValidationTestPage.NavigateUrl(_url);
        }

        
        [Then(@"the page title should be ""(.*)""")]
        public void WhenThePageTitleShouldBe(string title)
        {
            Assert.That(title, Is.EqualTo(titleValidationTestPage.CheckTitle()));            
        }



    }

}
       

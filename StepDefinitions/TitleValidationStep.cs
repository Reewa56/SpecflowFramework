using System.ComponentModel.DataAnnotations;
using NorthStandardProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NorthStandardProject.StepDefinitions
{
    [Binding]
    [TestFixture]
    
    public sealed class TitleValidationStep 
    {
      //  private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver? driver;

        TitleValidationTest titleValidationTestPage;

        public TitleValidationStep(IWebDriver driver)
        {
            this.driver = driver;
            titleValidationTestPage = new TitleValidationTest(driver);
        }
       
        private String _url;

        [Given(@"I have the page url ""(.*)""")]
        public void GivenIhavethepageurl(string url)
        {
            _url = url;
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
       

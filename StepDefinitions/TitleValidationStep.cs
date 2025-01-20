using NorthStandardProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NorthStandardProject.StepDefinitions
{
    [Binding]
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

      /*  [Given(@"I have set the chrome driver")]
        public void GivenIhavesetthechromedriver()
        {
            //  titleValidationTestPage.setWebDriver();
            IWebDriver driver = new ChromeDriver();
            titleValidationTestPage = new TitleValidationTest(driver);
        }*/

        [When(@"I navigate to the page url ""(.*)""")]
        public void WhenInavigatetothepageurl(String url)
        {
            //titleValidationTestPage = new TitleValidationTest(driver);
            _url = url;
            titleValidationTestPage.NavigateUrl(_url);
        }

        
        [Then(@"the page title should be ""(.*)""")]
        public void WhenThePageTitleShouldBe(String title)
        {
            Assert.That(title, Is.EqualTo(titleValidationTestPage.CheckTitle()));
            
        }

       

    }

}
       

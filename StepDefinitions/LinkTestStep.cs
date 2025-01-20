using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthStandardProject.Pages;
using OpenQA.Selenium;

namespace NorthStandardProject.StepDefinitions
{
    [Binding]
    public class LinkTestStep
    {
        private IWebDriver driver;

        public LinkTestStep(IWebDriver driver)
        {
            this.driver = driver;
        }

        private LinkTestValidation validation;
       

        [When(@"Click on Services link")]
        public void WhenClickOnServicesLink()
        {
            validation = new LinkTestValidation(driver);
            validation.ClickLink();
        }
    }
}

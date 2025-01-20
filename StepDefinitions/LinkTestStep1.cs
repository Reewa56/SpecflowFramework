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
    public class LinkTestStep1
    {
        private IWebDriver driver;

        public LinkTestStep1(IWebDriver driver)
        {
            this.driver = driver; 
        }

        private LinkTestValidation1 validation1;
     

        [When(@"Click on Newsletter link")]
        public void WhenClickOnNewsletterLink()
        {
            validation1 = new LinkTestValidation1(driver);
            validation1.ClickLink1();
        }
    }
}

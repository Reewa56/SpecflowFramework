using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NorthStandardProject.Pages
{
    public class LinkTestValidation
    {
        private IWebDriver? driver;

        public LinkTestValidation(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickLink()
        {
            IWebElement _servicesLink = driver.FindElement(By.XPath("//*[@id='main-menu']/div/div[2]/div/nav/ul/li/a"));

            _servicesLink.Click();

        }
    }
}

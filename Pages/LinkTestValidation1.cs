using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NorthStandardProject.Pages
{
    public class LinkTestValidation1
    {
        private IWebDriver? driver;

        public LinkTestValidation1(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickLink1()
        {
            IWebElement _newsletterLink = driver.FindElement(By.XPath("//*[@id='main-menu']/div/div[2]/div/nav/ul/li/a[text()='Services']"));

            _newsletterLink.Click();

        }
    }
}

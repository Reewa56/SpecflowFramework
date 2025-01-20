using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;


namespace NorthStandardProject.Pages
{
    [Binding]
    public  class TitleValidationTest 
    {
        private IWebDriver? driver;

        public TitleValidationTest(IWebDriver? driver)
        {
            this.driver = driver;
        }

        public void NavigateUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string CheckTitle()
        {
            String pageTitle = driver.Title;
            Console.WriteLine(pageTitle);
            return driver.Title;
        }

       
    }
}

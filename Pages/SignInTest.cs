using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RestSharp;
using SeleniumExtras.WaitHelpers;

namespace NorthStandardProject.Pages
{
    public class SignInTest
    {
        private IWebDriver? driver;
        private RestClient client;
        public SignInTest(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickLink()
        {
            driver.Manage().Window.Maximize();
           // IWebElement _signInLink = driver.FindElement(By.XPath("//*[@data-test='nav-sign-in']"));
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            IWebElement _signInLink =  wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@data-test='nav-sign-in']")));

            _signInLink.Click();

        }

        public void EnterEmail()
        {
            driver.FindElement(By.Id("email")).SendKeys("customer@practicesoftwaretesting.com");
        }

        public void EnterPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("welcome01");
        }

        public void ClickLogin()
        {
            driver.FindElement(By.ClassName("btnSubmit")).Click();
        }

       
    }
}

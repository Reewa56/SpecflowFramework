using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NorthStandardProject
{
    [Binding]
    public class Hooks
    {
        private IObjectContainer container;
      //  private DriverHelper _driverhelper;
        
        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }
        

        [BeforeScenario]
        public void CreateBrowser()
        {
           IWebDriver driver  = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void DeleteBrowser()
        {
            var driver = container.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}

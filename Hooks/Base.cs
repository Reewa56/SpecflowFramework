using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
//[assembly: Parallelizable(ParallelScope.All)]
//[assembly: LevelOfParallelism(2)]

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
            IWebDriver driver = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void DeleteBrowser()
        {

            var driver = container.Resolve<IWebDriver>();
            container.Dispose();
            driver.Quit();
            driver.Dispose();
        }

        //private void DisposeSpecflowContext()
        //{
        //    try
        //    {
        //        container.Dispose();
        //    }
        //    catch { }
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthStandardProject.StepDefinitions;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.Browser;

namespace NorthStandardProject.Pages
{
    public class AllPages
    {

        private LinkTestValidation linkTestValidation;
        private LinkTestValidation1 linkTestValidation1;
        private TitleValidationTest titleValidationTest;
        public AllPages(IWebDriver driver) 
        {
            linkTestValidation = new LinkTestValidation(driver);
            this.linkTestValidation1 = new LinkTestValidation1(driver);
            this.titleValidationTest = new TitleValidationTest(driver);
        }

        public LinkTestValidation GetLinkTestValidation()
        {
            return this.linkTestValidation;
        }

        public LinkTestValidation1 GetLinkTestValidation1()
        {
            return this.linkTestValidation1;
        }

        public TitleValidationTest GetTitleValidationTest()
        {
            return this.titleValidationTest;
        }




    }
}

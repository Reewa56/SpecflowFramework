﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NorthStandardProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RestSharp;
using TechTalk.SpecFlow;



namespace NorthStandardProject.StepDefinitions
{
    [Binding]
    [TestFixture]
    
    public class SignInStep
    {
        private readonly IWebDriver driver;
       
        public SignInStep(IWebDriver driver)
        {
            this.driver = driver;
        }

        private SignInTest signInTest;
       

        [When(@"I click on sign in")]
        public void WhenIclickonsignin()
        {
            signInTest = new SignInTest(driver);
            signInTest.ClickLink();
        }


        [When(@"I entered email address")]
        public void WhenIenteredemailaddress()
        {
           signInTest.EnterEmail();
        }

        [When(@"I entered the password")]
        public void WhenIenteredthepassword()
        {
            signInTest.EnterPassword();
        }

        [When(@"I click the sign in button")]
        public void WhenIclickthesigninbutton()
        {
            signInTest.ClickLogin();
            Thread.Sleep(2000);
        }

        [Then(@"I validate that sign in is successfully done")]
        public void ThenIvalidatethatsigninissuccessfullydone()
        {
            Assert.That(signInTest.SignInValidation, Is.EqualTo("Jack Howe"));
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using DevtechInternalAT01.Init;
using DevtechInternalAT01.Pages;
using DevtechInternalAT01.Tests;

namespace DevtechInternalAT01.Tests
{
    [TestClass]
    public class VerifyHomePage : BaseClass
    {
        [TestInitialize]
        public void SetupTest()
        {
            base.Driver = new FirefoxDriver();
            //base.Driver = new ChromeDriver(@"C:\Program Files (x86)\Selenium\Libraries");
            base.Initialize = new Initialize();

            this.Initialize.GoToHomePage(this.Driver);

            _cloudIntegrationPage = new CloudIntegrationPage(base.Driver);
        }

        [TestMethod]
        public void VerifyHomePageText()
        {
            //_homePage.VerifyHomePageText("DevTech provides Cloud enablement solutions to ISVs, Cloud Service Providers, Fortune 500 and some of the world’s largest telecommunication companies.");
            //_homePage.VerifyHomePageText("Contact");

        }


        [TestCleanup]
        public void Finish()
        {
            this.Initialize.FinishTest(this.Driver);
        }
    }
}

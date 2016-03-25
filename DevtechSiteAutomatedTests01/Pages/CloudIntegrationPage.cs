using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevtechInternalAT01.Pages
{
    public class CloudIntegrationPage
    {
        private readonly IWebDriver driver;

        public CloudIntegrationPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        //Page Name
        [FindsBy(How = How.ClassName, Using = "banner-text-text")]
        public IWebElement CloudIntegrationHeadline { get; set; }

        public void ValidatePage(string pageName)
        {
            Assert.IsTrue(this.CloudIntegrationHeadline.Text.Contains(pageName), "Expected headline not found");
        }
    }
}

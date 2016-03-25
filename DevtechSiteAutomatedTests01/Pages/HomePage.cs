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
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"http://devtechgroup.com/";

        public HomePage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public void GoTo()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }

        public void MaxWin()
        {
            this.driver.Manage().Window.Maximize();
        }

        //Page Text
        [FindsBy(How = How.XPath, Using = "html/body/footer/div/section[4]/div/h1")]
        public IWebElement HomePageText { get; set; }

        public void VerifyHomePageText(string pageText)
        {
            Assert.IsTrue(this.HomePageText.Text.Contains(pageText), "Expected text not found");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using DevtechInternalAT01.Pages;
using DevtechInternalAT01.Init;

namespace DevtechInternalAT01.Init
{
    public class Initialize : BaseClass
    {
        public void GoToHomePage(IWebDriver driver)
        {
            HomePage _homePage = new HomePage(driver);

            _homePage.GoTo();
            _homePage.MaxWin();
        }

        public void FinishTest(IWebDriver driver)
        {
            HomePage _homePage = new HomePage(driver);

            driver.Quit();
        }
    }
}
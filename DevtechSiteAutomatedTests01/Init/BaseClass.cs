using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using DevtechInternalAT01.Pages;
using DevtechInternalAT01.Init;

namespace DevtechInternalAT01.Init
{
    public abstract class BaseClass
    {
        public IWebDriver Driver { get; set; }
        public Initialize Initialize { get; set; }

        public HomePage _homePage;
        public CloudIntegrationPage _cloudIntegrationPage;
    }
}

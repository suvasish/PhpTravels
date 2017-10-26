using System;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PhpTravels.TestCases
{
    [TestFixture]
    public class TestBase
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            if (GetBrowser().ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(GetUrl());
            driver.Manage().Window.Maximize();

            // Make sure the page loaded successfully.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until<IWebElement>(d => d.FindElement(By.ClassName("logo")));
        }

        private string GetUrl()
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings["Url"];
        }

        private string GetBrowser()
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings["Browser"];
        }
    }
}

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using PhpTravelsFramework.Helpers;

namespace PhpTravels.TestCases
{
    [TestFixture]
    public class TestBase
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            switch (Config.GetBrowser().ToLower())
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

        public void OpenUrl()
        {
            driver.Navigate().GoToUrl(Config.GetUrl());
            driver.Manage().Window.Maximize();

            // Make sure the page loaded successfully.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until<IWebElement>(d => d.FindElement(By.ClassName("logo")));
        }

    }
}

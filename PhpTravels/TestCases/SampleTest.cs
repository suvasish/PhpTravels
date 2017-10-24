using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PhpTravels
{
    public class SampleTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TC_open_travel_agency_site()
        {
            driver.Navigate().GoToUrl("http://www.phptravels.net/");
            driver.Manage().Window.Maximize();

            // Make sure the page loaded successfully.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until<IWebElement>(d => d.FindElement(By.ClassName("logo")));
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}

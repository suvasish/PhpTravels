using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PhpTravelsFramework
{
    public class HomePage
    {
        public static void GotoSite()
        {
            var _driver = Driver.Instance;
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.phptravels.net/");

            var containerXpath = ".//div[@class='container']";
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElements(By.XPath(containerXpath)));

        }
    }
}

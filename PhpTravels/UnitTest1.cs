using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace PhpTravels
{
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Finalize()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}

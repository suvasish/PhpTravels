using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace PhpTravelsFramework
{
    public  static class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            //Instance = new FirefoxDriver();
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Finalize()
        {
            Instance.Quit();
        }
    }
}
using PhpTravels;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace PhpTravelsFramework
{
    public  static class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string browser;

        public static void Initialize()
        {
            browser = Config.Browser;

            switch (browser)
            {
                case "Chrome":
                    Instance = new ChromeDriver();
                    Instance.Manage().Window.Maximize();
                    Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    break;
                case "Firefox":
                    Instance = new FirefoxDriver();
                    Instance.Manage().Window.Maximize();
                    Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    break;

                default:
                    break;

            }

        }

        public static void Finalize()
        {
            Instance.Quit();
        }
    }
}
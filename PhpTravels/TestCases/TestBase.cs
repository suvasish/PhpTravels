using NUnit.Framework;
using OpenQA.Selenium;
using PhpTravelsFramework;

namespace PhpTravels.TestCases
{
    public class TestBase
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [TearDown]
        public void Finish()
        {
            Driver.Finalize();
        }

        public void Open_php_travels_URL()
        {
            Driver.Instance.Navigate().GoToUrl(Config.URL);
        }

        public void Login_to_myAccounts()
        {
            Open_php_travels_URL();

            var defaultNavbar = MainPage.DefalutNavBar;
            defaultNavbar.Goto_login_page();

            var loginPage = MainPage.Loginpage;
            loginPage.Login(Config.LoginEmail, Config.Password);
        }
    }
}

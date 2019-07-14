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

        public void Login_to_myAccounts(string email, string passwd)
        {
            Open_php_travels_URL();

            var defaultNavbar = MainPage.DefalutNavBar;
            defaultNavbar.Goto_login_page();

            var loginPage = MainPage.Loginpage;
            loginPage.Login(email, passwd);
        }

        public void Verify_login_result(string expectedAlert)
        {
            var loginPage = MainPage.Loginpage;
            var loginAlert = loginPage.Get_login_alert();
            Assert.True(loginAlert == expectedAlert);
        }

        public void Choose_search_option(string option)
        {
            var searchpage = MainPage.SearchPage;
            searchpage.Select_search_option(option);
        }

    }
}

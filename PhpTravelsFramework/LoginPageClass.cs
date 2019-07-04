using OpenQA.Selenium;
using System;

namespace PhpTravelsFramework
{
    public class LoginPageClass : MainPage
    {
        private static IWebElement loginPage;

        public LoginPageClass(IWebElement _pageElem)
        {
            loginPage = _pageElem;
            Verify_login_page_loaded();
        }

        private void Verify_login_page_loaded()
        {
            var xPath = ".//button[contains(@class, 'btn btn-action btn-lg btn-block loginbtn') and contains(text(), 'Login')]";
            var loginButton = loginPage.FindElement(By.XPath(xPath));
            if (!loginButton.Enabled && loginButton.Displayed)
                throw new Exception("LoginPage not loaded !");
        }

        public void Login(string emailAddress, string passwd)
        {
            if (String.IsNullOrEmpty(emailAddress) && String.IsNullOrEmpty(passwd))
                throw new Exception("Please supply LoginEmail and Password !");

            var email = loginPage.FindElement(By.Name("username"));
            email.Clear();
            email.SendKeys(emailAddress);

            var _password = loginPage.FindElement(By.Name("password"));
            _password.Clear();
            _password.SendKeys(passwd);

            var loginBtn = loginPage.FindElement(By.TagName("button"));
            loginBtn.Click();
        }
    }
}

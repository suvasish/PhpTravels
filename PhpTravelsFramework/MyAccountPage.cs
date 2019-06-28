using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PhpTravelsFramework
{
    public class MyAccountPage
    {
        private static IWebDriver _driver = Driver.Instance;

        public static void Goto_login_page()
        {
            _driver.Navigate().GoToUrl("http://www.phptravels.net/");

            var topNavBar = _driver.FindElement(By.CssSelector("nav[class='navbar navbar-default']"));

            var containerDiv = topNavBar.FindElement(By.ClassName("container"));

            var navBarHeader = containerDiv.FindElement(By.ClassName("navbar-header"));

            var navBarCollapse = containerDiv.FindElement(By.Id("collapse"));

            var navBarLeftUL = navBarCollapse.FindElement(By.CssSelector("ul[class='nav navbar-nav']"));

            var navBarRightUL = navBarCollapse.FindElement(By.CssSelector("ul[class='nav navbar-nav navbar-right']"));

            var rUL = navBarRightUL.FindElement(By.CssSelector("ul[class='nav navbar-nav navbar-side navbar-right sidebar go-left']"));

            var myAccElem = rUL.FindElement(By.Id("li_myaccount"));

            myAccElem.Click();

            var myAccDropdownMenu = myAccElem.FindElement(By.TagName("ul"));
            var myAcclis = myAccDropdownMenu.FindElements(By.TagName("li"));

            foreach (var elem in myAcclis)
            {
                var liText = elem.FindElement(By.TagName("a")).Text;

                if (liText == "Login")
                {
                    elem.Click();
                    break;
                }
            }
        }

        public static void Login(string emailAddress, string passwd)
        {
            var defaultPanel = _driver.FindElement(By.CssSelector("div[class='panel panel-default']"));

            var email = defaultPanel.FindElement(By.Name("username"));
            email.Clear();
            email.SendKeys(emailAddress);

            var _password = defaultPanel.FindElement(By.Name("password"));
            _password.Clear();
            _password.SendKeys(passwd);

            var loginBtn = defaultPanel.FindElement(By.TagName("button"));
            loginBtn.Click();
        }
    }
}

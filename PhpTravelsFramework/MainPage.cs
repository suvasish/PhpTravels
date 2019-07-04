using OpenQA.Selenium;

namespace PhpTravelsFramework
{
    public class MainPage : PageBase
    {
        public MainPage()
        {
        }

        private static IWebElement TopToolBarDiv
        {
            get
            {
                var xPath = ".//div[@class='tbar-top hidden-sm hidden-xs']";
                var topToolBar = Driver.Instance.FindElement(By.XPath(xPath));
                return topToolBar;
            }
        }

        public static TopToolBarClass TopToolbar
        {
            get { return new TopToolBarClass(TopToolBarDiv); }
        }

        private static IWebElement DefaultNavbarId
        {
            get
            {
                var defaultNavigationBar = Driver.Instance.FindElement(By.CssSelector("nav[class='navbar navbar-default']"));
                return defaultNavigationBar;
            }
        }

        public static DefaultNavBarClass DefalutNavBar
        {
            get
            {
                return new DefaultNavBarClass(DefaultNavbarId);
            }
        }

        private static IWebElement LeftNavbar
        {
            get
            {
                var navBarLeftUL = Driver.Instance.FindElement(By.CssSelector("ul[class='nav navbar-nav']"));
                return navBarLeftUL;
            }
        }

        private static IWebElement RightNavbar
        {
            get
            {
                var navBarRightUL = Driver.Instance.FindElement(By.CssSelector("ul[class='nav navbar-nav navbar-right']"));
                return navBarRightUL;
            }
        }

        private static IWebElement LoginPageId
        {
            get
            {
                var xPath = ".//div[contains(@id, 'body-section')]/div";
                var loginPageDiv = Driver.Instance.FindElements(By.XPath(xPath));
                return loginPageDiv[0];
            }
        }

        public static LoginPageClass Loginpage
        {
            get
            {
                return new LoginPageClass(LoginPageId);
            }
        }
    }
}

public class TopToolBarClass
{
    private IWebElement _toolBar;

    public TopToolBarClass(IWebElement toolBarDiv)
    {
        _toolBar = toolBarDiv;
    }
}

public class DefaultNavBarClass
{
    private IWebElement navBar;

    public DefaultNavBarClass(IWebElement NavBarDiv)
    {
        navBar = NavBarDiv;
    }

    public void Goto_login_page()
    {
        navBar.FindElement(By.Id("li_myaccount")).Click();

        var href = "https://www.phptravels.net/login";
        var xPath = $".//a[contains(@href, '{href}') and contains(text(), 'Login')]";
        navBar.FindElement(By.XPath(xPath)).Click();
    }

}
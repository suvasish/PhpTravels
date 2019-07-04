using OpenQA.Selenium;

namespace PhpTravelsFramework
{
    public class MyAccountPage : PageBase
    {
        private static IWebElement myAccountPage;

        public MyAccountPage()
        {
            myAccountPage = pageBody;
        }

    }
}

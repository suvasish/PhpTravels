using NUnit.Framework;
using PhpTravels.TestCases;
using PhpTravelsFramework;
using System;

namespace PhpTravels
{
    public class LoginTest : TestBase
    {
        [Test]
        public void Login_to_phpTravels_site()
        {
            MyAccountPage.Goto_login_page();
            //MyAccountPage.Login("onlysarker@gmail.com", "abc123");
            //System.Threading.Thread.Sleep(3000);

        }
    }
}

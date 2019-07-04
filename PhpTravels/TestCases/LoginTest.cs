using NUnit.Framework;
using PhpTravels.TestCases;

namespace PhpTravels
{
    public class LoginTest : TestBase
    {
        [Test]
        public void Login_to_phpTravels_site()
        {
            Login_to_myAccounts();
        }
    }
}

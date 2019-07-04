using NUnit.Framework;
using PhpTravels.TestCases;
using PhpTravelsFramework;

namespace PhpTravels
{
    public class LoginTest : TestBase
    {
        [Test]
        public void Login_to_phpTravels_site()
        {
            Login_to_myAccounts(Config.LoginEmail, Config.Password);
        }

        [Test]
        public void Verify_login_error_message()
        {
            Login_to_myAccounts("abc@abc.com", "abcdotcom");
            Verify_login_result("Invalid Email or Password");
        }

    }
}

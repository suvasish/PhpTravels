using NUnit.Framework;
using PhpTravelsFramework;

namespace PhpTravels.TestCases
{
    public class TestBase
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
            HomePage.GotoSite();
        }

        [TearDown]
        public void Finish()
        {
            Driver.Finalize();
        }
    }
}

using NUnit.Framework;
using System;
using System.Configuration;

namespace PhpTravels.TestCases
{
    public class SampleTest: TestBase
    {
        [Test]
        public void TC_open_travel_agency_site()
        {
            OpenUrl();
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravels.TestCases
{
    class FlightSearchTest : TestBase
    {
        [Test]
        public void Search_for_flights()
        {
            Open_php_travels_URL();
            Choose_search_option("Flights");
        }
    }
}

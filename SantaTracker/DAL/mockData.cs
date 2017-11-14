using SantaTracker.Models;
using System;
using System.Collections.Generic;

namespace SantaTracker.DAL
{
    public class MockData
    {
        public static List<Santa> getMockSantas()
        {
            Santa santa1 = new Santa("Waylon", "Dalton", true, false, 12.50M);
            Santa santa2 = new Santa("Justin", "Henderson", true, true, 14.00M);
            Santa santa3 = new Santa("Eddie", "Randolph", false, false, 8.00M);
            Santa santa4 = new Santa("Jonathan", "Sheppard", false, true, 10.00M);
            Santa santa5 = new Santa("Grady", "Smithers", true, true, 14.00M);

            List<Santa> santas = new List<Santa>();
            santas.Add(santa1);
            santas.Add(santa2);
            santas.Add(santa3);
            santas.Add(santa4);
            santas.Add(santa5);

            return santas;
        }

        public static List<Location> getMockLocations()
        {
            Location location1 = new Location("Arrowhead Mall", "7700 W Arrowhead Towne Center", "Glendale", new DateTime(2017, 11, 14), new DateTime(2017, 12, 24), true);
            Location location2 = new Location("Best Buy", "13711 W Bell Rd", "Surprise", new DateTime(2017, 11, 24), new DateTime(2017, 12, 23), false);
            Location location3 = new Location("Paradise Valley Mall", "4568 E Cactus Rd", "Phoenix", new DateTime(2017, 11, 15), new DateTime(2017, 12, 24), true);

            List<Location> locations = new List<Location>();
            locations.Add(location1);
            locations.Add(location2);
            locations.Add(location3);

            return locations;
        }

    }
}

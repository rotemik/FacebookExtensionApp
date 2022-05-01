using System.Collections.Generic;

namespace FacebookExtensionApp.TravelDiary.Model
{
    public class City
    {
        public string Name { get; set; }

        public Dictionary<string, Location> Locations { get; private set; } = new Dictionary<string, Location>() { };
    }
}

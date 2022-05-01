using System.Collections.Generic;

namespace FacebookExtensionApp.TravelDiary.Model
{
    public class Country
    {
        public string Name { get; set; }

        public Dictionary<string, City> Cities { get; private set; } = new Dictionary<string, City>();
    }
}

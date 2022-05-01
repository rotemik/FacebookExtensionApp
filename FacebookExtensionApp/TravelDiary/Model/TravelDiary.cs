using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookExtensionApp.TravelDiary.Model
{
    public class TravelDiary
    {
        public Dictionary<string, Country> Travels { get; private set; } = new Dictionary<string, Country>();

        public void AddingTravelsAccordingToKeysAndCheckIn(string i_CountryKey, string i_CityKey, string i_LocationKey, Checkin i_Checkin)
        {
            // Check if not visit this country
            if (!Travels.ContainsKey(i_CountryKey))
            {
                addNewTravel(i_Checkin);
            }
            else
            {
                // Check if not visit this city
                if (!Travels[i_CountryKey].Cities.ContainsKey(i_CityKey))
                {
                    addNewTravelCity(i_Checkin);
                }
                else
                {
                    // Check if not visit this location
                    if (!Travels[i_CountryKey].Cities[i_CityKey].Locations.ContainsKey(i_LocationKey))
                    {
                        addNewTravelLocation(i_Checkin);
                    }
                }
            }
        }

        //// ---------------Private Functions for adding travels ------------------

        // Note: just if the country does't exist
        private void addNewTravelCountry(Checkin i_Checkin)
        {
            string countryKey = i_Checkin.Place.Location.Country;

            Country country = new Country() { Name = countryKey };

            Travels.Add(countryKey, country);
        }

        // Note: The Country must be exist!
        private void addNewTravelCity(Checkin i_Checkin)
        {
            string countryKey = i_Checkin.Place.Location.Country;

            City city = new City() { Name = i_Checkin.Place.Location.City };

            Travels[countryKey].Cities.Add(city.Name, city);
        }

        // Note: The Country and City must be exist!
        private void addNewTravelLocation(Checkin i_Checkin)
        {
            string countryKey = i_Checkin.Place.Location.Country;
            string cityKey = i_Checkin.Place.Location.City;

            FacebookExtensionApp.TravelDiary.Model.Location location = new FacebookExtensionApp.TravelDiary.Model.Location()
            {
                Name = i_Checkin.Place.Name,
                Street = i_Checkin.Place.Location.Street,
                Zip = i_Checkin.Place.Location.Zip
            };

            Travels[countryKey].Cities[cityKey].Locations.Add(location.Zip, location);
        }

        // Note just if the Country and City and location exist
        private void addNewTravel(Checkin i_Checkin)
        {
            addNewTravelCountry(i_Checkin);
            addNewTravelCity(i_Checkin);
            addNewTravelLocation(i_Checkin);
        }
    }
}

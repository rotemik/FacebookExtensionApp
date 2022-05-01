using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookExtensionApp.TravelDiary.Model;
using FacebookExtensionApp.CommonUtils;

namespace FacebookExtensionApp.TravelDiary.ViewModel
{
    public class TravelDiaryLogic
    {
        private User m_LogedInUser;

        public int NumberOfTravels { get; private set; }

        public FacebookExtensionApp.TravelDiary.Model.TravelDiary TravelDiary { get; private set; } = new FacebookExtensionApp.TravelDiary.Model.TravelDiary();

        public TravelDiaryLogic()
        {
            m_LogedInUser = FacebookUser.Instance.LogInUser;
            NumberOfTravels = m_LogedInUser.Checkins.Count;
        }

        //// ---------------------------Public Functions-------------------------------

        public void FetchTravels()
        {
            if (m_LogedInUser.Checkins != null)
            {
                // Fetch data and build the user's travel data
                foreach (Checkin checkin in m_LogedInUser.Checkins)
                {
                    string countryKey = checkin.Place.Location.Country;
                    string cityKey = checkin.Place.Location.City;
                    string locationKey = checkin.Place.Location.Zip;

                    TravelDiary.AddingTravelsAccordingToKeysAndCheckIn(countryKey, cityKey, locationKey, checkin);
                }
            }
        }
    }
}

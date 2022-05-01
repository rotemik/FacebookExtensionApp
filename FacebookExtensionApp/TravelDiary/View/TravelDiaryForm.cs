using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookExtensionApp.TravelDiary.Model;
using FacebookExtensionApp.TravelDiary.ViewModel;
using FacebookWrapper;

namespace FacebookExtensionApp.TravelDiary.View
{
    public partial class TravelDiaryForm : Form
    {
        private const string k_CountriesLabel = "Countries:";

        private const string k_CitiesLabel = "Cities:";

        private const string k_LocationsLabel = "Locations:";

        private TravelDiaryLogic m_TravelDiary;

        public TravelDiaryForm()
        {
            InitializeComponent();
            m_TravelDiary = new TravelDiaryLogic();
        }

        public void PoupulateUserTravelsFromFacebook()  
        {    
            new Thread(m_TravelDiary.FetchTravels).Start();
            showCountriesList();
        }

        //// --------------Showing Travel Component at list Functions----------------------

        private void showCountriesList()                   
        {
            labelTravel.Text = k_CountriesLabel;

            this.listBoxTravels.Items.Clear();
            this.listBoxTravels.DisplayMember = "Name"; 

            // Check if the user does checkins
            if (m_TravelDiary.NumberOfTravels == 0)
            {
               this.listBoxTravels.Items.Add("You have not tagged places you've been to...");
            }
            else
            {
                // Build The list of Cities
                foreach (KeyValuePair<string, Country> travel in m_TravelDiary.TravelDiary.Travels)
                {
                    this.listBoxTravels.Items.Add(travel.Value);
                }
            }
        }

        private void showCitiesListOfSelectedCountry()
        {
            try
            {
                labelTravel.Text = k_CitiesLabel;

                Country selectedCountry = listBoxTravels.SelectedItem as Country;

                this.listBoxTravels.Items.Clear();
                this.listBoxTravels.DisplayMember = "Name";

                // Build The list of cities
                foreach (KeyValuePair<string, City> city in selectedCountry.Cities)
                {
                    this.listBoxTravels.Items.Add(city.Value);
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        private void showLocationsListOfSelectedCity()
        {
            try
            {
                labelTravel.Text = k_LocationsLabel;

                // The Information Display= of location
                string locationData = "{0,-20}{1,-20}{2,-20}";   
                string locationDataTilte = string.Format(locationData, "Name", "Street", "Zip");

                City selectedCity = listBoxTravels.SelectedItem as City;

                this.listBoxTravels.Items.Clear();
                this.listBoxTravels.Items.Add(locationDataTilte);

                // In order to display toString of Location
                this.listBoxTravels.DisplayMember = string.Empty;  

                // Build The list of locations
                foreach (FacebookExtensionApp.TravelDiary.Model.Location location in selectedCity.Locations.Values)
                {
                    this.listBoxTravels.Items.Add(location);
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        //// --------------------------Event Handler Functions-----------------------------

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxTravels.SelectedItem is Country)
            {
                showCitiesListOfSelectedCountry();
            }
            else if (listBoxTravels.SelectedItem is City)
            {
                showLocationsListOfSelectedCity();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            try
            {
                PoupulateUserTravelsFromFacebook();
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format(exception.Message));
            }
        }
    }
}

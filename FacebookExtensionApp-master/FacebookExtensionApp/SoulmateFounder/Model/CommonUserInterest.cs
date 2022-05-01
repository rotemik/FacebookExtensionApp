namespace FacebookExtensionApp.SoulmateFounder.Model
{
    public class CommonUserInterest
    {
        public int NumberOfLikedPages { get; set; }

        public int NumberOfEvents { get; set; }

        public int NumberOfGroups { get; set; }

        public int NumberOfFriends { get; set; }

        public bool IsTheSameHoroscope { get; set; }

        public bool IsTheSameChinesezodiac { get; set; }

        public bool IsTheSameHometown { get; set; }

        public bool IsTheSameEducation { get; set; }

        public bool IsTheSameJob { get; set; }

        public bool IsTheSameGender { get; set; }

        public int NumberOfCommonInterest { get; set; }

        public CommonUserInterest()
        {
            ZeroData();
        }

        public void Reset()
        {
            ZeroData();
        }

        private void ZeroData()
        {
            NumberOfCommonInterest = 0;
            NumberOfLikedPages = 0;
            NumberOfEvents = 0;
            NumberOfGroups = 0;
            NumberOfFriends = 0;
            IsTheSameHoroscope = false;
            IsTheSameChinesezodiac = false;
            IsTheSameHometown = false;
            IsTheSameEducation = false;
            IsTheSameJob = false;
            IsTheSameGender = false;
        }
    }
}

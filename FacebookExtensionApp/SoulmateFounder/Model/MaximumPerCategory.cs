namespace FacebookExtensionApp.SoulmateFounder.Model
{
    public class MaximumPerCategory
    {
        public int NumberOfLikedPages { get; set; }

        public int NumberOfEvents { get; set; }

        public int NumberOfGroups { get; set; }

        public int NumberOfFriends { get; set; }

        public MaximumPerCategory()
        {
            ZeroData();
        }

        public void ZeroData()
        {
            NumberOfLikedPages = 0;
            NumberOfEvents = 0;
            NumberOfGroups = 0;
            NumberOfFriends = 0;
        }
    }
}

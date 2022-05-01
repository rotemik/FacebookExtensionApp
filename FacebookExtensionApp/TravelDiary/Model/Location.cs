namespace FacebookExtensionApp.TravelDiary.Model
{
    public class Location
    {
        public string Name { get; set; }

        public string Street { get; set; }

        public string Zip { get; set; }

        public override string ToString()
        {
            string locationFormat = "{0,-20}{1,-20}{2,-20}";
            return string.Format(locationFormat, Name, Street, Zip);
        }
    }
}

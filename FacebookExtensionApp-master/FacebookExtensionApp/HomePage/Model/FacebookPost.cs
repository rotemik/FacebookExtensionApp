namespace FacebookExtensionApp.HomePage.Model
{
    public abstract class FacebookPost
    {
        public string Description { get; set; }

        public abstract void Post();
    }
}

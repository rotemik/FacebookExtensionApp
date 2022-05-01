namespace FacebookExtensionApp.HomePage.Model
{
    public static class PostCreator
    {
        public static FacebookPost Create(string i_Description, string i_Path)
        {
            FacebookPost postToCreate = null;

            if (string.IsNullOrEmpty(i_Path))
            {
                postToCreate = new TextPost(i_Description);
            }
            else
            {
                postToCreate = new PhotoPost(i_Description, i_Path);
            }

            return postToCreate;
        }
    }
}

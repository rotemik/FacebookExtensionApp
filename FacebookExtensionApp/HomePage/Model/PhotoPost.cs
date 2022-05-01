using FacebookExtensionApp.Utility;
using System;

namespace FacebookExtensionApp.HomePage.Model
{
    public class PhotoPost : FacebookPost
    {
        public string PhotoPath { get; set; }

        public PhotoPost(string i_Description, string i_PhotoPath)
        {
            Description = i_Description;
            PhotoPath = i_PhotoPath;
        }

        public override void Post()
        {
            try
            {
                FacebookUser.Instance.LogInUser.PostPhoto(PhotoPath, Description);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

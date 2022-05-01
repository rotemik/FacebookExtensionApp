using FacebookExtensionApp.Utility;
using System;

namespace FacebookExtensionApp.HomePage.Model
{
    public class TextPost : FacebookPost
    {
        public TextPost(string i_Description)
        {
            Description = i_Description;
        }

        public override void Post()
        {
            // If The Post is not empty post it
            if (!string.IsNullOrEmpty(Description))
            {
                try
                {
                    FacebookUser.Instance.LogInUser.PostStatus(Description);
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }
    }
}

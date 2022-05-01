using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookExtensionApp.SoulmateFounder.Model
{
    public class SoulmateFriend
    {
        public User FriendOnFacebook { get; set; }

        public CommonUserInterest CommonInterest { get; set; }

        public List<string> MostCommonIntrest { get; set; }

        public void ResetSoulmateFriend()
        {
            FriendOnFacebook = null;
            CommonInterest = new CommonUserInterest();
            MostCommonIntrest = new List<string>();
            CommonInterest.Reset();
            MostCommonIntrest.Clear();
        }
    }
}

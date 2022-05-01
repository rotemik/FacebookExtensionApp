using FacebookExtensionApp.SoulmateFounder.Model;
using System.Collections.Generic;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public class SoulmateFriendBuilder : ISoulmateBuilder
    {
        private SoulmateFriend m_SoulmateFriend = new SoulmateFriend();

        //--------------------Create soulmate friend's memeber functions--------------------------------------------------
        public void SetCommonIntrest()
        {
            m_SoulmateFriend.CommonInterest = new CommonUserInterest();
        }

        public void SetMostCommonIntrest()
        {
            m_SoulmateFriend.MostCommonIntrest = new List<string>();
        }

        public void SetFacebookFriendUser(User i_FriendUser)
        {
            m_SoulmateFriend.FriendOnFacebook = i_FriendUser;
        }

        //--------------------return the soulmate friend--------------------------------------------------
        public SoulmateFriend GetSoulmateFriend()
        {
            return m_SoulmateFriend;
        }
    }
}

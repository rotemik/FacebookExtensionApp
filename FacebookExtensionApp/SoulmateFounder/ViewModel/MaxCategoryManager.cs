using FacebookExtensionApp.SoulmateFounder.Model;
using System;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public class MaxCategoryManager : ICountCategoryStrategy
    {
        public void UpdateAmountPerCategoryUserComparison(SoulmateFriend i_Friend, MaximumPerCategory m_MaxPerCategoryUser)
        {
            m_MaxPerCategoryUser.NumberOfLikedPages = Math.Max(
                m_MaxPerCategoryUser.NumberOfLikedPages,
                i_Friend.CommonInterest.NumberOfLikedPages);

            m_MaxPerCategoryUser.NumberOfEvents = Math.Max(
                m_MaxPerCategoryUser.NumberOfEvents,
                i_Friend.CommonInterest.NumberOfEvents);

            m_MaxPerCategoryUser.NumberOfGroups = Math.Max(
                m_MaxPerCategoryUser.NumberOfGroups,
               i_Friend.CommonInterest.NumberOfGroups);

            m_MaxPerCategoryUser.NumberOfFriends = Math.Max(
                m_MaxPerCategoryUser.NumberOfFriends,
              i_Friend.CommonInterest.NumberOfFriends);
        }

        public bool CompareCommonInterest(SoulmateFriend i_NewFriend, SoulmateFriend i_CurrentFriend)
        {
            bool isBigger = false;

            if (i_NewFriend.CommonInterest.NumberOfCommonInterest > i_CurrentFriend.CommonInterest.NumberOfCommonInterest)
            {
                isBigger = true;
            }

            return isBigger;
        }
    }
}

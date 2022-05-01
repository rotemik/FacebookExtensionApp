using System.Collections.Generic;
using System.Linq;
using FacebookExtensionApp.CommonUtils;
using FacebookExtensionApp.SoulmateFounder.Model;
using FacebookWrapper.ObjectModel;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public class SoulmateFounderLogic
    {
        private User m_LogedInUser;

        private MaximumPerCategory m_MaxPerCategoryUser;

        public List<string> ChoosenCommonIntrest { get; set; }

        public SoulmateFriend SoulMateFriend { get; private set; }

        public ICountCategoryStrategy CountMaxCategory { get; set; }

        public SoulmateFounderLogic(ICountCategoryStrategy i_CountMaxCategory)
        {
            m_LogedInUser = FacebookUser.Instance.LogInUser;
            m_MaxPerCategoryUser = new MaximumPerCategory();
            ChoosenCommonIntrest = new List<string>();
            SoulMateFriend = new SoulmateFriend();
            CountMaxCategory = i_CountMaxCategory;
        }

        public void FindingTheSoultmateFriendProcess()
        {
            if (ChoosenCommonIntrest != null)
            {
                findSoultmateAccordingToChoosenCommonInterest();
            }
            else
            {
                SoulMateFriend = null;
            }
        }

        private void findSoultmateAccordingToChoosenCommonInterest()
        {
            // create list of friends 
            foreach (User friend in m_LogedInUser.Friends)
            {
                SoulmateFriend newFriend = createPotentioalSoulmateFriend();
                newFriend.CommonInterest.NumberOfCommonInterest = 0;
                newFriend.FriendOnFacebook = friend;

                updateFriendCommonIntrestNumberByChosenCategory(newFriend);
                updateCurrentSoulmatFriend(newFriend);
                CountMaxCategory.UpdateAmountPerCategoryUserComparison(newFriend, m_MaxPerCategoryUser);
            }

            if (m_LogedInUser.Friends.Count == 0)
            {
                SoulMateFriend = null;
            }

            // verify if some of the friend is the soulmate
            if (SoulMateFriend.FriendOnFacebook != null)
            {
                updateTheMostCommonCategoriesList();
            }
        }

        private SoulmateFriend createPotentioalSoulmateFriend()
        {
            SoulMateCreator soulmateCreator = new SoulMateCreator(new SoulmateFriendBuilder());
            soulmateCreator.CreateSoulmateFriend();
            return soulmateCreator.GetSoulmateFriend();
        }

        private void updateFriendCommonIntrestNumberByChosenCategory(SoulmateFriend i_Friend)
        {
            updateFriendCommonCountableIntrestNumberByChosenCategory(i_Friend);
            updateFriendCommonBoolIntrestNumberByChosenCategory(i_Friend);
        }

        private void updateFriendCommonBoolIntrestNumberByChosenCategory(SoulmateFriend i_Friend)
        {
            bool isInTheSameChinesezodiac;
            bool isTheSameHoroscope;
            string friendBirthdayString = i_Friend.FriendOnFacebook.Birthday;
            string[] birthdayArry = friendBirthdayString.Split('/');
            string userBirthdayString = m_LogedInUser.Birthday;
            string[] userBirthdayArry = userBirthdayString.Split('/');
            bool isSameGender = i_Friend.FriendOnFacebook.Gender == m_LogedInUser.Gender && (m_LogedInUser.Gender != null);
            bool isInTheSameJob = i_Friend.FriendOnFacebook.WorkExperiences == m_LogedInUser.WorkExperiences && (m_LogedInUser.WorkExperiences != null);
            bool isWithSameEducation = i_Friend.FriendOnFacebook.Educations == m_LogedInUser.Educations && (m_LogedInUser.Educations != null);
            bool isInSameHomeTown = i_Friend.FriendOnFacebook.Hometown == m_LogedInUser.Hometown && (m_LogedInUser.Hometown != null);
            if (userBirthdayArry.Length == 2 && birthdayArry.Length == 2)
            {
                isInTheSameChinesezodiac = userBirthdayArry[1] == birthdayArry[1];
            }
            else
            {
                isInTheSameChinesezodiac = false;
            }

            if (userBirthdayArry.Length == 3 && birthdayArry.Length == 3)
            {
                isTheSameHoroscope = userBirthdayArry[2] == birthdayArry[2];
            }
            else
            {
                isTheSameHoroscope = false;
            }

            i_Friend.CommonInterest.IsTheSameHoroscope = commonInfoSelected("Horoscope", isTheSameHoroscope, i_Friend);
            i_Friend.CommonInterest.IsTheSameChinesezodiac = commonInfoSelected("Chinese zodiac", isInTheSameChinesezodiac, i_Friend);
            i_Friend.CommonInterest.IsTheSameHometown = commonInfoSelected("Hometown", isInSameHomeTown, i_Friend);
            i_Friend.CommonInterest.IsTheSameEducation = commonInfoSelected("Education", isWithSameEducation, i_Friend);
            i_Friend.CommonInterest.IsTheSameJob = commonInfoSelected("Job", isInTheSameJob, i_Friend);
            i_Friend.CommonInterest.IsTheSameGender = commonInfoSelected("Gender", isSameGender, i_Friend);
        }

        private void updateFriendCommonCountableIntrestNumberByChosenCategory(SoulmateFriend i_Friend)
        {
            if (ChoosenCommonIntrest.Contains("Liked Pages"))
            {
                foreach (Page userPage in m_LogedInUser.LikedPages)
                {
                    if (i_Friend.FriendOnFacebook.LikedPages.Contains(userPage))
                    {
                        i_Friend.CommonInterest.NumberOfLikedPages++;
                    }
                }

                i_Friend.CommonInterest.NumberOfCommonInterest += i_Friend.CommonInterest.NumberOfLikedPages;
            }

            if (ChoosenCommonIntrest.Contains("Events"))
            {
                foreach (Event userEvent in m_LogedInUser.Events)
                {
                    if (i_Friend.FriendOnFacebook.Events.Contains(userEvent))
                    {
                        i_Friend.CommonInterest.NumberOfEvents++;
                    }
                }

                i_Friend.CommonInterest.NumberOfCommonInterest += i_Friend.CommonInterest.NumberOfEvents;
            }

            if (ChoosenCommonIntrest.Contains("Groups"))
            {
                foreach (Group userGroup in m_LogedInUser.Groups)
                {
                    if (i_Friend.FriendOnFacebook.Groups.Contains(userGroup))
                    {
                        i_Friend.CommonInterest.NumberOfGroups++;
                    }
                }

                i_Friend.CommonInterest.NumberOfCommonInterest += i_Friend.CommonInterest.NumberOfGroups;
            }

            if (ChoosenCommonIntrest.Contains("Friends"))
            {
                foreach (User friendOfUser in m_LogedInUser.Friends)
                {
                    foreach (User friendOfFriend in i_Friend.FriendOnFacebook.Friends)
                    {
                        if (friendOfFriend.Name == friendOfUser.Name)
                        {
                            i_Friend.CommonInterest.NumberOfFriends++;
                        }
                    }
                }

                i_Friend.CommonInterest.NumberOfCommonInterest += i_Friend.CommonInterest.NumberOfFriends;
            }
        }

        private bool commonInfoSelected(string i_CommonIntrest, bool i_IntrestToCheck, SoulmateFriend i_Friend)
        {
            bool commonInterest = false;

            if (ChoosenCommonIntrest.Contains(i_CommonIntrest))
            {
                if (i_IntrestToCheck)
                {
                    commonInterest = true;
                    i_Friend.CommonInterest.NumberOfCommonInterest++;
                }
            }

            return commonInterest;
        }

        private void updateCurrentSoulmatFriend(SoulmateFriend i_Friend)
        {
            if (CountMaxCategory.CompareCommonInterest(i_Friend, SoulMateFriend))
            {
                SoulMateFriend = i_Friend;
            }
        }

        private void updateTheMostCommonCategoriesList()
        {
            bool isNumberOfFriendsIsMaxInHisCategory = SoulMateFriend.CommonInterest.NumberOfFriends == m_MaxPerCategoryUser.NumberOfFriends;
            bool isNumberOfGroupsIsMaxInHisCategory = SoulMateFriend.CommonInterest.NumberOfGroups == m_MaxPerCategoryUser.NumberOfGroups;
            bool isNumberOfEventsIsMaxInHisCategory = SoulMateFriend.CommonInterest.NumberOfEvents == m_MaxPerCategoryUser.NumberOfEvents;
            bool isNumberOfLikedPagesIsMaxInHisCategory = SoulMateFriend.CommonInterest.NumberOfLikedPages == m_MaxPerCategoryUser.NumberOfLikedPages;

            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Liked Pages", isNumberOfLikedPagesIsMaxInHisCategory);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Events", isNumberOfEventsIsMaxInHisCategory);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Groups", isNumberOfGroupsIsMaxInHisCategory);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Friends", isNumberOfFriendsIsMaxInHisCategory);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Horoscope", SoulMateFriend.CommonInterest.IsTheSameHoroscope);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Chinese zodiac", SoulMateFriend.CommonInterest.IsTheSameChinesezodiac);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Hometown", SoulMateFriend.CommonInterest.IsTheSameHometown);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Education", SoulMateFriend.CommonInterest.IsTheSameEducation);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Job", SoulMateFriend.CommonInterest.IsTheSameJob);
            addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt("Gender", SoulMateFriend.CommonInterest.IsTheSameGender);
        }

        private void addToSoulmateMostCommonIntrestIfChoosenCommonInterstContainIt(string i_CommonIntrest, bool i_IntrestToCheck)
        {
            if (ChoosenCommonIntrest.Contains(i_CommonIntrest))
            {
                if (i_IntrestToCheck)
                {
                    SoulMateFriend.MostCommonIntrest.Add(i_CommonIntrest);
                }
            }
        }

        public void InitilaiteSoulMateFriend()
        {
            SoulMateFriend.ResetSoulmateFriend();
            ChoosenCommonIntrest.Clear();
            m_MaxPerCategoryUser.ZeroData();
        }
    }
}

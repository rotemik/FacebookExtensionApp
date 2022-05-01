using FacebookExtensionApp.SoulmateFounder.Model;
using FacebookWrapper.ObjectModel;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public interface ISoulmateBuilder
    {
        void SetCommonIntrest();

        void SetMostCommonIntrest();

        void SetFacebookFriendUser(User i_FriendUser);

        SoulmateFriend GetSoulmateFriend();
    }
}

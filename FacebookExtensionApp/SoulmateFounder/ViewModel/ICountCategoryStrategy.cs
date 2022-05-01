using FacebookExtensionApp.SoulmateFounder.Model;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public interface ICountCategoryStrategy
    {
        void UpdateAmountPerCategoryUserComparison(SoulmateFriend i_Friend, MaximumPerCategory m_MaxPerCategoryUser);

        bool CompareCommonInterest(SoulmateFriend i_NewFriend, SoulmateFriend i_CurrentFriend);
    }
}

using FacebookExtensionApp.SoulmateFounder.Model;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public class SoulMateCreator
    {
        private readonly ISoulmateBuilder m_Builder;

        public SoulMateCreator(ISoulmateBuilder i_Builder)
        {
            m_Builder = i_Builder;
        }

        public void CreateSoulmateFriend()
        {
            m_Builder.SetCommonIntrest();
            m_Builder.SetMostCommonIntrest();
            m_Builder.SetFacebookFriendUser(null);
        }

        public SoulmateFriend GetSoulmateFriend()
        {
            return m_Builder.GetSoulmateFriend();
        }
    }
}

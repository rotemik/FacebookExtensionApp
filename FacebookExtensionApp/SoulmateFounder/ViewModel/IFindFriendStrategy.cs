using FacebookExtensionApp.SoulmateFounder.Model;
using System.Collections.Generic;

namespace FacebookExtensionApp.SoulmateFounder.ViewModel
{
    public interface IFindFriendStrategy
    {
        SoulmateFriend FindingTheSoultmateFriendProcess(List<string> i_chosenIntrest);
        void InitilaiteSoulMateFriend();
    }
}

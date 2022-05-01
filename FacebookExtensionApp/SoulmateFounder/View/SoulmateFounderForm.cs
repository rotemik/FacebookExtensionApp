using System;
using System.Windows.Forms;
using FacebookExtensionApp.SoulmateFounder.Model;
using FacebookExtensionApp.SoulmateFounder.ViewModel;
using FacebookWrapper.ObjectModel;


namespace FacebookExtensionApp.SoulmateFounder.View
{
    public partial class SoulmateFounderForm : Form
    {
        private readonly string[] r_listOfParameters =
        {
            "Liked Pages",
            "Events",
            "Groups",
            "Friends",
            "Horoscope",
            "Chinese zodiac",
            "Hometown",
            "Education",
            "Job",
            "Gender"
        };

        private SoulmateFounderLogic m_SoulmateFounderLogic;

        private SoulMateCreator m_SoulmateCreator;

        public SoulmateFriend m_TheSoulMateFriend;

        private IPictureDecorated m_PictureDEcorator;

        public SoulmateFounderForm()
        {
            InitializeComponent();
            m_SoulmateFounderLogic = new SoulmateFounderLogic(new MaxCategoryManager());
            m_PictureDEcorator = new FlickeringPicture(new RoundEdgesPicture(new PictureCoreDecorated()), pictureSoulmateFriend);
        }

        //// --------------------------Event Handler Functions-----------------------------

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            int numOfItems = checkedListCommonInterests.Items.Count;

            for (int i = 0; i < numOfItems; i++)
            {
                checkedListCommonInterests.SetItemChecked(i, true);
            }
        }

        private void buttonGetStarted_Click(object sender, EventArgs e)
        {
            try
            {
                resetApp();
                labelLoading.Visible = true;          
                m_TheSoulMateFriend = soulmateFriendSearch();
                showSoulmateOnForm(m_SoulmateFounderLogic.SoulMateFriend);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
                labelLoading.Visible = false;
            }
        }

        private SoulmateFriend soulmateFriendSearch()
        {
            SoulmateFriend soulmateFriend;
            m_SoulmateCreator = new SoulMateCreator(new SoulmateFriendBuilder());
            m_SoulmateCreator.CreateSoulmateFriend();
            soulmateFriend = m_SoulmateCreator.GetSoulmateFriend();

            InitializeChosenCommonIntrest();
            m_SoulmateFounderLogic.FindingTheSoultmateFriendProcess();
            soulmateFriend = m_SoulmateFounderLogic.SoulMateFriend;

            return soulmateFriend;
        }

       //// --------------------------Swops information functions- between common interest to ListBox-----------------------------

        private void InitializeChosenCommonIntrest()
        {
            foreach (string checkBox in checkedListCommonInterests.CheckedItems)
            {
                m_SoulmateFounderLogic.ChoosenCommonIntrest.Add(checkBox);
            }
        }

        private void initializeCommonFinal()
        {
            foreach(string commonIntrest in m_SoulmateFounderLogic.SoulMateFriend.MostCommonIntrest)
            {
                this.listBoxCommonFinal.Items.Add(commonIntrest);
            }
        }

        //// -------------------------Form view controller functions-----------------------------------
        
        private void resetApp()
        {
            labelFriendName.Visible = false;
            listBoxCommonFinal.Visible = false;
            labelMetchCategories.Visible = false;
            pictureSoulmateFriend.Visible = false;
            labelLoading.Visible = false;
            m_SoulmateFounderLogic.InitilaiteSoulMateFriend();
            listBoxCommonFinal.Items.Clear();
            pictureSoulmateFriend.ImageLocation = @"...\...\...\Images\UnknownUser2.jpeg";
            labelFriendName.Text = "Friend Name"; // The defult user name
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            resetApp();
            checkedListCommonInterests.Items.AddRange(r_listOfParameters);
        }

        private void showSoulmateOnForm(SoulmateFriend i_SoulMateFriend)
        {
            if (m_SoulmateFounderLogic.SoulMateFriend.FriendOnFacebook != null)
            {
                labelFriendName.Text = m_SoulmateFounderLogic.SoulMateFriend.FriendOnFacebook.Name;
                labelFriendName.Visible = true;
                labelMetchCategories.Visible = true;
                m_PictureDEcorator.ShowPicture(pictureSoulmateFriend, m_SoulmateFounderLogic.SoulMateFriend.FriendOnFacebook.PictureLargeURL);
                labelLoading.Visible = false;
                pictureSoulmateFriend.Visible = true;
                initializeCommonFinal();
                listBoxCommonFinal.Visible = true;
            }
            else
            {
                resetApp();
                labelLoading.Visible = true;
                labelLoading.Text = "Sorry \n we can't find your soulmate :(";
            }
        }
    }
}

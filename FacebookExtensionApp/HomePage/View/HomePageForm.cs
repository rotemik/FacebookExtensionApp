using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookExtensionApp.HomePage.Model;
using FacebookExtensionApp.CommonUtils;
using FacebookWrapper.ObjectModel;

namespace FacebookExtensionApp.HomePage.View
{
    public partial class HomePageForm : Form
    {
        private const string k_DefultTextForPost = "What\'s on your mind?";

        private const string k_UserHaveNotInsertText = "You have not inserted text into your post";

        private User m_LoggedInUser;

        private string m_PicturePath;

        public HomePageForm()
        {
            InitializeComponent();
            m_LoggedInUser = FacebookUser.Instance.LogInUser;
        }

        //// -------------------------Public Functions------------------------------

        public void PoupulateUserDataFromFacebook()         
        {
            new Thread(fetchFriends).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchLikedPages).Start();
            new Thread(fetchIntro).Start();
            new Thread(fetchBirthDays).Start();
        }

        //// ---------------------------Post Section---------------------------------

        private void buttonShare_Click(object sender, EventArgs e)
        {
            post();
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            m_PicturePath = getPicturePath();
            pictureBoxAddToPostReview.ImageLocation = m_PicturePath;
        }

        private void post()
        {
            try
            {
                string statusToPost = richTextBoxPost.Text;

                FacebookPost post = PostCreator.Create(statusToPost, m_PicturePath);
                post.Post();

                // Do after posting
                richTextBoxPost.Text = k_DefultTextForPost;
                pictureBoxAddToPostReview.ImageLocation = null;
                m_PicturePath = null;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }        
        }

        private string getPicturePath()
        {
            string picturePath = string.Empty;

            OpenFileDialog fileDialogPicture = new OpenFileDialog();
            fileDialogPicture.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (fileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                picturePath = fileDialogPicture.FileName;
            }

            fileDialogPicture.Dispose();

            return picturePath;
        }

        //// -------------------------Fetch Functions------------------------------

        private void fetchEvents()
        {
            try
            {
                this.labelMessageAboutEvent.Invoke(new Action(() => this.labelMessageAboutEvent.Visible = false));

                if (m_LoggedInUser.Events.Count == 0)
                {
                    this.labelMessageAboutEvent.Invoke(new Action(() => this.labelMessageAboutEvent.Text = "No Events to retrieve..."));
                    this.labelMessageAboutEvent.Invoke(new Action(() => this.labelMessageAboutEvent.Visible = true));
                }
                else
                {
                    var events = m_LoggedInUser.Events;
                    
                    Thread EventThread = new Thread(() => Utility.BindingTheDataBindingSourceToDataSourceAndInvoke(events, listBoxEvents, eventBindingSource));
                    EventThread.Start();
                }
            }
            catch
            {
                this.labelMessageAboutEvent.Invoke(new Action(() => this.labelMessageAboutEvent.Text = "No permision to events..."));
                this.labelMessageAboutEvent.Invoke(new Action(() => this.labelMessageAboutEvent.Visible = true));
            }
        }

        private void fetchFriends() 
        {
            this.labelFriendsNumber.Invoke(new Action(() => this.labelFriendsNumber.Text = m_LoggedInUser.Friends.Count().ToString()));

            var userFriends = m_LoggedInUser.Friends;

            Thread FriendsThread = new Thread(() => Utility.BindingTheDataBindingSourceToDataSourceAndInvoke(userFriends, this.listBoxFriends, userBindingSource));
            FriendsThread.Start();
        }

        private void fetchLikedPages() 
        {
            try
            {      
                this.labelMessageAboutPage.Invoke(new Action(() => this.labelMessageAboutPage.Visible = false));

                if (m_LoggedInUser.LikedPages.Count() == 0)
                {
                    new Thread(initializeDueToNoPagesData).Start();
                }
                else
                {
                    var pages = m_LoggedInUser.LikedPages;

                    Thread LikedPagesThread = new Thread(() => Utility.BindingTheDataBindingSourceToDataSourceAndInvoke(pages, listBoxLikes, pageBindingSource));
                    LikedPagesThread.Start(); 
                }
            }
            catch
            {
                this.labelMessageAboutPage.Invoke(new Action(() => this.labelMessageAboutPage.Text = "No permision to events..."));
                this.labelMessageAboutPage.Invoke(new Action(() => this.labelMessageAboutPage.Visible = true));
            }
        }

        private void fetchBirthDays()
        {
            int i_NumberOfBirthdayToday = 0;
            listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.DisplayMember = "Name"));

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.Birthday == DateTime.Now.ToString("M/d/yyyy"))
                {
                    listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Add(friend)));
                    i_NumberOfBirthdayToday++;
                }
            }

            if (i_NumberOfBirthdayToday == 0)
            {
                listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Add("No one of your friends have a birthday today")));
            }
        }

        private void fetchIntro()
        {
            addInfoToIntroListIfNotNullOrEmpty("Birthday", m_LoggedInUser.Birthday);
            addInfoToIntroListIfNotNullOrEmpty("Gender", m_LoggedInUser.Gender.ToString());
            addInfoToIntroListIfNotNullOrEmpty("Email", m_LoggedInUser.Email);
            addInfoToIntroListIfNotNullOrEmpty("In relationships with", m_LoggedInUser.RelationshipStatus.ToString());
        }

        //// -------------------------Others Functions------------------------------
        
        private void addInfoToIntroListIfNotNullOrEmpty(string i_Title, string i_Info)
        {
            string titleAndDataFormat = "{0} :   {1}";

            if (!string.IsNullOrEmpty(i_Info))
            {
                listBoxIntro.Invoke(new Action(() => listBoxIntro.Items.Add(string.Format(titleAndDataFormat, i_Title, i_Info))));
            }
        }

        private void initializeDueToNoPagesData()
        {
            this.labelPageName.Invoke(new Action(() => this.labelPageName.Text = "Not Have Pages"));
            this.labelLikesCount.Invoke(new Action(() => this.labelLikesCount.Text = "0"));
            this.labelCategory.Invoke(new Action(() => this.labelCategory.Text = "none"));
            this.labelWebsite.Invoke(new Action(() => this.labelWebsite.Text = "-"));
            this.richTextBoxDescription.Invoke(new Action(() => this.richTextBoxDescription.Text = "No information..."));
            this.labelMessageAboutPage.Invoke(new Action(() => this.labelMessageAboutPage.Text = "No liked Pages..."));
            this.labelMessageAboutPage.Invoke(new Action(() => this.labelMessageAboutPage.Visible = true));
            this.imageSquarePictureBoxPage.Invoke(new Action(() =>
            {
                this.imageSquarePictureBoxPage.ImageLocation = @"...\...\...\Images\noPicture.png";
            }));
        }

        ////------------------------------------------------------------------------
        
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            PoupulateUserDataFromFacebook();
        }
    }
}

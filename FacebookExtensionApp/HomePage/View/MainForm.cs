using System;
using System.Windows.Forms;
using System.Threading;
using FacebookExtensionApp.CommonUtils;
using FacebookExtensionApp.Settings;
using FacebookExtensionApp.TravelDiary.View;
using FacebookExtensionApp.SoulmateFounder.View;
using FacebookExtensionApp.HomePage.ViewModel;
using FacebookExtensionApp.HomePage.Model;
using FacebookWrapper;

namespace FacebookExtensionApp.HomePage.View
{
    public partial class MainForm : Form
    {
        private FacebookUser m_FacebookUser = FacebookUser.Instance;

        private AppSettings m_AppSettings;

        private HomePageForm m_HomePage;

        private TravelDiaryForm m_FormTravelDiary;

        private SoulmateFounderForm m_FormSoulmateFounder;

        private FormLogic m_FormLogic = new FormLogic();

        private IPictureDecorated m_RoundProfilePicture;

        public MainForm()
        {
            InitializeComponent();
            m_AppSettings = AppSettings.LoadFromFile();
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            m_RoundProfilePicture = new RoundEdgesPicture(new PictureCoreDecorated());

            initializeComponentAccordingToSetting();
            ResetAndDisableHomePage();
        }

        private class OpenFormFromMainFormPanelCommand : ICommand
        {
            public MainForm MainForm { get; set; }

            public Form FormToOpen { get; set; }

            public void Execute()
            {
                if (FormToOpen != null)
                {
                    MainForm.m_FormLogic.OpenFormFromPanel(FormToOpen, MainForm.panelWelcome);
                }
            }
        }

        //// ---------------------------Initialize Functions----------------------------

        private void initializeComponentAccordingToSetting()
        {
            if (m_AppSettings == null)
            {
                m_AppSettings = new AppSettings();
            }

            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
            this.m_FacebookUser.AccessToken = m_AppSettings.LastAccessToken;
        }

        private void initializeSubForms()
        {
            this.m_HomePage = new HomePageForm();
            this.m_FormTravelDiary = new TravelDiaryForm();
            this.m_FormSoulmateFounder = new SoulmateFounderForm();
        }

        private void InitializeButtonFeatureCommand()
        {
            this.buttonHome.FeatureCommand = new OpenFormFromMainFormPanelCommand { MainForm = this, FormToOpen = m_HomePage };
            this.buttonSoulmateFounder.FeatureCommand = new OpenFormFromMainFormPanelCommand { MainForm = this, FormToOpen = m_FormSoulmateFounder };
            this.buttonTravelDiary.FeatureCommand = new OpenFormFromMainFormPanelCommand { MainForm = this, FormToOpen = m_FormTravelDiary };
        }

        //// ---------------------------Functions according to Log In/Out-------------------------

        private void resetInfoAccordingToLogOutUser()
        {
            ResetAndDisableHomePage();
            updateAppSetting();
        }

        private void initializeComponentAccordingToLogIn()
        {
            // Check If the user login successfully
            if (m_FacebookUser.LogedIn)
            {
                new Thread(initializeDataAccordingToSuccessfullyLogedIn).Start();
            }
        }

        //// ---------------------------Others Functions---------------------------------

        private void initializeDataAccordingToSuccessfullyLogedIn()
        {
            new Thread(fetchBasicUserInfo).Start();
            initializeSubForms();
            InitializeButtonFeatureCommand();
            displayAndEnableHomePage();
            this.labelLoading.Invoke(new Action(() => this.labelLoading.Visible = false));
        }

        private void fetchBasicUserInfo()
        {
            this.labelUserName.Invoke(new Action(() => this.labelUserName.Text = m_FacebookUser.LogInUser.Name));
            this.Invoke(new Action(() => this.Text = m_FacebookUser.LogInUser.Name));  
            this.Invoke(new Action(() => m_RoundProfilePicture.ShowPicture(this.pictureBoxProfilePicture, m_FacebookUser.LogInUser.PictureLargeURL)));
        }

        private void displayAndEnableHomePage()
        {
            try
            {
                EnableApplication();
                m_FormLogic.OpenFormFromPanel(m_HomePage, this.panelWelcome);
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format(exception.Message));
            }
        }

        private void disableApplication()
        {
            this.buttonHome.Enabled = false;
            this.buttonSoulmateFounder.Enabled = false;
            this.buttonTravelDiary.Enabled = false;
            this.buttonLogIn.Visible = true;
            this.buttonLogOut.Visible = false;
        }

        private void EnableApplication()
        {
            this.buttonHome.Invoke(new Action(() => this.buttonHome.Enabled = true));
            this.buttonSoulmateFounder.Invoke(new Action(() => this.buttonSoulmateFounder.Enabled = true));
            this.buttonTravelDiary.Invoke(new Action(() => this.buttonTravelDiary.Enabled = true));
            this.buttonLogIn.Invoke(new Action(() => this.buttonLogIn.Visible = false));
            this.buttonLogOut.Invoke(new Action(() => this.buttonLogOut.Visible = true));
        }

        private void ResetAndDisableHomePage()
        {
            this.panelWelcome.Controls.Clear();
            this.panelWelcome.Controls.Add(this.labelWelcome);

            // The defult user values:
            this.pictureBoxProfilePicture.ImageLocation = @"...\...\...\Images\UnknownUser.jpeg";
            this.labelUserName.Text = "Facebook User";
            this.Text = "Facebook App";

            disableApplication();
        }

        private void updateAppSetting()
        {
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;

            if (m_AppSettings.RememberUser && m_FacebookUser.LogInResult != null)
            {
                m_AppSettings.LastAccessToken = m_FacebookUser.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null; // In Order to delete accessToken
                m_FacebookUser.LogOutFromFaceBook();
            }

            m_AppSettings.SaveToFile();
        }

        private void connectToFacebookAndInitializeData()
        {
            try
            {
                m_FacebookUser.ConnectToFacebook();
                initializeDataAccordingToSuccessfullyLogedIn();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Error: Could'nt connect to Facebook server...")));
            }
        }

        //// --------------------------Event Handler Functions-----------------------------

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            m_FacebookUser.LogOutFromFaceBook();
            resetInfoAccordingToLogOutUser();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.labelLoading.Visible = true;
            m_FacebookUser.LoginToFaceBook(AppSettings.k_AppID, m_AppSettings.R_Permissions);
            initializeComponentAccordingToLogIn();
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
        }

        //// ---------------------------Raises Event Functions---------------------------------

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                try
                {
                    this.labelLoading.Visible = true;
                    m_FacebookUser.AccessToken = m_AppSettings.LastAccessToken;
                    new Thread(connectToFacebookAndInitializeData).Start();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(string.Format(exception.Message));
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            updateAppSetting();
        }
    }
}

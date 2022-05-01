using System;
using FacebookWrapper;

namespace FacebookExtensionApp.CommonUtils
{
    public sealed class FacebookUser
    {
        private static volatile FacebookUser s_Instance;

        private static object s_FacebookUserCreationLock = new object();

        // Creation function that create the only instance of the class or return the exist instance
        public static FacebookUser Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_FacebookUserCreationLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookUser();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public LoginResult LogInResult { get; set; }

        public FacebookWrapper.ObjectModel.User LogInUser { get; set; }

        public bool LogedIn { get; set; }

        public string AccessToken { get; set; }

        // Private constractor in order no allow to create an instance of the class
        private FacebookUser()
        {
        }

        //// ---------------------------public Functions---------------------------------

        public void ConnectToFacebook()
        {
            if (!string.IsNullOrEmpty(AccessToken))
            {
                LogInResult = FacebookService.Connect(AccessToken);
                LogInUser = LogInResult.LoggedInUser;
                LogedIn = true;
            }
            else
            {
                LogedIn = false;
            }
        }

        public void LoginToFaceBook(string i_AppID, params string[] i_Permissions)
        {
            LogInResult = FacebookService.Login(i_AppID, i_Permissions);

            // Check If the user login successfully
            if (!string.IsNullOrEmpty(LogInResult.AccessToken))
            {
                LogInUser = LogInResult.LoggedInUser;
                LogedIn = true;
                AccessToken = LogInResult.AccessToken;
            }
            else
            {
                LogedIn = false;
                throw new Exception(LogInResult.ErrorMessage);
            }
        }

        public void LogOutFromFaceBook()
        {
            if (LogedIn)
            {
                FacebookService.Logout(logOutLogInResult);
                LogInResult = null;
            }
        }

        //// ---------------------------private Functions---------------------------------

        private void logOutLogInResult()
        {
            LogInResult = null;
            LogedIn = false;
        }
    }
}

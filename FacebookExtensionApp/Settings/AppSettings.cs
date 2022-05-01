using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookExtensionApp.Settings
{
    public class AppSettings
    {
        public const string k_AppID = "13413513134141";

        public readonly string[] R_Permissions =
        {
                "public_profile",
                "email",
                "publish_to_groups",
                "publish_pages",
                "manage_pages",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown",
                "user_photos",
        };

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(734, 659);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();

            if (File.Exists(@"...\...\...\saves\appSettingsForFacebook.xml"))
            {
                using (Stream stream = new FileStream(@"...\...\...\saves\appSettingsForFacebook.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = (AppSettings)serializer.Deserialize(stream);
                }
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            FileMode fileMode;

            fileMode = File.Exists(@"...\...\...\saves\appSettingsForFacebook.xml") ? FileMode.Truncate : FileMode.CreateNew;

            using (Stream stream = new FileStream(@"...\...\...\saves\appSettingsForFacebook.xml", fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}

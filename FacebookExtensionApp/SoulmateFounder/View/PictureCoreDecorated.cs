using System.Windows.Forms;

namespace FacebookExtensionApp.SoulmateFounder.View
{
    public class PictureCoreDecorated : IPictureDecorated
    {
        public void ShowPicture(PictureBox i_PictureBox, string i_UrlPath)
        {
            i_PictureBox.LoadAsync(i_UrlPath);
        }
    }
}

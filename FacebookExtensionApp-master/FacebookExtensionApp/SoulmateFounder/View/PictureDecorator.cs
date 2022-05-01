using System.Windows.Forms;

namespace FacebookExtensionApp.SoulmateFounder.View
{
    public class PictureDecorator : IPictureDecorated
    {
        protected IPictureDecorated m_PictureDecorated;

        public PictureDecorator(IPictureDecorated i_Decorated)
        {
            m_PictureDecorated = i_Decorated;
        }

        public virtual void ShowPicture(PictureBox i_PictureBox, string i_UrlPath)
        {
            m_PictureDecorated.ShowPicture(i_PictureBox, i_UrlPath);
        }
    }
}

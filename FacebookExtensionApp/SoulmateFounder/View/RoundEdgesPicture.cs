using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FacebookExtensionApp.SoulmateFounder.View
{
    public class RoundEdgesPicture : PictureDecorator
    {
        public RoundEdgesPicture(IPictureDecorated i_Decorated) :
                 base(i_Decorated)
        {
        }

        public override void ShowPicture(PictureBox i_PictureBox, string i_UrlPath)
        {
            m_PictureDecorated.ShowPicture(i_PictureBox, i_UrlPath);
            GraphicsPath GraphicPath = new GraphicsPath();
            GraphicPath.AddEllipse(i_PictureBox.DisplayRectangle);
            i_PictureBox.Region = new Region(GraphicPath);
        }
    }
}

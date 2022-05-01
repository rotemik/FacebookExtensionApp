using System;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookExtensionApp.SoulmateFounder.View
{
    public class FlickeringPicture : PictureDecorator
    {
        private const int m_MaxNumberOfBlinks = 6;

        private int m_BlinkCount = 0;

        private Timer m_Timer;

        private Color m_OldColor;

        private PictureBox m_PictureBox1;

        public FlickeringPicture(IPictureDecorated i_Decorated, PictureBox i_PictureBox) :
            base(i_Decorated)
        {
            this.m_Timer = new Timer();
            this.m_Timer.Tick += new EventHandler(timerTick);
            this.m_Timer.Interval = 400;
            m_PictureBox1 = i_PictureBox;
        }

        public override void ShowPicture(PictureBox i_PictureBox, string i_UrlPath)
        {
            m_PictureDecorated.ShowPicture(i_PictureBox, i_UrlPath);
            StartBlink();
        }

        public void StartBlink()
        {
            this.m_BlinkCount = 0;
            m_PictureBox1.Visible = true;
            this.m_OldColor = m_PictureBox1.ForeColor;
            m_PictureBox1.ForeColor = System.Drawing.Color.Purple;
            this.m_Timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            m_PictureBox1.Visible = !m_PictureBox1.Visible;
            this.m_BlinkCount++;
            if (this.m_BlinkCount >= m_MaxNumberOfBlinks)
            {
                this.m_Timer.Stop();
                m_PictureBox1.Visible = true;
                m_PictureBox1.ForeColor = m_OldColor;
            }
        }
    }
}

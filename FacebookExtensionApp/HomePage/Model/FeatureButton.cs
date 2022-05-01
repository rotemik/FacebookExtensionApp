using System;
using System.Windows.Forms;

namespace FacebookExtensionApp.HomePage.Model
{
    public class FeatureButton : Button
    {
        public ICommand FeatureCommand { get; set; }

        protected override void OnClick(EventArgs e)
        {
            if (FeatureCommand != null)
            {
                FeatureCommand.Execute();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace FacebookExtensionApp.HomePage.ViewModel
{
    public class FormLogic
    {
        public void OpenFormFromPanel(Form i_FormToOpen, Panel i_Panel)
        {
            i_Panel.Invoke(new Action(() => i_Panel.Controls.Clear()));
            addFormToThePanel(i_FormToOpen, i_Panel);
            i_FormToOpen.Invoke(new Action(() => i_FormToOpen.Show()));
        }

        private void addFormToThePanel(Form i_FormToAdd, Panel i_Panel)
        {
            // Page can be added to the panel just if it not Top level
            i_FormToAdd.TopLevel = false;
            i_Panel.Invoke(new Action(() => i_Panel.Controls.Add(i_FormToAdd)));
        }
    }
}

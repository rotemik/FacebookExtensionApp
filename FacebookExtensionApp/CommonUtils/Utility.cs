using System;
using System.Windows.Forms;

namespace FacebookExtensionApp.CommonUtils
{
    public static class Utility
    {
        public static void BindingTheDataBindingSourceToDataSourceAndInvoke(object i_DataSource, Control i_Control, BindingSource i_BindingSource)
        {
            if (!i_Control.InvokeRequired)
            {
                // Data binding: binding the data source of the binding source,to our data source
                i_BindingSource.DataSource = i_DataSource;
            }
            else
            {
                i_Control.Invoke(new Action(() => i_BindingSource.DataSource = i_DataSource));
            }
        }
    }
}

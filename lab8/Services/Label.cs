using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    [Serializable]
    public class Label
    {
        private static System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();

        public void TipTextBox(object sender, string message) 
        {
            System.Windows.Forms.TextBox TB = (System.Windows.Forms.TextBox)sender;
            tt.SetToolTip(TB, message);
        }
        public void TipButton(object sender, string message) 
        {
            System.Windows.Forms.Button TB = (System.Windows.Forms.Button)sender;
            tt.SetToolTip(TB, message);
        }
        public void TipListBox(object sender, string message)
        {
            System.Windows.Forms.ListBox TB = (System.Windows.Forms.ListBox)sender;
            tt.SetToolTip(TB, message);
        }
        public void TipComboBox(object sender, string message)
        {
            System.Windows.Forms.ComboBox TB = (System.Windows.Forms.ComboBox)sender;
            tt.SetToolTip(TB, message);
        }
        public void TipLabel(object sender, string message)
        {
            System.Windows.Forms.Label TB = (System.Windows.Forms.Label)sender;
            tt.SetToolTip(TB, message);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View.Tabs;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class MainForm : Form
    {
        Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
           
        }

        private void customersTab1_Load(object sender, EventArgs e)
        {

        }

        private void itemsTab1_Load(object sender, EventArgs e)
        {

        }

        private void cartsTab1_Load(object sender, EventArgs e)
        {

        }

       
    }
}

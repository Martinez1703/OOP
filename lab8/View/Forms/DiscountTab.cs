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

namespace WindowsFormsApp1.View.Tabs
{
    public partial class DiscountTab : Form
    {
        PercentDiscount PercentDiscount = new PercentDiscount();
        public List<Category> Categories = new List<Category>();
        public CustomersTab CustomersTabForm { get; set; }
        public DiscountTab()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Category));
            comboBox1.SelectedItem = null;
        }

        public List<Category> SelectedItem()
        {
            return Categories;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                PercentDiscount newD = new PercentDiscount((Category)comboBox1.SelectedItem);
                
                CustomersTabForm.newPer = newD;
                comboBox1.SelectedItem = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите скидку!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            this.Close();
        }
    }
}
